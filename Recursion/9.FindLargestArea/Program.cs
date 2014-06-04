using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.FindLargestArea
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
        static int countOfCells = 0;
        private static int FindLargestArea(int row, int coll, int numberToMark)
        {
            countOfCells++;
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

            return countOfCells;
        }

        static void Main(string[] args)
        {
            int maxCountOfEmpties=0;
            int numberToMark = 0;
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    if (lab[i, j] == ' ')
                    {
                        countOfCells = 0;
                        int currentCount=FindLargestArea(i, j, numberToMark);
                        Console.WriteLine(currentCount);
                        numberToMark++;
                        if (currentCount > maxCountOfEmpties)
                        {
                            maxCountOfEmpties = currentCount;
                        }
                    }
                }
            }
            Console.WriteLine("Max area of emties is: {0}", maxCountOfEmpties);
        }
    }
}
