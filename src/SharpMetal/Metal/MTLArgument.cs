using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public enum MTLDataType : ulong
    {
        None = 0,
        Struct = 1,
        Array = 2,
        Float = 3,
        Float2 = 4,
        Float3 = 5,
        Float4 = 6,
        Float2x2 = 7,
        Float2x3 = 8,
        Float2x4 = 9,
        Float3x2 = 10,
        Float3x3 = 11,
        Float3x4 = 12,
        Float4x2 = 13,
        Float4x3 = 14,
        Float4x4 = 15,
        Half = 16,
        Half2 = 17,
        Half3 = 18,
        Half4 = 19,
        Half2x2 = 20,
        Half2x3 = 21,
        Half2x4 = 22,
        Half3x2 = 23,
        Half3x3 = 24,
        Half3x4 = 25,
        Half4x2 = 26,
        Half4x3 = 27,
        Half4x4 = 28,
        Int = 29,
        Int2 = 30,
        Int3 = 31,
        Int4 = 32,
        UInt = 33,
        UInt2 = 34,
        UInt3 = 35,
        UInt4 = 36,
        Short = 37,
        Short2 = 38,
        Short3 = 39,
        Short4 = 40,
        UShort = 41,
        UShort2 = 42,
        UShort3 = 43,
        UShort4 = 44,
        Char = 45,
        Char2 = 46,
        Char3 = 47,
        Char4 = 48,
        UChar = 49,
        UChar2 = 50,
        UChar3 = 51,
        UChar4 = 52,
        Bool = 53,
        Bool2 = 54,
        Bool3 = 55,
        Bool4 = 56,
        Texture = 58,
        Sampler = 59,
        Pointer = 60,
        R8Unorm = 62,
        R8Snorm = 63,
        R16Unorm = 64,
        R16Snorm = 65,
        RG8Unorm = 66,
        RG8Snorm = 67,
        RG16Unorm = 68,
        RG16Snorm = 69,
        RGBA8Unorm = 70,
        RGBA8UnormsRGB = 71,
        RGBA8Snorm = 72,
        RGBA16Unorm = 73,
        RGBA16Snorm = 74,
        RGB10A2Unorm = 75,
        RG11B10Float = 76,
        RGB9E5Float = 77,
        RenderPipeline = 78,
        ComputePipeline = 79,
        IndirectCommandBuffer = 80,
        Long = 81,
        Long2 = 82,
        Long3 = 83,
        Long4 = 84,
        ULong = 85,
        ULong2 = 86,
        ULong3 = 87,
        ULong4 = 88,
        VisibleFunctionTable = 115,
        IntersectionFunctionTable = 116,
        PrimitiveAccelerationStructure = 117,
        InstanceAccelerationStructure = 118,
        BFloat = 121,
        BFloat2 = 122,
        BFloat3 = 123,
        BFloat4 = 124,
    }

    public enum MTLBindingType : long
    {
        Buffer = 0,
        ThreadgroupMemory = 1,
        Texture = 2,
        Sampler = 3,
        ImageblockData = 16,
        Imageblock = 17,
        VisibleFunctionTable = 24,
        PrimitiveAccelerationStructure = 25,
        InstanceAccelerationStructure = 26,
        IntersectionFunctionTable = 27,
        ObjectPayload = 34,
    }

    public enum MTLBindingAccess : ulong
    {
        ReadOnly = 0,
        ReadWrite = 1,
        WriteOnly = 2,
    }

    public partial struct MTLType
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLType obj) => obj.NativePtr;
        public MTLType(in IntPtr ptr) => NativePtr = ptr;

        public static MTLType New() => s_class.AllocInit<MTLType>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLType));

        public MTLDataType DataType => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_dataType);

        private static readonly Selector sel_dataType = "dataType";
    }

    public partial struct MTLStructMember
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLStructMember obj) => obj.NativePtr;
        public MTLStructMember(in IntPtr ptr) => NativePtr = ptr;

        public static MTLStructMember New() => s_class.AllocInit<MTLStructMember>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLStructMember));

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public ulong Offset => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_offset);

        public MTLDataType DataType => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_dataType);

        public MTLStructType StructType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_structType));

        public MTLArrayType ArrayType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_arrayType));

        public MTLTextureReferenceType TextureReferenceType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_textureReferenceType));

        public MTLPointerType PointerType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_pointerType));

        public ulong ArgumentIndex => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_argumentIndex);

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_offset = "offset";
        private static readonly Selector sel_dataType = "dataType";
        private static readonly Selector sel_structType = "structType";
        private static readonly Selector sel_arrayType = "arrayType";
        private static readonly Selector sel_textureReferenceType = "textureReferenceType";
        private static readonly Selector sel_pointerType = "pointerType";
        private static readonly Selector sel_argumentIndex = "argumentIndex";
    }

    public partial struct MTLStructType
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLStructType obj) => obj.NativePtr;
        public MTLStructType(in IntPtr ptr) => NativePtr = ptr;

        public static MTLStructType New() => s_class.AllocInit<MTLStructType>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLStructType));

        public NSArray Members => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_members));

        public MTLStructMember MemberByName(NSString name)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_memberByName, name));
        }

        private static readonly Selector sel_members = "members";
        private static readonly Selector sel_memberByName = "memberByName:";
    }

    public partial struct MTLArrayType
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLArrayType obj) => obj.NativePtr;
        public MTLArrayType(in IntPtr ptr) => NativePtr = ptr;

        public static MTLArrayType New() => s_class.AllocInit<MTLArrayType>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLArrayType));

        public MTLDataType ElementType => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_elementType);

        public ulong ArrayLength => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_arrayLength);

        public ulong Stride => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_stride);

        public ulong ArgumentIndexStride => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_argumentIndexStride);

        public MTLStructType ElementStructType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_elementStructType));

        public MTLArrayType ElementArrayType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_elementArrayType));

        public MTLTextureReferenceType ElementTextureReferenceType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_elementTextureReferenceType));

        public MTLPointerType ElementPointerType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_elementPointerType));

        private static readonly Selector sel_elementType = "elementType";
        private static readonly Selector sel_arrayLength = "arrayLength";
        private static readonly Selector sel_stride = "stride";
        private static readonly Selector sel_argumentIndexStride = "argumentIndexStride";
        private static readonly Selector sel_elementStructType = "elementStructType";
        private static readonly Selector sel_elementArrayType = "elementArrayType";
        private static readonly Selector sel_elementTextureReferenceType = "elementTextureReferenceType";
        private static readonly Selector sel_elementPointerType = "elementPointerType";
    }

    public partial struct MTLPointerType
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLPointerType obj) => obj.NativePtr;
        public MTLPointerType(in IntPtr ptr) => NativePtr = ptr;

        public static MTLPointerType New() => s_class.AllocInit<MTLPointerType>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLPointerType));

        public MTLDataType ElementType => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_elementType);

        public MTLBindingAccess Access => (MTLBindingAccess)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_access);

        public ulong Alignment => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_alignment);

        public ulong DataSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_dataSize);

        public bool ElementIsArgumentBuffer => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_elementIsArgumentBuffer);

        public MTLStructType ElementStructType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_elementStructType));

        public MTLArrayType ElementArrayType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_elementArrayType));

        private static readonly Selector sel_elementType = "elementType";
        private static readonly Selector sel_access = "access";
        private static readonly Selector sel_alignment = "alignment";
        private static readonly Selector sel_dataSize = "dataSize";
        private static readonly Selector sel_elementIsArgumentBuffer = "elementIsArgumentBuffer";
        private static readonly Selector sel_elementStructType = "elementStructType";
        private static readonly Selector sel_elementArrayType = "elementArrayType";
    }
    
    public partial struct MTLTextureReferenceType
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLTextureReferenceType obj) => obj.NativePtr;
        public MTLTextureReferenceType(in IntPtr ptr) => NativePtr = ptr;

        public static MTLTextureReferenceType New() => s_class.AllocInit<MTLTextureReferenceType>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLTextureReferenceType));

        public MTLDataType TextureDataType => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_textureDataType);

        public MTLTextureType TextureType => (MTLTextureType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_textureType);

        public MTLBindingAccess Access => (MTLBindingAccess)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_access);

        public bool IsDepthTexture => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isDepthTexture);

        private static readonly Selector sel_textureDataType = "textureDataType";
        private static readonly Selector sel_textureType = "textureType";
        private static readonly Selector sel_access = "access";
        private static readonly Selector sel_isDepthTexture = "isDepthTexture";
    }

    public partial struct MTLArgument
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLArgument obj) => obj.NativePtr;
        public MTLArgument(in IntPtr ptr) => NativePtr = ptr;

        public static MTLArgument New() => s_class.AllocInit<MTLArgument>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLArgument));

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public MTLBindingType Type => (MTLBindingType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_type);

        public MTLBindingAccess Access => (MTLBindingAccess)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_access);

        public ulong Index => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_index);

        public bool Active => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isActive);

        public ulong BufferAlignment => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_bufferAlignment);

        public ulong BufferDataSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_bufferDataSize);

        public MTLDataType BufferDataType => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_bufferDataType);

        public MTLStructType BufferStructType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_bufferStructType));

        public MTLPointerType BufferPointerType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_bufferPointerType));

        public ulong ThreadgroupMemoryAlignment => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_threadgroupMemoryAlignment);

        public ulong ThreadgroupMemoryDataSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_threadgroupMemoryDataSize);

        public MTLTextureType TextureType => (MTLTextureType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_textureType);

        public MTLDataType TextureDataType => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_textureDataType);

        public bool IsDepthTexture => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isDepthTexture);

        public ulong ArrayLength => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_arrayLength);

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_access = "access";
        private static readonly Selector sel_index = "index";
        private static readonly Selector sel_isActive = "isActive";
        private static readonly Selector sel_bufferAlignment = "bufferAlignment";
        private static readonly Selector sel_bufferDataSize = "bufferDataSize";
        private static readonly Selector sel_bufferDataType = "bufferDataType";
        private static readonly Selector sel_bufferStructType = "bufferStructType";
        private static readonly Selector sel_bufferPointerType = "bufferPointerType";
        private static readonly Selector sel_threadgroupMemoryAlignment = "threadgroupMemoryAlignment";
        private static readonly Selector sel_threadgroupMemoryDataSize = "threadgroupMemoryDataSize";
        private static readonly Selector sel_textureType = "textureType";
        private static readonly Selector sel_textureDataType = "textureDataType";
        private static readonly Selector sel_isDepthTexture = "isDepthTexture";
        private static readonly Selector sel_arrayLength = "arrayLength";
    }

    public partial struct MTLBinding
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLBinding obj) => obj.NativePtr;
        public MTLBinding(in IntPtr ptr) => NativePtr = ptr;

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public MTLBindingType Type => (MTLBindingType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_type);

        public MTLBindingAccess Access => (MTLBindingAccess)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_access);

        public ulong Index => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_index);

        public bool Used => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isUsed);

        public bool Argument => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isArgument);

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_access = "access";
        private static readonly Selector sel_index = "index";
        private static readonly Selector sel_isUsed = "isUsed";
        private static readonly Selector sel_isArgument = "isArgument";
    }

    public partial struct MTLBufferBinding
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLBufferBinding obj) => obj.NativePtr;
        public static implicit operator MTLBinding(in MTLBufferBinding obj) => new MTLBinding(obj.NativePtr);
        public static implicit operator MTLBufferBinding(in MTLBinding obj) => new MTLBufferBinding(obj.NativePtr);

        public MTLBufferBinding(in IntPtr ptr) => NativePtr = ptr;

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public MTLBindingType Type => (MTLBindingType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_type);

        public MTLBindingAccess Access => (MTLBindingAccess)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_access);

        public ulong Index => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_index);

        public bool Used => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isUsed);

        public bool Argument => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isArgument);
        public ulong BufferAlignment => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_bufferAlignment);

        public ulong BufferDataSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_bufferDataSize);

        public MTLDataType BufferDataType => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_bufferDataType);

        public MTLStructType BufferStructType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_bufferStructType));

        public MTLPointerType BufferPointerType => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_bufferPointerType));

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_access = "access";
        private static readonly Selector sel_index = "index";
        private static readonly Selector sel_isUsed = "isUsed";
        private static readonly Selector sel_isArgument = "isArgument";
        private static readonly Selector sel_bufferAlignment = "bufferAlignment";
        private static readonly Selector sel_bufferDataSize = "bufferDataSize";
        private static readonly Selector sel_bufferDataType = "bufferDataType";
        private static readonly Selector sel_bufferStructType = "bufferStructType";
        private static readonly Selector sel_bufferPointerType = "bufferPointerType";
    }

    public partial struct MTLThreadgroupBinding
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLThreadgroupBinding obj) => obj.NativePtr;
        public static implicit operator MTLBinding(in MTLThreadgroupBinding obj) => new MTLBinding(obj.NativePtr);
        public static implicit operator MTLThreadgroupBinding(in MTLBinding obj) => new MTLThreadgroupBinding(obj.NativePtr);

        public MTLThreadgroupBinding(in IntPtr ptr) => NativePtr = ptr;

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public MTLBindingType Type => (MTLBindingType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_type);

        public MTLBindingAccess Access => (MTLBindingAccess)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_access);

        public ulong Index => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_index);

        public bool Used => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isUsed);

        public bool Argument => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isArgument);
        public ulong ThreadgroupMemoryAlignment => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_threadgroupMemoryAlignment);

        public ulong ThreadgroupMemoryDataSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_threadgroupMemoryDataSize);

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_access = "access";
        private static readonly Selector sel_index = "index";
        private static readonly Selector sel_isUsed = "isUsed";
        private static readonly Selector sel_isArgument = "isArgument";
        private static readonly Selector sel_threadgroupMemoryAlignment = "threadgroupMemoryAlignment";
        private static readonly Selector sel_threadgroupMemoryDataSize = "threadgroupMemoryDataSize";
    }

    public partial struct MTLTextureBinding
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLTextureBinding obj) => obj.NativePtr;
        public static implicit operator MTLBinding(in MTLTextureBinding obj) => new MTLBinding(obj.NativePtr);
        public static implicit operator MTLTextureBinding(in MTLBinding obj) => new MTLTextureBinding(obj.NativePtr);

        public MTLTextureBinding(in IntPtr ptr) => NativePtr = ptr;

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public MTLBindingType Type => (MTLBindingType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_type);

        public MTLBindingAccess Access => (MTLBindingAccess)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_access);

        public ulong Index => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_index);

        public bool Used => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isUsed);

        public bool Argument => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isArgument);
        public MTLTextureType TextureType => (MTLTextureType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_textureType);

        public MTLDataType TextureDataType => (MTLDataType)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_textureDataType);

        public bool DepthTexture => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isDepthTexture);

        public ulong ArrayLength => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_arrayLength);

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_access = "access";
        private static readonly Selector sel_index = "index";
        private static readonly Selector sel_isUsed = "isUsed";
        private static readonly Selector sel_isArgument = "isArgument";
        private static readonly Selector sel_textureType = "textureType";
        private static readonly Selector sel_textureDataType = "textureDataType";
        private static readonly Selector sel_isDepthTexture = "isDepthTexture";
        private static readonly Selector sel_arrayLength = "arrayLength";
    }

    public partial struct MTLObjectPayloadBinding
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLObjectPayloadBinding obj) => obj.NativePtr;
        public static implicit operator MTLBinding(in MTLObjectPayloadBinding obj) => new MTLBinding(obj.NativePtr);
        public static implicit operator MTLObjectPayloadBinding(in MTLBinding obj) => new MTLObjectPayloadBinding(obj.NativePtr);

        public MTLObjectPayloadBinding(in IntPtr ptr) => NativePtr = ptr;

        public NSString Name => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));

        public MTLBindingType Type => (MTLBindingType)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_type);

        public MTLBindingAccess Access => (MTLBindingAccess)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_access);

        public ulong Index => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_index);

        public bool Used => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isUsed);

        public bool Argument => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isArgument);
        public ulong ObjectPayloadAlignment => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_objectPayloadAlignment);

        public ulong ObjectPayloadDataSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_objectPayloadDataSize);

        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_type = "type";
        private static readonly Selector sel_access = "access";
        private static readonly Selector sel_index = "index";
        private static readonly Selector sel_isUsed = "isUsed";
        private static readonly Selector sel_isArgument = "isArgument";
        private static readonly Selector sel_objectPayloadAlignment = "objectPayloadAlignment";
        private static readonly Selector sel_objectPayloadDataSize = "objectPayloadDataSize";
    }
}
