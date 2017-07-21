//Problem reference:http://www.codeabbey.com/index/task_view/bubble-sort
using System;
class Programm
{
    static int[] Sorting(int[] matrix)
    {
        int temp;
        int prohod = 0, summ = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = i + 1; j < matrix.Length; j++)
            {
                if (matrix[i] > matrix[j])
                {
                    temp = matrix[i];
                    matrix[i] = matrix[j];
                    matrix[j] = temp;
                    summ++;
                }
            }
            prohod++;
        }
        prohod--;
        Console.WriteLine(prohod + " " + summ);
        return matrix;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers will be sorted?");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter numbers to sort:");
        int[] mas = new int[N];
        string supportString = Console.ReadLine();
        string[] supportArray = supportString.Split(' ');
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = Convert.ToInt32(supportArray[i]);
        }
        Sorting(mas);
        Console.WriteLine("After sorting:");
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + " ");
        }
        Console.ReadLine();
    }
}