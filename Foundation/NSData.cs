using System;
using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public partial struct NSData
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSData obj) => obj.NativePtr;
        public NSData(in IntPtr ptr) => NativePtr = ptr;

        public IntPtr MutableBytes => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_mutableBytes));

        public ulong Length => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_length);

        private static readonly Selector sel_mutableBytes = "mutableBytes";
        private static readonly Selector sel_length = "length";
    }
}
