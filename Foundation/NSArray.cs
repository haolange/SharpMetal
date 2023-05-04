using System;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public unsafe struct NSArray
    {
        public readonly IntPtr NativePtr;
        public NSArray(in IntPtr ptr) => NativePtr = ptr;

        public uint count => (uint)UIntPtr_objc_msgSend(NativePtr, sel_count);
        public IntPtr lastObject => IntPtr_objc_msgSend(NativePtr, sel_lastObject);
        public IntPtr firstObject => IntPtr_objc_msgSend(NativePtr, sel_firstObject);
        public IntPtr this[uint index]
        {
            get
            {
                return IntPtr_objc_msgSend(NativePtr, sel_objectAtIndex, index);
            }
        }

        private static readonly Selector sel_count = "count";
        private static readonly Selector sel_lastObject = "lastObject";
        private static readonly Selector sel_firstObject = "firstObject";
        private static readonly Selector sel_objectAtIndex = "objectAtIndex:";
    }
}