using SharpMetal.Metal;
using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.QuartzCore
{
    public partial struct CAMetalDrawable
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in CAMetalDrawable obj) => obj.NativePtr;
        public CAMetalDrawable(in IntPtr ptr) => NativePtr = ptr;

        public CAMetalLayer Layer => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_layer));

        public MTLTexture Texture => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_texture));

        public IntPtr PresentedTime => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_presentedTime));

        public ulong DrawableID => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_drawableID);

        public void Present()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_present);
        }

        public void PresentAtTime(in IntPtr presentationTime)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_presentAtTime, presentationTime);
        }

        public void PresentAfterMinimumDuration(in IntPtr duration)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_presentAfterMinimumDuration, duration);
        }

        private static readonly Selector sel_layer = "layer";
        private static readonly Selector sel_texture = "texture";
        private static readonly Selector sel_present = "present";
        private static readonly Selector sel_presentAtTime = "presentAtTime:";
        private static readonly Selector sel_presentAfterMinimumDuration = "presentAfterMinimumDuration:";
        private static readonly Selector sel_presentedTime = "presentedTime";
        private static readonly Selector sel_drawableID = "drawableID";
    }
}
