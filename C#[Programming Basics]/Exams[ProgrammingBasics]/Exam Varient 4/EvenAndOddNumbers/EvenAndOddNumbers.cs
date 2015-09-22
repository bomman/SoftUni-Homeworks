using System;
using System.Threading;
using System.Globalization;

class EvenAndOddNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string elements = Console.ReadLine();
        string[] elementsNumbers = elements.Split(' ');
        
        double oddSum = 0;
        double oddMax = double.MinValue;
        double oddMin = double.MaxValue;
        double evenSum = 0;
        double evenMax = double.MinValue;
        double evenMin = double.MaxValue;

       
     
        for (int i = 0; i < elementsNumbers.Length; i++)
        {
            double element = double.Parse(elementsNumbers[i]);
            if ((i+1) % 2 == 1)
            {
                oddSum += element;
                if (element > oddMax)
                {
                    oddMax = element;
                }
                if (element < oddMin)
                {
                    oddMin = element;
                }
            }
            if ((i + 1) % 2 == 0)
            {
                evenSum += element;
                if (element > evenMax)
                {
                    evenMax = element;
                }
                if (element < evenMin)
                {
                    evenMin = element;
                }
            }
        }

        oddSum = WithoutTrailingZeros(oddSum);
        evenSum = WithoutTrailingZeros(evenSum);
        oddMax = WithoutTrailingZeros(oddMax);
        oddMin = WithoutTrailingZeros(oddMin);
        evenMax = WithoutTrailingZeros(evenMax);
        evenMin = WithoutTrailingZeros(evenMin);

        if (elementsNumbers.Length <= 1)
        {
            if (elementsNumbers.Length == 0)
            {
                Console.Write("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No ");
            }
            else
            {
                Console.Write("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No ", oddSum, oddMin, oddMax);
            }
        }
        else
        {
            Console.Write("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5} ", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
        
    }
    static double WithoutTrailingZeros(double number)
    {
        string numberInString = number.ToString();
       
        for (int i = numberInString.Length - 1; i > 0; i--)
        {
            
            while(numberInString[i] == '0')
            {
                number = number % 10; 
                i--;
            }
            break;
        }
        return number;
   
        

    }
}

