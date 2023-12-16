using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    public struct CGSize
    {
        public double width;
        public double height;

        public CGSize(in double width, in double height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString() => string.Format("{0} x {1}", width, height);
    }

    public struct CGPoint
    {
        public double x;
        public double y;

        public CGPoint(in double x, in double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => string.Format("{0} x {1}", x, y);
    }

    public struct CGRect
    {
        public CGPoint origin;
        public CGSize size;

        public CGRect(in CGPoint origin, in CGSize size)
        {
            this.origin = origin;
            this.size = size;
        }

        public override string ToString() => string.Format("{0} x {1}", origin, size);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLOrigin
    {
        public ulong x;
        public ulong y;
        public ulong z;

        public MTLOrigin(in ulong x, in ulong y, in ulong z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString() => string.Format("({0},{1},{2})", x, y, z);
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLSize
    {
        public ulong width;
        public ulong height;
        public ulong depth;

        public MTLSize(in ulong width, in ulong height, in ulong depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        public override string ToString() => string.Format("{0} x {1} x {2}", width, height, depth);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLRegion
    {
        public MTLOrigin origin;
        public MTLSize size;

        public MTLRegion(in MTLOrigin origin, in MTLSize size)
        {
            this.origin = origin;
            this.size = size;
        }

        public override string ToString() => string.Format("{0}, {1}", origin, size);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLSamplePosition
    {
        public float x;
        public float y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLResourceID
    {
        public ulong _impl;
    }
}
