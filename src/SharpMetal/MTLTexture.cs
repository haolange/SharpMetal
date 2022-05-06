using static Apple.Metal.ObjectiveCRuntime;
using System;
using System.Runtime.InteropServices;

namespace Apple.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MTLTexture
    {
        public readonly IntPtr NativePtr;

        public MTLTexture(in IntPtr ptr) => NativePtr = ptr;
        public bool IsNull => NativePtr == IntPtr.Zero;

        public void replaceRegion(
            in MTLRegion region,
            in UIntPtr mipmapLevel,
            in UIntPtr slice,
            in void* pixelBytes,
            in UIntPtr bytesPerRow,
            in UIntPtr bytesPerImage)
        {
            objc_msgSend(NativePtr, sel_replaceRegion,
                region,
                mipmapLevel,
                slice,
                (IntPtr)pixelBytes,
                bytesPerRow,
                bytesPerImage);
        }

        public MTLTexture newTextureView(
            in MTLPixelFormat pixelFormat,
            in MTLTextureType textureType,
            in NSRange levelRange,
            in NSRange sliceRange)
        {
            IntPtr ret = IntPtr_objc_msgSend(NativePtr, sel_newTextureView,
                (uint)pixelFormat, (uint)textureType, levelRange, sliceRange);
            return new MTLTexture(ret);
        }

        private static readonly Selector sel_replaceRegion = "replaceRegion:mipmapLevel:slice:withBytes:bytesPerRow:bytesPerImage:";
        private static readonly Selector sel_newTextureView = "newTextureViewWithPixelFormat:textureType:levels:slices:";
    }
}