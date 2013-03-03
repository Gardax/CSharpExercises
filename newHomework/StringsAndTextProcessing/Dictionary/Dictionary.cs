using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Hashtable dictionary = new Hashtable();
            dictionary[".NET"] = "platform for applications from Microsoft";
            dictionary["CLR"] = "managed execution environment for .NET";
            dictionary["namespace"] = "hierarchical organization of classes";
            Console.WriteLine(dictionary[word]);
        }
    }
}
