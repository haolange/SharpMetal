using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLIndirectRenderCommand
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLIndirectRenderCommand obj) => obj.NativePtr;
        public MTLIndirectRenderCommand(in IntPtr ptr) => NativePtr = ptr;

        public void SetRenderPipelineState(MTLRenderPipelineState pipelineState)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRenderPipelineState, pipelineState);
        }

        public void SetVertexBuffer(in MTLBuffer buffer, in ulong offset, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexBufferoffsetatIndex, buffer, offset, index);
        }

        public void SetFragmentBuffer(in MTLBuffer buffer, in ulong offset, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFragmentBufferoffsetatIndex, buffer, offset, index);
        }

        public void SetVertexBuffer(in MTLBuffer buffer, in ulong offset, in ulong stride, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexBufferoffsetattributeStrideatIndex, buffer, offset, stride, index);
        }

        public void DrawPatches(in ulong numberOfPatchControlPoints, in ulong patchStart, in ulong patchCount, in MTLBuffer patchIndexBuffer, in ulong patchIndexBufferOffset, in ulong instanceCount, in ulong baseInstance, in MTLBuffer buffer, in ulong offset, in ulong instanceStride)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawPatchespatchStartpatchCountpatchIndexBufferpatchIndexBufferOffsetinstanceCountbaseInstancetessellationFactorBuffertessellationFactorBufferOffsettessellationFactorBufferInstanceStride, numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer, patchIndexBufferOffset, instanceCount, baseInstance, buffer, offset, instanceStride);
        }

        public void DrawIndexedPatches(in ulong numberOfPatchControlPoints, in ulong patchStart, in ulong patchCount, in MTLBuffer patchIndexBuffer, in ulong patchIndexBufferOffset, in MTLBuffer controlPointIndexBuffer, in ulong controlPointIndexBufferOffset, in ulong instanceCount, in ulong baseInstance, in MTLBuffer buffer, in ulong offset, in ulong instanceStride)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawIndexedPatchespatchStartpatchCountpatchIndexBufferpatchIndexBufferOffsetcontrolPointIndexBuffercontrolPointIndexBufferOffsetinstanceCountbaseInstancetessellationFactorBuffertessellationFactorBufferOffsettessellationFactorBufferInstanceStride, numberOfPatchControlPoints, patchStart, patchCount, patchIndexBuffer, patchIndexBufferOffset, controlPointIndexBuffer, controlPointIndexBufferOffset, instanceCount, baseInstance, buffer, offset, instanceStride);
        }

        public void DrawPrimitives(in MTLPrimitiveType primitiveType, in ulong vertexStart, in ulong vertexCount, in ulong instanceCount, in ulong baseInstance)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawPrimitivesvertexStartvertexCountinstanceCountbaseInstance, (ulong)primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);
        }

        public void DrawIndexedPrimitives(in MTLPrimitiveType primitiveType, in ulong indexCount, in MTLIndexType indexType, in MTLBuffer indexBuffer, in ulong indexBufferOffset, in ulong instanceCount, long baseVertex, in ulong baseInstance)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawIndexedPrimitivesindexCountindexTypeindexBufferindexBufferOffsetinstanceCountbaseVertexbaseInstance, (ulong)primitiveType, indexCount, (ulong)indexType, indexBuffer, indexBufferOffset, instanceCount, baseVertex, baseInstance);
        }

        public void Reset()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_reset);
        }

        private static readonly Selector sel_setRenderPipelineState = "setRenderPipelineState:";
        private static readonly Selector sel_setVertexBufferoffsetatIndex = "setVertexBuffer:offset:atIndex:";
        private static readonly Selector sel_setFragmentBufferoffsetatIndex = "setFragmentBuffer:offset:atIndex:";
        private static readonly Selector sel_setVertexBufferoffsetattributeStrideatIndex = "setVertexBuffer:offset:attributeStride:atIndex:";
        private static readonly Selector sel_drawPatchespatchStartpatchCountpatchIndexBufferpatchIndexBufferOffsetinstanceCountbaseInstancetessellationFactorBuffertessellationFactorBufferOffsettessellationFactorBufferInstanceStride = "drawPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:";
        private static readonly Selector sel_drawIndexedPatchespatchStartpatchCountpatchIndexBufferpatchIndexBufferOffsetcontrolPointIndexBuffercontrolPointIndexBufferOffsetinstanceCountbaseInstancetessellationFactorBuffertessellationFactorBufferOffsettessellationFactorBufferInstanceStride = "drawIndexedPatches:patchStart:patchCount:patchIndexBuffer:patchIndexBufferOffset:controlPointIndexBuffer:controlPointIndexBufferOffset:instanceCount:baseInstance:tessellationFactorBuffer:tessellationFactorBufferOffset:tessellationFactorBufferInstanceStride:";
        private static readonly Selector sel_drawPrimitivesvertexStartvertexCountinstanceCountbaseInstance = "drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:";
        private static readonly Selector sel_drawIndexedPrimitivesindexCountindexTypeindexBufferindexBufferOffsetinstanceCountbaseVertexbaseInstance = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:";
        private static readonly Selector sel_reset = "reset";
    }

    public partial struct MTLIndirectComputeCommand
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLIndirectComputeCommand obj) => obj.NativePtr;
        public MTLIndirectComputeCommand(in IntPtr ptr) => NativePtr = ptr;

        public void SetComputePipelineState(in MTLComputePipelineState pipelineState)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setComputePipelineState, pipelineState);
        }

        public void SetKernelBuffer(in MTLBuffer buffer, in ulong offset, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setKernelBufferoffsetatIndex, buffer, offset, index);
        }

        public void SetKernelBuffer(in MTLBuffer buffer, in ulong offset, in ulong stride, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setKernelBufferoffsetattributeStrideatIndex, buffer, offset, stride, index);
        }

        public void ConcurrentDispatchThreadgroups(in MTLSize threadgroupsPerGrid, in MTLSize threadsPerThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_concurrentDispatchThreadgroupsthreadsPerThreadgroup, threadgroupsPerGrid, threadsPerThreadgroup);
        }

        public void ConcurrentDispatchThreads(in MTLSize threadsPerGrid, in MTLSize threadsPerThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_concurrentDispatchThreadsthreadsPerThreadgroup, threadsPerGrid, threadsPerThreadgroup);
        }

        public void SetBarrier()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBarrier);
        }

        public void ClearBarrier()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_clearBarrier);
        }

        public void SetImageblockWidth(in ulong width, in ulong height)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setImageblockWidthheight, width, height);
        }

        public void Reset()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_reset);
        }

        public void SetThreadgroupMemoryLength(in ulong length, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setThreadgroupMemoryLengthatIndex, length, index);
        }

        public void SetStageInRegion(in MTLRegion region)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStageInRegion, region);
        }

        private static readonly Selector sel_setComputePipelineState = "setComputePipelineState:";
        private static readonly Selector sel_setKernelBufferoffsetatIndex = "setKernelBuffer:offset:atIndex:";
        private static readonly Selector sel_setKernelBufferoffsetattributeStrideatIndex = "setKernelBuffer:offset:attributeStride:atIndex:";
        private static readonly Selector sel_concurrentDispatchThreadgroupsthreadsPerThreadgroup = "concurrentDispatchThreadgroups:threadsPerThreadgroup:";
        private static readonly Selector sel_concurrentDispatchThreadsthreadsPerThreadgroup = "concurrentDispatchThreads:threadsPerThreadgroup:";
        private static readonly Selector sel_setBarrier = "setBarrier";
        private static readonly Selector sel_clearBarrier = "clearBarrier";
        private static readonly Selector sel_setImageblockWidthheight = "setImageblockWidth:height:";
        private static readonly Selector sel_reset = "reset";
        private static readonly Selector sel_setThreadgroupMemoryLengthatIndex = "setThreadgroupMemoryLength:atIndex:";
        private static readonly Selector sel_setStageInRegion = "setStageInRegion:";
    }
}
