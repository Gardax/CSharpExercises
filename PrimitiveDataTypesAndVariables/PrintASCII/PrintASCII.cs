using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintASCII
{
    class PrintASCII
    {
        static void Main(string[] args)
        {
            //Write a program that prints the entire ASCII table of characters on the console.
            Console.OutputEncoding = Encoding.UTF8;
            for (byte counter = 0; counter < 255; counter++)
            {
                Console.WriteLine((char)counter);
            }

        }
    }
}
