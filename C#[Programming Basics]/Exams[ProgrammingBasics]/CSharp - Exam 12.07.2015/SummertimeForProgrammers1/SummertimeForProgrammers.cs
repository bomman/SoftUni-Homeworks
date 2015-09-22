using System;

class SummertimeForProgrammers
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
        int widthOfTop = number + 1;
        int widthOfBottle = number * 2;
        Console.WriteLine(new string(' ', number / 2) + new string('*', widthOfTop));
        for (int i = 0; i < (number / 2) + 1; i++)
        {
            Console.WriteLine(new string(' ', number / 2) + '*' + new string(' ', widthOfTop - 2) + '*' );
        }
        if (number > 3)
        {
          
           
        for (int i = widthOfTop; i < widthOfBottle - 2; i+=2)
        {
            int whiteSpacesCenter = i;
            Console.WriteLine(new string(' ', (widthOfBottle - i - 2) / 2) + '*' + (new string(' ', i) + '*'));
        }
        }
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine('*' + new string('.', widthOfBottle - 2) + '*');
        }
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine('*' + new string('@', widthOfBottle - 2 ) + '*');
        }
        Console.WriteLine(new string('*', widthOfBottle ));

    }
}

