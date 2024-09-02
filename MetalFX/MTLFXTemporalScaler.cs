using SharpMetal.Metal;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.MetalFX
{
    public partial struct MTLFXTemporalScalerDescriptor
    {
        public IntPtr NativePtr;

        public MTLFXTemporalScalerDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLFXTemporalScalerDescriptor New() => s_class.AllocInit<MTLFXTemporalScalerDescriptor>();

        public MTLPixelFormat ColorTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_colorTextureFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setColorTextureFormat, (ulong)value);
        }

        public MTLPixelFormat DepthTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_depthTextureFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setDepthTextureFormat, (ulong)value);
        }

        public MTLPixelFormat MotionTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_motionTextureFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setMotionTextureFormat, (ulong)value);
        }

        public MTLPixelFormat OutputTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_outputTextureFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setOutputTextureFormat, (ulong)value);
        }

        public MTLPixelFormat reactiveMaskTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_reactiveMaskTextureFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setReactiveMaskTextureFormat, (ulong)value);
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

        public bool AutoExposureEnabled
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, MTLFXSelector.sel_isAutoExposureEnabled);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setAutoExposureEnabled, value);
        }

        public bool InputContentPropertiesEnabled
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, MTLFXSelector.sel_isInputContentPropertiesEnabled);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setInputContentPropertiesEnabled, value);
        }

        public bool requiresSynchronousInitialization
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, MTLFXSelector.sel_requiresSynchronousInitialization);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setRequiresSynchronousInitialization, value);
        }

        public bool reactiveMaskTextureEnabled
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, MTLFXSelector.sel_isReactiveMaskTextureEnabled);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setReactiveMaskTextureEnabled, value);
        }

        public float InputContentMinScale
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, MTLFXSelector.sel_inputContentMinScale);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setInputContentMinScale, value);
        }

        public float InputContentMaxScale
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, MTLFXSelector.sel_inputContentMaxScale);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setInputContentMaxScale, value);
        }

        public MTLFXTemporalScaler NewTemporalScaler(in MTLDevice device)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, MTLFXSelector.sel_newTemporalScalerWithDevice, device));
        }

        public static bool SupportsDevice(in MTLDevice device)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(s_class, MTLFXSelector.sel_supportsDevice, device);
        }

        public static float SupportedInputContentMinScaleForDevice(in MTLDevice device)
        {
            return ObjectiveCRuntime.float_objc_msgSend(s_class, MTLFXSelector.sel_supportedInputContentMinScaleForDevice, device);
        }

        public static float SupportedInputContentMaxScaleForDevice(in MTLDevice device)
        {
            return ObjectiveCRuntime.float_objc_msgSend(s_class, MTLFXSelector.sel_supportedInputContentMaxScaleForDevice, device);
        }

        public static implicit operator IntPtr(in MTLFXTemporalScalerDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLFXTemporalScalerDescriptor));
    }

    public partial struct MTLFXTemporalScaler
    {
        public IntPtr NativePtr;

        public MTLFXTemporalScaler(in IntPtr ptr) => NativePtr = ptr;

        public MTLTextureUsage ColorTextureUsage
        {
            get => (MTLTextureUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_colorTextureUsage);
        }

        public MTLTextureUsage DepthTextureUsage
        {
            get => (MTLTextureUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_depthTextureUsage);
        }

        public MTLTextureUsage MotionTextureUsage
        {
            get => (MTLTextureUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_motionTextureUsage);
        }

        public MTLTextureUsage reactiveTextureUsage
        {
            get => (MTLTextureUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_reactiveTextureUsage);
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

        public MTLTexture DepthTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, MTLFXSelector.sel_depthTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setDepthTexture, value);
        }

        public MTLTexture MotionTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, MTLFXSelector.sel_motionTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setMotionTexture, value);
        }

        public MTLTexture reactiveMaskTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, MTLFXSelector.sel_reactiveMaskTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setReactiveMaskTexture, value);
        }

        public MTLTexture OutputTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, MTLFXSelector.sel_outputTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setOutputTexture, value);
        }

        public MTLTexture ExposureTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, MTLFXSelector.sel_exposureTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setExposureTexture, value);
        }

        public float PreExposure
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, MTLFXSelector.sel_preExposure);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setPreExposure, value);
        }

        public float JitterOffsetX
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, MTLFXSelector.sel_jitterOffsetX);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setJitterOffsetX, value);
        }

        public float JitterOffsetY
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, MTLFXSelector.sel_jitterOffsetY);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setJitterOffsetY, value);
        }

        public float MotionVectorScaleX
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, MTLFXSelector.sel_motionVectorScaleX);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setMotionVectorScaleX, value);
        }

        public float MotionVectorScaleY
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, MTLFXSelector.sel_motionVectorScaleY);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setMotionVectorScaleY, value);
        }

        public bool Reset
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, MTLFXSelector.sel_isAutoExposureEnabled);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setAutoExposureEnabled, value);
        }

        public bool DepthReversed
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, MTLFXSelector.sel_isDepthReversed);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, MTLFXSelector.sel_setDepthReversed, value);
        }

        public MTLPixelFormat ColorTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_colorTextureFormat);
        }

        public MTLPixelFormat DepthTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_depthTextureFormat);
        }

        public MTLPixelFormat MotionTextureFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, MTLFXSelector.sel_motionTextureFormat);
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
        
        public float InputContentMinScale
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, MTLFXSelector.sel_inputContentMinScale);
        }

        public float InputContentMaxScale
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, MTLFXSelector.sel_inputContentMaxScale);
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

        public static implicit operator IntPtr(in MTLFXTemporalScaler obj) => obj.NativePtr;
    }
}
