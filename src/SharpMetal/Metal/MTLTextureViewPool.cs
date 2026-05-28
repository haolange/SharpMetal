using SharpMetal.Foundation;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLTextureViewPool
    {
        public IntPtr NativePtr;

        public MTLTextureViewPool(in IntPtr ptr) => NativePtr = ptr;

        public MTLResourceID BaseResourceID => ObjectiveCRuntime.MTLResourceID_objc_msgSend(NativePtr, sel_baseResourceID);

        public ulong ResourceViewCount => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_resourceViewCount);

        public MTLDevice Device => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_device));

        public NSString Label => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_label));

        public MTLResourceID SetTextureView(in IntPtr texture, in ulong index)
        {
            return ObjectiveCRuntime.MTLResourceID_objc_msgSend(NativePtr, sel_setTextureViewatIndex, texture, index);
        }

        public MTLResourceID SetTextureView(in IntPtr texture, in IntPtr descriptor, in ulong index)
        {
            return ObjectiveCRuntime.MTLResourceID_objc_msgSend(NativePtr, sel_setTextureViewdescriptoratIndex, texture, descriptor, index);
        }

        public MTLResourceID SetTextureViewFromBuffer(in IntPtr buffer, in IntPtr descriptor, in ulong offset, in ulong bytesPerRow, in ulong index)
        {
            return ObjectiveCRuntime.MTLResourceID_objc_msgSend(NativePtr, sel_setTextureViewFromBufferdescriptoroffsetbytesPerRowatIndex, buffer, descriptor, offset, bytesPerRow, index);
        }

        public MTLResourceID CopyResourceViewsFromPool(in IntPtr sourcePool, in NSRange sourceRange, in ulong destinationIndex)
        {
            return ObjectiveCRuntime.MTLResourceID_objc_msgSend(NativePtr, sel_copyResourceViewsFromPoolsourceRangedestinationIndex, sourcePool, sourceRange, destinationIndex);
        }

        public static implicit operator IntPtr(in MTLTextureViewPool obj) => obj.NativePtr;

        private static readonly Selector sel_baseResourceID = "baseResourceID";
        private static readonly Selector sel_resourceViewCount = "resourceViewCount";
        private static readonly Selector sel_device = "device";
        private static readonly Selector sel_label = "label";
        private static readonly Selector sel_setTextureViewatIndex = "setTextureView:atIndex:";
        private static readonly Selector sel_setTextureViewdescriptoratIndex = "setTextureView:descriptor:atIndex:";
        private static readonly Selector sel_setTextureViewFromBufferdescriptoroffsetbytesPerRowatIndex = "setTextureViewFromBuffer:descriptor:offset:bytesPerRow:atIndex:";
        private static readonly Selector sel_copyResourceViewsFromPoolsourceRangedestinationIndex = "copyResourceViewsFromPool:sourceRange:destinationIndex:";
    }
}
