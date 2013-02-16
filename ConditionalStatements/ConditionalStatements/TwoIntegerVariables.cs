using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionalStatements
{
    class TwoIntegerVariables
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int swap;
                swap = a;
                a = b;
                b = swap;
                Console.WriteLine("a={0} b={1}", a, b);
            }
            else
            {
                Console.WriteLine("b>a");
                Console.WriteLine("a={0} b={1}", a, b); Console.WriteLine();
            }
        }
    }
}
