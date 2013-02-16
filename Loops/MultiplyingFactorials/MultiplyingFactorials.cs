using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplyingFactorials
{
    class MultiplyingFactorials
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int Nfact=1;
            int Kfact = 1;
            int NKfact = 1;
            int NK = N - K;
            for (int i = 1; i <= N; i++)
            {
                Nfact *= i;
            }
            for (int i = 1; i <= K; i++)
            {
                Kfact *= i;
            }
            for (int i = 1; i <= NK; i++)
            {
                NKfact *= i;
            }
            Console.WriteLine(Nfact*Kfact/NKfact);
        }
    }
}
