using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTL4TileRenderPipelineDescriptor
    {
        public IntPtr NativePtr;

        public MTL4TileRenderPipelineDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4TileRenderPipelineDescriptor New() => s_class.AllocInit<MTL4TileRenderPipelineDescriptor>();

        public static implicit operator MTL4PipelineDescriptor(in MTL4TileRenderPipelineDescriptor obj) => new(obj.NativePtr);

        public MTL4FunctionDescriptor TileFunctionDescriptor
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_tileFunctionDescriptor));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTileFunctionDescriptor, value);
        }

        public ulong RasterSampleCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_rasterSampleCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRasterSampleCount, value);
        }

        public MTLTileRenderPipelineColorAttachmentDescriptorArray ColorAttachments => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_colorAttachments));

        public bool ThreadgroupSizeMatchesTileSize
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_threadgroupSizeMatchesTileSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setThreadgroupSizeMatchesTileSize, value);
        }

        public ulong MaxTotalThreadsPerThreadgroup
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxTotalThreadsPerThreadgroup);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMaxTotalThreadsPerThreadgroup, value);
        }

        public MTLSize RequiredThreadsPerThreadgroup
        {
            get => ObjectiveCRuntime.MTLSize_objc_msgSend(NativePtr, sel_requiredThreadsPerThreadgroup);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRequiredThreadsPerThreadgroup, value);
        }

        public MTL4StaticLinkingDescriptor StaticLinkingDescriptor
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_staticLinkingDescriptor));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStaticLinkingDescriptor, value);
        }

        public bool SupportBinaryLinking
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_supportBinaryLinking);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSupportBinaryLinking, value);
        }

        public void Reset()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_reset);
        }

        public static implicit operator IntPtr(in MTL4TileRenderPipelineDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4TileRenderPipelineDescriptor));
        private static readonly Selector sel_tileFunctionDescriptor = "tileFunctionDescriptor";
        private static readonly Selector sel_setTileFunctionDescriptor = "setTileFunctionDescriptor:";
        private static readonly Selector sel_rasterSampleCount = "rasterSampleCount";
        private static readonly Selector sel_setRasterSampleCount = "setRasterSampleCount:";
        private static readonly Selector sel_colorAttachments = "colorAttachments";
        private static readonly Selector sel_threadgroupSizeMatchesTileSize = "threadgroupSizeMatchesTileSize";
        private static readonly Selector sel_setThreadgroupSizeMatchesTileSize = "setThreadgroupSizeMatchesTileSize:";
        private static readonly Selector sel_maxTotalThreadsPerThreadgroup = "maxTotalThreadsPerThreadgroup";
        private static readonly Selector sel_setMaxTotalThreadsPerThreadgroup = "setMaxTotalThreadsPerThreadgroup:";
        private static readonly Selector sel_requiredThreadsPerThreadgroup = "requiredThreadsPerThreadgroup";
        private static readonly Selector sel_setRequiredThreadsPerThreadgroup = "setRequiredThreadsPerThreadgroup:";
        private static readonly Selector sel_staticLinkingDescriptor = "staticLinkingDescriptor";
        private static readonly Selector sel_setStaticLinkingDescriptor = "setStaticLinkingDescriptor:";
        private static readonly Selector sel_supportBinaryLinking = "supportBinaryLinking";
        private static readonly Selector sel_setSupportBinaryLinking = "setSupportBinaryLinking:";
        private static readonly Selector sel_reset = "reset";
    }
}
