using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumAlgorithm
{
    class SumAlgorithm
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());
            double S = 0;
            for (int i = 1; i <= N; i++)
            {
                double f = 1;
                for (int j = 1; j <= i; j++)
                {
                    f = f * j;
                }
                double Xn = 1;
                for (int j = 0; j < i; j++)
                {
                    Xn = Xn * X;
                }
                S = S + (double)(f / Xn);
                Console.WriteLine("f="+f);
                Console.WriteLine("Xn="+Xn);
                Console.WriteLine("s="+S);
            }
            Console.WriteLine(S);
        }
    }
}
