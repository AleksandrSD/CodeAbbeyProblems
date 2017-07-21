//Problem reference:http://www.codeabbey.com/index/task_view/rock-paper-scissors
using System;
class Program
{
    static void Main()
    {
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[x];
        for (int i = 0; i < array.Length; i++)
        {
            int j = i + 1;
            Console.Write("Enter line №{0}: ", j);
            array[i] = Console.ReadLine();
        }

        for (int i = 0; i < array.Length; i++)
            Console.Write(RPS(array[i]) + " ");

        Console.ReadKey();
    }

    static int RPS(string a)
    {
        string[] array = a.Split(' ');
        int winer = 0;
        for (int i = 0; i < array.Length; i++)
        {
            string str = array[i];
            if (str[0] == str[1]) continue;
            if (str[0] == 'R' && str[1] == 'S') winer = 1;
            if (str[0] == 'R' && str[1] == 'P') winer = 2;
            if (str[0] == 'S' && str[1] == 'R') winer = 2;
            if (str[0] == 'S' && str[1] == 'P') winer = 1;
            if (str[0] == 'P' && str[1] == 'R') winer = 1;
            if (str[0] == 'P' && str[1] == 'S') winer = 2;
        }
        return winer;
    }
}