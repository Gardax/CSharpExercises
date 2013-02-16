using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleInputOutput
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}+{2}={3}",a,b,c,a+b+c);
        }
    }
}
