using System;

class FourFactors
{
    static void Main()
    {
        double fieldGoals = long.Parse(Console.ReadLine());
        double fieldGoalsAttempts = long.Parse(Console.ReadLine());
        double threePointFieldGoals = long.Parse(Console.ReadLine());
        double turnovers = long.Parse(Console.ReadLine());
        double offensiveRebounds = long.Parse(Console.ReadLine());
        double opponentDefensiveRebounds = long.Parse(Console.ReadLine());
        double freeThrows = long.Parse(Console.ReadLine());
        double freeThrowAttempts = long.Parse(Console.ReadLine());

        double effectiveFieldGoalPercentage = (fieldGoals + (0.5 * threePointFieldGoals)) / fieldGoalsAttempts;
        double turnoverPercentage = turnovers / (fieldGoalsAttempts + 0.44 * freeThrowAttempts + turnovers);
        double offensiveReboundsPercentage = offensiveRebounds / (offensiveRebounds + opponentDefensiveRebounds);
        double freeThrowPercentage = freeThrows / fieldGoalsAttempts;

        Console.WriteLine("eFG% {0:F3}", effectiveFieldGoalPercentage);
        Console.WriteLine("TOV% {0:F3}", turnoverPercentage);
        Console.WriteLine("ORB% {0:F3}", offensiveReboundsPercentage);
        Console.WriteLine("FT% {0:F3}", freeThrowPercentage);
    }
}

