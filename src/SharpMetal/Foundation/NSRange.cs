using System.Runtime.InteropServices;

namespace SharpMetal.Foundation
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NSRange
    {
        public ulong location;
        public ulong length;
    }
}
