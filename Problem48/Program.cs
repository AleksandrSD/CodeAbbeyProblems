//Problem reference:http://www.codeabbey.com/index/task_view/collatz-sequence
using System;
class Programm
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        string[] digitsArray = inputStr.Split(' ');
        for (int i = 0; i < digitsArray.Length; i++)
        {
            Console.Write(CollatzSequence(digitsArray[i]) + " ");
        }
        Console.ReadKey();
    }

    static int CollatzSequence(string a)
    {
        int x = Convert.ToInt32(a);
        int index = 0;
        while (x != 1)
        {
            if (x % 2 == 0)
            {
                x /= 2;
            }
            else
            {
                x = x * 3 + 1;
            }
            index++;
        }
        return index;
    }
}