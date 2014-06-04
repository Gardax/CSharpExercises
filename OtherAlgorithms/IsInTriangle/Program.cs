using System;
using System.Collections.Generic;
using System.Linq;

namespace IsInTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            A.X=int.Parse(Console.ReadLine());
            A.Y=int.Parse(Console.ReadLine());

            Point B = new Point();
            B.X = int.Parse(Console.ReadLine());
            B.Y = int.Parse(Console.ReadLine());

            Point C = new Point();
            C.X = int.Parse(Console.ReadLine());
            C.Y = int.Parse(Console.ReadLine());

            Point P = new Point();
            P.X = int.Parse(Console.ReadLine());
            P.Y = int.Parse(Console.ReadLine());

            double triangleArea = CalcArea(A, B, C);
            double firstTriangleArea = CalcArea(A, B, P);
            double secondTriangleArea = CalcArea(A, C, P);
            double thirdTriangleArea = CalcArea(C, B, P);

            if (triangleArea == firstTriangleArea + secondTriangleArea + thirdTriangleArea)
            {
                Console.WriteLine("Point P{0} is in triangle.", P.ToString());
            }
            else
            {
                Console.WriteLine("Point P{0} is out of triangle.", P.ToString());
            }
        }

        static double CalcArea(Point p1, Point p2, Point p3)
        {
            double p1p2 = p1.CalcDistance(p2);
            double p2p3 = p2.CalcDistance(p3);
            double p3p1 = p3.CalcDistance(p1);
            double s = (p1p2 + p2p3 + +p3p1) / 2;

            double area = Math.Sqrt(s * (s - p1p2) * (s - p2p3) * (s - p3p1));
            return area;
        }
    }
}
