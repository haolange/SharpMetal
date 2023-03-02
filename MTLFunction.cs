using static Apple.Metal.ObjectiveCRuntime;
using System;

namespace Apple.Metal
{
    public struct MTLFunction
    {
        public readonly IntPtr NativePtr;
        public MTLFunction(in IntPtr ptr) => NativePtr = ptr;

        public NSDictionary functionConstantsDictionary => objc_msgSend<NSDictionary>(NativePtr, sel_functionConstantsDictionary);

        private static readonly Selector sel_functionConstantsDictionary = "functionConstantsDictionary";
    }
}