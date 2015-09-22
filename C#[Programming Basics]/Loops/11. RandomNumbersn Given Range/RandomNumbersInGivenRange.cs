
using System;


class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            int randomNumber = random.Next(Math.Min(min, max), Math.Max(min, max) + 1);
            Console.Write(randomNumber + " ");
        }
    }
}

