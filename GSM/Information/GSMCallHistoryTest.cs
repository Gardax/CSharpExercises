using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class GSMCallHistoryTest
    {
        public static void Calls()
        {
            GSM myGsm = new GSM("One X", "HTC", 800, "Georgi", new Battery("Li/Ion", 200, 7), new Display(4.7, 160000000));
            myGsm.AddCall("0878182854", 213);
            myGsm.AddCall("0898625311", 51);
            myGsm.AddCall("0898694325", 118);
            foreach (var item in myGsm.GetCallHistory)
            {
                Console.WriteLine("Call to: "+item.phoneNumber);
                Console.WriteLine("Duration: "+item.duration);
                Console.WriteLine("Date: "+item.date);
                Console.WriteLine();
            }
            Console.WriteLine("Total price: {0}", myGsm.TotalPriceOfCalls(0.37));
            //Remove the longest call
            int max=0;
            int index=0;
            foreach (var item in myGsm.GetCallHistory)
            {
                if (item.duration > max)
                {
                    max = item.duration;
                    index = myGsm.GetCallHistory.IndexOf(item);
                }
            }
            GSM.callHistory.RemoveAt(index);
            Console.WriteLine("Total price: {0}", myGsm.TotalPriceOfCalls(0.37));
            //Clear all history and print it
            myGsm.ClearAllCallHistory();
            foreach (var item in myGsm.GetCallHistory)
            {
                Console.WriteLine("Call to: " + item.phoneNumber);
                Console.WriteLine("Duration: " + item.duration);
                Console.WriteLine("Date: " + item.date);
                Console.WriteLine();
            }
            
        }
    }
}
