using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTL4PipelineDataSetSerializerConfiguration : ulong
    {
        CaptureDescriptors = 1,
        CaptureBinaries = 2,
    }

    public partial struct MTL4Archive
    {
        public IntPtr NativePtr;

        public MTL4Archive(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4Archive obj) => obj.NativePtr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLComputePipelineState NewComputePipelineState(in MTL4ComputePipelineDescriptor descriptor, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newComputePipelineStateWithDescriptorerror, descriptor, ref error.NativePtr));
        }

        public MTLComputePipelineState NewComputePipelineState(in MTL4ComputePipelineDescriptor descriptor, in MTL4PipelineStageDynamicLinkingDescriptor dynamicLinkingDescriptor, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newComputePipelineStateWithDescriptordynamicLinkingDescriptorerror, descriptor, dynamicLinkingDescriptor, ref error.NativePtr));
        }

        public MTLRenderPipelineState NewRenderPipelineState(in MTL4PipelineDescriptor descriptor, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newRenderPipelineStateWithDescriptorerror, descriptor, ref error.NativePtr));
        }

        public MTLRenderPipelineState NewRenderPipelineState(in MTL4PipelineDescriptor descriptor, in MTL4RenderPipelineDynamicLinkingDescriptor dynamicLinkingDescriptor, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newRenderPipelineStateWithDescriptordynamicLinkingDescriptorerror, descriptor, dynamicLinkingDescriptor, ref error.NativePtr));
        }

        public MTL4BinaryFunction NewBinaryFunction(in MTL4BinaryFunctionDescriptor descriptor, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newBinaryFunctionWithDescriptorerror, descriptor, ref error.NativePtr));
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_newComputePipelineStateWithDescriptorerror = "newComputePipelineStateWithDescriptor:error:";
        private static readonly Selector sel_newComputePipelineStateWithDescriptordynamicLinkingDescriptorerror = "newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:error:";
        private static readonly Selector sel_newRenderPipelineStateWithDescriptorerror = "newRenderPipelineStateWithDescriptor:error:";
        private static readonly Selector sel_newRenderPipelineStateWithDescriptordynamicLinkingDescriptorerror = "newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:error:";
        private static readonly Selector sel_newBinaryFunctionWithDescriptorerror = "newBinaryFunctionWithDescriptor:error:";
    }

    public partial struct MTL4PipelineDataSetSerializerDescriptor
    {
        public IntPtr NativePtr;

        public MTL4PipelineDataSetSerializerDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4PipelineDataSetSerializerDescriptor New() => s_class.AllocInit<MTL4PipelineDataSetSerializerDescriptor>();

        public MTL4PipelineDataSetSerializerConfiguration Configuration
        {
            get => (MTL4PipelineDataSetSerializerConfiguration)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_configuration);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setConfiguration, (ulong)value);
        }

        public static implicit operator IntPtr(in MTL4PipelineDataSetSerializerDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4PipelineDataSetSerializerDescriptor));
        private static readonly Selector sel_configuration = "configuration";
        private static readonly Selector sel_setConfiguration = "setConfiguration:";
    }

    public partial struct MTL4PipelineDataSetSerializer
    {
        public IntPtr NativePtr;

        public MTL4PipelineDataSetSerializer(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4PipelineDataSetSerializer obj) => obj.NativePtr;

        public bool SerializeAsArchiveAndFlushToURL(in NSURL url, ref NSError error)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_serializeAsArchiveAndFlushToURLerror, url, ref error.NativePtr);
        }

        public IntPtr SerializeAsPipelinesScript(ref NSError error)
        {
            return ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_serializeAsPipelinesScriptWithError, ref error.NativePtr);
        }

        private static readonly Selector sel_serializeAsArchiveAndFlushToURLerror = "serializeAsArchiveAndFlushToURL:error:";
        private static readonly Selector sel_serializeAsPipelinesScriptWithError = "serializeAsPipelinesScriptWithError:";
    }
}
