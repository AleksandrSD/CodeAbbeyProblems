//Problem reference:http://www.codeabbey.com/index/task_view/combinations-counting
using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[x];
        for (int i = 0, j = 1; i < array.Length; i++)
        {
            Console.Write("Enter testline №{0}: ", j++);
            array[i] = Console.ReadLine();
        }
        for (int i = 0; i < array.Length; i++)
            Console.Write(CombinationsCounting(array[i]) + " ");
        Console.ReadKey();
    }

    static BigInteger CombinationsCounting(string inputStr)
    {
        string[] array = inputStr.Split(' ');
        long n = Convert.ToInt64(array[0]), k = Convert.ToInt64(array[1]), z = n - k;
        BigInteger fn = 1, fk = 1, fz = 1;
        for (long i = 1; i < n; i++) fn += fn * i;
        for (long i = 1; i < k; i++) fk += fk * i;
        for (long i = 1; i < z; i++) fz += fz * i;
        BigInteger c = fn / (fk * fz);
        return c;
    }
}