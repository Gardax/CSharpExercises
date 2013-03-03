using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class ReverseWords
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char lastChar = text[text.Length - 1];
            string[] arr = text.Split(' ', '!', '.', '?', ',');
            for (int i = arr.Count() - 1; i >= 0; i--)
            {
                if (i != arr.Count() - 1 && i != 0) Console.Write(arr[i] + " ");
                else if (i == arr.Count() - 1) Console.Write(arr[i]);
                else Console.Write(arr[i] + lastChar);
            }
        }
    }
}
