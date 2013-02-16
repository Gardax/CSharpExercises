using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is the biggest number!");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is the biggest number!");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c + " is the biggest number!");
            }
        }
    }
}
