using System.Diagnostics;
using SharpMetal.ObjectiveCCore;

namespace SharpMetal.Foundation
{
    public enum NSStringEncoding : ulong
    {
        ASCII = 1,
        NEXTSTEP = 2,
        JapaneseEUC = 3,
        UTF8 = 4,
        ISOLatin1 = 5,
        Symbol = 6,
        NonLossyASCII = 7,
        ShiftJIS = 8,
        ISOLatin2 = 9,
        Unicode = 10,
        WindowsCP1251 = 11,
        WindowsCP1252 = 12,
        WindowsCP1253 = 13,
        WindowsCP1254 = 14,
        WindowsCP1250 = 15,
        ISO2022JP = 21,
        MacOSRoman = 30,
        UTF16 = Unicode,
        UTF16BigEndian = 0x90000100,
        UTF16LittleEndian = 0x94000100,
        UTF32 = 0x8c000100,
        UTF32BigEndian = 0x98000100,
        UTF32LittleEndian = 0x9c000100,
    }

    public enum NSStringCompareOptions : ulong
    {
        CaseInsensitiveSearch = 1,
        LiteralSearch = 2,
        BackwardsSearch = 4,
        AnchoredSearch = 8,
        NumericSearch = 64,
        DiacriticInsensitiveSearch = 128,
        WidthInsensitiveSearch = 256,
        ForcedOrderingSearch = 512,
        RegularExpressionSearch = 1024,
    }

    internal unsafe sealed class NSStringDebugView
    {
        NSString m_Target;

        public NSStringDebugView(NSString target)
        {
            m_Target = target;
        }

        public string StringValue
        {
            get
            {
                return m_Target.ToString();
            }
        }
    }

    [DebuggerTypeProxy(typeof(NSStringDebugView))]
    public unsafe partial struct NSString
    {
        public IntPtr NativePtr;

        public NSString(in IntPtr ptr) => NativePtr = ptr;

        public NSString(string s)
        {
            NativePtr = s_class.AllocInit<NSString>();

            fixed (char* utf16Ptr = s)
            {
                UIntPtr length = (UIntPtr)s.Length;
                IntPtr newString = ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithCharacters, (IntPtr)utf16Ptr, length);
            }
        }

        public static NSString New() => s_class.AllocInit<NSString>();

        public ulong Length => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_length);

        public ushort Utf8String => ObjectiveCRuntime.ushort_objc_msgSend(NativePtr, sel_UTF8String);

        public ushort FileSystemRepresentation => ObjectiveCRuntime.ushort_objc_msgSend(NativePtr, sel_fileSystemRepresentation);

        public override string ToString()
        {
            //ushort utf8Ptr = ObjectiveCRuntime.ushort_objc_msgSend(NativePtr, sel_UTF8String);
            //return Encoding.UTF8.GetString((byte*)&utf8Ptr, (int)Length);

            byte* utf8Ptr = ObjectiveCRuntime.bytePtr_objc_msgSend(NativePtr, sel_UTF8String);
            return NSUtil.GetUtf8String(utf8Ptr);
        }

        public static NSString String(in NSString pString)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSString"), sel_stringWithString, pString));
        }

        public static NSString String(in ushort pString, in NSStringEncoding encoding)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(new ObjectiveCClass("NSString"), sel_stringWithCStringencoding, pString, (ulong)encoding));
        }

        public NSString Init(in NSString pString)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithString, pString));
        }

        public NSString Init(in ushort pString, in NSStringEncoding encoding)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithCStringencoding, pString, (ulong)encoding));
        }

        public NSString Init(in IntPtr pBytes, in ulong len, in NSStringEncoding encoding, in bool freeBuffer)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_initWithBytesNoCopylengthencodingfreeWhenDone, pBytes, len, (ulong)encoding, freeBuffer));
        }

        public ushort Character(in ulong index)
        {
            return ObjectiveCRuntime.ushort_objc_msgSend(NativePtr, sel_characterAtIndex, index);
        }

        public ushort CString(in NSStringEncoding encoding)
        {
            return ObjectiveCRuntime.ushort_objc_msgSend(NativePtr, sel_cStringUsingEncoding, (ulong)encoding);
        }

        public ulong MaximumLengthOfBytes(in NSStringEncoding encoding)
        {
            return ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maximumLengthOfBytesUsingEncoding, (ulong)encoding);
        }

        public ulong LengthOfBytes(in NSStringEncoding encoding)
        {
            return ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_maximumLengthOfBytesUsingEncoding, (ulong)encoding);
        }

        public bool IsEqualToString(in NSString pString)
        {
            return ObjectiveCRuntime.bool_objc_msgSend(NativePtr, sel_isEqualToString, pString);
        }

        public NSRange RangeOfString(in NSString pString, in NSStringCompareOptions options)
        {
            return ObjectiveCRuntime.NSRange_objc_msgSend(NativePtr, sel_rangeOfStringoptions, pString, (ulong)options);
        }

        public NSString StringByAppendingString(in NSString pString)
        {
            return new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_stringByAppendingString, pString));
        }

        public NSComparisonResult CaseInsensitiveCompare(in NSString pString)
        {
            return (NSComparisonResult)ObjectiveCRuntime.long_objc_msgSend(NativePtr, sel_caseInsensitiveCompare, pString);
        }

        public static implicit operator IntPtr(in NSString obj) => obj.NativePtr;

        private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(NSString));
        private static readonly Selector sel_string = "string";
        private static readonly Selector sel_stringWithString = "stringWithString:";
        private static readonly Selector sel_initWithCharacters = "initWithCharacters:length:";
        private static readonly Selector sel_stringWithCStringencoding = "stringWithCString:encoding:";
        private static readonly Selector sel_initWithString = "initWithString:";
        private static readonly Selector sel_initWithCStringencoding = "initWithCString:encoding:";
        private static readonly Selector sel_initWithBytesNoCopylengthencodingfreeWhenDone = "initWithBytesNoCopy:length:encoding:freeWhenDone:";
        private static readonly Selector sel_characterAtIndex = "characterAtIndex:";
        private static readonly Selector sel_length = "length";
        private static readonly Selector sel_cStringUsingEncoding = "cStringUsingEncoding:";
        private static readonly Selector sel_UTF8String = "UTF8String";
        private static readonly Selector sel_maximumLengthOfBytesUsingEncoding = "maximumLengthOfBytesUsingEncoding:";
        private static readonly Selector sel_lengthOfBytesUsingEncoding = "lengthOfBytesUsingEncoding:";
        private static readonly Selector sel_isEqualToString = "isEqualToString:";
        private static readonly Selector sel_rangeOfStringoptions = "rangeOfString:options:";
        private static readonly Selector sel_fileSystemRepresentation = "fileSystemRepresentation";
        private static readonly Selector sel_stringByAppendingString = "stringByAppendingString:";
        private static readonly Selector sel_caseInsensitiveCompare = "caseInsensitiveCompare:";
    }
}
