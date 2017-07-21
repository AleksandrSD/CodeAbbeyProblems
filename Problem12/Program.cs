//Problem reference:http://www.codeabbey.com/index/task_view/modulo-and-time-difference
using System;
class Programm
{
    static void Main()
    {
        Console.Write("How many lines?: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[quantity];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }

        for (int i = 0; i < array.Length; i++)
        {
            Method(array[i]);
        }
        Console.ReadKey();
    }

    static void Method(string outStr)
    {
        string[] sArray = outStr.Split(' ');

        int[] departure = new int[4];
        int[] arrival = new int[4];
        int[] inputArray = new int[4];

        for (int i = 0, j = 0; i < sArray.Length; i++)
        {
            if (i < 4)
            {
                departure[i] = Convert.ToInt32(sArray[i]);
            }
            if (i >= 4)
            {
                arrival[j] = Convert.ToInt32(sArray[i]);
                j++;
            }
        }

        for (int i = 0; i < departure.Length; i++)
        {
            inputArray[i] = arrival[i] - departure[i];
        }

        for (int i = 1; i < departure.Length; i++)
        {
            if (inputArray[i] < 0)
            {
                if (i == 1) inputArray[i] += 24;
                if (i == 2 || i == 3) inputArray[i] += 60;
                inputArray[i - 1]--;
            }
        }
        Console.Write("({0} {1} {2} {3}) ", inputArray[0], inputArray[1], inputArray[2], inputArray[3]);
    }
}