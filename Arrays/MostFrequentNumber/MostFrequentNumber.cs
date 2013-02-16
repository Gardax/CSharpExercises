using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mostFrequentequentNumber
{
    class mostFrequentequentNumber
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int mostFrequent =1;
            int count = 0;
            int num=arr[0];
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) count++;
                    if (mostFrequent < count) { mostFrequent = count; num = arr[i]; }
                }
                count = 0;
            }
            Console.WriteLine(num);
        }
    }
}
