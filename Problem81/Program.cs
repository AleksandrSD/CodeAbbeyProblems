//Problem reference:http://www.codeabbey.com/index/task_view/bit-count
using System;
class Programm
{
    static void Main()
    {
        string outputStr = Console.ReadLine();
        string[] sArray = outputStr.Split(' ');
        int[] array = new int[sArray.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(sArray[i]);
            Console.Write(Method(array[i]) + " ");
        }
        Console.ReadKey();
    }

    static int Method(int n)
    {
        string y = Convert.ToString(n, 2);
        int index = 0;
        for (int i = 0; i < y.Length; i++)
        {
            if (y[i] == '1') index++;
        }
        return index;
    }
}