using System;

    class IsoscelesTriangle
    {
        static void Main()
        {
            //Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
            char copyright = '\u00a9';

            Console.WriteLine("Another triangle:");
            Console.WriteLine(new string(' ', 3) + copyright + new string(' ', 3));
            Console.WriteLine();
            Console.WriteLine(new string(' ', 2) + copyright + new string(' ', 1) + copyright + new string(' ', 2));
            Console.WriteLine();
            Console.WriteLine(new string(' ', 1) + copyright + new string(' ', 3) + copyright + new string(' ', 1));
            Console.WriteLine();
            Console.WriteLine(copyright + new string(' ', 1) + copyright + new string(' ', 1) + copyright + new string(' ', 1) + copyright);
        }
    }

