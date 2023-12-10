using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NSFastEnumerationState
    {
        public IntPtr itemsPtr;
    }

    public partial struct NSEnumerator
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSEnumerator obj) => obj.NativePtr;
        public NSEnumerator(in IntPtr ptr) => NativePtr = ptr;

        public ulong CountByEnumerating(NSFastEnumerationState pState, NSObject pBuffer, ulong len)
        {
            return ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_countByEnumeratingWithStateobjectscount, pState, pBuffer, len);
        }

        private static readonly Selector sel_countByEnumeratingWithStateobjectscount = "countByEnumeratingWithState:objects:count:";
    }
}
