using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLBlitPassSampleBufferAttachmentDescriptor
    {
        public IntPtr NativePtr;

        public MTLBlitPassSampleBufferAttachmentDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLBlitPassSampleBufferAttachmentDescriptor New() => s_class.AllocInit<MTLBlitPassSampleBufferAttachmentDescriptor>();

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

        public static implicit operator IntPtr(in MTLBlitPassSampleBufferAttachmentDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLBlitPassSampleBufferAttachmentDescriptor));
        private static readonly Selector sel_sampleBuffer = "sampleBuffer";
        private static readonly Selector sel_setSampleBuffer = "setSampleBuffer:";
        private static readonly Selector sel_startOfEncoderSampleIndex = "startOfEncoderSampleIndex";
        private static readonly Selector sel_setStartOfEncoderSampleIndex = "setStartOfEncoderSampleIndex:";
        private static readonly Selector sel_endOfEncoderSampleIndex = "endOfEncoderSampleIndex";
        private static readonly Selector sel_setEndOfEncoderSampleIndex = "setEndOfEncoderSampleIndex:";
    }

    public partial struct MTLBlitPassSampleBufferAttachmentDescriptorArray
    {
        public IntPtr NativePtr;

        public MTLBlitPassSampleBufferAttachmentDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

        public static MTLBlitPassSampleBufferAttachmentDescriptorArray New() => s_class.AllocInit<MTLBlitPassSampleBufferAttachmentDescriptorArray>();

        public MTLBlitPassSampleBufferAttachmentDescriptor Object(in ulong attachmentIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, attachmentIndex));
        }

        public void SetObject(in MTLBlitPassSampleBufferAttachmentDescriptor attachment, in ulong attachmentIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, attachment, attachmentIndex);
        }

        public static implicit operator IntPtr(in MTLBlitPassSampleBufferAttachmentDescriptorArray obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLBlitPassSampleBufferAttachmentDescriptorArray));
        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    public partial struct MTLBlitPassDescriptor
    {
        public IntPtr NativePtr;

        public MTLBlitPassDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLBlitPassDescriptor New() => s_class.AllocInit<MTLBlitPassDescriptor>();

        public MTLBlitPassSampleBufferAttachmentDescriptorArray SampleBufferAttachments => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_sampleBufferAttachments));

        public static implicit operator IntPtr(in MTLBlitPassDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLBlitPassDescriptor));
        private static readonly Selector sel_blitPassDescriptor = "blitPassDescriptor";
        private static readonly Selector sel_sampleBufferAttachments = "sampleBufferAttachments";
    }
}
