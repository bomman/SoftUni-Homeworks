using System;

class Calculation
{
    static void Main()
    {
        // Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.

        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        decimal sum = 1;

        for (int i = 1 ; i <= n; i++)
        {
            sum += Factorial(i) / PowerOf(x, i);
        }
       
        Console.WriteLine("{0:0.00000}", sum);

    }

    static decimal Factorial (int factorialNum)
    {
        int result = 1;  
        for (int i = 1; i <= factorialNum; i++)
        {
            result *= i;
        }
        return result;
    }

    static decimal PowerOf (decimal poweredNum, int grade)
    {
        decimal result = 1;

        for (int i = 1; i <= grade; i++)
        {
            
            result *= poweredNum;
        }

        return result;


    }
}

