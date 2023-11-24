using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.MetalFX
{
    
    public partial class MTLTemporalScalerDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(MTLTemporalScalerDescriptor obj) => obj.NativePtr;
        public MTLTemporalScalerDescriptor(IntPtr ptr) => NativePtr = ptr;

        public MTLTemporalScalerDescriptor()
        {
            var cls = new ObjectiveCClass("MTLTemporalScalerDescriptor");
            NativePtr = cls.AllocInit();
        }












    }

    
    public partial class MTLTemporalScaler
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(MTLTemporalScaler obj) => obj.NativePtr;
        public MTLTemporalScaler(IntPtr ptr) => NativePtr = ptr;

        protected MTLTemporalScaler()
        {
            throw new NotImplementedException();
        }





























    }
}
