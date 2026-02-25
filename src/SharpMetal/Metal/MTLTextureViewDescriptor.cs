using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLTextureViewDescriptor
    {
        public IntPtr NativePtr;

        public MTLTextureViewDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLTextureViewDescriptor New() => s_class.AllocInit<MTLTextureViewDescriptor>();

        public MTLPixelFormat PixelFormat
        {
            get => (MTLPixelFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_pixelFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPixelFormat, (ulong)value);
        }

        public MTLTextureType TextureType
        {
            get => (MTLTextureType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_textureType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTextureType, (ulong)value);
        }

        public NSRange LevelRange
        {
            get => ObjectiveCRuntime.NSRange_objc_msgSend(NativePtr, sel_levelRange);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLevelRange, value);
        }

        public NSRange SliceRange
        {
            get => ObjectiveCRuntime.NSRange_objc_msgSend(NativePtr, sel_sliceRange);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSliceRange, value);
        }

        public MTLTextureSwizzleChannels Swizzle
        {
            get => ObjectiveCRuntime.MTLTextureSwizzleChannels_objc_msgSend(NativePtr, sel_swizzle);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSwizzle, value);
        }

        public static implicit operator IntPtr(in MTLTextureViewDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLTextureViewDescriptor));
        private static readonly Selector sel_pixelFormat = "pixelFormat";
        private static readonly Selector sel_setPixelFormat = "setPixelFormat:";
        private static readonly Selector sel_textureType = "textureType";
        private static readonly Selector sel_setTextureType = "setTextureType:";
        private static readonly Selector sel_levelRange = "levelRange";
        private static readonly Selector sel_setLevelRange = "setLevelRange:";
        private static readonly Selector sel_sliceRange = "sliceRange";
        private static readonly Selector sel_setSliceRange = "setSliceRange:";
        private static readonly Selector sel_swizzle = "swizzle";
        private static readonly Selector sel_setSwizzle = "setSwizzle:";
    }
}
