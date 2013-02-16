using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequanceOfElements
{
    class MaxSequanceOfElements
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            int sequence = 1;
            int maxSeq = 1;
            int num = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] == num) sequence++;
                else
                {
                    num = nums[i];
                    if (sequence > maxSeq) maxSeq = sequence;
                    sequence = 1;
                }
            }
            if (sequence > maxSeq) maxSeq = sequence;
            Console.WriteLine("Maximum sequance is {0}", maxSeq);
        }
    }
}
