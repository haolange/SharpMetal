using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLAllocation
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLAllocation obj) => obj.NativePtr;
        public MTLAllocation(in IntPtr ptr) => NativePtr = ptr;

        public ulong Label
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_allocatedSize);
        }

        private static readonly Selector sel_allocatedSize = "allocatedSize";
    }
}
