namespace Apple.Metal
{
    public struct Bool8
    {
        public readonly byte Value;

        public Bool8(in byte value)
        {
            Value = value;
        }

        public Bool8(in bool value)
        {
            Value = value ? (byte)1 : (byte)0;
        }

        public static implicit operator bool(in Bool8 b) => b.Value != 0;
        public static implicit operator byte(in Bool8 b) => b.Value;
        public static implicit operator Bool8(in bool b) => new Bool8(b);
    }
}