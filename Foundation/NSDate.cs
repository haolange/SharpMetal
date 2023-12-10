using System;
using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public partial struct NSDate
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSDate obj) => obj.NativePtr;
        public NSDate(in IntPtr ptr) => NativePtr = ptr;

        public static NSDate DateWithTimeIntervalSinceNow(IntPtr secs)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSDate"), sel_dateWithTimeIntervalSinceNow, secs));
        }

        private static readonly Selector sel_dateWithTimeIntervalSinceNow = "dateWithTimeIntervalSinceNow:";
    }
}
