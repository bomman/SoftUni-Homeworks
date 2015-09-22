using System;

class CalculateNFactorialDividedByK
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        short k = short.Parse(Console.ReadLine());
        decimal result = 0;

        if (n > 100)
        {
            Console.WriteLine("Invalid number n.");
        }
        else if (k > n)
        {
            Console.WriteLine("Invalid number k.");
        }
        else
        {
            result = Factorial(n) / Factorial(k);
            Console.WriteLine(result);
        }
        
    }
    static decimal Factorial(int factorialNum)
    {
        int result = 1;
        for (int i = 1; i <= factorialNum; i++)
        {
            result *= i;
        }
        return result;
    }
}

