using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorials
{
    class Factorials
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int Nfactorial = 1;
            int Kfactorial = 1;
            for (int i = 1; i <= N; i++)
            {
                Nfactorial *= i;
            }
            for (int i = 1; i <= K; i++)
            {
                Kfactorial *= i;
            }
            Console.WriteLine(Nfactorial/Kfactorial);
        }
    }
}
