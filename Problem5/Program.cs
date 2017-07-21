//Problem reference:http://www.codeabbey.com/index/task_view/min-of-three
using System;
class Programm
{
    static void Main()
    {
        int[,] array = new int[28, 3];
        int[] result = new int[array.GetLength(0)];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            array[i, 0] = Convert.ToInt32(Console.ReadLine());
            array[i, 1] = Convert.ToInt32(Console.ReadLine());
            array[i, 2] = Convert.ToInt32(Console.ReadLine());

            if (array[i, 0] < array[i, 1] && array[i, 0] < array[i, 2])
            {
                result[i] = array[i, 0];
            }
            else if (array[i, 1] < array[i, 0] && array[i, 1] < array[i, 2])
            {
                result[i] = array[i, 1];
            }
            else if (array[i, 2] < array[i, 0] && array[i, 2] < array[i, 1])
            {
                result[i] = array[i, 2];
            }
            Console.WriteLine(result[i]);
        }
        Console.ReadKey();
    }
}