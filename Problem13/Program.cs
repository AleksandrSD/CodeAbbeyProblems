//Problem reference:http://www.codeabbey.com/index/task_view/weighted-sum-of-digits
using System;
class Programm
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] array = inputLine.Split(' ');

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(Wsd(array[i]) + " ");
        }
        Console.ReadKey();
    }

    static int Wsd(string a)
    {
        a = a.Insert(0, "0");

        string[] b = new string[a.Length];
        int[] c = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            b[i] = Convert.ToString(a[i]);
        }

        int sum = 0;
        for (int i = 0; i < b.Length; i++)
        {
            c[i] = int.Parse(b[i]);
            sum = sum + c[i] * i;
        }
        return sum;
    }
}