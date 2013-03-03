using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SortNames
{
    class SortNames
    {
        static void Main(string[] args)
        {
            StreamReader names = new StreamReader("names.txt");
            List<string> list=new List<string>();
            using (names)
            {
                string line = names.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = names.ReadLine();
                }
            }
            list.Sort();
            StreamWriter sortedNames = new StreamWriter("sortedNames.txt");
            using (sortedNames)
            {
                foreach (var name in list)
                {
                    sortedNames.WriteLine(name);
                }
            }
        }
    }
}
