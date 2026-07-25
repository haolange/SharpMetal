using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Metal
{
    public partial struct MTLLogicalToPhysicalColorAttachmentMap
    {
        public IntPtr NativePtr;

        public MTLLogicalToPhysicalColorAttachmentMap(in IntPtr ptr)
        {
            NativePtr = ptr;
        }

        public static MTLLogicalToPhysicalColorAttachmentMap New() =>
            s_class.AllocInit<MTLLogicalToPhysicalColorAttachmentMap>();

        public bool SupportsPhysicalIndexMapping =>
            new SharpMetal.Foundation.NSObject(NativePtr)
                .RespondsToSelector(
                    sel_setPhysicalIndexForLogicalIndex);

        public void SetPhysicalIndex(
            in ulong physicalIndex,
            in ulong logicalIndex)
        {
            if (!SupportsPhysicalIndexMapping)
            {
                throw new MissingMethodException(
                    "MTLLogicalToPhysicalColorAttachmentMap does not " +
                    "respond to setPhysicalIndex:forLogicalIndex:.");
            }
            ObjectiveCRuntime.objc_msgSend(
                NativePtr,
                sel_setPhysicalIndexForLogicalIndex,
                physicalIndex,
                logicalIndex);
        }

        public void Reset()
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_reset);
        }

        public static implicit operator IntPtr(
            in MTLLogicalToPhysicalColorAttachmentMap obj) =>
            obj.NativePtr;

        private static readonly ObjectiveCClass s_class =
            new ObjectiveCClass(nameof(MTLLogicalToPhysicalColorAttachmentMap));
        private static readonly Selector sel_setPhysicalIndexForLogicalIndex =
            "setPhysicalIndex:forLogicalIndex:";
        private static readonly Selector sel_reset = "reset";
    }
}
