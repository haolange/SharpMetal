using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MTL4CommitFeedbackHandler(IntPtr block, MTL4CommitFeedback commitFeedback);

    public partial struct MTL4CommitFeedback
    {
        public IntPtr NativePtr;

        public MTL4CommitFeedback(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4CommitFeedback obj) => obj.NativePtr;

        public NSError Error => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_error));

        public double GPUStartTime => ObjectiveCRuntime.double_objc_msgSend(NativePtr, sel_GPUStartTime);

        public double GPUEndTime => ObjectiveCRuntime.double_objc_msgSend(NativePtr, sel_GPUEndTime);

        private static readonly Selector sel_error = "error";
        private static readonly Selector sel_GPUStartTime = "GPUStartTime";
        private static readonly Selector sel_GPUEndTime = "GPUEndTime";
    }
}
