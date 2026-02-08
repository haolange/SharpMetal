using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTL4VisibilityOptions : ulong
    {
        None = 0,
        Device = 1,
        ResourceAlias = 2,
    }

    public partial struct MTL4CommandEncoder
    {
        public IntPtr NativePtr;

        public MTL4CommandEncoder(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4CommandEncoder obj) => obj.NativePtr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTL4CommandBuffer CommandBuffer => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_commandBuffer));

        public void BarrierAfterQueueStages(in ulong afterQueueStages, in ulong beforeStages, in MTL4VisibilityOptions visibilityOptions)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_barrierAfterQueueStagesbeforeStagesvisibilityOptions, afterQueueStages, beforeStages, (ulong)visibilityOptions);
        }

        public void BarrierAfterStages(in ulong afterStages, in ulong beforeQueueStages, in MTL4VisibilityOptions visibilityOptions)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_barrierAfterStagesbeforeQueueStagesvisibilityOptions, afterStages, beforeQueueStages, (ulong)visibilityOptions);
        }

        public void BarrierAfterEncoderStages(in ulong afterEncoderStages, in ulong beforeEncoderStages, in MTL4VisibilityOptions visibilityOptions)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_barrierAfterEncoderStagesbeforeEncoderStagesvisibilityOptions, afterEncoderStages, beforeEncoderStages, (ulong)visibilityOptions);
        }

        public void UpdateFence(in MTLFence fence, in ulong afterEncoderStages)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_updateFenceafterEncoderStages, fence, afterEncoderStages);
        }

        public void WaitForFence(in MTLFence fence, in ulong beforeEncoderStages)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_waitForFencebeforeEncoderStages, fence, beforeEncoderStages);
        }

        public void InsertDebugSignpost(in NSString nsString)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_insertDebugSignpost, nsString);
        }

        public void PushDebugGroup(in NSString nsString)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_pushDebugGroup, nsString);
        }

        public void PopDebugGroup()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_popDebugGroup);
        }

        public void EndEncoding()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_endEncoding);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_commandBuffer = "commandBuffer";
        private static readonly Selector sel_barrierAfterQueueStagesbeforeStagesvisibilityOptions = "barrierAfterQueueStages:beforeStages:visibilityOptions:";
        private static readonly Selector sel_barrierAfterStagesbeforeQueueStagesvisibilityOptions = "barrierAfterStages:beforeQueueStages:visibilityOptions:";
        private static readonly Selector sel_barrierAfterEncoderStagesbeforeEncoderStagesvisibilityOptions = "barrierAfterEncoderStages:beforeEncoderStages:visibilityOptions:";
        private static readonly Selector sel_updateFenceafterEncoderStages = "updateFence:afterEncoderStages:";
        private static readonly Selector sel_waitForFencebeforeEncoderStages = "waitForFence:beforeEncoderStages:";
        private static readonly Selector sel_insertDebugSignpost = "insertDebugSignpost:";
        private static readonly Selector sel_pushDebugGroup = "pushDebugGroup:";
        private static readonly Selector sel_popDebugGroup = "popDebugGroup";
        private static readonly Selector sel_endEncoding = "endEncoding";
    }
}
