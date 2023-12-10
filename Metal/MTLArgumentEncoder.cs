using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    
    public partial struct MTLArgumentEncoder
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLArgumentEncoder obj) => obj.NativePtr;
        public MTLArgumentEncoder(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public ulong EncodedLength => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_encodedLength);

        public ulong Alignment => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_alignment);

        public void SetArgumentBuffer(in MTLBuffer argumentBuffer, in ulong offset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setArgumentBufferoffset, argumentBuffer, offset);
        }

        public void SetArgumentBuffer(MTLBuffer argumentBuffer, in ulong startOffset, in ulong arrayElement)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setArgumentBufferstartOffsetarrayElement, argumentBuffer, startOffset, arrayElement);
        }

        public void SetBuffer(in MTLBuffer buffer, in ulong offset, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBufferoffsetatIndex, buffer, offset, index);
        }

        public void SetBuffers(MTLBuffer[] buffers, ulong[] offsets, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetTexture(MTLTexture texture, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTextureatIndex, texture, index);
        }

        public void SetTextures(MTLTexture[] textures, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetSamplerState(MTLSamplerState sampler, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSamplerStateatIndex, sampler, index);
        }

        public void SetSamplerStates(MTLSamplerState[] samplers, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public IntPtr ConstantData(in ulong index)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_constantDataAtIndex, index));
        }

        public void SetRenderPipelineState(in MTLRenderPipelineState pipeline, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRenderPipelineStateatIndex, pipeline, index);
        }

        public void SetRenderPipelineStates(MTLRenderPipelineState[] pipelines, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetComputePipelineState(in MTLComputePipelineState pipeline, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setComputePipelineStateatIndex, pipeline, index);
        }

        public void SetComputePipelineStates(MTLComputePipelineState[] pipelines, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetIndirectCommandBuffer(in MTLIndirectCommandBuffer indirectCommandBuffer, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndirectCommandBufferatIndex, indirectCommandBuffer, index);
        }

        public void SetIndirectCommandBuffers(MTLIndirectCommandBuffer[] buffers, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetAccelerationStructure(in MTLAccelerationStructure accelerationStructure, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAccelerationStructureatIndex, accelerationStructure, index);
        }

        public MTLArgumentEncoder NewArgumentEncoder(in ulong index)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newArgumentEncoderForBufferAtIndex, index));
        }

        public void SetVisibleFunctionTable(in MTLVisibleFunctionTable visibleFunctionTable, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVisibleFunctionTableatIndex, visibleFunctionTable, index);
        }

        public void SetVisibleFunctionTables(MTLVisibleFunctionTable[] visibleFunctionTables, in NSRange range)
        {
            throw new NotImplementedException();
        }

        public void SetIntersectionFunctionTable(in MTLIntersectionFunctionTable intersectionFunctionTable, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIntersectionFunctionTableatIndex, intersectionFunctionTable, index);
        }

        public void SetIntersectionFunctionTables(MTLIntersectionFunctionTable[] intersectionFunctionTables, in NSRange range)
        {
            throw new NotImplementedException();
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_encodedLength = "encodedLength";
        private static readonly Selector sel_alignment = "alignment";
        private static readonly Selector sel_setArgumentBufferoffset = "setArgumentBuffer:offset:";
        private static readonly Selector sel_setArgumentBufferstartOffsetarrayElement = "setArgumentBuffer:startOffset:arrayElement:";
        private static readonly Selector sel_setBufferoffsetatIndex = "setBuffer:offset:atIndex:";
        private static readonly Selector sel_setBuffersoffsetswithRange = "setBuffers:offsets:withRange:";
        private static readonly Selector sel_setTextureatIndex = "setTexture:atIndex:";
        private static readonly Selector sel_setTextureswithRange = "setTextures:withRange:";
        private static readonly Selector sel_setSamplerStateatIndex = "setSamplerState:atIndex:";
        private static readonly Selector sel_setSamplerStateswithRange = "setSamplerStates:withRange:";
        private static readonly Selector sel_constantDataAtIndex = "constantDataAtIndex:";
        private static readonly Selector sel_setRenderPipelineStateatIndex = "setRenderPipelineState:atIndex:";
        private static readonly Selector sel_setRenderPipelineStateswithRange = "setRenderPipelineStates:withRange:";
        private static readonly Selector sel_setComputePipelineStateatIndex = "setComputePipelineState:atIndex:";
        private static readonly Selector sel_setComputePipelineStateswithRange = "setComputePipelineStates:withRange:";
        private static readonly Selector sel_setIndirectCommandBufferatIndex = "setIndirectCommandBuffer:atIndex:";
        private static readonly Selector sel_setIndirectCommandBufferswithRange = "setIndirectCommandBuffers:withRange:";
        private static readonly Selector sel_setAccelerationStructureatIndex = "setAccelerationStructure:atIndex:";
        private static readonly Selector sel_newArgumentEncoderForBufferAtIndex = "newArgumentEncoderForBufferAtIndex:";
        private static readonly Selector sel_setVisibleFunctionTableatIndex = "setVisibleFunctionTable:atIndex:";
        private static readonly Selector sel_setVisibleFunctionTableswithRange = "setVisibleFunctionTables:withRange:";
        private static readonly Selector sel_setIntersectionFunctionTableatIndex = "setIntersectionFunctionTable:atIndex:";
        private static readonly Selector sel_setIntersectionFunctionTableswithRange = "setIntersectionFunctionTables:withRange:";
    }
}
