using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLCommandQueueDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLCommandQueueDescriptor obj) => obj.NativePtr;

        public MTLCommandQueueDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLCommandQueueDescriptor New() => s_class.AllocInit<MTLCommandQueueDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLCommandQueueDescriptor));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLLogState LogState
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_logState));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLogState, value);
        }

        public ulong MaxCommandBufferCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxCommandBufferCount);
            set => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_setMaxCommandBufferCount, value);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_logState = "logState";
        private static readonly Selector sel_setLogState = "setLogState:";
        private static readonly Selector sel_maxCommandBufferCount = "maxCommandBufferCount";
        private static readonly Selector sel_setMaxCommandBufferCount = "setMaxCommandBufferCount:";
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

        public void AddResidencySet(in MTLResidencySet residencySet)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addResidencySet, residencySet);
        }

        public void AddResidencySets(in IntPtr residencySets, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addResidencySets, residencySets, (ulong)count);
        }

        public void RemoveResidencySet(in MTLResidencySet residencySet)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_removeResidencySet, residencySet);
        }

        public void RemoveResidencySets(in IntPtr residencySets, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_removeResidencySets, residencySets, (ulong)count);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_commandBuffer = "commandBuffer";
        private static readonly Selector sel_commandBufferWithDescriptor = "commandBufferWithDescriptor:";
        private static readonly Selector sel_commandBufferWithUnretainedReferences = "commandBufferWithUnretainedReferences";
        private static readonly Selector sel_insertDebugCaptureBoundary = "insertDebugCaptureBoundary";

        private static readonly Selector sel_addResidencySet = "addResidencySet";
        private static readonly Selector sel_addResidencySets = "addResidencySets:count:";
        private static readonly Selector sel_removeResidencySet = "removeResidencySet";
        private static readonly Selector sel_removeResidencySets = "removeResidencySets:count:";
    }
}
