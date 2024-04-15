using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    public enum MTLAccelerationStructureUsage : ulong
    {
        None = 0,
        Refit = 1,
        PreferFastBuild = 2,
        ExtendedLimits = 4,
    }
    
    public enum MTLAccelerationStructureInstanceOptions : uint
    {
        None = 0,
        DisableTriangleCulling = 1,
        TriangleFrontFacingWindingCounterClockwise = 2,
        Opaque = 4,
        NonOpaque = 8,
    }

    public enum MTLMotionBorderMode : uint
    {
        Clamp = 0,
        Vanish = 1,
    }

    public enum MTLCurveType : long
    {
        Round = 0,
        Flat = 1,
    }

    public enum MTLCurveBasis : long
    {
        BSpline = 0,
        CatmullRom = 1,
        Linear = 2,
        Bezier = 3,
    }

    public enum MTLCurveEndCaps : long
    {
        None = 0,
        Disk = 1,
        Sphere = 2,
    }

    public enum MTLAccelerationStructureInstanceDescriptorType : ulong
    {
        Default = 0,
        UserID = 1,
        Motion = 2,
        Indirect = 3,
        IndirectMotion = 4,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLAccelerationStructureInstanceDescriptor
    {
        public MTLPackedFloat4x3 transformationMatrix;
        public MTLAccelerationStructureInstanceOptions options;
        public uint mask;
        public uint intersectionFunctionTableOffset;
        public uint accelerationStructureIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLAccelerationStructureUserIDInstanceDescriptor
    {
        public MTLPackedFloat4x3 transformationMatrix;
        public MTLAccelerationStructureInstanceOptions options;
        public uint mask;
        public uint intersectionFunctionTableOffset;
        public uint accelerationStructureIndex;
        public uint userID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLAccelerationStructureMotionInstanceDescriptor
    {
        public MTLAccelerationStructureInstanceOptions options;
        public uint mask;
        public uint intersectionFunctionTableOffset;
        public uint accelerationStructureIndex;
        public uint userID;
        public uint motionTransformsStartIndex;
        public uint motionTransformsCount;
        public MTLMotionBorderMode motionStartBorderMode;
        public MTLMotionBorderMode motionEndBorderMode;
        public float motionStartTime;
        public float motionEndTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLIndirectAccelerationStructureInstanceDescriptor
    {
        public MTLPackedFloat4x3 transformationMatrix;
        public MTLAccelerationStructureInstanceOptions options;
        public uint mask;
        public uint intersectionFunctionTableOffset;
        public uint userID;
        public MTLResourceID accelerationStructureID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MTLIndirectAccelerationStructureMotionInstanceDescriptor
    {
        public MTLAccelerationStructureInstanceOptions options;
        public uint mask;
        public uint intersectionFunctionTableOffset;
        public uint userID;
        public MTLResourceID accelerationStructureID;
        public uint motionTransformsStartIndex;
        public uint motionTransformsCount;
        public MTLMotionBorderMode motionStartBorderMode;
        public MTLMotionBorderMode motionEndBorderMode;
        public float motionStartTime;
        public float motionEndTime;
    }

    public partial struct MTLAccelerationStructureGeometryDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLAccelerationStructureGeometryDescriptor obj) => obj.NativePtr;
        public MTLAccelerationStructureGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructureGeometryDescriptor New() => s_class.AllocInit<MTLAccelerationStructureGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructureGeometryDescriptor));

        public ulong IntersectionFunctionTableOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_intersectionFunctionTableOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIntersectionFunctionTableOffset, value);
        }

        public bool Opaque
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_opaque);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaque, value);
        }

        public bool AllowDuplicateIntersectionFunctionInvocation
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_allowDuplicateIntersectionFunctionInvocation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAllowDuplicateIntersectionFunctionInvocation, value);
        }

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLBuffer PrimitiveDataBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_primitiveDataBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBuffer, value);
        }

        public ulong PrimitiveDataBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBufferOffset, value);
        }

        public ulong PrimitiveDataStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataStride, value);
        }

        public ulong PrimitiveDataElementSize
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataElementSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataElementSize, value);
        }

        private static readonly Selector sel_intersectionFunctionTableOffset = "intersectionFunctionTableOffset";
        private static readonly Selector sel_setIntersectionFunctionTableOffset = "setIntersectionFunctionTableOffset:";
        private static readonly Selector sel_opaque = "opaque";
        private static readonly Selector sel_setOpaque = "setOpaque:";
        private static readonly Selector sel_allowDuplicateIntersectionFunctionInvocation = "allowDuplicateIntersectionFunctionInvocation";
        private static readonly Selector sel_setAllowDuplicateIntersectionFunctionInvocation = "setAllowDuplicateIntersectionFunctionInvocation:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_primitiveDataBuffer = "primitiveDataBuffer";
        private static readonly Selector sel_setPrimitiveDataBuffer = "setPrimitiveDataBuffer:";
        private static readonly Selector sel_primitiveDataBufferOffset = "primitiveDataBufferOffset";
        private static readonly Selector sel_setPrimitiveDataBufferOffset = "setPrimitiveDataBufferOffset:";
        private static readonly Selector sel_primitiveDataStride = "primitiveDataStride";
        private static readonly Selector sel_setPrimitiveDataStride = "setPrimitiveDataStride:";
        private static readonly Selector sel_primitiveDataElementSize = "primitiveDataElementSize";
        private static readonly Selector sel_setPrimitiveDataElementSize = "setPrimitiveDataElementSize:";
    }

    public partial struct MTLMotionKeyframeData
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLMotionKeyframeData obj) => obj.NativePtr;
        public MTLMotionKeyframeData(in IntPtr ptr) => NativePtr = ptr;

        public static MTLMotionKeyframeData New() => s_class.AllocInit<MTLMotionKeyframeData>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLMotionKeyframeData));

        public MTLBuffer Buffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_buffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBuffer, value);
        }

        public ulong Offset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_offset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOffset, value);
        }

        private static readonly Selector sel_buffer = "buffer";
        private static readonly Selector sel_setBuffer = "setBuffer:";
        private static readonly Selector sel_offset = "offset";
        private static readonly Selector sel_setOffset = "setOffset:";
        private static readonly Selector sel_data = "data";
    }

    public partial struct MTLAccelerationStructureTriangleGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLAccelerationStructureTriangleGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLAccelerationStructureGeometryDescriptor(in MTLAccelerationStructureTriangleGeometryDescriptor obj) => new MTLAccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTLAccelerationStructureTriangleGeometryDescriptor(in MTLAccelerationStructureGeometryDescriptor obj) => new MTLAccelerationStructureTriangleGeometryDescriptor(obj.NativePtr);

        public MTLAccelerationStructureTriangleGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructureTriangleGeometryDescriptor New() => s_class.AllocInit<MTLAccelerationStructureTriangleGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructureTriangleGeometryDescriptor));

        public ulong IntersectionFunctionTableOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_intersectionFunctionTableOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIntersectionFunctionTableOffset, value);
        }

        public bool Opaque
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_opaque);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaque, value);
        }

        public bool AllowDuplicateIntersectionFunctionInvocation
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_allowDuplicateIntersectionFunctionInvocation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAllowDuplicateIntersectionFunctionInvocation, value);
        }

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLBuffer PrimitiveDataBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_primitiveDataBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBuffer, value);
        }

        public ulong PrimitiveDataBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBufferOffset, value);
        }

        public ulong PrimitiveDataStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataStride, value);
        }

        public ulong PrimitiveDataElementSize
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataElementSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataElementSize, value);
        }

        public MTLBuffer VertexBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_vertexBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexBuffer, value);
        }

        public ulong VertexBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_vertexBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexBufferOffset, value);
        }

        public MTLAttributeFormat VertexFormat
        {
            get => (MTLAttributeFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_vertexFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexFormat, (ulong)value);
        }

        public ulong VertexStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_vertexStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexStride, value);
        }

        public MTLBuffer IndexBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_indexBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBuffer, value);
        }

        public ulong IndexBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBufferOffset, value);
        }

        public MTLIndexType IndexType
        {
            get => (MTLIndexType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexType, (ulong)value);
        }

        public ulong TriangleCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_triangleCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTriangleCount, value);
        }

        public MTLBuffer TransformationMatrixBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_transformationMatrixBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTransformationMatrixBuffer, value);
        }

        public ulong TransformationMatrixBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_transformationMatrixBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTransformationMatrixBufferOffset, value);
        }

        private static readonly Selector sel_intersectionFunctionTableOffset = "intersectionFunctionTableOffset";
        private static readonly Selector sel_setIntersectionFunctionTableOffset = "setIntersectionFunctionTableOffset:";
        private static readonly Selector sel_opaque = "opaque";
        private static readonly Selector sel_setOpaque = "setOpaque:";
        private static readonly Selector sel_allowDuplicateIntersectionFunctionInvocation = "allowDuplicateIntersectionFunctionInvocation";
        private static readonly Selector sel_setAllowDuplicateIntersectionFunctionInvocation = "setAllowDuplicateIntersectionFunctionInvocation:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_primitiveDataBuffer = "primitiveDataBuffer";
        private static readonly Selector sel_setPrimitiveDataBuffer = "setPrimitiveDataBuffer:";
        private static readonly Selector sel_primitiveDataBufferOffset = "primitiveDataBufferOffset";
        private static readonly Selector sel_setPrimitiveDataBufferOffset = "setPrimitiveDataBufferOffset:";
        private static readonly Selector sel_primitiveDataStride = "primitiveDataStride";
        private static readonly Selector sel_setPrimitiveDataStride = "setPrimitiveDataStride:";
        private static readonly Selector sel_primitiveDataElementSize = "primitiveDataElementSize";
        private static readonly Selector sel_setPrimitiveDataElementSize = "setPrimitiveDataElementSize:";
        private static readonly Selector sel_vertexBuffer = "vertexBuffer";
        private static readonly Selector sel_setVertexBuffer = "setVertexBuffer:";
        private static readonly Selector sel_vertexBufferOffset = "vertexBufferOffset";
        private static readonly Selector sel_setVertexBufferOffset = "setVertexBufferOffset:";
        private static readonly Selector sel_vertexFormat = "vertexFormat";
        private static readonly Selector sel_setVertexFormat = "setVertexFormat:";
        private static readonly Selector sel_vertexStride = "vertexStride";
        private static readonly Selector sel_setVertexStride = "setVertexStride:";
        private static readonly Selector sel_indexBuffer = "indexBuffer";
        private static readonly Selector sel_setIndexBuffer = "setIndexBuffer:";
        private static readonly Selector sel_indexBufferOffset = "indexBufferOffset";
        private static readonly Selector sel_setIndexBufferOffset = "setIndexBufferOffset:";
        private static readonly Selector sel_indexType = "indexType";
        private static readonly Selector sel_setIndexType = "setIndexType:";
        private static readonly Selector sel_triangleCount = "triangleCount";
        private static readonly Selector sel_setTriangleCount = "setTriangleCount:";
        private static readonly Selector sel_transformationMatrixBuffer = "transformationMatrixBuffer";
        private static readonly Selector sel_setTransformationMatrixBuffer = "setTransformationMatrixBuffer:";
        private static readonly Selector sel_transformationMatrixBufferOffset = "transformationMatrixBufferOffset";
        private static readonly Selector sel_setTransformationMatrixBufferOffset = "setTransformationMatrixBufferOffset:";
        private static readonly Selector sel_descriptor = "descriptor";
    }

    public partial struct MTLAccelerationStructureBoundingBoxGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLAccelerationStructureBoundingBoxGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLAccelerationStructureGeometryDescriptor(in MTLAccelerationStructureBoundingBoxGeometryDescriptor obj) => new MTLAccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTLAccelerationStructureBoundingBoxGeometryDescriptor(in MTLAccelerationStructureGeometryDescriptor obj) => new MTLAccelerationStructureBoundingBoxGeometryDescriptor(obj.NativePtr);

        public MTLAccelerationStructureBoundingBoxGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructureBoundingBoxGeometryDescriptor New() => s_class.AllocInit<MTLAccelerationStructureBoundingBoxGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructureBoundingBoxGeometryDescriptor));

        public ulong IntersectionFunctionTableOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_intersectionFunctionTableOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIntersectionFunctionTableOffset, value);
        }

        public bool Opaque
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_opaque);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaque, value);
        }

        public bool AllowDuplicateIntersectionFunctionInvocation
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_allowDuplicateIntersectionFunctionInvocation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAllowDuplicateIntersectionFunctionInvocation, value);
        }

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLBuffer PrimitiveDataBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_primitiveDataBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBuffer, value);
        }

        public ulong PrimitiveDataBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBufferOffset, value);
        }

        public ulong PrimitiveDataStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataStride, value);
        }

        public ulong PrimitiveDataElementSize
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataElementSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataElementSize, value);
        }

        public MTLBuffer BoundingBoxBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_boundingBoxBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBoundingBoxBuffer, value);
        }

        public ulong BoundingBoxBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_boundingBoxBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBoundingBoxBufferOffset, value);
        }

        public ulong BoundingBoxStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_boundingBoxStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBoundingBoxStride, value);
        }

        public ulong BoundingBoxCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_boundingBoxCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBoundingBoxCount, value);
        }

        private static readonly Selector sel_intersectionFunctionTableOffset = "intersectionFunctionTableOffset";
        private static readonly Selector sel_setIntersectionFunctionTableOffset = "setIntersectionFunctionTableOffset:";
        private static readonly Selector sel_opaque = "opaque";
        private static readonly Selector sel_setOpaque = "setOpaque:";
        private static readonly Selector sel_allowDuplicateIntersectionFunctionInvocation = "allowDuplicateIntersectionFunctionInvocation";
        private static readonly Selector sel_setAllowDuplicateIntersectionFunctionInvocation = "setAllowDuplicateIntersectionFunctionInvocation:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_primitiveDataBuffer = "primitiveDataBuffer";
        private static readonly Selector sel_setPrimitiveDataBuffer = "setPrimitiveDataBuffer:";
        private static readonly Selector sel_primitiveDataBufferOffset = "primitiveDataBufferOffset";
        private static readonly Selector sel_setPrimitiveDataBufferOffset = "setPrimitiveDataBufferOffset:";
        private static readonly Selector sel_primitiveDataStride = "primitiveDataStride";
        private static readonly Selector sel_setPrimitiveDataStride = "setPrimitiveDataStride:";
        private static readonly Selector sel_primitiveDataElementSize = "primitiveDataElementSize";
        private static readonly Selector sel_setPrimitiveDataElementSize = "setPrimitiveDataElementSize:";
        private static readonly Selector sel_boundingBoxBuffer = "boundingBoxBuffer";
        private static readonly Selector sel_setBoundingBoxBuffer = "setBoundingBoxBuffer:";
        private static readonly Selector sel_boundingBoxBufferOffset = "boundingBoxBufferOffset";
        private static readonly Selector sel_setBoundingBoxBufferOffset = "setBoundingBoxBufferOffset:";
        private static readonly Selector sel_boundingBoxStride = "boundingBoxStride";
        private static readonly Selector sel_setBoundingBoxStride = "setBoundingBoxStride:";
        private static readonly Selector sel_boundingBoxCount = "boundingBoxCount";
        private static readonly Selector sel_setBoundingBoxCount = "setBoundingBoxCount:";
        private static readonly Selector sel_descriptor = "descriptor";
    }

    public partial struct MTLAccelerationStructureMotionTriangleGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLAccelerationStructureMotionTriangleGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLAccelerationStructureGeometryDescriptor(in MTLAccelerationStructureMotionTriangleGeometryDescriptor obj) => new MTLAccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTLAccelerationStructureMotionTriangleGeometryDescriptor(in MTLAccelerationStructureGeometryDescriptor obj) => new MTLAccelerationStructureMotionTriangleGeometryDescriptor(obj.NativePtr);

        public MTLAccelerationStructureMotionTriangleGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructureMotionTriangleGeometryDescriptor New() => s_class.AllocInit<MTLAccelerationStructureMotionTriangleGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructureMotionTriangleGeometryDescriptor));

        public ulong IntersectionFunctionTableOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_intersectionFunctionTableOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIntersectionFunctionTableOffset, value);
        }

        public bool Opaque
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_opaque);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaque, value);
        }

        public bool AllowDuplicateIntersectionFunctionInvocation
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_allowDuplicateIntersectionFunctionInvocation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAllowDuplicateIntersectionFunctionInvocation, value);
        }

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLBuffer PrimitiveDataBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_primitiveDataBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBuffer, value);
        }

        public ulong PrimitiveDataBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBufferOffset, value);
        }

        public ulong PrimitiveDataStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataStride, value);
        }

        public ulong PrimitiveDataElementSize
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataElementSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataElementSize, value);
        }

        public NSArray VertexBuffers
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_vertexBuffers));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexBuffers, value);
        }

        public MTLAttributeFormat VertexFormat
        {
            get => (MTLAttributeFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_vertexFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexFormat, (ulong)value);
        }

        public ulong VertexStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_vertexStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexStride, value);
        }

        public MTLBuffer IndexBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_indexBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBuffer, value);
        }

        public ulong IndexBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBufferOffset, value);
        }

        public MTLIndexType IndexType
        {
            get => (MTLIndexType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexType, (ulong)value);
        }

        public ulong TriangleCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_triangleCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTriangleCount, value);
        }

        public MTLBuffer TransformationMatrixBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_transformationMatrixBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTransformationMatrixBuffer, value);
        }

        public ulong TransformationMatrixBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_transformationMatrixBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTransformationMatrixBufferOffset, value);
        }

        private static readonly Selector sel_intersectionFunctionTableOffset = "intersectionFunctionTableOffset";
        private static readonly Selector sel_setIntersectionFunctionTableOffset = "setIntersectionFunctionTableOffset:";
        private static readonly Selector sel_opaque = "opaque";
        private static readonly Selector sel_setOpaque = "setOpaque:";
        private static readonly Selector sel_allowDuplicateIntersectionFunctionInvocation = "allowDuplicateIntersectionFunctionInvocation";
        private static readonly Selector sel_setAllowDuplicateIntersectionFunctionInvocation = "setAllowDuplicateIntersectionFunctionInvocation:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_primitiveDataBuffer = "primitiveDataBuffer";
        private static readonly Selector sel_setPrimitiveDataBuffer = "setPrimitiveDataBuffer:";
        private static readonly Selector sel_primitiveDataBufferOffset = "primitiveDataBufferOffset";
        private static readonly Selector sel_setPrimitiveDataBufferOffset = "setPrimitiveDataBufferOffset:";
        private static readonly Selector sel_primitiveDataStride = "primitiveDataStride";
        private static readonly Selector sel_setPrimitiveDataStride = "setPrimitiveDataStride:";
        private static readonly Selector sel_primitiveDataElementSize = "primitiveDataElementSize";
        private static readonly Selector sel_setPrimitiveDataElementSize = "setPrimitiveDataElementSize:";
        private static readonly Selector sel_vertexBuffers = "vertexBuffers";
        private static readonly Selector sel_setVertexBuffers = "setVertexBuffers:";
        private static readonly Selector sel_vertexFormat = "vertexFormat";
        private static readonly Selector sel_setVertexFormat = "setVertexFormat:";
        private static readonly Selector sel_vertexStride = "vertexStride";
        private static readonly Selector sel_setVertexStride = "setVertexStride:";
        private static readonly Selector sel_indexBuffer = "indexBuffer";
        private static readonly Selector sel_setIndexBuffer = "setIndexBuffer:";
        private static readonly Selector sel_indexBufferOffset = "indexBufferOffset";
        private static readonly Selector sel_setIndexBufferOffset = "setIndexBufferOffset:";
        private static readonly Selector sel_indexType = "indexType";
        private static readonly Selector sel_setIndexType = "setIndexType:";
        private static readonly Selector sel_triangleCount = "triangleCount";
        private static readonly Selector sel_setTriangleCount = "setTriangleCount:";
        private static readonly Selector sel_transformationMatrixBuffer = "transformationMatrixBuffer";
        private static readonly Selector sel_setTransformationMatrixBuffer = "setTransformationMatrixBuffer:";
        private static readonly Selector sel_transformationMatrixBufferOffset = "transformationMatrixBufferOffset";
        private static readonly Selector sel_setTransformationMatrixBufferOffset = "setTransformationMatrixBufferOffset:";
        private static readonly Selector sel_descriptor = "descriptor";
    }

    public partial struct MTLAccelerationStructureMotionBoundingBoxGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLAccelerationStructureMotionBoundingBoxGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLAccelerationStructureGeometryDescriptor(in MTLAccelerationStructureMotionBoundingBoxGeometryDescriptor obj) => new MTLAccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTLAccelerationStructureMotionBoundingBoxGeometryDescriptor(in MTLAccelerationStructureGeometryDescriptor obj) => new MTLAccelerationStructureMotionBoundingBoxGeometryDescriptor(obj.NativePtr);

        public MTLAccelerationStructureMotionBoundingBoxGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructureMotionBoundingBoxGeometryDescriptor New() => s_class.AllocInit<MTLAccelerationStructureMotionBoundingBoxGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructureMotionBoundingBoxGeometryDescriptor));

        public ulong IntersectionFunctionTableOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_intersectionFunctionTableOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIntersectionFunctionTableOffset, value);
        }

        public bool Opaque
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_opaque);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaque, value);
        }

        public bool AllowDuplicateIntersectionFunctionInvocation
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_allowDuplicateIntersectionFunctionInvocation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAllowDuplicateIntersectionFunctionInvocation, value);
        }

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLBuffer PrimitiveDataBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_primitiveDataBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBuffer, value);
        }

        public ulong PrimitiveDataBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBufferOffset, value);
        }

        public ulong PrimitiveDataStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataStride, value);
        }

        public ulong PrimitiveDataElementSize
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataElementSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataElementSize, value);
        }

        public NSArray BoundingBoxBuffers
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_boundingBoxBuffers));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBoundingBoxBuffers, value);
        }

        public ulong BoundingBoxStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_boundingBoxStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBoundingBoxStride, value);
        }

        public ulong BoundingBoxCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_boundingBoxCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBoundingBoxCount, value);
        }

        private static readonly Selector sel_intersectionFunctionTableOffset = "intersectionFunctionTableOffset";
        private static readonly Selector sel_setIntersectionFunctionTableOffset = "setIntersectionFunctionTableOffset:";
        private static readonly Selector sel_opaque = "opaque";
        private static readonly Selector sel_setOpaque = "setOpaque:";
        private static readonly Selector sel_allowDuplicateIntersectionFunctionInvocation = "allowDuplicateIntersectionFunctionInvocation";
        private static readonly Selector sel_setAllowDuplicateIntersectionFunctionInvocation = "setAllowDuplicateIntersectionFunctionInvocation:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_primitiveDataBuffer = "primitiveDataBuffer";
        private static readonly Selector sel_setPrimitiveDataBuffer = "setPrimitiveDataBuffer:";
        private static readonly Selector sel_primitiveDataBufferOffset = "primitiveDataBufferOffset";
        private static readonly Selector sel_setPrimitiveDataBufferOffset = "setPrimitiveDataBufferOffset:";
        private static readonly Selector sel_primitiveDataStride = "primitiveDataStride";
        private static readonly Selector sel_setPrimitiveDataStride = "setPrimitiveDataStride:";
        private static readonly Selector sel_primitiveDataElementSize = "primitiveDataElementSize";
        private static readonly Selector sel_setPrimitiveDataElementSize = "setPrimitiveDataElementSize:";
        private static readonly Selector sel_boundingBoxBuffers = "boundingBoxBuffers";
        private static readonly Selector sel_setBoundingBoxBuffers = "setBoundingBoxBuffers:";
        private static readonly Selector sel_boundingBoxStride = "boundingBoxStride";
        private static readonly Selector sel_setBoundingBoxStride = "setBoundingBoxStride:";
        private static readonly Selector sel_boundingBoxCount = "boundingBoxCount";
        private static readonly Selector sel_setBoundingBoxCount = "setBoundingBoxCount:";
        private static readonly Selector sel_descriptor = "descriptor";
    }

    public partial struct MTLAccelerationStructureCurveGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLAccelerationStructureCurveGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLAccelerationStructureGeometryDescriptor(in MTLAccelerationStructureCurveGeometryDescriptor obj) => new MTLAccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTLAccelerationStructureCurveGeometryDescriptor(in MTLAccelerationStructureGeometryDescriptor obj) => new MTLAccelerationStructureCurveGeometryDescriptor(obj.NativePtr);

        public MTLAccelerationStructureCurveGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructureCurveGeometryDescriptor New() => s_class.AllocInit<MTLAccelerationStructureCurveGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructureCurveGeometryDescriptor));

        public ulong IntersectionFunctionTableOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_intersectionFunctionTableOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIntersectionFunctionTableOffset, value);
        }

        public bool Opaque
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_opaque);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaque, value);
        }

        public bool AllowDuplicateIntersectionFunctionInvocation
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_allowDuplicateIntersectionFunctionInvocation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAllowDuplicateIntersectionFunctionInvocation, value);
        }

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLBuffer PrimitiveDataBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_primitiveDataBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBuffer, value);
        }

        public ulong PrimitiveDataBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBufferOffset, value);
        }

        public ulong PrimitiveDataStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataStride, value);
        }

        public ulong PrimitiveDataElementSize
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataElementSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataElementSize, value);
        }

        public MTLBuffer ControlPointBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_controlPointBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointBuffer, value);
        }

        public ulong ControlPointBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_controlPointBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointBufferOffset, value);
        }

        public ulong ControlPointCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_controlPointCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointCount, value);
        }

        public ulong ControlPointStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_controlPointStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointStride, value);
        }

        public MTLAttributeFormat ControlPointFormat
        {
            get => (MTLAttributeFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_controlPointFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointFormat, (ulong)value);
        }

        public MTLBuffer RadiusBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_radiusBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusBuffer, value);
        }

        public ulong RadiusBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_radiusBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusBufferOffset, value);
        }

        public MTLAttributeFormat RadiusFormat
        {
            get => (MTLAttributeFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_radiusFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusFormat, (ulong)value);
        }

        public ulong RadiusStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_radiusStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusStride, value);
        }

        public MTLBuffer IndexBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_indexBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBuffer, value);
        }

        public ulong IndexBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBufferOffset, value);
        }

        public MTLIndexType IndexType
        {
            get => (MTLIndexType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexType, (ulong)value);
        }

        public ulong SegmentCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_segmentCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSegmentCount, value);
        }

        public ulong SegmentControlPointCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_segmentControlPointCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSegmentControlPointCount, value);
        }

        public MTLCurveType CurveType
        {
            get => (MTLCurveType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_curveType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCurveType, (long)value);
        }

        public MTLCurveBasis CurveBasis
        {
            get => (MTLCurveBasis)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_curveBasis);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCurveBasis, (long)value);
        }

        public MTLCurveEndCaps CurveEndCaps
        {
            get => (MTLCurveEndCaps)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_curveEndCaps);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCurveEndCaps, (long)value);
        }

        private static readonly Selector sel_intersectionFunctionTableOffset = "intersectionFunctionTableOffset";
        private static readonly Selector sel_setIntersectionFunctionTableOffset = "setIntersectionFunctionTableOffset:";
        private static readonly Selector sel_opaque = "opaque";
        private static readonly Selector sel_setOpaque = "setOpaque:";
        private static readonly Selector sel_allowDuplicateIntersectionFunctionInvocation = "allowDuplicateIntersectionFunctionInvocation";
        private static readonly Selector sel_setAllowDuplicateIntersectionFunctionInvocation = "setAllowDuplicateIntersectionFunctionInvocation:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_primitiveDataBuffer = "primitiveDataBuffer";
        private static readonly Selector sel_setPrimitiveDataBuffer = "setPrimitiveDataBuffer:";
        private static readonly Selector sel_primitiveDataBufferOffset = "primitiveDataBufferOffset";
        private static readonly Selector sel_setPrimitiveDataBufferOffset = "setPrimitiveDataBufferOffset:";
        private static readonly Selector sel_primitiveDataStride = "primitiveDataStride";
        private static readonly Selector sel_setPrimitiveDataStride = "setPrimitiveDataStride:";
        private static readonly Selector sel_primitiveDataElementSize = "primitiveDataElementSize";
        private static readonly Selector sel_setPrimitiveDataElementSize = "setPrimitiveDataElementSize:";
        private static readonly Selector sel_controlPointBuffer = "controlPointBuffer";
        private static readonly Selector sel_setControlPointBuffer = "setControlPointBuffer:";
        private static readonly Selector sel_controlPointBufferOffset = "controlPointBufferOffset";
        private static readonly Selector sel_setControlPointBufferOffset = "setControlPointBufferOffset:";
        private static readonly Selector sel_controlPointCount = "controlPointCount";
        private static readonly Selector sel_setControlPointCount = "setControlPointCount:";
        private static readonly Selector sel_controlPointStride = "controlPointStride";
        private static readonly Selector sel_setControlPointStride = "setControlPointStride:";
        private static readonly Selector sel_controlPointFormat = "controlPointFormat";
        private static readonly Selector sel_setControlPointFormat = "setControlPointFormat:";
        private static readonly Selector sel_radiusBuffer = "radiusBuffer";
        private static readonly Selector sel_setRadiusBuffer = "setRadiusBuffer:";
        private static readonly Selector sel_radiusBufferOffset = "radiusBufferOffset";
        private static readonly Selector sel_setRadiusBufferOffset = "setRadiusBufferOffset:";
        private static readonly Selector sel_radiusFormat = "radiusFormat";
        private static readonly Selector sel_setRadiusFormat = "setRadiusFormat:";
        private static readonly Selector sel_radiusStride = "radiusStride";
        private static readonly Selector sel_setRadiusStride = "setRadiusStride:";
        private static readonly Selector sel_indexBuffer = "indexBuffer";
        private static readonly Selector sel_setIndexBuffer = "setIndexBuffer:";
        private static readonly Selector sel_indexBufferOffset = "indexBufferOffset";
        private static readonly Selector sel_setIndexBufferOffset = "setIndexBufferOffset:";
        private static readonly Selector sel_indexType = "indexType";
        private static readonly Selector sel_setIndexType = "setIndexType:";
        private static readonly Selector sel_segmentCount = "segmentCount";
        private static readonly Selector sel_setSegmentCount = "setSegmentCount:";
        private static readonly Selector sel_segmentControlPointCount = "segmentControlPointCount";
        private static readonly Selector sel_setSegmentControlPointCount = "setSegmentControlPointCount:";
        private static readonly Selector sel_curveType = "curveType";
        private static readonly Selector sel_setCurveType = "setCurveType:";
        private static readonly Selector sel_curveBasis = "curveBasis";
        private static readonly Selector sel_setCurveBasis = "setCurveBasis:";
        private static readonly Selector sel_curveEndCaps = "curveEndCaps";
        private static readonly Selector sel_setCurveEndCaps = "setCurveEndCaps:";
        private static readonly Selector sel_descriptor = "descriptor";
    }

    public partial struct MTLAccelerationStructureMotionCurveGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLAccelerationStructureMotionCurveGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLAccelerationStructureGeometryDescriptor(in MTLAccelerationStructureMotionCurveGeometryDescriptor obj) => new MTLAccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTLAccelerationStructureMotionCurveGeometryDescriptor(in MTLAccelerationStructureGeometryDescriptor obj) => new MTLAccelerationStructureMotionCurveGeometryDescriptor(obj.NativePtr);

        public MTLAccelerationStructureMotionCurveGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructureMotionCurveGeometryDescriptor New() => s_class.AllocInit<MTLAccelerationStructureMotionCurveGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructureMotionCurveGeometryDescriptor));

        public ulong IntersectionFunctionTableOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_intersectionFunctionTableOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIntersectionFunctionTableOffset, value);
        }

        public bool Opaque
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_opaque);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOpaque, value);
        }

        public bool AllowDuplicateIntersectionFunctionInvocation
        {
            get => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_allowDuplicateIntersectionFunctionInvocation);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAllowDuplicateIntersectionFunctionInvocation, value);
        }

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLBuffer PrimitiveDataBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_primitiveDataBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBuffer, value);
        }

        public ulong PrimitiveDataBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBufferOffset, value);
        }

        public ulong PrimitiveDataStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataStride, value);
        }

        public ulong PrimitiveDataElementSize
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_primitiveDataElementSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataElementSize, value);
        }

        public NSArray ControlPointBuffers
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_controlPointBuffers));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointBuffers, value);
        }

        public ulong ControlPointCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_controlPointCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointCount, value);
        }

        public ulong ControlPointStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_controlPointStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointStride, value);
        }

        public MTLAttributeFormat ControlPointFormat
        {
            get => (MTLAttributeFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_controlPointFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointFormat, (ulong)value);
        }

        public NSArray RadiusBuffers
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_radiusBuffers));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusBuffers, value);
        }

        public MTLAttributeFormat RadiusFormat
        {
            get => (MTLAttributeFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_radiusFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusFormat, (ulong)value);
        }

        public ulong RadiusStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_radiusStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusStride, value);
        }

        public MTLBuffer IndexBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_indexBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBuffer, value);
        }

        public ulong IndexBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBufferOffset, value);
        }

        public MTLIndexType IndexType
        {
            get => (MTLIndexType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexType, (ulong)value);
        }

        public ulong SegmentCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_segmentCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSegmentCount, value);
        }

        public ulong SegmentControlPointCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_segmentControlPointCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSegmentControlPointCount, value);
        }

        public MTLCurveType CurveType
        {
            get => (MTLCurveType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_curveType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCurveType, (long)value);
        }

        public MTLCurveBasis CurveBasis
        {
            get => (MTLCurveBasis)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_curveBasis);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCurveBasis, (long)value);
        }

        public MTLCurveEndCaps CurveEndCaps
        {
            get => (MTLCurveEndCaps)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_curveEndCaps);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setCurveEndCaps, (long)value);
        }

        private static readonly Selector sel_intersectionFunctionTableOffset = "intersectionFunctionTableOffset";
        private static readonly Selector sel_setIntersectionFunctionTableOffset = "setIntersectionFunctionTableOffset:";
        private static readonly Selector sel_opaque = "opaque";
        private static readonly Selector sel_setOpaque = "setOpaque:";
        private static readonly Selector sel_allowDuplicateIntersectionFunctionInvocation = "allowDuplicateIntersectionFunctionInvocation";
        private static readonly Selector sel_setAllowDuplicateIntersectionFunctionInvocation = "setAllowDuplicateIntersectionFunctionInvocation:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_primitiveDataBuffer = "primitiveDataBuffer";
        private static readonly Selector sel_setPrimitiveDataBuffer = "setPrimitiveDataBuffer:";
        private static readonly Selector sel_primitiveDataBufferOffset = "primitiveDataBufferOffset";
        private static readonly Selector sel_setPrimitiveDataBufferOffset = "setPrimitiveDataBufferOffset:";
        private static readonly Selector sel_primitiveDataStride = "primitiveDataStride";
        private static readonly Selector sel_setPrimitiveDataStride = "setPrimitiveDataStride:";
        private static readonly Selector sel_primitiveDataElementSize = "primitiveDataElementSize";
        private static readonly Selector sel_setPrimitiveDataElementSize = "setPrimitiveDataElementSize:";
        private static readonly Selector sel_controlPointBuffers = "controlPointBuffers";
        private static readonly Selector sel_setControlPointBuffers = "setControlPointBuffers:";
        private static readonly Selector sel_controlPointCount = "controlPointCount";
        private static readonly Selector sel_setControlPointCount = "setControlPointCount:";
        private static readonly Selector sel_controlPointStride = "controlPointStride";
        private static readonly Selector sel_setControlPointStride = "setControlPointStride:";
        private static readonly Selector sel_controlPointFormat = "controlPointFormat";
        private static readonly Selector sel_setControlPointFormat = "setControlPointFormat:";
        private static readonly Selector sel_radiusBuffers = "radiusBuffers";
        private static readonly Selector sel_setRadiusBuffers = "setRadiusBuffers:";
        private static readonly Selector sel_radiusFormat = "radiusFormat";
        private static readonly Selector sel_setRadiusFormat = "setRadiusFormat:";
        private static readonly Selector sel_radiusStride = "radiusStride";
        private static readonly Selector sel_setRadiusStride = "setRadiusStride:";
        private static readonly Selector sel_indexBuffer = "indexBuffer";
        private static readonly Selector sel_setIndexBuffer = "setIndexBuffer:";
        private static readonly Selector sel_indexBufferOffset = "indexBufferOffset";
        private static readonly Selector sel_setIndexBufferOffset = "setIndexBufferOffset:";
        private static readonly Selector sel_indexType = "indexType";
        private static readonly Selector sel_setIndexType = "setIndexType:";
        private static readonly Selector sel_segmentCount = "segmentCount";
        private static readonly Selector sel_setSegmentCount = "setSegmentCount:";
        private static readonly Selector sel_segmentControlPointCount = "segmentControlPointCount";
        private static readonly Selector sel_setSegmentControlPointCount = "setSegmentControlPointCount:";
        private static readonly Selector sel_curveType = "curveType";
        private static readonly Selector sel_setCurveType = "setCurveType:";
        private static readonly Selector sel_curveBasis = "curveBasis";
        private static readonly Selector sel_setCurveBasis = "setCurveBasis:";
        private static readonly Selector sel_curveEndCaps = "curveEndCaps";
        private static readonly Selector sel_setCurveEndCaps = "setCurveEndCaps:";
        private static readonly Selector sel_descriptor = "descriptor";
    }

    public partial struct MTLAccelerationStructureDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLAccelerationStructureDescriptor obj) => obj.NativePtr;
        public MTLAccelerationStructureDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAccelerationStructureDescriptor New() => s_class.AllocInit<MTLAccelerationStructureDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAccelerationStructureDescriptor));

        public MTLAccelerationStructureUsage Usage
        {
            get => (MTLAccelerationStructureUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_usage);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setUsage, (ulong)value);
        }

        private static readonly Selector sel_usage = "usage";
        private static readonly Selector sel_setUsage = "setUsage:";
    }

    public partial struct MTLInstanceAccelerationStructureDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLInstanceAccelerationStructureDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLAccelerationStructureDescriptor(in MTLInstanceAccelerationStructureDescriptor obj) => new MTLAccelerationStructureDescriptor(obj.NativePtr);
        public static implicit operator MTLInstanceAccelerationStructureDescriptor(in MTLAccelerationStructureDescriptor obj) => new MTLInstanceAccelerationStructureDescriptor(obj.NativePtr);

        public MTLInstanceAccelerationStructureDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLInstanceAccelerationStructureDescriptor New() => s_class.AllocInit<MTLInstanceAccelerationStructureDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLInstanceAccelerationStructureDescriptor));

        public MTLBuffer InstanceDescriptorBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_instanceDescriptorBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorBuffer, value);
        }

        public ulong InstanceDescriptorBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceDescriptorBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorBufferOffset, value);
        }

        public ulong InstanceDescriptorStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceDescriptorStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorStride, value);
        }

        public ulong InstanceCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceCount, value);
        }

        public NSArray InstancedAccelerationStructures
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_instancedAccelerationStructures));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstancedAccelerationStructures, value);
        }

        public MTLAccelerationStructureInstanceDescriptorType InstanceDescriptorType
        {
            get => (MTLAccelerationStructureInstanceDescriptorType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceDescriptorType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorType, (ulong)value);
        }

        public MTLBuffer MotionTransformBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_motionTransformBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformBuffer, value);
        }

        public ulong MotionTransformBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_motionTransformBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformBufferOffset, value);
        }

        public ulong MotionTransformCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_motionTransformCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformCount, value);
        }

        public MTLAccelerationStructureUsage Usage
        {
            get => (MTLAccelerationStructureUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_usage);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setUsage, (ulong)value);
        }

        private static readonly Selector sel_usage = "usage";
        private static readonly Selector sel_setUsage = "setUsage:";
        private static readonly Selector sel_instanceDescriptorBuffer = "instanceDescriptorBuffer";
        private static readonly Selector sel_setInstanceDescriptorBuffer = "setInstanceDescriptorBuffer:";
        private static readonly Selector sel_instanceDescriptorBufferOffset = "instanceDescriptorBufferOffset";
        private static readonly Selector sel_setInstanceDescriptorBufferOffset = "setInstanceDescriptorBufferOffset:";
        private static readonly Selector sel_instanceDescriptorStride = "instanceDescriptorStride";
        private static readonly Selector sel_setInstanceDescriptorStride = "setInstanceDescriptorStride:";
        private static readonly Selector sel_instanceCount = "instanceCount";
        private static readonly Selector sel_setInstanceCount = "setInstanceCount:";
        private static readonly Selector sel_instancedAccelerationStructures = "instancedAccelerationStructures";
        private static readonly Selector sel_setInstancedAccelerationStructures = "setInstancedAccelerationStructures:";
        private static readonly Selector sel_instanceDescriptorType = "instanceDescriptorType";
        private static readonly Selector sel_setInstanceDescriptorType = "setInstanceDescriptorType:";
        private static readonly Selector sel_motionTransformBuffer = "motionTransformBuffer";
        private static readonly Selector sel_setMotionTransformBuffer = "setMotionTransformBuffer:";
        private static readonly Selector sel_motionTransformBufferOffset = "motionTransformBufferOffset";
        private static readonly Selector sel_setMotionTransformBufferOffset = "setMotionTransformBufferOffset:";
        private static readonly Selector sel_motionTransformCount = "motionTransformCount";
        private static readonly Selector sel_setMotionTransformCount = "setMotionTransformCount:";
        private static readonly Selector sel_descriptor = "descriptor";
    }

    public partial struct MTLIndirectInstanceAccelerationStructureDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLIndirectInstanceAccelerationStructureDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLAccelerationStructureDescriptor(in MTLIndirectInstanceAccelerationStructureDescriptor obj) => new MTLAccelerationStructureDescriptor(obj.NativePtr);
        public static implicit operator MTLIndirectInstanceAccelerationStructureDescriptor(in MTLAccelerationStructureDescriptor obj) => new MTLIndirectInstanceAccelerationStructureDescriptor(obj.NativePtr);

        public MTLIndirectInstanceAccelerationStructureDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLIndirectInstanceAccelerationStructureDescriptor New() => s_class.AllocInit<MTLIndirectInstanceAccelerationStructureDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLIndirectInstanceAccelerationStructureDescriptor));

        public MTLBuffer InstanceDescriptorBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_instanceDescriptorBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorBuffer, value);
        }

        public ulong InstanceDescriptorBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceDescriptorBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorBufferOffset, value);
        }

        public ulong InstanceDescriptorStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceDescriptorStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorStride, value);
        }

        public ulong MaxInstanceCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxInstanceCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMaxInstanceCount, value);
        }

        public MTLBuffer InstanceCountBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_instanceCountBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceCountBuffer, value);
        }

        public ulong InstanceCountBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceCountBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceCountBufferOffset, value);
        }

        public MTLAccelerationStructureInstanceDescriptorType InstanceDescriptorType
        {
            get => (MTLAccelerationStructureInstanceDescriptorType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceDescriptorType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorType, (ulong)value);
        }

        public MTLBuffer MotionTransformBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_motionTransformBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformBuffer, value);
        }

        public ulong MotionTransformBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_motionTransformBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformBufferOffset, value);
        }

        public ulong MaxMotionTransformCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxMotionTransformCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMaxMotionTransformCount, value);
        }

        public MTLBuffer MotionTransformCountBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_motionTransformCountBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformCountBuffer, value);
        }

        public ulong MotionTransformCountBufferOffset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_motionTransformCountBufferOffset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformCountBufferOffset, value);
        }

        public MTLAccelerationStructureUsage Usage
        {
            get => (MTLAccelerationStructureUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_usage);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setUsage, (ulong)value);
        }

        private static readonly Selector sel_usage = "usage";
        private static readonly Selector sel_setUsage = "setUsage:";
        private static readonly Selector sel_descriptor = "descriptor";
        private static readonly Selector sel_instanceDescriptorBuffer = "instanceDescriptorBuffer";
        private static readonly Selector sel_setInstanceDescriptorBuffer = "setInstanceDescriptorBuffer:";
        private static readonly Selector sel_instanceDescriptorBufferOffset = "instanceDescriptorBufferOffset";
        private static readonly Selector sel_setInstanceDescriptorBufferOffset = "setInstanceDescriptorBufferOffset:";
        private static readonly Selector sel_instanceDescriptorStride = "instanceDescriptorStride";
        private static readonly Selector sel_setInstanceDescriptorStride = "setInstanceDescriptorStride:";
        private static readonly Selector sel_maxInstanceCount = "maxInstanceCount";
        private static readonly Selector sel_setMaxInstanceCount = "setMaxInstanceCount:";
        private static readonly Selector sel_instanceCountBuffer = "instanceCountBuffer";
        private static readonly Selector sel_setInstanceCountBuffer = "setInstanceCountBuffer:";
        private static readonly Selector sel_instanceCountBufferOffset = "instanceCountBufferOffset";
        private static readonly Selector sel_setInstanceCountBufferOffset = "setInstanceCountBufferOffset:";
        private static readonly Selector sel_instanceDescriptorType = "instanceDescriptorType";
        private static readonly Selector sel_setInstanceDescriptorType = "setInstanceDescriptorType:";
        private static readonly Selector sel_motionTransformBuffer = "motionTransformBuffer";
        private static readonly Selector sel_setMotionTransformBuffer = "setMotionTransformBuffer:";
        private static readonly Selector sel_motionTransformBufferOffset = "motionTransformBufferOffset";
        private static readonly Selector sel_setMotionTransformBufferOffset = "setMotionTransformBufferOffset:";
        private static readonly Selector sel_maxMotionTransformCount = "maxMotionTransformCount";
        private static readonly Selector sel_setMaxMotionTransformCount = "setMaxMotionTransformCount:";
        private static readonly Selector sel_motionTransformCountBuffer = "motionTransformCountBuffer";
        private static readonly Selector sel_setMotionTransformCountBuffer = "setMotionTransformCountBuffer:";
        private static readonly Selector sel_motionTransformCountBufferOffset = "motionTransformCountBufferOffset";
        private static readonly Selector sel_setMotionTransformCountBufferOffset = "setMotionTransformCountBufferOffset:";
    }

    public partial struct MTLPrimitiveAccelerationStructureDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLPrimitiveAccelerationStructureDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLAccelerationStructureDescriptor(in MTLPrimitiveAccelerationStructureDescriptor obj) => new MTLAccelerationStructureDescriptor(obj.NativePtr);
        public static implicit operator MTLPrimitiveAccelerationStructureDescriptor(in MTLAccelerationStructureDescriptor obj) => new MTLPrimitiveAccelerationStructureDescriptor(obj.NativePtr);

        public MTLPrimitiveAccelerationStructureDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLPrimitiveAccelerationStructureDescriptor New() => s_class.AllocInit<MTLPrimitiveAccelerationStructureDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLPrimitiveAccelerationStructureDescriptor));

        public NSArray GeometryDescriptors
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_geometryDescriptors));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setGeometryDescriptors, value);
        }

        public MTLMotionBorderMode MotionStartBorderMode
        {
            get => (MTLMotionBorderMode)ObjectiveCRuntime.uint_objc_msgSend(NativePtr, sel_motionStartBorderMode);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionStartBorderMode, (uint)value);
        }

        public MTLMotionBorderMode MotionEndBorderMode
        {
            get => (MTLMotionBorderMode)ObjectiveCRuntime.uint_objc_msgSend(NativePtr, sel_motionEndBorderMode);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionEndBorderMode, (uint)value);
        }

        public float MotionStartTime
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, sel_motionStartTime);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionStartTime, value);
        }

        public float MotionEndTime
        {
            get => ObjectiveCRuntime.float_objc_msgSend(NativePtr, sel_motionEndTime);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionEndTime, value);
        }

        public ulong MotionKeyframeCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_motionKeyframeCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionKeyframeCount, value);
        }

        public MTLAccelerationStructureUsage Usage
        {
            get => (MTLAccelerationStructureUsage)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_usage);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setUsage, (ulong)value);
        }

        private static readonly Selector sel_usage = "usage";
        private static readonly Selector sel_setUsage = "setUsage:";
        private static readonly Selector sel_geometryDescriptors = "geometryDescriptors";
        private static readonly Selector sel_setGeometryDescriptors = "setGeometryDescriptors:";
        private static readonly Selector sel_motionStartBorderMode = "motionStartBorderMode";
        private static readonly Selector sel_setMotionStartBorderMode = "setMotionStartBorderMode:";
        private static readonly Selector sel_motionEndBorderMode = "motionEndBorderMode";
        private static readonly Selector sel_setMotionEndBorderMode = "setMotionEndBorderMode:";
        private static readonly Selector sel_motionStartTime = "motionStartTime";
        private static readonly Selector sel_setMotionStartTime = "setMotionStartTime:";
        private static readonly Selector sel_motionEndTime = "motionEndTime";
        private static readonly Selector sel_setMotionEndTime = "setMotionEndTime:";
        private static readonly Selector sel_motionKeyframeCount = "motionKeyframeCount";
        private static readonly Selector sel_setMotionKeyframeCount = "setMotionKeyframeCount:";
        private static readonly Selector sel_descriptor = "descriptor";
    }

    public partial struct MTLAccelerationStructure
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLAccelerationStructure obj) => obj.NativePtr;
        public static implicit operator MTLResource(in MTLAccelerationStructure obj) => new MTLResource(obj.NativePtr);
        public static implicit operator MTLAccelerationStructure(in MTLResource obj) => new MTLAccelerationStructure(obj.NativePtr);

        public MTLAccelerationStructure(in IntPtr ptr) => NativePtr = ptr;

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public MTLCPUCacheMode CpuCacheMode => (MTLCPUCacheMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_cpuCacheMode);

        public MTLStorageMode StorageMode => (MTLStorageMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storageMode);

        public MTLHazardTrackingMode HazardTrackingMode => (MTLHazardTrackingMode)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_hazardTrackingMode);

        public MTLResourceOptions ResourceOptions => (MTLResourceOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resourceOptions);

        public MTLHeap Heap => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_heap));

        public ulong HeapOffset => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_heapOffset);

        public ulong AllocatedSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_allocatedSize);

        public bool IsAliasable => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isAliasable);

        public ulong Size => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_size);

        public MTLResourceID GpuResourceID => ObjectiveCRuntime.MTLResourceID_objc_msgSend(NativePtr, sel_gpuResourceID);

        public MTLPurgeableState SetPurgeableState(in MTLPurgeableState state)
        {
            return (MTLPurgeableState)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_setPurgeableState, (ulong)state);
        }

        public void MakeAliasable()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_makeAliasable);
        }

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_cpuCacheMode = "cpuCacheMode";
        private static readonly Selector sel_storageMode = "storageMode";
        private static readonly Selector sel_hazardTrackingMode = "hazardTrackingMode";
        private static readonly Selector sel_resourceOptions = "resourceOptions";
        private static readonly Selector sel_setPurgeableState = "setPurgeableState:";
        private static readonly Selector sel_heap = "heap";
        private static readonly Selector sel_heapOffset = "heapOffset";
        private static readonly Selector sel_allocatedSize = "allocatedSize";
        private static readonly Selector sel_makeAliasable = "makeAliasable";
        private static readonly Selector sel_isAliasable = "isAliasable";
        private static readonly Selector sel_size = "size";
        private static readonly Selector sel_gpuResourceID = "gpuResourceID";
    }
}
