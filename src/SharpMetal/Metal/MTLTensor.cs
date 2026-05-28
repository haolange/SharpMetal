using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLTensorDataType : long
    {
        None = (long)MTLDataType.None,
        Float32 = (long)MTLDataType.Float,
        Float16 = (long)MTLDataType.Half,
        BFloat16 = (long)MTLDataType.BFloat,
        Int8 = (long)MTLDataType.Char,
        UInt8 = (long)MTLDataType.UChar,
        Int16 = (long)MTLDataType.Short,
        UInt16 = (long)MTLDataType.UShort,
        Int32 = (long)MTLDataType.Int,
        UInt32 = (long)MTLDataType.UInt,
        Int4 = 143,
        UInt4 = 144,
    }

    public enum MTLTensorError : long
    {
        None = 0,
        InternalError = 1,
        InvalidDescriptor = 2,
    }

    public enum MTLTensorUsage : ulong
    {
        Compute = 1 << 0,
        Render = 1 << 1,
        MachineLearning = 1 << 2,
    }

    public partial struct MTLTensorExtents
    {
        public const ulong MaxRank = 16;

        public IntPtr NativePtr;

        public MTLTensorExtents(in IntPtr ptr) => NativePtr = ptr;

        public static MTLTensorExtents New() => s_class.AllocInit<MTLTensorExtents>();

        public static MTLTensorExtents New(in ulong rank, in IntPtr values)
        {
            IntPtr allocated = s_class.Alloc();
            return new MTLTensorExtents(ObjectiveCRuntime.IntPtr_objc_msgSend(allocated, sel_initWithRankvalues, rank, values));
        }

        public ulong Rank => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_rank);

        public long ExtentAtDimensionIndex(in ulong dimensionIndex)
        {
            return ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_extentAtDimensionIndex, dimensionIndex);
        }

        public static implicit operator IntPtr(in MTLTensorExtents obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLTensorExtents));
        private static readonly Selector sel_initWithRankvalues = "initWithRank:values:";
        private static readonly Selector sel_rank = "rank";
        private static readonly Selector sel_extentAtDimensionIndex = "extentAtDimensionIndex:";
    }

    public partial struct MTLTensorDescriptor
    {
        public IntPtr NativePtr;

        public MTLTensorDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLTensorDescriptor New() => s_class.AllocInit<MTLTensorDescriptor>();

        public MTLTensorExtents Dimensions
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_dimensions));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDimensions, value);
        }

        public MTLTensorExtents Strides
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_strides));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStrides, value);
        }

        public MTLTensorDataType DataType
        {
            get => (MTLTensorDataType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_dataType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDataType, (long)value);
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

        public MTLCPUCacheMode CpuCacheMode
        {
            get => (MTLCPUCacheMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_cpuCacheMode);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCpuCacheMode, (ulong)value);
        }

        public MTLStorageMode StorageMode
        {
            get => (MTLStorageMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storageMode);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStorageMode, (ulong)value);
        }

        public MTLHazardTrackingMode HazardTrackingMode
        {
            get => (MTLHazardTrackingMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_hazardTrackingMode);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setHazardTrackingMode, (ulong)value);
        }

        public static implicit operator IntPtr(in MTLTensorDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLTensorDescriptor));
        private static readonly Selector sel_dimensions = "dimensions";
        private static readonly Selector sel_setDimensions = "setDimensions:";
        private static readonly Selector sel_strides = "strides";
        private static readonly Selector sel_setStrides = "setStrides:";
        private static readonly Selector sel_dataType = "dataType";
        private static readonly Selector sel_setDataType = "setDataType:";
        private static readonly Selector sel_usage = "usage";
        private static readonly Selector sel_setUsage = "setUsage:";
        private static readonly Selector sel_resourceOptions = "resourceOptions";
        private static readonly Selector sel_setResourceOptions = "setResourceOptions:";
        private static readonly Selector sel_cpuCacheMode = "cpuCacheMode";
        private static readonly Selector sel_setCpuCacheMode = "setCpuCacheMode:";
        private static readonly Selector sel_storageMode = "storageMode";
        private static readonly Selector sel_setStorageMode = "setStorageMode:";
        private static readonly Selector sel_hazardTrackingMode = "hazardTrackingMode";
        private static readonly Selector sel_setHazardTrackingMode = "setHazardTrackingMode:";
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

        public MTLResourceID GpuResourceID => ObjectiveCRuntime.MTLResourceID_objc_msgSend(NativePtr, sel_gpuResourceID);

        public MTLBuffer Buffer => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_buffer));

        public ulong BufferOffset => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_bufferOffset);

        public MTLTensorExtents Strides => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_strides));

        public MTLTensorExtents Dimensions => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_dimensions));

        public MTLTensorDataType DataType => (MTLTensorDataType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_dataType);

        public MTLTensorUsage Usage => (MTLTensorUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_usage);

        public void ReplaceSlice(in MTLTensorExtents sliceOrigin, in MTLTensorExtents sliceDimensions, in IntPtr bytes, in MTLTensorExtents strides)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_replaceSliceOriginsliceDimensionswithBytesstrides, sliceOrigin, sliceDimensions, bytes, strides);
        }

        public void GetBytes(in IntPtr bytes, in MTLTensorExtents strides, in MTLTensorExtents sliceOrigin, in MTLTensorExtents sliceDimensions)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_getBytesstridesfromSliceOriginsliceDimensions, bytes, strides, sliceOrigin, sliceDimensions);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_gpuResourceID = "gpuResourceID";
        private static readonly Selector sel_buffer = "buffer";
        private static readonly Selector sel_bufferOffset = "bufferOffset";
        private static readonly Selector sel_strides = "strides";
        private static readonly Selector sel_dataType = "dataType";
        private static readonly Selector sel_dimensions = "dimensions";
        private static readonly Selector sel_usage = "usage";
        private static readonly Selector sel_replaceSliceOriginsliceDimensionswithBytesstrides = "replaceSliceOrigin:sliceDimensions:withBytes:strides:";
        private static readonly Selector sel_getBytesstridesfromSliceOriginsliceDimensions = "getBytes:strides:fromSliceOrigin:sliceDimensions:";
    }
}
