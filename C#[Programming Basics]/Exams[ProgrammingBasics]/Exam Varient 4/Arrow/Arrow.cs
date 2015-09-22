using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int numberOfRowsAndCols = (n * 2) - 1; // I need this commutement
        Console.Write(new string('.', (numberOfRowsAndCols - n)/2) + new string ('#', n) + new string('.', (numberOfRowsAndCols - n)/2));
        Console.WriteLine();
        int midDieses = (n + 1) / 2;
        int halfOfArrow = n - 2; // because of the first line that is written manually and the line in the center of the Arrow.
        for (int i = 1; i <= halfOfArrow; i++)
        {           
            int diesCount = 2;
            int asideDotsCount = (numberOfRowsAndCols - n)/2;
            int dotsCenterCount = numberOfRowsAndCols - (diesCount + (numberOfRowsAndCols - n));

            Console.Write(new string('.', asideDotsCount) + new string('#', diesCount / 2) + new string('.', dotsCenterCount) + new string('#', diesCount / 2) + new string('.', asideDotsCount));
            Console.WriteLine();
        }

        Console.Write(new string('#', midDieses) + new string('.', numberOfRowsAndCols - (midDieses * 2)) + new string('#', midDieses));
        Console.WriteLine();

        for (int i = 1; i <= halfOfArrow; i++)
        {
            int diesCount = 2;
            int asideDotsCount = i;
            int dotsCenterCount = numberOfRowsAndCols - (diesCount + (asideDotsCount * 2));

            Console.Write(new string('.', asideDotsCount) + new string('#', diesCount / 2) + new string('.', dotsCenterCount) + new string('#', diesCount / 2) + new string('.', asideDotsCount));
            Console.WriteLine();
        }

        Console.Write(new string('.', (numberOfRowsAndCols - 1) / 2) + new string('#', 1) + new string('.', (numberOfRowsAndCols - 1) / 2));
        Console.WriteLine();
    }
}

