using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Triangle:Shape
    {
        public Triangle(int width, int height):base (width, height)
        {
        }
        public override double CalculateSurface()
        {
            return width * height / 2;
        }
    }
}
