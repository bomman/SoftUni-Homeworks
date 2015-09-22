using System;

class BabaTincheAirlines
{
    static void Main()
    {

        
        string[] firstClassPassengers = Console.ReadLine().Split(' ');
        string[] businessClassPassengers = Console.ReadLine().Split(' ');
        string[] economyClassPassengers = Console.ReadLine().Split(' ');

        // firstClass

        int firstClassPassengersFrequent = int.Parse(firstClassPassengers[1]);
        int firstClassPassengersNormal = int.Parse(firstClassPassengers[0]) - firstClassPassengersFrequent;
        double firstClassPassengersWantingMeal = double.Parse(firstClassPassengers[2]);

        int ticketFirstClass = 7000;
        int ticketFirstClassFrequent = (7000 * 30) / 100;
        double mealFirstClass = (7000 * 0.5) / 100;

        double moneyFromFirstClass = (firstClassPassengersFrequent * ticketFirstClassFrequent) + (firstClassPassengersNormal * ticketFirstClass) + (firstClassPassengersWantingMeal * mealFirstClass);
        double maxMoneyFromFirstClass = 12 * 7000 + 12 * ((7000 * 0.5) / 100);
        // business class


        int businessClassPassengersFrequent = int.Parse(businessClassPassengers[1]);
        int businessClassPassengersNormal = int.Parse(businessClassPassengers[0]) - businessClassPassengersFrequent;
        double businessClassPassengersWantingMeal = double.Parse(businessClassPassengers[2]);

        int ticketBusinessClass = 3500;
        double ticketBusinessClassFrequent = (3500 * 30) / 100;
        double mealBusinessClass = (3500 * 0.5) / 100;

        double moneyFromBusinessClass = (businessClassPassengersFrequent * ticketBusinessClassFrequent + (businessClassPassengersNormal * ticketBusinessClass) + businessClassPassengersWantingMeal * mealBusinessClass);
        double maxMoneyFromBusinessClass = 28 * 3500 + 28 * ((3500 * 0.5)/ 100);
        // economy class

        int economyClassPassengersFrequent = int.Parse(economyClassPassengers[1]);
        int economyClassPassengersNormal = int.Parse(economyClassPassengers[0]) - economyClassPassengersFrequent;
        double economyClassPassengersWantingMeal = double.Parse(economyClassPassengers[2]);

        int ticketEconomyClass = 1000;
        double ticketEconomyClassFrequent = (1000 * 30) / 100;
        double mealEconomyClass = (1000 * 0.5) / 100;

        double moneyFromEconomyClass = (economyClassPassengersFrequent * ticketEconomyClassFrequent) + (economyClassPassengersNormal * ticketEconomyClass) + (economyClassPassengersWantingMeal * mealEconomyClass);
        double maxMoneyFromEconomyClass = 50 * 1000 + 50 * ((1000 * 0.5)/ 100);
        // all the money

        double moneyReceived = moneyFromBusinessClass + moneyFromEconomyClass + moneyFromFirstClass;
        double maxMoney = maxMoneyFromBusinessClass + maxMoneyFromEconomyClass + maxMoneyFromFirstClass;

        Console.WriteLine(Math.Floor(moneyReceived));
        Console.WriteLine(Math.Ceiling(maxMoney - moneyReceived));
    }
}

