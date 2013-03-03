using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NonRepeatOfLetters
{
    class NonRepeatOfLetters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(Regex.Replace(text, @"(\w)\1+", "$1"));
        }
    }
}
