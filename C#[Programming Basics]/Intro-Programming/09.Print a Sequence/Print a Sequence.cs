using System;

class Program
{
    static void Main()
    {
        int numberToPrint = 0;
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                numberToPrint = i;
            }
            else
            {
                numberToPrint = i * (-1);
            }
            Console.Write(numberToPrint + " ");
        }
    }
}

