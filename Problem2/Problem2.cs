//Problem reference:http://www.codeabbey.com/index/task_view/sum-in-loop
using System;
class Programm
{
    static void Main()
    {
        int sum = 0;
        int[] array = new int[32];
        Console.WriteLine("Please, enter digits");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
            sum += array[i];
        }
        Console.WriteLine("The sum of the entered {0} digits: {1}", array.Length, sum);
        Console.ReadKey();
    }
}