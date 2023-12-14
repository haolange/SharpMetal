using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLFunctionStitchingAttribute
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLFunctionStitchingAttribute obj) => obj.NativePtr;
        public MTLFunctionStitchingAttribute(in IntPtr ptr) => NativePtr = ptr;
    }

    public partial struct MTLFunctionStitchingAttributeAlwaysInline
    {
        public IntPtr NativePtr;

        public MTLFunctionStitchingAttributeAlwaysInline(in IntPtr ptr) => NativePtr = ptr;

        public static MTLFunctionStitchingAttributeAlwaysInline New() => s_class.AllocInit<MTLFunctionStitchingAttributeAlwaysInline>();

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLFunctionStitchingAttributeAlwaysInline));
        public static implicit operator IntPtr(in MTLFunctionStitchingAttributeAlwaysInline obj) => obj.NativePtr;
        public static implicit operator MTLFunctionStitchingAttribute(in MTLFunctionStitchingAttributeAlwaysInline obj) => new MTLFunctionStitchingAttribute(obj.NativePtr);
        public static implicit operator MTLFunctionStitchingAttributeAlwaysInline(in MTLFunctionStitchingAttribute obj) => new MTLFunctionStitchingAttributeAlwaysInline(obj.NativePtr);
    }

    public partial struct MTLFunctionStitchingNode
    {
        public IntPtr NativePtr;

        public MTLFunctionStitchingNode(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTLFunctionStitchingNode obj) => obj.NativePtr;
    }

    public partial struct MTLFunctionStitchingInputNode
    {
        public IntPtr NativePtr;

        public MTLFunctionStitchingInputNode(in IntPtr ptr) => NativePtr = ptr;

        public static MTLFunctionStitchingInputNode New() => s_class.AllocInit<MTLFunctionStitchingInputNode>();

        public ulong ArgumentIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_argumentIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setArgumentIndex, value);
        }

        public MTLFunctionStitchingInputNode Init(in ulong argument)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithArgumentIndex, argument));
        }

        public static implicit operator IntPtr(in MTLFunctionStitchingInputNode obj) => obj.NativePtr;
        public static implicit operator MTLFunctionStitchingNode(in MTLFunctionStitchingInputNode obj) => new MTLFunctionStitchingNode(obj.NativePtr);
        public static implicit operator MTLFunctionStitchingInputNode(in MTLFunctionStitchingNode obj) => new MTLFunctionStitchingInputNode(obj.NativePtr);

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLFunctionStitchingInputNode));
        private static readonly Selector sel_argumentIndex = "argumentIndex";
        private static readonly Selector sel_setArgumentIndex = "setArgumentIndex:";
        private static readonly Selector sel_initWithArgumentIndex = "initWithArgumentIndex:";
    }

    public partial struct MTLFunctionStitchingFunctionNode
    {
        public IntPtr NativePtr;

        public MTLFunctionStitchingFunctionNode(in IntPtr ptr) => NativePtr = ptr;

        public static MTLFunctionStitchingFunctionNode New() => s_class.AllocInit<MTLFunctionStitchingFunctionNode>();

        public NSString Name
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_name));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setName, value);
        }

        public NSArray Arguments
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_arguments));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setArguments, value);
        }

        public NSArray ControlDependencies
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_controlDependencies));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setControlDependencies, value);
        }

        public MTLFunctionStitchingFunctionNode Init(in NSString name, in NSArray arguments, in NSArray controlDependencies)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithNameargumentscontrolDependencies, name, arguments, controlDependencies));
        }

        public static implicit operator IntPtr(in MTLFunctionStitchingFunctionNode obj) => obj.NativePtr;
        public static implicit operator MTLFunctionStitchingNode(in MTLFunctionStitchingFunctionNode obj) => new MTLFunctionStitchingNode(obj.NativePtr);
        public static implicit operator MTLFunctionStitchingFunctionNode(in MTLFunctionStitchingNode obj) => new MTLFunctionStitchingFunctionNode(obj.NativePtr);

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLFunctionStitchingFunctionNode));
        private static readonly Selector sel_name = "name";
        private static readonly Selector sel_setName = "setName:";
        private static readonly Selector sel_arguments = "arguments";
        private static readonly Selector sel_setArguments = "setArguments:";
        private static readonly Selector sel_controlDependencies = "controlDependencies";
        private static readonly Selector sel_setControlDependencies = "setControlDependencies:";
        private static readonly Selector sel_initWithNameargumentscontrolDependencies = "initWithName:arguments:controlDependencies:";
    }

    public partial struct MTLFunctionStitchingGraph
    {
        public IntPtr NativePtr;

        public MTLFunctionStitchingGraph(in IntPtr ptr) => NativePtr = ptr;

        public static MTLFunctionStitchingGraph New() => s_class.AllocInit<MTLFunctionStitchingGraph>();

        public NSString FunctionName
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_functionName));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctionName, value);
        }

        public NSArray Nodes
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_nodes));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setNodes, value);
        }

        public MTLFunctionStitchingFunctionNode OutputNode
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_outputNode));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setOutputNode, value);
        }

        public NSArray Attributes
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_attributes));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setAttributes, value);
        }

        public MTLFunctionStitchingGraph Init(in NSString functionName, in NSArray nodes, in MTLFunctionStitchingFunctionNode outputNode, in NSArray attributes)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithFunctionNamenodesoutputNodeattributes, functionName, nodes, outputNode, attributes));
        }

        public static implicit operator IntPtr(in MTLFunctionStitchingGraph obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLFunctionStitchingGraph));
        private static readonly Selector sel_functionName = "functionName";
        private static readonly Selector sel_setFunctionName = "setFunctionName:";
        private static readonly Selector sel_nodes = "nodes";
        private static readonly Selector sel_setNodes = "setNodes:";
        private static readonly Selector sel_outputNode = "outputNode";
        private static readonly Selector sel_setOutputNode = "setOutputNode:";
        private static readonly Selector sel_attributes = "attributes";
        private static readonly Selector sel_setAttributes = "setAttributes:";
        private static readonly Selector sel_initWithFunctionNamenodesoutputNodeattributes = "initWithFunctionName:nodes:outputNode:attributes:";
    }

    public partial struct MTLStitchedLibraryDescriptor
    {
        public IntPtr NativePtr;
        
        public MTLStitchedLibraryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTLStitchedLibraryDescriptor New() => s_class.AllocInit<MTLStitchedLibraryDescriptor>();

        public NSArray FunctionGraphs
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_functionGraphs));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctionGraphs, value);
        }

        public NSArray Functions
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_functions));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setFunctions, value);
        }

        public static implicit operator IntPtr(in MTLStitchedLibraryDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTLStitchedLibraryDescriptor));
        private static readonly Selector sel_functionGraphs = "functionGraphs";
        private static readonly Selector sel_setFunctionGraphs = "setFunctionGraphs:";
        private static readonly Selector sel_functions = "functions";
        private static readonly Selector sel_setFunctions = "setFunctions:";
    }
}
