using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public unsafe struct NSWindow
    {
        public readonly IntPtr NativePtr;
        public NSWindow(in IntPtr ptr)
        {
            NativePtr = ptr;
        }

        public NSView contentView => objc_msgSend<NSView>(NativePtr, "contentView");
    }
}