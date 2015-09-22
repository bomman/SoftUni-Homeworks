using System;

class OddAndEvenProduct
{
    static void Main()
    {
        // You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 

        string elements = Console.ReadLine();
        string[] elementsNumbers = elements.Split(' ');
        
        int sumOfEvenNumbers = 1 ;
        int sumOfOddNumbers = 1;

        for (int i = 0; i < elementsNumbers.Length; i++)
        {
            int element = int.Parse(elementsNumbers[i]);
            if ((i + 1) % 2 == 1)
            {
                sumOfOddNumbers *= element;
            }

            else if ((i + 1) % 2 == 0)
            {
                sumOfEvenNumbers *= element;
            }
           
        }

        if (sumOfEvenNumbers == sumOfOddNumbers)
        {
            Console.WriteLine("Yes");

            Console.WriteLine("Product:{0}", sumOfEvenNumbers);
        }
        else
        {
            Console.WriteLine("No");

            Console.WriteLine("Even product:{0}", sumOfEvenNumbers);
            Console.WriteLine("Odd product:{0}", sumOfOddNumbers);
        }
    }
}

