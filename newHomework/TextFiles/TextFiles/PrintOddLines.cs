using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFiles
{
    class PrintOddLines
    {
        static void Main(string[] args)
        {
            using (StreamReader text = new StreamReader("text.txt")) 
            {
                int lineNumber = 1;
                string line = text.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    lineNumber++;
                    line = text.ReadLine();
                }
            }

        }
    }
}
