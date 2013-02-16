using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVariations
{
    class AllVariations
    {
        static int N = int.Parse(Console.ReadLine());
        static int K = int.Parse(Console.ReadLine());
        static void Variations(int[] array, int index)
        {
            if (index == array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    array[index] = i;
                    Variations(array, index + 1);
                }
            }
        }
        static void Main()
        {
            int[] variations = new int[K];
            Variations(variations, 0);
        }
    }
}
