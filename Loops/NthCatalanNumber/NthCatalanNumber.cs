using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NthCatalanNumber
{
    class NthCatalanNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number = (double)(2 * n) / ((n + 1) * n);
            Console.WriteLine(number);
        }
    }
}
