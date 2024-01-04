using SharpMetal.Metal;
using SharpMetal.QuartzCore;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public unsafe struct UIScreen
    {
        public readonly IntPtr NativePtr;

        public UIScreen(in IntPtr ptr) => NativePtr = ptr;

        public float NativeScale => ObjectiveCRuntime.float_objc_msgSend(NativePtr, sel_nativeScale);

        public static UIScreen MainScreen => ObjectiveCRuntime.objc_msgSend<UIScreen>(s_class, sel_mainScreen);

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(UIScreen));

        private static readonly Selector sel_mainScreen = "mainScreen";
        private static readonly Selector sel_nativeScale = "nativeScale";
    }

    public struct UIView
    {
        public readonly nint NativePtr;

        public UIView(in nint ptr) => NativePtr = ptr;

        public CGRect Frame => ObjectiveCRuntime.CGRect_objc_msgSend(NativePtr, sel_frame);

        public CALayer Layer => ObjectiveCRuntime.objc_msgSend<CALayer>(NativePtr, sel_layer);

        private static readonly Selector sel_layer = "layer";
        private static readonly Selector sel_frame = "frame";
    }

    public struct UIViewController
    {
        public readonly nint NativePtr;

        public UIViewController(in nint ptr) => NativePtr = ptr;

        public UIView View => ObjectiveCRuntime.objc_msgSend<UIView>(NativePtr, sel_view);

        private static readonly Selector sel_view = "view";
    }

    public struct UIWindow
    {
        public readonly nint NativePtr;

        public UIWindow(in nint ptr) => NativePtr = ptr;

        public UIViewController RootViewController => ObjectiveCRuntime.objc_msgSend<UIViewController>(NativePtr, sel_rootViewController);

        private static readonly Selector sel_rootViewController = "rootViewController";
    }
}