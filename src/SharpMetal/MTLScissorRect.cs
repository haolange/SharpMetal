using System;

namespace Apple.Metal
{
    public struct MTLScissorRect
    {
        public UIntPtr x;
        public UIntPtr y;
        public UIntPtr width;
        public UIntPtr height;

        public MTLScissorRect(in uint x, in uint y, in uint width, in uint height)
        {
            this.x = (UIntPtr)x;
            this.y = (UIntPtr)y;
            this.width = (UIntPtr)width;
            this.height = (UIntPtr)height;
        }
    }
}