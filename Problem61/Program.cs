//Problem reference:http://www.codeabbey.com/index/task_view/prime-numbers-generation
using System;
class Program
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        string[] array = inputStr.Split(' ');
        for (int i = 0; i < array.Length; i++) Method(Convert.ToInt32(array[i]));
        Console.ReadKey();
    }

    static void Method(int value)
    {
        for (int i = 1, j = 1; i <= 2147483640; i++)
        {
            if (Prime(i))
            {
                if (j == value)
                {
                    Console.Write(i++ + " ");
                    break;
                }
                j++;
            }
        }
    }

    static bool Prime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}