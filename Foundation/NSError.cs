using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public partial struct NSError
    {
        public IntPtr NativePtr;

        public NSError(in IntPtr ptr) => NativePtr = ptr;

        public static NSError New() => s_class.AllocInit<NSError>();

        public long Code => ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_code);

        public IntPtr Domain => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_domain));

        public NSDictionary UserInfo => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_userInfo));

        public NSString LocalizedDescription => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_localizedDescription));

        public NSArray LocalizedRecoveryOptions => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_localizedRecoveryOptions));

        public NSString LocalizedRecoverySuggestion => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_localizedRecoverySuggestion));

        public NSString LocalizedFailureReason => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_localizedFailureReason));

        public static NSError Error(in IntPtr domain, in long code, in NSDictionary pDictionary)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSError"), sel_errorWithDomaincodeuserInfo, domain, code, pDictionary));
        }

        public NSError Init(in IntPtr domain, in long code, in NSDictionary pDictionary)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithDomaincodeuserInfo, domain, code, pDictionary));
        }

        public static implicit operator IntPtr(in NSError obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(NSError));
        private static readonly Selector sel_errorWithDomaincodeuserInfo = "errorWithDomain:code:userInfo:";
        private static readonly Selector sel_initWithDomaincodeuserInfo = "initWithDomain:code:userInfo:";
        private static readonly Selector sel_code = "code";
        private static readonly Selector sel_domain = "domain";
        private static readonly Selector sel_userInfo = "userInfo";
        private static readonly Selector sel_localizedDescription = "localizedDescription";
        private static readonly Selector sel_localizedRecoveryOptions = "localizedRecoveryOptions";
        private static readonly Selector sel_localizedRecoverySuggestion = "localizedRecoverySuggestion";
        private static readonly Selector sel_localizedFailureReason = "localizedFailureReason";
    }
}
