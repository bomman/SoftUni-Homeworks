using System;
using System.Collections.Generic;

class RandomizeOneToN
{
    static void Main()
    {
        // Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

        int n = int.Parse(Console.ReadLine());
        Random randomNumbers = new Random();
        int[] arrayOfRandomNumbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            
            arrayOfRandomNumbers[i] = i + 1;
            
        }
        foreach (var randomNumber in GetRandomNumbers(n, n))
        {
            Console.Write(arrayOfRandomNumbers[randomNumber] + " ");
        } 
       
    }
    public static List<int> GetRandomNumbers(int count, int max)
    {
        List<int> randomNumbers = new List<int>();
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int number;

            do number = random.Next(0, max);
            while (randomNumbers.Contains(number));

            randomNumbers.Add(number);
        }

        return randomNumbers;
    }
}

