using System;

namespace Apple.Metal
{
    public struct MTLComputePipelineState
    {
        public readonly IntPtr NativePtr;
        public MTLComputePipelineState(in IntPtr ptr) => NativePtr = ptr;
        public bool IsNull => NativePtr == IntPtr.Zero;
    }
}