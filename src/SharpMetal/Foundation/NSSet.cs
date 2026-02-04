using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public partial struct NSSet
    {
        public IntPtr NativePtr;

        public NSSet(in IntPtr ptr) => NativePtr = ptr;

        public static NSSet New() => s_class.AllocInit<NSSet>();

        public ulong Count => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_count);

        public IntPtr ObjectEnumerator => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectEnumerator));

        public NSSet Init(in NSObject pObjects, in ulong count)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithObjectscount, pObjects, count));
        }

        public NSSet Init(in IntPtr pCoder)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithCoder, pCoder));
        }

        public static implicit operator IntPtr(in NSSet obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(NSSet));
        private static readonly Selector sel_count = "count";
        private static readonly Selector sel_objectEnumerator = "objectEnumerator";
        private static readonly Selector sel_initWithObjectscount = "initWithObjects:count:";
        private static readonly Selector sel_initWithCoder = "initWithCoder:";
    }
}
