//Problem reference:http://www.codeabbey.com/index/task_view/matching-words
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string outStr = null;
        string str = Console.ReadLine();
        string[] sArray = str.Split(' ');
        Array.Sort(sArray);
        for (int i = 0; i < sArray.Length - 1; i++)
            if (sArray[i] == sArray[i + 1]) outStr += sArray[i] + " ";

        outStr = string.Join(" ", outStr.Split(' ').Distinct());
        Console.WriteLine(outStr);
        Console.ReadLine();
    }
}