using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CombinationsWithoutDuplicates
{
    class Program
    {
        static int n;
        static int k;
        static int[] result;

        private static void GenerateCombinationsWithDuplicates(int index, int start)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                result[index] = i;
                GenerateCombinationsWithDuplicates(index + 1, i+1);
            }
        }

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            result = new int[k];
            GenerateCombinationsWithDuplicates(0, 1);
        }
    }
}
