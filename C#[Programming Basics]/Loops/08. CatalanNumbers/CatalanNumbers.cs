using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        
        BigInteger CatalanNumber = 0;

        if (n > 100 || n < 1)
        {
            Console.WriteLine("Invalid number n.");
        }
        
        else
        {
            CatalanNumber = Factorial(n * 2) / (Factorial(n + 1) * Factorial(n));
            Console.WriteLine(CatalanNumber);
        }
    }
    static BigInteger Factorial(int factorialNum)
    {
        BigInteger result = 1;
        for (int i = 1; i <= factorialNum; i++)
        {
            result *= i;
        }
        return result;
    }
}

