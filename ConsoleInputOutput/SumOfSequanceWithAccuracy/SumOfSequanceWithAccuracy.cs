using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfSequanceWithAccuracy
{
    class SumOfSequanceWithAccuracy
    {
        static void Main(string[] args)
        {
            double number=1d;
            double sum = 0d;
            int i = 1;
            while (number > 0.001)
            {
                number = number / i;
                sum += number;
                i++;
 
            }
            sum=Math.Round(sum, 3, MidpointRounding.AwayFromZero);
            Console.WriteLine(sum);
        }
    }
}
