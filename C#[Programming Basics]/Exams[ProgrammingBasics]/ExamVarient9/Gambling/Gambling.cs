using System;
using System.Collections.Generic;
class Gambling
{
    static void Main()
    {
        
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
                        

        Dictionary<string, int> card = new Dictionary<string, int>
       {
           {"2", 2},
           {"3", 3},
           {"4", 4},
           {"5", 5},
           {"6", 6},
           {"7", 7},
           {"8", 8},
           {"9", 9},
           {"10", 10},
           {"J", 11},
           {"Q", 12},
           {"K", 13},
           {"A", 14}
       };

        double bet = double.Parse(Console.ReadLine());
        string[] hand = Console.ReadLine().Split(' ');

        int points = 0;
        for (int i = 0; i < hand.Length; i++)
        {

            points += card[hand[i]];
        }

        int betterHand = 0;
        int allPossibleVariants = 0;
        int strength = 0;
        for (int c1 = 0; c1 < cards.Length; c1++)
        {
            for (int c2 = 0; c2 < cards.Length; c2++)
            {
                for (int c3 = 0; c3 < cards.Length; c3++)
                {
                    for (int c4 = 0; c4 < cards.Length; c4++)
                    {
                        strength = card[cards[c1]] + card[cards[c2]] + card[cards[c3]] + card[cards[c4]];
                        allPossibleVariants++;
                        if(strength > points)
                        {
                            betterHand++;
                        }

                    }
                }
            }
        }

        double percentage = (double)betterHand / allPossibleVariants;
        double expectedWining = (bet * 2) * percentage;
        percentage = percentage * 100;
        
        if (percentage < 50)
        {
            Console.WriteLine("FOLD");
            Console.WriteLine("{0:F2}", expectedWining);
        }
        else
        {
            Console.WriteLine("DRAW");
            Console.WriteLine("{0:F2}", expectedWining);
        }
        

    }
}

