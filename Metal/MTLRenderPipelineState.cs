using System;

namespace Apple.Metal
{
    public struct MTLRenderPipelineState
    {
        public readonly IntPtr NativePtr;
        public MTLRenderPipelineState(in IntPtr ptr) => NativePtr = ptr;
    }
}