using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Foundation
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NSFastEnumerationState
    {
        public IntPtr itemsPtr;
    }

    public partial struct NSFastEnumeration
    {
        public IntPtr NativePtr;

        public NSFastEnumeration(IntPtr ptr) => NativePtr = ptr;

        public ulong CountByEnumerating(NSFastEnumerationState pState, NSObject pBuffer, ulong len)
        {
            return ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_countByEnumeratingWithStateobjectscount, pState, pBuffer, len);
        }

        public static implicit operator IntPtr(NSFastEnumeration obj) => obj.NativePtr;

        private static readonly Selector sel_countByEnumeratingWithStateobjectscount = "countByEnumeratingWithState:objects:count:";
    }

    public partial struct NSEnumerator
    {
        public IntPtr NativePtr;
        
        public NSEnumerator(in IntPtr ptr) => NativePtr = ptr;

        public ulong CountByEnumerating(NSFastEnumerationState pState, NSObject pBuffer, ulong len)
        {
            return ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_countByEnumeratingWithStateobjectscount, pState, pBuffer, len);
        }

        public static implicit operator IntPtr(in NSEnumerator obj) => obj.NativePtr;
        public static implicit operator NSEnumerator(in NSFastEnumeration obj) => new NSEnumerator(obj.NativePtr);
        public static implicit operator NSFastEnumeration(in NSEnumerator obj) => new NSFastEnumeration(obj.NativePtr);

        private static readonly Selector sel_countByEnumeratingWithStateobjectscount = "countByEnumeratingWithState:objects:count:";
    }
}
