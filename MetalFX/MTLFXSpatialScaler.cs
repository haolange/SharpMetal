using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.MetalFX
{
    public enum MTLSpatialScalerColorProcessingMode : long
    {
        SpatialScalerColorProcessingModePerceptual = 0,
        SpatialScalerColorProcessingModeLinear = 1,
        SpatialScalerColorProcessingModeHDR = 2
    }

    public partial class MTLSpatialScalerDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(MTLSpatialScalerDescriptor obj) => obj.NativePtr;
        public MTLSpatialScalerDescriptor(IntPtr ptr) => NativePtr = ptr;

        public MTLSpatialScalerDescriptor()
        {
            var cls = new ObjectiveCClass("MTLSpatialScalerDescriptor");
            NativePtr = cls.AllocInit();
        }







    }

    
    public partial class MTLSpatialScaler
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(MTLSpatialScaler obj) => obj.NativePtr;
        public MTLSpatialScaler(IntPtr ptr) => NativePtr = ptr;

        protected MTLSpatialScaler()
        {
            throw new NotImplementedException();
        }














    }
}
