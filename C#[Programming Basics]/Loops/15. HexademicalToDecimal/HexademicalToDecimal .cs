using System;

class HexademicalToDecimal
{
    static void Main()
    {
        string hex = Console.ReadLine();       
        long resultindecimal = 0;
        int element = 0;

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            if (hex[i] == 'A' ||hex[i] == 'B' || hex[i] == 'C' || hex[i] == 'D' || hex[i] == 'E'|| hex[i] == 'F')
            {
                element = int.Parse(HexLettersToDecimal(hex[i]));
            }
            else
            {
                element = hex[i] - '0';
            }            

            resultindecimal += element * PowerOf(hex.Length - (i + 1));

        }
        Console.WriteLine(resultindecimal);
        

    }
    static long PowerOf(int grade)
    {
        long result = 1;
        int poweredNum = 16;
        for (int i = 1; i <= grade; i++)
        {

            result *= poweredNum;
        }

        return result;
    }

    static string HexLettersToDecimal(char hex)
    {
        string element = "";
        if (hex == 'A')
        {
           element = "10";
           
        }
        else if (hex == 'B')
        {
            element = "11";
            
        }
        else if (hex == 'C')
        {
            element = "12";
            
        }
        else if (hex == 'D')
        {
            element = "13";
            
        }
        else if (hex == 'E')
        {
            element = "14";
            
        }
        else if (hex == 'F')
        {
            element = "15";
           
        }
        return element;
       
    }
}

