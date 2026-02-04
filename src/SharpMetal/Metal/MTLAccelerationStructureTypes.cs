using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLPackedFloat3
    {
        public float x;
        public float y;
        public float z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLPackedFloat4x3
    {
        public MTLPackedFloat3 columns;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLAxisAlignedBoundingBox
    {
        public MTLPackedFloat3 min;
        public MTLPackedFloat3 max;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLPackedFloatQuaternion
    {
        public float x;
        public float y;
        public float z;
        public float w;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLComponentTransform
    {
        public MTLPackedFloat3 Scale;
        public MTLPackedFloat3 Shear;
        public MTLPackedFloat3 Pivot;
        public MTLPackedFloatQuaternion Rotation;
        public MTLPackedFloat3 Translation;
    }
}
