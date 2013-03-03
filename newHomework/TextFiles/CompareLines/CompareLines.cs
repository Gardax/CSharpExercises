using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CompareLines
{
    class CompareLines
    {
        static void Main(string[] args)
        {
            StreamReader file1 = new StreamReader("file1.txt");
            StreamReader file2 = new StreamReader("file2.txt");
            int equal = 0;
            int different = 0;
            using (file1)
            {
                using (file2)
                {
                    string line1=file1.ReadLine();
                    string line2=file2.ReadLine();
                    while (line1 != null)
                    {
                        if (!(String.Compare(line1, line2) == 0))
                        {
                            different++;
                        }
                        else
                        {
                            equal++;
                        }
                        line1 = file1.ReadLine();
                        line2 = file2.ReadLine();
                    }
                    
                }
            }
            Console.WriteLine("Equal lines: {0}", equal);
            Console.WriteLine("Diferent lines: "+ different);
        }
    }
}
