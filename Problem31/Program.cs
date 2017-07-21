//Problem reference:http://www.codeabbey.com/index/task_view/rotate-string
using System;
class Programm
{
    static void Main()
    {
        Console.WriteLine("Please, enter ALL Digits");
        string inputDigits = Console.ReadLine();
        Console.WriteLine("Please, enter ALL Words");
        string inputStr = Console.ReadLine();

        string[] a = inputStr.Split(' ');
        string[] sdigits = inputDigits.Split(' ');
        int[] digits = new int[sdigits.Length];
        for (int i = 0; i < sdigits.Length; i++)
        {
            digits[i] = Convert.ToInt32(sdigits[i]);
        }

        for (int i = 0; i < a.Length; i++)
        {
            Method(a[i], digits[i]);
        }
        Console.ReadKey();
    }

    static void Method(string a, int rotate)
    {
        if (rotate > 0)
        {
            for (int i = 0; i < rotate; i++)
            {
                a += a[i];
            }
            a = a.Remove(0, rotate);
        }
        else
        {
            int x = a.Length + rotate;
            for (int i = 0; i < x; i++)
            {
                a += a[i];
            }
            a = a.Remove(0, x);
        }
        Console.Write(a + " ");
    }
}