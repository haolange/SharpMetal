using System;
using System.Runtime.InteropServices;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CAMetalDrawable
    {
        public readonly IntPtr NativePtr;
        public CAMetalDrawable(in IntPtr ptr) => NativePtr = ptr;
        public bool IsNull => NativePtr == IntPtr.Zero;
        public MTLTexture texture => objc_msgSend<MTLTexture>(NativePtr, Selectors.texture);
    }
}