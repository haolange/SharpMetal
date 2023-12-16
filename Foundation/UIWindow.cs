using SharpMetal.Metal;
using SharpMetal.QuartzCore;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public unsafe struct UIScreen
    {
        public readonly IntPtr NativePtr;

        public UIScreen(in IntPtr ptr) => NativePtr = ptr;

        public float nativeScale => ObjectiveCRuntime.float_objc_msgSend(NativePtr, sel_nativeScale);

        public static UIScreen mainScreen => ObjectiveCRuntime.objc_msgSend<UIScreen>(new ObjectiveCClass("UIScreen"), sel_mainScreen);

        private static readonly Selector sel_nativeScale = "nativeScale";
        private static readonly Selector sel_mainScreen = "mainScreen";
    }

    public struct UIView
    {
        public readonly nint NativePtr;

        public UIView(in nint ptr) => NativePtr = ptr;

        public CALayer layer => ObjectiveCRuntime.objc_msgSend<CALayer>(NativePtr, sel_layer);

        public CGRect frame => ObjectiveCRuntime.CGRect_objc_msgSend(NativePtr, sel_frame);

        private static readonly Selector sel_layer = "layer";
        private static readonly Selector sel_frame = "frame";
    }

    public struct UIViewController
    {
        public readonly nint NativePtr;

        public UIViewController(in nint ptr) => NativePtr = ptr;

        public UIView view => ObjectiveCRuntime.objc_msgSend<UIView>(NativePtr, "view");
    }

    public struct UIWindow
    {
        public readonly nint NativePtr;

        public UIWindow(in nint ptr) => NativePtr = ptr;

        public UIViewController rootViewController => ObjectiveCRuntime.objc_msgSend<UIViewController>(NativePtr, "rootViewController");
    }
}