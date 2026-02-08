using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTL4ArgumentTableDescriptor
    {
        public IntPtr NativePtr;

        public MTL4ArgumentTableDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4ArgumentTableDescriptor New() => s_class.AllocInit<MTL4ArgumentTableDescriptor>();

        public ulong MaxBufferBindCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxBufferBindCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMaxBufferBindCount, value);
        }

        public ulong MaxTextureBindCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxTextureBindCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMaxTextureBindCount, value);
        }

        public ulong MaxSamplerStateBindCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxSamplerStateBindCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMaxSamplerStateBindCount, value);
        }

        public bool InitializeBindings
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_initializeBindings);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInitializeBindings, value);
        }

        public bool SupportAttributeStrides
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_supportAttributeStrides);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSupportAttributeStrides, value);
        }

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public static implicit operator IntPtr(in MTL4ArgumentTableDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4ArgumentTableDescriptor));
        private static readonly Selector sel_maxBufferBindCount = "maxBufferBindCount";
        private static readonly Selector sel_setMaxBufferBindCount = "setMaxBufferBindCount:";
        private static readonly Selector sel_maxTextureBindCount = "maxTextureBindCount";
        private static readonly Selector sel_setMaxTextureBindCount = "setMaxTextureBindCount:";
        private static readonly Selector sel_maxSamplerStateBindCount = "maxSamplerStateBindCount";
        private static readonly Selector sel_setMaxSamplerStateBindCount = "setMaxSamplerStateBindCount:";
        private static readonly Selector sel_initializeBindings = "initializeBindings";
        private static readonly Selector sel_setInitializeBindings = "setInitializeBindings:";
        private static readonly Selector sel_supportAttributeStrides = "supportAttributeStrides";
        private static readonly Selector sel_setSupportAttributeStrides = "setSupportAttributeStrides:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
    }

    public partial struct MTL4ArgumentTable
    {
        public IntPtr NativePtr;

        public MTL4ArgumentTable(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4ArgumentTable obj) => obj.NativePtr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));

        public void SetAddress(in ulong gpuAddress, in ulong bindingIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAddressatIndex, gpuAddress, bindingIndex);
        }

        public void SetAddress(in ulong gpuAddress, in ulong stride, in ulong bindingIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAddressattributeStrideatIndex, gpuAddress, stride, bindingIndex);
        }

        public void SetResource(in MTLResourceID resourceID, in ulong bindingIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResourceatBufferIndex, resourceID, bindingIndex);
        }

        public void SetTexture(in MTLResourceID resourceID, in ulong bindingIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTextureatIndex, resourceID, bindingIndex);
        }

        public void SetSamplerState(in MTLResourceID resourceID, in ulong bindingIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSamplerStateatIndex, resourceID, bindingIndex);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setAddressatIndex = "setAddress:atIndex:";
        private static readonly Selector sel_setAddressattributeStrideatIndex = "setAddress:attributeStride:atIndex:";
        private static readonly Selector sel_setResourceatBufferIndex = "setResource:atBufferIndex:";
        private static readonly Selector sel_setTextureatIndex = "setTexture:atIndex:";
        private static readonly Selector sel_setSamplerStateatIndex = "setSamplerState:atIndex:";
    }
}
