using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorantOfAnArray
{
    class MajorantOfAnArray
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int count;
            for (int i = 0; i < array.Length; i++)
            {
                count = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j]) count++;
                }
                if (count >= array.Length/2 + 1)
                {
                    Console.WriteLine(array[i]);
                    break;
                }
            }
        }
    }
}
