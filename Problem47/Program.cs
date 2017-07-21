//Problem reference:http://www.codeabbey.com/index/task_view/caesar-shift-cipher
using System;
class Program
{
    static void Main()
    {
        Console.Write("How many tastcases? ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter encrypted key: ");
        int key = Convert.ToInt32(Console.ReadLine());

        string[] array = new string[x];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
            array[i] = array[i].Remove(array[i].Length - 1, 1);
        }

        for (int i = 0; i < array.Length; i++)
        {
            CaesarShiftCipher(array[i], key);
        }
        Console.ReadKey();
    }

    static void CaesarShiftCipher(string inputStr, int key)
    {
        const string alphabet = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
        string[] alphabetArray = alphabet.Split(' ');
        string[] sArray = new string[inputStr.Length];

        for (int i = 0; i < inputStr.Length; i++)
        {
            sArray[i] = Convert.ToString(inputStr[i]);
        }

        for (int i = 0; i < inputStr.Length; i++)
        {
            if (sArray[i] == " ") continue;

            for (int j = 0; j < alphabetArray.Length; j++)
            {


                if (sArray[i] == alphabetArray[j])
                {

                    if ((j - key) < 0)
                    {
                        int y = key - j;
                        int x = 26 - y;
                        sArray[i] = alphabetArray[x];
                        break;
                    }

                    if ((j - key) >= 0)
                    {
                        sArray[i] = alphabetArray[j - key];
                        break;
                    }
                }
            }
        }
        string result = null;
        for (int i = 0; i < sArray.Length; i++)
        {
            result += sArray[i];
        }
        Console.Write(result + ". ");
    }
}