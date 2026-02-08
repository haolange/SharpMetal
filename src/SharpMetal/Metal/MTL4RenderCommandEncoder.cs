using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    [Flags]
    public enum MTL4RenderEncoderOptions : ulong
    {
        None = 0,
        Suspending = 1,
        Resuming = 2,
    }

    public partial struct MTL4RenderCommandEncoder
    {
        public IntPtr NativePtr;

        public MTL4RenderCommandEncoder(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4RenderCommandEncoder obj) => obj.NativePtr;

        public ulong TileWidth => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_tileWidth);

        public ulong TileHeight => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_tileHeight);

        public void SetColorAttachmentMap(in IntPtr mapping)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setColorAttachmentMap, mapping);
        }

        public void SetRenderPipelineState(in MTLRenderPipelineState pipelineState)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRenderPipelineState, pipelineState);
        }

        public void SetViewport(in MTLViewport viewport)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setViewport, viewport);
        }

        public void SetViewports(in IntPtr viewports, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setViewportscount, viewports, count);
        }

        public void SetVertexAmplificationCount(in ulong count, in IntPtr viewMappings)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexAmplificationCountviewMappings, count, viewMappings);
        }

        public void SetCullMode(in MTLCullMode cullMode)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCullMode, (ulong)cullMode);
        }

        public void SetDepthClipMode(in MTLDepthClipMode depthClipMode)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthClipMode, (ulong)depthClipMode);
        }

        public void SetDepthBias(in float depthBias, in float slopeScale, in float clamp)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthBiasslopeScaleclamp, depthBias, slopeScale, clamp);
        }

        public void SetDepthTestMinBound(in float minBound, in float maxBound)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthTestMinBoundmaxBound, minBound, maxBound);
        }

        public void SetScissorRect(in MTLScissorRect rect)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setScissorRect, rect);
        }

        public void SetScissorRects(in IntPtr scissorRects, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setScissorRectscount, scissorRects, count);
        }

        public void SetTriangleFillMode(in MTLTriangleFillMode fillMode)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTriangleFillMode, (ulong)fillMode);
        }

        public void SetBlendColor(in float red, in float green, in float blue, in float alpha)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBlendColorRedgreenbluealpha, red, green, blue, alpha);
        }

        public void SetDepthStencilState(in IntPtr depthStencilState)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthStencilState, depthStencilState);
        }

        public void SetStencilReferenceValue(in uint referenceValue)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStencilReferenceValue, referenceValue);
        }

        public void SetStencilReferenceValues(in uint frontReferenceValue, in uint backReferenceValue)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStencilFrontReferenceValuebackReferenceValue, frontReferenceValue, backReferenceValue);
        }

        public void SetVisibilityResultMode(in MTLVisibilityResultMode mode, in ulong offset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVisibilityResultModeoffset, (ulong)mode, offset);
        }

        public void SetColorStoreAction(in MTLStoreAction storeAction, in ulong colorAttachmentIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setColorStoreActionatIndex, (ulong)storeAction, colorAttachmentIndex);
        }

        public void SetDepthStoreAction(in MTLStoreAction storeAction)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthStoreAction, (ulong)storeAction);
        }

        public void SetStencilStoreAction(in MTLStoreAction storeAction)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStencilStoreAction, (ulong)storeAction);
        }

        public void DrawPrimitives(in MTLPrimitiveType primitiveType, in ulong vertexStart, in ulong vertexCount)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawPrimitivesvertexStartvertexCount, (ulong)primitiveType, vertexStart, vertexCount);
        }

        public void DrawPrimitives(in MTLPrimitiveType primitiveType, in ulong vertexStart, in ulong vertexCount, in ulong instanceCount)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawPrimitivesvertexStartvertexCountinstanceCount, (ulong)primitiveType, vertexStart, vertexCount, instanceCount);
        }

        public void DrawPrimitives(in MTLPrimitiveType primitiveType, in ulong vertexStart, in ulong vertexCount, in ulong instanceCount, in ulong baseInstance)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawPrimitivesvertexStartvertexCountinstanceCountbaseInstance, (ulong)primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);
        }

        public void DrawIndexedPrimitives(in MTLPrimitiveType primitiveType, in ulong indexCount, in MTLIndexType indexType, in ulong indexBuffer, in ulong indexBufferLength)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawIndexedPrimitivesindexCountindexTypeindexBufferindexBufferLength, (ulong)primitiveType, indexCount, (ulong)indexType, indexBuffer, indexBufferLength);
        }

        public void DrawIndexedPrimitives(in MTLPrimitiveType primitiveType, in ulong indexCount, in MTLIndexType indexType, in ulong indexBuffer, in ulong indexBufferLength, in ulong instanceCount)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawIndexedPrimitivesindexCountindexTypeindexBufferindexBufferLengthinstanceCount, (ulong)primitiveType, indexCount, (ulong)indexType, indexBuffer, indexBufferLength, instanceCount);
        }

        public void DrawIndexedPrimitives(in MTLPrimitiveType primitiveType, in ulong indexCount, in MTLIndexType indexType, in ulong indexBuffer, in ulong indexBufferLength, in ulong instanceCount, in long baseVertex, in ulong baseInstance)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawIndexedPrimitivesindexCountindexTypeindexBufferindexBufferLengthinstanceCountbaseVertexbaseInstance, (ulong)primitiveType, indexCount, (ulong)indexType, indexBuffer, indexBufferLength, instanceCount, baseVertex, baseInstance);
        }

        public void DrawPrimitives(in MTLPrimitiveType primitiveType, in ulong indirectBuffer)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawPrimitivesindirectBuffer, (ulong)primitiveType, indirectBuffer);
        }

        public void DrawIndexedPrimitives(in MTLPrimitiveType primitiveType, in MTLIndexType indexType, in ulong indexBuffer, in ulong indexBufferLength, in ulong indirectBuffer)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawIndexedPrimitivesindexTypeindexBufferindexBufferLengthindirectBuffer, (ulong)primitiveType, (ulong)indexType, indexBuffer, indexBufferLength, indirectBuffer);
        }

        public void ExecuteCommandsInBuffer(in MTLIndirectCommandBuffer indirectCommandBuffer, in NSRange executionRange)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_executeCommandsInBufferwithRange, indirectCommandBuffer, executionRange);
        }

        public void ExecuteCommandsInBuffer(in MTLIndirectCommandBuffer indirectCommandBuffer, in ulong indirectRangeBuffer)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_executeCommandsInBufferindirectBuffer, indirectCommandBuffer, indirectRangeBuffer);
        }

        public void SetObjectThreadgroupMemoryLength(in ulong length, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectThreadgroupMemoryLengthatIndex, length, index);
        }

        public void DrawMeshThreadgroups(in MTLSize threadgroupsPerGrid, in MTLSize threadsPerObjectThreadgroup, in MTLSize threadsPerMeshThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawMeshThreadgroupsthreadsPerObjectThreadgroupthreadsPerMeshThreadgroup, threadgroupsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
        }

        public void DrawMeshThreads(in MTLSize threadsPerGrid, in MTLSize threadsPerObjectThreadgroup, in MTLSize threadsPerMeshThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawMeshThreadsthreadsPerObjectThreadgroupthreadsPerMeshThreadgroup, threadsPerGrid, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
        }

        public void DrawMeshThreadgroupsWithIndirectBuffer(in ulong indirectBuffer, in MTLSize threadsPerObjectThreadgroup, in MTLSize threadsPerMeshThreadgroup)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_drawMeshThreadgroupsWithIndirectBufferthreadsPerObjectThreadgroupthreadsPerMeshThreadgroup, indirectBuffer, threadsPerObjectThreadgroup, threadsPerMeshThreadgroup);
        }

        public void DispatchThreadsPerTile(in MTLSize threadsPerTile)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_dispatchThreadsPerTile, threadsPerTile);
        }

        public void SetThreadgroupMemoryLength(in ulong length, in ulong offset, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setThreadgroupMemoryLengthoffsetatIndex, length, offset, index);
        }

        public void SetArgumentTable(in IntPtr argumentTable, in ulong stages)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setArgumentTableatStages, argumentTable, stages);
        }

        public void SetFrontFacingWinding(in MTLWinding frontFacingWinding)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFrontFacingWinding, (ulong)frontFacingWinding);
        }

        public void WriteTimestamp(in long granularity, in ulong afterStage, in IntPtr counterHeap, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_writeTimestampWithGranularityafterStageintoHeapatIndex, granularity, afterStage, counterHeap, index);
        }

        private static readonly Selector sel_tileWidth = "tileWidth";
        private static readonly Selector sel_tileHeight = "tileHeight";
        private static readonly Selector sel_setColorAttachmentMap = "setColorAttachmentMap:";
        private static readonly Selector sel_setRenderPipelineState = "setRenderPipelineState:";
        private static readonly Selector sel_setViewport = "setViewport:";
        private static readonly Selector sel_setViewportscount = "setViewports:count:";
        private static readonly Selector sel_setVertexAmplificationCountviewMappings = "setVertexAmplificationCount:viewMappings:";
        private static readonly Selector sel_setCullMode = "setCullMode:";
        private static readonly Selector sel_setDepthClipMode = "setDepthClipMode:";
        private static readonly Selector sel_setDepthBiasslopeScaleclamp = "setDepthBias:slopeScale:clamp:";
        private static readonly Selector sel_setDepthTestMinBoundmaxBound = "setDepthTestMinBound:maxBound:";
        private static readonly Selector sel_setScissorRect = "setScissorRect:";
        private static readonly Selector sel_setScissorRectscount = "setScissorRects:count:";
        private static readonly Selector sel_setTriangleFillMode = "setTriangleFillMode:";
        private static readonly Selector sel_setBlendColorRedgreenbluealpha = "setBlendColorRed:green:blue:alpha:";
        private static readonly Selector sel_setDepthStencilState = "setDepthStencilState:";
        private static readonly Selector sel_setStencilReferenceValue = "setStencilReferenceValue:";
        private static readonly Selector sel_setStencilFrontReferenceValuebackReferenceValue = "setStencilFrontReferenceValue:backReferenceValue:";
        private static readonly Selector sel_setVisibilityResultModeoffset = "setVisibilityResultMode:offset:";
        private static readonly Selector sel_setColorStoreActionatIndex = "setColorStoreAction:atIndex:";
        private static readonly Selector sel_setDepthStoreAction = "setDepthStoreAction:";
        private static readonly Selector sel_setStencilStoreAction = "setStencilStoreAction:";
        private static readonly Selector sel_drawPrimitivesvertexStartvertexCount = "drawPrimitives:vertexStart:vertexCount:";
        private static readonly Selector sel_drawPrimitivesvertexStartvertexCountinstanceCount = "drawPrimitives:vertexStart:vertexCount:instanceCount:";
        private static readonly Selector sel_drawPrimitivesvertexStartvertexCountinstanceCountbaseInstance = "drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:";
        private static readonly Selector sel_drawIndexedPrimitivesindexCountindexTypeindexBufferindexBufferLength = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:";
        private static readonly Selector sel_drawIndexedPrimitivesindexCountindexTypeindexBufferindexBufferLengthinstanceCount = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:";
        private static readonly Selector sel_drawIndexedPrimitivesindexCountindexTypeindexBufferindexBufferLengthinstanceCountbaseVertexbaseInstance = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferLength:instanceCount:baseVertex:baseInstance:";
        private static readonly Selector sel_drawPrimitivesindirectBuffer = "drawPrimitives:indirectBuffer:";
        private static readonly Selector sel_drawIndexedPrimitivesindexTypeindexBufferindexBufferLengthindirectBuffer = "drawIndexedPrimitives:indexType:indexBuffer:indexBufferLength:indirectBuffer:";
        private static readonly Selector sel_executeCommandsInBufferwithRange = "executeCommandsInBuffer:withRange:";
        private static readonly Selector sel_executeCommandsInBufferindirectBuffer = "executeCommandsInBuffer:indirectBuffer:";
        private static readonly Selector sel_setObjectThreadgroupMemoryLengthatIndex = "setObjectThreadgroupMemoryLength:atIndex:";
        private static readonly Selector sel_drawMeshThreadgroupsthreadsPerObjectThreadgroupthreadsPerMeshThreadgroup = "drawMeshThreadgroups:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:";
        private static readonly Selector sel_drawMeshThreadsthreadsPerObjectThreadgroupthreadsPerMeshThreadgroup = "drawMeshThreads:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:";
        private static readonly Selector sel_drawMeshThreadgroupsWithIndirectBufferthreadsPerObjectThreadgroupthreadsPerMeshThreadgroup = "drawMeshThreadgroupsWithIndirectBuffer:threadsPerObjectThreadgroup:threadsPerMeshThreadgroup:";
        private static readonly Selector sel_dispatchThreadsPerTile = "dispatchThreadsPerTile:";
        private static readonly Selector sel_setThreadgroupMemoryLengthoffsetatIndex = "setThreadgroupMemoryLength:offset:atIndex:";
        private static readonly Selector sel_setArgumentTableatStages = "setArgumentTable:atStages:";
        private static readonly Selector sel_setFrontFacingWinding = "setFrontFacingWinding:";
        private static readonly Selector sel_writeTimestampWithGranularityafterStageintoHeapatIndex = "writeTimestampWithGranularity:afterStage:intoHeap:atIndex:";
    }
}
