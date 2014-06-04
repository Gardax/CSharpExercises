using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //person with not specified age
            Person ivan = new Person("Ivan Ivanov");
            //person with specified age
            Person Georgi = new Person("Georgi Georgiev", 17);
            //test
            Console.WriteLine(ivan.ToString());
            Console.WriteLine(Georgi.ToString());
        }
    }
}
