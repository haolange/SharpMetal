using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.MetalFX
{
    
    public partial struct MTLTemporalScalerDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLTemporalScalerDescriptor obj) => obj.NativePtr;
        public MTLTemporalScalerDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public MTLTemporalScalerDescriptor()
        {
            var cls = new ObjectiveCClass("MTLTemporalScalerDescriptor");
            NativePtr = cls.AllocInit();
        }
    }

    public partial struct MTLTemporalScaler
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLTemporalScaler obj) => obj.NativePtr;
        public MTLTemporalScaler(in IntPtr ptr) => NativePtr = ptr;
    }
}
