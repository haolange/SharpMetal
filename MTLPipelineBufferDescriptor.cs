using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public struct MTLPipelineBufferDescriptor
    {
        public readonly IntPtr NativePtr;

        public MTLPipelineBufferDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public MTLMutability mutability
        {
            get => (MTLMutability)uint_objc_msgSend(NativePtr, sel_mutability);
            set => objc_msgSend(NativePtr, sel_setMutability, (uint)value);
        }

        private static readonly Selector sel_mutability = "mutability";
        private static readonly Selector sel_setMutability = "setMutability:";
    }
}