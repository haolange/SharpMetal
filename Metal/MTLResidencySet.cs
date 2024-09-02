using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLAllocation : ulong
    {

    }

    public partial struct MTLResidencySetDescriptor
    {
        public IntPtr NativePtr;

        public MTLResidencySetDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLResidencySetDescriptor New() => s_class.AllocInit<MTLResidencySetDescriptor>();

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public static implicit operator IntPtr(in MTLResidencySetDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLResidencySetDescriptor));
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
    }

    public partial struct MTLResidencySet
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLResidencySet obj) => obj.NativePtr;
        public MTLResidencySet(in IntPtr ptr) => NativePtr = ptr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));


        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_device = "device";
    }
}
