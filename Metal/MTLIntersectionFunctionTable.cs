using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLIntersectionFunctionSignature : ulong
    {
        None = 0,
        Instancing = 1,
        TriangleData = 2,
        WorldSpaceData = 4,
        InstanceMotion = 8,
        PrimitiveMotion = 16,
        ExtendedLimits = 32,
        MaxLevels = 64,
        CurveData = 128,
    }

    public partial struct MTLIntersectionFunctionTableDescriptor
    {
        public IntPtr NativePtr;

        public MTLIntersectionFunctionTableDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLIntersectionFunctionTableDescriptor New() => s_class.AllocInit<MTLIntersectionFunctionTableDescriptor>();

        public ulong FunctionCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_functionCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctionCount, value);
        }

        public static implicit operator IntPtr(in MTLIntersectionFunctionTableDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLIntersectionFunctionTableDescriptor));
        private static readonly Selector sel_intersectionFunctionTableDescriptor = "intersectionFunctionTableDescriptor";
        private static readonly Selector sel_functionCount = "functionCount";
        private static readonly Selector sel_setFunctionCount = "setFunctionCount:";
    }

    public partial struct MTLIntersectionFunctionTable
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLIntersectionFunctionTable obj) => obj.NativePtr;
        public static implicit operator MTLResource(in MTLIntersectionFunctionTable obj) => new MTLResource(obj.NativePtr);
        public static implicit operator MTLIntersectionFunctionTable(in MTLResource obj) => new MTLIntersectionFunctionTable(obj.NativePtr);
        public static implicit operator MTLAllocation(in MTLIntersectionFunctionTable obj) => new MTLAllocation(obj.NativePtr);
        public static implicit operator MTLIntersectionFunctionTable(in MTLAllocation obj) => new MTLIntersectionFunctionTable(obj.NativePtr);

        public MTLIntersectionFunctionTable(in IntPtr ptr) => NativePtr = ptr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public MTLCPUCacheMode CpuCacheMode => (MTLCPUCacheMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_cpuCacheMode);

        public MTLStorageMode StorageMode => (MTLStorageMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storageMode);

        public MTLHazardTrackingMode HazardTrackingMode => (MTLHazardTrackingMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_hazardTrackingMode);

        public MTLResourceOptions ResourceOptions => (MTLResourceOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resourceOptions);

        public MTLHeap Heap => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_heap));

        public ulong HeapOffset => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_heapOffset);

        public ulong AllocatedSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_allocatedSize);

        public bool IsAliasable => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isAliasable);

        public MTLResourceID GpuResourceID => ObjectiveCRuntime.MTLResourceID_objc_msgSend(NativePtr, sel_gpuResourceID);

        public MTLPurgeableState SetPurgeableState(in MTLPurgeableState state)
        {
            return (MTLPurgeableState)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_setPurgeableState, (ulong)state);
        }

        public void MakeAliasable()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_makeAliasable);
        }

        public void SetBuffer(in MTLBuffer buffer, in ulong offset, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBufferoffsetatIndex, buffer, offset, index);
        }

        public void SetBuffers(in IntPtr buffers, in IntPtr offsets, in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBuffersoffsetswithRange, buffers, offsets, range);
        }

        public void SetFunction(in MTLFunctionHandle function, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctionatIndex, function, index);
        }

        public void SetFunctions(in IntPtr functions, in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctionswithRange, functions, range);
        }

        public void SetOpaqueTriangleIntersectionFunction(in MTLIntersectionFunctionSignature signature, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaqueTriangleIntersectionFunctionWithSignatureatIndex, (ulong)signature, index);
        }

        public void SetOpaqueTriangleIntersectionFunction(in MTLIntersectionFunctionSignature signature, in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaqueTriangleIntersectionFunctionWithSignaturewithRange, (ulong)signature, range);
        }

        public void SetOpaqueCurveIntersectionFunction(in MTLIntersectionFunctionSignature signature, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaqueCurveIntersectionFunctionWithSignatureatIndex, (ulong)signature, index);
        }

        public void SetOpaqueCurveIntersectionFunction(in MTLIntersectionFunctionSignature signature, in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaqueCurveIntersectionFunctionWithSignaturewithRange, (ulong)signature, range);
        }

        public void SetVisibleFunctionTable(in MTLVisibleFunctionTable functionTable, in ulong bufferIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVisibleFunctionTableatBufferIndex, functionTable, bufferIndex);
        }

        public void SetVisibleFunctionTables(in IntPtr functionTables, in NSRange bufferRange)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVisibleFunctionTableswithBufferRange, functionTables, bufferRange);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_cpuCacheMode = "cpuCacheMode";
        private static readonly Selector sel_storageMode = "storageMode";
        private static readonly Selector sel_hazardTrackingMode = "hazardTrackingMode";
        private static readonly Selector sel_resourceOptions = "resourceOptions";
        private static readonly Selector sel_setPurgeableState = "setPurgeableState:";
        private static readonly Selector sel_heap = "heap";
        private static readonly Selector sel_heapOffset = "heapOffset";
        private static readonly Selector sel_allocatedSize = "allocatedSize";
        private static readonly Selector sel_makeAliasable = "makeAliasable";
        private static readonly Selector sel_isAliasable = "isAliasable";
        private static readonly Selector sel_setBufferoffsetatIndex = "setBuffer:offset:atIndex:";
        private static readonly Selector sel_setBuffersoffsetswithRange = "setBuffers:offsets:withRange:";
        private static readonly Selector sel_gpuResourceID = "gpuResourceID";
        private static readonly Selector sel_setFunctionatIndex = "setFunction:atIndex:";
        private static readonly Selector sel_setFunctionswithRange = "setFunctions:withRange:";
        private static readonly Selector sel_setOpaqueTriangleIntersectionFunctionWithSignatureatIndex = "setOpaqueTriangleIntersectionFunctionWithSignature:atIndex:";
        private static readonly Selector sel_setOpaqueTriangleIntersectionFunctionWithSignaturewithRange = "setOpaqueTriangleIntersectionFunctionWithSignature:withRange:";
        private static readonly Selector sel_setOpaqueCurveIntersectionFunctionWithSignatureatIndex = "setOpaqueCurveIntersectionFunctionWithSignature:atIndex:";
        private static readonly Selector sel_setOpaqueCurveIntersectionFunctionWithSignaturewithRange = "setOpaqueCurveIntersectionFunctionWithSignature:withRange:";
        private static readonly Selector sel_setVisibleFunctionTableatBufferIndex = "setVisibleFunctionTable:atBufferIndex:";
        private static readonly Selector sel_setVisibleFunctionTableswithBufferRange = "setVisibleFunctionTables:withBufferRange:";
    }
}
