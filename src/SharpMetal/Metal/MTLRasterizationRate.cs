using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLRasterizationRateSampleArray
    {
        public IntPtr NativePtr;

        public MTLRasterizationRateSampleArray(in IntPtr ptr) => NativePtr = ptr;

        public static MTLRasterizationRateSampleArray New() => s_class.AllocInit<MTLRasterizationRateSampleArray>();

        public NSNumber Object(in ulong index)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, index));
        }

        public void SetObject(in NSNumber value, in ulong index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, value, index);
        }

        public static implicit operator IntPtr(in MTLRasterizationRateSampleArray obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRasterizationRateSampleArray));
        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    public partial struct MTLRasterizationRateLayerDescriptor
    {
        public IntPtr NativePtr;

        public MTLRasterizationRateLayerDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLRasterizationRateLayerDescriptor New() => s_class.AllocInit<MTLRasterizationRateLayerDescriptor>();

        public MTLSize SampleCount
        {
            get => ObjectiveCRuntime.MTLSize_objc_msgSend(NativePtr, sel_sampleCount);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setSampleCount, value);
        }

        public MTLSize MaxSampleCount => ObjectiveCRuntime.MTLSize_objc_msgSend(NativePtr, sel_maxSampleCount);

        public float HorizontalSampleStorage => ObjectiveCRuntime.float_objc_msgSend(NativePtr, sel_horizontalSampleStorage);

        public float VerticalSampleStorage => ObjectiveCRuntime.float_objc_msgSend(NativePtr, sel_verticalSampleStorage);

        public MTLRasterizationRateSampleArray Horizontal => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_horizontal));

        public MTLRasterizationRateSampleArray Vertical => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_vertical));

        public MTLRasterizationRateLayerDescriptor Init(in MTLSize sampleCount)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithSampleCount, sampleCount));
        }

        public MTLRasterizationRateLayerDescriptor Init(in MTLSize sampleCount, in float horizontal, in float vertical)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithSampleCounthorizontalvertical, sampleCount, horizontal, vertical));
        }

        public static implicit operator IntPtr(in MTLRasterizationRateLayerDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRasterizationRateLayerDescriptor));
        private static readonly Selector sel_initWithSampleCount = "initWithSampleCount:";
        private static readonly Selector sel_initWithSampleCounthorizontalvertical = "initWithSampleCount:horizontal:vertical:";
        private static readonly Selector sel_sampleCount = "sampleCount";
        private static readonly Selector sel_maxSampleCount = "maxSampleCount";
        private static readonly Selector sel_horizontalSampleStorage = "horizontalSampleStorage";
        private static readonly Selector sel_verticalSampleStorage = "verticalSampleStorage";
        private static readonly Selector sel_horizontal = "horizontal";
        private static readonly Selector sel_vertical = "vertical";
        private static readonly Selector sel_setSampleCount = "setSampleCount:";
    }

    public partial struct MTLRasterizationRateLayerArray
    {
        public IntPtr NativePtr;

        public MTLRasterizationRateLayerArray(in IntPtr ptr) => NativePtr = ptr;

        public static MTLRasterizationRateLayerArray New() => s_class.AllocInit<MTLRasterizationRateLayerArray>();

        public MTLRasterizationRateLayerDescriptor Object(in ulong layerIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_objectAtIndexedSubscript, layerIndex));
        }

        public void SetObject(in MTLRasterizationRateLayerDescriptor layer, in ulong layerIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setObjectatIndexedSubscript, layer, layerIndex);
        }

        public static implicit operator IntPtr(in MTLRasterizationRateLayerArray obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRasterizationRateLayerArray));
        private static readonly Selector sel_objectAtIndexedSubscript = "objectAtIndexedSubscript:";
        private static readonly Selector sel_setObjectatIndexedSubscript = "setObject:atIndexedSubscript:";
    }

    
    public partial struct MTLRasterizationRateMapDescriptor
    {
        public IntPtr NativePtr;

        public MTLRasterizationRateMapDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLRasterizationRateMapDescriptor New() => s_class.AllocInit<MTLRasterizationRateMapDescriptor>();

        public ulong LayerCount => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_layerCount);

        public MTLRasterizationRateLayerArray Layers => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_layers));

        public MTLSize ScreenSize
        {
            get => ObjectiveCRuntime.MTLSize_objc_msgSend(NativePtr, sel_screenSize);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setScreenSize, value);
        }

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public static MTLRasterizationRateMapDescriptor RasterizationRateMapDescriptor(in MTLSize screenSize)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("MTLRasterizationRateMapDescriptor"), sel_rasterizationRateMapDescriptorWithScreenSize, screenSize));
        }

        public static MTLRasterizationRateMapDescriptor RasterizationRateMapDescriptor(in MTLSize screenSize, in MTLRasterizationRateLayerDescriptor layer)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("MTLRasterizationRateMapDescriptor"), sel_rasterizationRateMapDescriptorWithScreenSizelayer, screenSize, layer));
        }

        public static MTLRasterizationRateMapDescriptor RasterizationRateMapDescriptor(in MTLSize screenSize, in ulong layerCount, in MTLRasterizationRateLayerDescriptor layers)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("MTLRasterizationRateMapDescriptor"), sel_rasterizationRateMapDescriptorWithScreenSizelayerCountlayers, screenSize, layerCount, layers));
        }

        public MTLRasterizationRateLayerDescriptor Layer(in ulong layerIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_layerAtIndex, layerIndex));
        }

        public void SetLayer(in MTLRasterizationRateLayerDescriptor layer, in ulong layerIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLayeratIndex, layer, layerIndex);
        }

        public static implicit operator IntPtr(in MTLRasterizationRateMapDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRasterizationRateMapDescriptor));
        private static readonly Selector sel_rasterizationRateMapDescriptorWithScreenSize = "rasterizationRateMapDescriptorWithScreenSize:";
        private static readonly Selector sel_rasterizationRateMapDescriptorWithScreenSizelayer = "rasterizationRateMapDescriptorWithScreenSize:layer:";
        private static readonly Selector sel_rasterizationRateMapDescriptorWithScreenSizelayerCountlayers = "rasterizationRateMapDescriptorWithScreenSize:layerCount:layers:";
        private static readonly Selector sel_layerAtIndex = "layerAtIndex:";
        private static readonly Selector sel_setLayeratIndex = "setLayer:atIndex:";
        private static readonly Selector sel_layers = "layers";
        private static readonly Selector sel_screenSize = "screenSize";
        private static readonly Selector sel_setScreenSize = "setScreenSize:";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_layerCount = "layerCount";
    }
    
    public partial struct MTLRasterizationRateMap
    {
        public IntPtr NativePtr;

        public MTLRasterizationRateMap(in IntPtr ptr) => NativePtr = ptr;

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));

        public MTLSize ScreenSize => ObjectiveCRuntime.MTLSize_objc_msgSend(NativePtr, sel_screenSize);

        public MTLSize PhysicalGranularity => ObjectiveCRuntime.MTLSize_objc_msgSend(NativePtr, sel_physicalGranularity);

        public ulong LayerCount => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_layerCount);

        public MTLSizeAndAlign ParameterBufferSizeAndAlign => ObjectiveCRuntime.MTLSizeAndAlign_objc_msgSend(NativePtr, sel_parameterBufferSizeAndAlign);

        public void CopyParameterDataToBuffer(in MTLBuffer buffer, in ulong offset)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_copyParameterDataToBufferoffset, buffer, offset);
        }

        public MTLSize PhysicalSize(in ulong layerIndex)
        {
            return ObjectiveCRuntime.MTLSize_objc_msgSend(NativePtr, sel_physicalSizeForLayer, layerIndex);
        }

        public IntPtr MapScreenToPhysicalCoordinates(in IntPtr screenCoordinates, ulong layerIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_mapScreenToPhysicalCoordinatesforLayer, screenCoordinates, layerIndex));
        }

        public IntPtr MapPhysicalToScreenCoordinates(in IntPtr physicalCoordinates, ulong layerIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_mapPhysicalToScreenCoordinatesforLayer, physicalCoordinates, layerIndex));
        }

        public static implicit operator IntPtr(in MTLRasterizationRateMap obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLRasterizationRateMap));
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_screenSize = "screenSize";
        private static readonly Selector sel_physicalGranularity = "physicalGranularity";
        private static readonly Selector sel_layerCount = "layerCount";
        private static readonly Selector sel_parameterBufferSizeAndAlign = "parameterBufferSizeAndAlign";
        private static readonly Selector sel_copyParameterDataToBufferoffset = "copyParameterDataToBuffer:offset:";
        private static readonly Selector sel_physicalSizeForLayer = "physicalSizeForLayer:";
        private static readonly Selector sel_mapScreenToPhysicalCoordinatesforLayer = "mapScreenToPhysicalCoordinates:forLayer:";
        private static readonly Selector sel_mapPhysicalToScreenCoordinatesforLayer = "mapPhysicalToScreenCoordinates:forLayer:";
    }
}
