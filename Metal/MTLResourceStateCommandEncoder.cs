using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    public enum MTLSparseTextureMappingMode : ulong
    {
        Map = 0,
        Unmap = 1,
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLMapIndirectArguments
    {
        public uint regionOriginX;
        public uint regionOriginY;
        public uint regionOriginZ;
        public uint regionSizeWidth;
        public uint regionSizeHeight;
        public uint regionSizeDepth;
        public uint mipMapLevel;
        public uint sliceId;
    }
    
    public partial struct MTLResourceStateCommandEncoder
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLResourceStateCommandEncoder obj) => obj.NativePtr;
        public static implicit operator MTLCommandEncoder(in MTLResourceStateCommandEncoder obj) => new MTLCommandEncoder(obj.NativePtr);
        public static implicit operator MTLResourceStateCommandEncoder(in MTLCommandEncoder obj) => new MTLResourceStateCommandEncoder(obj.NativePtr);

        public MTLResourceStateCommandEncoder(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public void EndEncoding()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_endEncoding);
        }

        public void InsertDebugSignpost(in NSString nsString)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_insertDebugSignpost, nsString);
        }

        public void PushDebugGroup(in NSString nsString)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_pushDebugGroup, nsString);
        }

        public void PopDebugGroup()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_popDebugGroup);
        }

        public void UpdateTextureMappings(in MTLTexture texture, in MTLSparseTextureMappingMode mode, in MTLRegion regions, in ulong mipLevels, in ulong slices, in ulong numRegions)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_updateTextureMappingsmoderegionsmipLevelsslicesnumRegions, texture, (ulong)mode, regions, mipLevels, slices, numRegions);
        }

        public void UpdateTextureMapping(in MTLTexture texture, in MTLSparseTextureMappingMode mode, in MTLRegion region, in ulong mipLevel, in ulong slice)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_updateTextureMappingmoderegionmipLevelslice, texture, (ulong)mode, region, mipLevel, slice);
        }

        public void UpdateTextureMapping(in MTLTexture texture, in MTLSparseTextureMappingMode mode, in MTLBuffer indirectBuffer, in ulong indirectBufferOffset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_updateTextureMappingmodeindirectBufferindirectBufferOffset, texture, (ulong)mode, indirectBuffer, indirectBufferOffset);
        }

        public void UpdateFence(in MTLFence fence)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_updateFence, fence);
        }

        public void WaitForFence(in MTLFence fence)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_waitForFence, fence);
        }

        public void MoveTextureMappingsFromTexture(in MTLTexture sourceTexture, in ulong sourceSlice, in ulong sourceLevel, in MTLOrigin sourceOrigin, in MTLSize sourceSize, in MTLTexture destinationTexture, in ulong destinationSlice, in ulong destinationLevel, in MTLOrigin destinationOrigin)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_moveTextureMappingsFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoTexturedestinationSlicedestinationLeveldestinationOrigin, sourceTexture, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture, destinationSlice, destinationLevel, destinationOrigin);
        }

        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_endEncoding = "endEncoding";
        private static readonly Selector sel_insertDebugSignpost = "insertDebugSignpost:";
        private static readonly Selector sel_pushDebugGroup = "pushDebugGroup:";
        private static readonly Selector sel_popDebugGroup = "popDebugGroup";
        private static readonly Selector sel_updateTextureMappingsmoderegionsmipLevelsslicesnumRegions = "updateTextureMappings:mode:regions:mipLevels:slices:numRegions:";
        private static readonly Selector sel_updateTextureMappingmoderegionmipLevelslice = "updateTextureMapping:mode:region:mipLevel:slice:";
        private static readonly Selector sel_updateTextureMappingmodeindirectBufferindirectBufferOffset = "updateTextureMapping:mode:indirectBuffer:indirectBufferOffset:";
        private static readonly Selector sel_updateFence = "updateFence:";
        private static readonly Selector sel_waitForFence = "waitForFence:";
        private static readonly Selector sel_moveTextureMappingsFromTexturesourceSlicesourceLevelsourceOriginsourceSizetoTexturedestinationSlicedestinationLeveldestinationOrigin = "moveTextureMappingsFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:";
    }
}
