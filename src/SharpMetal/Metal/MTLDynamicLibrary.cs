using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLDynamicLibraryError : ulong
    {
        None = 0,
        InvalidFile = 1,
        CompilationFailure = 2,
        UnresolvedInstallName = 3,
        DependencyLoadFailure = 4,
        Unsupported = 5,
    }

    public partial struct MTLDynamicLibrary
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLDynamicLibrary obj) => obj.NativePtr;
        public MTLDynamicLibrary(in IntPtr ptr) => NativePtr = ptr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString InstallName => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_installName));

        public bool SerializeToURL(in NSURL url, ref NSError error)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_serializeToURLerror, url, ref error.NativePtr);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_installName = "installName";
        private static readonly Selector sel_serializeToURLerror = "serializeToURL:error:";
    }
}
