using System;
using SharpMetal.Metal;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Sample
{
    internal static class Program
    {
        private static unsafe int Main()
        {
            if (Marshal.SizeOf<MTLSize>() != 24)
            {
                throw new InvalidOperationException("MTLSize ABI mismatch.");
            }
            if (!OperatingSystem.IsMacOS() && !OperatingSystem.IsIOS() && !OperatingSystem.IsMacCatalyst())
            {
                Console.WriteLine("Managed ABI passed. Native Metal workload: BLOCKED_PLATFORM (Apple host required).");
                return 0;
            }
            MTLDevice device = default;
            MTLBuffer buffer = default;
            try
            {
            device = MTLDevice.CreateSystemDefaultDevice();
            if (device.NativePtr == IntPtr.Zero) { throw new InvalidOperationException("No Metal device."); }
            buffer = device.NewBuffer(4096, MTLResourceOptions.ResourceStorageModeShared);
            if (buffer.NativePtr == IntPtr.Zero || buffer.Contents == IntPtr.Zero)
            {
                throw new InvalidOperationException("Shared Metal buffer allocation failed.");
            }
            Span<int> values = new Span<int>((void*)buffer.Contents, 1024);
            for (int index = 0; index < values.Length; index++) { values[index] = index * 7; }
            for (int index = 0; index < values.Length; index++)
            {
                if (values[index] != index * 7) { throw new InvalidOperationException("Buffer readback mismatch."); }
            }
            Console.WriteLine("Metal device and shared-buffer read/write passed; native owners disposed.");
            return 0;
            }
            finally
            {
                if (buffer.NativePtr != IntPtr.Zero) { ObjectiveCRuntime.Release(buffer.NativePtr); }
                if (device.NativePtr != IntPtr.Zero) { ObjectiveCRuntime.Release(device.NativePtr); }
            }
        }
    }
}
