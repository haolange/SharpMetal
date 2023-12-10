using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLDispatchThreadgroupsIndirectArguments
    {
        public uint threadgroupsPerGrid;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLStageInRegionIndirectArguments
    {
        public uint stageInOrigin;
        public uint stageInSize;
    }
    
    public partial struct MTLComputeCommandEncoder
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLComputeCommandEncoder obj) => obj.NativePtr;
        public static implicit operator MTLCommandEncoder(in MTLComputeCommandEncoder obj) => new MTLCommandEncoder(obj.NativePtr);
        public static implicit operator MTLComputeCommandEncoder(in MTLCommandEncoder obj) => new MTLComputeCommandEncoder(obj.NativePtr);

        public MTLComputeCommandEncoder(in IntPtr ptr) => NativePtr = ptr;

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

        public MTLDispatchType DispatchType => (MTLDispatchType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_dispatchType);

        public void SetComputePipelineState(in MTLComputePipelineState state)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setComputePipelineState, state);
        }

        public void SetBytes(in IntPtr bytes, in ulong length, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setByteslengthatIndex, bytes, length, index);
        }

        public void SetBuffer(in MTLBuffer buffer, in ulong offset, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBufferoffsetatIndex, buffer, offset, index);
        }

        public void SetBufferOffset(in ulong offset, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBufferOffsetatIndex, offset, index);
        }

        public void SetBuffers(MTLBuffer[] buffers, in ulong[] offsets, NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetBuffer(in MTLBuffer buffer, in ulong offset, in ulong stride, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBufferoffsetattributeStrideatIndex, buffer, offset, stride, index);
        }

        public void SetBuffers(MTLBuffer[] buffers, in ulong offsets, in ulong strides, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetBufferOffset(in ulong offset, in ulong stride, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBufferOffsetattributeStrideatIndex, offset, stride, index);
        }

        public void SetBytes(in IntPtr bytes, in ulong length, in ulong stride, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setByteslengthattributeStrideatIndex, bytes, length, stride, index);
        }

        public void SetVisibleFunctionTable(in MTLVisibleFunctionTable visibleFunctionTable, in ulong bufferIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVisibleFunctionTableatBufferIndex, visibleFunctionTable, bufferIndex);
        }

        public void SetVisibleFunctionTables(MTLVisibleFunctionTable[] visibleFunctionTables, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetIntersectionFunctionTable(in MTLIntersectionFunctionTable intersectionFunctionTable, in ulong bufferIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIntersectionFunctionTableatBufferIndex, intersectionFunctionTable, bufferIndex);
        }

        public void SetIntersectionFunctionTables(MTLIntersectionFunctionTable[] intersectionFunctionTables, NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetAccelerationStructure(in MTLAccelerationStructure accelerationStructure, in ulong bufferIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAccelerationStructureatBufferIndex, accelerationStructure, bufferIndex);
        }

        public void SetTexture(in MTLTexture texture, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTextureatIndex, texture, index);
        }

        public void SetTextures(MTLTexture[] textures, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetSamplerState(in MTLSamplerState sampler, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSamplerStateatIndex, sampler, index);
        }

        public void SetSamplerStates(MTLSamplerState[] samplers, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetSamplerState(in MTLSamplerState sampler, in float lodMinClamp, in float lodMaxClamp, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSamplerStatelodMinClamplodMaxClampatIndex, sampler, lodMinClamp, lodMaxClamp, index);
        }

        public void SetSamplerStates(MTLSamplerState[] samplers, float[] lodMinClamps, float[] lodMaxClamps, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetThreadgroupMemoryLength(in ulong length, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setThreadgroupMemoryLengthatIndex, length, index);
        }

        public void SetImageblockWidth(in ulong width, in ulong height)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setImageblockWidthheight, width, height);
        }

        public void SetStageInRegion(in MTLRegion region)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStageInRegion, region);
        }

        public void SetStageInRegion(in MTLBuffer indirectBuffer, in ulong indirectBufferOffset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStageInRegionWithIndirectBufferindirectBufferOffset, indirectBuffer, indirectBufferOffset);
        }

        public void DispatchThreadgroups(MTLSize threadgroupsPerGrid, MTLSize threadsPerThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_dispatchThreadgroupsthreadsPerThreadgroup, threadgroupsPerGrid, threadsPerThreadgroup);
        }

        public void DispatchThreadgroups(in MTLBuffer indirectBuffer, in ulong indirectBufferOffset, in MTLSize threadsPerThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_dispatchThreadgroupsWithIndirectBufferindirectBufferOffsetthreadsPerThreadgroup, indirectBuffer, indirectBufferOffset, threadsPerThreadgroup);
        }

        public void DispatchThreads(in MTLSize threadsPerGrid, in MTLSize threadsPerThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_dispatchThreadsthreadsPerThreadgroup, threadsPerGrid, threadsPerThreadgroup);
        }

        public void UpdateFence(in MTLFence fence)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_updateFence, fence);
        }

        public void WaitForFence(in MTLFence fence)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_waitForFence, fence);
        }

        public void UseResource(in MTLResource resource, in MTLResourceUsage usage)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_useResourceusage, resource, (ulong)usage);
        }

        public void UseResources(MTLResource[] resources, in ulong count, in MTLResourceUsage usage)
        {
            throw new NotImplementedException();
        }

        public void UseHeap(in MTLHeap heap)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_useHeap, heap);
        }

        public void UseHeaps(MTLHeap[] heaps, in ulong count)
        {
            throw new NotImplementedException();
        }

        public void ExecuteCommandsInBuffer(in MTLIndirectCommandBuffer indirectCommandBuffer, in NSRange executionRange)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_executeCommandsInBufferwithRange, indirectCommandBuffer, executionRange);
        }

        public void ExecuteCommandsInBuffer(in MTLIndirectCommandBuffer indirectCommandbuffer, in MTLBuffer indirectRangeBuffer, in ulong indirectBufferOffset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_executeCommandsInBufferindirectBufferindirectBufferOffset, indirectCommandbuffer, indirectRangeBuffer, indirectBufferOffset);
        }

        public void MemoryBarrier(in MTLBarrierScope scope)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_memoryBarrierWithScope, (ulong)scope);
        }

        public void MemoryBarrier(MTLResource[] resources, in ulong count)
        {
            throw new NotImplementedException();
        }

        public void SampleCountersInBuffer(in MTLCounterSampleBuffer sampleBuffer, in ulong sampleIndex, bool barrier)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_sampleCountersInBufferatSampleIndexwithBarrier, sampleBuffer, sampleIndex, barrier);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_endEncoding = "endEncoding";
        private static readonly Selector sel_insertDebugSignpost = "insertDebugSignpost:";
        private static readonly Selector sel_pushDebugGroup = "pushDebugGroup:";
        private static readonly Selector sel_popDebugGroup = "popDebugGroup";
        private static readonly Selector sel_dispatchType = "dispatchType";
        private static readonly Selector sel_setComputePipelineState = "setComputePipelineState:";
        private static readonly Selector sel_setByteslengthatIndex = "setBytes:length:atIndex:";
        private static readonly Selector sel_setBufferoffsetatIndex = "setBuffer:offset:atIndex:";
        private static readonly Selector sel_setBufferOffsetatIndex = "setBufferOffset:atIndex:";
        private static readonly Selector sel_setBuffersoffsetswithRange = "setBuffers:offsets:withRange:";
        private static readonly Selector sel_setBufferoffsetattributeStrideatIndex = "setBuffer:offset:attributeStride:atIndex:";
        private static readonly Selector sel_setBuffersoffsetsattributeStrideswithRange = "setBuffers:offsets:attributeStrides:withRange:";
        private static readonly Selector sel_setBufferOffsetattributeStrideatIndex = "setBufferOffset:attributeStride:atIndex:";
        private static readonly Selector sel_setByteslengthattributeStrideatIndex = "setBytes:length:attributeStride:atIndex:";
        private static readonly Selector sel_setVisibleFunctionTableatBufferIndex = "setVisibleFunctionTable:atBufferIndex:";
        private static readonly Selector sel_setVisibleFunctionTableswithBufferRange = "setVisibleFunctionTables:withBufferRange:";
        private static readonly Selector sel_setIntersectionFunctionTableatBufferIndex = "setIntersectionFunctionTable:atBufferIndex:";
        private static readonly Selector sel_setIntersectionFunctionTableswithBufferRange = "setIntersectionFunctionTables:withBufferRange:";
        private static readonly Selector sel_setAccelerationStructureatBufferIndex = "setAccelerationStructure:atBufferIndex:";
        private static readonly Selector sel_setTextureatIndex = "setTexture:atIndex:";
        private static readonly Selector sel_setTextureswithRange = "setTextures:withRange:";
        private static readonly Selector sel_setSamplerStateatIndex = "setSamplerState:atIndex:";
        private static readonly Selector sel_setSamplerStateswithRange = "setSamplerStates:withRange:";
        private static readonly Selector sel_setSamplerStatelodMinClamplodMaxClampatIndex = "setSamplerState:lodMinClamp:lodMaxClamp:atIndex:";
        private static readonly Selector sel_setSamplerStateslodMinClampslodMaxClampswithRange = "setSamplerStates:lodMinClamps:lodMaxClamps:withRange:";
        private static readonly Selector sel_setThreadgroupMemoryLengthatIndex = "setThreadgroupMemoryLength:atIndex:";
        private static readonly Selector sel_setImageblockWidthheight = "setImageblockWidth:height:";
        private static readonly Selector sel_setStageInRegion = "setStageInRegion:";
        private static readonly Selector sel_setStageInRegionWithIndirectBufferindirectBufferOffset = "setStageInRegionWithIndirectBuffer:indirectBufferOffset:";
        private static readonly Selector sel_dispatchThreadgroupsthreadsPerThreadgroup = "dispatchThreadgroups:threadsPerThreadgroup:";
        private static readonly Selector sel_dispatchThreadgroupsWithIndirectBufferindirectBufferOffsetthreadsPerThreadgroup = "dispatchThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerThreadgroup:";
        private static readonly Selector sel_dispatchThreadsthreadsPerThreadgroup = "dispatchThreads:threadsPerThreadgroup:";
        private static readonly Selector sel_updateFence = "updateFence:";
        private static readonly Selector sel_waitForFence = "waitForFence:";
        private static readonly Selector sel_useResourceusage = "useResource:usage:";
        private static readonly Selector sel_useResourcescountusage = "useResources:count:usage:";
        private static readonly Selector sel_useHeap = "useHeap:";
        private static readonly Selector sel_useHeapscount = "useHeaps:count:";
        private static readonly Selector sel_executeCommandsInBufferwithRange = "executeCommandsInBuffer:withRange:";
        private static readonly Selector sel_executeCommandsInBufferindirectBufferindirectBufferOffset = "executeCommandsInBuffer:indirectBuffer:indirectBufferOffset:";
        private static readonly Selector sel_memoryBarrierWithScope = "memoryBarrierWithScope:";
        private static readonly Selector sel_memoryBarrierWithResourcescount = "memoryBarrierWithResources:count:";
        private static readonly Selector sel_sampleCountersInBufferatSampleIndexwithBarrier = "sampleCountersInBuffer:atSampleIndex:withBarrier:";
    }
}
