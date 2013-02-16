using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            Console.WriteLine("Fill first array:");
            for (int i = 0; i < 5; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Fill second array:");
            for (int i = 0; i < 5; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (arr1[i] > arr2[i]) Console.WriteLine("Element of the first array is bigger");
                else if (arr1[i] < arr2[i]) Console.WriteLine("Element of the second array is bigger");
                else Console.WriteLine("Elements are equal");
            }
        }
    }
}
