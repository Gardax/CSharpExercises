using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintAllCards
{
    class PrintAllCards
    {
        static void Main(string[] args)
        {
            string[] cards = new string[13] {"Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
            string[] colors = new string[4] { "clubs", "diamonds", "hearts", "spades" };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    Console.WriteLine(cards[j]+" of " +colors[i]);
                }
            }
        }
    }
}
