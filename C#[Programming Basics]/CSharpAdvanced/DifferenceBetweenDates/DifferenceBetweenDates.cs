using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime startDate = DateTime.Parse(Console.ReadLine());
     
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        double daysBetween = (endDate - startDate ).TotalDays;
        Console.WriteLine(daysBetween);
    }
}

