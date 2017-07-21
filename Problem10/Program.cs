//Problem reference:http://www.codeabbey.com/index/task_view/linear-function
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
            Console.Write("Enter string №{0}: ", j++);
            array[i] = Console.ReadLine();
        }
        for (int i = 0; i < array.Length; i++)
            LinearFunction(array[i]);
        Console.ReadKey();
    }

    static void LinearFunction(string str)
    {
        string[] sArray = str.Split(' ');
        int x1 = Convert.ToInt32(sArray[0]), y1 = Convert.ToInt32(sArray[1]);
        int x2 = Convert.ToInt32(sArray[2]), y2 = Convert.ToInt32(sArray[3]);
        int a = ((y2 - y1) / (x2 - x1));
        int b = y1 - a * x1;
        Console.Write("({0} {1}) ", a, b);
    }
}