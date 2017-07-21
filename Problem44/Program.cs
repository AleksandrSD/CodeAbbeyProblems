//Problem reference:http://www.codeabbey.com/index/task_view/double-dice-roll
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("How much testcases?");
        int x = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[x, 2];
        for (int i = 0; i < x; i++)
        {
            string supString = Console.ReadLine();
            string[] sArray = supString.Split(' ');
            array[i, 0] = Convert.ToInt32(sArray[0]);
            array[i, 1] = Convert.ToInt32(sArray[1]);
        }

        for (int i = 0; i < x; i++)
        {
            Console.Write(DoubleDiceRoll(array[i, 0], array[i, 1]) + " ");
        }
        Console.ReadKey();
    }

    static int DoubleDiceRoll(int a, int b)
    {
        const int diceSide = 6;
        int value = a % diceSide + 1;
        int value2 = b % diceSide + 1;
        value += value2;
        return value;
    }
}