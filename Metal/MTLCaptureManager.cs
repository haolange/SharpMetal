using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLCaptureError : long
    {
        NotSupported = 1,
        AlreadyCapturing = 2,
        InvalidDescriptor = 3,
    }

    public enum MTLCaptureDestination : long
    {
        DeveloperTools = 1,
        GPUTraceDocument = 2,
    }

    
    public partial struct MTLCaptureDescriptor
    {
        public IntPtr NativePtr;

        public MTLCaptureDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLCaptureDescriptor New() => s_class.AllocInit<MTLCaptureDescriptor>();

        public IntPtr CaptureObject
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_captureObject));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCaptureObject, value);
        }

        public MTLCaptureDestination Destination
        {
            get => (MTLCaptureDestination)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_destination);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDestination, (long)value);
        }

        public NSURL OutputURL
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_outputURL));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOutputURL, value);
        }

        public static implicit operator IntPtr(in MTLCaptureDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLCaptureDescriptor));
        private static readonly Selector sel_captureObject = "captureObject";
        private static readonly Selector sel_setCaptureObject = "setCaptureObject:";
        private static readonly Selector sel_destination = "destination";
        private static readonly Selector sel_setDestination = "setDestination:";
        private static readonly Selector sel_outputURL = "outputURL";
        private static readonly Selector sel_setOutputURL = "setOutputURL:";
    }

    
    public partial struct MTLCaptureManager
    {
        public IntPtr NativePtr;

        public MTLCaptureManager(in IntPtr ptr) => NativePtr = ptr;

        public static MTLCaptureManager New() => s_class.AllocInit<MTLCaptureManager>();

        public MTLCaptureScope DefaultCaptureScope
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_defaultCaptureScope));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDefaultCaptureScope, value);
        }
        
        public bool IsCapturing => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isCapturing);

        public static MTLCaptureManager SharedCaptureManager()
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(s_class, sel_sharedCaptureManager));
        }

        public MTLCaptureScope NewCaptureScope(in MTLDevice device)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newCaptureScopeWithDevice, device));
        }

        public MTLCaptureScope NewCaptureScope(in MTLCommandQueue commandQueue)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newCaptureScopeWithCommandQueue, commandQueue));
        }

        public bool SupportsDestination(in MTLCaptureDestination destination)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_supportsDestination, (long)destination);
        }

        public bool StartCapture(in MTLCaptureDescriptor descriptor, ref NSError error)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_startCaptureWithDescriptorerror, descriptor, ref error.NativePtr);
        }

        public void StartCapture(in MTLDevice device)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_startCaptureWithDevice, device);
        }

        public void StartCapture(in MTLCommandQueue commandQueue)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_startCaptureWithCommandQueue, commandQueue);
        }

        public void StartCapture(in MTLCaptureScope captureScope)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_startCaptureWithScope, captureScope);
        }

        public void StopCapture()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_stopCapture);
        }

        public static implicit operator IntPtr(in MTLCaptureManager obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLCaptureManager));
        private static readonly Selector sel_sharedCaptureManager = "sharedCaptureManager";
        private static readonly Selector sel_newCaptureScopeWithDevice = "newCaptureScopeWithDevice:";
        private static readonly Selector sel_newCaptureScopeWithCommandQueue = "newCaptureScopeWithCommandQueue:";
        private static readonly Selector sel_supportsDestination = "supportsDestination:";
        private static readonly Selector sel_startCaptureWithDescriptorerror = "startCaptureWithDescriptor:error:";
        private static readonly Selector sel_startCaptureWithDevice = "startCaptureWithDevice:";
        private static readonly Selector sel_startCaptureWithCommandQueue = "startCaptureWithCommandQueue:";
        private static readonly Selector sel_startCaptureWithScope = "startCaptureWithScope:";
        private static readonly Selector sel_stopCapture = "stopCapture";
        private static readonly Selector sel_defaultCaptureScope = "defaultCaptureScope";
        private static readonly Selector sel_setDefaultCaptureScope = "setDefaultCaptureScope:";
        private static readonly Selector sel_isCapturing = "isCapturing";
    }
}
