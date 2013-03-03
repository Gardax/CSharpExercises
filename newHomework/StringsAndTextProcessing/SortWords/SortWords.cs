using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SortWords
{
    class SortingWords
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var words = new List<string>();

            foreach (Match word in Regex.Matches(text, @"\w+"))
                words.Add(word.Value);

            words.Sort();

            foreach (string word in words)
                Console.WriteLine(word);
        }
    }
}
