using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arr1 = new char[5];
            char[] arr2 = new char[5];
            Console.WriteLine("Fill first array:");
            for (int i = 0; i < 5; i++)
            {
                arr1[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Fill second array:");
            for (int i = 0; i < 5; i++)
            {
                arr2[i] = Convert.ToChar(Console.ReadLine());
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
