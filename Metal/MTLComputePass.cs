using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    
    public partial struct MTLComputePassSampleBufferAttachmentDescriptor
    {
        public IntPtr NativePtr;

        public MTLComputePassSampleBufferAttachmentDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLComputePassSampleBufferAttachmentDescriptor New() => s_class.AllocInit<MTLComputePassSampleBufferAttachmentDescriptor>();

        public MTLCounterSampleBuffer SampleBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_sampleBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSampleBuffer, value);
        }
       
        public ulong StartOfEncoderSampleIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_startOfEncoderSampleIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStartOfEncoderSampleIndex, value);
        }
        
        public ulong EndOfEncoderSampleIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_endOfEncoderSampleIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setEndOfEncoderSampleIndex, value);
        }

        public static implicit operator IntPtr(in MTLComputePassSampleBufferAttachmentDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLComputePassSampleBufferAttachmentDescriptor));
        private static readonly Selector sel_sampleBuffer = "sampleBuffer";
        private static readonly Selector sel_setSampleBuffer = "setSampleBuffer:";
        private static readonly Selector sel_startOfEncoderSampleIndex = "startOfEncoderSampleIndex";
        private static readonly Selector sel_setStartOfEncoderSampleIndex = "setStartOfEncoderSampleIndex:";
        private static readonly Selector sel_endOfEncoderSampleIndex = "endOfEncoderSampleIndex";
        private static readonly Selector sel_setEndOfEncoderSampleIndex = "setEndOfEncoderSampleIndex:";
    }

    
    public partial struct MTLComputePassSampleBufferAttachmentDescriptorArray
    {
        public IntPtr NativePtr;

        public MTLComputePassSampleBufferAttachmentDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

        public static MTLComputePassSampleBufferAttachmentDescriptorArray New() => s_class.AllocInit<MTLComputePassSampleBufferAttachmentDescriptorArray>();

        public MTLComputePassSampleBufferAttachmentDescriptor Object(in ulong attachmentIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, attachmentIndex));
        }

        public void SetObject(in MTLComputePassSampleBufferAttachmentDescriptor attachment, in ulong attachmentIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, attachment, attachmentIndex);
        }

        public static implicit operator IntPtr(in MTLComputePassSampleBufferAttachmentDescriptorArray obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLComputePassSampleBufferAttachmentDescriptorArray));
        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    
    public partial struct MTLComputePassDescriptor
    {
        public IntPtr NativePtr;

        public MTLComputePassDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLComputePassDescriptor New() => s_class.AllocInit<MTLComputePassDescriptor>();

        public MTLDispatchType DispatchType
        {
            get => (MTLDispatchType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_dispatchType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDispatchType, (ulong)value);
        }
        
        public MTLComputePassSampleBufferAttachmentDescriptorArray SampleBufferAttachments => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_sampleBufferAttachments));

        public static implicit operator IntPtr(in MTLComputePassDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLComputePassDescriptor));
        private static readonly Selector sel_computePassDescriptor = "computePassDescriptor";
        private static readonly Selector sel_dispatchType = "dispatchType";
        private static readonly Selector sel_setDispatchType = "setDispatchType:";
        private static readonly Selector sel_sampleBufferAttachments = "sampleBufferAttachments";
    }
}
