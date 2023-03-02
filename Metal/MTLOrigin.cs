using System;

namespace Apple.Metal
{
    public struct MTLOrigin
    {
        public UIntPtr x;
        public UIntPtr y;
        public UIntPtr z;

        public MTLOrigin(in uint x, in uint y, in uint z)
        {
            this.x = (UIntPtr)x;
            this.y = (UIntPtr)y;
            this.z = (UIntPtr)z;
        }
    }
}