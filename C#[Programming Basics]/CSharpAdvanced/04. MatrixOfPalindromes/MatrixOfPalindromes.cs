using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] rowsAndCols = inputLine.Split(' ');
        int rows = int.Parse(rowsAndCols[1]);
        int cols = int.Parse(rowsAndCols[0]);
        string letters = "abcdefghijklmnopqrstuvwxyz";

        int[,] m = new int[rows, cols];

        for (int c = 0; c < cols; c++)
        {
            for (int r = 0; r < rows; r++)
            {
                Console.Write(letters[c]);
                Console.Write(letters[r + c]) ;
                Console.Write(letters[c]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

