//Problem reference:http://www.codeabbey.com/index/task_view/modular-calculator
using System;
using System.Numerics;

class Programm
{
    static void Main()
    {
        Console.Write("Please, Enter you digit: ");

        BigInteger a = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            Console.Write("Whitch sign?: ");
            char o = (char)Console.Read();
            if (o == '+')
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a += x;
                Console.WriteLine(a);
            }
            else if (o == '*')
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a *= x;
                Console.WriteLine(a);
            }
            else if (o == '-')
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a -= x;
                Console.WriteLine(a);
            }
            else if (o == '%')
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a = a % x;
                break;
            }
        }
        Console.WriteLine(a);
        Console.ReadKey();
    }
}