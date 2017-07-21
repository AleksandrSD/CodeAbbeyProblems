//Problem reference:http://www.codeabbey.com/index/task_view/card-names
using System;
class Program
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        string[] sArray = inputStr.Split(' ');
        int[] array = new int[sArray.Length];

        for (int i = 0; i < sArray.Length; i++)
        {
            array[i] = Convert.ToInt32(sArray[i]);
            CardName(array[i]);
        }
        Console.ReadKey();
    }

    static void CardName(int card_value)
    {
        string[] suits = { "Clubs", "Spades", "Diamonds", "Hearts" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        int suit_value, rank_value;
        string suit, rank;
        suit_value = card_value / 13;
        rank_value = card_value % 13;
        suit = suits[suit_value];
        rank = ranks[rank_value];
        Console.Write("{0}-of-{1} ", rank, suit);
    }
}