using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public struct NSArray
    {
        public readonly IntPtr NativePtr;
        public NSArray(in IntPtr ptr) => NativePtr = ptr;

        public UIntPtr count => UIntPtr_objc_msgSend(NativePtr, sel_count);
        private static readonly Selector sel_count = "count";
    }
}