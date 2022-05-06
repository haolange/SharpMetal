namespace Apple.Metal
{
    public struct MTLViewport
    {
        public double originX;
        public double originY;
        public double width;
        public double height;
        public double znear;
        public double zfar;

        public MTLViewport(in double originX, in double originY, in double width, in double height, in double znear, in double zfar)
        {
            this.originX = originX;
            this.originY = originY;
            this.width = width;
            this.height = height;
            this.znear = znear;
            this.zfar = zfar;
        }
    }
}