//Problem reference:http://www.codeabbey.com/index/task_view/integer-factorization
using System;
class Program
{
    static void Main()
    {
        Console.Write("How much digits?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        long[] array = new long[x];
        for (int i = 0, j = 1; i < x; i++)
        {
            Console.Write("Please, enter digits №{0}:", j++);
            array[i] = Convert.ToInt64(Console.ReadLine());
        }
        for (int i = 0; i < x; i++) Console.Write(IntegerFactorization(array[i]) + " ");
        Console.ReadKey();
    }

    static string IntegerFactorization(long a)
    {
        int z = 2;
        string rez = string.Empty;
        while (a > 1)
        {
            if (a % z == 0)
            {
                rez += z + "*";
                a /= z;
                z = 2;
            }
            else
                z++;
        }
        rez = rez.Remove(rez.Length - 1, 1);
        return rez;
    }
}