using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AddNumberOfLines
{
    class AddNumberOfLines
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("text.txt");
            StreamWriter file2 = new StreamWriter("text2.txt");
            using (file)
            {
                using (file2)
                {
                    int numOfLine = 1;
                    string line = file.ReadLine();
                    while (line != null)
                    {
                        file2.WriteLine(numOfLine + " " + line);
                        numOfLine++;
                        line = file.ReadLine();

                    }
                }
            }
        }
    }
}
