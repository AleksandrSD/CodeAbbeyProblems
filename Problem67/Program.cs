//Problem reference:http://www.codeabbey.com/index/task_view/fibonacci-sequence
using System;
using System.Numerics;

class Programm
{
    static void Main()
    {
        Console.WriteLine("How many numbers?");
        int x = Convert.ToInt32(Console.ReadLine());
        string[] digits = new string[x];
        for (int i = 0; i < digits.Length; i++)
        {
            digits[i] = Console.ReadLine();
        }
        BigInteger u, u1 = 0, u2 = 1;
        BigInteger n = 99999999999999;
        for (int i = 2; i < n; i++)
        {
            u = u1 + u2;

            for (int j = 0; j < digits.Length; j++)
            {
                if (u == BigInteger.Parse(digits[j]))
                {
                    Console.WriteLine("#{0}. {1}", i, u);
                }
            }
            u1 = u2;
            u2 = u;
        }
        Console.ReadKey();
    }
}