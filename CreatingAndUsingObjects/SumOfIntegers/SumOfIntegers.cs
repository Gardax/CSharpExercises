using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfIntegers
{
    class SumOfIntegers
    {
        static int sum(string numbers)
        {
            int sum = 0;
            string[] nums = numbers.Split(' ');
            foreach (string number in nums)
            {
                sum += int.Parse(number);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string Numbers = Console.ReadLine();
            Console.WriteLine(sum(Numbers));
        }
    }
}
