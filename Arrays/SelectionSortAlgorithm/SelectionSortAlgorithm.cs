using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSortAlgorithm
{
    class SelectionSortAlgorithm
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 5, 5, 7, 8, 9, 10, 1, 2, 3, 4, 4, 6, 7, 8, 20, 3 };
            int count = numbers.Length;
            int i, j;
            int min, temp;

            for (i = 0; i < count - 1; i++)
            {
                min = i;
                for (j = i + 1; j < count; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }
                }

                temp = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = temp;
            }
            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
                Console.WriteLine();
            }
        }
    }
}
