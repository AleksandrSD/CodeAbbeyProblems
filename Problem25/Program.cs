//Problem reference:http://www.codeabbey.com/index/task_view/linear-congruential-generator
using System;
class Program
{
    static void Main()
    {
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[x];
        for (int i = 0, j = 1; i < array.Length; i++)
        {
            Console.Write("Please, enter digits string №{0,2}: ", j++);
            array[i] = Console.ReadLine();
        }
        for (int i = 0; i < array.Length; i++)
            Console.Write(LCG(array[i]) + " ");
        Console.ReadKey();
    }
    static int LCG(string inputStr)
    {
        string[] sArray = inputStr.Split(' ');
        int a = Convert.ToInt32(sArray[0]), c = Convert.ToInt32(sArray[1]), m = Convert.ToInt32(sArray[2]), x0 = Convert.ToInt32(sArray[3]), n = Convert.ToInt32(sArray[4]);
        int[] x = new int[n + 1];
        x[0] = x0;
        for (int i = 0; i < n; i++)
            x[i + 1] = ((a * x[i]) + c) % m;
        return x[x.Length - 1];
    }
}