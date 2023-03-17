using System;
using System.Runtime.InteropServices;

namespace Apple.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MTLBuffer
    {
        public readonly IntPtr NativePtr;
        public bool IsNull => NativePtr == IntPtr.Zero;

        public UIntPtr length => ObjectiveCRuntime.UIntPtr_objc_msgSend(NativePtr, sel_length);

        public IntPtr contents() => ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_contents);

        public MTLBuffer(in IntPtr ptr)
        {
            NativePtr = ptr;
        }

        public void didModifyRange(in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_didModifyRange, range);
        }

        public void addDebugMarker(in NSString marker, in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addDebugMarker, marker.NativePtr, range);
        }

        public void removeAllDebugMarkers()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_removeAllDebugMarkers);
        }

        private static readonly Selector sel_length = "length";
        private static readonly Selector sel_contents = "contents";
        private static readonly Selector sel_didModifyRange = "didModifyRange:";
        private static readonly Selector sel_addDebugMarker = "addDebugMarker:range:";
        private static readonly Selector sel_removeAllDebugMarkers = "removeAllDebugMarkers";
    }
}