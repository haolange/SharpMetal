using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTL4FunctionDescriptor
    {
        public IntPtr NativePtr;

        public MTL4FunctionDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4FunctionDescriptor New() => s_class.AllocInit<MTL4FunctionDescriptor>();

        public static implicit operator IntPtr(in MTL4FunctionDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4FunctionDescriptor));
    }

    public partial struct MTL4LibraryDescriptor
    {
        public IntPtr NativePtr;

        public MTL4LibraryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4LibraryDescriptor New() => s_class.AllocInit<MTL4LibraryDescriptor>();

        public NSString Source
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_source));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSource, value);
        }

        public MTLCompileOptions Options
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_options));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOptions, value);
        }

        public NSString Name
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setName, value);
        }

        public static implicit operator IntPtr(in MTL4LibraryDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4LibraryDescriptor));
        private static readonly Selector sel_source = "source";
        private static readonly Selector sel_setSource = "setSource:";
        private static readonly Selector sel_options = "options";
        private static readonly Selector sel_setOptions = "setOptions:";
        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_setName = "setName:";
    }

    public partial struct MTL4LibraryFunctionDescriptor
    {
        public IntPtr NativePtr;

        public MTL4LibraryFunctionDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4LibraryFunctionDescriptor New() => s_class.AllocInit<MTL4LibraryFunctionDescriptor>();

        public static implicit operator MTL4FunctionDescriptor(in MTL4LibraryFunctionDescriptor obj) => new(obj.NativePtr);
        public static implicit operator MTL4LibraryFunctionDescriptor(in MTL4FunctionDescriptor obj) => new(obj.NativePtr);

        public NSString Name
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setName, value);
        }

        public MTLLibrary Library
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_library));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLibrary, value);
        }

        public static implicit operator IntPtr(in MTL4LibraryFunctionDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4LibraryFunctionDescriptor));
        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_setName = "setName:";
        private static readonly Selector sel_library = "library";
        private static readonly Selector sel_setLibrary = "setLibrary:";
    }

    public partial struct MTL4SpecializedFunctionDescriptor
    {
        public IntPtr NativePtr;

        public MTL4SpecializedFunctionDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4SpecializedFunctionDescriptor New() => s_class.AllocInit<MTL4SpecializedFunctionDescriptor>();

        public static implicit operator MTL4FunctionDescriptor(in MTL4SpecializedFunctionDescriptor obj) => new(obj.NativePtr);
        public static implicit operator MTL4SpecializedFunctionDescriptor(in MTL4FunctionDescriptor obj) => new(obj.NativePtr);

        public MTL4FunctionDescriptor FunctionDescriptor
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_functionDescriptor));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctionDescriptor, value);
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

        public static implicit operator IntPtr(in MTL4SpecializedFunctionDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4SpecializedFunctionDescriptor));
        private static readonly Selector sel_functionDescriptor = "functionDescriptor";
        private static readonly Selector sel_setFunctionDescriptor = "setFunctionDescriptor:";
        private static readonly Selector sel_specializedName = "specializedName";
        private static readonly Selector sel_setSpecializedName = "setSpecializedName:";
        private static readonly Selector sel_constantValues = "constantValues";
        private static readonly Selector sel_setConstantValues = "setConstantValues:";
    }

    public partial struct MTL4StitchedFunctionDescriptor
    {
        public IntPtr NativePtr;

        public MTL4StitchedFunctionDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4StitchedFunctionDescriptor New() => s_class.AllocInit<MTL4StitchedFunctionDescriptor>();

        public static implicit operator MTL4FunctionDescriptor(in MTL4StitchedFunctionDescriptor obj) => new(obj.NativePtr);
        public static implicit operator MTL4StitchedFunctionDescriptor(in MTL4FunctionDescriptor obj) => new(obj.NativePtr);

        public MTLFunctionStitchingGraph FunctionGraph
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_functionGraph));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctionGraph, value);
        }

        public NSArray FunctionDescriptors
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_functionDescriptors));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctionDescriptors, value);
        }

        public static implicit operator IntPtr(in MTL4StitchedFunctionDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4StitchedFunctionDescriptor));
        private static readonly Selector sel_functionGraph = "functionGraph";
        private static readonly Selector sel_setFunctionGraph = "setFunctionGraph:";
        private static readonly Selector sel_functionDescriptors = "functionDescriptors";
        private static readonly Selector sel_setFunctionDescriptors = "setFunctionDescriptors:";
    }
}
