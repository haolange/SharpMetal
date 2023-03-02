using System;
using System.Runtime.InteropServices;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLCommandQueue
    {
        public readonly IntPtr NativePtr;

        public MTLCommandQueue(in IntPtr ptr) => NativePtr = ptr;

        public MTLCommandBuffer commandBuffer() => objc_msgSend<MTLCommandBuffer>(NativePtr, sel_commandBuffer);

        public void insertDebugCaptureBoundary() => objc_msgSend(NativePtr, sel_insertDebugCaptureBoundary);

        private static readonly Selector sel_commandBuffer = "commandBuffer";
        private static readonly Selector sel_insertDebugCaptureBoundary = "insertDebugCaptureBoundary";
    }
}