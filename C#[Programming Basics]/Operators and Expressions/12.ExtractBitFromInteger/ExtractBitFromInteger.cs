using System;

class ExtractBitFromInteger
{
    static void Main()
    {

        Console.Write("Enter the number which's bit you want to check: ");
        int integer = int.Parse(Console.ReadLine());

        Console.Write("Enter the bit position you want to check: ");
        int bitPosition = int.Parse(Console.ReadLine());
       
        int mask = 1 << bitPosition;
        int integerAndMask = integer & mask;
        int theBitIs = integerAndMask >> bitPosition;
        Console.WriteLine(theBitIs);
    }
}

