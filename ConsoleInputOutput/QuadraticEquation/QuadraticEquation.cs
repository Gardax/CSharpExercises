using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double d;
            d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("The equation has no real roots.");
            }
            else if (d > 0)
            {
                d = Math.Sqrt(d);
                double x1 = (-b + d) / (2 * a);
                double x2 = (-b - d) / (2 * a);
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }
            else
            {
                double x = -b / (2 * a);
                Console.WriteLine("x1=x2="+x);
            }
        }
    }
}
