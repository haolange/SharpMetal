using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public struct MTLBlitCommandEncoder
    {
        public readonly IntPtr NativePtr;
        public bool IsNull => NativePtr == IntPtr.Zero;

        public void copy(
            in MTLBuffer sourceBuffer,
            in UIntPtr sourceOffset,
            in MTLBuffer destinationBuffer,
            in UIntPtr destinationOffset,
            in UIntPtr size)
            => objc_msgSend(
                NativePtr,
                sel_copyFromBuffer0,
                sourceBuffer, sourceOffset, destinationBuffer, destinationOffset, size);

        public void copyFromBuffer(
            in MTLBuffer sourceBuffer,
            in UIntPtr sourceOffset,
            in UIntPtr sourceBytesPerRow,
            in UIntPtr sourceBytesPerImage,
            in MTLSize sourceSize,
            in MTLTexture destinationTexture,
            in UIntPtr destinationSlice,
            in UIntPtr destinationLevel,
            in MTLOrigin destinationOrigin)
            => objc_msgSend(
                NativePtr,
                sel_copyFromBuffer1,
                sourceBuffer.NativePtr,
                sourceOffset,
                sourceBytesPerRow,
                sourceBytesPerImage,
                sourceSize,
                destinationTexture.NativePtr,
                destinationSlice,
                destinationLevel,
                destinationOrigin);

        public void copyTextureToBuffer(
            in MTLTexture sourceTexture,
            in UIntPtr sourceSlice,
            in UIntPtr sourceLevel,
            in MTLOrigin sourceOrigin,
            in MTLSize sourceSize,
            in MTLBuffer destinationBuffer,
            in UIntPtr destinationOffset,
            in UIntPtr destinationBytesPerRow,
            in UIntPtr destinationBytesPerImage)
            => objc_msgSend(NativePtr, sel_copyFromTexture0,
                sourceTexture,
                sourceSlice,
                sourceLevel,
                sourceOrigin,
                sourceSize,
                destinationBuffer,
                destinationOffset,
                destinationBytesPerRow,
                destinationBytesPerImage);

        public void generateMipmapsForTexture(in MTLTexture texture)
            => objc_msgSend(NativePtr, sel_generateMipmapsForTexture, texture.NativePtr);

        public void synchronizeResource(in IntPtr resource) => objc_msgSend(NativePtr, sel_synchronizeResource, resource);

        public void endEncoding() => objc_msgSend(NativePtr, sel_endEncoding);

        public void pushDebugGroup(in NSString @string) => objc_msgSend(NativePtr, Selectors.pushDebugGroup, @string.NativePtr);

        public void popDebugGroup() => objc_msgSend(NativePtr, Selectors.popDebugGroup);

        public void insertDebugSignpost(in NSString @string)
            => objc_msgSend(NativePtr, Selectors.insertDebugSignpost, @string.NativePtr);

        public void copyFromTexture(
            in MTLTexture sourceTexture,
            in UIntPtr sourceSlice,
            in UIntPtr sourceLevel,
            in MTLOrigin sourceOrigin,
            in MTLSize sourceSize,
            in MTLTexture destinationTexture,
            in UIntPtr destinationSlice,
            in UIntPtr destinationLevel,
            in MTLOrigin destinationOrigin)
            => objc_msgSend(NativePtr, sel_copyFromTexture1,
                sourceTexture,
                sourceSlice,
                sourceLevel,
                sourceOrigin,
                sourceSize,
                destinationTexture,
                destinationSlice,
                destinationLevel,
                destinationOrigin);

        private static readonly Selector sel_copyFromBuffer0 = "copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:";
        private static readonly Selector sel_copyFromBuffer1 = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:";
        private static readonly Selector sel_copyFromTexture0 = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:";
        private static readonly Selector sel_copyFromTexture1 = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:";
        private static readonly Selector sel_generateMipmapsForTexture = "generateMipmapsForTexture:";
        private static readonly Selector sel_synchronizeResource = "synchronizeResource:";
        private static readonly Selector sel_endEncoding = "endEncoding";
    }
}