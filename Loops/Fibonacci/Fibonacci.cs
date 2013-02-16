using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            int third = 1;
            int N = int.Parse(Console.ReadLine());
            int fourth;
            int sum = 2;
            for (int i = 3; i < N; i++)
            {
                fourth = second + third;
                second = third;
                third = fourth;
                sum = sum + fourth;
            }
            Console.WriteLine(sum);
        }
    }
}
