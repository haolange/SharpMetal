using System;

namespace Apple.Metal
{
    public struct MTLFunctionConstantValues
    {
        public readonly IntPtr NativePtr;

        public static MTLFunctionConstantValues New()
        {
            return s_class.AllocInit<MTLFunctionConstantValues>();
        }

        public unsafe void setConstantValuetypeatIndex(in void* value, in MTLDataType type, in UIntPtr index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setConstantValuetypeatIndex, value, (uint)type, index);
        }

        private static readonly ObjCClass s_class = new ObjCClass(nameof(MTLFunctionConstantValues));
        private static readonly Selector sel_setConstantValuetypeatIndex = "setConstantValue:type:atIndex:";
    }
}
