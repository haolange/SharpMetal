using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLResourceStatePassSampleBufferAttachmentDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLResourceStatePassSampleBufferAttachmentDescriptor obj) => obj.NativePtr;
        public MTLResourceStatePassSampleBufferAttachmentDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public MTLResourceStatePassSampleBufferAttachmentDescriptor()
        {
            var cls = new ObjectiveCClass("MTLResourceStatePassSampleBufferAttachmentDescriptor");
            NativePtr = cls.AllocInit();
        }

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
        public static implicit operator IntPtr(in MTLResourceStatePassSampleBufferAttachmentDescriptorArray obj) => obj.NativePtr;
        public MTLResourceStatePassSampleBufferAttachmentDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

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

        public MTLResourceStatePassSampleBufferAttachmentDescriptorArray()
        {
            var cls = new ObjectiveCClass("MTLResourceStatePassSampleBufferAttachmentDescriptorArray");
            NativePtr = cls.AllocInit();
        }

        public MTLResourceStatePassSampleBufferAttachmentDescriptor Object(in ulong attachmentIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, attachmentIndex));
        }

        public void SetObject(in MTLResourceStatePassSampleBufferAttachmentDescriptor attachment, in ulong attachmentIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, attachment, attachmentIndex);
        }

        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    
    public partial struct MTLResourceStatePassDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLResourceStatePassDescriptor obj) => obj.NativePtr;
        public MTLResourceStatePassDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public MTLResourceStatePassDescriptor()
        {
            var cls = new ObjectiveCClass("MTLResourceStatePassDescriptor");
            NativePtr = cls.AllocInit();
        }

        public MTLResourceStatePassSampleBufferAttachmentDescriptorArray SampleBufferAttachments => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_sampleBufferAttachments));

        private static readonly Selector sel_resourceStatePassDescriptor = "resourceStatePassDescriptor";
        private static readonly Selector sel_sampleBufferAttachments = "sampleBufferAttachments";
    }
}
