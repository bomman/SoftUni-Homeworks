using System;

class MatrixOfNumbers
{
    static void Main()
    {
        // Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 

        int n = int.Parse(Console.ReadLine());
        for (int rows = 1; rows <= n; rows++)
        {
            
            for (int row = rows; row < n + rows; row++)
            {
               

                Console.Write(row + " ");
                
            }
            Console.WriteLine();
        }
    }
}

