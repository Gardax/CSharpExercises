using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_LongestSubsequance
{
    public class LongestSubsequance
    {
        public static List<int> FindTheLongestSubsequance(IList<int> numbers)
        {

            if (numbers != null && numbers.Count>0)
            {
                int maxSequance = 1;
                int currentSequance = 1;
                int numberOfTheLongestSequance=numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        currentSequance++;
                    }
                    else
                    {
                        if (maxSequance < currentSequance)
                        {
                            numberOfTheLongestSequance = numbers[i-1];
                            maxSequance = currentSequance;
                        }
                        currentSequance = 1;
                    }
                }

                List<int> sequance = new List<int>();
                for (int i = 0; i < maxSequance; i++)
                {
                    sequance.Add(numberOfTheLongestSequance);
                }
                return sequance;
            }
            else
            {
                throw new ArgumentNullException("The collection is empty or not initialized!");
            }
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 3, 2, 2, 2, 3, 5, 5, 5, 5, 5, 6, 6 };
            List<int> maxSubsequance = FindTheLongestSubsequance(numbers);

            foreach (var number in maxSubsequance)
            {
                Console.WriteLine(number);
            }
        }
    }
}
