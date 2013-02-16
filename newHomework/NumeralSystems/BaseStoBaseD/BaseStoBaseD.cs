using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseStoBaseD
{
    class BaseStoBaseD
    {
        static string convert(int s, int d, string num)
        {
            //Convert to decimal
            char[] number = num.ToCharArray();
            int[] newString=new int [number.Length];
            int multiplayer = 1,j=0;
            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case '0': newString[i] = 0; break;
                    case '1': newString[i] = 1; break;
                    case '2': newString[i] = 2; break;
                    case '3': newString[i] = 3; break;
                    case '4': newString[i] = 4; break;
                    case '5': newString[i] = 5; break;
                    case '6': newString[i] = 6; break;
                    case '7': newString[i] = 7; break;
                    case '8': newString[i] = 8; break;
                    case '9': newString[i] = 9; break;
                    case 'A': newString[i] = 10; break;
                    case 'B': newString[i] = 11; break;
                    case 'C': newString[i] = 12; break;
                    case 'D': newString[i] = 13; break;
                    case 'E': newString[i] = 14; break;
                    case 'F': newString[i] = 15; break;
                }

            }
            int decimalNum=0;
            for (int i = newString.Count() - 1; i >= 0;i--)
            {
                multiplayer = 1;
                for (int z = 0; z < j; z++)
                {
                    multiplayer *= s;
                }
                decimalNum += newString[i] * multiplayer;
                j++;
            }
            //convert to d
            int[] newNumber = new int[32];
            j = 0;
            while (decimalNum> 0)
            {
                newNumber[j] = decimalNum % d;
                decimalNum /= d;
                j++;
            }
            string convertedNum = "";
            for (int i = j - 1; i >= 0; i--)
            {
                switch (newNumber[i])
                {
                    case 0: convertedNum+="0"; break;
                    case 1: convertedNum+="1"; break;
                    case 2: convertedNum+="2"; break;
                    case 3: convertedNum+= "3"; break;
                    case 4: convertedNum+="4"; break;
                    case 5: convertedNum+="5"; break;
                    case 6: convertedNum+="6"; break;
                    case 7: convertedNum+="7"; break;
                    case 8: convertedNum+="8"; break;
                    case 9: convertedNum+="9"; break;
                    case 10:convertedNum+="A"; break;
                    case 11: convertedNum+="B"; break;
                    case 12: convertedNum+="C"; break;
                    case 13: convertedNum+="D"; break;
                    case 14: convertedNum+="E"; break;
                    case 15: convertedNum+="F"; break;
                }
            }
            return convertedNum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete broinata sistema na chisloto");
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete vroinata sistema, v koqto da vude prevurnato");
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete chisloto");
            string number = Console.ReadLine();
            Console.WriteLine(convert(S,D,number));
        }
    }
}
