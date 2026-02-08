using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTL4BinaryFunctionOptions : ulong
    {
        None = 0,
        PipelineIndependent = 2,
    }

    public partial struct MTL4BinaryFunctionDescriptor
    {
        public IntPtr NativePtr;

        public MTL4BinaryFunctionDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4BinaryFunctionDescriptor New() => s_class.AllocInit<MTL4BinaryFunctionDescriptor>();

        public NSString Name
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setName, value);
        }

        public MTL4FunctionDescriptor FunctionDescriptor
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_functionDescriptor));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctionDescriptor, value);
        }

        public MTL4BinaryFunctionOptions Options
        {
            get => (MTL4BinaryFunctionOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_options);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOptions, (ulong)value);
        }

        public static implicit operator IntPtr(in MTL4BinaryFunctionDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4BinaryFunctionDescriptor));
        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_setName = "setName:";
        private static readonly Selector sel_functionDescriptor = "functionDescriptor";
        private static readonly Selector sel_setFunctionDescriptor = "setFunctionDescriptor:";
        private static readonly Selector sel_options = "options";
        private static readonly Selector sel_setOptions = "setOptions:";
    }

    public partial struct MTL4BinaryFunction
    {
        public IntPtr NativePtr;

        public MTL4BinaryFunction(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4BinaryFunction obj) => obj.NativePtr;

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public MTLFunctionType FunctionType => (MTLFunctionType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_functionType);

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_functionType = "functionType";
    }
}
