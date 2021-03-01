using System;
namespace FrontSurface
{
    public class FrontSurface
    {
        private int height { get; set; }
        private int length { get; set; }

        public FrontSurface(int length, int height)
        {
            this.length = length;
            this.height = height;
           
        }

        public int Surface()
        {
            this.height = height;
            this.length = length;
            int SurfaceTotal = height * length;
            return SurfaceTotal;
        }
    }
}
