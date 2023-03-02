using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal.QuartzCore
{
    public struct UIView
    {
        public readonly IntPtr NativePtr;
        public UIView(in IntPtr ptr) => NativePtr = ptr;

        public CALayer layer => objc_msgSend<CALayer>(NativePtr, "layer");

        public CGRect frame => CGRect_objc_msgSend(NativePtr, "frame");
    }
}