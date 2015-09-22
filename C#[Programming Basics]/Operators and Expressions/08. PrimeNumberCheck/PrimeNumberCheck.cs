using System;

class PrimeNumberCheck
{
    static void Main()
    {
        // Write an expression that checks if given positive integer number n (n ≤ 100) is Prime

        Console.WriteLine("Enter a integer that smaller or equal to 100: ");

        short integer = short.Parse(Console.ReadLine());

        if (integer % 3 ==0 || integer % 5 == 0|| integer % 7 == 0)
        {
            Console.WriteLine("The number {0} is not Prime", integer);
        }
        else 
        {
            Console.WriteLine("The number {0} is Prime", integer);
        }

    }
}

