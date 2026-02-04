using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLFunctionConstantValues
    {
        public IntPtr NativePtr;

        public MTLFunctionConstantValues(in IntPtr ptr) => NativePtr = ptr;

        public static MTLFunctionConstantValues New() => s_class.AllocInit<MTLFunctionConstantValues>();

        public void SetConstantValue(in IntPtr value, in MTLDataType type, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setConstantValuetypeatIndex, value, (ulong)type, index);
        }

        public void SetConstantValues(in IntPtr values, in MTLDataType type, in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setConstantValuestypewithRange, values, (ulong)type, range);
        }

        public void SetConstantValue(in IntPtr value, in MTLDataType type, in NSString name)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setConstantValuetypewithName, value, (ulong)type, name);
        }

        public void Reset()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_reset);
        }

        public static implicit operator IntPtr(in MTLFunctionConstantValues obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLFunctionConstantValues));
        private static readonly Selector sel_setConstantValuetypeatIndex = "setConstantValue:type:atIndex:";
        private static readonly Selector sel_setConstantValuestypewithRange = "setConstantValues:type:withRange:";
        private static readonly Selector sel_setConstantValuetypewithName = "setConstantValue:type:withName:";
        private static readonly Selector sel_reset = "reset";
    }
}
