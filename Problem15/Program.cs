//Problem reference:http://www.codeabbey.com/index/task_view/maximum-of-array
using System;
class Programm
{
    static void Main()
    {
        string a = Console.ReadLine();
        string[] digits = a.Split(' ');
        int[] array = new int[300];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(digits[i]);
        }

        int max = 0, min = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine("{0} {1}", max, min);
        Console.ReadKey();
    }
}