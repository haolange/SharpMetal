using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLResourceViewPoolDescriptor
    {
        public IntPtr NativePtr;

        public MTLResourceViewPoolDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLResourceViewPoolDescriptor New() => s_class.AllocInit<MTLResourceViewPoolDescriptor>();

        public ulong ResourceViewCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resourceViewCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResourceViewCount, value);
        }

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public static implicit operator IntPtr(in MTLResourceViewPoolDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLResourceViewPoolDescriptor));
        private static readonly Selector sel_resourceViewCount = "resourceViewCount";
        private static readonly Selector sel_setResourceViewCount = "setResourceViewCount:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
    }
}
