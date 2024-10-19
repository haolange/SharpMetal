using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLHeapType : long
    {
        Automatic = 0,
        Placement = 1,
        Sparse = 2,
    }

    
    public partial struct MTLHeapDescriptor
    {
        public IntPtr NativePtr;

        public MTLHeapDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLHeapDescriptor New() => s_class.AllocInit<MTLHeapDescriptor>();

        public ulong Size
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_size);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSize, value);
        }

        public MTLStorageMode StorageMode
        {
            get => (MTLStorageMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storageMode);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStorageMode, (ulong)value);
        }

        public MTLCPUCacheMode CpuCacheMode
        {
            get => (MTLCPUCacheMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_cpuCacheMode);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCpuCacheMode, (ulong)value);
        }
        public MTLSparsePageSize SparsePageSize
        {
            get => (MTLSparsePageSize)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_sparsePageSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSparsePageSize, (long)value);
        }
        public MTLHazardTrackingMode HazardTrackingMode
        {
            get => (MTLHazardTrackingMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_hazardTrackingMode);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setHazardTrackingMode, (ulong)value);
        }
        public MTLResourceOptions ResourceOptions
        {
            get => (MTLResourceOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resourceOptions);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResourceOptions, (ulong)value);
        }
        public MTLHeapType Type
        {
            get => (MTLHeapType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_type);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setType, (long)value);
        }

        public static implicit operator IntPtr(in MTLHeapDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLHeapDescriptor));
        private static readonly Selector sel_size = "size";
        private static readonly Selector sel_setSize = "setSize:";
        private static readonly Selector sel_storageMode = "storageMode";
        private static readonly Selector sel_setStorageMode = "setStorageMode:";
        private static readonly Selector sel_cpuCacheMode = "cpuCacheMode";
        private static readonly Selector sel_setCpuCacheMode = "setCpuCacheMode:";
        private static readonly Selector sel_sparsePageSize = "sparsePageSize";
        private static readonly Selector sel_setSparsePageSize = "setSparsePageSize:";
        private static readonly Selector sel_hazardTrackingMode = "hazardTrackingMode";
        private static readonly Selector sel_setHazardTrackingMode = "setHazardTrackingMode:";
        private static readonly Selector sel_resourceOptions = "resourceOptions";
        private static readonly Selector sel_setResourceOptions = "setResourceOptions:";
        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_setType = "setType:";
    }

    public partial struct MTLHeap
    {
        public IntPtr NativePtr;

        public MTLHeap(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator MTLAllocation(in MTLHeap obj) => new MTLAllocation(obj.NativePtr);
        public static implicit operator MTLHeap(in MTLAllocation obj) => new MTLHeap(obj.NativePtr);

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public MTLStorageMode StorageMode => (MTLStorageMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storageMode);

        public MTLCPUCacheMode CpuCacheMode => (MTLCPUCacheMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_cpuCacheMode);

        public MTLHazardTrackingMode HazardTrackingMode => (MTLHazardTrackingMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_hazardTrackingMode);

        public MTLResourceOptions ResourceOptions => (MTLResourceOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resourceOptions);

        public ulong Size => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_size);

        public ulong UsedSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_usedSize);

        public ulong CurrentAllocatedSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_currentAllocatedSize);

        public MTLHeapType Type => (MTLHeapType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_type);

        public ulong MaxAvailableSize(in ulong alignment)
        {
            return ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxAvailableSizeWithAlignment, alignment);
        }

        public MTLBuffer NewBuffer(in ulong length, in MTLResourceOptions options)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newBufferWithLengthoptions, length, (ulong)options));
        }

        public MTLTexture NewTexture(in MTLTextureDescriptor descriptor)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newTextureWithDescriptor, descriptor));
        }

        public MTLPurgeableState SetPurgeableState(in MTLPurgeableState state)
        {
            return (MTLPurgeableState)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_setPurgeableState, (ulong)state);
        }

        public MTLBuffer NewBuffer(in ulong length, in MTLResourceOptions options, in ulong offset)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newBufferWithLengthoptionsoffset, length, (ulong)options, offset));
        }

        public MTLTexture NewTexture(in MTLTextureDescriptor descriptor, in ulong offset)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newTextureWithDescriptoroffset, descriptor, offset));
        }

        public MTLAccelerationStructure NewAccelerationStructure(in ulong size)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newAccelerationStructureWithSize, size));
        }

        public MTLAccelerationStructure NewAccelerationStructure(in MTLAccelerationStructureDescriptor descriptor)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newAccelerationStructureWithDescriptor, descriptor));
        }

        public MTLAccelerationStructure NewAccelerationStructure(in ulong size, in ulong offset)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newAccelerationStructureWithSizeoffset, size, offset));
        }

        public MTLAccelerationStructure NewAccelerationStructure(in MTLAccelerationStructureDescriptor descriptor, in ulong offset)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newAccelerationStructureWithDescriptoroffset, descriptor, offset));
        }

        public static implicit operator IntPtr(in MTLHeap obj) => obj.NativePtr;

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_storageMode = "storageMode";
        private static readonly Selector sel_cpuCacheMode = "cpuCacheMode";
        private static readonly Selector sel_hazardTrackingMode = "hazardTrackingMode";
        private static readonly Selector sel_resourceOptions = "resourceOptions";
        private static readonly Selector sel_size = "size";
        private static readonly Selector sel_usedSize = "usedSize";
        private static readonly Selector sel_currentAllocatedSize = "currentAllocatedSize";
        private static readonly Selector sel_maxAvailableSizeWithAlignment = "maxAvailableSizeWithAlignment:";
        private static readonly Selector sel_newBufferWithLengthoptions = "newBufferWithLength:options:";
        private static readonly Selector sel_newTextureWithDescriptor = "newTextureWithDescriptor:";
        private static readonly Selector sel_setPurgeableState = "setPurgeableState:";
        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_newBufferWithLengthoptionsoffset = "newBufferWithLength:options:offset:";
        private static readonly Selector sel_newTextureWithDescriptoroffset = "newTextureWithDescriptor:offset:";
        private static readonly Selector sel_newAccelerationStructureWithSize = "newAccelerationStructureWithSize:";
        private static readonly Selector sel_newAccelerationStructureWithDescriptor = "newAccelerationStructureWithDescriptor:";
        private static readonly Selector sel_newAccelerationStructureWithSizeoffset = "newAccelerationStructureWithSize:offset:";
        private static readonly Selector sel_newAccelerationStructureWithDescriptoroffset = "newAccelerationStructureWithDescriptor:offset:";
    }
}
