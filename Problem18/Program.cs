//Problem reference:http://www.codeabbey.com/index/task_view/square-root
using System;
using System.Threading;
using System.Globalization;
class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[x];
        for (int i = 0, j = 1; i < array.Length; i++)
        {
            Console.Write("Enter testline №{0}: ", j++);
            array[i] = Console.ReadLine();
        }
        for (int i = 0; i < array.Length; i++)
            Console.Write(SquareRoot(array[i]) + " ");
        Console.ReadLine();
    }

    static double SquareRoot(string str)
    {
        string[] sArray = str.Split(' ');
        double x = Convert.ToDouble(sArray[0]), n = Convert.ToDouble(sArray[1]);
        double r = 1, d = 0;
        for (int i = 0; i < n; i++)
        {
            d = x / r;
            r = (r + d) / 2;
            r = Math.Round(r, 9);
        }
        return r;
    }
}