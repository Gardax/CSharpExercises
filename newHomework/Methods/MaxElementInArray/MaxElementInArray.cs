using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElementInArray
{
    class MaxElementInArray
    {
        static int maxElement(int[] arr, int startingIndex)
        {
            int max = arr[startingIndex];
            for (int i = startingIndex; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] array = { 4, 6, 30, 1, 7, 8, 10, 2, 3 };
            int startIndex = int.Parse(Console.ReadLine());
            Console.WriteLine(maxElement(array, startIndex));
        }
    }
}
