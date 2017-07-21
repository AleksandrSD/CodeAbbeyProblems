//Problem reference:http://www.codeabbey.com/index/task_view/sum-of-two
using System;
class Program
{
    static void Main()
    {
        string outputStr = Console.ReadLine();
        string[] sArray = outputStr.Split(' ');
        int a = Convert.ToInt32(sArray[0]);
        int b = Convert.ToInt32(sArray[1]);
        Console.WriteLine(a + b);
        Console.ReadKey(true);
    }
}