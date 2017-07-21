//Problem reference:http://www.codeabbey.com/index/task_view/arithmetic-progression
using System;
class Programm
{
    static void Main()
    {
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string[] sArray = new string[x];
        int[,] array = new int[x, 3];
        for (int i = 0, j = 1; i < sArray.Length; i++)
        {
            Console.Write("Enter testcase {0}: ", j++);
            string supportStr = Console.ReadLine();
            string[] sArraySupport = supportStr.Split(' ');
            array[i, 0] = Convert.ToInt32(sArraySupport[0]);
            array[i, 1] = Convert.ToInt32(sArraySupport[1]);
            array[i, 2] = Convert.ToInt32(sArraySupport[2]);
        }
        for (int i = 0; i < array.GetLength(0); i++) Console.Write(ArithmeticProgression(array[i, 0], array[i, 1], array[i, 2]) + " ");
        Console.ReadKey();
    }

    static int ArithmeticProgression(int a, int b, int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++) sum += a + i * b;
        return sum;
    }
}