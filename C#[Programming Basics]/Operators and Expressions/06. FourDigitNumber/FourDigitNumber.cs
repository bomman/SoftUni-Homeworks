using System;

class FourDigitNumber
{
    static void Main()
    {
//   Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).

        Console.Write("Enter a four digit number: "); 
        int fourDigitNumber = int.Parse(Console.ReadLine());

        int firstDigit = (fourDigitNumber / 1000) % 10;
        int secondDigit = (fourDigitNumber / 100) % 10;
        int thirdDigit = (fourDigitNumber / 10) % 10;
        int fourthDigit = fourDigitNumber % 10;

        Console.WriteLine("The sum of the digits is: {0}", firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("The number in reversed order: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("The last digit in first position: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("The number with the second and third digit exchanged: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}

