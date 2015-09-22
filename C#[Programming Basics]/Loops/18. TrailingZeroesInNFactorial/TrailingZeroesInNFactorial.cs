using System;
using System.Numerics;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string factorialN = Factorial(n).ToString();
        int trailZeros = 0;
        for (int i = factorialN.Length - 1; i >= 0; i--)
        {
            while (factorialN[i] == '0')
            {
                trailZeros++;
                break;
            }
            if (factorialN[i] != '0')
            {
                break;
            }
            
            
        }
        Console.WriteLine(trailZeros);

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

