using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeclareCharacterVariable
{
    class DeclareCharacterVariable
    {
        static void Main(string[] args)
        {
            //Declare a character variable and assign it with the symbol that has Unicode code 72. 
            char sym = '\u0048';
            Console.WriteLine(sym);
        }
    }
}
