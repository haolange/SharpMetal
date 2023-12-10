using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLMutability : ulong
    {
        Default = 0,
        Mutable = 1,
        Immutable = 2,
    }
    
    public partial struct MTLPipelineBufferDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLPipelineBufferDescriptor obj) => obj.NativePtr;
        public MTLPipelineBufferDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public MTLPipelineBufferDescriptor()
        {
            var cls = new ObjectiveCClass("MTLPipelineBufferDescriptor");
            NativePtr = cls.AllocInit();
        }

        public MTLMutability Mutability
        {
            get => (MTLMutability)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_mutability);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMutability, (ulong)value);
        }

        private static readonly Selector sel_mutability = "mutability";
        private static readonly Selector sel_setMutability = "setMutability:";
    }

    public partial struct MTLPipelineBufferDescriptorArray
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLPipelineBufferDescriptorArray obj) => obj.NativePtr;
        public MTLPipelineBufferDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

        public MTLPipelineBufferDescriptorArray()
        {
            var cls = new ObjectiveCClass("MTLPipelineBufferDescriptorArray");
            NativePtr = cls.AllocInit();
        }

        public MTLPipelineBufferDescriptor Object(ulong bufferIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, bufferIndex));
        }

        public void SetObject(MTLPipelineBufferDescriptor buffer, ulong bufferIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, buffer, bufferIndex);
        }

        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }
}
