using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SayNumber
{
    class SayNumber
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            if (number < 10)
            {
                switch (number)
                {
                    case 0: Console.WriteLine("Zero"); break;
                    case 1: Console.WriteLine("One"); break;
                    case 2: Console.WriteLine("Two"); break;
                    case 3: Console.WriteLine("Three"); break;
                    case 4: Console.WriteLine("Four"); break;
                    case 5: Console.WriteLine("Five"); break;
                    case 6: Console.WriteLine("Six"); break;
                    case 7: Console.WriteLine("Seven"); break;
                    case 8: Console.WriteLine("Eight"); break;
                    case 9: Console.WriteLine("Nine"); break;
                }
            }
            else if (number > 19 && number < 100)
            {
                int desetici = number / 10;
                string num = "";
                switch (desetici)
                {
                    case 2: num = num + "Twenty"; break;
                    case 3: num = num + "Thirty"; break;
                    case 4: num = num + "Fourty"; break;
                    case 5: num = num + "Fifty"; break;
                    case 6: num = num + "Sixty"; break;
                    case 7: num = num + "Seventy"; break;
                    case 8: num = num + "Eighty"; break;
                    case 9: num = num + "Ninty"; break;
                }
                int edinici = number % 10;
                switch (edinici)
                {
                    case 0: num = num + ""; break;
                    case 1: num = num + " One"; break;
                    case 2: num = num + " Two"; break;
                    case 3: num = num + " Three"; break;
                    case 4: num = num + " Four"; break;
                    case 5: num = num + " Five"; break;
                    case 6: num = num + " Six"; break;
                    case 7: num = num + " Seven"; break;
                    case 8: num = num + " Eight"; break;
                    case 9: num = num + " Nine"; break;
                }
                Console.WriteLine(num);
            }
            else if (number > 9 && number < 20)
            {
                switch (number)
                {
                    case 10: Console.WriteLine("Ten"); break;
                    case 11: Console.WriteLine("Eleven"); break;
                    case 12: Console.WriteLine("Twelve"); break;
                    case 13: Console.WriteLine("Thirteen"); break;
                    case 14: Console.WriteLine("Fourteen"); break;
                    case 15: Console.WriteLine("Fifteen"); break;
                    case 16: Console.WriteLine("Sixteen"); break;
                    case 17: Console.WriteLine("Seventeen"); break;
                    case 18: Console.WriteLine("Eighteen"); break;
                    case 19: Console.WriteLine("Ninteen"); break;
                }
            } if (number > 99 && number < 1000)
            {
                int stotici = number / 100;
                string num = "";
                switch (stotici)
                {
                    case 1: num = num + "One hundred"; break;
                    case 2: num = num + "Two hundred"; break;
                    case 3: num = num + "Three hundred"; break;
                    case 4: num = num + "Four hundred"; break;
                    case 5: num = num + "Five hundred"; break;
                    case 6: num = num + "Six hundred"; break;
                    case 7: num = num + "Seven hundred"; break;
                    case 8: num = num + "Eight hundred"; break;
                    case 9: num = num + "Nine hundred"; break;
                }
                int desetici = number % 100;
                desetici = desetici / 10;
                if (desetici > 1)
                {
                    switch (desetici)
                    {
                        case 2: num = num + " Twenty"; break;
                        case 3: num = num + " Thirty"; break;
                        case 4: num = num + " Fourty"; break;
                        case 5: num = num + " Fifty"; break;
                        case 6: num = num + " Sixty"; break;
                        case 7: num = num + " Seventy"; break;
                        case 8: num = num + " Eighty"; break;
                        case 9: num = num + " Ninty"; break;
                    }
                }
                else if (desetici == 1)
                {
                    int number2 = number % 100;
                    switch (number2)
                    {
                        case 10: num = num + " and Ten"; break;
                        case 11: num = num + " and Eleven"; break;
                        case 12: num = num + " and Twelve"; break;
                        case 13: num = num + " and Thirteen"; break;
                        case 14: num = num + " and Fourteen"; break;
                        case 15: num = num + " and Fifteen"; break;
                        case 16: num = num + " and Sixteen"; break;
                        case 17: num = num + " and Seventeen"; break;
                        case 18: num = num + " and Eighteen"; break;
                        case 19: num = num + " and Ninteen"; break;
                    }
                }
                else if (desetici == 0)
                {
                    num = num + " and";
                }
                if (desetici != 1)
                {
                    int edinici = number % 10;
                    switch (edinici)
                    {
                        case 0: num = num + ""; break;
                        case 1: num = num + " One"; break;
                        case 2: num = num + " Two"; break;
                        case 3: num = num + " Three"; break;
                        case 4: num = num + " Four"; break;
                        case 5: num = num + " Five"; break;
                        case 6: num = num + " Six"; break;
                        case 7: num = num + " Seven"; break;
                        case 8: num = num + " Eight"; break;
                        case 9: num = num + " Nine"; break;
                    }
                }
                Console.WriteLine(num);

            }

        }
    }
}
