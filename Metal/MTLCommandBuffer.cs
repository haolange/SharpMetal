using System;
using System.Runtime.InteropServices;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLCommandBuffer
    {
        public readonly IntPtr NativePtr;

        public MTLCommandBuffer(in IntPtr ptr) => NativePtr = ptr;

        public MTLCommandBufferStatus status => (MTLCommandBufferStatus)uint_objc_msgSend(NativePtr, sel_status);

        public MTLBlitCommandEncoder blitCommandEncoder() => objc_msgSend<MTLBlitCommandEncoder>(NativePtr, sel_blitCommandEncoder);

        public MTLComputeCommandEncoder computeCommandEncoder() => objc_msgSend<MTLComputeCommandEncoder>(NativePtr, sel_computeCommandEncoder);

        public MTLRenderCommandEncoder renderCommandEncoderWithDescriptor(in MTLRenderPassDescriptor desc) => new MTLRenderCommandEncoder(IntPtr_objc_msgSend(NativePtr, sel_renderCommandEncoderWithDescriptor, desc.NativePtr));

        public void enqueue() { }

        public void commit() => objc_msgSend(NativePtr, sel_commit);

        public void addScheduledHandler(in IntPtr block) { }

        public void addScheduledHandler(MTLCommandBufferHandler block) { }

        public void waitUntilScheduled() { }

        public void addCompletedHandler(in IntPtr block) => objc_msgSend(NativePtr, sel_addCompletedHandler, block);

        public void addCompletedHandler(MTLCommandBufferHandler block) => objc_msgSend(NativePtr, sel_addCompletedHandler, block);

        public void waitUntilCompleted() => objc_msgSend(NativePtr, sel_waitUntilCompleted);

        public void presentDrawable(in IntPtr drawable) => objc_msgSend(NativePtr, sel_presentDrawable, drawable);

        private static readonly Selector sel_status = "status";
        private static readonly Selector sel_blitCommandEncoder = "blitCommandEncoder";
        private static readonly Selector sel_computeCommandEncoder = "computeCommandEncoder";
        private static readonly Selector sel_renderCommandEncoderWithDescriptor = "renderCommandEncoderWithDescriptor:";
        private static readonly Selector sel_commit = "commit";
        private static readonly Selector sel_addCompletedHandler = "addCompletedHandler:";
        private static readonly Selector sel_waitUntilCompleted = "waitUntilCompleted";
        private static readonly Selector sel_presentDrawable = "presentDrawable:";
    }
}