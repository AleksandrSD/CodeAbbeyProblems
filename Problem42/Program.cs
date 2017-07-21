//Problem reference:http://www.codeabbey.com/index/task_view/blackjack-counting
using System;
class Program
{
    static void Main()
    {
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[x];
        for (int i = 0, j = 1; i < array.Length; i++)
        {
            Console.Write("Enter testline №{0}: ", j++);
            array[i] = Console.ReadLine();
        }
        for (int i = 0; i < array.Length; i++)
            BlackJack(array[i]);
        Console.ReadKey();
    }

    static void BlackJack(string inputStr)
    {
        string[] array = inputStr.Split(' ');
        Array.Sort(array);
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == "2") result += 2;
            if (array[i] == "3") result += 3;
            if (array[i] == "4") result += 4;
            if (array[i] == "5") result += 5;
            if (array[i] == "6") result += 6;
            if (array[i] == "7") result += 7;
            if (array[i] == "8") result += 8;
            if (array[i] == "9") result += 9;
            if (array[i] == "T" || array[i] == "J" || array[i] == "Q" || array[i] == "K") result += 10;
            if (array[i] == "A") result = ((result + 11) > 21) ? result += 1 : result += 11;
        }
        if (result > 21) Console.Write("Bust ");
        else Console.Write(result + " ");
    }
}