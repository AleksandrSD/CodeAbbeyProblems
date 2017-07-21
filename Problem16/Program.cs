//Problem reference:http://www.codeabbey.com/index/task_view/average-of-array
using System;
class Programm
{
    static void Main()
    {
        Console.WriteLine("How many lines will be considered?");
        int amount = Convert.ToInt32(Console.ReadLine());
        string[] b = new string[amount];
        int[] c = new int[amount];
        for (int i = 0; i < amount; i++)
        {
            Console.Write("Please enter a line: ");
            b[i] = Console.ReadLine();
            string[] g = b[i].Split(' ');
            c[i] = g.Length;
        }

        for (int i = 0; i < amount; i++)
        {
            Console.Write(Avg(c[i], b[i]) + " ");
        }
        Console.ReadKey(true);
    }

    static double Avg(int numEl, string elements)
    {
        double sum = 0;
        int[] array = new int[numEl];
        string[] inputStringArray = elements.Split(' ');

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(inputStringArray[i]);
            sum += array[i];
        }
        sum = Math.Round((sum / numEl));
        return sum;
    }
}