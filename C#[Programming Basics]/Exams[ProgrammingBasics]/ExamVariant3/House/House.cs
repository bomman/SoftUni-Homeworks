using System;

class House
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', (int)(number - 1) / 2) + '*' + new string('.', (int)(number - 1) / 2));

        for (int i = 1; i <= number - 4; i += 2)
        {
            int dotsCount = number - 2;
            int dotsCenter = i;
            int dotsAside = (dotsCount - dotsCenter) / 2;
            Console.Write(new string('.', dotsAside) + '*' + new string('.', dotsCenter) + '*' + new string('.', dotsAside));
            Console.WriteLine();
        }
        Console.WriteLine(new string('*', (int)number));
      


        int wallDistance = number / 4;

        for (int i = number / 2 + 1; i < number - 1; i++)
        {
            Console.Write(new string('.', wallDistance));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', number - 2 * wallDistance - 2));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', wallDistance));
        }

        Console.Write(new string('.', wallDistance));
        Console.Write(new string('*', number - 2 * wallDistance));
        Console.WriteLine(new string('.', wallDistance));
    }
}




