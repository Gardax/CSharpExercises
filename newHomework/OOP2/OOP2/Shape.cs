using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    abstract class Shape
    {
        public int  width{get; set;}
        public int height { get; set; }
        public Shape(int height)
        {
            this.height = height;
            this.width = height;
        }
        public Shape(int width, int height)
        {
            this.height = height;
            this.width = width;
        }
        public abstract double CalculateSurface();
    }
}
