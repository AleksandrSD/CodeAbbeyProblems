//Problem reference:http://www.codeabbey.com/index/task_view/min-of-two
using System;
class Programm
{
    static void Main()
    {
        int[,] array = new int[25, 2];
        int[] result = new int[25];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            array[i, 0] = Convert.ToInt32(Console.ReadLine());
            array[i, 1] = Convert.ToInt32(Console.ReadLine());

            if (array[i, 0] < array[i, 1])
            {
                result[i] = array[i, 0];
            }
            else
            {
                result[i] = array[i, 1];
            }
            Console.WriteLine("The smallest digit in the pair: {0}", result[i]);
        }

        Console.ReadKey();
    }
}