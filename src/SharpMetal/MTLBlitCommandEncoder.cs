using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public struct MTLBlitCommandEncoder
    {
        public readonly IntPtr NativePtr;
        public bool IsNull => NativePtr == IntPtr.Zero;

        public void copyFromBuffer(in MTLBuffer sourceBuffer, in UIntPtr sourceOffset, in MTLBuffer destinationBuffer, in UIntPtr destinationOffset, in UIntPtr size)
        {
            objc_msgSend(NativePtr, sel_copyFromBuffer0, sourceBuffer, sourceOffset, destinationBuffer, destinationOffset, size);
        }

        public void copyFromBuffer(in MTLBuffer sourceBuffer, in UIntPtr sourceOffset, in UIntPtr sourceBytesPerRow, in UIntPtr sourceBytesPerImage, in MTLSize sourceSize, in MTLTexture destinationTexture, in UIntPtr destinationSlice, in UIntPtr destinationLevel, in MTLOrigin destinationOrigin)
        {
            objc_msgSend(NativePtr, sel_copyFromBuffer1, sourceBuffer.NativePtr, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture.NativePtr, destinationSlice, destinationLevel, destinationOrigin);
        }

        public void copyFromTexture(in MTLTexture sourceTexture, in MTLTexture destinationTexture)
        {
            objc_msgSend(NativePtr, sel_copyFromTexture0, sourceTexture, destinationTexture);
        }

        public void copyFromTexture(in MTLTexture sourceTexture, in UIntPtr sourceSlice, in UIntPtr sourceLevel, in MTLTexture destinationTexture, in UIntPtr destinationSlice, in UIntPtr destinationLevel, in UIntPtr sliceCount, in UIntPtr levelCount)
        {
            objc_msgSend(NativePtr, sel_copyFromTexture1, sourceTexture, sourceSlice, sourceLevel, destinationTexture, destinationSlice, destinationLevel, sliceCount, levelCount);
        }

        public void copyFromTexture(in MTLTexture sourceTexture, in UIntPtr sourceSlice, in UIntPtr sourceLevel, in MTLOrigin sourceOrigin, in MTLSize sourceSize, in MTLTexture destinationTexture, in UIntPtr destinationSlice, in UIntPtr destinationLevel, in MTLOrigin destinationOrigin)
        {
            objc_msgSend(NativePtr, sel_copyFromTexture2, sourceTexture, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture, destinationSlice, destinationLevel, destinationOrigin);
        }

        public void copyFromTexture(in MTLTexture sourceTexture, in UIntPtr sourceSlice, in UIntPtr sourceLevel, in MTLOrigin sourceOrigin, in MTLSize sourceSize, in MTLBuffer destinationBuffer, in UIntPtr destinationOffset, in UIntPtr destinationBytesPerRow, in UIntPtr destinationBytesPerImage)
        {
            objc_msgSend(NativePtr, sel_copyFromTexture3, sourceTexture, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer, destinationOffset, destinationBytesPerRow, destinationBytesPerImage);
        }

        public void fillBuffer(in MTLBuffer buffer, in NSRange range, in UIntPtr value)
        {
            objc_msgSend(NativePtr, sel_fillBuffer, buffer, range, value);
        }

        public void generateMipmapsForTexture(in MTLTexture texture)
        {
            objc_msgSend(NativePtr, sel_generateMipmapsForTexture, texture.NativePtr);
        }

        public void updateFence()
        {

        }

        public void waitForFence()
        {

        }

        public void optimizeContentsForGPUAccess()
        {

        }

        public void synchronizeResource(in IntPtr resource)
        {
            objc_msgSend(NativePtr, sel_synchronizeResource, resource);
        }

        public void synchronizeTexture(in IntPtr resource, in UIntPtr slice, in UIntPtr level)
        {
            objc_msgSend(NativePtr, sel_synchronizeTexture, resource, slice, level);
        }

        public void copyIndirectCommandBuffer()
        {
            
        }

        public void optimizeIndirectCommandBuffer()
        {

        }

        public void resetCommandsInBuffer()
        {

        }

        public void optimizeContentsForGPUAccess(in UIntPtr slice, in UIntPtr level)
        {

        }

        public void optimizeContentsForCPUAccess()
        {

        }

        public void optimizeContentsForCPUAccess(in UIntPtr slice, in UIntPtr level)
        {

        }

        public void sampleCountersInBuffer()
        {

        }

        public void resolveCounters()
        {

        }

        public void getTextureAccessCounters()
        {

        }

        public void resetTextureAccessCounters()
        {

        }

        public void endEncoding()
        {
            objc_msgSend(NativePtr, sel_endEncoding);
        }

        public void insertDebugSignpost(in NSString @string)
        {
            objc_msgSend(NativePtr, Selectors.insertDebugSignpost, @string.NativePtr);
        }

        public void pushDebugGroup(in NSString @string)
        {
            objc_msgSend(NativePtr, Selectors.pushDebugGroup, @string.NativePtr);
        }

        public void popDebugGroup()
        {
            objc_msgSend(NativePtr, Selectors.popDebugGroup);
        }

        private static readonly Selector sel_copyFromBuffer0 = "copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:";
        private static readonly Selector sel_copyFromBuffer1 = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:";
        private static readonly Selector sel_copyFromTexture0 = "copyFromTexture:toTexture:";
        private static readonly Selector sel_copyFromTexture1 = "copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:";
        private static readonly Selector sel_copyFromTexture2 = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:";
        private static readonly Selector sel_copyFromTexture3 = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:";
        private static readonly Selector sel_fillBuffer = "fillBuffer:range:value:";
        private static readonly Selector sel_generateMipmapsForTexture = "generateMipmapsForTexture:";
        private static readonly Selector sel_copyIndirectCommandBuffer = "copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:";
        private static readonly Selector sel_optimizeIndirectCommandBuffer = "optimizeIndirectCommandBuffer:withRange:";
        private static readonly Selector sel_resetCommandsInBuffer = "resetCommandsInBuffer:withRange:";
        private static readonly Selector sel_synchronizeResource = "synchronizeResource:";
        private static readonly Selector sel_synchronizeTexture = "synchronizeTexture:slice:level:";
        private static readonly Selector sel_updateFence = "updateFence:";
        private static readonly Selector sel_waitForFence = "waitForFence:";
        private static readonly Selector sel_optimizeContentsForGPUAccess0 = "optimizeContentsForGPUAccess:";
        private static readonly Selector sel_optimizeContentsForGPUAccess1 = "optimizeContentsForGPUAccess:slice:level:";
        private static readonly Selector sel_optimizeContentsForCPUAccess0 = "optimizeContentsForCPUAccess:";
        private static readonly Selector sel_optimizeContentsForCPUAccess1 = "optimizeContentsForCPUAccess:slice:level:";
        private static readonly Selector sel_sampleCountersInBuffer = "sampleCountersInBuffer:atSampleIndex:withBarrier:";
        private static readonly Selector sel_resolveCounters = "resolveCounters:inRange:destinationBuffer:destinationOffset:";
        private static readonly Selector sel_getTextureAccessCounters = "getTextureAccessCounters:region:mipLevel:slice:resetCounters:countersBuffer:countersBufferOffset:";
        private static readonly Selector sel_resetTextureAccessCounters = "resetTextureAccessCounters:region:mipLevel:slice:";
        private static readonly Selector sel_endEncoding = "endEncoding";
    }
}