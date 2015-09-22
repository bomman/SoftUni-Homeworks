using System;

    class NumberComparer
    {
        static void Main()
        {
            // Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. 

            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The bigger one is:{0} ", Math.Max(a, b));
            
        }
    }

