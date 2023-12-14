using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLEvent
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLEvent obj) => obj.NativePtr;
        public MTLEvent(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
    }

    public partial struct MTLSharedEventListener
    {
        public IntPtr NativePtr;

        public MTLSharedEventListener(in IntPtr ptr) => NativePtr = ptr;

        public static MTLSharedEventListener New() => s_class.AllocInit<MTLSharedEventListener>();

        public IntPtr DispatchQueue => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_dispatchQueue));

        public MTLSharedEventListener Init(in IntPtr dispatchQueue)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithDispatchQueue, dispatchQueue));
        }

        public static implicit operator IntPtr(in MTLSharedEventListener obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLSharedEventListener));
        private static readonly Selector sel_initWithDispatchQueue = "initWithDispatchQueue:";
        private static readonly Selector sel_dispatchQueue = "dispatchQueue";
    }

    public partial struct MTLSharedEvent
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLSharedEvent obj) => obj.NativePtr;
        public static implicit operator MTLEvent(in MTLSharedEvent obj) => new MTLEvent(obj.NativePtr);
        public static implicit operator MTLSharedEvent(in MTLEvent obj) => new MTLSharedEvent(obj.NativePtr);

        public MTLSharedEvent(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));
        public MTLSharedEventHandle NewSharedEventHandle => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newSharedEventHandle));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public ulong SignaledValue
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_signaledValue);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSignaledValue, value);
        }

        public void NotifyListener(MTLSharedEventListener listener, ulong value, IntPtr block)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_notifyListeneratValueblock, listener, value, block);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_notifyListeneratValueblock = "notifyListener:atValue:block:";
        private static readonly Selector sel_newSharedEventHandle = "newSharedEventHandle";
        private static readonly Selector sel_signaledValue = "signaledValue";
        private static readonly Selector sel_setSignaledValue = "setSignaledValue:";
    }

    public partial struct MTLSharedEventHandle
    {
        public IntPtr NativePtr;

        public MTLSharedEventHandle(in IntPtr ptr) => NativePtr = ptr;

        public static MTLSharedEventHandle New() => s_class.AllocInit<MTLSharedEventHandle>();

        public NSString Label => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));

        public static implicit operator IntPtr(in MTLSharedEventHandle obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLSharedEventHandle));
        private static readonly Selector sel_label = "label";
    }
}
