using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.AllAreasOfPassableCells
{
    class Program
    {
        static char[,] lab = new char[,]{
                                            {' ', ' ', ' ', '*', ' ', ' ', ' '},
                                            {'*', '*', '*', '*', ' ', '*', ' '},
                                            {' ', ' ', ' ', '*', ' ', ' ', ' '},
                                            {' ', '*', '*', '*', '*', '*', ' '},
                                            {' ', ' ', '*', ' ', ' ', ' ', ' '},
                                        };
        private static void FindLargestArea(int row, int coll, int numberToMark)
        {
            lab[row, coll] = (char)numberToMark;
            if (row - 1 >= 0)
            {
                if (lab[row - 1, coll] == ' ')
                {
                    FindLargestArea(row - 1, coll, numberToMark);
                }
            }
            if (row + 1 < lab.GetLength(0))
            {
                if (lab[row + 1, coll] == ' ')
                {
                    FindLargestArea(row + 1, coll, numberToMark);
                }
            }
            if (coll - 1 >= 0)
            {
                if (lab[row, coll - 1] == ' ')
                {
                    FindLargestArea(row, coll - 1, numberToMark);
                }
            }
            if (coll + 1 < lab.GetLength(1))
            {
                if (lab[row, coll + 1] == ' ')
                {
                    FindLargestArea(row, coll + 1, numberToMark);
                }
            }
        }
        private static void PrintMatrix()
        {
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    Console.Write(lab[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int numberToMark = 49;
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    if (lab[i, j] == ' ')
                    {
                        FindLargestArea(i, j, numberToMark);
                        numberToMark++;
                    }
                }
            }

            PrintMatrix();
            
        }
    }
}
