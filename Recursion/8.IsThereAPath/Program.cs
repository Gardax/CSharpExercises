using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.IsThereAPath
{
    class Program
    {
        static char[,] lab = 
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };

        static List<char> path = new List<char>();
        static bool pathFound = false;
        static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < lab.GetLength(0);
            bool colInRange = col >= 0 && col < lab.GetLength(1);
            return rowInRange && colInRange;
        }

        static void FindPathToExit(int row, int col, char direction)
        {
            if (pathFound)
            {
                return;
            }

            if (!InRange(row, col))
            {
                // We are out of the labyrinth -> can't find a path
                return;
            }

            // Append the current direction to the path
            path.Add(direction);

            // Check if we have found the exit
            if (lab[row, col] == 'e')
            {
                PrintPath(path);
                pathFound = true;
                return;
            }

            if (lab[row, col] == ' ')
            {
                // Temporary mark the current cell as visited
                lab[row, col] = 's';

                // Recursively explore all possible directions
                FindPathToExit(row, col - 1, 'L'); // left
                FindPathToExit(row - 1, col, 'U'); // up
                FindPathToExit(row, col + 1, 'R'); // right
                FindPathToExit(row + 1, col, 'D'); // down

                // Mark back the current cell as free
                lab[row, col] = ' ';
            }

            // Remove the last direction from the path
            path.RemoveAt(path.Count - 1);
        }

        static void PrintPath(List<char> path)
        {
            Console.Write("Found path to the exit: ");
            foreach (var dir in path)
            {
                Console.Write(dir);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            FindPathToExit(0, 0, 'S');
        }
    }
}
