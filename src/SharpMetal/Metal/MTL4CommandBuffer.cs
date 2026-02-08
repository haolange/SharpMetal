using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTL4CommandBufferOptions
    {
        public IntPtr NativePtr;

        public MTL4CommandBufferOptions(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4CommandBufferOptions New() => s_class.AllocInit<MTL4CommandBufferOptions>();

        public MTLLogState LogState
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_logState));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLogState, value);
        }

        public static implicit operator IntPtr(in MTL4CommandBufferOptions obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4CommandBufferOptions));
        private static readonly Selector sel_logState = "logState";
        private static readonly Selector sel_setLogState = "setLogState:";
    }

    public partial struct MTL4CommandBuffer
    {
        public IntPtr NativePtr;

        public MTL4CommandBuffer(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4CommandBuffer obj) => obj.NativePtr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public void BeginCommandBuffer(in MTL4CommandAllocator allocator)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_beginCommandBufferWithAllocator, allocator);
        }

        public void BeginCommandBuffer(in MTL4CommandAllocator allocator, in MTL4CommandBufferOptions options)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_beginCommandBufferWithAllocatoroptions, allocator, options);
        }

        public void EndCommandBuffer()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_endCommandBuffer);
        }

        public MTL4RenderCommandEncoder RenderCommandEncoder(in MTL4RenderPassDescriptor descriptor)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_renderCommandEncoderWithDescriptor, descriptor));
        }

        public MTL4RenderCommandEncoder RenderCommandEncoder(in MTL4RenderPassDescriptor descriptor, in ulong options)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_renderCommandEncoderWithDescriptoroptions, descriptor, options));
        }

        public MTL4ComputeCommandEncoder ComputeCommandEncoder()
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_computeCommandEncoder));
        }

        public MTL4MachineLearningCommandEncoder MachineLearningCommandEncoder()
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_machineLearningCommandEncoder));
        }

        public void UseResidencySet(in MTLResidencySet residencySet)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_useResidencySet, residencySet);
        }

        public void UseResidencySets(in IntPtr residencySets, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_useResidencySetscount, residencySets, count);
        }

        public void PushDebugGroup(in NSString nsString)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_pushDebugGroup, nsString);
        }

        public void PopDebugGroup()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_popDebugGroup);
        }

        public void WriteTimestampIntoHeap(in MTL4CounterHeap counterHeap, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_writeTimestampIntoHeapatIndex, counterHeap, index);
        }

        public void ResolveCounterHeap(in MTL4CounterHeap counterHeap, in NSRange range, in MTL4BufferRange bufferRange, in MTLFence fenceToWait, in MTLFence fenceToUpdate)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_resolveCounterHeapwithRangeintoBufferwaitFenceupdateFence, counterHeap, range, bufferRange.BufferAddress, bufferRange.Length, fenceToWait, fenceToUpdate);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_beginCommandBufferWithAllocator = "beginCommandBufferWithAllocator:";
        private static readonly Selector sel_beginCommandBufferWithAllocatoroptions = "beginCommandBufferWithAllocator:options:";
        private static readonly Selector sel_endCommandBuffer = "endCommandBuffer";
        private static readonly Selector sel_renderCommandEncoderWithDescriptor = "renderCommandEncoderWithDescriptor:";
        private static readonly Selector sel_renderCommandEncoderWithDescriptoroptions = "renderCommandEncoderWithDescriptor:options:";
        private static readonly Selector sel_computeCommandEncoder = "computeCommandEncoder";
        private static readonly Selector sel_machineLearningCommandEncoder = "machineLearningCommandEncoder";
        private static readonly Selector sel_useResidencySet = "useResidencySet:";
        private static readonly Selector sel_useResidencySetscount = "useResidencySets:count:";
        private static readonly Selector sel_pushDebugGroup = "pushDebugGroup:";
        private static readonly Selector sel_popDebugGroup = "popDebugGroup";
        private static readonly Selector sel_writeTimestampIntoHeapatIndex = "writeTimestampIntoHeap:atIndex:";
        private static readonly Selector sel_resolveCounterHeapwithRangeintoBufferwaitFenceupdateFence = "resolveCounterHeap:withRange:intoBuffer:waitFence:updateFence:";
    }
}
