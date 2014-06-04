using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class GSMTest
    {
        public static void Test()
        {
            GSM[] arr = new GSM[]{new GSM("One X", "HTC", 800, "Georgi", new Battery("Li/Ion", 200, 7), new Display(4.7, 160000000)),
                    new GSM ("Lumia 800", "Nokia")};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
                Console.WriteLine();
            }
            Console.WriteLine(GSM.Iphone4S);
            Console.WriteLine();
        }

    }
}
