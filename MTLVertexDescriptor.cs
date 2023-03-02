using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public unsafe struct MTLVertexDescriptor
    {
        public readonly IntPtr NativePtr;

        public MTLVertexBufferLayoutDescriptorArray layouts
            => objc_msgSend<MTLVertexBufferLayoutDescriptorArray>(NativePtr, sel_layouts);

        public MTLVertexAttributeDescriptorArray attributes
            => objc_msgSend<MTLVertexAttributeDescriptorArray>(NativePtr, sel_attributes);

        private static readonly Selector sel_layouts = "layouts";
        private static readonly Selector sel_attributes = "attributes";
    }
}