using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLFunctionLogType : ulong
    {
        Validation = 0,
    }

    public partial struct MTLLogContainer
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLLogContainer obj) => obj.NativePtr;
        public MTLLogContainer(in IntPtr ptr) => NativePtr = ptr;

        public ulong CountByEnumerating(in NSFastEnumerationState pState, in NSObject pBuffer, in ulong len)
        {
            return ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_countByEnumeratingWithStateobjectscount, pState, pBuffer, len);
        }

        private static readonly Selector sel_countByEnumeratingWithStateobjectscount = "countByEnumeratingWithState:objects:count:";
    }

    public partial struct MTLFunctionLogDebugLocation
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLFunctionLogDebugLocation obj) => obj.NativePtr;
        public MTLFunctionLogDebugLocation(in IntPtr ptr) => NativePtr = ptr;

        public NSString FunctionName => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_functionName));

        public NSURL URL => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_URL));

        public ulong Line => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_line);

        public ulong Column => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_column);

        private static readonly Selector sel_functionName = "functionName";
        private static readonly Selector sel_URL = "URL";
        private static readonly Selector sel_line = "line";
        private static readonly Selector sel_column = "column";
    }

    public partial struct MTLFunctionLog
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLFunctionLog obj) => obj.NativePtr;
        public MTLFunctionLog(in IntPtr ptr) => NativePtr = ptr;

        public MTLFunctionLogType Type => (MTLFunctionLogType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_type);

        public NSString EncoderLabel => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_encoderLabel));

        public MTLFunction Function => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_function));

        public MTLFunctionLogDebugLocation DebugLocation => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_debugLocation));

        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_encoderLabel = "encoderLabel";
        private static readonly Selector sel_function = "function";
        private static readonly Selector sel_debugLocation = "debugLocation";
    }
}
