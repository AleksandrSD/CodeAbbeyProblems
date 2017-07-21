//Problem reference:http://www.codeabbey.com/index/task_view/body-mass-index
using System;
using System.Threading;
using System.Globalization;

class Programm
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Console.Write("How much testcases?: ");
        int x = Convert.ToInt32(Console.ReadLine());
        double[,] BodyCharacter = new double[x, 2];
        for (int i = 0, j = 1; i < BodyCharacter.GetLength(0); i++)
        {
            Console.Write("Enter testcases №{0}: ", j++);
            string supportStr = Console.ReadLine();
            string[] sArray = supportStr.Split(' ');
            BodyCharacter[i, 0] = Convert.ToDouble(sArray[0]);
            BodyCharacter[i, 1] = Convert.ToDouble(sArray[1]);
        }

        for (int i = 0; i < BodyCharacter.GetLength(0); i++)
        {
            Console.Write(BMI(BodyCharacter[i, 0], BodyCharacter[i, 1]) + " ");
        }
        Console.ReadKey();
    }

    static string BMI(double weight, double height)
    {
        double bmi = Math.Round(weight / (height * height), 2);
        string massCategory = "Unknown";
        if (bmi < 18.5) massCategory = "under";
        if (bmi > 18.5 && bmi < 25.0) massCategory = "normal";
        if (bmi > 25.0 && bmi < 30.0) massCategory = "over";
        if (bmi > 30.0) massCategory = "obese";

        return massCategory;
    }
}