using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLResourceStatePassSampleBufferAttachmentDescriptor
    {
        public IntPtr NativePtr;

        public MTLResourceStatePassSampleBufferAttachmentDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLResourceStatePassSampleBufferAttachmentDescriptor New() => s_class.AllocInit<MTLResourceStatePassSampleBufferAttachmentDescriptor>();

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

        public static implicit operator IntPtr(in MTLResourceStatePassSampleBufferAttachmentDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLResourceStatePassSampleBufferAttachmentDescriptor));
        private static readonly Selector sel_sampleBuffer = "sampleBuffer";
        private static readonly Selector sel_setSampleBuffer = "setSampleBuffer:";
        private static readonly Selector sel_startOfEncoderSampleIndex = "startOfEncoderSampleIndex";
        private static readonly Selector sel_setStartOfEncoderSampleIndex = "setStartOfEncoderSampleIndex:";
        private static readonly Selector sel_endOfEncoderSampleIndex = "endOfEncoderSampleIndex";
        private static readonly Selector sel_setEndOfEncoderSampleIndex = "setEndOfEncoderSampleIndex:";
    }

    public partial struct MTLResourceStatePassSampleBufferAttachmentDescriptorArray
    {
        public IntPtr NativePtr;

        public MTLResourceStatePassSampleBufferAttachmentDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

        public static MTLResourceStatePassSampleBufferAttachmentDescriptorArray New() => s_class.AllocInit<MTLResourceStatePassSampleBufferAttachmentDescriptorArray>();

        public MTLResourceStatePassSampleBufferAttachmentDescriptor this[uint index]
        {
            get
            {
                return Object(index);
            }
            set
            {
                SetObject(value, index);
            }
        }

        public MTLResourceStatePassSampleBufferAttachmentDescriptor Object(in ulong attachmentIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, attachmentIndex));
        }

        public void SetObject(in MTLResourceStatePassSampleBufferAttachmentDescriptor attachment, in ulong attachmentIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, attachment, attachmentIndex);
        }

        public static implicit operator IntPtr(in MTLResourceStatePassSampleBufferAttachmentDescriptorArray obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLResourceStatePassSampleBufferAttachmentDescriptorArray));
        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    
    public partial struct MTLResourceStatePassDescriptor
    {
        public IntPtr NativePtr;

        public MTLResourceStatePassDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLResourceStatePassDescriptor New() => s_class.AllocInit<MTLResourceStatePassDescriptor>();

        public MTLResourceStatePassSampleBufferAttachmentDescriptorArray SampleBufferAttachments => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_sampleBufferAttachments));

        public static implicit operator IntPtr(in MTLResourceStatePassDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLResourceStatePassDescriptor));
        private static readonly Selector sel_resourceStatePassDescriptor = "resourceStatePassDescriptor";
        private static readonly Selector sel_sampleBufferAttachments = "sampleBufferAttachments";
    }
}
