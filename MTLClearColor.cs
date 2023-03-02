using System.Runtime.InteropServices;

namespace Apple.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLClearColor
    {
        public double red;
        public double green;
        public double blue;
        public double alpha;

        public MTLClearColor(in double r, in double g, in double b, in double a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }
    }
}