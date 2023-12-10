using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;
using SharpMetal.Foundation;
using SharpMetal.Metal;
using SharpMetal.QuartzCore;
using System.Runtime.CompilerServices;

namespace SharpMetal.ObjectiveCCore
{
    public static unsafe partial class ObjectiveCRuntime
    {
        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, NSRange c, NSRange d, MTLTextureSwizzleChannels e);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, uint a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, long a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, float a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, double a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.Bool)] bool a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, IntPtr b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ushort a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, [MarshalAs(UnmanagedType.Bool)] bool d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a, ulong b, IntPtr c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a, IntPtr b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, int a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a, float b, float c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c, IntPtr d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, long b, ref IntPtr c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, IntPtr c, ref IntPtr d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, ref IntPtr c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, NSRange a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ref IntPtr b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, NSRange c, NSRange d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, short a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ushort a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, [MarshalAs(UnmanagedType.Bool)] bool c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, byte a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, [MarshalAs(UnmanagedType.Bool)] bool d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, long b, IntPtr c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ushort b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, ulong c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLAccelerationStructureSizes MTLAccelerationStructureSizes_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLClearColor MTLClearColor_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLResourceID MTLResourceID_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLRegion MTLRegion_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLSize MTLSize_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLSize MTLSize_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLSize MTLSize_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLSize MTLSize_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, long d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLSizeAndAlign MTLSizeAndAlign_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLSizeAndAlign MTLSizeAndAlign_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLSizeAndAlign MTLSizeAndAlign_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLSizeAndAlign MTLSizeAndAlign_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial MTLTextureSwizzleChannels MTLTextureSwizzleChannels_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial NSOperatingSystemVersion NSOperatingSystemVersion_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial NSRange NSRange_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, NSOperatingSystemVersion a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, long a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ref IntPtr b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, ref IntPtr c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, ref IntPtr a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial byte byte_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial double double_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial float float_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial int int_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial long long_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial long long_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial short short_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial uint uint_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSamplePosition a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector, long a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector, NSFastEnumerationState a, IntPtr b, ulong c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial ushort ushort_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial ushort ushort_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, NSRange b, IntPtr c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, MTLSize c, MTLSize d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a, MTLSize b, MTLSize c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, float b, float c, NSRange d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, uint a, uint b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, float a, float b, float c, float d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLScissorRect a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, float a, float b, float c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, ulong f);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, MTLVertexAmplificationViewMapping b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLViewport a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLViewport a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, uint a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLScissorRect a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, IntPtr c, ulong d, IntPtr e, ulong f);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLRegion a, ulong b, IntPtr c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, MTLRegion c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLRegion a, ulong b, ulong c, IntPtr d, ulong e, ulong f);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, MTLRegion d, ulong e, ulong f);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLTextureSwizzleChannels a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, MTLRegion c, ulong d, ulong e);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, MTLRegion c, ulong d, ulong e, ulong f);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, double a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLClearColor a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.Bool)] bool a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, IntPtr b, ulong c, IntPtr d, ulong e, IntPtr f, ulong g);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, IntPtr f, ulong g, ulong h, ulong i);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, IntPtr b, ulong c, IntPtr d, ulong e);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, ulong f, ulong g);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, IntPtr b, ulong c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, float a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, long a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, MTLSize d, ulong e, ulong f, MTLOrigin g, IntPtr h, ulong i);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, MTLOrigin d, MTLSize e, IntPtr f, ulong g, ulong h, MTLOrigin i);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, ulong d, MTLSize e, IntPtr f, ulong g, ulong h, MTLOrigin i);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, ulong d, MTLSize e, IntPtr f, ulong g, ulong h, MTLOrigin i, ulong j);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, MTLOrigin d, MTLSize e, IntPtr f, ulong g, ulong h, ulong i);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, MTLOrigin d, MTLSize e, IntPtr f, ulong g, ulong h, ulong i, ulong j);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, NSRange b, byte c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, IntPtr d, ulong e, ulong f, ulong g, ulong h);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, IntPtr c, ulong d, ulong e);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, NSRange b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, MTLRegion b, ulong c, ulong d, [MarshalAs(UnmanagedType.Bool)] bool e, IntPtr f, ulong g);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a, MTLSize b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLRegion a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, MTLRegion b, ulong c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, float b, float c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, NSRange d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, MTLSize c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, NSRange a);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLSamplePosition a, ulong b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, [MarshalAs(UnmanagedType.Bool)] bool c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, IntPtr d, ulong e);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, IntPtr c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, NSRange b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, ulong f, long g, ulong h);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, ulong d, ulong e);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, IntPtr f, ulong g, ulong h, ulong i, IntPtr j, ulong k, ulong l);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, ulong f, ulong g, IntPtr h, ulong i, ulong j);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, NSRange c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c, IntPtr d, ulong e);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, NSRange c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, IntPtr c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, ulong c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, ulong c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLRegion a, MTLRegion b, MTLSize c, ulong d);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLRegion a, MTLRegion b, MTLSize c, ulong d, ulong e);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c, IntPtr d, ulong e, ulong f);

        [LibraryImport(ObjectiveC.ObjCRuntime, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c, NSRange d);

        public static T objc_msgSend<T>(IntPtr receiver, Selector selector) where T : struct
        {
            IntPtr value = IntPtr_objc_msgSend(receiver, selector);
            return Unsafe.AsRef<T>(&value);
        }
        public static T objc_msgSend<T>(IntPtr receiver, Selector selector, uint a) where T : struct
        {
            IntPtr value = IntPtr_objc_msgSend(receiver, selector, a);
            return Unsafe.AsRef<T>(&value);
        }
        public static T objc_msgSend<T>(IntPtr receiver, Selector selector, IntPtr a) where T : struct
        {
            IntPtr value = IntPtr_objc_msgSend(receiver, selector, a);
            return Unsafe.AsRef<T>(&value);
        }
        public static string string_objc_msgSend(IntPtr receiver, Selector selector)
        {
            return objc_msgSend<NSString>(receiver, selector).GetValue();
        }

        [DllImport(ObjectiveC.ObjCRuntime)]
        public static extern IntPtr sel_registerName(byte* namePtr);

        [DllImport(ObjectiveC.ObjCRuntime)]
        public static extern byte* sel_getName(IntPtr selector);

        [DllImport(ObjectiveC.ObjCRuntime)]
        public static extern IntPtr objc_getClass(byte* namePtr);

        [DllImport(ObjectiveC.ObjCRuntime)]
        public static extern ObjectiveCClass object_getClass(IntPtr obj);

        [DllImport(ObjectiveC.ObjCRuntime)]
        public static extern IntPtr class_getProperty(ObjectiveCClass cls, byte* namePtr);

        [DllImport(ObjectiveC.ObjCRuntime)]
        public static extern byte* class_getName(ObjectiveCClass cls);

        [DllImport(ObjectiveC.ObjCRuntime)]
        public static extern byte* property_copyAttributeValue(IntPtr property, byte* attributeNamePtr);

        [DllImport(ObjectiveC.ObjCRuntime)]
        public static extern Selector method_getName(ObjectiveCMethod method);

        [DllImport(ObjectiveC.ObjCRuntime)]
        public static extern ObjectiveCMethod* class_copyMethodList(ObjectiveCClass cls, out uint outCount);

        [DllImport(ObjectiveC.ObjCRuntime)]
        public static extern void free(IntPtr receiver);

        public static void retain(IntPtr receiver) => objc_msgSend(receiver, sel_retain);

        public static void release(IntPtr receiver) => objc_msgSend(receiver, sel_release);

        public static ulong GetRetainCount(IntPtr receiver) => ulong_objc_msgSend(receiver, sel_retainCount);


        private static readonly Selector sel_retain = "retain";
        private static readonly Selector sel_release = "release";
        private static readonly Selector sel_retainCount = "retainCount";
    }
}
