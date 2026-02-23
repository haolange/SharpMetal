using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLTensorUsage : ulong
    {
        MachineLearning = 0x01,
        Compute = 0x02,
        Render = 0x04,
        Read = 0x08,
        Write = 0x10,
    }

    public partial struct MTLTensorDescriptor
    {
        public IntPtr NativePtr;

        public MTLTensorDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLTensorDescriptor New() => s_class.AllocInit<MTLTensorDescriptor>();

        public MTLDataType DataType
        {
            get => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_dataType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDataType, (ulong)value);
        }

        public NSArray Dimensions
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_dimensions));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDimensions, value);
        }

        public MTLTensorUsage Usage
        {
            get => (MTLTensorUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_usage);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setUsage, (ulong)value);
        }

        public MTLResourceOptions ResourceOptions
        {
            get => (MTLResourceOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resourceOptions);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResourceOptions, (ulong)value);
        }

        public static implicit operator IntPtr(in MTLTensorDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLTensorDescriptor));
        private static readonly Selector sel_dataType = "dataType";
        private static readonly Selector sel_setDataType = "setDataType:";
        private static readonly Selector sel_dimensions = "dimensions";
        private static readonly Selector sel_setDimensions = "setDimensions:";
        private static readonly Selector sel_usage = "usage";
        private static readonly Selector sel_setUsage = "setUsage:";
        private static readonly Selector sel_resourceOptions = "resourceOptions";
        private static readonly Selector sel_setResourceOptions = "setResourceOptions:";
    }

    public partial struct MTLTensor
    {
        public IntPtr NativePtr;

        public MTLTensor(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTLTensor obj) => obj.NativePtr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLDataType DataType => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_dataType);

        public NSArray Dimensions => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_dimensions));

        public MTLTensorUsage Usage => (MTLTensorUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_usage);

        public ulong Length => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_length);

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_dataType = "dataType";
        private static readonly Selector sel_dimensions = "dimensions";
        private static readonly Selector sel_usage = "usage";
        private static readonly Selector sel_length = "length";
    }
}
