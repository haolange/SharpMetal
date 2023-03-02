namespace Apple.Metal
{
    public struct MTLRegion
    {
        public MTLOrigin origin;
        public MTLSize size;

        public MTLRegion(in MTLOrigin origin, in MTLSize size)
        {
            this.origin = origin;
            this.size = size;
        }
    }
}