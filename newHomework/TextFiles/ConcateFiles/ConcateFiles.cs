using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConcateFiles
{
    class ConcateFiles
    {
        static void Main(string[] args)
        {
            StreamReader readFirstFile = new StreamReader("text.txt");
            StreamReader readSecondFile = new StreamReader("text2.txt");
            StreamWriter outputFile = new StreamWriter("new.txt");
            using (readFirstFile)
            {
                using (readSecondFile)
                {
                    using (outputFile)
                    {
                        string file1 = readFirstFile.ReadToEnd();
                        string file2 = readSecondFile.ReadToEnd();
                        string concat = file1 + file2;
                        outputFile.WriteLine(concat);
                    }
                }
            }
        }
    }
}
