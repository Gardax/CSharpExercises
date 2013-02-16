using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequanceOfMaximalSum
{
    class SequanceOfMaximalSum
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int max = Int32.MinValue;
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0) arr[i] += arr[i - 1];
                if (arr[i] - min > max) max = arr[i] - min;
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine("Maximal sum is: "+max);
        }
    }
}
