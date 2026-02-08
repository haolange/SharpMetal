using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTL4CommandAllocatorDescriptor
    {
        public IntPtr NativePtr;

        public MTL4CommandAllocatorDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4CommandAllocatorDescriptor New() => s_class.AllocInit<MTL4CommandAllocatorDescriptor>();

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public static implicit operator IntPtr(in MTL4CommandAllocatorDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4CommandAllocatorDescriptor));
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
    }

    public partial struct MTL4CommandAllocator
    {
        public IntPtr NativePtr;

        public MTL4CommandAllocator(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4CommandAllocator obj) => obj.NativePtr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));

        public ulong AllocatedSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_allocatedSize);

        public void Reset()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_reset);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_allocatedSize = "allocatedSize";
        private static readonly Selector sel_reset = "reset";
    }
}
