using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerThanNeigbours
{
    class BiggerThanNeigbours
    {
        static bool isBiggerThanItsNeighbours(int[] arr, int index)
        {
            if (index == 0)
            {
                return arr[0] > arr[1];
            }
            else if (index == arr.Length)
            {
                return arr[index] > arr[index - 1];
            }
            else
                return ((arr[index] > arr[index - 1]) && (arr[index] > arr[index + 1]));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type index of the element:");
            int index = int.Parse(Console.ReadLine());
            int[] array = { 2, 4, 5, 3, 12, 76, 34, 23, 22, 1, 8, 5, 54, 32, 34, 15, 11, 8, 12, 9 };
            if (isBiggerThanItsNeighbours(array, index))
            {
                Console.WriteLine("The element is bigger than its neighbour/s");
            }
            else
            {
                Console.WriteLine("The element is not bigger than its neighbour/s");
            }
        }
    }
}
