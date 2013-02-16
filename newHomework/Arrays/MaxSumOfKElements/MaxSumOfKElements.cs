using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumOfKElements
{
    class MaxSumOfKElements
    {
        static void Main(string[] args)
        {
            int[] array;
            int index=-1,sum=0;
            int K, N, max=int.MinValue;
            N = int.Parse(Console.ReadLine());
            K = int.Parse(Console.ReadLine());
            array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < K; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                        index = i;
                    }
                }
                sum += array[index];
                array[index] = int.MinValue;
                max = int.MinValue;
            }
            Console.WriteLine(sum);
        }
    }
}
