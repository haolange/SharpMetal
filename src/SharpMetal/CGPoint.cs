namespace Apple.Metal
{
    public struct CGPoint
    {
        public CGFloat x;
        public CGFloat y;

        public CGPoint(in double x, in double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => string.Format("({0},{1})", x, y);
    }
}