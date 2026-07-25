using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SharpMetal.ObjectiveCCore
{
    /// <summary>
    /// Minimal Objective-C block trampoline for async Metal callbacks.
    /// Raw C# function pointers are not ObjC blocks; passing them to
    /// addFeedbackHandler: / addPresentedHandler: crashes with PAC faults.
    /// </summary>
    internal static unsafe partial class ObjectiveCBlock
    {
        private const int BlockHasCopyDispose = 1 << 25;
        private const int BlockHasSignature = 1 << 30;

        private static readonly IntPtr s_ConcreteStackBlock = ResolveSymbol("_NSConcreteStackBlock");
        private static readonly delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void> s_Invoke = &InvokeObjectHandler;
        private static readonly delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void> s_CopyHelper = &CopyHelper;
        private static readonly delegate* unmanaged[Cdecl]<IntPtr, void> s_DisposeHelper = &DisposeHelper;
        private static readonly IntPtr s_DescriptorPtr = CreateDescriptor();

        public static IntPtr CopyObjectHandler(Action<IntPtr, IntPtr> handler)
        {
            ArgumentNullException.ThrowIfNull(handler);

            NativeBlockLiteral literal = default;
            literal.Isa = s_ConcreteStackBlock;
            literal.Flags = BlockHasCopyDispose | BlockHasSignature;
            literal.Reserved = 0;
            literal.Invoke = (IntPtr)s_Invoke;
            literal.Descriptor = s_DescriptorPtr;
            literal.Context = GCHandle.ToIntPtr(GCHandle.Alloc(handler));

            IntPtr copied = BlockCopy((IntPtr)(&literal));
            if (copied == IntPtr.Zero)
            {
                GCHandle.FromIntPtr(literal.Context).Free();
                throw new InvalidOperationException("Failed to copy Objective-C block.");
            }

            // CopyHelper duplicated the GCHandle into the heap block.
            GCHandle.FromIntPtr(literal.Context).Free();
            return copied;
        }

        public static void Release(IntPtr block)
        {
            if (block != IntPtr.Zero)
            {
                BlockRelease(block);
            }
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static void InvokeObjectHandler(IntPtr block, IntPtr argument)
        {
            NativeBlockLiteral* literal = (NativeBlockLiteral*)block;
            if (literal->Context == IntPtr.Zero)
            {
                return;
            }

            GCHandle handle = GCHandle.FromIntPtr(literal->Context);
            if (handle.Target is Action<IntPtr, IntPtr> action)
            {
                action(block, argument);
            }
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static void CopyHelper(IntPtr dst, IntPtr src)
        {
            NativeBlockLiteral* destination = (NativeBlockLiteral*)dst;
            NativeBlockLiteral* source = (NativeBlockLiteral*)src;
            if (source->Context == IntPtr.Zero)
            {
                destination->Context = IntPtr.Zero;
                return;
            }

            GCHandle original = GCHandle.FromIntPtr(source->Context);
            destination->Context = GCHandle.ToIntPtr(GCHandle.Alloc(original.Target));
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static void DisposeHelper(IntPtr src)
        {
            NativeBlockLiteral* source = (NativeBlockLiteral*)src;
            if (source->Context == IntPtr.Zero)
            {
                return;
            }

            GCHandle.FromIntPtr(source->Context).Free();
            source->Context = IntPtr.Zero;
        }

        private static IntPtr CreateDescriptor()
        {
            // void (^)(id) on arm64
            ReadOnlySpan<byte> signature = "v16@?0@8\0"u8;
            IntPtr signaturePtr = Marshal.AllocHGlobal(signature.Length);
            signature.CopyTo(new Span<byte>((void*)signaturePtr, signature.Length));

            NativeBlockDescriptor* descriptor =
                (NativeBlockDescriptor*)NativeMemory.Alloc((nuint)sizeof(NativeBlockDescriptor));
            descriptor->Reserved = 0;
            descriptor->Size = (ulong)sizeof(NativeBlockLiteral);
            descriptor->CopyHelper = (IntPtr)s_CopyHelper;
            descriptor->DisposeHelper = (IntPtr)s_DisposeHelper;
            descriptor->Signature = signaturePtr;
            return (IntPtr)descriptor;
        }

        private static IntPtr ResolveSymbol(string name)
        {
            IntPtr handle = DlOpen("/usr/lib/libSystem.B.dylib", 0);
            if (handle == IntPtr.Zero)
            {
                throw new InvalidOperationException("Failed to open libSystem.B.dylib.");
            }

            IntPtr symbol = DlSym(handle, name);
            if (symbol == IntPtr.Zero)
            {
                throw new InvalidOperationException($"Failed to resolve symbol '{name}'.");
            }

            return symbol;
        }

        [LibraryImport("libSystem.B.dylib", EntryPoint = "_Block_copy")]
        private static partial IntPtr BlockCopy(IntPtr block);

        [LibraryImport("libSystem.B.dylib", EntryPoint = "_Block_release")]
        private static partial void BlockRelease(IntPtr block);

        [LibraryImport("libdl.dylib", EntryPoint = "dlopen", StringMarshalling = StringMarshalling.Utf8)]
        private static partial IntPtr DlOpen(string path, int mode);

        [LibraryImport("libdl.dylib", EntryPoint = "dlsym", StringMarshalling = StringMarshalling.Utf8)]
        private static partial IntPtr DlSym(IntPtr handle, string symbol);

        [StructLayout(LayoutKind.Sequential)]
        private struct NativeBlockLiteral
        {
            public IntPtr Isa;
            public int Flags;
            public int Reserved;
            public IntPtr Invoke;
            public IntPtr Descriptor;
            public IntPtr Context;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct NativeBlockDescriptor
        {
            public ulong Reserved;
            public ulong Size;
            public IntPtr CopyHelper;
            public IntPtr DisposeHelper;
            public IntPtr Signature;
        }
    }
}
