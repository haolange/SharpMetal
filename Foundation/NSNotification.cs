using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public partial struct NSNotification
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSNotification obj) => obj.NativePtr;
        public NSNotification(in IntPtr ptr) => NativePtr = ptr;

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public NSObject Object => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_object));

        public NSDictionary UserInfo => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_userInfo));

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_object = "object";
        private static readonly Selector sel_userInfo = "userInfo";
    }

    public partial struct NSNotificationCenter
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSNotificationCenter obj) => obj.NativePtr;
        public NSNotificationCenter(in IntPtr ptr) => NativePtr = ptr;


        public static NSNotificationCenter DefaultCenter()
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNotificationCenter"), sel_defaultCenter));
        }

        private static readonly Selector sel_defaultCenter = "defaultCenter";
    }
}
