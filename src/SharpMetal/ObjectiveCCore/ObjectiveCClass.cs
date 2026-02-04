using System.Text;
using SharpMetal.Foundation;
using System.Runtime.CompilerServices;

namespace SharpMetal.ObjectiveCCore
{
    public struct ObjectiveCMethod
    {
        public readonly IntPtr NativePtr;
        public ObjectiveCMethod(in IntPtr ptr) => NativePtr = ptr;
        public static implicit operator IntPtr(in ObjectiveCMethod method) => method.NativePtr;
        public static implicit operator ObjectiveCMethod(in IntPtr ptr) => new ObjectiveCMethod(ptr);

        public Selector GetSelector() => ObjectiveCRuntime.method_getName(this);
        public string GetName() => GetSelector().Name;
    }

    public unsafe struct ObjectiveCClass
    {
        public readonly IntPtr NativePtr;
        public static implicit operator IntPtr(in ObjectiveCClass c) => c.NativePtr;

        public string Name => NSUtil.GetUtf8String(ObjectiveCRuntime.class_getName(this));

        public ObjectiveCClass(in IntPtr ptr)
        {
            NativePtr = ptr;
        }

        public ObjectiveCClass(string name)
        {
            var ptr = ObjectiveCRuntime.objc_getClass(name);

            if (ptr == IntPtr.Zero)
            {
                Console.WriteLine($"Failed to get class {name}!");
            }

            NativePtr = ptr;
        }

        public IntPtr GetProperty(string propertyName)
        {
            int byteCount = Encoding.UTF8.GetMaxByteCount(propertyName.Length);
            byte* utf8BytesPtr = stackalloc byte[byteCount];
            fixed (char* namePtr = propertyName)
            {
                Encoding.UTF8.GetBytes(namePtr, propertyName.Length, utf8BytesPtr, byteCount);
            }

            return ObjectiveCRuntime.class_getProperty(this, utf8BytesPtr);
        }

        public ObjectiveCClass Alloc()
        {
            var value = ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_alloc);
            return new ObjectiveCClass(value);
        }

        public ObjectiveCClass AllocInit()
        {
            var value = ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_alloc);
            ObjectiveCRuntime.objc_msgSend(value, sel_init);
            return new ObjectiveCClass(value);
        }

        public T Alloc<T>() where T : struct
        {
            IntPtr value = ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_alloc);
            return Unsafe.AsRef<T>(&value);
        }

        public T AllocInit<T>() where T : struct
        {
            IntPtr value = ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_alloc);
            ObjectiveCRuntime.objc_msgSend(value, sel_init);
            return Unsafe.AsRef<T>(&value);
        }

        public ObjectiveCMethod* class_copyMethodList(out uint count)
        {
            return ObjectiveCRuntime.class_copyMethodList(this, out count);
        }

        private static readonly Selector sel_alloc = "alloc";
        private static readonly Selector sel_init = "init";
    }
}
