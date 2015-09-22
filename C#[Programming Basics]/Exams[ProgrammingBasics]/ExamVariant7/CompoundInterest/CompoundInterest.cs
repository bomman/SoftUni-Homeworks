using System;

class CompoundInterest
{
    static void Main()
    {
        decimal prize = decimal.Parse(Console.ReadLine());
        int bankTerm = int.Parse(Console.ReadLine());
        double bankInterest = double.Parse(Console.ReadLine());
        double friendInterest = double.Parse(Console.ReadLine());

        decimal moneyOwedToBank = prize * (decimal)Math.Pow(1 + bankInterest, bankTerm);
        decimal moneyOwedToFriend = prize * (decimal)(1 + friendInterest);

        if (moneyOwedToBank == moneyOwedToFriend)
        {
            Console.WriteLine("{0:F2} Friend", moneyOwedToFriend);
        }
        else
        {
            Console.WriteLine("{0:F2} {1}", Math.Min(moneyOwedToFriend, moneyOwedToBank), moneyOwedToBank < moneyOwedToFriend ? "Bank" : "Friend");
        }
    }
}

