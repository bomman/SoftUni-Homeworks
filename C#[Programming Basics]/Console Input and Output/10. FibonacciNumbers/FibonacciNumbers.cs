using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            // Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. 

            int n = int.Parse(Console.ReadLine());
            int a = 0; // start of fibonacci
            int b = 1;
            int sum = 0; 
            for (int i = 0; i < n; i++)
            {

                Console.Write(a + " ");
                sum = a + b;              
                a = b;            
                b = sum;
                
            }
        }
    }

