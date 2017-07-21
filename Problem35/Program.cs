//Problem reference:http://www.codeabbey.com/index/task_view/savings-calculator
using System;
class Program
{
    static void Main()
    {
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        double[,] array = new double[x, 3];
        for (int i = 0; i < x; i++)
        {
            string inputStr = Console.ReadLine();
            string[] sArray = inputStr.Split(' ');
            array[i, 0] = Convert.ToDouble(sArray[0]);
            array[i, 1] = Convert.ToDouble(sArray[1]);
            array[i, 2] = Convert.ToDouble(sArray[2]);
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write(SavingCalculator(array[i, 0], array[i, 1], array[i, 2]) + " ");
        }
        Console.ReadKey();
    }

    static int SavingCalculator(double s, double r, double p)
    {
        p = (p * 0.01) + 1;
        int index = 0;

        while (true)
        {
            s *= p;
            index++;
            if (s > r) break;
        }
        return index;
    }
}