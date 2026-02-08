using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    public partial struct MTL4AccelerationStructureDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTL4AccelerationStructureDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLAccelerationStructureDescriptor(in MTL4AccelerationStructureDescriptor obj) => new MTLAccelerationStructureDescriptor(obj.NativePtr);
        public static implicit operator MTL4AccelerationStructureDescriptor(in MTLAccelerationStructureDescriptor obj) => new MTL4AccelerationStructureDescriptor(obj.NativePtr);
        public MTL4AccelerationStructureDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4AccelerationStructureDescriptor New() => s_class.AllocInit<MTL4AccelerationStructureDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4AccelerationStructureDescriptor));
    }

    public partial struct MTL4AccelerationStructureGeometryDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTL4AccelerationStructureGeometryDescriptor obj) => obj.NativePtr;
        public MTL4AccelerationStructureGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4AccelerationStructureGeometryDescriptor New() => s_class.AllocInit<MTL4AccelerationStructureGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4AccelerationStructureGeometryDescriptor));

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

        public MTL4BufferRange PrimitiveDataBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPrimitiveDataBuffer, value);
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
        private static readonly Selector sel_setPrimitiveDataBuffer = "setPrimitiveDataBuffer:";
        private static readonly Selector sel_primitiveDataStride = "primitiveDataStride";
        private static readonly Selector sel_setPrimitiveDataStride = "setPrimitiveDataStride:";
        private static readonly Selector sel_primitiveDataElementSize = "primitiveDataElementSize";
        private static readonly Selector sel_setPrimitiveDataElementSize = "setPrimitiveDataElementSize:";
    }

    public partial struct MTL4PrimitiveAccelerationStructureDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4PrimitiveAccelerationStructureDescriptor obj) => obj.NativePtr;
        public static implicit operator MTL4AccelerationStructureDescriptor(in MTL4PrimitiveAccelerationStructureDescriptor obj) => new MTL4AccelerationStructureDescriptor(obj.NativePtr);
        public static implicit operator MTL4PrimitiveAccelerationStructureDescriptor(in MTL4AccelerationStructureDescriptor obj) => new MTL4PrimitiveAccelerationStructureDescriptor(obj.NativePtr);

        public MTL4PrimitiveAccelerationStructureDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4PrimitiveAccelerationStructureDescriptor New() => s_class.AllocInit<MTL4PrimitiveAccelerationStructureDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4PrimitiveAccelerationStructureDescriptor));

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
    }

    public partial struct MTL4AccelerationStructureTriangleGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4AccelerationStructureTriangleGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTL4AccelerationStructureGeometryDescriptor(in MTL4AccelerationStructureTriangleGeometryDescriptor obj) => new MTL4AccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTL4AccelerationStructureTriangleGeometryDescriptor(in MTL4AccelerationStructureGeometryDescriptor obj) => new MTL4AccelerationStructureTriangleGeometryDescriptor(obj.NativePtr);

        public MTL4AccelerationStructureTriangleGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4AccelerationStructureTriangleGeometryDescriptor New() => s_class.AllocInit<MTL4AccelerationStructureTriangleGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4AccelerationStructureTriangleGeometryDescriptor));

        public MTL4BufferRange VertexBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexBuffer, value);
        }

        public ulong VertexFormat
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_vertexFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexFormat, value);
        }

        public ulong VertexStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_vertexStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexStride, value);
        }

        public MTL4BufferRange IndexBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBuffer, value);
        }

        public ulong IndexType
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexType, value);
        }

        public ulong TriangleCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_triangleCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTriangleCount, value);
        }

        public MTL4BufferRange TransformationMatrixBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTransformationMatrixBuffer, value);
        }

        public MTLMatrixLayout TransformationMatrixLayout
        {
            get => (MTLMatrixLayout)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_transformationMatrixLayout);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTransformationMatrixLayout, (ulong)value);
        }

        private static readonly Selector sel_setVertexBuffer = "setVertexBuffer:";
        private static readonly Selector sel_vertexFormat = "vertexFormat";
        private static readonly Selector sel_setVertexFormat = "setVertexFormat:";
        private static readonly Selector sel_vertexStride = "vertexStride";
        private static readonly Selector sel_setVertexStride = "setVertexStride:";
        private static readonly Selector sel_setIndexBuffer = "setIndexBuffer:";
        private static readonly Selector sel_indexType = "indexType";
        private static readonly Selector sel_setIndexType = "setIndexType:";
        private static readonly Selector sel_triangleCount = "triangleCount";
        private static readonly Selector sel_setTriangleCount = "setTriangleCount:";
        private static readonly Selector sel_setTransformationMatrixBuffer = "setTransformationMatrixBuffer:";
        private static readonly Selector sel_transformationMatrixLayout = "transformationMatrixLayout";
        private static readonly Selector sel_setTransformationMatrixLayout = "setTransformationMatrixLayout:";
    }

    public partial struct MTL4AccelerationStructureBoundingBoxGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4AccelerationStructureBoundingBoxGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTL4AccelerationStructureGeometryDescriptor(in MTL4AccelerationStructureBoundingBoxGeometryDescriptor obj) => new MTL4AccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTL4AccelerationStructureBoundingBoxGeometryDescriptor(in MTL4AccelerationStructureGeometryDescriptor obj) => new MTL4AccelerationStructureBoundingBoxGeometryDescriptor(obj.NativePtr);

        public MTL4AccelerationStructureBoundingBoxGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4AccelerationStructureBoundingBoxGeometryDescriptor New() => s_class.AllocInit<MTL4AccelerationStructureBoundingBoxGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4AccelerationStructureBoundingBoxGeometryDescriptor));

        public MTL4BufferRange BoundingBoxBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBoundingBoxBuffer, value);
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

        private static readonly Selector sel_setBoundingBoxBuffer = "setBoundingBoxBuffer:";
        private static readonly Selector sel_boundingBoxStride = "boundingBoxStride";
        private static readonly Selector sel_setBoundingBoxStride = "setBoundingBoxStride:";
        private static readonly Selector sel_boundingBoxCount = "boundingBoxCount";
        private static readonly Selector sel_setBoundingBoxCount = "setBoundingBoxCount:";
    }

    public partial struct MTL4AccelerationStructureMotionTriangleGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4AccelerationStructureMotionTriangleGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTL4AccelerationStructureGeometryDescriptor(in MTL4AccelerationStructureMotionTriangleGeometryDescriptor obj) => new MTL4AccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTL4AccelerationStructureMotionTriangleGeometryDescriptor(in MTL4AccelerationStructureGeometryDescriptor obj) => new MTL4AccelerationStructureMotionTriangleGeometryDescriptor(obj.NativePtr);

        public MTL4AccelerationStructureMotionTriangleGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4AccelerationStructureMotionTriangleGeometryDescriptor New() => s_class.AllocInit<MTL4AccelerationStructureMotionTriangleGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4AccelerationStructureMotionTriangleGeometryDescriptor));

        public MTL4BufferRange VertexBuffers
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexBuffers, value);
        }

        public ulong VertexFormat
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_vertexFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexFormat, value);
        }

        public ulong VertexStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_vertexStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVertexStride, value);
        }

        public MTL4BufferRange IndexBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBuffer, value);
        }

        public ulong IndexType
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexType, value);
        }

        public ulong TriangleCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_triangleCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTriangleCount, value);
        }

        public MTL4BufferRange TransformationMatrixBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTransformationMatrixBuffer, value);
        }

        public MTLMatrixLayout TransformationMatrixLayout
        {
            get => (MTLMatrixLayout)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_transformationMatrixLayout);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTransformationMatrixLayout, (ulong)value);
        }

        private static readonly Selector sel_setVertexBuffers = "setVertexBuffers:";
        private static readonly Selector sel_vertexFormat = "vertexFormat";
        private static readonly Selector sel_setVertexFormat = "setVertexFormat:";
        private static readonly Selector sel_vertexStride = "vertexStride";
        private static readonly Selector sel_setVertexStride = "setVertexStride:";
        private static readonly Selector sel_setIndexBuffer = "setIndexBuffer:";
        private static readonly Selector sel_indexType = "indexType";
        private static readonly Selector sel_setIndexType = "setIndexType:";
        private static readonly Selector sel_triangleCount = "triangleCount";
        private static readonly Selector sel_setTriangleCount = "setTriangleCount:";
        private static readonly Selector sel_setTransformationMatrixBuffer = "setTransformationMatrixBuffer:";
        private static readonly Selector sel_transformationMatrixLayout = "transformationMatrixLayout";
        private static readonly Selector sel_setTransformationMatrixLayout = "setTransformationMatrixLayout:";
    }

    public partial struct MTL4AccelerationStructureMotionBoundingBoxGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4AccelerationStructureMotionBoundingBoxGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTL4AccelerationStructureGeometryDescriptor(in MTL4AccelerationStructureMotionBoundingBoxGeometryDescriptor obj) => new MTL4AccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTL4AccelerationStructureMotionBoundingBoxGeometryDescriptor(in MTL4AccelerationStructureGeometryDescriptor obj) => new MTL4AccelerationStructureMotionBoundingBoxGeometryDescriptor(obj.NativePtr);

        public MTL4AccelerationStructureMotionBoundingBoxGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4AccelerationStructureMotionBoundingBoxGeometryDescriptor New() => s_class.AllocInit<MTL4AccelerationStructureMotionBoundingBoxGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4AccelerationStructureMotionBoundingBoxGeometryDescriptor));

        public MTL4BufferRange BoundingBoxBuffers
        {
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

        private static readonly Selector sel_setBoundingBoxBuffers = "setBoundingBoxBuffers:";
        private static readonly Selector sel_boundingBoxStride = "boundingBoxStride";
        private static readonly Selector sel_setBoundingBoxStride = "setBoundingBoxStride:";
        private static readonly Selector sel_boundingBoxCount = "boundingBoxCount";
        private static readonly Selector sel_setBoundingBoxCount = "setBoundingBoxCount:";
    }

    public partial struct MTL4AccelerationStructureCurveGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4AccelerationStructureCurveGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTL4AccelerationStructureGeometryDescriptor(in MTL4AccelerationStructureCurveGeometryDescriptor obj) => new MTL4AccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTL4AccelerationStructureCurveGeometryDescriptor(in MTL4AccelerationStructureGeometryDescriptor obj) => new MTL4AccelerationStructureCurveGeometryDescriptor(obj.NativePtr);

        public MTL4AccelerationStructureCurveGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4AccelerationStructureCurveGeometryDescriptor New() => s_class.AllocInit<MTL4AccelerationStructureCurveGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4AccelerationStructureCurveGeometryDescriptor));

        public MTL4BufferRange ControlPointBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointBuffer, value);
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

        public ulong ControlPointFormat
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_controlPointFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointFormat, value);
        }

        public MTL4BufferRange RadiusBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusBuffer, value);
        }

        public ulong RadiusFormat
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_radiusFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusFormat, value);
        }

        public ulong RadiusStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_radiusStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusStride, value);
        }

        public MTL4BufferRange IndexBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBuffer, value);
        }

        public ulong IndexType
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexType, value);
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

        private static readonly Selector sel_setControlPointBuffer = "setControlPointBuffer:";
        private static readonly Selector sel_controlPointCount = "controlPointCount";
        private static readonly Selector sel_setControlPointCount = "setControlPointCount:";
        private static readonly Selector sel_controlPointStride = "controlPointStride";
        private static readonly Selector sel_setControlPointStride = "setControlPointStride:";
        private static readonly Selector sel_controlPointFormat = "controlPointFormat";
        private static readonly Selector sel_setControlPointFormat = "setControlPointFormat:";
        private static readonly Selector sel_setRadiusBuffer = "setRadiusBuffer:";
        private static readonly Selector sel_radiusFormat = "radiusFormat";
        private static readonly Selector sel_setRadiusFormat = "setRadiusFormat:";
        private static readonly Selector sel_radiusStride = "radiusStride";
        private static readonly Selector sel_setRadiusStride = "setRadiusStride:";
        private static readonly Selector sel_setIndexBuffer = "setIndexBuffer:";
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
    }

    public partial struct MTL4AccelerationStructureMotionCurveGeometryDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4AccelerationStructureMotionCurveGeometryDescriptor obj) => obj.NativePtr;
        public static implicit operator MTL4AccelerationStructureGeometryDescriptor(in MTL4AccelerationStructureMotionCurveGeometryDescriptor obj) => new MTL4AccelerationStructureGeometryDescriptor(obj.NativePtr);
        public static implicit operator MTL4AccelerationStructureMotionCurveGeometryDescriptor(in MTL4AccelerationStructureGeometryDescriptor obj) => new MTL4AccelerationStructureMotionCurveGeometryDescriptor(obj.NativePtr);

        public MTL4AccelerationStructureMotionCurveGeometryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4AccelerationStructureMotionCurveGeometryDescriptor New() => s_class.AllocInit<MTL4AccelerationStructureMotionCurveGeometryDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4AccelerationStructureMotionCurveGeometryDescriptor));

        public MTL4BufferRange ControlPointBuffers
        {
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

        public ulong ControlPointFormat
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_controlPointFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlPointFormat, value);
        }

        public MTL4BufferRange RadiusBuffers
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusBuffers, value);
        }

        public ulong RadiusFormat
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_radiusFormat);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusFormat, value);
        }

        public ulong RadiusStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_radiusStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRadiusStride, value);
        }

        public MTL4BufferRange IndexBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBuffer, value);
        }

        public ulong IndexType
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexType, value);
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

        private static readonly Selector sel_setControlPointBuffers = "setControlPointBuffers:";
        private static readonly Selector sel_controlPointCount = "controlPointCount";
        private static readonly Selector sel_setControlPointCount = "setControlPointCount:";
        private static readonly Selector sel_controlPointStride = "controlPointStride";
        private static readonly Selector sel_setControlPointStride = "setControlPointStride:";
        private static readonly Selector sel_controlPointFormat = "controlPointFormat";
        private static readonly Selector sel_setControlPointFormat = "setControlPointFormat:";
        private static readonly Selector sel_setRadiusBuffers = "setRadiusBuffers:";
        private static readonly Selector sel_radiusFormat = "radiusFormat";
        private static readonly Selector sel_setRadiusFormat = "setRadiusFormat:";
        private static readonly Selector sel_radiusStride = "radiusStride";
        private static readonly Selector sel_setRadiusStride = "setRadiusStride:";
        private static readonly Selector sel_setIndexBuffer = "setIndexBuffer:";
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
    }

    public partial struct MTL4InstanceAccelerationStructureDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4InstanceAccelerationStructureDescriptor obj) => obj.NativePtr;
        public static implicit operator MTL4AccelerationStructureDescriptor(in MTL4InstanceAccelerationStructureDescriptor obj) => new MTL4AccelerationStructureDescriptor(obj.NativePtr);
        public static implicit operator MTL4InstanceAccelerationStructureDescriptor(in MTL4AccelerationStructureDescriptor obj) => new MTL4InstanceAccelerationStructureDescriptor(obj.NativePtr);

        public MTL4InstanceAccelerationStructureDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4InstanceAccelerationStructureDescriptor New() => s_class.AllocInit<MTL4InstanceAccelerationStructureDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4InstanceAccelerationStructureDescriptor));

        public MTL4BufferRange InstanceDescriptorBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorBuffer, value);
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

        public MTLAccelerationStructureInstanceDescriptorType InstanceDescriptorType
        {
            get => (MTLAccelerationStructureInstanceDescriptorType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceDescriptorType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorType, (ulong)value);
        }

        public MTL4BufferRange MotionTransformBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformBuffer, value);
        }

        public ulong MotionTransformCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_motionTransformCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformCount, value);
        }

        public MTLMatrixLayout InstanceTransformationMatrixLayout
        {
            get => (MTLMatrixLayout)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceTransformationMatrixLayout);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceTransformationMatrixLayout, (ulong)value);
        }

        public MTLTransformType MotionTransformType
        {
            get => (MTLTransformType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_motionTransformType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformType, (long)value);
        }

        public ulong MotionTransformStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_motionTransformStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformStride, value);
        }

        private static readonly Selector sel_setInstanceDescriptorBuffer = "setInstanceDescriptorBuffer:";
        private static readonly Selector sel_instanceDescriptorStride = "instanceDescriptorStride";
        private static readonly Selector sel_setInstanceDescriptorStride = "setInstanceDescriptorStride:";
        private static readonly Selector sel_instanceCount = "instanceCount";
        private static readonly Selector sel_setInstanceCount = "setInstanceCount:";
        private static readonly Selector sel_instanceDescriptorType = "instanceDescriptorType";
        private static readonly Selector sel_setInstanceDescriptorType = "setInstanceDescriptorType:";
        private static readonly Selector sel_setMotionTransformBuffer = "setMotionTransformBuffer:";
        private static readonly Selector sel_motionTransformCount = "motionTransformCount";
        private static readonly Selector sel_setMotionTransformCount = "setMotionTransformCount:";
        private static readonly Selector sel_instanceTransformationMatrixLayout = "instanceTransformationMatrixLayout";
        private static readonly Selector sel_setInstanceTransformationMatrixLayout = "setInstanceTransformationMatrixLayout:";
        private static readonly Selector sel_motionTransformType = "motionTransformType";
        private static readonly Selector sel_setMotionTransformType = "setMotionTransformType:";
        private static readonly Selector sel_motionTransformStride = "motionTransformStride";
        private static readonly Selector sel_setMotionTransformStride = "setMotionTransformStride:";
    }

    public partial struct MTL4IndirectInstanceAccelerationStructureDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTL4IndirectInstanceAccelerationStructureDescriptor obj) => obj.NativePtr;
        public static implicit operator MTL4AccelerationStructureDescriptor(in MTL4IndirectInstanceAccelerationStructureDescriptor obj) => new MTL4AccelerationStructureDescriptor(obj.NativePtr);
        public static implicit operator MTL4IndirectInstanceAccelerationStructureDescriptor(in MTL4AccelerationStructureDescriptor obj) => new MTL4IndirectInstanceAccelerationStructureDescriptor(obj.NativePtr);

        public MTL4IndirectInstanceAccelerationStructureDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4IndirectInstanceAccelerationStructureDescriptor New() => s_class.AllocInit<MTL4IndirectInstanceAccelerationStructureDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4IndirectInstanceAccelerationStructureDescriptor));

        public MTL4BufferRange InstanceDescriptorBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorBuffer, value);
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

        public MTL4BufferRange InstanceCountBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceCountBuffer, value);
        }

        public MTLAccelerationStructureInstanceDescriptorType InstanceDescriptorType
        {
            get => (MTLAccelerationStructureInstanceDescriptorType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceDescriptorType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceDescriptorType, (ulong)value);
        }

        public MTL4BufferRange MotionTransformBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformBuffer, value);
        }

        public ulong MaxMotionTransformCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maxMotionTransformCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMaxMotionTransformCount, value);
        }

        public MTL4BufferRange MotionTransformCountBuffer
        {
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformCountBuffer, value);
        }

        public MTLMatrixLayout InstanceTransformationMatrixLayout
        {
            get => (MTLMatrixLayout)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_instanceTransformationMatrixLayout);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInstanceTransformationMatrixLayout, (ulong)value);
        }

        public MTLTransformType MotionTransformType
        {
            get => (MTLTransformType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_motionTransformType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformType, (long)value);
        }

        public ulong MotionTransformStride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_motionTransformStride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMotionTransformStride, value);
        }

        private static readonly Selector sel_setInstanceDescriptorBuffer = "setInstanceDescriptorBuffer:";
        private static readonly Selector sel_instanceDescriptorStride = "instanceDescriptorStride";
        private static readonly Selector sel_setInstanceDescriptorStride = "setInstanceDescriptorStride:";
        private static readonly Selector sel_maxInstanceCount = "maxInstanceCount";
        private static readonly Selector sel_setMaxInstanceCount = "setMaxInstanceCount:";
        private static readonly Selector sel_setInstanceCountBuffer = "setInstanceCountBuffer:";
        private static readonly Selector sel_instanceDescriptorType = "instanceDescriptorType";
        private static readonly Selector sel_setInstanceDescriptorType = "setInstanceDescriptorType:";
        private static readonly Selector sel_setMotionTransformBuffer = "setMotionTransformBuffer:";
        private static readonly Selector sel_maxMotionTransformCount = "maxMotionTransformCount";
        private static readonly Selector sel_setMaxMotionTransformCount = "setMaxMotionTransformCount:";
        private static readonly Selector sel_setMotionTransformCountBuffer = "setMotionTransformCountBuffer:";
        private static readonly Selector sel_instanceTransformationMatrixLayout = "instanceTransformationMatrixLayout";
        private static readonly Selector sel_setInstanceTransformationMatrixLayout = "setInstanceTransformationMatrixLayout:";
        private static readonly Selector sel_motionTransformType = "motionTransformType";
        private static readonly Selector sel_setMotionTransformType = "setMotionTransformType:";
        private static readonly Selector sel_motionTransformStride = "motionTransformStride";
        private static readonly Selector sel_setMotionTransformStride = "setMotionTransformStride:";
    }
}
