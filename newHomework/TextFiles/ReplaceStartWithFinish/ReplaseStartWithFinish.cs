using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReplaceStartWithFinish
{
    class ReplaseStartWithFinish
    {
        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader("text1.txt"))
            using (StreamWriter output = new StreamWriter("text2.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                    output.WriteLine(line.Replace("start", "finish"));
        }
    }
}
