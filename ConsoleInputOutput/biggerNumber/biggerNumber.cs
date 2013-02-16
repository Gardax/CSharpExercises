using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biggerNumber
{
    class biggerNumber
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine((a>b)?a:b);
        }
    }
}
