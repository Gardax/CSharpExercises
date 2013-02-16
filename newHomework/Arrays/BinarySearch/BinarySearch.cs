using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int firstIndex = 0;
            int lastIndex = arr.Length;
            int searchedElement = int.Parse(Console.ReadLine());
            int index = ((lastIndex + firstIndex) / 2);
            while (arr[index] != searchedElement)
            {
                if (searchedElement > arr[index])
                {
                    firstIndex = index;
                    index = ((lastIndex + firstIndex) / 2);
                }
                else
                {
                    lastIndex = index;
                    index = ((lastIndex + firstIndex) / 2);
                }
            }
            Console.WriteLine("The index of the element is: {0}", index);

        }
    }
}
