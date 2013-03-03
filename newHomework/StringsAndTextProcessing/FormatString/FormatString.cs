using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatString
{
    class FormatString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            foreach (var symbol in text)
            {
                Console.Write("\\u{0:X4}", (int)symbol);
            }
            Console.WriteLine();
        }
    }
}
