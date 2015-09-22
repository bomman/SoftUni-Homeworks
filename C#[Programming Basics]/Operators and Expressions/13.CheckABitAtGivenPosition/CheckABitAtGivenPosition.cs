using System;

    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            // Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. 

            Console.Write("Enter the number which's bit you want to check: ");
            int integer = int.Parse(Console.ReadLine());

            Console.Write("Enter the bit position you want to check if it is 1: ");
            int bitPosition = int.Parse(Console.ReadLine());           

            int mask = 1 << bitPosition;
            int integerAndMask = integer & mask;
            int theBitIs = integerAndMask >> bitPosition;
            Console.WriteLine(theBitIs == 1 ? "true" : "false");

            
        }
    }

