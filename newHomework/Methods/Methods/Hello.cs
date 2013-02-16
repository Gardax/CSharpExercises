using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Hello
    {
        static void sayHello()
        {
            string name;
            Console.WriteLine("Hi, I am Method! What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }
        static void Main(string[] args)
        {
            sayHello();
        }
    }
}
