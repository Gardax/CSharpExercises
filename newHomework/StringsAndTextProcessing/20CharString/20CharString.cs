using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20CharString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int rest = 20 - text.Length;
            if (text.Length < 20)
            {
                for (int i = 0; i < rest; i++)
                {
                    text += "*";
                }
            }
            Console.WriteLine(text);
        }
    }
}
