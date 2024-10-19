using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLBinaryArchiveError : ulong
    {
        None = 0,
        InvalidFile = 1,
        UnexpectedElement = 2,
        CompilationFailure = 3,
        InternalError = 4,
    }

    public partial struct MTLBinaryArchiveDescriptor
    {
        public IntPtr NativePtr;

        public MTLBinaryArchiveDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLBinaryArchiveDescriptor New() => s_class.AllocInit<MTLBinaryArchiveDescriptor>();

        public NSURL Url
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_url));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setUrl, value);
        }

        public static implicit operator IntPtr(in MTLBinaryArchiveDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLBinaryArchiveDescriptor));
        private static readonly Selector sel_url = "url";
        private static readonly Selector sel_setUrl = "setUrl:";
    }

    public partial struct MTLBinaryArchive
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLBinaryArchive obj) => obj.NativePtr;
        public MTLBinaryArchive(in IntPtr ptr) => NativePtr = ptr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public bool AddComputePipelineFunctions(in MTLComputePipelineDescriptor descriptor, ref NSError error)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_addComputePipelineFunctionsWithDescriptorerror, descriptor, ref error.NativePtr);
        }

        public bool AddRenderPipelineFunctions(in MTLRenderPipelineDescriptor descriptor, ref NSError error)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_addRenderPipelineFunctionsWithDescriptorerror, descriptor, ref error.NativePtr);
        }

        public bool AddTileRenderPipelineFunctions(in MTLTileRenderPipelineDescriptor descriptor, ref NSError error)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_addTileRenderPipelineFunctionsWithDescriptorerror, descriptor, ref error.NativePtr);
        }

        public bool AddMeshRenderPipelineFunctions(in MTLMeshRenderPipelineDescriptor descriptor, ref NSError error)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_addMeshRenderPipelineFunctionsWithDescriptorerror, descriptor, ref error.NativePtr);
        }

        public bool AddLibrary(in MTLStitchedLibraryDescriptor descriptor, ref NSError error)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_addLibraryWithDescriptor, descriptor, ref error.NativePtr);
        }

        public bool SerializeToURL(in NSURL url, ref NSError error)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_serializeToURLerror, url, ref error.NativePtr);
        }

        public bool AddFunction(in MTLFunctionDescriptor descriptor, in MTLLibrary library, ref NSError error)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_addFunctionWithDescriptorlibraryerror, descriptor, library, ref error.NativePtr);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_addComputePipelineFunctionsWithDescriptorerror = "addComputePipelineFunctionsWithDescriptor:error:";
        private static readonly Selector sel_addRenderPipelineFunctionsWithDescriptorerror = "addRenderPipelineFunctionsWithDescriptor:error:";
        private static readonly Selector sel_addTileRenderPipelineFunctionsWithDescriptorerror = "addTileRenderPipelineFunctionsWithDescriptor:error:";
        private static readonly Selector sel_addMeshRenderPipelineFunctionsWithDescriptorerror = "addMeshRenderPipelineFunctionsWithDescriptor:error:";
        private static readonly Selector sel_addLibraryWithDescriptor = "addLibraryWithDescriptor:error:";
        private static readonly Selector sel_serializeToURLerror = "serializeToURL:error:";
        private static readonly Selector sel_addFunctionWithDescriptorlibraryerror = "addFunctionWithDescriptor:library:error:";
    }
}
