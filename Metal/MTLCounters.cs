using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    public enum MTLCounterSampleBufferError : long
    {
        OutOfMemory = 0,
        Invalid = 1,
        Internal = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLCounterResultTimestamp
    {
        public ulong timestamp;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLCounterResultStageUtilization
    {
        public ulong totalCycles;
        public ulong vertexCycles;
        public ulong tessellationCycles;
        public ulong postTessellationVertexCycles;
        public ulong fragmentCycles;
        public ulong renderTargetCycles;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLCounterResultStatistic
    {
        public ulong tessellationInputPatches;
        public ulong vertexInvocations;
        public ulong postTessellationVertexInvocations;
        public ulong clipperInvocations;
        public ulong clipperPrimitivesOut;
        public ulong fragmentInvocations;
        public ulong fragmentsPassed;
        public ulong computeKernelInvocations;
    }

    public partial struct MTLCounter
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLCounter obj) => obj.NativePtr;
        public MTLCounter(in IntPtr ptr) => NativePtr = ptr;

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        private static readonly Selector sel_name = "name";
    }

    public partial struct MTLCounterSet
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLCounterSet obj) => obj.NativePtr;
        public MTLCounterSet(in IntPtr ptr) => NativePtr = ptr;

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public NSArray Counters => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_counters));

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_counters = "counters";
    }

    public partial struct MTLCounterSampleBufferDescriptor
    {
        public IntPtr NativePtr;

        public MTLCounterSampleBufferDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLCounterSampleBufferDescriptor New() => s_class.AllocInit<MTLCounterSampleBufferDescriptor>();

        public MTLCounterSet CounterSet
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_counterSet));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCounterSet, value);
        }
        
        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }
        
        public MTLStorageMode StorageMode
        {
            get => (MTLStorageMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storageMode);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStorageMode, (ulong)value);
        }
        
        public ulong SampleCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_sampleCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSampleCount, value);
        }

        public static implicit operator IntPtr(in MTLCounterSampleBufferDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLCounterSampleBufferDescriptor));
        private static readonly Selector sel_counterSet = "counterSet";
        private static readonly Selector sel_setCounterSet = "setCounterSet:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_storageMode = "storageMode";
        private static readonly Selector sel_setStorageMode = "setStorageMode:";
        private static readonly Selector sel_sampleCount = "sampleCount";
        private static readonly Selector sel_setSampleCount = "setSampleCount:";
    }

    public partial struct MTLCounterSampleBuffer
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLCounterSampleBuffer obj) => obj.NativePtr;
        public MTLCounterSampleBuffer(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));

        public ulong SampleCount => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_sampleCount);

        public NSData ResolveCounterRange(NSRange range)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_resolveCounterRange, range));
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_sampleCount = "sampleCount";
        private static readonly Selector sel_resolveCounterRange = "resolveCounterRange:";
    }
}
