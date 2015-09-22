using System;

class FullCardDeck
{
    static void Main()
    {

        LowerCards();
        HigherCards();
    }
    static void LowerCards()
    {
        char spades = '\u2663';
        char clubs = '\u2660';
        char hearts = '\u2665';
        char diamonds = '\u2666';


        for (int i = 2; i <= 10; i++)
        {
            Console.Write(i + "" + spades + " " + i + clubs + " " + i + hearts + " " + i + diamonds);
            Console.WriteLine();
        }
    }
    static void HigherCards()
    {
        char spades = '\u2663';
        char clubs = '\u2660';
        char hearts = '\u2665';
        char diamonds = '\u2666';
        

     
        for (int i = 1; i <= 4; i++)
        {
            switch (i)
            {
                case 1:
                    Console.Write("J" + spades + " " + "J" + clubs + " " + "J" + hearts + " " + "J" + diamonds);
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("Q" + spades + " " + "Q" + clubs + " " + "Q" + hearts + " " + "Q" + diamonds);
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("K" + spades + " " + "K" + clubs + " " + "K" + hearts + " " + "K" + diamonds);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("A" + spades + " " + "A" + clubs + " " + "A" + hearts + " " + "A" + diamonds);
                    Console.WriteLine();
                    break;

            }

        }
    }
}

