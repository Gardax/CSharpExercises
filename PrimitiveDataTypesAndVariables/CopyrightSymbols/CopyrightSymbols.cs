using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopyrightSymbols
{
    class CopyrightSymbols
    {
        static void Main(string[] args)
        {
            //Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
            char sym = '\u00A9';
            Console.WriteLine("  " + sym);
            Console.WriteLine(" "+sym+sym+sym);
            Console.WriteLine(""+sym+sym+sym+sym+sym);
        }
    }
}
