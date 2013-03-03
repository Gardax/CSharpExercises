using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateRange
{
    class DateRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first date:");
            DateTime first = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second date:");
            DateTime second = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs((first - second).TotalDays));
        }
    }
}
