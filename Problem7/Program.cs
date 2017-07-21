//Problem reference:http://www.codeabbey.com/index/task_view/fahrenheit-celsius
using System;
class Programm
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        string[] sArray = inputStr.Split(' ');
        double[] Fahrenheit = new double[sArray.Length];
        for (int i = 0; i < Fahrenheit.Length; i++) Fahrenheit[i] = Convert.ToDouble(sArray[i]);
        int[] Celsius = new int[Fahrenheit.Length];

        for (int i = 0; i < Fahrenheit.Length; i++)
        {
            Celsius[i] = (int)(Math.Round(((Fahrenheit[i] - 32) * 5) / 9));
            Console.Write(Celsius[i] + " ");
        }
        Console.ReadKey();
    }
}