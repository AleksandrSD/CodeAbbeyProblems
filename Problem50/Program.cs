//Problem reference:http://www.codeabbey.com/index/task_view/palindromes
using System;
class Programm
{
    static void Main()
    {
        Console.WriteLine("How much lines?");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(Method(array[i]) + " ");
        }
        Console.ReadKey();
    }

    static char Method(string a)
    {
        string b = null;
        a = a.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace(":", "").Replace(";", "").Replace("-", "");

        for (int i = a.Length - 1; i >= 0; i--)
        {
            b = b + a[i];
        }

        if (a == b) return 'Y';
        else return 'N';
    }
}