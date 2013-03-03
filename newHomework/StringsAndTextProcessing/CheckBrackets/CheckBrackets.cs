using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBrackets
{
    class CheckBrackets
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            int counter = 0;
            bool ok = true;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(') counter++;
                if (expression[i] == ')') counter--;
                if (counter < 0)
                {
                    ok = false;
                    break;
                }
            }
            if (counter == 0 && ok)
            {
                Console.WriteLine("The brackets are ok");
            }
            else
            {
                Console.WriteLine("The brackets are NOT ok");
            }
        }
    }
}
