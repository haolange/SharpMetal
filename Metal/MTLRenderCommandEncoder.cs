using System;
using System.Runtime.InteropServices;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLRenderCommandEncoder
    {
        public readonly IntPtr NativePtr;
        public MTLRenderCommandEncoder(in IntPtr ptr) => NativePtr = ptr;
        public bool IsNull => NativePtr == IntPtr.Zero;

        public void setRenderPipelineState(in MTLRenderPipelineState pipelineState)
            => objc_msgSend(NativePtr, sel_setRenderPipelineState, pipelineState.NativePtr);

        public void setVertexBuffer(in MTLBuffer buffer, in UIntPtr offset, in UIntPtr index)
            => objc_msgSend(NativePtr, sel_setVertexBuffer,
                buffer.NativePtr,
                offset,
                index);

        public void setFragmentBuffer(in MTLBuffer buffer, in UIntPtr offset, in UIntPtr index)
            => objc_msgSend(NativePtr, sel_setFragmentBuffer,
                buffer.NativePtr,
                offset,
                index);

        public void setVertexTexture(in MTLTexture texture, in UIntPtr index)
            => objc_msgSend(NativePtr, sel_setVertexTexture, texture.NativePtr, index);
        public void setFragmentTexture(in MTLTexture texture, in UIntPtr index)
            => objc_msgSend(NativePtr, sel_setFragmentTexture, texture.NativePtr, index);

        public void setVertexSamplerState(in MTLSamplerState sampler, in UIntPtr index)
            => objc_msgSend(NativePtr, sel_setVertexSamplerState, sampler.NativePtr, index);

        public void setFragmentSamplerState(in MTLSamplerState sampler, in UIntPtr index)
            => objc_msgSend(NativePtr, sel_setFragmentSamplerState, sampler.NativePtr, index);

        public void drawPrimitives(
            in MTLPrimitiveType primitiveType,
            in UIntPtr vertexStart,
            in UIntPtr vertexCount,
            in UIntPtr instanceCount,
            in UIntPtr baseInstance)
            => objc_msgSend(NativePtr, sel_drawPrimitives0,
                primitiveType, vertexStart, vertexCount, instanceCount, baseInstance);

        public void drawPrimitives(
            in MTLPrimitiveType primitiveType,
            in UIntPtr vertexStart,
            in UIntPtr vertexCount,
            in UIntPtr instanceCount)
            => objc_msgSend(NativePtr, sel_drawPrimitives2,
                primitiveType, vertexStart, vertexCount, instanceCount);

        public void drawPrimitives(in MTLPrimitiveType primitiveType, in MTLBuffer indirectBuffer, in UIntPtr indirectBufferOffset)
            => objc_msgSend(NativePtr, sel_drawPrimitives1,
                primitiveType, indirectBuffer, indirectBufferOffset);

        public void drawIndexedPrimitives(
            in MTLPrimitiveType primitiveType,
            in UIntPtr indexCount,
            in MTLIndexType indexType,
            in MTLBuffer indexBuffer,
            in UIntPtr indexBufferOffset,
            in UIntPtr instanceCount)
            => objc_msgSend(NativePtr, sel_drawIndexedPrimitives0,
                primitiveType, indexCount, indexType, indexBuffer.NativePtr, indexBufferOffset, instanceCount);

        public void drawIndexedPrimitives(
            in MTLPrimitiveType primitiveType,
            in UIntPtr indexCount,
            in MTLIndexType indexType,
            in MTLBuffer indexBuffer,
            in UIntPtr indexBufferOffset,
            in UIntPtr instanceCount,
            in IntPtr baseVertex,
            in UIntPtr baseInstance)
            => objc_msgSend(
                NativePtr,
                sel_drawIndexedPrimitives1,
                primitiveType, indexCount, indexType, indexBuffer.NativePtr, indexBufferOffset, instanceCount, baseVertex, baseInstance);

        public void drawIndexedPrimitives(
            in MTLPrimitiveType primitiveType,
            in MTLIndexType indexType,
            in MTLBuffer indexBuffer,
            in UIntPtr indexBufferOffset,
            in MTLBuffer indirectBuffer,
            in UIntPtr indirectBufferOffset)
            => objc_msgSend(NativePtr, sel_drawIndexedPrimitives2,
                primitiveType,
                indexType,
                indexBuffer,
                indexBufferOffset,
                indirectBuffer,
                indirectBufferOffset);

        public unsafe void setViewport(in MTLViewport viewport)
            => objc_msgSend(NativePtr, sel_setViewport, viewport);

        public unsafe void setViewports(in MTLViewport* viewports, in UIntPtr count)
            => objc_msgSend(NativePtr, sel_setViewports, viewports, count);

        public unsafe void setScissorRect(in MTLScissorRect scissorRect)
            => objc_msgSend(NativePtr, sel_setScissorRect, scissorRect);

        public unsafe void setScissorRects(in MTLScissorRect* scissorRects, in UIntPtr count)
            => objc_msgSend(NativePtr, sel_setScissorRects, scissorRects, count);

        public void setCullMode(in MTLCullMode cullMode)
            => objc_msgSend(NativePtr, sel_setCullMode, (uint)cullMode);

        public void setFrontFacing(in MTLWinding frontFaceWinding)
            => objc_msgSend(NativePtr, sel_setFrontFacingWinding, (uint)frontFaceWinding);

        public void setDepthStencilState(in MTLDepthStencilState depthStencilState)
            => objc_msgSend(NativePtr, sel_setDepthStencilState, depthStencilState.NativePtr);

        public void setDepthClipMode(in MTLDepthClipMode depthClipMode)
            => objc_msgSend(NativePtr, sel_setDepthClipMode, (uint)depthClipMode);

        public void endEncoding() => objc_msgSend(NativePtr, sel_endEncoding);

        public void setStencilReferenceValue(in uint stencilReference)
            => objc_msgSend(NativePtr, sel_setStencilReferenceValue, stencilReference);

        public void setBlendColor(in float red, in float green, in float blue, in float alpha)
            => objc_msgSend(NativePtr, sel_setBlendColor, red, green, blue, alpha);

        public void setTriangleFillMode(in MTLTriangleFillMode fillMode)
            => objc_msgSend(NativePtr, sel_setTriangleFillMode, (uint)fillMode);

        public void pushDebugGroup(in NSString @string)
            => objc_msgSend(NativePtr, Selectors.pushDebugGroup, @string.NativePtr);

        public void popDebugGroup() => objc_msgSend(NativePtr, Selectors.popDebugGroup);

        public void insertDebugSignpost(in NSString @string)
            => objc_msgSend(NativePtr, Selectors.insertDebugSignpost, @string.NativePtr);

        private static readonly Selector sel_setRenderPipelineState = "setRenderPipelineState:";
        private static readonly Selector sel_setVertexBuffer = "setVertexBuffer:offset:atIndex:";
        private static readonly Selector sel_setFragmentBuffer = "setFragmentBuffer:offset:atIndex:";
        private static readonly Selector sel_setVertexTexture = "setVertexTexture:atIndex:";
        private static readonly Selector sel_setFragmentTexture = "setFragmentTexture:atIndex:";
        private static readonly Selector sel_setVertexSamplerState = "setVertexSamplerState:atIndex:";
        private static readonly Selector sel_setFragmentSamplerState = "setFragmentSamplerState:atIndex:";
        private static readonly Selector sel_drawPrimitives0 = "drawPrimitives:vertexStart:vertexCount:instanceCount:baseInstance:";
        private static readonly Selector sel_drawPrimitives1 = "drawPrimitives:indirectBuffer:indirectBufferOffset:";
        private static readonly Selector sel_drawPrimitives2 = "drawPrimitives:vertexStart:vertexCount:instanceCount:";
        private static readonly Selector sel_drawIndexedPrimitives0 = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:";
        private static readonly Selector sel_drawIndexedPrimitives1 = "drawIndexedPrimitives:indexCount:indexType:indexBuffer:indexBufferOffset:instanceCount:baseVertex:baseInstance:";
        private static readonly Selector sel_drawIndexedPrimitives2 = "drawIndexedPrimitives:indexType:indexBuffer:indexBufferOffset:indirectBuffer:indirectBufferOffset:";
        private static readonly Selector sel_setViewport = "setViewport:";
        private static readonly Selector sel_setViewports = "setViewports:count:";
        private static readonly Selector sel_setScissorRect = "setScissorRect:";
        private static readonly Selector sel_setScissorRects = "setScissorRects:count:";
        private static readonly Selector sel_setCullMode = "setCullMode:";
        private static readonly Selector sel_setFrontFacingWinding = "setFrontFacingWinding:";
        private static readonly Selector sel_setDepthStencilState = "setDepthStencilState:";
        private static readonly Selector sel_setDepthClipMode = "setDepthClipMode:";
        private static readonly Selector sel_endEncoding = "endEncoding";
        private static readonly Selector sel_setStencilReferenceValue = "setStencilReferenceValue:";
        private static readonly Selector sel_setBlendColor = "setBlendColorRed:green:blue:alpha:";
        private static readonly Selector sel_setTriangleFillMode = "setTriangleFillMode:";
    }
}
