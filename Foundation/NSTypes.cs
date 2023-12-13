using System.Runtime.InteropServices;

namespace SharpMetal.Foundation
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NSOperatingSystemVersion
    {
        public long majorVersion;
        public long minorVersion;
        public long patchVersion;
    }
}
