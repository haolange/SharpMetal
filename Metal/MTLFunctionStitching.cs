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

        public static implicit operator IntPtr(in MTLFunctionStitchingAttributeAlwaysInline obj) => obj.NativePtr;
        public static implicit operator MTLFunctionStitchingAttribute(in MTLFunctionStitchingAttributeAlwaysInline obj) => new MTLFunctionStitchingAttribute(obj.NativePtr);
        public static implicit operator MTLFunctionStitchingAttributeAlwaysInline(in MTLFunctionStitchingAttribute obj) => new MTLFunctionStitchingAttributeAlwaysInline(obj.NativePtr);

        public MTLFunctionStitchingAttributeAlwaysInline(in IntPtr ptr) => NativePtr = ptr;

        public MTLFunctionStitchingAttributeAlwaysInline()
        {
            var cls = new ObjectiveCClass("MTLFunctionStitchingAttributeAlwaysInline");
            NativePtr = cls.AllocInit();
        }
    }

    public partial struct MTLFunctionStitchingNode
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in MTLFunctionStitchingNode obj) => obj.NativePtr;
        public MTLFunctionStitchingNode(in IntPtr ptr) => NativePtr = ptr;
    }

    public partial struct MTLFunctionStitchingInputNode
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLFunctionStitchingInputNode obj) => obj.NativePtr;
        public static implicit operator MTLFunctionStitchingNode(in MTLFunctionStitchingInputNode obj) => new MTLFunctionStitchingNode(obj.NativePtr);
        public static implicit operator MTLFunctionStitchingInputNode(in MTLFunctionStitchingNode obj) => new MTLFunctionStitchingInputNode(obj.NativePtr);

        public MTLFunctionStitchingInputNode(in IntPtr ptr) => NativePtr = ptr;

        public MTLFunctionStitchingInputNode()
        {
            var cls = new ObjectiveCClass("MTLFunctionStitchingInputNode");
            NativePtr = cls.AllocInit();
        }

        public ulong ArgumentIndex
        {
            get => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_argumentIndex);
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setArgumentIndex, value);
        }

        public MTLFunctionStitchingInputNode Init(in ulong argument)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithArgumentIndex, argument));
        }

        private static readonly Selector sel_argumentIndex = "argumentIndex";
        private static readonly Selector sel_setArgumentIndex = "setArgumentIndex:";
        private static readonly Selector sel_initWithArgumentIndex = "initWithArgumentIndex:";
    }

    public partial struct MTLFunctionStitchingFunctionNode
    {
        public IntPtr NativePtr;

        public static implicit operator IntPtr(in MTLFunctionStitchingFunctionNode obj) => obj.NativePtr;
        public static implicit operator MTLFunctionStitchingNode(in MTLFunctionStitchingFunctionNode obj) => new MTLFunctionStitchingNode(obj.NativePtr);
        public static implicit operator MTLFunctionStitchingFunctionNode(in MTLFunctionStitchingNode obj) => new MTLFunctionStitchingFunctionNode(obj.NativePtr);
        public MTLFunctionStitchingFunctionNode(in IntPtr ptr) => NativePtr = ptr;

        public MTLFunctionStitchingFunctionNode()
        {
            var cls = new ObjectiveCClass("MTLFunctionStitchingFunctionNode");
            NativePtr = cls.AllocInit();
        }

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
        public static implicit operator IntPtr(in MTLFunctionStitchingGraph obj) => obj.NativePtr;
        public MTLFunctionStitchingGraph(in IntPtr ptr) => NativePtr = ptr;

        public MTLFunctionStitchingGraph()
        {
            var cls = new ObjectiveCClass("MTLFunctionStitchingGraph");
            NativePtr = cls.AllocInit();
        }

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
        public static implicit operator IntPtr(in MTLStitchedLibraryDescriptor obj) => obj.NativePtr;
        public MTLStitchedLibraryDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public MTLStitchedLibraryDescriptor()
        {
            var cls = new ObjectiveCClass("MTLStitchedLibraryDescriptor");
            NativePtr = cls.AllocInit();
        }

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

        private static readonly Selector sel_functionGraphs = "functionGraphs";
        private static readonly Selector sel_setFunctionGraphs = "setFunctionGraphs:";
        private static readonly Selector sel_functions = "functions";
        private static readonly Selector sel_setFunctions = "setFunctions:";
    }
}
