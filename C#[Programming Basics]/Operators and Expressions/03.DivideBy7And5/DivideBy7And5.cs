using System;

class DivideBy7And5
{
    static void Main()
    {
        // Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
        Console.WriteLine("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());

        Console.WriteLine(integer % 5 == 0 && integer % 7 == 0 ? "The number can be divided by 5 and 7" : "The number cannot be divided by 5 and 7");
        
    }
}

