using System;

class Numerology
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] yearsAndUsername = input.Split(' ', '.');

        int date = int.Parse(yearsAndUsername[0]);
        int month = int.Parse(yearsAndUsername[1]);
        int year = int.Parse(yearsAndUsername[2]);

        long productOfDate = date * month * year;

        if (month % 2 == 1)
        {
            productOfDate = (long)Math.Pow(productOfDate, 2);
        }

        int sumOfUsernameCharacters = 0;
        for (int i = 0; i < yearsAndUsername[3].Length; i++)
        {
            if(char.IsLetter(yearsAndUsername[3][i]))
            {
                sumOfUsernameCharacters += GettingTheAlphabeticalOrderOfLetter(yearsAndUsername[3][i]);
            }
            else
            {
                sumOfUsernameCharacters += yearsAndUsername[3][i] - '0';
            }
         
        }

        long dateAndUsername = productOfDate + sumOfUsernameCharacters;
        
        if( dateAndUsername > 13)
        {
            string stringOfDateAndUsername = Convert.ToString(dateAndUsername, 10);

            int dateAndUsernameDigitsSum = 15; // to be able to get inside the while condition

            while(dateAndUsernameDigitsSum > 13)
            {
                dateAndUsernameDigitsSum = 0; // reverting to zero to safe the sum of the new number;
                for (int i = 0; i < stringOfDateAndUsername.Length; i++)
                {
                    dateAndUsernameDigitsSum += stringOfDateAndUsername[i] - '0';
                }
                stringOfDateAndUsername = Convert.ToString(dateAndUsernameDigitsSum, 10);
              
            }
            Console.WriteLine(dateAndUsernameDigitsSum);
        }
        else
        {
            Console.WriteLine(dateAndUsername);
        }
    }

    private static int GettingTheAlphabeticalOrderOfLetter(char letter)
    {
        int alphabeticOrder = 0;

        if(letter > 91)
        {
            alphabeticOrder = letter - 96;
        }
        else
        {          
                alphabeticOrder = (letter - 64) * 2;
        }
        return alphabeticOrder;
    }
}
