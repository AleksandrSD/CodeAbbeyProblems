//Problem reference:http://www.codeabbey.com/index/task_view/neumanns-random-generator
using System;
class Program
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        string[] array = inputStr.Split();
        for (int i = 0; i < array.Length; i++) NRG(array[i]);
        Console.ReadLine();
    }

    static void NRG(string str) //NeumansRandomGenerator
    {
        int value = Convert.ToInt32(str);
        int[] trap = { 4100, 8100, 6100, 2100 };
        int i = 0, j = 0;

        while (true)
        {
            value = ((value * value) / 100) % 10000;
            if (value == trap[0] || value == trap[1] || value == trap[2] || value == trap[3]) j++;
            if (value == trap[0] && j > 0 || value == trap[1] && j > 0 || value == trap[2] && j > 0 || value == trap[3] && j > 0)
            {
                Console.Write(i + 5 + " ");
                break;
            }
            i++;
        }
    }
}