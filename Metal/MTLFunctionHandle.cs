using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLFunctionHandle
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLFunctionHandle obj) => obj.NativePtr;
        public MTLFunctionHandle(in IntPtr ptr) => NativePtr = ptr;

        public MTLFunctionType FunctionType => (MTLFunctionType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_functionType);

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        private static readonly Selector sel_functionType = "functionType";
        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_device = "device";
    }
}
