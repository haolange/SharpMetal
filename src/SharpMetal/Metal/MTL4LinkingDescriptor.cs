using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTL4StaticLinkingDescriptor
    {
        public IntPtr NativePtr;

        public MTL4StaticLinkingDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4StaticLinkingDescriptor New() => s_class.AllocInit<MTL4StaticLinkingDescriptor>();

        public NSArray FunctionDescriptors
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_functionDescriptors));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctionDescriptors, value);
        }

        public NSArray PrivateFunctionDescriptors
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_privateFunctionDescriptors));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrivateFunctionDescriptors, value);
        }

        public IntPtr Groups
        {
            get => ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_groups);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setGroups, value);
        }

        public static implicit operator IntPtr(in MTL4StaticLinkingDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4StaticLinkingDescriptor));
        private static readonly Selector sel_functionDescriptors = "functionDescriptors";
        private static readonly Selector sel_setFunctionDescriptors = "setFunctionDescriptors:";
        private static readonly Selector sel_privateFunctionDescriptors = "privateFunctionDescriptors";
        private static readonly Selector sel_setPrivateFunctionDescriptors = "setPrivateFunctionDescriptors:";
        private static readonly Selector sel_groups = "groups";
        private static readonly Selector sel_setGroups = "setGroups:";
    }

    public partial struct MTL4PipelineStageDynamicLinkingDescriptor
    {
        public IntPtr NativePtr;

        public MTL4PipelineStageDynamicLinkingDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4PipelineStageDynamicLinkingDescriptor New() => s_class.AllocInit<MTL4PipelineStageDynamicLinkingDescriptor>();

        public ulong MaxCallStackDepth
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxCallStackDepth);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMaxCallStackDepth, value);
        }

        public NSArray BinaryLinkedFunctions
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_binaryLinkedFunctions));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBinaryLinkedFunctions, value);
        }

        public NSArray PreloadedLibraries
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_preloadedLibraries));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPreloadedLibraries, value);
        }

        public static implicit operator IntPtr(in MTL4PipelineStageDynamicLinkingDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4PipelineStageDynamicLinkingDescriptor));
        private static readonly Selector sel_maxCallStackDepth = "maxCallStackDepth";
        private static readonly Selector sel_setMaxCallStackDepth = "setMaxCallStackDepth:";
        private static readonly Selector sel_binaryLinkedFunctions = "binaryLinkedFunctions";
        private static readonly Selector sel_setBinaryLinkedFunctions = "setBinaryLinkedFunctions:";
        private static readonly Selector sel_preloadedLibraries = "preloadedLibraries";
        private static readonly Selector sel_setPreloadedLibraries = "setPreloadedLibraries:";
    }

    public partial struct MTL4RenderPipelineDynamicLinkingDescriptor
    {
        public IntPtr NativePtr;

        public MTL4RenderPipelineDynamicLinkingDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4RenderPipelineDynamicLinkingDescriptor New() => s_class.AllocInit<MTL4RenderPipelineDynamicLinkingDescriptor>();

        public MTL4PipelineStageDynamicLinkingDescriptor VertexLinkingDescriptor => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_vertexLinkingDescriptor));

        public MTL4PipelineStageDynamicLinkingDescriptor FragmentLinkingDescriptor => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_fragmentLinkingDescriptor));

        public MTL4PipelineStageDynamicLinkingDescriptor TileLinkingDescriptor => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_tileLinkingDescriptor));

        public MTL4PipelineStageDynamicLinkingDescriptor ObjectLinkingDescriptor => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectLinkingDescriptor));

        public MTL4PipelineStageDynamicLinkingDescriptor MeshLinkingDescriptor => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_meshLinkingDescriptor));

        public static implicit operator IntPtr(in MTL4RenderPipelineDynamicLinkingDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4RenderPipelineDynamicLinkingDescriptor));
        private static readonly Selector sel_vertexLinkingDescriptor = "vertexLinkingDescriptor";
        private static readonly Selector sel_fragmentLinkingDescriptor = "fragmentLinkingDescriptor";
        private static readonly Selector sel_tileLinkingDescriptor = "tileLinkingDescriptor";
        private static readonly Selector sel_objectLinkingDescriptor = "objectLinkingDescriptor";
        private static readonly Selector sel_meshLinkingDescriptor = "meshLinkingDescriptor";
    }
}
