using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLAttributeFormat : ulong
    {
        Invalid = 0,
        UChar2 = 1,
        UChar3 = 2,
        UChar4 = 3,
        Char2 = 4,
        Char3 = 5,
        Char4 = 6,
        UChar2Normalized = 7,
        UChar3Normalized = 8,
        UChar4Normalized = 9,
        Char2Normalized = 10,
        Char3Normalized = 11,
        Char4Normalized = 12,
        UShort2 = 13,
        UShort3 = 14,
        UShort4 = 15,
        Short2 = 16,
        Short3 = 17,
        Short4 = 18,
        UShort2Normalized = 19,
        UShort3Normalized = 20,
        UShort4Normalized = 21,
        Short2Normalized = 22,
        Short3Normalized = 23,
        Short4Normalized = 24,
        Half2 = 25,
        Half3 = 26,
        Half4 = 27,
        Float = 28,
        Float2 = 29,
        Float3 = 30,
        Float4 = 31,
        Int = 32,
        Int2 = 33,
        Int3 = 34,
        Int4 = 35,
        UInt = 36,
        UInt2 = 37,
        UInt3 = 38,
        UInt4 = 39,
        Int1010102Normalized = 40,
        UInt1010102Normalized = 41,
        UChar4NormalizedBGRA = 42,
        UChar = 45,
        Char = 46,
        UCharNormalized = 47,
        CharNormalized = 48,
        UShort = 49,
        Short = 50,
        UShortNormalized = 51,
        ShortNormalized = 52,
        Half = 53,
        FloatRG11B10 = 54,
        FloatRGB9E5 = 55,
    }

    public enum MTLIndexType : ulong
    {
        UInt16 = 0,
        UInt32 = 1,
    }

    public enum MTLStepFunction : ulong
    {
        Constant = 0,
        PerVertex = 1,
        PerInstance = 2,
        PerPatch = 3,
        PerPatchControlPoint = 4,
        ThreadPositionInGridX = 5,
        ThreadPositionInGridY = 6,
        ThreadPositionInGridXIndexed = 7,
        ThreadPositionInGridYIndexed = 8,
    }
 
    public partial struct MTLBufferLayoutDescriptor
    {
        public IntPtr NativePtr;

        public MTLBufferLayoutDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLBufferLayoutDescriptor New() => s_class.AllocInit<MTLBufferLayoutDescriptor>();

        public ulong Stride
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_stride);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStride, value);
        }

        public MTLStepFunction StepFunction
        {
            get => (MTLStepFunction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_stepFunction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStepFunction, (ulong)value);
        }

        public ulong StepRate
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_stepRate);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStepRate, value);
        }

        public static implicit operator IntPtr(in MTLBufferLayoutDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLBufferLayoutDescriptor));
        private static readonly Selector sel_stride = "stride";
        private static readonly Selector sel_setStride = "setStride:";
        private static readonly Selector sel_stepFunction = "stepFunction";
        private static readonly Selector sel_setStepFunction = "setStepFunction:";
        private static readonly Selector sel_stepRate = "stepRate";
        private static readonly Selector sel_setStepRate = "setStepRate:";
    }

    public partial struct MTLBufferLayoutDescriptorArray
    {
        public IntPtr NativePtr;

        public MTLBufferLayoutDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

        public static MTLBufferLayoutDescriptorArray New() => s_class.AllocInit<MTLBufferLayoutDescriptorArray>();

        public MTLBufferLayoutDescriptor this[uint index]
        {
            get
            {
                return Object(index);
            }
            set
            {
                SetObject(value, index);
            }
        }

        public MTLBufferLayoutDescriptor Object(in ulong index)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, index));
        }

        public void SetObject(in MTLBufferLayoutDescriptor bufferDesc, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, bufferDesc, index);
        }

        public static implicit operator IntPtr(in MTLBufferLayoutDescriptorArray obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLBufferLayoutDescriptorArray));
        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    public partial struct MTLAttributeDescriptor
    {
        public IntPtr NativePtr;

        public MTLAttributeDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAttributeDescriptor New() => s_class.AllocInit<MTLAttributeDescriptor>();

        public MTLAttributeFormat Format
        {
            get => (MTLAttributeFormat)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_format);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFormat, (ulong)value);
        }

        public ulong Offset
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_offset);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOffset, value);
        }

        public ulong BufferIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_bufferIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setBufferIndex, value);
        }

        public static implicit operator IntPtr(in MTLAttributeDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAttributeDescriptor));
        private static readonly Selector sel_format = "format";
        private static readonly Selector sel_setFormat = "setFormat:";
        private static readonly Selector sel_offset = "offset";
        private static readonly Selector sel_setOffset = "setOffset:";
        private static readonly Selector sel_bufferIndex = "bufferIndex";
        private static readonly Selector sel_setBufferIndex = "setBufferIndex:";
    }

    public partial struct MTLAttributeDescriptorArray
    {
        public IntPtr NativePtr;

        public MTLAttributeDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

        public static MTLAttributeDescriptorArray New() => s_class.AllocInit<MTLAttributeDescriptorArray>();

        public MTLAttributeDescriptor this[uint index]
        {
            get
            {
                return Object(index);
            }
            set
            {
                SetObject(value, index);
            }
        }

        public MTLAttributeDescriptor Object(in ulong index)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, index));
        }

        public void SetObject(in MTLAttributeDescriptor attributeDesc, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, attributeDesc, index);
        }

        public static implicit operator IntPtr(in MTLAttributeDescriptorArray obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLAttributeDescriptorArray));
        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    public partial struct MTLStageInputOutputDescriptor
    {
        public IntPtr NativePtr;

        public MTLStageInputOutputDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLStageInputOutputDescriptor New() => s_class.AllocInit<MTLStageInputOutputDescriptor>();

        public MTLBufferLayoutDescriptorArray Layouts => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_layouts));

        public MTLAttributeDescriptorArray Attributes => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_attributes));

        public MTLIndexType IndexType
        {
            get => (MTLIndexType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexType);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexType, (ulong)value);
        }

        public ulong IndexBufferIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_indexBufferIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setIndexBufferIndex, value);
        }

        public void Reset()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_reset);
        }

        public static implicit operator IntPtr(in MTLStageInputOutputDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLStageInputOutputDescriptor));
        private static readonly Selector sel_stageInputOutputDescriptor = "stageInputOutputDescriptor";
        private static readonly Selector sel_layouts = "layouts";
        private static readonly Selector sel_attributes = "attributes";
        private static readonly Selector sel_indexType = "indexType";
        private static readonly Selector sel_setIndexType = "setIndexType:";
        private static readonly Selector sel_indexBufferIndex = "indexBufferIndex";
        private static readonly Selector sel_setIndexBufferIndex = "setIndexBufferIndex:";
        private static readonly Selector sel_reset = "reset";
    }
}
