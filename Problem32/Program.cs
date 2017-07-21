//Problem reference:http://www.codeabbey.com/index/task_view/josephus-problem
using System;

class Programm
{
    static void Main()
    {
        Console.WriteLine("How much warriors?");
        int peopleCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Which one should I kill?");
        int killNumber = Convert.ToInt32(Console.ReadLine());
        bool[] nums = new bool[peopleCount];
        int survivors = peopleCount;
        int tmp = 0;

        while (survivors > 1)
        {
            for (int i = 0; i < killNumber;)
            {
                tmp = (tmp + 1) % peopleCount;
                if (!nums[tmp])
                    ++i;
            }

            nums[tmp] = true;
            --survivors;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (!nums[i])
            {
                Console.WriteLine(i);
                break;
            }
        }
        Console.ReadKey();
    }
}