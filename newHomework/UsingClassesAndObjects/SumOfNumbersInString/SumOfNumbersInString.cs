using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbersInString
{
    class SumOfNumbersInString
    {
        static int sum(string nums)
        {
            string[] numbers =nums.Split(' ');
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            Console.WriteLine(sum(numbers));
        }
    }
}
