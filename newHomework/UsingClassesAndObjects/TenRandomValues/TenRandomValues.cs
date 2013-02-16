
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenRandomValues
{
    class TenRandomValues
    {
        static Random _generateRandom = new Random();
        static void generateRandom()
        {
            int n = _generateRandom.Next(100, 201);
            Console.WriteLine(n);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                generateRandom();
            }
        }
    }
}
