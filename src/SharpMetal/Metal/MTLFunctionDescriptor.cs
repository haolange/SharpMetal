using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLFunctionOptions : ulong
    {
        None = 0,
        CompileToBinary = 1,
        StoreFunctionInMetalScript = 2,
        FunctionOptionFailOnBinaryArchiveMiss = 4,
    }

    public partial struct MTLFunctionDescriptor
    {
        public IntPtr NativePtr;

        public MTLFunctionDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLFunctionDescriptor New() => s_class.AllocInit<MTLFunctionDescriptor>();

        public NSString Name
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setName, value);
        }

        public NSString SpecializedName
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_specializedName));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSpecializedName, value);
        }

        public MTLFunctionConstantValues ConstantValues
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_constantValues));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setConstantValues, value);
        }

        public MTLFunctionOptions Options
        {
            get => (MTLFunctionOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_options);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOptions, (ulong)value);
        }

        public NSArray BinaryArchives
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_binaryArchives));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBinaryArchives, value);
        }

        public static implicit operator IntPtr(in MTLFunctionDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLFunctionDescriptor));
        private static readonly Selector sel_functionDescriptor = "functionDescriptor";
        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_setName = "setName:";
        private static readonly Selector sel_specializedName = "specializedName";
        private static readonly Selector sel_setSpecializedName = "setSpecializedName:";
        private static readonly Selector sel_constantValues = "constantValues";
        private static readonly Selector sel_setConstantValues = "setConstantValues:";
        private static readonly Selector sel_options = "options";
        private static readonly Selector sel_setOptions = "setOptions:";
        private static readonly Selector sel_binaryArchives = "binaryArchives";
        private static readonly Selector sel_setBinaryArchives = "setBinaryArchives:";
    }

    
    public partial struct MTLIntersectionFunctionDescriptor
    {
        public IntPtr NativePtr;

        public MTLIntersectionFunctionDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLIntersectionFunctionDescriptor New() => s_class.AllocInit<MTLIntersectionFunctionDescriptor>();

        public NSString Name
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setName, value);
        }
        
        public NSString SpecializedName
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_specializedName));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSpecializedName, value);
        }
        
        public MTLFunctionConstantValues ConstantValues
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_constantValues));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setConstantValues, value);
        }
        
        public MTLFunctionOptions Options
        {
            get => (MTLFunctionOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_options);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOptions, (ulong)value);
        }
        
        public NSArray BinaryArchives
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_binaryArchives));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBinaryArchives, value);
        }

        public static implicit operator IntPtr(in MTLIntersectionFunctionDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLFunctionDescriptor(in MTLIntersectionFunctionDescriptor obj) => new MTLFunctionDescriptor(obj.NativePtr);
        public static implicit operator MTLIntersectionFunctionDescriptor(in MTLFunctionDescriptor obj) => new MTLIntersectionFunctionDescriptor(obj.NativePtr);

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLIntersectionFunctionDescriptor));
        private static readonly Selector sel_functionDescriptor = "functionDescriptor";
        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_setName = "setName:";
        private static readonly Selector sel_specializedName = "specializedName";
        private static readonly Selector sel_setSpecializedName = "setSpecializedName:";
        private static readonly Selector sel_constantValues = "constantValues";
        private static readonly Selector sel_setConstantValues = "setConstantValues:";
        private static readonly Selector sel_options = "options";
        private static readonly Selector sel_setOptions = "setOptions:";
        private static readonly Selector sel_binaryArchives = "binaryArchives";
        private static readonly Selector sel_setBinaryArchives = "setBinaryArchives:";
    }
}
