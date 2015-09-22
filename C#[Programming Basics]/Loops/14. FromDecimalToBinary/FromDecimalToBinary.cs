using System;

class FromDecimalToBinary
{
    static void Main()
    {
       // Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string

        long decimalInteger = long.Parse(Console.ReadLine()); 
        string binaryInteger = "";

        while (decimalInteger > 0)
        {
            if (decimalInteger % 2 == 1)
            {
                binaryInteger += "1";
            }
            if (decimalInteger % 2 == 0)
            {
                binaryInteger += "0";
            }
            decimalInteger /= 2;
        }
        for (int i = binaryInteger.Length - 1; i >= 0; i--)
        {
            Console.Write(binaryInteger[i]);
        }


    }

   
}

