using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringVariables
{
    class StringVariables
    {
        static void Main(string[] args)
        {
            //Declare two string variables and assign them with following value:
            //The "use" of quotations causes difficulties.
            //Do the above in two different ways: with and without using quoted strings.
            string withoutQuatations = "The use of quatations causes difficulties!";
            string withQuatations = "The \"use\" of quatations causes difficulties!";
            Console.WriteLine(withoutQuatations);
            Console.WriteLine(withQuatations);
        }
    }
}
