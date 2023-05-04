using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public struct MTLComputePipelineDescriptor
    {
        public readonly IntPtr NativePtr;

        public MTLFunction computeFunction
        {
            get => objc_msgSend<MTLFunction>(NativePtr, sel_computeFunction);
            set => objc_msgSend(NativePtr, sel_setComputeFunction, value.NativePtr);
        }

        public MTLPipelineBufferDescriptorArray buffers => objc_msgSend<MTLPipelineBufferDescriptorArray>(NativePtr, sel_buffers);

        private static readonly Selector sel_buffers = "buffers";
        private static readonly Selector sel_computeFunction = "computeFunction";
        private static readonly Selector sel_setComputeFunction = "setComputeFunction:";
    }
}