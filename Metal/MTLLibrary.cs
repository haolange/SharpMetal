using System;
using System.Runtime.InteropServices;
using static Apple.Metal.ObjectiveCRuntime;

namespace Apple.Metal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLLibrary
    {
        public readonly IntPtr NativePtr;
        public MTLLibrary(in IntPtr ptr) => NativePtr = ptr;

        public MTLFunction newFunctionWithName(string name)
        {
            NSString nameNSS = NSString.New(name);
            IntPtr function = IntPtr_objc_msgSend(NativePtr, sel_newFunctionWithName, nameNSS);
            release(nameNSS.NativePtr);
            return new MTLFunction(function);
        }

        public MTLFunction newFunctionWithNameConstantValues(string name, in MTLFunctionConstantValues constantValues)
        {
            NSString nameNSS = NSString.New(name);
            IntPtr function = IntPtr_objc_msgSend(
                NativePtr,
                sel_newFunctionWithNameConstantValues,
                nameNSS.NativePtr,
                constantValues.NativePtr,
                out NSError error);
            release(nameNSS.NativePtr);

            if (function == IntPtr.Zero)
            {
                throw new Exception($"Failed to create MTLFunction: {error.localizedDescription}");
            }

            return new MTLFunction(function);
        }

        private static readonly Selector sel_newFunctionWithName = "newFunctionWithName:";
        private static readonly Selector sel_newFunctionWithNameConstantValues = "newFunctionWithName:constantValues:error:";
    }
}