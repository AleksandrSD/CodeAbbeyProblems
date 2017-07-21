//Problem reference:http://www.codeabbey.com/index/task_view/sum-of-digits
using System;
class Programm
{
    static void Main()
    {
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[x, 3];
        for (int i = 0, j = 1; i < array.GetLength(0); i++)
        {
            Console.Write("Enter testcases №{0}: ", j++);
            string supportStr = Console.ReadLine();
            string[] sArray = supportStr.Split(' ');
            array[i, 0] = Convert.ToInt32(sArray[0]);
            array[i, 1] = Convert.ToInt32(sArray[1]);
            array[i, 2] = Convert.ToInt32(sArray[2]);
        }
        for (int i = 0; i < array.GetLength(0); i++) Console.Write(SumOfDigits(array[i, 0], array[i, 1], array[i, 2]) + " ");
        Console.ReadKey();
    }

    static int SumOfDigits(int a, int b, int c)
    {
        int result = 0;
        int x = a * b + c;
        while (x != 0)
        {
            result += (x % 10);
            x /= 10;
        }
        return result;
    }
}