using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;
using System.Diagnostics;

namespace LargeCollectionOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {

            OrderedBag<Product> products = new OrderedBag<Product>();

            Random randomPrice = new Random();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 500000; i++)
            {
                double price=randomPrice.NextDouble();
                products.Add(new Product("someName"+i, price));
            }
            double min = randomPrice.NextDouble();
            double max = randomPrice.NextDouble();
            for (int i = 0; i < 10000; i++)
            {
                products.FindAll(x => x.Price > min && x.Price < max).Take(20);
            }
            timer.Stop();
            Console.WriteLine("Program executed in {0}.", timer.Elapsed);
        }
    }
}
