//Problem reference:http://www.codeabbey.com/index/task_view/smoothing-the-weather
using System;
using System.Threading;
using System.Globalization;

class Programm
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        string a = Console.ReadLine();
        string[] sArray = a.Split(' ');
        double[] array = new double[sArray.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = double.Parse(sArray[i]);
        }
        double[] arrayNew = new double[array.Length];

        arrayNew[0] = array[0];
        arrayNew[array.Length - 1] = array[array.Length - 1];

        for (int i = 1; i < array.Length - 1; i++)
        {
            arrayNew[i] = ((array[i - 1] + array[i] + array[i + 1]) / 3);
        }
        for (int i = 0; i < arrayNew.Length; i++)
        {
            Console.Write(arrayNew[i] + " ");
        }
        Console.ReadKey();
    }
}