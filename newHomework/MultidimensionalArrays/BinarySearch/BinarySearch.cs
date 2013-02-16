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
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int K = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            int num = -1;
            while (num < 0)
            {
                num = Array.BinarySearch(arr, K);
                K--;
            }
            Console.WriteLine(arr[num]);
        }
    }
}
