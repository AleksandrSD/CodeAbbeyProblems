//Problem reference:http://www.codeabbey.com/index/task_view/pythagorean-theorem
using System;
class Programm
{
    static void Main()
    {
        Console.Write("How many triangles: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[x, 3];
        for (int i = 0, j = 1; i < array.GetLength(0); i++)
        {
            Console.Write("Triangle №{0}\nEnter triangle side №1: ", j++);
            array[i, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter triangle side №2: ");
            array[i, 1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter triangle side №2: ");
            array[i, 2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Method(array[i, 0], array[i, 1], array[i, 2]);
        }
        Console.ReadKey();
    }

    static void Method(int a, int b, int c)
    {
        int a2 = a * a, b2 = b * b, c2 = c * c;
        int hypotenuse = a2 + b2;
        if (c2 == hypotenuse)
        {
            Console.Write("R ");
        }
        else if (c2 < hypotenuse)
        {
            Console.Write("A ");
        }
        else if (c2 > hypotenuse)
        {
            Console.Write("O ");
        }
    }
}