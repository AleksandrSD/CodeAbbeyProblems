//Problem reference:http://www.codeabbey.com/index/task_view/vowel-count
using System;
class Programm
{
    static void Main()
    {
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string[] words = new string[x];
        for (int i = 0, j = 1; i < words.Length; i++)
        {
            Console.Write("Enter testcases №{0}: ", j++);
            words[i] = Console.ReadLine();
        }
        for (int i = 0; i < words.Length; i++) Console.Write(Method(words[i]) + " ");
        Console.ReadKey();
    }

    static int Method(string a)
    {
        char[] vowels = { 'a', 'o', 'u', 'i', 'e', 'y' };
        int index = 0;
        char[] separator = new char[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            separator[i] = a[i];
            if (a[i] == vowels[0] || a[i] == vowels[1] || a[i] == vowels[2] || a[i] == vowels[3] || a[i] == vowels[4] || a[i] == vowels[5])
                index++;
        }
        return index;
    }
}