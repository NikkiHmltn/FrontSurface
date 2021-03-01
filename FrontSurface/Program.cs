using System;

namespace FrontSurface
{
    class Program
    {
        static void Main(string[] args)
        {
            //challenge: create a read only property "FrontSurface" which calculates
            //the front surface based on height and length

            FrontSurface table = new FrontSurface(10, 100);
            Console.WriteLine("The surface is " + table.Surface());
        }
    }
}
