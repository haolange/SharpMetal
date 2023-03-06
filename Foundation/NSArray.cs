using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public unsafe struct NSArray
    {
        public readonly IntPtr NativePtr;
        public NSArray(in IntPtr ptr) => NativePtr = ptr;

        public UIntPtr count => UIntPtr_objc_msgSend(NativePtr, sel_count);

        public IntPtr this[int index]
        {
            get
            {
                return objc_msgSend<IntPtr>(NativePtr, sel_objects, new IntPtr(&index));
            }
        }

        private static readonly Selector sel_count = "count";
        private static readonly Selector sel_objects = "objects";
    }
}