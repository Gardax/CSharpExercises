using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLeapYear
{
    class IsLeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }
}
