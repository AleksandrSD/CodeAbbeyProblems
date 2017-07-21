//Problem reference:http://www.codeabbey.com/index/task_view/two-printers
using System;
class Program
{
    static void Main()
    {
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string[] sArray = new string[x];
        for (int i = 0, j = 1; i < sArray.Length; i++)
        {
            Console.Write("Enter testcase line №{0}: ", j++);
            sArray[i] = Console.ReadLine();
        }
        for (int i = 0; i < sArray.Length; i++)
            Console.Write(TwoPrinters(sArray[i]) + " ");
        Console.ReadLine();
    }

    static int TwoPrinters(string str)
    {
        string[] sArray = str.Split(' ');
        int x = Convert.ToInt32(sArray[0]), y = Convert.ToInt32(sArray[1]), n = Convert.ToInt32(sArray[2]);
        int nx = n * y / (x + y);
        return Math.Min((n - nx) * y, (nx + 1) * x);
    }
}