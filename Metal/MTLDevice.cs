using System;
using System.Runtime.InteropServices;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public unsafe struct MTLDevice
    {
        public MTLSize maxThreadsPerThreadgroup
        {
            get
            {
                if (UseStret<MTLSize>())
                {
                    return objc_msgSend_stret<MTLSize>(this, sel_maxThreadsPerThreadgroup);
                }
                else
                {
                    return MTLSize_objc_msgSend(this, sel_maxThreadsPerThreadgroup);
                }
            }
        }
        public uint maxThreadgroupMemoryLength => (uint)UIntPtr_objc_msgSend(NativePtr, sel_maxThreadgroupMemoryLength);
        public Bool8 supportsRaytracing => bool8_objc_msgSend(NativePtr, sel_supportsRaytracing);
        public Bool8 supportsPrimitiveMotionBlur => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 supportsRaytracingFromRender => bool8_objc_msgSend(NativePtr, sel_supportsRaytracingFromRender);
        public Bool8 supports32BitMSAA => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 supportsPullModelInterpolation => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 supportsShaderBarycentricCoordinates => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 supportsVertexAmplificationCount => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 programmableSamplePositionsSupported => bool8_objc_msgSend(NativePtr, sel_areProgrammableSamplePositionsSupported);
        public Bool8 rasterOrderGroupsSupported => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 supports32BitFloatFiltering => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 supportsBCTextureCompression => bool8_objc_msgSend(NativePtr, sel_supportsBCTextureCompression);
        public Bool8 depth24Stencil8PixelFormatSupported => bool8_objc_msgSend(NativePtr, sel_depth24Stencil8PixelFormatSupported);
        public Bool8 supportsQueryTextureLOD => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 readWriteTextureSupport => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 supportsFunctionPointers => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 supportsFunctionPointersFromRender => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 currentAllocatedSize => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 recommendedMaxWorkingSetSize => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 hasUnifiedMemory => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 maxTransferRate => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 counterSets => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 supportsCounterSampling => bool8_objc_msgSend(NativePtr, sel_);
        public string name => string_objc_msgSend(NativePtr, sel_name);
        public ulong registryID => bool8_objc_msgSend(NativePtr, sel_);
        public ulong location => bool8_objc_msgSend(NativePtr, sel_);
        public ulong locationNumber => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 lowPower => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 removable => bool8_objc_msgSend(NativePtr, sel_);
        public Bool8 headless => bool8_objc_msgSend(NativePtr, sel_);
        public ulong peerGroupID => bool8_objc_msgSend(NativePtr, sel_);
        public ulong peerCount => bool8_objc_msgSend(NativePtr, sel_);
        public ulong peerIndex => bool8_objc_msgSend(NativePtr, sel_);

        public readonly IntPtr NativePtr;

        public MTLDevice(in IntPtr nativePtr) => NativePtr = nativePtr;

        public Bool8 supportsFamily(in MTLGPUFamily gpuFamily)
        {
            return bool8_objc_msgSend(NativePtr, sel_supportsFamily, (uint)gpuFamily);
        }

        public Bool8 supportsTextureSampleCount(in uint sampleCount)
        {
            return bool8_objc_msgSend(NativePtr, sel_supportsTextureSampleCount, sampleCount);
        }

        public MTLLibrary newLibraryWithData(in DispatchData data)
        {
            IntPtr library = IntPtr_objc_msgSend(NativePtr, sel_newLibraryWithData, data.NativePtr, out NSError error);

            if (library == IntPtr.Zero)
            {
                throw new Exception("Unable to load Metal library: " + error.localizedDescription);
            }

            return new MTLLibrary(library);
        }

        public MTLLibrary newLibraryWithSource(string source, in MTLCompileOptions options)
        {
            NSString sourceNSS = NSString.New(source);

            IntPtr library = IntPtr_objc_msgSend(NativePtr, sel_newLibraryWithSource, sourceNSS, options, out NSError error);

            release(sourceNSS.NativePtr);

            if (library == IntPtr.Zero)
            {
                throw new Exception("Shader compilation failed: " + error.localizedDescription);
            }

            return new MTLLibrary(library);
        }

        public MTLRenderPipelineState newRenderPipelineStateWithDescriptor(in MTLRenderPipelineDescriptor desc)
        {
            IntPtr ret = IntPtr_objc_msgSend(NativePtr, sel_newRenderPipelineStateWithDescriptor, desc.NativePtr, out NSError error);

            if (error.NativePtr != IntPtr.Zero)
            {
                throw new Exception("Failed to create new MTLRenderPipelineState: " + error.localizedDescription);
            }

            return new MTLRenderPipelineState(ret);
        }

        public MTLComputePipelineState newComputePipelineStateWithDescriptor(in MTLComputePipelineDescriptor descriptor)
        {
            IntPtr ret = IntPtr_objc_msgSend(NativePtr, sel_newComputePipelineStateWithDescriptor, descriptor, 0, IntPtr.Zero, out NSError error);

            if (error.NativePtr != IntPtr.Zero)
            {
                throw new Exception("Failed to create new MTLRenderPipelineState: " + error.localizedDescription);
            }

            return new MTLComputePipelineState(ret);
        }

        public MTLCommandQueue newCommandQueue()
        {
            return objc_msgSend<MTLCommandQueue>(NativePtr, sel_newCommandQueue);
        }

        public MTLBuffer newBuffer(in void* pointer, in UIntPtr length, in MTLResourceOptions options)
        {
            IntPtr buffer = IntPtr_objc_msgSend(NativePtr, sel_newBufferWithBytes,
                pointer,
                length,
                options);
            return new MTLBuffer(buffer);
        }

        public MTLBuffer newBufferWithLengthOptions(in UIntPtr length, in MTLResourceOptions options)
        {
            IntPtr buffer = IntPtr_objc_msgSend(NativePtr, sel_newBufferWithLength, length, options);
            return new MTLBuffer(buffer);
        }

        public MTLTexture newTextureWithDescriptor(in MTLTextureDescriptor descriptor)
        {
            return objc_msgSend<MTLTexture>(NativePtr, sel_newTextureWithDescriptor, descriptor.NativePtr);
        }

        public MTLSamplerState newSamplerStateWithDescriptor(in MTLSamplerDescriptor descriptor)
        {
            return objc_msgSend<MTLSamplerState>(NativePtr, sel_newSamplerStateWithDescriptor, descriptor.NativePtr);
        }

        public MTLDepthStencilState newDepthStencilStateWithDescriptor(in MTLDepthStencilDescriptor descriptor)
        {
            return objc_msgSend<MTLDepthStencilState>(NativePtr, sel_newDepthStencilStateWithDescriptor, descriptor.NativePtr);
        }

        [DllImport("/System/Library/Frameworks/Metal.framework/Metal")]
        public static extern NSArray MTLCopyAllDevices();

        [DllImport("/System/Library/Frameworks/Metal.framework/Metal")]
        public static extern MTLDevice MTLCreateSystemDefaultDevice();

        public static implicit operator IntPtr(in MTLDevice device) => device.NativePtr;

        private static readonly Selector sel_supportsFamily = "supportsFamily:";
        private static readonly Selector sel_maxThreadsPerThreadgroup = "maxThreadsPerThreadgroup";
        private static readonly Selector sel_maxThreadgroupMemoryLength = "maxThreadgroupMemoryLength";
        private static readonly Selector sel_supportsRaytracing = "supportsRaytracing";
        private static readonly Selector sel_supportsRaytracingFromRender = "supportsRaytracingFromRender";
        private static readonly Selector sel_areProgrammableSamplePositionsSupported = "areProgrammableSamplePositionsSupported";
        private static readonly Selector sel_supportsBCTextureCompression = "supportsBCTextureCompression";
        private static readonly Selector sel_depth24Stencil8PixelFormatSupported = "isDepth24Stencil8PixelFormatSupported";

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_supportsTextureSampleCount = "supportsTextureSampleCount:";
        private static readonly Selector sel_newLibraryWithData = "newLibraryWithData:error:";
        private static readonly Selector sel_newLibraryWithSource = "newLibraryWithSource:options:error:";
        private static readonly Selector sel_newRenderPipelineStateWithDescriptor = "newRenderPipelineStateWithDescriptor:error:";
        private static readonly Selector sel_newComputePipelineStateWithDescriptor = "newComputePipelineStateWithDescriptor:options:reflection:error:";
        private static readonly Selector sel_newCommandQueue = "newCommandQueue";
        private static readonly Selector sel_newBufferWithBytes = "newBufferWithBytes:length:options:";
        private static readonly Selector sel_newBufferWithLength = "newBufferWithLength:options:";
        private static readonly Selector sel_newTextureWithDescriptor = "newTextureWithDescriptor:";
        private static readonly Selector sel_newSamplerStateWithDescriptor = "newSamplerStateWithDescriptor:";
        private static readonly Selector sel_newDepthStencilStateWithDescriptor = "newDepthStencilStateWithDescriptor:";
    }
}