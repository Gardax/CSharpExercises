using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatingAndUsingObjects
{
    class TenRandomValues
    {
        static Random _r = new Random();
        static void F()
        {
            int n = _r.Next(100,201);
            Console.WriteLine(n);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
			{
                F(); 
            }
        }
    }
}
