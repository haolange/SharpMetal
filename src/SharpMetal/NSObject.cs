using static Apple.Metal.ObjectiveCRuntime;
using System;

namespace Apple.Metal
{
    public struct NSObject
    {
        public readonly IntPtr NativePtr;

        public NSObject(in IntPtr ptr) => NativePtr = ptr;

        public Bool8 IsKindOfClass(in IntPtr @class) => bool8_objc_msgSend(NativePtr, sel_isKindOfClass, @class);

        private static readonly Selector sel_isKindOfClass = "isKindOfClass:";
    }
}
