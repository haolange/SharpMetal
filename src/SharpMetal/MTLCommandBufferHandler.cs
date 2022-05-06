using System;
using System.Runtime.InteropServices;

namespace Apple.Metal
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MTLCommandBufferHandler(IntPtr block, MTLCommandBuffer buffer);
}