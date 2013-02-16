using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleSurface
{
    class Triangle
    {
        public double surfaceBy3Sides(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double surfaceBy2SidesAndAngle(int a, int b, int angle)
        {
            return Math.Sin(angle) * a * b / 2;
        }
        public double surfaceBySideAndAltituide(int a, int h)
        {
            return a * h / 2;
        }
    }
    class TriangleSurface
    {

        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine(triangle.surfaceBy3Sides(3, 4, 5));
            Console.WriteLine(triangle.surfaceBy2SidesAndAngle(4, 4, 90));
            Console.WriteLine(triangle.surfaceBySideAndAltituide(5, 4));
        }
    }
}
