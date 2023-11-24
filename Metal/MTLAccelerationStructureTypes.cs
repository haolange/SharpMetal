using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using SharpMetal.Foundation;

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
}
