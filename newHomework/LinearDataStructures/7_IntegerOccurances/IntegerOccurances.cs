using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_IntegerOccurances
{
    class IntegerOccurances
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int[] integers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            for (int i = 0; i < integers.Length; i++)
            {
                if (!numbers.Keys.Contains(integers[i]))
                {
                    numbers.Add(integers[i], 1);
                }
                else
                {
                    numbers[integers[i]]++;
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine("{0} => {1} times", number.Key, number.Value);
            }
        }
    }
}
