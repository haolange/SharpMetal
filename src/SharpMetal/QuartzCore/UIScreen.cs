using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal.QuartzCore
{
    public unsafe struct UIScreen
    {
        public readonly IntPtr NativePtr;
        public UIScreen(in IntPtr ptr)
        {
            NativePtr = ptr;
        }

        public CGFloat nativeScale => CGFloat_objc_msgSend(NativePtr, "nativeScale");

        public static UIScreen mainScreen
            => objc_msgSend<UIScreen>(new ObjCClass(nameof(UIScreen)), "mainScreen");
    }
}