using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringInString
{
    class SubstringInString
    {
        static int counter(string d, string s)
        {
            int Index = s.IndexOf(d);
            int l = d.Length;
            s = s.Substring(Index + 1);
            if (Index == -1)
                return 0;
            else
                return 1 + counter(d, s);
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string text2 = text.ToLower();
            string word2 = word.ToLower();
            int count = counter(word2, text2);
            Console.WriteLine("The result is: "+count);
        }
    }
}
