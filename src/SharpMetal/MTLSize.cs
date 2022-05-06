using System;
using System.Runtime.InteropServices;

namespace Apple.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLSize
    {
        public UIntPtr Width;
        public UIntPtr Height;
        public UIntPtr Depth;

        public MTLSize(in uint width, in uint height, in uint depth)
        {
            Width = (UIntPtr)width;
            Height = (UIntPtr)height;
            Depth = (UIntPtr)depth;
        }
    }
}