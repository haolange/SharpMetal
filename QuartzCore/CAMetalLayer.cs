using SharpMetal.Metal;
using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.QuartzCore
{
    public partial struct CAMetalLayer
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in CAMetalLayer obj) => obj.NativePtr;
        public CAMetalLayer(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDevice, value);
        }

        public MTLPixelFormat PixelFormat
        {
            get => (MTLPixelFormat) ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_setPixelFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPixelFormat, (uint)value);
        }

        public bool FramebufferOnly
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_framebufferOnly);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFramebufferOnly, value);
        }

        public IntPtr DrawableSize
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_drawableSize));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDrawableSize, value);
        }

        public MTLRegion frame
        {
            get => ObjectiveCRuntime.MTLRegion_objc_msgSend(NativePtr, sel_frame);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFrame, value);
        }

        public bool opaque
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isOpaque);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaque, value);
        }

        public bool displaySyncEnabled
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_displaySyncEnabled);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDisplaySyncEnabled, value);
        }


        private static readonly Selector sel_layer = "layer";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_setDevice = "setDevice:";
        private static readonly Selector sel_pixelFormat = "pixelFormat";
        private static readonly Selector sel_setPixelFormat = "setPixelFormat:";
        private static readonly Selector sel_framebufferOnly = "framebufferOnly";
        private static readonly Selector sel_setFramebufferOnly = "setFramebufferOnly:";
        private static readonly Selector sel_drawableSize = "drawableSize";
        private static readonly Selector sel_setDrawableSize = "setDrawableSize:";
        private static readonly Selector sel_frame = "frame";
        private static readonly Selector sel_setFrame = "setFrame:";
        private static readonly Selector sel_isOpaque = "isOpaque";
        private static readonly Selector sel_setOpaque = "setOpaque:";
        private static readonly Selector sel_nextDrawable = "nextDrawable";
        private static readonly Selector sel_displaySyncEnabled = "displaySyncEnabled";
        private static readonly Selector sel_setDisplaySyncEnabled = "setDisplaySyncEnabled:";
    }
}
