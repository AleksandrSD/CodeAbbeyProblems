//Problem reference:http://www.codeabbey.com/index/task_view/sums-in-loop
using System;
class Programm
{
    static void Main()
    {
        int[,] digits = new int[15, 2];
        int[] results = new int[15];

        for (int i = 0; i < digits.GetLength(0); i++)
        {
            digits[i, 0] = Convert.ToInt32(Console.ReadLine());
            digits[i, 1] = Convert.ToInt32(Console.ReadLine());
            results[i] = digits[i, 0] + digits[i, 1];
            Console.WriteLine(results[i]);
        }
        Console.ReadKey();
    }
}