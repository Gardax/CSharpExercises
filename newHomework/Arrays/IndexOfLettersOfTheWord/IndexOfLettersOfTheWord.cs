﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLettersOfTheWord
{
    class IndexOfLettersOfTheWord
    {
        static void Main(string[] args)
        {
            int j;
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                j = 0;
                while (word[i] != letters[j])
                {
                    j++;
                }
                Console.Write(j + " ");
            }
        }
    }
}
