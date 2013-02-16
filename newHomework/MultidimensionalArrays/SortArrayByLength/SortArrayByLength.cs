using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayByLength
{
    class SortArrayByLength
    {
        static void sortArray(string[] arr)
        {
            int i, j;
            int min;
            string temp;

            for (i = 0; i < arr.Length-1; i++)
            {
                min = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].Length < arr[min].Length)
                    {
                        min = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
        static void Main(string[] args)
        {
            string[] array = new string[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = Console.ReadLine();
            }
            sortArray(array);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
