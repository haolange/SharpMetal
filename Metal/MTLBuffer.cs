using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLBuffer
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLBuffer obj) => obj.NativePtr;
        public static implicit operator MTLResource(in MTLBuffer obj) => new MTLResource(obj.NativePtr);
        public static implicit operator MTLBuffer(in MTLResource obj) => new MTLBuffer(obj.NativePtr);

        public MTLBuffer(in IntPtr ptr) => NativePtr = ptr;

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

        public ulong Length => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_length);

        public IntPtr Contents => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_contents));

        public MTLBuffer RemoteStorageBuffer => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_remoteStorageBuffer));

        public ulong GpuAddress => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_gpuAddress);

        public MTLPurgeableState SetPurgeableState(in MTLPurgeableState state)
        {
            return (MTLPurgeableState)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_setPurgeableState, (ulong)state);
        }

        public void MakeAliasable()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_makeAliasable);
        }

        public void DidModifyRange(in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_didModifyRange, range);
        }

        public MTLTexture NewTexture(in MTLTextureDescriptor descriptor, in ulong offset, in ulong bytesPerRow)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newTextureWithDescriptoroffsetbytesPerRow, descriptor, offset, bytesPerRow));
        }

        public void AddDebugMarker(in NSString marker, in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addDebugMarkerrange, marker, range);
        }

        public void RemoveAllDebugMarkers()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_removeAllDebugMarkers);
        }

        public MTLBuffer NewRemoteBufferViewForDevice(in MTLDevice device)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_newRemoteBufferViewForDevice, device));
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
        private static readonly Selector sel_length = "length";
        private static readonly Selector sel_contents = "contents";
        private static readonly Selector sel_didModifyRange = "didModifyRange:";
        private static readonly Selector sel_newTextureWithDescriptoroffsetbytesPerRow = "newTextureWithDescriptor:offset:bytesPerRow:";
        private static readonly Selector sel_addDebugMarkerrange = "addDebugMarker:range:";
        private static readonly Selector sel_removeAllDebugMarkers = "removeAllDebugMarkers";
        private static readonly Selector sel_remoteStorageBuffer = "remoteStorageBuffer";
        private static readonly Selector sel_newRemoteBufferViewForDevice = "newRemoteBufferViewForDevice:";
        private static readonly Selector sel_gpuAddress = "gpuAddress";
    }
}
