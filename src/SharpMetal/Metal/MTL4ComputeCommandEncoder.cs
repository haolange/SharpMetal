using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    public partial struct MTL4ComputeCommandEncoder
    {
        public IntPtr NativePtr;

        public MTL4ComputeCommandEncoder(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4ComputeCommandEncoder obj) => obj.NativePtr;
        public static implicit operator MTL4CommandEncoder(in MTL4ComputeCommandEncoder obj) => new MTL4CommandEncoder(obj.NativePtr);
        public static implicit operator MTL4ComputeCommandEncoder(in MTL4CommandEncoder obj) => new MTL4ComputeCommandEncoder(obj.NativePtr);

        public ulong Stages => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_stages);

        public void SetComputePipelineState(in MTLComputePipelineState state)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setComputePipelineState, state);
        }

        public void SetThreadgroupMemoryLength(in ulong length, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setThreadgroupMemoryLengthatIndex, length, index);
        }

        public void SetImageblockWidth(in ulong width, in ulong height)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setImageblockWidthheight, width, height);
        }

        public void DispatchThreads(in MTLSize threadsPerGrid, in MTLSize threadsPerThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_dispatchThreadsthreadsPerThreadgroup, threadsPerGrid, threadsPerThreadgroup);
        }

        public void DispatchThreadgroups(in MTLSize threadgroupsPerGrid, in MTLSize threadsPerThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_dispatchThreadgroupsthreadsPerThreadgroup, threadgroupsPerGrid, threadsPerThreadgroup);
        }

        public void DispatchThreadgroupsWithIndirectBuffer(in ulong indirectBuffer, in MTLSize threadsPerThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_dispatchThreadgroupsWithIndirectBufferthreadsPerThreadgroup, indirectBuffer, threadsPerThreadgroup);
        }

        public void DispatchThreadsWithIndirectBuffer(in ulong indirectBuffer)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_dispatchThreadsWithIndirectBuffer, indirectBuffer);
        }

        public void ExecuteCommandsInBuffer(in MTLIndirectCommandBuffer indirectCommandBuffer, in NSRange executionRange)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_executeCommandsInBufferwithRange, indirectCommandBuffer, executionRange);
        }

        public void ExecuteCommandsInBuffer(in MTLIndirectCommandBuffer indirectCommandbuffer, in ulong indirectRangeBuffer)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_executeCommandsInBufferindirectBuffer, indirectCommandbuffer, indirectRangeBuffer);
        }

        public void CopyFromTexture(in MTLTexture sourceTexture, in MTLTexture destinationTexture)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTexturetoTexture, sourceTexture, destinationTexture);
        }

        public void CopyFromTexture(in MTLTexture sourceTexture, in ulong sourceSlice, in ulong sourceLevel, in MTLTexture destinationTexture, in ulong destinationSlice, in ulong destinationLevel, in ulong sliceCount, in ulong levelCount)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTexturesourceSlicesourceLeveltoTexturedestinationSlicedestinationLevelsliceCountlevelCount, sourceTexture, sourceSlice, sourceLevel, destinationTexture, destinationSlice, destinationLevel, sliceCount, levelCount);
        }

        public void CopyFromTexture(in MTLTexture sourceTexture, in ulong sourceSlice, in ulong sourceLevel, in MTLOrigin sourceOrigin, in MTLSize sourceSize, in MTLTexture destinationTexture, in ulong destinationSlice, in ulong destinationLevel, in MTLOrigin destinationOrigin)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoTexturedestinationSlicedestinationLeveldestinationOrigin, sourceTexture, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture, destinationSlice, destinationLevel, destinationOrigin);
        }

        public void CopyFromTexture(in MTLTexture sourceTexture, in ulong sourceSlice, in ulong sourceLevel, in MTLOrigin sourceOrigin, in MTLSize sourceSize, in MTLBuffer destinationBuffer, in ulong destinationOffset, in ulong destinationBytesPerRow, in ulong destinationBytesPerImage)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoBufferdestinationOffsetdestinationBytesPerRowdestinationBytesPerImage, sourceTexture, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer, destinationOffset, destinationBytesPerRow, destinationBytesPerImage);
        }

        public void CopyFromTexture(in MTLTexture sourceTexture, in ulong sourceSlice, in ulong sourceLevel, in MTLOrigin sourceOrigin, in MTLSize sourceSize, in MTLBuffer destinationBuffer, in ulong destinationOffset, in ulong destinationBytesPerRow, in ulong destinationBytesPerImage, in ulong options)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoBufferdestinationOffsetdestinationBytesPerRowdestinationBytesPerImageoptions, sourceTexture, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationBuffer, destinationOffset, destinationBytesPerRow, destinationBytesPerImage, options);
        }

        public void CopyFromBuffer(in MTLBuffer sourceBuffer, in ulong sourceOffset, in MTLBuffer destinationBuffer, in ulong destinationOffset, in ulong size)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromBuffersourceOffsettoBufferdestinationOffsetsize, sourceBuffer, sourceOffset, destinationBuffer, destinationOffset, size);
        }

        public void CopyFromBuffer(in MTLBuffer sourceBuffer, in ulong sourceOffset, in ulong sourceBytesPerRow, in ulong sourceBytesPerImage, in MTLSize sourceSize, in MTLTexture destinationTexture, in ulong destinationSlice, in ulong destinationLevel, in MTLOrigin destinationOrigin)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromBuffersourceOffsetsourceBytesPerRowsourceBytesPerImagesourceSizetoTexturedestinationSlicedestinationLeveldestinationOrigin, sourceBuffer, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture, destinationSlice, destinationLevel, destinationOrigin);
        }

        public void CopyFromBuffer(in MTLBuffer sourceBuffer, in ulong sourceOffset, in ulong sourceBytesPerRow, in ulong sourceBytesPerImage, in MTLSize sourceSize, in MTLTexture destinationTexture, in ulong destinationSlice, in ulong destinationLevel, in MTLOrigin destinationOrigin, in ulong options)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromBuffersourceOffsetsourceBytesPerRowsourceBytesPerImagesourceSizetoTexturedestinationSlicedestinationLeveldestinationOriginoptions, sourceBuffer, sourceOffset, sourceBytesPerRow, sourceBytesPerImage, sourceSize, destinationTexture, destinationSlice, destinationLevel, destinationOrigin, options);
        }

        public void CopyFromTensor(in IntPtr sourceTensor, in IntPtr sourceOrigin, in IntPtr sourceDimensions, in IntPtr destinationTensor, in IntPtr destinationOrigin, in IntPtr destinationDimensions)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyFromTensorsourceOriginsourceDimensionstoTensordestinationOrigindestinationDimensions, sourceTensor, sourceOrigin, sourceDimensions, destinationTensor, destinationOrigin, destinationDimensions);
        }

        public void GenerateMipmapsForTexture(in MTLTexture texture)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_generateMipmapsForTexture, texture);
        }

        public void FillBuffer(in MTLBuffer buffer, in NSRange range, in byte value)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_fillBufferrangevalue, buffer, range, value);
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

        public void SetBytes(in IntPtr bytes, in ulong length, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setByteslengthatIndex, bytes, length, index);
        }

        public void SetArgumentTable(in IntPtr argumentTable)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setArgumentTable, argumentTable);
        }

        public void BuildAccelerationStructure(in MTLAccelerationStructure accelerationStructure, in IntPtr descriptor, in MTL4BufferRange scratchBuffer)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_buildAccelerationStructuredescriptorscratchBuffer, accelerationStructure, descriptor, scratchBuffer);
        }

        public void RefitAccelerationStructure(in MTLAccelerationStructure sourceAccelerationStructure, in IntPtr descriptor, in MTLAccelerationStructure destinationAccelerationStructure, in MTL4BufferRange scratchBuffer)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_refitAccelerationStructuredescriptordestinationscratchBuffer, sourceAccelerationStructure, descriptor, destinationAccelerationStructure, scratchBuffer);
        }

        public void RefitAccelerationStructure(in MTLAccelerationStructure sourceAccelerationStructure, in IntPtr descriptor, in MTLAccelerationStructure destinationAccelerationStructure, in MTL4BufferRange scratchBuffer, in ulong options)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_refitAccelerationStructuredescriptordestinationscratchBufferoptions, sourceAccelerationStructure, descriptor, destinationAccelerationStructure, scratchBuffer, options);
        }

        public void CopyAccelerationStructure(in MTLAccelerationStructure sourceAccelerationStructure, in MTLAccelerationStructure destinationAccelerationStructure)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyAccelerationStructuretoAccelerationStructure, sourceAccelerationStructure, destinationAccelerationStructure);
        }

        public void WriteCompactedAccelerationStructureSize(in MTLAccelerationStructure accelerationStructure, in MTL4BufferRange buffer)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_writeCompactedAccelerationStructureSizetoBuffer, accelerationStructure, buffer);
        }

        public void CopyAndCompactAccelerationStructure(in MTLAccelerationStructure sourceAccelerationStructure, in MTLAccelerationStructure destinationAccelerationStructure)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyAndCompactAccelerationStructuretoAccelerationStructure, sourceAccelerationStructure, destinationAccelerationStructure);
        }

        public void WriteTimestampWithGranularity(in MTL4TimestampGranularity granularity, in MTL4CounterHeap counterHeap, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_writeTimestampWithGranularityintoHeapatIndex, (long)granularity, counterHeap, index);
        }

        private static readonly Selector sel_stages = "stages";
        private static readonly Selector sel_setComputePipelineState = "setComputePipelineState:";
        private static readonly Selector sel_setThreadgroupMemoryLengthatIndex = "setThreadgroupMemoryLength:atIndex:";
        private static readonly Selector sel_setImageblockWidthheight = "setImageblockWidth:height:";
        private static readonly Selector sel_dispatchThreadsthreadsPerThreadgroup = "dispatchThreads:threadsPerThreadgroup:";
        private static readonly Selector sel_dispatchThreadgroupsthreadsPerThreadgroup = "dispatchThreadgroups:threadsPerThreadgroup:";
        private static readonly Selector sel_dispatchThreadgroupsWithIndirectBufferthreadsPerThreadgroup = "dispatchThreadgroupsWithIndirectBuffer:threadsPerThreadgroup:";
        private static readonly Selector sel_dispatchThreadsWithIndirectBuffer = "dispatchThreadsWithIndirectBuffer:";
        private static readonly Selector sel_executeCommandsInBufferwithRange = "executeCommandsInBuffer:withRange:";
        private static readonly Selector sel_executeCommandsInBufferindirectBuffer = "executeCommandsInBuffer:indirectBuffer:";
        private static readonly Selector sel_copyFromTexturetoTexture = "copyFromTexture:toTexture:";
        private static readonly Selector sel_copyFromTexturesourceSlicesourceLeveltoTexturedestinationSlicedestinationLevelsliceCountlevelCount = "copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:";
        private static readonly Selector sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoTexturedestinationSlicedestinationLeveldestinationOrigin = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:";
        private static readonly Selector sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoBufferdestinationOffsetdestinationBytesPerRowdestinationBytesPerImage = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:";
        private static readonly Selector sel_copyFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoBufferdestinationOffsetdestinationBytesPerRowdestinationBytesPerImageoptions = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:";
        private static readonly Selector sel_copyFromBuffersourceOffsettoBufferdestinationOffsetsize = "copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:";
        private static readonly Selector sel_copyFromBuffersourceOffsetsourceBytesPerRowsourceBytesPerImagesourceSizetoTexturedestinationSlicedestinationLeveldestinationOrigin = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:";
        private static readonly Selector sel_copyFromBuffersourceOffsetsourceBytesPerRowsourceBytesPerImagesourceSizetoTexturedestinationSlicedestinationLeveldestinationOriginoptions = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:";
        private static readonly Selector sel_copyFromTensorsourceOriginsourceDimensionstoTensordestinationOrigindestinationDimensions = "copyFromTensor:sourceOrigin:sourceDimensions:toTensor:destinationOrigin:destinationDimensions:";
        private static readonly Selector sel_generateMipmapsForTexture = "generateMipmapsForTexture:";
        private static readonly Selector sel_fillBufferrangevalue = "fillBuffer:range:value:";
        private static readonly Selector sel_optimizeContentsForGPUAccess = "optimizeContentsForGPUAccess:";
        private static readonly Selector sel_optimizeContentsForGPUAccessslicelevel = "optimizeContentsForGPUAccess:slice:level:";
        private static readonly Selector sel_optimizeContentsForCPUAccess = "optimizeContentsForCPUAccess:";
        private static readonly Selector sel_optimizeContentsForCPUAccessslicelevel = "optimizeContentsForCPUAccess:slice:level:";
        private static readonly Selector sel_resetCommandsInBufferwithRange = "resetCommandsInBuffer:withRange:";
        private static readonly Selector sel_copyIndirectCommandBuffersourceRangedestinationdestinationIndex = "copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:";
        private static readonly Selector sel_optimizeIndirectCommandBufferwithRange = "optimizeIndirectCommandBuffer:withRange:";
        private static readonly Selector sel_setByteslengthatIndex = "setBytes:length:atIndex:";
        private static readonly Selector sel_setArgumentTable = "setArgumentTable:";
        private static readonly Selector sel_buildAccelerationStructuredescriptorscratchBuffer = "buildAccelerationStructure:descriptor:scratchBuffer:";
        private static readonly Selector sel_refitAccelerationStructuredescriptordestinationscratchBuffer = "refitAccelerationStructure:descriptor:destination:scratchBuffer:";
        private static readonly Selector sel_refitAccelerationStructuredescriptordestinationscratchBufferoptions = "refitAccelerationStructure:descriptor:destination:scratchBuffer:options:";
        private static readonly Selector sel_copyAccelerationStructuretoAccelerationStructure = "copyAccelerationStructure:toAccelerationStructure:";
        private static readonly Selector sel_writeCompactedAccelerationStructureSizetoBuffer = "writeCompactedAccelerationStructureSize:toBuffer:";
        private static readonly Selector sel_copyAndCompactAccelerationStructuretoAccelerationStructure = "copyAndCompactAccelerationStructure:toAccelerationStructure:";
        private static readonly Selector sel_writeTimestampWithGranularityintoHeapatIndex = "writeTimestampWithGranularity:intoHeap:atIndex:";
    }
}
