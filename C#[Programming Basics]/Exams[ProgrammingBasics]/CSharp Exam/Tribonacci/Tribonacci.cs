using System;
using System.Numerics;

    class Tribonacci
    {
        static void Main()
        {
            BigInteger firstNumber = long.Parse(Console.ReadLine());
            BigInteger secondNumber = long.Parse(Console.ReadLine());
            BigInteger thirdNumber = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            if (n == 1)
            {
                Console.WriteLine(firstNumber);
            }
            else if (n == 2)
            {
                Console.WriteLine(secondNumber);
            }
            else if (n == 3)
            {
                Console.WriteLine(thirdNumber);
            }

            else
            {

                BigInteger sum = 0;
                for (int i = 4; i <= n; i++)
                {


                    sum = firstNumber + secondNumber + thirdNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = sum;

                }
                Console.WriteLine(sum);
            }

           
        }
    }

