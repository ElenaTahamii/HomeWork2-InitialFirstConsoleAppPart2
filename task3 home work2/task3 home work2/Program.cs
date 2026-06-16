
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;


class Program
{
    public static void Main()
    {

        Console.Write("Enter your number  1:  ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your number  2:  ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Statistics.AnalyesNumber( num1, ref num2, out int num3);
        Console.WriteLine( num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
    }

    class Statistics
    {
        public int num1;
        public int num2;
        public int num3;

        public static void AnalyesNumber(int num1, ref int num2, out int num3)
        {

            num3 = num1 + num2;
            num2 *= num2;


        }


    }
}
//  Console.Write("Enter your number  3 ");
//   int num3 = Convert.ToInt32(Console.ReadLine());