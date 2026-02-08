using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTL4BufferRange
    {
        public ulong BufferAddress;
        public ulong Length;

        public MTL4BufferRange(in ulong bufferAddress, in ulong length)
        {
            BufferAddress = bufferAddress;
            Length = length;
        }

        public static MTL4BufferRange Make(in ulong bufferAddress, in ulong length)
        {
            return new MTL4BufferRange(bufferAddress, length);
        }
    }
}
