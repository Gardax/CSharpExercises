using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_ReadAndSortInteers
{
    class ReadAndSortInteers
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
            numbers.Sort();

            //Print numbers
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
