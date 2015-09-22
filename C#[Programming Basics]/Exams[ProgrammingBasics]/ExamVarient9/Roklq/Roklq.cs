using System;

class Roklq
{
    static void Main()
    {
        
         int n = int.Parse(Console.ReadLine());
        int width = 3 * n;
        int dotsCenter = 0;
        int dotsEdge = 0;
        Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
        for (int i = 0; i < (n * 2) - 2; i+=4)
        {
             dotsCenter = n + 2 + i;
             dotsEdge = (width - dotsCenter - 2) / 2 ; // two asteriks;
            Console.WriteLine(new string('.', dotsEdge) + '*' + new string('.', dotsCenter) + '*' + new string('.', dotsEdge));
        }

        Console.WriteLine('*' + new string('.', (width - n - 4) / 2) + '*' + new string('.', n) + '*' + new string('.', (width - n - 4) / 2) + '*');

        

        for (int i = 1; i < n - 2; i+=2)
        {
            
            dotsCenter = n;
            dotsEdge = (width - 6 - (i * 2) - dotsCenter) / 2;

            Console.WriteLine('*' + new string('.', dotsEdge) + '*' + new string('.', i) + '*' + new string('.', n) + '*' + new string('.', i) + '*' + new string('.', dotsEdge) + '*');
        }

        for (int i = 0; i < n -1 ; i++)
        {
            dotsCenter = n + i * 2;
            dotsEdge = (width - 2 - dotsCenter) / 2;
            Console.WriteLine(new string('.', dotsEdge) + '*' + new string('.', dotsCenter) + '*' + new string('.', dotsEdge));
        }
        Console.WriteLine(new string('*', width));
    }
}

