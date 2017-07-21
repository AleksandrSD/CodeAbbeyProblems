//Problem reference:http://www.codeabbey.com/index/task_view/array-counters
using System;
class Programm
{
    static void Main()
    {
        Numerator(Console.ReadLine());
        Console.ReadKey();
    }

    static void Numerator(string inputStr)
    {
        string[] inputDigits = inputStr.Split(' ');
        int[] digitsArray = new int[inputDigits.Length];

        for (int i = 0; i < inputDigits.Length; i++)
        {
            digitsArray[i] = Convert.ToInt32(inputDigits[i]);
        }

        int maxVolume = 0;
        for (int i = 0; i < digitsArray.Length; i++)
        {
            if (digitsArray[i] > maxVolume)
                maxVolume = digitsArray[i];
        }
        maxVolume++;
        int[] numerator = new int[maxVolume];

        for (int i = 0; i < digitsArray.Length; i++)
        {
            int a = digitsArray[i];
            numerator[a]++;
        }

        for (int i = 1; i < numerator.Length; i++)
        {
            Console.Write(numerator[i] + " ");
        }
    }
}