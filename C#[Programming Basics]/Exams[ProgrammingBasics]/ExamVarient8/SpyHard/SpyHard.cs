using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
class SpyHard
{
    static void Main()
    {
        int numeralSystem = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        int result = 0;

        for (int i = 0; i < message.Length; i++)
        {
            if(char.IsLetter(message[i]))
            {
                result += GetValueOfLetter(message[i]);
            }
            else
            {
                result += message[i];
            }
        }

        Console.WriteLine(Convert.ToString(numeralSystem, 10) + Convert.ToString(message.Length, 10) + DecimalToBase(result, numeralSystem));
      

    }



    private static int GetValueOfLetter(char letter)
    {
        int alphabetNumber = 0;
        if (letter < 91)
        {
            alphabetNumber = letter - 64;
        }
        else
        {
            alphabetNumber = letter - 96;
        }
        return alphabetNumber;
    }
 
    public static string DecimalToBase(long decimalNumber, int numeralSystem)
    {
        string result = "";
        while (decimalNumber > 0)
        {
            // calculating remainder, after the input number
            // is divided by the number representing the numeral system
            // and we obtain the input number's digits
            long digit = decimalNumber % numeralSystem;

            if (digit >= 0 && digit <= 9)
            // example: '9' = 57 (ASCII code); '0' = 48; hence 9 - '0' = 9 + 48 = 57,
            // which is exactly the ASCII code of the char '9'
            // and the result is actually a string of chars, representing the separate digits of the number
            {
                result += (char)(digit + '0'); // we add one more char to the string representation of the number
            }

            // if a digit is > 9, it can only be A, B, etc.
            //from the hexadecimal numeral system
            else
            {
                result += (char)(digit + '7');
                // example: 'A' = 65 (ASCII code); '7' = 55; hence A + '7' = 10 + 55 = 65,
                // which is exactly the ASCII code of the char 'A'
            }

            // we divvide the decimal number by the number representing the numeral system,
            // so that we can re-apply the code below, and keep extracting digits,
            // until the decimal number has no more digits
            // and all its digits have been converted to chars,
            // and added to the string representation of the result number
            decimalNumber /= numeralSystem;
        }
        var reversed = result.Reverse(); // we will extract the digits in reversed order, so we need to reverse the order back to the correct one
        string output = string.Join("", reversed);
        return output;
    }

}

