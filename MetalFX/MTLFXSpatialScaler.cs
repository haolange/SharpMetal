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

    public partial struct MTLSpatialScalerDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLSpatialScalerDescriptor obj) => obj.NativePtr;
        public MTLSpatialScalerDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public MTLSpatialScalerDescriptor()
        {
            var cls = new ObjectiveCClass("MTLSpatialScalerDescriptor");
            NativePtr = cls.AllocInit();
        }
    }

    public partial struct MTLSpatialScaler
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLSpatialScaler obj) => obj.NativePtr;
        public MTLSpatialScaler(in IntPtr ptr) => NativePtr = ptr;
    }
}
