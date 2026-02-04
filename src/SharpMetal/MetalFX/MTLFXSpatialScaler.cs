using SharpMetal.Metal;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.MetalFX
{
    public enum MTLFXSpatialScalerColorProcessingMode : long
    {
        SpatialScalerColorProcessingModePerceptual = 0,
        SpatialScalerColorProcessingModeLinear = 1,
        SpatialScalerColorProcessingModeHDR = 2
    }

    public partial struct MTLFXSpatialScalerDescriptor
    {
        public IntPtr NativePtr;

        public MTLFXSpatialScalerDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLFXSpatialScalerDescriptor New() => s_class.AllocInit<MTLFXSpatialScalerDescriptor>();

        public MTLPixelFormat ColorTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_colorTextureFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setColorTextureFormat, (ulong)value);
        }

        public MTLPixelFormat OutputTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_outputTextureFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setOutputTextureFormat, (ulong)value);
        }

        public ulong InputWidth
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_inputWidth);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setInputWidth, value);
        }

        public ulong InputHeight
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_inputWidth);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setInputWidth, value);
        }

        public ulong OutputWidth
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_outputWidth);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setOutputWidth, value);
        }

        public ulong OutputHeight
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_outputHeight);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setOutputHeight, value);
        }

        public MTLFXSpatialScalerColorProcessingMode ColorProcessingMode
        {
            get => (MTLFXSpatialScalerColorProcessingMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_colorProcessingMode);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setColorProcessingMode, (ulong)value);
        }

        public MTLFXSpatialScaler NewSpatialScaler(in MTLDevice device)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(device, MTLFXSelector.sel_newSpatialScalerWithDevice, NativePtr));
        }

        public static bool SupportsDevice(in MTLDevice device)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(s_class, MTLFXSelector.sel_supportsDevice, device);
        }

        public static implicit operator IntPtr(in MTLFXSpatialScalerDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLFXSpatialScalerDescriptor));
    }

    public partial struct MTLFXSpatialScaler
    {
        public IntPtr NativePtr;

        public MTLFXSpatialScaler(in IntPtr ptr) => NativePtr = ptr;

        public MTLTextureUsage ColorTextureUsage
        {
            get => (MTLTextureUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_colorTextureUsage);
        }

        public MTLTextureUsage OutputTextureUsage
        {
            get => (MTLTextureUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_outputTextureUsage);
        }

        public ulong InputContentWidth
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_inputContentWidth);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setInputContentWidth, value);
        }

        public ulong InputContentHeight
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_inputContentHeight);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setInputContentHeight, value);
        }

        public MTLTexture ColorTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, MTLFXSelector.sel_colorTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setColorTexture, value);
        }

        public MTLTexture OutputTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, MTLFXSelector.sel_outputTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setOutputTexture, value);
        }

        public MTLPixelFormat ColorTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_colorTextureFormat);
        }

        public MTLPixelFormat OutputTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_outputTextureFormat);
        }

        public ulong InputWidth
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_inputWidth);
        }

        public ulong InputHeight
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_inputWidth);
        }

        public ulong OutputWidth
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_outputWidth);
        }

        public ulong OutputHeight
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_outputHeight);
        }

        public MTLFXSpatialScalerColorProcessingMode ColorProcessingMode
        {
            get => (MTLFXSpatialScalerColorProcessingMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_colorProcessingMode);
        }

        public MTLFence Fence
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, MTLFXSelector.sel_fence));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setFence, value);
        }

        public void EncodeToCommandBuffer(in MTLCommandBuffer commandBuffer)
        {
            ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, MTLFXSelector.sel_encodeToCommandBuffer, commandBuffer);
        }

        public static implicit operator IntPtr(in MTLFXSpatialScaler obj) => obj.NativePtr;
    }
}
