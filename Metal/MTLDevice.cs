using System;
using System.Runtime.InteropServices;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    public unsafe struct MTLDevice
    {
        public readonly IntPtr NativePtr;

        public string name => string_objc_msgSend(NativePtr, sel_name);
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
        public Bool8 isDepth24Stencil8PixelFormatSupported => bool8_objc_msgSend(NativePtr, sel_isDepth24Stencil8PixelFormatSupported);

        public MTLDevice(in IntPtr nativePtr)
        {
            NativePtr = nativePtr;
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

            IntPtr library = IntPtr_objc_msgSend(NativePtr, sel_newLibraryWithSource,
                sourceNSS,
                options,
                out NSError error);

            release(sourceNSS.NativePtr);

            if (library == IntPtr.Zero)
            {
                throw new Exception("Shader compilation failed: " + error.localizedDescription);
            }

            return new MTLLibrary(library);
        }

        public MTLRenderPipelineState newRenderPipelineStateWithDescriptor(in MTLRenderPipelineDescriptor desc)
        {
            IntPtr ret = IntPtr_objc_msgSend(NativePtr, sel_newRenderPipelineStateWithDescriptor,
                desc.NativePtr,
                out NSError error);

            if (error.NativePtr != IntPtr.Zero)
            {
                throw new Exception("Failed to create new MTLRenderPipelineState: " + error.localizedDescription);
            }

            return new MTLRenderPipelineState(ret);
        }

        public MTLComputePipelineState newComputePipelineStateWithDescriptor(in MTLComputePipelineDescriptor descriptor)
        {
            IntPtr ret = IntPtr_objc_msgSend(NativePtr, sel_newComputePipelineStateWithDescriptor,
                descriptor,
                0,
                IntPtr.Zero,
                out NSError error);

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
            IntPtr buffer = IntPtr_objc_msgSend(NativePtr, sel_newBufferWithBytes, pointer, length, options);
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

        public Bool8 supportsFeatureSet(in MTLFeatureSet featureSet)
        {
            return bool8_objc_msgSend(NativePtr, sel_supportsFeatureSet, (uint)featureSet);
        }

        public Bool8 supportsTextureSampleCount(in UIntPtr sampleCount)
        {
            return bool8_objc_msgSend(NativePtr, sel_supportsTextureSampleCount, sampleCount);
        }

        public static implicit operator IntPtr(in MTLDevice device) => device.NativePtr;

        private const string GMetalFrameworkName = "/System/Library/Frameworks/Metal.framework/Metal";

        [DllImport(GMetalFrameworkName)]
        public static extern NSArray MTLCopyAllDevices();

        [DllImport(GMetalFrameworkName)]
        public static extern MTLDevice MTLCreateSystemDefaultDevice();

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_maxThreadsPerThreadgroup = "maxThreadsPerThreadgroup";
        private static readonly Selector sel_newLibraryWithSource = "newLibraryWithSource:options:error:";
        private static readonly Selector sel_newLibraryWithData = "newLibraryWithData:error:";
        private static readonly Selector sel_newRenderPipelineStateWithDescriptor = "newRenderPipelineStateWithDescriptor:error:";
        private static readonly Selector sel_newComputePipelineStateWithDescriptor = "newComputePipelineStateWithDescriptor:options:reflection:error:";
        private static readonly Selector sel_newCommandQueue = "newCommandQueue";
        private static readonly Selector sel_newBufferWithBytes = "newBufferWithBytes:length:options:";
        private static readonly Selector sel_newBufferWithLength = "newBufferWithLength:options:";
        private static readonly Selector sel_newTextureWithDescriptor = "newTextureWithDescriptor:";
        private static readonly Selector sel_newSamplerStateWithDescriptor = "newSamplerStateWithDescriptor:";
        private static readonly Selector sel_newDepthStencilStateWithDescriptor = "newDepthStencilStateWithDescriptor:";
        private static readonly Selector sel_supportsTextureSampleCount = "supportsTextureSampleCount:";
        private static readonly Selector sel_supportsFeatureSet = "supportsFeatureSet:";
        private static readonly Selector sel_isDepth24Stencil8PixelFormatSupported = "isDepth24Stencil8PixelFormatSupported";
    }
}