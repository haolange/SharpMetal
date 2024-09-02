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

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLLogLevel level => (MTLLogLevel)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_level);

        public ulong bufferSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_bufferSize);

        public static implicit operator IntPtr(in MTLLogStateDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLLogStateDescriptor));
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_level = "level";
        private static readonly Selector sel_bufferSize = "bufferSize";
    }

    public partial struct MTLLogState
    {
        public IntPtr NativePtr;

        public MTLLogState(in IntPtr ptr) => NativePtr = ptr;

        public static MTLLogState New() => s_class.AllocInit<MTLLogState>();

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public void addLogHandler(MTLLogHandler block)
        {
            
        }

        public static implicit operator IntPtr(in MTLLogState obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLLogState));
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_addLogHandler = "addLogHandler:";
    }
}
