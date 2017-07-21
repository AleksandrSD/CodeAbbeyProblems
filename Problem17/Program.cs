//Problem reference:http://www.codeabbey.com/index/task_view/array-checksum
using System;
class Programm
{
    static void Main()
    {
        string x = Console.ReadLine();
        Console.WriteLine(Checksum(x));

        Console.ReadKey();
    }

    static ulong Checksum(string x)
    {
        string[] b = x.Split(' ');
        ulong[] a = new ulong[b.Length];
        for (int i = 0; i < b.Length; i++)
        {
            a[i] = Convert.ToUInt64(b[i]);
        }
        ulong result = 0;
        int limit = 10000007, seed = 113;

        for (int i = 0; i < a.Length; i++)
        {
            result = (result + a[i]) * (ulong)seed;
            result = result % (ulong)limit;
        }

        return result;
    }
}