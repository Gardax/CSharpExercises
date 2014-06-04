using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfIntegers
{
    class IntegersDivisibleby7And3
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 7, 21, 15, 14, 63, 9, 8 };
            //lambda
            var selectedNumbers = numbers.Where(x=>x%21==0);
            foreach (var num in selectedNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            //LINQ
            var selectedNums =
                from num in numbers
                where num % 21 == 0
                select num;
            foreach (var num in selectedNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
