using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Repeat d = new Repeat(Timer.Execute);
            d("I am apearing a lot of times", 5);
        }
    }
}
