using SharpMetal.Metal;
using SharpMetal.Foundation;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace SharpMetal.ObjectiveCCore
{
    public readonly struct NSPoint
    {
        public readonly double X;
        public readonly double Y;

        public NSPoint(in double x, in double y)
        {
            X = x;
            Y = y;
        }
    }

    public readonly struct NSRect
    {
        public readonly NSPoint Pos;
        public readonly NSPoint Size;

        public NSRect(in double x, in double y, in double width, in double height)
        {
            Pos = new NSPoint(x, y);
            Size = new NSPoint(width, height);
        }
    }

    public static unsafe partial class ObjectiveCRuntime
    {
        public const string ObjcLibraryPath = "/usr/lib/libobjc.A.dylib";

        [LibraryImport("libdl.dylib", StringMarshalling = StringMarshalling.Utf8)]
        private static partial void dlopen(string path, int mode);

        [LibraryImport(ObjcLibraryPath, StringMarshalling = StringMarshalling.Utf8)]
        public static partial IntPtr objc_getClass(string name);

        [LibraryImport(ObjcLibraryPath)]
        public static partial IntPtr objc_allocateClassPair(IntPtr superclass, char* name, int extraBytes);

        [LibraryImport(ObjcLibraryPath)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool class_addMethod(IntPtr cls, Selector selector, IntPtr imp, char* types);

        [LibraryImport(ObjcLibraryPath)]
        public static partial void objc_registerClassPair(IntPtr cls);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "free")]
        public static partial void Free(IntPtr receiver);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "sel_registerName")]
        public static partial IntPtr sel_registerName(byte* namePtr);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "sel_getName")]
        public static partial byte* sel_getName(IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_getClass")]
        public static partial IntPtr objc_getClass(byte* namePtr);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "object_getClass")]
        public static partial ObjectiveCClass object_getClass(IntPtr obj);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "class_getProperty")]
        public static partial IntPtr class_getProperty(ObjectiveCClass cls, byte* namePtr);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "class_getName")]
        public static partial byte* class_getName(ObjectiveCClass cls);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "property_copyAttributeValue")]
        public static partial byte* property_copyAttributeValue(IntPtr property, byte* attributeNamePtr);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "method_getName")]
        public static partial Selector method_getName(ObjectiveCMethod method);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "class_copyMethodList")]
        public static partial ObjectiveCMethod* class_copyMethodList(ObjectiveCClass cls, out uint outCount);

        /*[LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, Selector selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, Selector selector, NSRect rect);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, Selector selector, byte value);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, Selector selector, double value);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, Selector selector, IntPtr ptr);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, Selector selector, ulong format, ulong index);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, Selector selector, NSRect rect, byte value);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, Selector selector, [MarshalAs(UnmanagedType.Bool)] bool value);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, Selector selector, long activationPolicy);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, Selector selector, char* buffer, ulong maxBufferCount, ulong encoding);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, Selector selector, NSRect rect, IntPtr value);*/

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, Selector selector, NSRect contentRect, ulong style, ulong backingStoreType, [MarshalAs(UnmanagedType.Bool)] bool flag);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, Selector selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend", StringMarshalling = StringMarshalling.Utf8)]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, Selector selector, string param);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend", StringMarshalling = StringMarshalling.Utf8)]
        public static partial string string_objc_msgSend(IntPtr receiver, Selector selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, Selector selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, Selector selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, NSRange c, NSRange d, MTLTextureSwizzleChannels e);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, uint a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, long a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, float a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, double a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.Bool)] bool a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, IntPtr b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ushort a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, [MarshalAs(UnmanagedType.Bool)] bool d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a, ulong b, IntPtr c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a, IntPtr b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, int a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a, float b, float c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c, IntPtr d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, long b, ref IntPtr c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, IntPtr c, ref IntPtr d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, ref IntPtr c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, NSRange a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ref IntPtr b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, NSRange c, NSRange d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr objc_msgSend(IntPtr receiver, IntPtr selector, CGSize a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr objc_msgSend(IntPtr receiver, IntPtr selector, CGRect a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, short a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ushort a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, [MarshalAs(UnmanagedType.Bool)] bool c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, byte a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, [MarshalAs(UnmanagedType.Bool)] bool d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, long b, IntPtr c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ushort b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, ulong c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLAccelerationStructureSizes MTLAccelerationStructureSizes_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLClearColor MTLClearColor_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLResourceID MTLResourceID_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLRegion MTLRegion_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial CGSize CGSize_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial CGRect CGRect_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLSize MTLSize_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLSize MTLSize_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLSize MTLSize_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLSize MTLSize_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, long d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLSizeAndAlign MTLSizeAndAlign_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLSizeAndAlign MTLSizeAndAlign_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLSizeAndAlign MTLSizeAndAlign_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLSizeAndAlign MTLSizeAndAlign_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial MTLTextureSwizzleChannels MTLTextureSwizzleChannels_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial NSOperatingSystemVersion NSOperatingSystemVersion_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial NSRange NSRange_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, NSOperatingSystemVersion a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, long a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ref IntPtr b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, ref IntPtr c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, ref IntPtr a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool bool_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial byte byte_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial double double_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial float float_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial float float_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial int int_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial long long_objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial long long_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial short short_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial uint uint_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSamplePosition a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector, long a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial ulong ulong_objc_msgSend(IntPtr receiver, IntPtr selector, NSFastEnumerationState a, IntPtr b, ulong c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial ushort ushort_objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial ushort ushort_objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial byte* bytePtr_objc_msgSend(IntPtr receiver, Selector selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, NSRange b, IntPtr c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, MTLSize c, MTLSize d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a, MTLSize b, MTLSize c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, float b, float c, NSRange d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, uint a, uint b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, float a, float b, float c, float d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLScissorRect a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, float a, float b, float c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, ulong f);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, MTLVertexAmplificationViewMapping b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLViewport a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLViewport a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, uint a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLScissorRect a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, IntPtr c, ulong d, IntPtr e, ulong f);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLRegion a, ulong b, IntPtr c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, MTLRegion c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLRegion a, ulong b, ulong c, IntPtr d, ulong e, ulong f);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, MTLRegion d, ulong e, ulong f);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLTextureSwizzleChannels a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, MTLRegion c, ulong d, ulong e);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, MTLRegion c, ulong d, ulong e, ulong f);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, double a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLClearColor a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, [MarshalAs(UnmanagedType.Bool)] bool a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, IntPtr b, ulong c, IntPtr d, ulong e, IntPtr f, ulong g);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, IntPtr f, ulong g, ulong h, ulong i);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, IntPtr b, ulong c, IntPtr d, ulong e);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, ulong f, ulong g);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, IntPtr b, ulong c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, float a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, long a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, MTLSize d, ulong e, ulong f, MTLOrigin g, IntPtr h, ulong i);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, MTLOrigin d, MTLSize e, IntPtr f, ulong g, ulong h, MTLOrigin i);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, ulong d, MTLSize e, IntPtr f, ulong g, ulong h, MTLOrigin i);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, ulong d, MTLSize e, IntPtr f, ulong g, ulong h, MTLOrigin i, ulong j);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, MTLOrigin d, MTLSize e, IntPtr f, ulong g, ulong h, ulong i);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, MTLOrigin d, MTLSize e, IntPtr f, ulong g, ulong h, ulong i, ulong j);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, NSRange b, byte c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, IntPtr d, ulong e, ulong f, ulong g, ulong h);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, IntPtr c, ulong d, ulong e);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, NSRange b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, MTLRegion b, ulong c, ulong d, [MarshalAs(UnmanagedType.Bool)] bool e, IntPtr f, ulong g);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLSize a, MTLSize b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLRegion a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, MTLRegion b, ulong c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, float b, float c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, NSRange d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, MTLSize c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, NSRange a);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLSamplePosition a, ulong b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, [MarshalAs(UnmanagedType.Bool)] bool c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c, IntPtr d, ulong e);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, IntPtr c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, NSRange b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, ulong f, long g, ulong h);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, ulong d, ulong e);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, IntPtr f, ulong g, ulong h, ulong i, IntPtr j, ulong k, ulong l);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, ulong a, ulong b, ulong c, IntPtr d, ulong e, ulong f, ulong g, IntPtr h, ulong i, ulong j);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, NSRange c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c, IntPtr d, ulong e);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, NSRange c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, IntPtr c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, ulong c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, ulong c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, ulong b, ulong c);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLRegion a, MTLRegion b, MTLSize c, ulong d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, MTLRegion a, MTLRegion b, MTLSize c, ulong d, ulong e);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c, IntPtr d, ulong e, ulong f);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, IntPtr selector, IntPtr a, IntPtr b, IntPtr c, NSRange d);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend_stret")]
        public static partial void objc_msgSend_stret(void* retPtr, IntPtr receiver, Selector selector);

        [LibraryImport(ObjcLibraryPath, EntryPoint = "objc_msgSend")]
        public static partial void objc_msgSend(IntPtr receiver, Selector selector, MTLCommandBufferHandler a);

        public static void Retain(in IntPtr receiver)
        {
            objc_msgSend(receiver, sel_retain);
        }

        public static void Release(in IntPtr receiver)
        {
            objc_msgSend(receiver, sel_release);
        }

        public static ulong GetRetainCount(in IntPtr receiver)
        {
            return ulong_objc_msgSend(receiver, sel_retainCount);
        }

        public static T objc_msgSend<T>(in IntPtr receiver, in Selector selector) where T : struct
        {
            IntPtr value = IntPtr_objc_msgSend(receiver, selector);
            return Unsafe.AsRef<T>(&value);
        }

        public static T objc_msgSend<T>(in IntPtr receiver, in Selector selector, in uint a) where T : struct
        {
            IntPtr value = IntPtr_objc_msgSend(receiver, selector, a);
            return Unsafe.AsRef<T>(&value);
        }

        public static T objc_msgSend<T>(in IntPtr receiver, in Selector selector, in IntPtr a) where T : struct
        {
            IntPtr value = IntPtr_objc_msgSend(receiver, selector, a);
            return Unsafe.AsRef<T>(&value);
        }

        public static T objc_msgSend_stret<T>(in IntPtr receiver, in Selector selector) where T : struct
        {
            T ret = default(T);
            objc_msgSend_stret(Unsafe.AsPointer(ref ret), receiver, selector);
            return ret;
        }

        public static string string_objc_msgSend(in IntPtr receiver, in Selector selector)
        {
            return objc_msgSend<NSString>(receiver, selector).ToString();
        }

        public static void LinkMetal()
        {
            dlopen("/System/Library/Frameworks/Metal.framework/Metal", 0);
        }

        public static void LinkCoreGraphics()
        {
            dlopen("/System/Library/Frameworks/CoreGraphics.framework/CoreGraphics", 0);
        }

        public static void LinkAppKit()
        {
            dlopen("/System/Library/Frameworks/AppKit.framework/AppKit", 0);
        }

        public static void LinkMetalKit()
        {
            dlopen("/System/Library/Frameworks/MetalKit.framework/MetalKit", 0);
        }

        private static readonly Selector sel_retain = "retain";
        private static readonly Selector sel_release = "release";
        private static readonly Selector sel_retainCount = "retainCount";
    }
}
