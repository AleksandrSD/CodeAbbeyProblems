//Problem reference:http://www.codeabbey.com/index/task_view/triangle-area
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
            Console.Write("Enter line №{0}: ", j++);
            array[i] = Console.ReadLine();
        }

        for (int i = 0; i < array.Length; i++)
            Console.Write(TriangleS(array[i]) + " ");

        Console.ReadKey();
    }

    static double TriangleS(string inputStr)
    {
        string[] sArray = inputStr.Split(' ');
        int x1 = Convert.ToInt32(sArray[0]), y1 = Convert.ToInt32(sArray[1]);
        int x2 = Convert.ToInt32(sArray[2]), y2 = Convert.ToInt32(sArray[3]);
        int x3 = Convert.ToInt32(sArray[4]), y3 = Convert.ToInt32(sArray[5]);
        double a = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        double b = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
        double c = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return Math.Round(s, 2);
    }
}