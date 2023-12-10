using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLBlitOption : ulong
    {
        None = 0,
        DepthFromDepthStencil = 1,
        StencilFromDepthStencil = 2,
        RowLinearPVRTC = 4,
    }
    
    public partial struct MTLBlitCommandEncoder
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLBlitCommandEncoder obj) => obj.NativePtr;
        public static implicit operator MTLCommandEncoder(in MTLBlitCommandEncoder obj) => new MTLCommandEncoder(obj.NativePtr);
        public static implicit operator MTLBlitCommandEncoder(in MTLCommandEncoder obj) => new MTLBlitCommandEncoder(obj.NativePtr);

        public MTLBlitCommandEncoder(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public void EndEncoding()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_endEncoding);
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

        public void SynchronizeResource(in MTLResource resource)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_synchronizeResource, resource);
        }

        public void SynchronizeTexture(in MTLTexture texture, in ulong slice, in ulong level)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_synchronizeTextureslicelevel, texture, slice, level);
        }

        public void CopyFromTexture(in MTLTexture sourceTexture, in ulong sourceSlice, in ulong sourceLevel, in MTLOrigin sourceOrigin, in MTLSize sourceSize, in MTLTexture destinationTexture, in ulong destinationSlice, in ulong destinationLevel, in MTLOrigin destinationOrigin)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoTexturedestinationSlicedestinationLeveldestinationOrigin, sourceTexture, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture, destinationSlice, destinationLevel, destinationOrigin);
        }

        public void CopyFromBuffer(in MTLBuffer sourceBuffer, in ulong sourceOffset, in ulong sourceBytesPerRow, in ulong sourceBytesPerImage, in MTLSize sourceSize, in MTLTexture destinationTexture, in ulong destinationSlice, in ulong destinationLevel, in MTLOrigin destinationOrigin)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromBuffersourceOffsetsourceBytesPerRowsourceBytesPerImagesourceSizetoTexturedestinationSlicedestinationLeveldestinationOrigin, sourceBuffer, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture, destinationSlice, destinationLevel, destinationOrigin);
        }

        public void CopyFromBuffer(in MTLBuffer sourceBuffer, in ulong sourceOffset, in ulong sourceBytesPerRow, in ulong sourceBytesPerImage, in MTLSize sourceSize, in MTLTexture destinationTexture, in ulong destinationSlice, in ulong destinationLevel, in MTLOrigin destinationOrigin, in MTLBlitOption options)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromBuffersourceOffsetsourceBytesPerRowsourceBytesPerImagesourceSizetoTexturedestinationSlicedestinationLeveldestinationOriginoptions, sourceBuffer, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture, destinationSlice, destinationLevel, destinationOrigin, (ulong)options);
        }

        public void CopyFromTexture(in MTLTexture sourceTexture, in ulong sourceSlice, in ulong sourceLevel, in MTLOrigin sourceOrigin, in MTLSize sourceSize, in MTLBuffer destinationBuffer, in ulong destinationOffset, in ulong destinationBytesPerRow, in ulong destinationBytesPerImage)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoBufferdestinationOffsetdestinationBytesPerRowdestinationBytesPerImage, sourceTexture, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer, destinationOffset, destinationBytesPerRow, destinationBytesPerImage);
        }

        public void CopyFromTexture(in MTLTexture sourceTexture, in ulong sourceSlice, in ulong sourceLevel, in MTLOrigin sourceOrigin, in MTLSize sourceSize, in MTLBuffer destinationBuffer, in ulong destinationOffset, in ulong destinationBytesPerRow, in ulong destinationBytesPerImage, in MTLBlitOption options)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoBufferdestinationOffsetdestinationBytesPerRowdestinationBytesPerImageoptions, sourceTexture, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer, destinationOffset, destinationBytesPerRow, destinationBytesPerImage, (ulong)options);
        }

        public void GenerateMipmaps(in MTLTexture texture)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_generateMipmapsForTexture, texture);
        }

        public void FillBuffer(in MTLBuffer buffer, in NSRange range, byte value)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_fillBufferrangevalue, buffer, range, value);
        }

        public void CopyFromTexture(in MTLTexture sourceTexture, in ulong sourceSlice, in ulong sourceLevel, in MTLTexture destinationTexture, in ulong destinationSlice, in ulong destinationLevel, in ulong sliceCount, in ulong levelCount)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTexturesourceSlicesourceLeveltoTexturedestinationSlicedestinationLevelsliceCountlevelCount, sourceTexture, sourceSlice, sourceLevel, destinationTexture, destinationSlice, destinationLevel, sliceCount, levelCount);
        }

        public void CopyFromTexture(in MTLTexture sourceTexture, in MTLTexture destinationTexture)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTexturetoTexture, sourceTexture, destinationTexture);
        }

        public void CopyFromBuffer(in MTLBuffer sourceBuffer, in ulong sourceOffset, in MTLBuffer destinationBuffer, in ulong destinationOffset, in ulong size)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromBuffersourceOffsettoBufferdestinationOffsetsize, sourceBuffer, sourceOffset, destinationBuffer, destinationOffset, size);
        }

        public void UpdateFence(in MTLFence fence)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_updateFence, fence);
        }

        public void WaitForFence(in MTLFence fence)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_waitForFence, fence);
        }

        public void GetTextureAccessCounters(in MTLTexture texture, in MTLRegion region, in ulong mipLevel, in ulong slice, bool resetCounters, in MTLBuffer countersBuffer, in ulong countersBufferOffset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_getTextureAccessCountersregionmipLevelsliceresetCounterscountersBuffercountersBufferOffset, texture, region, mipLevel, slice, resetCounters, countersBuffer, countersBufferOffset);
        }

        public void ResetTextureAccessCounters(in MTLTexture texture, in MTLRegion region, in ulong mipLevel, in ulong slice)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_resetTextureAccessCountersregionmipLevelslice, texture, region, mipLevel, slice);
        }

        public void OptimizeContentsForGPUAccess(in MTLTexture texture)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_optimizeContentsForGPUAccess, texture);
        }

        public void OptimizeContentsForGPUAccess(in MTLTexture texture, in ulong slice, in ulong level)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_optimizeContentsForGPUAccessslicelevel, texture, slice, level);
        }

        public void OptimizeContentsForCPUAccess(in MTLTexture texture)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_optimizeContentsForCPUAccess, texture);
        }

        public void OptimizeContentsForCPUAccess(in MTLTexture texture, in ulong slice, in ulong level)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_optimizeContentsForCPUAccessslicelevel, texture, slice, level);
        }

        public void ResetCommandsInBuffer(in MTLIndirectCommandBuffer buffer, in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_resetCommandsInBufferwithRange, buffer, range);
        }

        public void CopyIndirectCommandBuffer(in MTLIndirectCommandBuffer source, in NSRange sourceRange, in MTLIndirectCommandBuffer destination, in ulong destinationIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyIndirectCommandBuffersourceRangedestinationdestinationIndex, source, sourceRange, destination, destinationIndex);
        }

        public void OptimizeIndirectCommandBuffer(in MTLIndirectCommandBuffer indirectCommandBuffer, in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_optimizeIndirectCommandBufferwithRange, indirectCommandBuffer, range);
        }

        public void SampleCountersInBuffer(in MTLCounterSampleBuffer sampleBuffer, in ulong sampleIndex, in bool barrier)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_sampleCountersInBufferatSampleIndexwithBarrier, sampleBuffer, sampleIndex, barrier);
        }

        public void ResolveCounters(in MTLCounterSampleBuffer sampleBuffer, in NSRange range, in MTLBuffer destinationBuffer, in ulong destinationOffset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_resolveCountersinRangedestinationBufferdestinationOffset, sampleBuffer, range, destinationBuffer, destinationOffset);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_endEncoding = "endEncoding";
        private static readonly Selector sel_insertDebugSignpost = "insertDebugSignpost:";
        private static readonly Selector sel_pushDebugGroup = "pushDebugGroup:";
        private static readonly Selector sel_popDebugGroup = "popDebugGroup";
        private static readonly Selector sel_synchronizeResource = "synchronizeResource:";
        private static readonly Selector sel_synchronizeTextureslicelevel = "synchronizeTexture:slice:level:";
        private static readonly Selector sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoTexturedestinationSlicedestinationLeveldestinationOrigin = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:";
        private static readonly Selector sel_copyFromBuffersourceOffsetsourceBytesPerRowsourceBytesPerImagesourceSizetoTexturedestinationSlicedestinationLeveldestinationOrigin = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:";
        private static readonly Selector sel_copyFromBuffersourceOffsetsourceBytesPerRowsourceBytesPerImagesourceSizetoTexturedestinationSlicedestinationLeveldestinationOriginoptions = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:";
        private static readonly Selector sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoBufferdestinationOffsetdestinationBytesPerRowdestinationBytesPerImage = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:";
        private static readonly Selector sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoBufferdestinationOffsetdestinationBytesPerRowdestinationBytesPerImageoptions = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:";
        private static readonly Selector sel_generateMipmapsForTexture = "generateMipmapsForTexture:";
        private static readonly Selector sel_fillBufferrangevalue = "fillBuffer:range:value:";
        private static readonly Selector sel_copyFromTexturesourceSlicesourceLeveltoTexturedestinationSlicedestinationLevelsliceCountlevelCount = "copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:";
        private static readonly Selector sel_copyFromTexturetoTexture = "copyFromTexture:toTexture:";
        private static readonly Selector sel_copyFromBuffersourceOffsettoBufferdestinationOffsetsize = "copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:";
        private static readonly Selector sel_updateFence = "updateFence:";
        private static readonly Selector sel_waitForFence = "waitForFence:";
        private static readonly Selector sel_getTextureAccessCountersregionmipLevelsliceresetCounterscountersBuffercountersBufferOffset = "getTextureAccessCounters:region:mipLevel:slice:resetCounters:countersBuffer:countersBufferOffset:";
        private static readonly Selector sel_resetTextureAccessCountersregionmipLevelslice = "resetTextureAccessCounters:region:mipLevel:slice:";
        private static readonly Selector sel_optimizeContentsForGPUAccess = "optimizeContentsForGPUAccess:";
        private static readonly Selector sel_optimizeContentsForGPUAccessslicelevel = "optimizeContentsForGPUAccess:slice:level:";
        private static readonly Selector sel_optimizeContentsForCPUAccess = "optimizeContentsForCPUAccess:";
        private static readonly Selector sel_optimizeContentsForCPUAccessslicelevel = "optimizeContentsForCPUAccess:slice:level:";
        private static readonly Selector sel_resetCommandsInBufferwithRange = "resetCommandsInBuffer:withRange:";
        private static readonly Selector sel_copyIndirectCommandBuffersourceRangedestinationdestinationIndex = "copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:";
        private static readonly Selector sel_optimizeIndirectCommandBufferwithRange = "optimizeIndirectCommandBuffer:withRange:";
        private static readonly Selector sel_sampleCountersInBufferatSampleIndexwithBarrier = "sampleCountersInBuffer:atSampleIndex:withBarrier:";
        private static readonly Selector sel_resolveCountersinRangedestinationBufferdestinationOffset = "resolveCounters:inRange:destinationBuffer:destinationOffset:";
    }
}
