using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSquare
{
    class SumOfSquare
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            matrix = new int[n, m];
            int sum = 0;
            int i, j;
            int maxSum = int.MinValue;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < n - 2; i++)
            {
                for (j = 0; j < m - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > maxSum) maxSum = sum;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
