//Problem reference:http://www.codeabbey.com/index/task_view/bicycle-race
using System;
using System.Threading;
using System.Globalization;
class Programm
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Console.WriteLine("How mutch testcases?");
        int x = Convert.ToInt32(Console.ReadLine());
        double[,] array = new double[x, 3];

        for (int i = 0, j = 1; i < x; i++)
        {
            Console.Write("Testcase №{0}\nEnter digit №1( s):", j++);
            array[i, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter digit №2(v1):");
            array[i, 1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter digit №3(v2):");
            array[i, 2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        for (int i = 0; i < x; i++)
        {
            Console.Write(Method(array[i, 0], array[i, 1], array[i, 2]) + " ");
        }
        Console.ReadKey();
    }

    static double Method(double s, double a, double b)
    {
        double v = a + b;
        s = s / v;
        double result = a * s;
        return result;
    }
}