using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            char[] hexString = Console.ReadLine().ToCharArray();
            int hex=0;
            int j, multiplayer = 1;
            for (int i = 0; i < hexString.Length; i++)
            {
                multiplayer = 1;
                for (j = 0; j < i; j++)
                {
                    multiplayer *= 16;
                }
                
                switch (hexString[hexString.Length-1 - i])
                {
                    case '0': hex+=0; break;
                    case '1': hex+=multiplayer; break;
                    case '2': hex += multiplayer*2; break;
                    case '3': hex += multiplayer*3; break;
                    case '4': hex += multiplayer*4; break;
                    case '5': hex += multiplayer*5; break;
                    case '6': hex += multiplayer*6; break;
                    case '7': hex += multiplayer*7; break;
                    case '8': hex += multiplayer*8; break;
                    case '9': hex += multiplayer*9; break;
                    case 'A': hex += multiplayer*10; break;
                    case 'B': hex += multiplayer*11; break;
                    case 'C': hex += multiplayer*12; break;
                    case 'D': hex += multiplayer*13; break;
                    case 'E': hex += multiplayer*14; break;
                    case 'F': hex += multiplayer*15; break;
                }

            }
            Console.WriteLine(hex);
        }
    }
}
