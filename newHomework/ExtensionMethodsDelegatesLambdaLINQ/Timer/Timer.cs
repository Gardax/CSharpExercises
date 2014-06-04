using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Timer
{
    public delegate void Repeat(string someText, int sec);
    public class Timer
    {
        public static void Execute(string someText, int sec)
        {
            Stopwatch sw = new Stopwatch(); 
            sw.Start();
            while (true)
            {
                if (sw.ElapsedMilliseconds == sec * 1000) 
                {
                    Console.WriteLine(someText);
                    sw.Restart();
                }

            }
        }

    }
}
