//Problem reference:http://www.codeabbey.com/index/task_view/dice-rolling
using System;
using System.Threading;
using System.Globalization;

class Programm
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        string x = Console.ReadLine();
        string[] digits = x.Split(' ');
        double[] array = new double[digits.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(digits[i]);
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(Method(array[i]) + " ");
        }
        Console.ReadKey();
    }

    static int Method(double a)
    {
        a *= 6;
        int cubeValue = (int)a + 1;
        return cubeValue;
    }
}