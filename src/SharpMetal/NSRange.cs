using System;

namespace Apple.Metal
{
    public struct NSRange
    {
        public UIntPtr location;
        public UIntPtr length;

        public NSRange(in UIntPtr location, in UIntPtr length)
        {
            this.location = location;
            this.length = length;
        }

        public NSRange(in uint location, in uint length)
        {
            this.location = (UIntPtr)location;
            this.length = (UIntPtr)length;
        }
    }
}