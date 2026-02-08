using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTL4ComputePipelineDescriptor
    {
        public IntPtr NativePtr;

        public MTL4ComputePipelineDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4ComputePipelineDescriptor New() => s_class.AllocInit<MTL4ComputePipelineDescriptor>();

        public static implicit operator MTL4PipelineDescriptor(in MTL4ComputePipelineDescriptor obj) => new(obj.NativePtr);

        public MTL4FunctionDescriptor ComputeFunctionDescriptor
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_computeFunctionDescriptor));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setComputeFunctionDescriptor, value);
        }

        public bool ThreadGroupSizeIsMultipleOfThreadExecutionWidth
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_threadGroupSizeIsMultipleOfThreadExecutionWidth);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setThreadGroupSizeIsMultipleOfThreadExecutionWidth, value);
        }

        public ulong MaxTotalThreadsPerThreadgroup
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxTotalThreadsPerThreadgroup);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMaxTotalThreadsPerThreadgroup, value);
        }

        public MTLSize RequiredThreadsPerThreadgroup
        {
            get => ObjectiveCRuntime.MTLSize_objc_msgSend(NativePtr, sel_requiredThreadsPerThreadgroup);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRequiredThreadsPerThreadgroup, value);
        }

        public bool SupportBinaryLinking
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_supportBinaryLinking);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSupportBinaryLinking, value);
        }

        public MTL4StaticLinkingDescriptor StaticLinkingDescriptor
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_staticLinkingDescriptor));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStaticLinkingDescriptor, value);
        }

        public MTL4IndirectCommandBufferSupportState SupportIndirectCommandBuffers
        {
            get => (MTL4IndirectCommandBufferSupportState)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_supportIndirectCommandBuffers);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSupportIndirectCommandBuffers, (long)value);
        }

        public void Reset()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_reset);
        }

        public static implicit operator IntPtr(in MTL4ComputePipelineDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4ComputePipelineDescriptor));
        private static readonly Selector sel_computeFunctionDescriptor = "computeFunctionDescriptor";
        private static readonly Selector sel_setComputeFunctionDescriptor = "setComputeFunctionDescriptor:";
        private static readonly Selector sel_threadGroupSizeIsMultipleOfThreadExecutionWidth = "threadGroupSizeIsMultipleOfThreadExecutionWidth";
        private static readonly Selector sel_setThreadGroupSizeIsMultipleOfThreadExecutionWidth = "setThreadGroupSizeIsMultipleOfThreadExecutionWidth:";
        private static readonly Selector sel_maxTotalThreadsPerThreadgroup = "maxTotalThreadsPerThreadgroup";
        private static readonly Selector sel_setMaxTotalThreadsPerThreadgroup = "setMaxTotalThreadsPerThreadgroup:";
        private static readonly Selector sel_requiredThreadsPerThreadgroup = "requiredThreadsPerThreadgroup";
        private static readonly Selector sel_setRequiredThreadsPerThreadgroup = "setRequiredThreadsPerThreadgroup:";
        private static readonly Selector sel_supportBinaryLinking = "supportBinaryLinking";
        private static readonly Selector sel_setSupportBinaryLinking = "setSupportBinaryLinking:";
        private static readonly Selector sel_staticLinkingDescriptor = "staticLinkingDescriptor";
        private static readonly Selector sel_setStaticLinkingDescriptor = "setStaticLinkingDescriptor:";
        private static readonly Selector sel_supportIndirectCommandBuffers = "supportIndirectCommandBuffers";
        private static readonly Selector sel_setSupportIndirectCommandBuffers = "setSupportIndirectCommandBuffers:";
        private static readonly Selector sel_reset = "reset";
    }
}
