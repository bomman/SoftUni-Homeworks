using System;


class Volleyball
{
    static void Main()
    {
        string typeOfYear = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        int hometownSpentWeekends = int.Parse(Console.ReadLine());

        double normalWeekends = 48 - hometownSpentWeekends; // all the weeks minus the ones spent in hometown.
        double playedWeekends = ((normalWeekends * 3) / 4) + hometownSpentWeekends;
        double volleyballPlayedDuringTheHolidays = (holidays * 2) / 3;
        double allVolleyballPlayed = playedWeekends + volleyballPlayedDuringTheHolidays;

        if (typeOfYear == "leap")
        {
            allVolleyballPlayed = allVolleyballPlayed + ((allVolleyballPlayed * 15) / 100);
        }

        Console.WriteLine(Math.Floor(allVolleyballPlayed));

    }
}

