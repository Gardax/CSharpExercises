using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerimeterAndAreaOfCircle
{
    class PerimeterAndAreaOfCircle
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            double C = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("The perimeter is: {0}", C);
            Console.WriteLine("The area is: "+area);
        }
    }
}
