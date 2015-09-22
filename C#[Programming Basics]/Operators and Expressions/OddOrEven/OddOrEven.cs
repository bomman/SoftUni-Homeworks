using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());

        Console.WriteLine(integer % 2 == 1 ? "the number is odd: true"  : "the number is odd: false");
        
    }
}

