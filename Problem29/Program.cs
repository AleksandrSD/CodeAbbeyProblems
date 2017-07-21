//Problem reference:http://www.codeabbey.com/index/task_view/sort-with-indexes
using System;
class Programm
{
    static void Main()
    {
        Console.Write("How much digits? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter digits line: ");
        string inputStr = Console.ReadLine();
        string[] sArray = inputStr.Split(' ');

        int[] array = new int[n];

        for (int i = 0; i < sArray.Length; i++)
        {
            array[i] = Convert.ToInt32(sArray[i]);
        }

        int[] array2 = (int[])array.Clone();

        int[] lastArray = new int[array.Length];

        int variable;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    variable = array[i];
                    array[i] = array[j];
                    array[j] = variable;
                }
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array2[j]) lastArray[i] = j + 1;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(lastArray[i] + " ");
        }
        Console.ReadKey();
    }
}