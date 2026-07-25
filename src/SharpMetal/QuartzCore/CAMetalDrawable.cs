using SharpMetal.Metal;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.QuartzCore
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CAMetalDrawablePresentedHandler(
        IntPtr block, CAMetalDrawable drawable);

    public partial struct CAMetalDrawable
    {
        public IntPtr NativePtr;

        public CAMetalDrawable(in IntPtr ptr) => NativePtr = ptr;

        public bool IsNull => NativePtr == IntPtr.Zero;

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

        public void AddPresentedHandler(CAMetalDrawablePresentedHandler handler)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addPresentedHandler, handler);
        }

        public static implicit operator IntPtr(in CAMetalDrawable obj) => obj.NativePtr;
        public static implicit operator MTLDrawable(in CAMetalDrawable obj) => new MTLDrawable(obj.NativePtr);
        public static implicit operator CAMetalDrawable(in MTLDrawable obj) => new CAMetalDrawable(obj.NativePtr);

        private static readonly Selector sel_layer = "layer";
        private static readonly Selector sel_texture = "texture";
        private static readonly Selector sel_present = "present";
        private static readonly Selector sel_presentAtTime = "presentAtTime:";
        private static readonly Selector sel_presentAfterMinimumDuration = "presentAfterMinimumDuration:";
        private static readonly Selector sel_presentedTime = "presentedTime";
        private static readonly Selector sel_drawableID = "drawableID";
        private static readonly Selector sel_addPresentedHandler = "addPresentedHandler:";
    }
}
