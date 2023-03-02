using System;
using System.Runtime.InteropServices;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLRenderPipelineColorAttachmentDescriptorArray
    {
        public readonly IntPtr NativePtr;

        public MTLRenderPipelineColorAttachmentDescriptor this[uint index]
        {
            get
            {
                IntPtr ptr = IntPtr_objc_msgSend(NativePtr, Selectors.objectAtIndexedSubscript, index);
                return new MTLRenderPipelineColorAttachmentDescriptor(ptr);
            }
            set
            {
                objc_msgSend(NativePtr, Selectors.setObjectAtIndexedSubscript, value.NativePtr, index);
            }
        }
    }
}