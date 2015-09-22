using System;

class CalculateGCD
{
    static void Main()
    {
        // Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean algorithm (find it in Internet). 

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int gcd = 0;
        int result = 0;

        while(a >= 0 || b >= 0)
        {

            if (a == 0)
            {
                gcd = b;
                break;
            }
            if (b == 0)
            {
                gcd = a;
                break;
            }

            result = a % b;
            a = b;
            b = result;


        }
        Console.WriteLine(gcd);
    }
}

