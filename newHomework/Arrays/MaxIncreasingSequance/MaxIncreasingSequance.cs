using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxIncreasingSequance
{
    class MaxIncreasingSequance
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 5, 5, 7, 8, 9, 10, 1, 2, 3, 4, 4, 6, 7, 8, 20, 3 };
            int sequence = 1;
            int maxSeq = 1;
            int num = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == num + 1) { sequence++; num++; }
                else
                {
                    num = nums[i];
                    if (sequence > maxSeq) maxSeq = sequence;
                    sequence = 1;
                }

            }
            Console.WriteLine(maxSeq);
        }
    }
}
