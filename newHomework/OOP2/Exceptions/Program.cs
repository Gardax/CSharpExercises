using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1 to 100");
            int number;
            InvalidRangeException<int> exception = new InvalidRangeException<int>("The number must be from 1 to 100", 1,100);
            number = int.Parse(Console.ReadLine());
            try
            {
                if (number < 1 || number > 100)
                    throw exception;
                else Console.WriteLine("The number is ok!");
            }
            catch
            {
                throw exception;
            }
            DateTime date1= new DateTime(1980,1,1);
            DateTime date2= new DateTime(2013,12,31);
            InvalidRangeException<DateTime> DateTimeException= new InvalidRangeException<DateTime>("The date must be from 1.1.1980 to 31.12.2013", date1, date2);
            DateTime date = DateTime.Parse(Console.ReadLine());
            try
            {
                if (date < date1 || date > date2)
                    throw exception;
                else Console.WriteLine("The date is ok!");
            }
            catch
            {
                throw DateTimeException;
            }
        }
    }
}
