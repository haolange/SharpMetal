using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public partial struct NSLocking
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSLocking obj) => obj.NativePtr;
        public NSLocking(in IntPtr ptr) => NativePtr = ptr;
    }

    public partial struct NSCondition
    {
        public IntPtr NativePtr;

        public NSCondition(in IntPtr ptr) => NativePtr = ptr;

        public static NSCondition New() => s_class.AllocInit<NSCondition>();

        public void Wait()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_wait);
        }

        public bool WaitUntilDate(in NSDate pLimit)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_waitUntilDate, pLimit);
        }

        public void Signal()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_signal);
        }

        public void Broadcast()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_broadcast);
        }

        public static implicit operator IntPtr(in NSCondition obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(NSCondition));
        private static readonly Selector sel_wait = "wait";
        private static readonly Selector sel_waitUntilDate = "waitUntilDate:";
        private static readonly Selector sel_signal = "signal";
        private static readonly Selector sel_broadcast = "broadcast";
    }
}
