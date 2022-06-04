using System;

namespace Apple.Metal
{
    public struct ObjectiveCMethod
    {
        public readonly IntPtr NativePtr;
        public ObjectiveCMethod(in IntPtr ptr) => NativePtr = ptr;
        public static implicit operator IntPtr(in ObjectiveCMethod method) => method.NativePtr;
        public static implicit operator ObjectiveCMethod(in IntPtr ptr) => new ObjectiveCMethod(ptr);

        public Selector GetSelector() => ObjectiveCRuntime.method_getName(this);
        public string GetName() => GetSelector().Name;
    }
}