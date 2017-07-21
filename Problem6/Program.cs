//Problem reference:http://www.codeabbey.com/index/task_view/rounding
using System;
class Programm
{
    static void Main()
    {
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        double[,] array = new double[x, 2];
        for (int i = 0, j = 1; i < array.GetLength(0); i++)
        {
            Console.Write("Enter testcase №{0}: ", j++);
            string supportStr = Console.ReadLine();
            string[] sArray = supportStr.Split(' ');
            array[i, 0] = Convert.ToDouble(sArray[0]);
            array[i, 1] = Convert.ToDouble(sArray[1]);
        }

        int[] result = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result[i] = (int)Math.Round((array[i, 0] / array[i, 1]));
            Console.Write(result[i] + " ");
        }
        Console.ReadKey();
    }
}