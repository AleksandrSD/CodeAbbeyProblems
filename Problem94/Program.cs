//Problem reference:http://www.codeabbey.com/index/task_view/fools-day-2014
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
            Console.Write(FoolsDay(array[i]) + " ");
        Console.ReadKey();
    }

    static int FoolsDay(string inputStr)
    {
        string[] array = inputStr.Split(' ');
        int result = 0;
        for (int i = 0; i < array.Length; i++)
            result = result + Convert.ToInt32(array[i]) * Convert.ToInt32(array[i]);
        return result;
    }
}