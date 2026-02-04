using SharpMetal.ObjectiveCCore;

namespace SharpMetal.QuartzCore
{
    public struct CALayer
    {
        public readonly IntPtr NativePtr;

        public static implicit operator IntPtr(in CALayer c) => c.NativePtr;

        public CALayer(in IntPtr ptr) => NativePtr = ptr;

        public void AddSublayer(in IntPtr layer)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addSublayer, layer);
        }

        private static readonly Selector sel_addSublayer = "addSublayer:";
    }
}