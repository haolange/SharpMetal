namespace Apple.Metal
{
    public struct CGRect
    {
        public CGPoint origin;
        public CGSize size;

        public CGRect(in CGPoint origin, in CGSize size)
        {
            this.origin = origin;
            this.size = size;
        }

        public override string ToString() => string.Format("{0}, {1}", origin, size);
    }
}