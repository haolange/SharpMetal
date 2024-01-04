using SharpMetal.QuartzCore;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;
using SharpMetal.Metal;

namespace SharpMetal.Foundation
{
    public unsafe struct NSView
    {
        public readonly IntPtr NativePtr;
        public static implicit operator IntPtr(in NSView nsView) => nsView.NativePtr;

        public NSView(in IntPtr ptr) => NativePtr = ptr;

        public bool WantsLayer
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_wantsLayer);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setWantsLayer, value);
        }

        public CALayer Layer
        {
            get => ObjectiveCRuntime.objc_msgSend<CALayer>(NativePtr, sel_layer);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLayer, value);
        }

        public CGRect Frame
        {
            get
            {
                return RuntimeInformation.ProcessArchitecture == Architecture.Arm64 ? ObjectiveCRuntime.CGRect_objc_msgSend(NativePtr, sel_frame) : ObjectiveCRuntime.objc_msgSend_stret<CGRect>(NativePtr, sel_setFrame);
            }
            set
            {
                ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFrame, value);
            }
        }

        private static readonly Selector sel_wantsLayer = "wantsLayer";
        private static readonly Selector sel_setWantsLayer = "setWantsLayer:";
        private static readonly Selector sel_layer = "layer";
        private static readonly Selector sel_setLayer = "setLayer:";
        private static readonly Selector sel_frame = "frame";
        private static readonly Selector sel_setFrame = "setFrame:";
    }

    public unsafe struct NSWindow
    {
        public readonly IntPtr NativePtr;

        public NSWindow(in IntPtr ptr) => NativePtr = ptr;

        public NSView ContentView => ObjectiveCRuntime.objc_msgSend<NSView>(NativePtr, "contentView");
    }
}