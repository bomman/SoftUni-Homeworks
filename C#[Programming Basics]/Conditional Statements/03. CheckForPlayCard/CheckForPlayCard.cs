using System;

class CheckForPlayCard
{
    static void Main()
    {
        string card = Console.ReadLine();
        for (int i = 2; i < 11; i++)
        {
            if (card == i.ToString())
            {
                Console.WriteLine("yes");
                return;
            }
        }
        if (card == "J")
        {
            Console.WriteLine("yes");
        }
        else if (card == "Q")
        {
            Console.WriteLine("yes");
        }
        else if (card == "K")
        {
            Console.WriteLine("yes");
        }
        else if (card == "A")
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
