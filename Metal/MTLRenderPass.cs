using SharpMetal.ObjectiveCCore;
using System.Runtime.InteropServices;

namespace SharpMetal.Metal
{
    public enum MTLLoadAction : ulong
    {
        DontCare = 0,
        Load = 1,
        Clear = 2,
    }

    public enum MTLStoreAction : ulong
    {
        DontCare = 0,
        Store = 1,
        MultisampleResolve = 2,
        StoreAndMultisampleResolve = 3,
        Unknown = 4,
        CustomSampleDepthStore = 5,
    }

    public enum MTLStoreActionOptions : ulong
    {
        None = 0,
        ValidMask = 1,
        CustomSamplePositions = 1,
    }

    public enum MTLMultisampleDepthResolveFilter : ulong
    {
        Sample0 = 0,
        Min = 1,
        Max = 2,
    }

    public enum MTLMultisampleStencilResolveFilter : ulong
    {
        Sample0 = 0,
        DepthResolvedSample = 1,
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLClearColor
    {
        public double red;
        public double green;
        public double blue;
        public double alpha;

        public MTLClearColor(in double r, in double g, in double b, in double a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }
    }

    public partial struct MTLRenderPassAttachmentDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLRenderPassAttachmentDescriptor obj) => obj.NativePtr;
        public MTLRenderPassAttachmentDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLRenderPassAttachmentDescriptor New() => s_class.AllocInit<MTLRenderPassAttachmentDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRenderPassAttachmentDescriptor));

        public MTLTexture Texture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_texture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTexture, value);
        }

        public ulong Level
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_level);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLevel, value);
        }

        public ulong Slice
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_slice);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSlice, value);
        }

        public ulong DepthPlane
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_depthPlane);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthPlane, value);
        }

        public MTLTexture ResolveTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_resolveTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveTexture, value);
        }

        public ulong ResolveLevel
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveLevel);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveLevel, value);
        }

        public ulong ResolveSlice
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveSlice);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveSlice, value);
        }

        public ulong ResolveDepthPlane
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveDepthPlane);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveDepthPlane, value);
        }

        public MTLLoadAction LoadAction
        {
            get => (MTLLoadAction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_loadAction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLoadAction, (ulong)value);
        }

        public MTLStoreAction StoreAction
        {
            get => (MTLStoreAction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storeAction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStoreAction, (ulong)value);
        }

        public MTLStoreActionOptions StoreActionOptions
        {
            get => (MTLStoreActionOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storeActionOptions);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStoreActionOptions, (ulong)value);
        }

        private static readonly Selector sel_texture = "texture";
        private static readonly Selector sel_setTexture = "setTexture:";
        private static readonly Selector sel_level = "level";
        private static readonly Selector sel_setLevel = "setLevel:";
        private static readonly Selector sel_slice = "slice";
        private static readonly Selector sel_setSlice = "setSlice:";
        private static readonly Selector sel_depthPlane = "depthPlane";
        private static readonly Selector sel_setDepthPlane = "setDepthPlane:";
        private static readonly Selector sel_resolveTexture = "resolveTexture";
        private static readonly Selector sel_setResolveTexture = "setResolveTexture:";
        private static readonly Selector sel_resolveLevel = "resolveLevel";
        private static readonly Selector sel_setResolveLevel = "setResolveLevel:";
        private static readonly Selector sel_resolveSlice = "resolveSlice";
        private static readonly Selector sel_setResolveSlice = "setResolveSlice:";
        private static readonly Selector sel_resolveDepthPlane = "resolveDepthPlane";
        private static readonly Selector sel_setResolveDepthPlane = "setResolveDepthPlane:";
        private static readonly Selector sel_loadAction = "loadAction";
        private static readonly Selector sel_setLoadAction = "setLoadAction:";
        private static readonly Selector sel_storeAction = "storeAction";
        private static readonly Selector sel_setStoreAction = "setStoreAction:";
        private static readonly Selector sel_storeActionOptions = "storeActionOptions";
        private static readonly Selector sel_setStoreActionOptions = "setStoreActionOptions:";
    }

    public partial struct MTLRenderPassColorAttachmentDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLRenderPassColorAttachmentDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLRenderPassAttachmentDescriptor(in MTLRenderPassColorAttachmentDescriptor obj) => new MTLRenderPassAttachmentDescriptor(obj.NativePtr);
        public static implicit operator MTLRenderPassColorAttachmentDescriptor(in MTLRenderPassAttachmentDescriptor obj) => new MTLRenderPassColorAttachmentDescriptor(obj.NativePtr);

        public MTLRenderPassColorAttachmentDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLRenderPassColorAttachmentDescriptor New() => s_class.AllocInit<MTLRenderPassColorAttachmentDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRenderPassColorAttachmentDescriptor));

        public MTLTexture Texture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_texture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTexture, value);
        }

        public ulong Level
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_level);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLevel, value);
        }

        public ulong Slice
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_slice);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSlice, value);
        }

        public ulong DepthPlane
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_depthPlane);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthPlane, value);
        }

        public MTLTexture ResolveTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_resolveTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveTexture, value);
        }

        public ulong ResolveLevel
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveLevel);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveLevel, value);
        }

        public ulong ResolveSlice
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveSlice);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveSlice, value);
        }

        public ulong ResolveDepthPlane
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveDepthPlane);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveDepthPlane, value);
        }

        public MTLLoadAction LoadAction
        {
            get => (MTLLoadAction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_loadAction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLoadAction, (ulong)value);
        }

        public MTLStoreAction StoreAction
        {
            get => (MTLStoreAction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storeAction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStoreAction, (ulong)value);
        }

        public MTLStoreActionOptions StoreActionOptions
        {
            get => (MTLStoreActionOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storeActionOptions);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStoreActionOptions, (ulong)value);
        }

        public MTLClearColor ClearColor
        {
            get => ObjectiveCRuntime.MTLClearColor_objc_msgSend(NativePtr, sel_clearColor);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setClearColor, value);
        }

        private static readonly Selector sel_texture = "texture";
        private static readonly Selector sel_setTexture = "setTexture:";
        private static readonly Selector sel_level = "level";
        private static readonly Selector sel_setLevel = "setLevel:";
        private static readonly Selector sel_slice = "slice";
        private static readonly Selector sel_setSlice = "setSlice:";
        private static readonly Selector sel_depthPlane = "depthPlane";
        private static readonly Selector sel_setDepthPlane = "setDepthPlane:";
        private static readonly Selector sel_resolveTexture = "resolveTexture";
        private static readonly Selector sel_setResolveTexture = "setResolveTexture:";
        private static readonly Selector sel_resolveLevel = "resolveLevel";
        private static readonly Selector sel_setResolveLevel = "setResolveLevel:";
        private static readonly Selector sel_resolveSlice = "resolveSlice";
        private static readonly Selector sel_setResolveSlice = "setResolveSlice:";
        private static readonly Selector sel_resolveDepthPlane = "resolveDepthPlane";
        private static readonly Selector sel_setResolveDepthPlane = "setResolveDepthPlane:";
        private static readonly Selector sel_loadAction = "loadAction";
        private static readonly Selector sel_setLoadAction = "setLoadAction:";
        private static readonly Selector sel_storeAction = "storeAction";
        private static readonly Selector sel_setStoreAction = "setStoreAction:";
        private static readonly Selector sel_storeActionOptions = "storeActionOptions";
        private static readonly Selector sel_setStoreActionOptions = "setStoreActionOptions:";
        private static readonly Selector sel_clearColor = "clearColor";
        private static readonly Selector sel_setClearColor = "setClearColor:";
    }

    public partial struct MTLRenderPassDepthAttachmentDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLRenderPassDepthAttachmentDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLRenderPassAttachmentDescriptor(in MTLRenderPassDepthAttachmentDescriptor obj) => new MTLRenderPassAttachmentDescriptor(obj.NativePtr);
        public static implicit operator MTLRenderPassDepthAttachmentDescriptor(in MTLRenderPassAttachmentDescriptor obj) => new MTLRenderPassDepthAttachmentDescriptor(obj.NativePtr);

        public MTLRenderPassDepthAttachmentDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLRenderPassDepthAttachmentDescriptor New() => s_class.AllocInit<MTLRenderPassDepthAttachmentDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRenderPassDepthAttachmentDescriptor));

        public MTLTexture Texture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_texture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTexture, value);
        }

        public ulong Level
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_level);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLevel, value);
        }

        public ulong Slice
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_slice);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSlice, value);
        }

        public ulong DepthPlane
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_depthPlane);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthPlane, value);
        }

        public MTLTexture ResolveTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_resolveTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveTexture, value);
        }

        public ulong ResolveLevel
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveLevel);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveLevel, value);
        }

        public ulong ResolveSlice
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveSlice);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveSlice, value);
        }

        public ulong ResolveDepthPlane
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveDepthPlane);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveDepthPlane, value);
        }

        public MTLLoadAction LoadAction
        {
            get => (MTLLoadAction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_loadAction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLoadAction, (ulong)value);
        }

        public MTLStoreAction StoreAction
        {
            get => (MTLStoreAction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storeAction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStoreAction, (ulong)value);
        }

        public MTLStoreActionOptions StoreActionOptions
        {
            get => (MTLStoreActionOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storeActionOptions);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStoreActionOptions, (ulong)value);
        }

        public double ClearDepth
        {
            get => ObjectiveCRuntime.double_objc_msgSend(NativePtr, sel_clearDepth);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setClearDepth, value);
        }

        public MTLMultisampleDepthResolveFilter DepthResolveFilter
        {
            get => (MTLMultisampleDepthResolveFilter)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_depthResolveFilter);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthResolveFilter, (ulong)value);
        }

        private static readonly Selector sel_texture = "texture";
        private static readonly Selector sel_setTexture = "setTexture:";
        private static readonly Selector sel_level = "level";
        private static readonly Selector sel_setLevel = "setLevel:";
        private static readonly Selector sel_slice = "slice";
        private static readonly Selector sel_setSlice = "setSlice:";
        private static readonly Selector sel_depthPlane = "depthPlane";
        private static readonly Selector sel_setDepthPlane = "setDepthPlane:";
        private static readonly Selector sel_resolveTexture = "resolveTexture";
        private static readonly Selector sel_setResolveTexture = "setResolveTexture:";
        private static readonly Selector sel_resolveLevel = "resolveLevel";
        private static readonly Selector sel_setResolveLevel = "setResolveLevel:";
        private static readonly Selector sel_resolveSlice = "resolveSlice";
        private static readonly Selector sel_setResolveSlice = "setResolveSlice:";
        private static readonly Selector sel_resolveDepthPlane = "resolveDepthPlane";
        private static readonly Selector sel_setResolveDepthPlane = "setResolveDepthPlane:";
        private static readonly Selector sel_loadAction = "loadAction";
        private static readonly Selector sel_setLoadAction = "setLoadAction:";
        private static readonly Selector sel_storeAction = "storeAction";
        private static readonly Selector sel_setStoreAction = "setStoreAction:";
        private static readonly Selector sel_storeActionOptions = "storeActionOptions";
        private static readonly Selector sel_setStoreActionOptions = "setStoreActionOptions:";
        private static readonly Selector sel_clearDepth = "clearDepth";
        private static readonly Selector sel_setClearDepth = "setClearDepth:";
        private static readonly Selector sel_depthResolveFilter = "depthResolveFilter";
        private static readonly Selector sel_setDepthResolveFilter = "setDepthResolveFilter:";
    }

    public partial struct MTLRenderPassStencilAttachmentDescriptor
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLRenderPassStencilAttachmentDescriptor obj) => obj.NativePtr;
        public static implicit operator MTLRenderPassAttachmentDescriptor(in MTLRenderPassStencilAttachmentDescriptor obj) => new MTLRenderPassAttachmentDescriptor(obj.NativePtr);
        public static implicit operator MTLRenderPassStencilAttachmentDescriptor(in MTLRenderPassAttachmentDescriptor obj) => new MTLRenderPassStencilAttachmentDescriptor(obj.NativePtr);

        public MTLRenderPassStencilAttachmentDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLRenderPassStencilAttachmentDescriptor New() => s_class.AllocInit<MTLRenderPassStencilAttachmentDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRenderPassStencilAttachmentDescriptor));

        public MTLTexture Texture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_texture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTexture, value);
        }

        public ulong Level
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_level);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLevel, value);
        }

        public ulong Slice
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_slice);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSlice, value);
        }

        public ulong DepthPlane
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_depthPlane);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthPlane, value);
        }

        public MTLTexture ResolveTexture
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_resolveTexture));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveTexture, value);
        }

        public ulong ResolveLevel
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveLevel);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveLevel, value);
        }

        public ulong ResolveSlice
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveSlice);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveSlice, value);
        }

        public ulong ResolveDepthPlane
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resolveDepthPlane);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setResolveDepthPlane, value);
        }

        public MTLLoadAction LoadAction
        {
            get => (MTLLoadAction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_loadAction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLoadAction, (ulong)value);
        }

        public MTLStoreAction StoreAction
        {
            get => (MTLStoreAction)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storeAction);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStoreAction, (ulong)value);
        }

        public MTLStoreActionOptions StoreActionOptions
        {
            get => (MTLStoreActionOptions)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_storeActionOptions);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStoreActionOptions, (ulong)value);
        }

        public uint ClearStencil
        {
            get => ObjectiveCRuntime.uint_objc_msgSend(NativePtr, sel_clearStencil);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setClearStencil, value);
        }

        public MTLMultisampleStencilResolveFilter StencilResolveFilter
        {
            get => (MTLMultisampleStencilResolveFilter)ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_stencilResolveFilter);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStencilResolveFilter, (ulong)value);
        }

        private static readonly Selector sel_texture = "texture";
        private static readonly Selector sel_setTexture = "setTexture:";
        private static readonly Selector sel_level = "level";
        private static readonly Selector sel_setLevel = "setLevel:";
        private static readonly Selector sel_slice = "slice";
        private static readonly Selector sel_setSlice = "setSlice:";
        private static readonly Selector sel_depthPlane = "depthPlane";
        private static readonly Selector sel_setDepthPlane = "setDepthPlane:";
        private static readonly Selector sel_resolveTexture = "resolveTexture";
        private static readonly Selector sel_setResolveTexture = "setResolveTexture:";
        private static readonly Selector sel_resolveLevel = "resolveLevel";
        private static readonly Selector sel_setResolveLevel = "setResolveLevel:";
        private static readonly Selector sel_resolveSlice = "resolveSlice";
        private static readonly Selector sel_setResolveSlice = "setResolveSlice:";
        private static readonly Selector sel_resolveDepthPlane = "resolveDepthPlane";
        private static readonly Selector sel_setResolveDepthPlane = "setResolveDepthPlane:";
        private static readonly Selector sel_loadAction = "loadAction";
        private static readonly Selector sel_setLoadAction = "setLoadAction:";
        private static readonly Selector sel_storeAction = "storeAction";
        private static readonly Selector sel_setStoreAction = "setStoreAction:";
        private static readonly Selector sel_storeActionOptions = "storeActionOptions";
        private static readonly Selector sel_setStoreActionOptions = "setStoreActionOptions:";
        private static readonly Selector sel_clearStencil = "clearStencil";
        private static readonly Selector sel_setClearStencil = "setClearStencil:";
        private static readonly Selector sel_stencilResolveFilter = "stencilResolveFilter";
        private static readonly Selector sel_setStencilResolveFilter = "setStencilResolveFilter:";
    }

    public partial struct MTLRenderPassColorAttachmentDescriptorArray
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLRenderPassColorAttachmentDescriptorArray obj) => obj.NativePtr;
        public MTLRenderPassColorAttachmentDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

        public MTLRenderPassColorAttachmentDescriptor this[uint index]
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

        public static MTLRenderPassColorAttachmentDescriptor New() => s_class.AllocInit<MTLRenderPassColorAttachmentDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRenderPassColorAttachmentDescriptor));

        public MTLRenderPassColorAttachmentDescriptor Object(in ulong attachmentIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, attachmentIndex));
        }

        public void SetObject(in MTLRenderPassColorAttachmentDescriptor attachment, in ulong attachmentIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, attachment, attachmentIndex);
        }

        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    public partial struct MTLRenderPassSampleBufferAttachmentDescriptor
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLRenderPassSampleBufferAttachmentDescriptor obj) => obj.NativePtr;
        public MTLRenderPassSampleBufferAttachmentDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLRenderPassSampleBufferAttachmentDescriptor New() => s_class.AllocInit<MTLRenderPassSampleBufferAttachmentDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRenderPassSampleBufferAttachmentDescriptor));

        public MTLCounterSampleBuffer SampleBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_sampleBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSampleBuffer, value);
        }

        public ulong StartOfVertexSampleIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_startOfVertexSampleIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStartOfVertexSampleIndex, value);
        }

        public ulong EndOfVertexSampleIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_endOfVertexSampleIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setEndOfVertexSampleIndex, value);
        }

        public ulong StartOfFragmentSampleIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_startOfFragmentSampleIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStartOfFragmentSampleIndex, value);
        }

        public ulong EndOfFragmentSampleIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_endOfFragmentSampleIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setEndOfFragmentSampleIndex, value);
        }

        private static readonly Selector sel_sampleBuffer = "sampleBuffer";
        private static readonly Selector sel_setSampleBuffer = "setSampleBuffer:";
        private static readonly Selector sel_startOfVertexSampleIndex = "startOfVertexSampleIndex";
        private static readonly Selector sel_setStartOfVertexSampleIndex = "setStartOfVertexSampleIndex:";
        private static readonly Selector sel_endOfVertexSampleIndex = "endOfVertexSampleIndex";
        private static readonly Selector sel_setEndOfVertexSampleIndex = "setEndOfVertexSampleIndex:";
        private static readonly Selector sel_startOfFragmentSampleIndex = "startOfFragmentSampleIndex";
        private static readonly Selector sel_setStartOfFragmentSampleIndex = "setStartOfFragmentSampleIndex:";
        private static readonly Selector sel_endOfFragmentSampleIndex = "endOfFragmentSampleIndex";
        private static readonly Selector sel_setEndOfFragmentSampleIndex = "setEndOfFragmentSampleIndex:";
    }

    public partial struct MTLRenderPassSampleBufferAttachmentDescriptorArray
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLRenderPassSampleBufferAttachmentDescriptorArray obj) => obj.NativePtr;
        public MTLRenderPassSampleBufferAttachmentDescriptorArray(in IntPtr ptr) => NativePtr = ptr;

        public MTLRenderPassSampleBufferAttachmentDescriptor this[uint index]
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

        public static MTLRenderPassSampleBufferAttachmentDescriptor New() => s_class.AllocInit<MTLRenderPassSampleBufferAttachmentDescriptor>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRenderPassSampleBufferAttachmentDescriptor));

        public MTLRenderPassSampleBufferAttachmentDescriptor Object(in ulong attachmentIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, attachmentIndex));
        }

        public void SetObject(MTLRenderPassSampleBufferAttachmentDescriptor attachment, ulong attachmentIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, attachment, attachmentIndex);
        }

        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    public partial struct MTLRenderPassDescriptor
    {
        public IntPtr NativePtr;

        public MTLRenderPassDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLRenderPassDescriptor New() => s_class.AllocInit<MTLRenderPassDescriptor>();

        public MTLRenderPassColorAttachmentDescriptorArray ColorAttachments => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_colorAttachments));

        public MTLRenderPassDepthAttachmentDescriptor DepthAttachment
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_depthAttachment));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDepthAttachment, value);
        }

        public MTLRenderPassStencilAttachmentDescriptor StencilAttachment
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_stencilAttachment));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setStencilAttachment, value);
        }

        public MTLBuffer VisibilityResultBuffer
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_visibilityResultBuffer));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setVisibilityResultBuffer, value);
        }

        public ulong RenderTargetArrayLength
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_renderTargetArrayLength);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRenderTargetArrayLength, value);
        }

        public ulong ImageblockSampleLength
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_imageblockSampleLength);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setImageblockSampleLength, value);
        }

        public ulong ThreadgroupMemoryLength
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_threadgroupMemoryLength);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setThreadgroupMemoryLength, value);
        }

        public ulong TileWidth
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_tileWidth);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTileWidth, value);
        }

        public ulong TileHeight
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_tileHeight);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setTileHeight, value);
        }

        public ulong DefaultRasterSampleCount
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_defaultRasterSampleCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setDefaultRasterSampleCount, value);
        }

        public ulong RenderTargetWidth
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_renderTargetWidth);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRenderTargetWidth, value);
        }

        public ulong RenderTargetHeight
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_renderTargetHeight);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRenderTargetHeight, value);
        }

        public MTLRasterizationRateMap RasterizationRateMap
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_rasterizationRateMap));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setRasterizationRateMap, value);
        }

        public MTLRenderPassSampleBufferAttachmentDescriptorArray SampleBufferAttachments => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_sampleBufferAttachments));

        public void SetSamplePositions(in MTLSamplePosition positions, in ulong count)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSamplePositionscount, positions, count);
        }

        public ulong GetSamplePositions(in MTLSamplePosition positions, in ulong count)
        {
            return ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_getSamplePositionscount, positions, count);
        }

        public static implicit operator IntPtr(in MTLRenderPassDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass("MTLRenderPassDescriptor");
        private static readonly Selector sel_renderPassDescriptor = "renderPassDescriptor";
        private static readonly Selector sel_colorAttachments = "colorAttachments";
        private static readonly Selector sel_depthAttachment = "depthAttachment";
        private static readonly Selector sel_setDepthAttachment = "setDepthAttachment:";
        private static readonly Selector sel_stencilAttachment = "stencilAttachment";
        private static readonly Selector sel_setStencilAttachment = "setStencilAttachment:";
        private static readonly Selector sel_visibilityResultBuffer = "visibilityResultBuffer";
        private static readonly Selector sel_setVisibilityResultBuffer = "setVisibilityResultBuffer:";
        private static readonly Selector sel_renderTargetArrayLength = "renderTargetArrayLength";
        private static readonly Selector sel_setRenderTargetArrayLength = "setRenderTargetArrayLength:";
        private static readonly Selector sel_imageblockSampleLength = "imageblockSampleLength";
        private static readonly Selector sel_setImageblockSampleLength = "setImageblockSampleLength:";
        private static readonly Selector sel_threadgroupMemoryLength = "threadgroupMemoryLength";
        private static readonly Selector sel_setThreadgroupMemoryLength = "setThreadgroupMemoryLength:";
        private static readonly Selector sel_tileWidth = "tileWidth";
        private static readonly Selector sel_setTileWidth = "setTileWidth:";
        private static readonly Selector sel_tileHeight = "tileHeight";
        private static readonly Selector sel_setTileHeight = "setTileHeight:";
        private static readonly Selector sel_defaultRasterSampleCount = "defaultRasterSampleCount";
        private static readonly Selector sel_setDefaultRasterSampleCount = "setDefaultRasterSampleCount:";
        private static readonly Selector sel_renderTargetWidth = "renderTargetWidth";
        private static readonly Selector sel_setRenderTargetWidth = "setRenderTargetWidth:";
        private static readonly Selector sel_renderTargetHeight = "renderTargetHeight";
        private static readonly Selector sel_setRenderTargetHeight = "setRenderTargetHeight:";
        private static readonly Selector sel_setSamplePositionscount = "setSamplePositions:count:";
        private static readonly Selector sel_getSamplePositionscount = "getSamplePositions:count:";
        private static readonly Selector sel_rasterizationRateMap = "rasterizationRateMap";
        private static readonly Selector sel_setRasterizationRateMap = "setRasterizationRateMap:";
        private static readonly Selector sel_sampleBufferAttachments = "sampleBufferAttachments";
    }
}
