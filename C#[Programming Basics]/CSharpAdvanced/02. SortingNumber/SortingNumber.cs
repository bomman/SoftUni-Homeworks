using System;
using System.Collections.Generic;
class SortingNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> listOfNumbers = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            listOfNumbers.Add(number);
        }

        listOfNumbers.Sort();
        foreach (var number in listOfNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

