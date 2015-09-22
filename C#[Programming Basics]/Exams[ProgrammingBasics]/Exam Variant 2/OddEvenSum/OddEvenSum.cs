using System;
using System.Linq;
class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] oddNumber = new long[n];
        long[] evenNumber = new long[n];

        for (int i = 0; i < n; i++)
        {

            oddNumber[i] = long.Parse(Console.ReadLine());
            evenNumber[i] = long.Parse(Console.ReadLine()); // even numbers 


        }

        long sumOfOddNumbers = oddNumber.Sum(); // odd numbers sum

        long sumOfEvenNumbers = evenNumber.Sum();

        if (sumOfOddNumbers == sumOfEvenNumbers)
        {
            Console.WriteLine("Yes, sum={0}", sumOfOddNumbers);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Max(sumOfEvenNumbers, sumOfOddNumbers) - Math.Min(sumOfOddNumbers, sumOfEvenNumbers));
        }
    }
}

