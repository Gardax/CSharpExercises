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
            uint first = 0;
            uint second = 1;
            uint next;
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 0; i < 100; i++)
            {
                next = first + second;
                Console.WriteLine(next);
                first = second;
                second = next;
            }
        }
    }
}
