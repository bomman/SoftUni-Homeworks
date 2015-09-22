using System;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            // Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 

              int n = int.Parse(Console.ReadLine());
              int max = int.MinValue;
              int min = int.MaxValue;
              double average = 0;
              int sum = 0;
              for (int i = 1; i <= n; i++)
              {
                  int num = int.Parse(Console.ReadLine());

                  if (num > max)
                  {
                      max = num;
                  }
                  if (num < min)
                  {
                      min = num;
                  }
                  sum += num;
                  average = average + num;
              }
            average = average / n;

            Console.WriteLine("{0}, {1}, {2}, {3: 0.00}", min, max, sum, average);
        }
    }

