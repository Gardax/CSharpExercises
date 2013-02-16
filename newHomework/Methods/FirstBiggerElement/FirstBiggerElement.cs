using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBiggerElement
{
    class FirstBiggerElement
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
        static int firstBiggerElement(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (isBiggerThanItsNeighbours(arr, i))
                    return arr[i];
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Fill the array with 10 numbers.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(firstBiggerElement(array));
        }
    }
}
