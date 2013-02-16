using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
