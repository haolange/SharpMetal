using SharpMetal.Metal;
using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.QuartzCore
{
    public partial struct CAMetalLayer
    {
        public IntPtr NativePtr;

        public static implicit operator CALayer(in CAMetalLayer obj) => new CALayer(obj.NativePtr);

        public CAMetalLayer(in IntPtr ptr) => NativePtr = ptr;

        public static CAMetalLayer New() => s_class.AllocInit<CAMetalLayer>();

        public MTLDevice Device
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDevice, value);
        }

        public MTLPixelFormat PixelFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_pixelFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPixelFormat, (uint)value);
        }

        public bool FramebufferOnly
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_framebufferOnly);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFramebufferOnly, value);
        }

        public CGSize DrawableSize
        {
            get => ObjectiveCRuntime.CGSize_objc_msgSend(NativePtr, sel_drawableSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDrawableSize, value);
        }

        public CGRect Frame
        {
            get => ObjectiveCRuntime.CGRect_objc_msgSend(NativePtr, sel_frame);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFrame, value);
        }

        public bool Opaque
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isOpaque);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaque, value);
        }

        public bool DisplaySyncEnabled
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_displaySyncEnabled);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDisplaySyncEnabled, value);
        }

        public void AddSublayer(in IntPtr layer)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addSublayer, layer);
        }

        public CAMetalDrawable NextDrawable()
        {
            return ObjectiveCRuntime.objc_msgSend<CAMetalDrawable>(NativePtr, sel_nextDrawable);
        }

        public static bool TryCast(in IntPtr layerPointer, out CAMetalLayer metalLayer)
        {
            var layerObject = new NSObject(layerPointer);

            if (layerObject.IsKindOfClass(s_class))
            {
                metalLayer = new CAMetalLayer(layerPointer);
                return true;
            }

            metalLayer = default;
            return false;
        }

        public static implicit operator IntPtr(in CAMetalLayer obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass("CAMetalLayer");

        private static readonly Selector sel_addSublayer = "addSublayer:";
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
