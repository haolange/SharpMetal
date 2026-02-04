using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    public enum MTLLogLevel : ulong
    {
        MTLLogLevelDebug = 0,
        MTLLogLevelInfo = 1,
        MTLLogLevelNotice = 2,
        MTLLogLevelError = 3,
        MTLLogLevelFault = 4,
        MTLLogLevelUndefined = 5,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MTLLogHandler(IntPtr block, NSString subSystem, NSString category, MTLLogLevel logLevel, NSString message);

    public partial struct MTLLogStateDescriptor
    {
        public IntPtr NativePtr;

        public MTLLogStateDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLLogStateDescriptor New() => s_class.AllocInit<MTLLogStateDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLLogStateDescriptor));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLLogLevel Level
        {
            get => (MTLLogLevel)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_level);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLevel, (ulong)value);
        }

        public ulong BufferSize
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_bufferSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBufferSize, value);
        }

        public static implicit operator IntPtr(in MTLLogStateDescriptor obj) => obj.NativePtr;

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_level = "level";
        private static readonly Selector sel_setLevel = "setLevel:";
        private static readonly Selector sel_bufferSize = "bufferSize";
        private static readonly Selector sel_setBufferSize = "setBufferSize:";
    }

    public partial struct MTLLogState
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLLogState obj) => obj.NativePtr;

        public MTLLogState(in IntPtr ptr) => NativePtr = ptr;

        public static MTLLogState New() => s_class.AllocInit<MTLLogState>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLLogState));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public void addLogHandler(MTLLogHandler block)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addLogHandler, block);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_addLogHandler = "addLogHandler:";
    }
}
