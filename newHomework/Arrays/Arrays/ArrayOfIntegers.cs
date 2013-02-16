using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int[] arr = new int[21];
            for (int i = 1; i <= 20; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
