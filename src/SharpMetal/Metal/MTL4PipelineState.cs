using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTL4ShaderReflection : ulong
    {
        None = 0,
        BindingInfo = 1,
        BufferTypeInfo = 2,
    }

    public enum MTL4AlphaToOneState : long
    {
        Disabled = 0,
        Enabled = 1,
    }

    public enum MTL4AlphaToCoverageState : long
    {
        Disabled = 0,
        Enabled = 1,
    }

    public enum MTL4BlendState : long
    {
        Disabled = 0,
        Enabled = 1,
        Unspecialized = 2,
    }

    public enum MTL4IndirectCommandBufferSupportState : long
    {
        Disabled = 0,
        Enabled = 1,
    }

    public partial struct MTL4PipelineOptions
    {
        public IntPtr NativePtr;

        public MTL4PipelineOptions(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4PipelineOptions New() => s_class.AllocInit<MTL4PipelineOptions>();

        public long ShaderValidation
        {
            get => ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_shaderValidation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setShaderValidation, value);
        }

        public MTL4ShaderReflection ShaderReflection
        {
            get => (MTL4ShaderReflection)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_shaderReflection);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setShaderReflection, (ulong)value);
        }

        public static implicit operator IntPtr(in MTL4PipelineOptions obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4PipelineOptions));
        private static readonly Selector sel_shaderValidation = "shaderValidation";
        private static readonly Selector sel_setShaderValidation = "setShaderValidation:";
        private static readonly Selector sel_shaderReflection = "shaderReflection";
        private static readonly Selector sel_setShaderReflection = "setShaderReflection:";
    }

    public partial struct MTL4PipelineDescriptor
    {
        public IntPtr NativePtr;

        public MTL4PipelineDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4PipelineDescriptor New() => s_class.AllocInit<MTL4PipelineDescriptor>();

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTL4PipelineOptions Options
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_options));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOptions, value);
        }

        public static implicit operator IntPtr(in MTL4PipelineDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4PipelineDescriptor));
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_options = "options";
        private static readonly Selector sel_setOptions = "setOptions:";
    }
}
