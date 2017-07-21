//Problem reference:http://www.codeabbey.com/index/task_view/greatest-common-divisor
using System;

class Programm
{
    static void Main()
    {
        Console.WriteLine("How many pairs of numbers?");
        int numbersPairs = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[numbersPairs, 2];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("Enter digit №1 ");
            array[i, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter digit №2 ");
            array[i, 1] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Method(array[i, 0], array[i, 1]);
        }

        Console.ReadKey();
    }

    static void Method(int a, int b)
    {
        int x = GCD(a, b);
        int y = LCM(a, b, x);
        Console.Write("({0} {1}) ", x, y);
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int LCM(int a, int b, int gcd)
    {
        int lcm = a * b / gcd;
        return lcm;
    }
}