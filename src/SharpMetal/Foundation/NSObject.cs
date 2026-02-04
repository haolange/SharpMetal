using System.Text;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public enum NSComparisonResult : long
    {
        OrderedAscending = -1L,
        OrderedSame,
        OrderedDescending,
    }

    public partial struct NS_NS_EXPORT
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NS_NS_EXPORT obj) => obj.NativePtr;
        public NS_NS_EXPORT(in IntPtr ptr) => NativePtr = ptr;
    }

    public partial struct NSCopying
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSCopying obj) => obj.NativePtr;
        public NSCopying(in IntPtr ptr) => NativePtr = ptr;
    }

    public partial struct NSSecureCoding
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSSecureCoding obj) => obj.NativePtr;
        public NSSecureCoding(in IntPtr ptr) => NativePtr = ptr;
    }

    public static class NSUtil
    {
        public static unsafe string GetUtf8String(byte* stringStart)
        {
            int characters = 0;
            while (stringStart[characters] != 0)
            {
                characters++;
            }

            return Encoding.UTF8.GetString(stringStart, characters);
        }
    }

    public partial struct NSObject
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSObject obj) => obj.NativePtr;
        public NSObject(in IntPtr ptr) => NativePtr = ptr;

        public ulong Hash => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_hash);

        public NSString Description => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_description));

        public NSString DebugDescription => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_debugDescription));

        public bool IsEqual(in NSObject pObject)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isEqual, pObject);
        }

        public bool IsKindOfClass(in IntPtr pObject)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isKindOfClass, pObject);
        }

        private static readonly Selector sel_methodSignatureForSelector = "methodSignatureForSelector:";
        private static readonly Selector sel_respondsToSelector = "respondsToSelector:";
        private static readonly Selector sel_alloc = "alloc";
        private static readonly Selector sel_init = "init";
        private static readonly Selector sel_hash = "hash";
        private static readonly Selector sel_isEqual = "isEqual:";
        private static readonly Selector sel_description = "description";
        private static readonly Selector sel_debugDescription = "debugDescription";
        private static readonly Selector sel_isKindOfClass = "isKindOfClass:";
    }
}
