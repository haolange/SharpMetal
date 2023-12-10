using System.Runtime.Versioning;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public partial struct NSValue
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSValue obj) => obj.NativePtr;
        public NSValue(in IntPtr ptr) => NativePtr = ptr;

        public NSValue()
        {
            var cls = new ObjectiveCClass("NSValue");
            NativePtr = cls.Alloc();
        }

        public ushort ObjCType => ObjectiveCRuntime.ushort_objc_msgSend(NativePtr, sel_objCType);

        public IntPtr PointerValue => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_pointerValue));

        public static NSValue Value(in IntPtr pValue, in ushort pType)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSValue"), sel_valueWithBytesobjCType, pValue, pType));
        }

        public static NSValue Value(in IntPtr pPointer)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSValue"), sel_valueWithPointer, pPointer));
        }

        public NSValue Init(in IntPtr pValue, in ushort pType)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithBytesobjCType, pValue, pType));
        }

        public NSValue Init(in IntPtr pCoder)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithCoder, pCoder));
        }

        public void GetValue(in IntPtr pValue, in ulong size)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_getValuesize, pValue, size);
        }

        public bool IsEqualToValue(in NSValue pValue)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isEqualToValue, pValue);
        }

        private static readonly Selector sel_valueWithBytesobjCType = "valueWithBytes:objCType:";
        private static readonly Selector sel_valueWithPointer = "valueWithPointer:";
        private static readonly Selector sel_initWithBytesobjCType = "initWithBytes:objCType:";
        private static readonly Selector sel_initWithCoder = "initWithCoder:";
        private static readonly Selector sel_getValuesize = "getValue:size:";
        private static readonly Selector sel_objCType = "objCType";
        private static readonly Selector sel_isEqualToValue = "isEqualToValue:";
        private static readonly Selector sel_pointerValue = "pointerValue";
    }

    public partial struct NSNumber
    {
        public IntPtr NativePtr;
        public static implicit operator IntPtr(in NSNumber obj) => obj.NativePtr;
        public NSNumber(IntPtr ptr) => NativePtr = ptr;

        public NSNumber()
        {
            var cls = new ObjectiveCClass("NSNumber");
            NativePtr = cls.Alloc();
        }

        public ushort CharValue => ObjectiveCRuntime.ushort_objc_msgSend(NativePtr, sel_charValue);

        public byte UnsignedCharValue => ObjectiveCRuntime.byte_objc_msgSend(NativePtr, sel_unsignedCharValue);

        public short ShortValue => ObjectiveCRuntime.short_objc_msgSend(NativePtr, sel_shortValue);

        public ushort UnsignedShortValue => ObjectiveCRuntime.ushort_objc_msgSend(NativePtr, sel_unsignedShortValue);

        public int IntValue => ObjectiveCRuntime.int_objc_msgSend(NativePtr, sel_intValue);

        public uint UnsignedIntValue => ObjectiveCRuntime.uint_objc_msgSend(NativePtr, sel_unsignedIntValue);

        public long LongValue => ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_longValue);

        public ulong UnsignedLongValue => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_unsignedLongValue);

        public long LongLongValue => ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_longLongValue);

        public ulong UnsignedLongLongValue => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_unsignedLongLongValue);

        public float FloatValue => ObjectiveCRuntime.float_objc_msgSend(NativePtr, sel_floatValue);

        public double DoubleValue => ObjectiveCRuntime.double_objc_msgSend(NativePtr, sel_doubleValue);

        public bool BoolValue => ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_boolValue);

        public long IntegerValue => ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_integerValue);

        public ulong UnsignedIntegerValue => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_unsignedIntegerValue);

        public NSString StringValue => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_stringValue));

        public static NSNumber Number(in ushort value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNumber"), sel_numberWithChar, value));
        }

        public static NSNumber Number(in byte value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNumber"), sel_numberWithUnsignedChar, value));
        }

        public static NSNumber Number(in short value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNumber"), sel_numberWithShort, value));
        }

        public static NSNumber Number(in int value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNumber"), sel_numberWithInt, value));
        }

        public static NSNumber Number(in uint value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNumber"), sel_numberWithUnsignedInt, value));
        }

        public static NSNumber Number(in long value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNumber"), sel_numberWithLong, value));
        }

        public static NSNumber Number(in ulong value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNumber"), sel_numberWithUnsignedLong, value));
        }

        public static NSNumber Number(in float value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNumber"), sel_numberWithFloat, value));
        }

        public static NSNumber Number(in double value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNumber"), sel_numberWithDouble, value));
        }

        public static NSNumber Number(in bool value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSNumber"), sel_numberWithBool, value));
        }

        public NSNumber Init(in IntPtr pCoder)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithCoder, pCoder));
        }

        public NSNumber Init(in ushort value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithChar, value));
        }

        public NSNumber Init(in byte value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithUnsignedChar, value));
        }

        public NSNumber Init(in short value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithShort, value));
        }

        public NSNumber Init(in int value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithInt, value));
        }

        public NSNumber Init(in uint value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithUnsignedInt, value));
        }

        public NSNumber Init(in long value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithLong, value));
        }

        public NSNumber Init(in ulong value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithUnsignedLong, value));
        }

        public NSNumber Init(in float value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithFloat, value));
        }

        public NSNumber Init(in double value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithDouble, value));
        }

        public NSNumber Init(in bool value)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithBool, value));
        }

        public NSComparisonResult Compare(in NSNumber pOtherNumber)
        {
            return (NSComparisonResult)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_compare, pOtherNumber);
        }

        public bool IsEqualToNumber(in NSNumber pNumber)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isEqualToNumber, pNumber);
        }

        public NSString DescriptionWithLocale(in NSObject pLocale)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_descriptionWithLocale, pLocale));
        }

        private static readonly Selector sel_numberWithChar = "numberWithChar:";
        private static readonly Selector sel_numberWithUnsignedChar = "numberWithUnsignedChar:";
        private static readonly Selector sel_numberWithShort = "numberWithShort:";
        private static readonly Selector sel_numberWithUnsignedShort = "numberWithUnsignedShort:";
        private static readonly Selector sel_numberWithInt = "numberWithInt:";
        private static readonly Selector sel_numberWithUnsignedInt = "numberWithUnsignedInt:";
        private static readonly Selector sel_numberWithLong = "numberWithLong:";
        private static readonly Selector sel_numberWithUnsignedLong = "numberWithUnsignedLong:";
        private static readonly Selector sel_numberWithLongLong = "numberWithLongLong:";
        private static readonly Selector sel_numberWithUnsignedLongLong = "numberWithUnsignedLongLong:";
        private static readonly Selector sel_numberWithFloat = "numberWithFloat:";
        private static readonly Selector sel_numberWithDouble = "numberWithDouble:";
        private static readonly Selector sel_numberWithBool = "numberWithBool:";
        private static readonly Selector sel_initWithCoder = "initWithCoder:";
        private static readonly Selector sel_initWithChar = "initWithChar:";
        private static readonly Selector sel_initWithUnsignedChar = "initWithUnsignedChar:";
        private static readonly Selector sel_initWithShort = "initWithShort:";
        private static readonly Selector sel_initWithUnsignedShort = "initWithUnsignedShort:";
        private static readonly Selector sel_initWithInt = "initWithInt:";
        private static readonly Selector sel_initWithUnsignedInt = "initWithUnsignedInt:";
        private static readonly Selector sel_initWithLong = "initWithLong:";
        private static readonly Selector sel_initWithUnsignedLong = "initWithUnsignedLong:";
        private static readonly Selector sel_initWithLongLong = "initWithLongLong:";
        private static readonly Selector sel_initWithUnsignedLongLong = "initWithUnsignedLongLong:";
        private static readonly Selector sel_initWithFloat = "initWithFloat:";
        private static readonly Selector sel_initWithDouble = "initWithDouble:";
        private static readonly Selector sel_initWithBool = "initWithBool:";
        private static readonly Selector sel_charValue = "charValue";
        private static readonly Selector sel_unsignedCharValue = "unsignedCharValue";
        private static readonly Selector sel_shortValue = "shortValue";
        private static readonly Selector sel_unsignedShortValue = "unsignedShortValue";
        private static readonly Selector sel_intValue = "intValue";
        private static readonly Selector sel_unsignedIntValue = "unsignedIntValue";
        private static readonly Selector sel_longValue = "longValue";
        private static readonly Selector sel_unsignedLongValue = "unsignedLongValue";
        private static readonly Selector sel_longLongValue = "longLongValue";
        private static readonly Selector sel_unsignedLongLongValue = "unsignedLongLongValue";
        private static readonly Selector sel_floatValue = "floatValue";
        private static readonly Selector sel_doubleValue = "doubleValue";
        private static readonly Selector sel_boolValue = "boolValue";
        private static readonly Selector sel_integerValue = "integerValue";
        private static readonly Selector sel_unsignedIntegerValue = "unsignedIntegerValue";
        private static readonly Selector sel_stringValue = "stringValue";
        private static readonly Selector sel_compare = "compare:";
        private static readonly Selector sel_isEqualToNumber = "isEqualToNumber:";
        private static readonly Selector sel_descriptionWithLocale = "descriptionWithLocale:";
    }
}
