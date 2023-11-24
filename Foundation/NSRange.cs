using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace SharpMetal.Foundation
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NSRange
    {
        public ulong location;
        public ulong length;
    }
}
