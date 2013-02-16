using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueAtThePossitionP
{
    class ValueAtThePossitionP
    {
        static void Main(string[] args)
        {
            int n, v, p;
            n = int.Parse(Console.ReadLine());
            v = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            if ((n & mask) == 0)
            {
                n = n | (1 << p);
                Console.WriteLine(n);
            }
            else if ((n & mask) != 0)
            {
                n = n & (~(1 << p));
                Console.WriteLine(n);
            }
        }
    }
}
