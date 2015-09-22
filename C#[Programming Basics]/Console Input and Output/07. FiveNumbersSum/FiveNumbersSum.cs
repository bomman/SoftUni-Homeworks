using System;
using System.Globalization;
using System.Threading;

class FiveNumbersSum
{
    static void Main()
    {
        // Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter five numbers separated by space:");
        string numbers = Console.ReadLine();     
        decimal sum = 0.00m;
        string[] numberAsStrings = numbers.Split(' ');
        for (int i = 0; i < numberAsStrings.Length; i++)
            if (numberAsStrings.Length > 5)
            {
                Console.WriteLine("Please enter excactly 5 numbers");
            }
            else if (numberAsStrings.Length < 5)
            {
                Console.WriteLine("Please enter excactly 5 numbers");
            }
            else
            {
                sum += decimal.Parse(numberAsStrings[i]);
               
            }
        Console.WriteLine(sum);


    }
}

