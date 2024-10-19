using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLResidencySetDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLResidencySetDescriptor obj) => obj.NativePtr;

        public MTLResidencySetDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLResidencySetDescriptor New() => s_class.AllocInit<MTLResidencySetDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLResidencySetDescriptor));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public ulong InitialCapacity
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_initialCapacity);
            set => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_setInitialCapacity, value);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_initialCapacity = "initialCapacity";
        private static readonly Selector sel_setInitialCapacity = "setInitialCapacity:";
    }

    public partial struct MTLResidencySet
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLResidencySet obj) => obj.NativePtr;

        public MTLResidencySet(in IntPtr ptr) => NativePtr = ptr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public ulong AllocatedSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_allocatedSize);

        public ulong AllocatedCount => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_allocationCount);

        public NSArray allAllocations() => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_allAllocations));

        public void RequestResidency(in MTLResidencySet residencySet)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_requestResidency);
        }

        public void EndResidency(in MTLResidencySet residencySet)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_endResidency, residencySet);
        }

        public void AddAllocation(in MTLAllocation allocation)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addAllocation, allocation);
        }

        public void AddAllocations(in IntPtr allocations, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addAllocations, allocations, (ulong)count);
        }

        public void RemoveAllocation(in MTLAllocation allocation)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_removeAllocation, allocation);
        }

        public void RemoveAllocations(in IntPtr allocations, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_removeAllocations, allocations, (ulong)count);
        }

        public void RemoveAllAllocations()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_removeAllAllocations);
        }

        public bool ContainsAllocation(in MTLAllocation allocation)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_containsAllocation, allocation);
        }

        public void Commit()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_commit);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_allocatedSize = "allocatedSize";
        private static readonly Selector sel_requestResidency = "requestResidency";
        private static readonly Selector sel_endResidency = "endResidency";
        private static readonly Selector sel_addAllocation = "addAllocation:";
        private static readonly Selector sel_addAllocations = "addAllocations:count:";
        private static readonly Selector sel_removeAllocation = "removeAllocation:";
        private static readonly Selector sel_removeAllocations = "removeAllocations:count:";
        private static readonly Selector sel_removeAllAllocations = "removeAllAllocations";
        private static readonly Selector sel_containsAllocation = "containsAllocation:";
        private static readonly Selector sel_allAllocations = "allAllocations";
        private static readonly Selector sel_allocationCount = "allocationCount";
        private static readonly Selector sel_commit = "commit";
    }
}
