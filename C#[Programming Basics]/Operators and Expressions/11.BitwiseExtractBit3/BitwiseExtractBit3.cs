using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        // Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0

        int bitThree = 3;

        Console.Write("Enter the number which's bit you want to check: ");
        int integer = int.Parse(Console.ReadLine());

        int mask = 1 << bitThree;
        int integerAndMask = integer & mask;
        int theBitIs = integerAndMask >> bitThree;
        Console.WriteLine(theBitIs);
    }
}

