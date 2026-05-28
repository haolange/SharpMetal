using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    public enum MTL4CommandQueueError : long
    {
        None = 0,
        Timeout = 1,
        NotPermitted = 2,
        OutOfMemory = 3,
        DeviceRemoved = 4,
        AccessRevoked = 5,
        Internal = 6,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTL4UpdateSparseTextureMappingOperation
    {
        public ulong mode;
        public MTLRegion textureRegion;
        public ulong textureLevel;
        public ulong textureSlice;
        public ulong heapOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTL4CopySparseTextureMappingOperation
    {
        public MTLRegion sourceRegion;
        public ulong sourceLevel;
        public ulong sourceSlice;
        public MTLOrigin destinationOrigin;
        public ulong destinationLevel;
        public ulong destinationSlice;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTL4UpdateSparseBufferMappingOperation
    {
        public ulong mode;
        public NSRange bufferRange;
        public ulong heapOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTL4CopySparseBufferMappingOperation
    {
        public NSRange sourceRange;
        public ulong destinationOffset;
    }

    public partial struct MTL4CommitOptions
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4CommitOptions obj) => obj.NativePtr;

        public MTL4CommitOptions(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4CommitOptions New() => s_class.AllocInit<MTL4CommitOptions>();

        public void AddFeedbackHandler(MTL4CommitFeedbackHandler block)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addFeedbackHandler, block);
        }

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4CommitOptions));
        private static readonly Selector sel_addFeedbackHandler = "addFeedbackHandler:";
    }

    public partial struct MTL4CommandQueueDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4CommandQueueDescriptor obj) => obj.NativePtr;

        public MTL4CommandQueueDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4CommandQueueDescriptor New() => s_class.AllocInit<MTL4CommandQueueDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4CommandQueueDescriptor));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public IntPtr FeedbackQueue
        {
            get => ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_feedbackQueue);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFeedbackQueue, value);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_feedbackQueue = "feedbackQueue";
        private static readonly Selector sel_setFeedbackQueue = "setFeedbackQueue:";
    }

    public partial struct MTL4CommandQueue
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4CommandQueue obj) => obj.NativePtr;

        public MTL4CommandQueue(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));

        public void Commit(in IntPtr commandBuffers, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_commitCount, commandBuffers, count);
        }

        public void Commit(in IntPtr commandBuffers, in ulong count, in MTL4CommitOptions options)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_commitCountOptions, commandBuffers, count, options);
        }

        public void SignalEvent(in MTLEvent mtlEvent, in ulong value)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_signalEventValue, mtlEvent, value);
        }

        public void WaitForEvent(in MTLEvent mtlEvent, in ulong value)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_waitForEventValue, mtlEvent, value);
        }

        public void SignalDrawable(in MTLDrawable drawable)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_signalDrawable, drawable);
        }

        public void WaitForDrawable(in MTLDrawable drawable)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_waitForDrawable, drawable);
        }

        public void AddResidencySet(in MTLResidencySet residencySet)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addResidencySet, residencySet);
        }

        public void AddResidencySets(in IntPtr residencySets, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addResidencySets, residencySets, count);
        }

        public void RemoveResidencySet(in MTLResidencySet residencySet)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_removeResidencySet, residencySet);
        }

        public void RemoveResidencySets(in IntPtr residencySets, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_removeResidencySets, residencySets, count);
        }

        public void UpdateTextureMappings(in MTLTexture texture, in MTLHeap heap, in IntPtr operations, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_updateTextureMappings, texture, heap, operations, count);
        }

        public void CopyTextureMappings(in MTLTexture sourceTexture, in MTLTexture destinationTexture, in IntPtr operations, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyTextureMappings, sourceTexture, destinationTexture, operations, count);
        }

        public void UpdateBufferMappings(in MTLBuffer buffer, in MTLHeap heap, in IntPtr operations, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_updateBufferMappings, buffer, heap, operations, count);
        }

        public void CopyBufferMappings(in MTLBuffer sourceBuffer, in MTLBuffer destinationBuffer, in IntPtr operations, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyBufferMappings, sourceBuffer, destinationBuffer, operations, count);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_commitCount = "commit:count:";
        private static readonly Selector sel_commitCountOptions = "commit:count:options:";
        private static readonly Selector sel_signalEventValue = "signalEvent:value:";
        private static readonly Selector sel_waitForEventValue = "waitForEvent:value:";
        private static readonly Selector sel_signalDrawable = "signalDrawable:";
        private static readonly Selector sel_waitForDrawable = "waitForDrawable:";
        private static readonly Selector sel_addResidencySet = "addResidencySet:";
        private static readonly Selector sel_addResidencySets = "addResidencySets:count:";
        private static readonly Selector sel_removeResidencySet = "removeResidencySet:";
        private static readonly Selector sel_removeResidencySets = "removeResidencySets:count:";
        private static readonly Selector sel_updateTextureMappings = "updateTextureMappings:heap:operations:count:";
        private static readonly Selector sel_copyTextureMappings = "copyTextureMappingsFromTexture:toTexture:operations:count:";
        private static readonly Selector sel_updateBufferMappings = "updateBufferMappings:heap:operations:count:";
        private static readonly Selector sel_copyBufferMappings = "copyBufferMappingsFromBuffer:toBuffer:operations:count:";
    }
}
