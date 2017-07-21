//Problem reference:http://www.codeabbey.com/index/task_view/bubble-in-array
using System;
class Program
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        string[] sArray = inputStr.Split(' ');
        Array.Resize(ref sArray, sArray.Length - 1);
        int[] array = new int[sArray.Length];
        for (int i = 0; i < sArray.Length; i++)
        {
            array[i] = Convert.ToInt32(sArray[i]);
        }
        int limit = 10000007, seed = 113, result = 0, index = 0, temp;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] >= array[i + 1])
            {
                index++;
                temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            result = (result + array[i]) * seed;
            result = result % limit;
        }
        Console.WriteLine("{0} {1}", index, result);
        Console.ReadKey();
    }
}