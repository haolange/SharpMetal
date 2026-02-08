using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTL4CompilerTaskStatus : long
    {
        None = 0,
        Scheduled = 1,
        Compiling = 2,
        Finished = 3,
    }

    public partial struct MTL4CompilerDescriptor
    {
        public IntPtr NativePtr;

        public MTL4CompilerDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4CompilerDescriptor New() => s_class.AllocInit<MTL4CompilerDescriptor>();

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTL4PipelineDataSetSerializer PipelineDataSetSerializer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_pipelineDataSetSerializer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPipelineDataSetSerializer, value);
        }

        public static implicit operator IntPtr(in MTL4CompilerDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4CompilerDescriptor));
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_pipelineDataSetSerializer = "pipelineDataSetSerializer";
        private static readonly Selector sel_setPipelineDataSetSerializer = "setPipelineDataSetSerializer:";
    }

    public partial struct MTL4CompilerTaskOptions
    {
        public IntPtr NativePtr;

        public MTL4CompilerTaskOptions(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4CompilerTaskOptions New() => s_class.AllocInit<MTL4CompilerTaskOptions>();

        public NSArray LookupArchives
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_lookupArchives));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLookupArchives, value);
        }

        public static implicit operator IntPtr(in MTL4CompilerTaskOptions obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4CompilerTaskOptions));
        private static readonly Selector sel_lookupArchives = "lookupArchives";
        private static readonly Selector sel_setLookupArchives = "setLookupArchives:";
    }

    public partial struct MTL4CompilerTask
    {
        public IntPtr NativePtr;

        public MTL4CompilerTask(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4CompilerTask obj) => obj.NativePtr;

        public MTL4Compiler Compiler => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_compiler));

        public MTL4CompilerTaskStatus Status => (MTL4CompilerTaskStatus)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_status);

        public void WaitUntilCompleted()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_waitUntilCompleted);
        }

        private static readonly Selector sel_compiler = "compiler";
        private static readonly Selector sel_status = "status";
        private static readonly Selector sel_waitUntilCompleted = "waitUntilCompleted";
    }

    public partial struct MTL4Compiler
    {
        public IntPtr NativePtr;

        public MTL4Compiler(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4Compiler obj) => obj.NativePtr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));

        public MTL4PipelineDataSetSerializer PipelineDataSetSerializer => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_pipelineDataSetSerializer));

        public MTLLibrary NewLibrary(in MTL4LibraryDescriptor descriptor, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newLibraryWithDescriptorerror, descriptor, ref error.NativePtr));
        }

        public MTLDynamicLibrary NewDynamicLibrary(in MTLLibrary library, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newDynamicLibraryerror, library, ref error.NativePtr));
        }

        public MTLDynamicLibrary NewDynamicLibrary(in NSURL url, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newDynamicLibraryWithURLerror, url, ref error.NativePtr));
        }

        public MTLComputePipelineState NewComputePipelineState(in MTL4ComputePipelineDescriptor descriptor, in MTL4CompilerTaskOptions compilerTaskOptions, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newComputePipelineStateWithDescriptorcompilerTaskOptionserror, descriptor, compilerTaskOptions, ref error.NativePtr));
        }

        public MTLComputePipelineState NewComputePipelineState(in MTL4ComputePipelineDescriptor descriptor, in MTL4PipelineStageDynamicLinkingDescriptor dynamicLinkingDescriptor, in MTL4CompilerTaskOptions compilerTaskOptions, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newComputePipelineStateWithDescriptordynamicLinkingDescriptorcompilerTaskOptionserror, descriptor, dynamicLinkingDescriptor, compilerTaskOptions, ref error.NativePtr));
        }

        public MTLRenderPipelineState NewRenderPipelineState(in MTL4PipelineDescriptor descriptor, in MTL4CompilerTaskOptions compilerTaskOptions, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newRenderPipelineStateWithDescriptorcompilerTaskOptionserror, descriptor, compilerTaskOptions, ref error.NativePtr));
        }

        public MTLRenderPipelineState NewRenderPipelineState(in MTL4PipelineDescriptor descriptor, in MTL4RenderPipelineDynamicLinkingDescriptor dynamicLinkingDescriptor, in MTL4CompilerTaskOptions compilerTaskOptions, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newRenderPipelineStateWithDescriptordynamicLinkingDescriptorcompilerTaskOptionserror, descriptor, dynamicLinkingDescriptor, compilerTaskOptions, ref error.NativePtr));
        }

        public MTLRenderPipelineState NewRenderPipelineStateBySpecialization(in MTL4PipelineDescriptor descriptor, in MTLRenderPipelineState pipeline, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newRenderPipelineStateBySpecializationWithDescriptorpipelineerror, descriptor, pipeline, ref error.NativePtr));
        }

        public MTL4BinaryFunction NewBinaryFunction(in MTL4BinaryFunctionDescriptor descriptor, in MTL4CompilerTaskOptions compilerTaskOptions, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newBinaryFunctionWithDescriptorcompilerTaskOptionserror, descriptor, compilerTaskOptions, ref error.NativePtr));
        }

        public MTL4MachineLearningPipelineState NewMachineLearningPipelineState(in MTL4MachineLearningPipelineDescriptor descriptor, ref NSError error)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newMachineLearningPipelineStateWithDescriptorerror, descriptor, ref error.NativePtr));
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_pipelineDataSetSerializer = "pipelineDataSetSerializer";
        private static readonly Selector sel_newLibraryWithDescriptorerror = "newLibraryWithDescriptor:error:";
        private static readonly Selector sel_newDynamicLibraryerror = "newDynamicLibrary:error:";
        private static readonly Selector sel_newDynamicLibraryWithURLerror = "newDynamicLibraryWithURL:error:";
        private static readonly Selector sel_newComputePipelineStateWithDescriptorcompilerTaskOptionserror = "newComputePipelineStateWithDescriptor:compilerTaskOptions:error:";
        private static readonly Selector sel_newComputePipelineStateWithDescriptordynamicLinkingDescriptorcompilerTaskOptionserror = "newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:";
        private static readonly Selector sel_newRenderPipelineStateWithDescriptorcompilerTaskOptionserror = "newRenderPipelineStateWithDescriptor:compilerTaskOptions:error:";
        private static readonly Selector sel_newRenderPipelineStateWithDescriptordynamicLinkingDescriptorcompilerTaskOptionserror = "newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:";
        private static readonly Selector sel_newRenderPipelineStateBySpecializationWithDescriptorpipelineerror = "newRenderPipelineStateBySpecializationWithDescriptor:pipeline:error:";
        private static readonly Selector sel_newBinaryFunctionWithDescriptorcompilerTaskOptionserror = "newBinaryFunctionWithDescriptor:compilerTaskOptions:error:";
        private static readonly Selector sel_newMachineLearningPipelineStateWithDescriptorerror = "newMachineLearningPipelineStateWithDescriptor:error:";
    }
}
