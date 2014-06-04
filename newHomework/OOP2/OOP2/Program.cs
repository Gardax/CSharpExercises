using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Triangle(5,8),
                new Triangle(2,5),
                new Rectangle(4,10),
                new Rectangle(7,3),
                new Circle(4),
                new Circle(2),
            };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
