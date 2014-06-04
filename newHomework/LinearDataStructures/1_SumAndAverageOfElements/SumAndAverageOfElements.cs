using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_SumAndAverageOfElements
{
    class SumAndAverageOfElements
    {
        static void Main(string[] args)
        {
            //Read all numbers
            List<int> numbers = new List<int>();
            string input;
            do
            {
                input = Console.ReadLine();
                if (input != "")
                {
                    numbers.Add(int.Parse(input));
                }
            }
            while (input != "");

            //Calculate sum and average
            int sum = 0;
            int countOfNumbers = numbers.Count;
            for (int i = 0; i < countOfNumbers; i++)
            {
                sum += numbers[i];
            }
            int average=sum/countOfNumbers;

            Console.WriteLine("Sum of elements is {0}", sum);
            Console.WriteLine("Avarage of elements is {0}", average);
        }
    }
}
