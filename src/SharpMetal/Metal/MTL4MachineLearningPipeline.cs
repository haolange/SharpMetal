using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTL4MachineLearningPipelineDescriptor
    {
        public IntPtr NativePtr;

        public MTL4MachineLearningPipelineDescriptor(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4MachineLearningPipelineDescriptor New() => s_class.AllocInit<MTL4MachineLearningPipelineDescriptor>();

        public static implicit operator MTL4PipelineDescriptor(in MTL4MachineLearningPipelineDescriptor obj) => new(obj.NativePtr);

        public NSString Label
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setLabel, value);
        }

        public MTL4FunctionDescriptor MachineLearningFunctionDescriptor
        {
            get => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_machineLearningFunctionDescriptor));
            set => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setMachineLearningFunctionDescriptor, value);
        }

        public void SetInputDimensions(in MTLTensorExtents dimensions, in long bufferIndex)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInputDimensionsatBufferIndex, dimensions, bufferIndex);
        }

        public void SetInputDimensions(in NSArray dimensions, in NSRange range)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setInputDimensionswithRange, dimensions, range);
        }

        public MTLTensorExtents InputDimensionsAtBufferIndex(in long bufferIndex)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_inputDimensionsAtBufferIndex, bufferIndex));
        }

        public void Reset()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_reset);
        }

        public static implicit operator IntPtr(in MTL4MachineLearningPipelineDescriptor obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4MachineLearningPipelineDescriptor));
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setLabel = "setLabel:";
        private static readonly Selector sel_machineLearningFunctionDescriptor = "machineLearningFunctionDescriptor";
        private static readonly Selector sel_setMachineLearningFunctionDescriptor = "setMachineLearningFunctionDescriptor:";
        private static readonly Selector sel_setInputDimensionsatBufferIndex = "setInputDimensions:atBufferIndex:";
        private static readonly Selector sel_setInputDimensionswithRange = "setInputDimensions:withRange:";
        private static readonly Selector sel_inputDimensionsAtBufferIndex = "inputDimensionsAtBufferIndex:";
        private static readonly Selector sel_reset = "reset";
    }

    public partial struct MTL4MachineLearningPipelineReflection
    {
        public IntPtr NativePtr;

        public MTL4MachineLearningPipelineReflection(in IntPtr ptr) => NativePtr = ptr;

        public static MTL4MachineLearningPipelineReflection New() => s_class.AllocInit<MTL4MachineLearningPipelineReflection>();

        public NSArray Bindings => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_bindings));

        public static implicit operator IntPtr(in MTL4MachineLearningPipelineReflection obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(MTL4MachineLearningPipelineReflection));
        private static readonly Selector sel_bindings = "bindings";
    }

    public partial struct MTL4MachineLearningPipelineState
    {
        public IntPtr NativePtr;

        public MTL4MachineLearningPipelineState(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4MachineLearningPipelineState obj) => obj.NativePtr;

        public NSString Label => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public MTL4MachineLearningPipelineReflection Reflection => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_reflection));

        public ulong IntermediatesHeapSize => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_intermediatesHeapSize);

        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_reflection = "reflection";
        private static readonly Selector sel_intermediatesHeapSize = "intermediatesHeapSize";
    }

    public partial struct MTL4MachineLearningCommandEncoder
    {
        public IntPtr NativePtr;

        public MTL4MachineLearningCommandEncoder(in IntPtr ptr) => NativePtr = ptr;

        public static implicit operator IntPtr(in MTL4MachineLearningCommandEncoder obj) => obj.NativePtr;

        public void SetPipelineState(in MTL4MachineLearningPipelineState pipelineState)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setPipelineState, pipelineState);
        }

        public void SetArgumentTable(in MTL4ArgumentTable argumentTable)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setArgumentTable, argumentTable);
        }

        public void DispatchNetworkWithIntermediatesHeap(in MTLHeap heap)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_dispatchNetworkWithIntermediatesHeap, heap);
        }

        private static readonly Selector sel_setPipelineState = "setPipelineState:";
        private static readonly Selector sel_setArgumentTable = "setArgumentTable:";
        private static readonly Selector sel_dispatchNetworkWithIntermediatesHeap = "dispatchNetworkWithIntermediatesHeap:";
    }
}
