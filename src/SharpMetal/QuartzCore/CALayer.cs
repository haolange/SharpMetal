using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public struct CALayer
    {
        public readonly IntPtr NativePtr;
        public static implicit operator IntPtr(in CALayer c) => c.NativePtr;

        public CALayer(in IntPtr ptr) => NativePtr = ptr;

        public void addSublayer(in IntPtr layer)
        {
            objc_msgSend(NativePtr, "addSublayer:", layer);
        }
    }
}