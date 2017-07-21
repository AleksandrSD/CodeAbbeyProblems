//Problem reference:http://www.codeabbey.com/index/task_view/triangles
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
        for (int i = 0; i < array.GetLength(0); i++) Console.Write(Triangle(array[i, 0], array[i, 1], array[i, 2]) + " ");
        Console.ReadKey();
    }

    static int Triangle(int a, int b, int c)
    {
        int result = 0;
        if (a < (b + c) && b < (a + c) && c < (a + b)) result = 1;
        return result;
    }
}