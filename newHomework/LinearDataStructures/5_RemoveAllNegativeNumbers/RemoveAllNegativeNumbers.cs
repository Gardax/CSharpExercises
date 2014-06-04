using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_RemoveAllNegativeNumbers
{
    class RemoveAllNegativeNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, -3, 2, -2, 2, -3, 5, 5, -5, 5, 5, -6, -6 };

            //Remove all negative
            List<int> possitiveNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number >= 0)
                {
                    possitiveNumbers.Add(number);
                }
            }

            for (int i = 0; i < possitiveNumbers.Count; i++)
            {
                Console.WriteLine(possitiveNumbers[i]);
            }
        }
    }
}
