using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        // We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. 



        Console.Write("Enter the number which's bit you want to check: ");
        int integer = int.Parse(Console.ReadLine());

        Console.Write("Enter the bit position: ");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of the bit you want to implant: ");
        int v = int.Parse(Console.ReadLine());

        int result = 0;

        if (v == 0)
        {
            int mask = ~(1 << position);
            result = integer & mask;

        }
        else if (v == 1)
        {
            int mask = 1 << position;
            result = integer | mask;

        }

        Console.WriteLine(result);
    }
}

