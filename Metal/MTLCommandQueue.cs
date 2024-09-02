using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLCommandQueueDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLCommandQueueDescriptor obj) => obj.NativePtr;
        public MTLCommandQueueDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLLogState logState => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_logState));

        public ulong maxCommandBufferCount => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxCommandBufferCount);

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_logState = "logState";
        private static readonly Selector sel_maxCommandBufferCount = "maxCommandBufferCount";
    }

    public partial struct MTLCommandQueue
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLCommandQueue obj) => obj.NativePtr;
        public MTLCommandQueue(in IntPtr ptr) => NativePtr = ptr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public MTLCommandBuffer CommandBufferWithUnretainedReferences => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_commandBufferWithUnretainedReferences));

        public MTLCommandBuffer CommandBuffer(in MTLCommandBufferDescriptor descriptor)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_commandBufferWithDescriptor, descriptor));
        }

        public MTLCommandBuffer CommandBuffer()
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_commandBuffer));
        }

        public void InsertDebugCaptureBoundary()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_insertDebugCaptureBoundary);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_commandBuffer = "commandBuffer";
        private static readonly Selector sel_commandBufferWithDescriptor = "commandBufferWithDescriptor:";
        private static readonly Selector sel_commandBufferWithUnretainedReferences = "commandBufferWithUnretainedReferences";
        private static readonly Selector sel_insertDebugCaptureBoundary = "insertDebugCaptureBoundary";
    }
}
