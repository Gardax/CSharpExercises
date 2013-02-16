﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixB
{
    class MatrixB
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            int n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];
            int i, j, num = 1;
            for (i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (j = 0; j < n; j++)
                    {
                        matrix[j, i] = num;
                        num++;
                    }
                }
                else
                {
                    for (j = n - 1; j >= 0; j--)
                    {
                        matrix[j, i] = num;
                        num++;
                    }

                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }
    }
}
