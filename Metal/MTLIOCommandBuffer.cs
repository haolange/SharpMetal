using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLIOStatus : long
    {
        Pending = 0,
        Cancelled = 1,
        Error = 2,
        Complete = 3,
    }
    
    public partial struct MTLIOCommandBuffer
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLIOCommandBuffer obj) => obj.NativePtr;
        public MTLIOCommandBuffer(in IntPtr ptr) => NativePtr = ptr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLIOStatus Status => (MTLIOStatus)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_status);

        public NSError Error => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_error));

        public void LoadBytes(in IntPtr pointer, in ulong size, in IntPtr sourceHandle, in ulong sourceHandleOffset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_loadBytessizesourceHandlesourceHandleOffset, pointer, size, sourceHandle, sourceHandleOffset);
        }

        public void LoadBuffer(in MTLBuffer buffer, in ulong offset, in ulong size, in IntPtr sourceHandle, in ulong sourceHandleOffset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_loadBufferoffsetsizesourceHandlesourceHandleOffset, buffer, offset, size, sourceHandle, sourceHandleOffset);
        }

        public void LoadTexture(in MTLTexture texture, in ulong slice, in ulong level, in MTLSize size, in ulong sourceBytesPerRow, in ulong sourceBytesPerImage, in MTLOrigin destinationOrigin, in IntPtr sourceHandle, in ulong sourceHandleOffset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_loadTextureslicelevelsizesourceBytesPerRowsourceBytesPerImagedestinationOriginsourceHandlesourceHandleOffset, texture, slice, level, size, sourceBytesPerRow, sourceBytesPerImage, destinationOrigin, sourceHandle, sourceHandleOffset);
        }

        public void CopyStatusToBuffer(in MTLBuffer buffer, in ulong offset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyStatusToBufferoffset, buffer, offset);
        }

        public void Commit()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_commit);
        }

        public void WaitUntilCompleted()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_waitUntilCompleted);
        }

        public void TryCancel()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_tryCancel);
        }

        public void AddBarrier()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addBarrier);
        }

        public void PushDebugGroup(in NSString nsString)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_pushDebugGroup, nsString);
        }

        public void PopDebugGroup()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_popDebugGroup);
        }

        public void Enqueue()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_enqueue);
        }

        public void Wait(in MTLSharedEvent mltEvent, in ulong value)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_waitForEventvalue, mltEvent, value);
        }

        public void SignalEvent(in MTLSharedEvent mltEvent, in ulong value)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_signalEventvalue, mltEvent, value);
        }

        private static readonly Selector sel_loadBytessizesourceHandlesourceHandleOffset = "loadBytes:size:sourceHandle:sourceHandleOffset:";
        private static readonly Selector sel_loadBufferoffsetsizesourceHandlesourceHandleOffset = "loadBuffer:offset:size:sourceHandle:sourceHandleOffset:";
        private static readonly Selector sel_loadTextureslicelevelsizesourceBytesPerRowsourceBytesPerImagedestinationOriginsourceHandlesourceHandleOffset = "loadTexture:slice:level:size:sourceBytesPerRow:sourceBytesPerImage:destinationOrigin:sourceHandle:sourceHandleOffset:";
        private static readonly Selector sel_copyStatusToBufferoffset = "copyStatusToBuffer:offset:";
        private static readonly Selector sel_commit = "commit";
        private static readonly Selector sel_waitUntilCompleted = "waitUntilCompleted";
        private static readonly Selector sel_tryCancel = "tryCancel";
        private static readonly Selector sel_addBarrier = "addBarrier";
        private static readonly Selector sel_pushDebugGroup = "pushDebugGroup:";
        private static readonly Selector sel_popDebugGroup = "popDebugGroup";
        private static readonly Selector sel_enqueue = "enqueue";
        private static readonly Selector sel_waitForEventvalue = "waitForEvent:value:";
        private static readonly Selector sel_signalEventvalue = "signalEvent:value:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_status = "status";
        private static readonly Selector sel_error = "error";
    }
}
