using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLCompareFunction : ulong
    {
        Never = 0,
        Less = 1,
        Equal = 2,
        LessEqual = 3,
        Greater = 4,
        NotEqual = 5,
        GreaterEqual = 6,
        Always = 7,
    }

    public enum MTLStencilOperation : ulong
    {
        Keep = 0,
        Zero = 1,
        Replace = 2,
        IncrementClamp = 3,
        DecrementClamp = 4,
        Invert = 5,
        IncrementWrap = 6,
        DecrementWrap = 7,
    }

    public partial struct MTLStencilDescriptor
    {
        public IntPtr NativePtr;

        public MTLStencilDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLStencilDescriptor New() => s_class.AllocInit<MTLStencilDescriptor>();

        public MTLCompareFunction StencilCompareFunction
        {
            get => (MTLCompareFunction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_stencilCompareFunction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStencilCompareFunction, (ulong)value);
        }
        
        public MTLStencilOperation StencilFailureOperation
        {
            get => (MTLStencilOperation)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_stencilFailureOperation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStencilFailureOperation, (ulong)value);
        }
        
        public MTLStencilOperation DepthFailureOperation
        {
            get => (MTLStencilOperation)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_depthFailureOperation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthFailureOperation, (ulong)value);
        }
        
        public MTLStencilOperation DepthStencilPassOperation
        {
            get => (MTLStencilOperation)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_depthStencilPassOperation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthStencilPassOperation, (ulong)value);
        }
        
        public uint ReadMask
        {
            get => ObjectiveCRuntime.uint_objc_msgSend(NativePtr, sel_readMask);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setReadMask, value);
        }
        
        public uint WriteMask
        {
            get => ObjectiveCRuntime.uint_objc_msgSend(NativePtr, sel_writeMask);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setWriteMask, value);
        }

        public static implicit operator IntPtr(in MTLStencilDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLStencilDescriptor));
        private static readonly Selector sel_stencilCompareFunction = "stencilCompareFunction";
        private static readonly Selector sel_setStencilCompareFunction = "setStencilCompareFunction:";
        private static readonly Selector sel_stencilFailureOperation = "stencilFailureOperation";
        private static readonly Selector sel_setStencilFailureOperation = "setStencilFailureOperation:";
        private static readonly Selector sel_depthFailureOperation = "depthFailureOperation";
        private static readonly Selector sel_setDepthFailureOperation = "setDepthFailureOperation:";
        private static readonly Selector sel_depthStencilPassOperation = "depthStencilPassOperation";
        private static readonly Selector sel_setDepthStencilPassOperation = "setDepthStencilPassOperation:";
        private static readonly Selector sel_readMask = "readMask";
        private static readonly Selector sel_setReadMask = "setReadMask:";
        private static readonly Selector sel_writeMask = "writeMask";
        private static readonly Selector sel_setWriteMask = "setWriteMask:";
    }

    public partial struct MTLDepthStencilDescriptor
    {
        public IntPtr NativePtr;

        public MTLDepthStencilDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLDepthStencilDescriptor New() => s_class.AllocInit<MTLDepthStencilDescriptor>();

        public MTLCompareFunction DepthCompareFunction
        {
            get => (MTLCompareFunction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_depthCompareFunction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthCompareFunction, (ulong)value);
        }
        
        public bool DepthWriteEnabled
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isDepthWriteEnabled);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthWriteEnabled, value);
        }
        
        public MTLStencilDescriptor FrontFaceStencil
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_frontFaceStencil));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFrontFaceStencil, value);
        }
        
        public MTLStencilDescriptor BackFaceStencil
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_backFaceStencil));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBackFaceStencil, value);
        }
        
        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public void SetDepthWriteEnabled(in bool depthWriteEnabled)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthWriteEnabled, depthWriteEnabled);
        }

        public static implicit operator IntPtr(in MTLDepthStencilDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLDepthStencilDescriptor));
        private static readonly Selector sel_depthCompareFunction = "depthCompareFunction";
        private static readonly Selector sel_setDepthCompareFunction = "setDepthCompareFunction:";
        private static readonly Selector sel_isDepthWriteEnabled = "isDepthWriteEnabled";
        private static readonly Selector sel_setDepthWriteEnabled = "setDepthWriteEnabled:";
        private static readonly Selector sel_frontFaceStencil = "frontFaceStencil";
        private static readonly Selector sel_setFrontFaceStencil = "setFrontFaceStencil:";
        private static readonly Selector sel_backFaceStencil = "backFaceStencil";
        private static readonly Selector sel_setBackFaceStencil = "setBackFaceStencil:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
    }

    public partial struct MTLDepthStencilState
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLDepthStencilState obj) => obj.NativePtr;

        public MTLDepthStencilState(in IntPtr ptr) => NativePtr = ptr;

        public NSString Label => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_device = "device";
    }
}
