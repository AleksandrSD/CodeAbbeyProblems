//Problem reference:http://www.codeabbey.com/index/task_view/reverse-string
using System;
class Programm
{
    static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine(Method(text));
        Console.ReadKey();
    }

    static string Method(string text)
    {
        string reverse = null;

        for (int i = text.Length - 1; i > 0; i--)
        {
            reverse += text[i];
        }
        reverse += text[0];

        return reverse;
    }
}