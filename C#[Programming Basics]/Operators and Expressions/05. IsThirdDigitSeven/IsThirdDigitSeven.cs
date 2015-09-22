using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        Console.Write("Enter a number with 3 digits: ");
        int threeDigitNumber = int.Parse(Console.ReadLine());

        Console.WriteLine((threeDigitNumber / 100) % 10 == 7 ? "The third digit of the number is 7" : "The third number IS NOT 7");
    }
}

