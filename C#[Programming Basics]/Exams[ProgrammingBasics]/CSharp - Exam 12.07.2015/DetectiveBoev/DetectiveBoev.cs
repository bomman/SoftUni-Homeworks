using System;

class DetectiveBoev
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string encrypteMessage = Console.ReadLine();

        int sumOfChars = 0;
        for (int i = 0; i < secretWord.Length; i++)
        {
            sumOfChars += secretWord[i];
        }

        int mask = 0;
        int digitsSum = 0;

        while (sumOfChars > 0)
        {
            digitsSum += sumOfChars % 10;
            sumOfChars = sumOfChars / 10;
           
        }
        if (digitsSum > 9)
        {

            while (digitsSum > 0)
            {
                mask += digitsSum % 10;
                digitsSum = digitsSum / 10;
            }

        }
        else
        {
            mask = digitsSum;
        }
        string decryptedMessage = "";
        for (int i = 0; i < encrypteMessage.Length; i++)
        {

            if (encrypteMessage[i] % mask == 0)
            {
                decryptedMessage += (char)(encrypteMessage[i] + mask);
            }
            else
            {
                decryptedMessage += (char)(encrypteMessage[i] - mask);
            }
        }

        string finalMessage = "";
        for (int i = decryptedMessage.Length - 1; i >= 0; i--)
        {
            finalMessage += decryptedMessage[i];
        }
        Console.WriteLine(finalMessage);
    }

}

