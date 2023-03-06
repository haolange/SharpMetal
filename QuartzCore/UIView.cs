using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public struct UIView
    {
        public readonly IntPtr NativePtr;
        public UIView(in IntPtr ptr) => NativePtr = ptr;

        public CALayer layer => objc_msgSend<CALayer>(NativePtr, "layer");

        public CGRect frame => CGRect_objc_msgSend(NativePtr, "frame");
    }

    public struct UIViewController
    {
        public readonly IntPtr NativePtr;
        public UIViewController(in IntPtr ptr) => NativePtr = ptr;

        public UIView view => objc_msgSend<UIView>(NativePtr, "view");
    }

    public struct UIWindow
    {
        public readonly IntPtr NativePtr;
        public UIWindow(in IntPtr ptr) => NativePtr = ptr;

        public UIViewController rootViewController => objc_msgSend<UIViewController>(NativePtr, "rootViewController");
    }
}