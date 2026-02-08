using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTL4TimestampHeapEntry
    {
        public ulong Timestamp;
    }

    public enum MTL4CounterHeapType : long
    {
        Invalid = 0,
        Timestamp = 1,
    }

    public enum MTL4TimestampGranularity : long
    {
        Relaxed = 0,
        Precise = 1,
    }

    public partial struct MTL4CounterHeapDescriptor
    {
        public IntPtr NativePtr;

        public MTL4CounterHeapDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4CounterHeapDescriptor New() => s_class.AllocInit<MTL4CounterHeapDescriptor>();

        public MTL4CounterHeapType Type
        {
            get => (MTL4CounterHeapType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_type);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setType, (long)value);
        }

        public ulong Count
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_count);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCount, value);
        }

        public static implicit operator IntPtr(in MTL4CounterHeapDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4CounterHeapDescriptor));
        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_setType = "setType:";
        private static readonly Selector sel_count = "count";
        private static readonly Selector sel_setCount = "setCount:";
    }

    public partial struct MTL4CounterHeap
    {
        public IntPtr NativePtr;

        public MTL4CounterHeap(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4CounterHeap obj) => obj.NativePtr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public ulong Count => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_count);

        public MTL4CounterHeapType Type => (MTL4CounterHeapType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_type);

        public IntPtr ResolveCounterRange(in NSRange range)
        {
            return ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_resolveCounterRange, range);
        }

        public void InvalidateCounterRange(in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_invalidateCounterRange, range);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_count = "count";
        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_resolveCounterRange = "resolveCounterRange:";
        private static readonly Selector sel_invalidateCounterRange = "invalidateCounterRange:";
    }
}
