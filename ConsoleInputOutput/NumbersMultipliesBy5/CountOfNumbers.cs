using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersMultipliesBy5
{
    class CountOfNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i%5==0)
                    count++;
            }
            Console.WriteLine(count); 
        }
    }
}
