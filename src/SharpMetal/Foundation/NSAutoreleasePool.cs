using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public partial struct NSAutoreleasePool : IDisposable
    {
        public IntPtr NativePtr;

        public NSAutoreleasePool(in IntPtr ptr) => NativePtr = ptr;

        public static NSAutoreleasePool Begin() => s_class.AllocInit<NSAutoreleasePool>();

        public void Drain()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drain);
        }

        public void AddObject(NSObject pObject)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addObject, pObject);
        }

        public void Dispose()
        {
            ObjectiveCRuntime.Release(NativePtr);
        }

        public static void ShowPools()
        {
            throw new NotSupportedException();
        }

        public static implicit operator IntPtr(in NSAutoreleasePool obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(NSAutoreleasePool));
        private static readonly Selector sel_drain = "drain";
        private static readonly Selector sel_showPools = "showPools";
        private static readonly Selector sel_addObject = "addObject:";
    }
}
