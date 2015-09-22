using System;
using System.Numerics;


class PetarsGame
{
    static void Main()
    {
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string replacingString = Console.ReadLine();
        BigInteger sum = 0;
        string result = "";
        for (ulong i = startNumber; i < endNumber; i++)
        {
            if (i % 5 ==0 )
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }

        string sumAsString = sum.ToString(); // need the sum as a string in order to take the digits.

        if (sum % 2 == 0)
        {
            
            for (int i = 0; i < sumAsString.Length ; i++)
            {
                char firstDigit = sumAsString[0];
                if (sumAsString[i] == firstDigit)
                {
                    result += replacingString;
                }
                else
                {
                    result += sumAsString[i];
                }
                
            }
        }
        else if (sum % 2 == 1)
        {
            
            for (int i = 0; i < sumAsString.Length ; i++)
            {
                char lastDigit = sumAsString[sumAsString.Length - 1];
                if (sumAsString[i] == lastDigit)
                {
                    result += replacingString;
                }
                else
                {
                    result += sumAsString[i];
                }

            }
        }
        Console.WriteLine(result);
    }
}

