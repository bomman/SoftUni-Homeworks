using System;

class FloatOrDouble
{
    static void Main()
    {
        // Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.

        double longDecimal = 34.567839023;
        float shortDecimal = 12.345F;
        double againLongDecimal = 8923.1234857;
        float againShortDecimal = 3456.091F;

        Console.WriteLine("All numbers:{0}...{1}....{2}....{3}", longDecimal, shortDecimal, againLongDecimal, againShortDecimal);
    }
}

