using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChooseVariable
{
    class ChooseVariable
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int type = 1;
            int integerNumber;
            double doubleNumber;
            if (int.TryParse(line, out integerNumber))
            {
                type = 2;
            }
            if (double.TryParse(line, out doubleNumber))
            {
                type = 3;
            }
            switch (type)
            {
                case 1: Console.WriteLine(line+"*"); break;
                case 2: Console.WriteLine(integerNumber + 1); break;
                case 3: Console.WriteLine(doubleNumber+1); break;
            }
        }
    }
}
