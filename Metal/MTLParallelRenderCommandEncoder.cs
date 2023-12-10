using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    
    public partial struct MTLParallelRenderCommandEncoder
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLParallelRenderCommandEncoder obj) => obj.NativePtr;
        public static implicit operator MTLCommandEncoder(in MTLParallelRenderCommandEncoder obj) => new MTLCommandEncoder(obj.NativePtr);
        public static implicit operator MTLParallelRenderCommandEncoder(in MTLCommandEncoder obj) => new MTLParallelRenderCommandEncoder(obj.NativePtr);

        public MTLParallelRenderCommandEncoder(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public MTLRenderCommandEncoder RenderCommandEncoder => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_renderCommandEncoder));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public void EndEncoding()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_endEncoding);
        }

        public void InsertDebugSignpost(in NSString nsString)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_insertDebugSignpost, nsString);
        }

        public void PushDebugGroup(in NSString nsString)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_pushDebugGroup, nsString);
        }

        public void PopDebugGroup()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_popDebugGroup);
        }

        public void SetColorStoreAction(in MTLStoreAction storeAction, in ulong colorAttachmentIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setColorStoreActionatIndex, (ulong)storeAction, colorAttachmentIndex);
        }

        public void SetDepthStoreAction(in MTLStoreAction storeAction)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthStoreAction, (ulong)storeAction);
        }

        public void SetStencilStoreAction(in MTLStoreAction storeAction)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStencilStoreAction, (ulong)storeAction);
        }

        public void SetColorStoreActionOptions(in MTLStoreActionOptions storeActionOptions, in ulong colorAttachmentIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setColorStoreActionOptionsatIndex, (ulong)storeActionOptions, colorAttachmentIndex);
        }

        public void SetDepthStoreActionOptions(in MTLStoreActionOptions storeActionOptions)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthStoreActionOptions, (ulong)storeActionOptions);
        }

        public void SetStencilStoreActionOptions(in MTLStoreActionOptions storeActionOptions)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStencilStoreActionOptions, (ulong)storeActionOptions);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_endEncoding = "endEncoding";
        private static readonly Selector sel_insertDebugSignpost = "insertDebugSignpost:";
        private static readonly Selector sel_pushDebugGroup = "pushDebugGroup:";
        private static readonly Selector sel_popDebugGroup = "popDebugGroup";
        private static readonly Selector sel_renderCommandEncoder = "renderCommandEncoder";
        private static readonly Selector sel_setColorStoreActionatIndex = "setColorStoreAction:atIndex:";
        private static readonly Selector sel_setDepthStoreAction = "setDepthStoreAction:";
        private static readonly Selector sel_setStencilStoreAction = "setStencilStoreAction:";
        private static readonly Selector sel_setColorStoreActionOptionsatIndex = "setColorStoreActionOptions:atIndex:";
        private static readonly Selector sel_setDepthStoreActionOptions = "setDepthStoreActionOptions:";
        private static readonly Selector sel_setStencilStoreActionOptions = "setStencilStoreActionOptions:";
    }
}
