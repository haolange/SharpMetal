using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLMutability : ulong
    {
        Default = 0,
        Mutable = 1,
        Immutable = 2,
    }

    public enum MTLShaderValidation : ulong
    {
        ShaderValidationDefault = 0,
        ShaderValidationEnabled = 1,
        ShaderValidationDisabled = 2,
    }

    public partial struct MTLPipelineBufferDescriptor
    {
        public IntPtr NativePtr;

        public MTLPipelineBufferDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLPipelineBufferDescriptor New() => s_class.AllocInit<MTLPipelineBufferDescriptor>();

        public MTLMutability Mutability
        {
            get => (MTLMutability)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_mutability);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMutability, (ulong)value);
        }

        public static implicit operator IntPtr(in MTLPipelineBufferDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLPipelineBufferDescriptor));
        private static readonly Selector sel_mutability = "mutability";
        private static readonly Selector sel_setMutability = "setMutability:";
    }

    public partial struct MTLPipelineBufferDescriptorArray
    {
        public IntPtr NativePtr;

        public MTLPipelineBufferDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

        public static MTLPipelineBufferDescriptorArray New() => s_class.AllocInit<MTLPipelineBufferDescriptorArray>();

        public MTLPipelineBufferDescriptor Object(ulong bufferIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, bufferIndex));
        }

        public void SetObject(MTLPipelineBufferDescriptor buffer, ulong bufferIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, buffer, bufferIndex);
        }

        public static implicit operator IntPtr(in MTLPipelineBufferDescriptorArray obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLPipelineBufferDescriptorArray));
        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }
}
