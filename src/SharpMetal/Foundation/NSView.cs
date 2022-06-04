using System;
using System.Runtime.InteropServices;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public unsafe struct NSView
    {
        public readonly IntPtr NativePtr;
        public static implicit operator IntPtr(in NSView nsView) => nsView.NativePtr;

        public NSView(in IntPtr ptr) => NativePtr = ptr;

        public Bool8 wantsLayer
        {
            get => bool8_objc_msgSend(NativePtr, "wantsLayer");
            set => objc_msgSend(NativePtr, "setWantsLayer:", value);
        }

        public IntPtr layer
        {
            get => IntPtr_objc_msgSend(NativePtr, "layer");
            set => objc_msgSend(NativePtr, "setLayer:", value);
        }

        public CGRect frame
        {
            get
            {
                return RuntimeInformation.ProcessArchitecture == Architecture.Arm64 ? CGRect_objc_msgSend(NativePtr, "frame") : objc_msgSend_stret<CGRect>(NativePtr, "frame");
            }
            set
            {
                objc_msgSend(NativePtr, "setFrame:", value);
            }
        }
    }
}