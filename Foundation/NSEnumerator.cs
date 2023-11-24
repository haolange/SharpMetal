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

    public partial class NSFastEnumeration
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(NSFastEnumeration obj) => obj.NativePtr;
        public NSFastEnumeration(IntPtr ptr) => NativePtr = ptr;

        protected NSFastEnumeration()
        {
            throw new NotImplementedException();
        }

        public ulong CountByEnumerating(NSFastEnumerationState pState, NSObject pBuffer, ulong len)
        {
            return ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_countByEnumeratingWithStateobjectscount, pState, pBuffer, len);
        }

        private static readonly Selector sel_countByEnumeratingWithStateobjectscount = "countByEnumeratingWithState:objects:count:";
    }

    public partial class NSEnumerator : NSFastEnumeration
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(NSEnumerator obj) => obj.NativePtr;
        public NSEnumerator(IntPtr ptr) : base(ptr) => NativePtr = ptr;

        protected NSEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
