using System;
using System.Runtime.CompilerServices;

namespace Apple.Metal
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
}