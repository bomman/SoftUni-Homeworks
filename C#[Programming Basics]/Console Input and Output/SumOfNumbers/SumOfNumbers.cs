using System;

class SumOfNumbers
{
    static void Main()
    {
        // Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. 

        Console.Write("Enter how many numbers you want to sum: ");
        int count = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i <= count; i++)
        {
            Console.Write("Add a number: ");
            double n = double.Parse(Console.ReadLine());
            sum += n;
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}

