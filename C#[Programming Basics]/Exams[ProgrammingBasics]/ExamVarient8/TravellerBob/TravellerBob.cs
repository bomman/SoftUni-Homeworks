using System;

class TravellerBob
{
    static void Main()
    {
        string leaprOrNot = Console.ReadLine();
        int contractMonth = int.Parse(Console.ReadLine());
        int familyMonth = int.Parse(Console.ReadLine());
        double normalMonth = 12 - (contractMonth + familyMonth);


        double travelling = contractMonth * 3 * 4; // 3 times a week by for 4 weeks in a month and by a number of months
        travelling += familyMonth * 2 * 2; // 2 times a week by for 2 weeks in a month and by a number of months
        travelling += normalMonth * 12 * 3 / 5;

        if (leaprOrNot == "leap")
        {
            travelling = Math.Floor(travelling + (travelling * 5 / 100));
        }
        else
        {
            travelling = Math.Floor(travelling);
        }
        Console.WriteLine(travelling);
    }
}

