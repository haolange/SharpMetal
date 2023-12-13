using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public partial struct NSAutoreleasePool : IDisposable
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSAutoreleasePool obj) => obj.NativePtr;
        public NSAutoreleasePool(in IntPtr ptr) => NativePtr = ptr;

        public static NSAutoreleasePool Begin()
        {
            var cls = new ObjectiveCClass("NSAutoreleasePool");
            return new NSAutoreleasePool(cls.AllocInit());
        }

        public void Drain()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drain);
        }

        public void AddObject(NSObject pObject)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addObject, pObject);
        }

        public static void ShowPools()
        {
            throw new NotSupportedException();
        }

        public void Dispose()
        {
            ObjectiveCRuntime.release(NativePtr);
        }

        private static readonly Selector sel_drain = "drain";
        private static readonly Selector sel_showPools = "showPools";
        private static readonly Selector sel_addObject = "addObject:";
    }
}
