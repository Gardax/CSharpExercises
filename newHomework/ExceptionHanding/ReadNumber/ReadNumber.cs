using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumber
{
    class Numbers
    {
        static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());

            if (!(start < n && n < end)) throw new ArgumentOutOfRangeException();

            return n;
        }

        static void Main()
        {
            int min = 1, max = 100;
            try
            {
                for (int i = 0; i < 10; i++) min = ReadNumber(min, max);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is out of range");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
