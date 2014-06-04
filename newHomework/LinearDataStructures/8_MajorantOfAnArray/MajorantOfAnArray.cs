using System;
using System.Collections.Generic;
using System.Linq;
namespace _8_MajorantOfAnArray
{
    class MajorantOfAnArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            int maxNumberOfOccurances = 1;
            int currentCount = 0;
            int number = arr[0];

            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentCount++;
                    }
                    if (maxNumberOfOccurances < currentCount) 
                    {
                        maxNumberOfOccurances = currentCount;
                        number = arr[i]; 
                    }
                }
                currentCount = 0;
            }

            if (maxNumberOfOccurances >= arr.Length / 2 + 1)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("There is no majorant in this array!");
            }
        }
    }
}
