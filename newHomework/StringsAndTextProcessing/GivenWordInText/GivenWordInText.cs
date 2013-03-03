using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GivenWordInText
{
    class GivenWordInText
    {
        static void Main(string[] args)
        {
            int firstLetter = 0;
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            bool print = true;
            string[] sentences = text.Split('.');
            for (int i = 0; i < sentences.Count(); i++)
            {
                print = false;
                for (int j = 0; j < sentences[i].Length; j++)
                {
                    if (sentences[i][j] == ' ')
                    {
                        for (int z = 0; z < word.Length; z++)
                        {
                            print = true;
                            if (sentences[i][j + z + 1] != word[z])
                            {
                                print = false;
                                break;
                            }
                        }
                    }
                }
                if (print)
                {
                    Console.WriteLine(sentences[i]);
                }
            }
        }
    }
}
