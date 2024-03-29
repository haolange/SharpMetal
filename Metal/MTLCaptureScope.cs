using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    
    public partial struct MTLCaptureScope
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLCaptureScope obj) => obj.NativePtr;
        public MTLCaptureScope(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLCommandQueue CommandQueue => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_commandQueue));

        public void BeginScope()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_beginScope);
        }

        public void EndScope()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_endScope);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_commandQueue = "commandQueue";
        private static readonly Selector sel_beginScope = "beginScope";
        private static readonly Selector sel_endScope = "endScope";
    }
}
