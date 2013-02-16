using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
