using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        //Write a program that reads 3 real numbers from the console and prints their sum.

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the numbers is:{0}", firstNumber + secondNumber + thirdNumber);

    }
}

