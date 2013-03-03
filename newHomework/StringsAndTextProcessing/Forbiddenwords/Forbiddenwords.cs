using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();
            string[] forbidenWords = "PHP, CLR, Microsoft".Split(',');
            for (int i = 0; i < forbidenWords.Length; i++)
            {
                forbidenWords[i] = forbidenWords[i].Trim();
                textInput = textInput.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
            }
            Console.WriteLine();
            Console.WriteLine(textInput);
        }
    }
}
