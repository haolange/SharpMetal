using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLAccelerationStructureRefitOptions : ulong
    {
        VertexData = 1,
        PerPrimitiveData = 2,
    }

    public partial struct MTLAccelerationStructureCommandEncoder
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLAccelerationStructureCommandEncoder obj) => obj.NativePtr;
        public static implicit operator MTLCommandEncoder(in MTLAccelerationStructureCommandEncoder obj) => new MTLCommandEncoder(obj.NativePtr);
        public static implicit operator MTLAccelerationStructureCommandEncoder(in MTLCommandEncoder obj) => new MTLAccelerationStructureCommandEncoder(obj.NativePtr);

        public MTLAccelerationStructureCommandEncoder(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public void EndEncoding()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_endEncoding);
        }

        public void InsertDebugSignpost(in NSString nsString)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_insertDebugSignpost, nsString);
        }

        public void PushDebugGroup(in NSString nsString)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_pushDebugGroup, nsString);
        }

        public void PopDebugGroup()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_popDebugGroup);
        }

        public void BuildAccelerationStructure(in MTLAccelerationStructure accelerationStructure, in MTLAccelerationStructureDescriptor descriptor, in MTLBuffer scratchBuffer, in ulong scratchBufferOffset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_buildAccelerationStructuredescriptorscratchBufferscratchBufferOffset, accelerationStructure, descriptor, scratchBuffer, scratchBufferOffset);
        }

        public void RefitAccelerationStructure(in MTLAccelerationStructure sourceAccelerationStructure, in MTLAccelerationStructureDescriptor descriptor, in MTLAccelerationStructure destinationAccelerationStructure, in MTLBuffer scratchBuffer, in ulong scratchBufferOffset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_refitAccelerationStructuredescriptordestinationscratchBufferscratchBufferOffset, sourceAccelerationStructure, descriptor, destinationAccelerationStructure, scratchBuffer, scratchBufferOffset);
        }

        public void RefitAccelerationStructure(in MTLAccelerationStructure sourceAccelerationStructure, in MTLAccelerationStructureDescriptor descriptor, in MTLAccelerationStructure destinationAccelerationStructure, in MTLBuffer scratchBuffer, in ulong scratchBufferOffset, in MTLAccelerationStructureRefitOptions options)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_refitAccelerationStructuredescriptordestinationscratchBufferscratchBufferOffsetoptions, sourceAccelerationStructure, descriptor, destinationAccelerationStructure, scratchBuffer, scratchBufferOffset, (ulong)options);
        }

        public void CopyAccelerationStructure(in MTLAccelerationStructure sourceAccelerationStructure, in MTLAccelerationStructure destinationAccelerationStructure)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyAccelerationStructuretoAccelerationStructure, sourceAccelerationStructure, destinationAccelerationStructure);
        }

        public void WriteCompactedAccelerationStructureSize(in MTLAccelerationStructure accelerationStructure, in MTLBuffer buffer, in ulong offset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_writeCompactedAccelerationStructureSizetoBufferoffset, accelerationStructure, buffer, offset);
        }

        public void WriteCompactedAccelerationStructureSize(in MTLAccelerationStructure accelerationStructure, in MTLBuffer buffer, in ulong offset, in MTLDataType sizeDataType)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_writeCompactedAccelerationStructureSizetoBufferoffsetsizeDataType, accelerationStructure, buffer, offset, (ulong)sizeDataType);
        }

        public void CopyAndCompactAccelerationStructure(in MTLAccelerationStructure sourceAccelerationStructure, in MTLAccelerationStructure destinationAccelerationStructure)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyAndCompactAccelerationStructuretoAccelerationStructure, sourceAccelerationStructure, destinationAccelerationStructure);
        }

        public void UpdateFence(in MTLFence fence)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_updateFence, fence);
        }

        public void WaitForFence(in MTLFence fence)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_waitForFence, fence);
        }

        public void UseResource(in MTLResource resource, in MTLResourceUsage usage)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_useResourceusage, resource, (ulong)usage);
        }

        public void UseResources(in IntPtr resources, in ulong count, in MTLResourceUsage usage)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_useResourcescountusage, resources, (ulong)usage);
        }

        public void UseHeap(in MTLHeap heap)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_useHeap, heap);
        }

        public void UseHeaps(in IntPtr heaps, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_useHeapscount, heaps, (ulong)count);
        }

        public void SampleCountersInBuffer(in MTLCounterSampleBuffer sampleBuffer, in ulong sampleIndex, in bool barrier)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_sampleCountersInBufferatSampleIndexwithBarrier, sampleBuffer, sampleIndex, barrier);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_endEncoding = "endEncoding";
        private static readonly Selector sel_insertDebugSignpost = "insertDebugSignpost:";
        private static readonly Selector sel_pushDebugGroup = "pushDebugGroup:";
        private static readonly Selector sel_popDebugGroup = "popDebugGroup";
        private static readonly Selector sel_buildAccelerationStructuredescriptorscratchBufferscratchBufferOffset = "buildAccelerationStructure:descriptor:scratchBuffer:scratchBufferOffset:";
        private static readonly Selector sel_refitAccelerationStructuredescriptordestinationscratchBufferscratchBufferOffset = "refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:";
        private static readonly Selector sel_refitAccelerationStructuredescriptordestinationscratchBufferscratchBufferOffsetoptions = "refitAccelerationStructure:descriptor:destination:scratchBuffer:scratchBufferOffset:options:";
        private static readonly Selector sel_copyAccelerationStructuretoAccelerationStructure = "copyAccelerationStructure:toAccelerationStructure:";
        private static readonly Selector sel_writeCompactedAccelerationStructureSizetoBufferoffset = "writeCompactedAccelerationStructureSize:toBuffer:offset:";
        private static readonly Selector sel_writeCompactedAccelerationStructureSizetoBufferoffsetsizeDataType = "writeCompactedAccelerationStructureSize:toBuffer:offset:sizeDataType:";
        private static readonly Selector sel_copyAndCompactAccelerationStructuretoAccelerationStructure = "copyAndCompactAccelerationStructure:toAccelerationStructure:";
        private static readonly Selector sel_updateFence = "updateFence:";
        private static readonly Selector sel_waitForFence = "waitForFence:";
        private static readonly Selector sel_useResourceusage = "useResource:usage:";
        private static readonly Selector sel_useResourcescountusage = "useResources:count:usage:";
        private static readonly Selector sel_useHeap = "useHeap:";
        private static readonly Selector sel_useHeapscount = "useHeaps:count:";
        private static readonly Selector sel_sampleCountersInBufferatSampleIndexwithBarrier = "sampleCountersInBuffer:atSampleIndex:withBarrier:";
    }

    public partial struct MTLAccelerationStructurePassSampleBufferAttachmentDescriptor
    {
        public IntPtr NativePtr;

        public MTLAccelerationStructurePassSampleBufferAttachmentDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructurePassSampleBufferAttachmentDescriptor New() => s_class.AllocInit<MTLAccelerationStructurePassSampleBufferAttachmentDescriptor>();

        public MTLCounterSampleBuffer SampleBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_sampleBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSampleBuffer, value);
        }
        
        public ulong StartOfEncoderSampleIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_startOfEncoderSampleIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStartOfEncoderSampleIndex, value);
        }
        
        public ulong EndOfEncoderSampleIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_endOfEncoderSampleIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setEndOfEncoderSampleIndex, value);
        }

        public static implicit operator IntPtr(in MTLAccelerationStructurePassSampleBufferAttachmentDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructurePassSampleBufferAttachmentDescriptor));
        private static readonly Selector sel_sampleBuffer = "sampleBuffer";
        private static readonly Selector sel_setSampleBuffer = "setSampleBuffer:";
        private static readonly Selector sel_startOfEncoderSampleIndex = "startOfEncoderSampleIndex";
        private static readonly Selector sel_setStartOfEncoderSampleIndex = "setStartOfEncoderSampleIndex:";
        private static readonly Selector sel_endOfEncoderSampleIndex = "endOfEncoderSampleIndex";
        private static readonly Selector sel_setEndOfEncoderSampleIndex = "setEndOfEncoderSampleIndex:";
    }
    
    public partial struct MTLAccelerationStructurePassSampleBufferAttachmentDescriptorArray
    {
        public IntPtr NativePtr;

        public MTLAccelerationStructurePassSampleBufferAttachmentDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructurePassSampleBufferAttachmentDescriptor New() => s_class.AllocInit<MTLAccelerationStructurePassSampleBufferAttachmentDescriptor>();

        public MTLAccelerationStructurePassSampleBufferAttachmentDescriptor this[uint index]
        {
            get
            {
                return Object(index);
            }
            set
            {
                SetObject(value, index);
            }
        }

        public MTLAccelerationStructurePassSampleBufferAttachmentDescriptor Object(in ulong attachmentIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, attachmentIndex));
        }

        public void SetObject(in MTLAccelerationStructurePassSampleBufferAttachmentDescriptor attachment, in ulong attachmentIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, attachment, attachmentIndex);
        }

        public static implicit operator IntPtr(in MTLAccelerationStructurePassSampleBufferAttachmentDescriptorArray obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructurePassSampleBufferAttachmentDescriptor));
        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    public partial struct MTLAccelerationStructurePassDescriptor
    {
        public IntPtr NativePtr;

        public MTLAccelerationStructurePassDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructurePassDescriptor New() => s_class.AllocInit<MTLAccelerationStructurePassDescriptor>();

        public MTLAccelerationStructurePassSampleBufferAttachmentDescriptorArray SampleBufferAttachments => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_sampleBufferAttachments));

        public static implicit operator IntPtr(in MTLAccelerationStructurePassDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructurePassDescriptor));
        private static readonly Selector sel_sampleBufferAttachments = "sampleBufferAttachments";
        private static readonly Selector sel_accelerationStructurePassDescriptor = "accelerationStructurePassDescriptor";
    }
}
