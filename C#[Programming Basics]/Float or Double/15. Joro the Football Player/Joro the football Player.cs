using System;

    class JoroThePlayer
    {
        static void Main()
        {
            Console.Write("Enter if the year is leap with \"t\" or not leap with \"f\": ");
            string leapYear = Console.ReadLine();

            Console.Write("Enter the number of the holidays:");
            short holidays = short.Parse(Console.ReadLine());

            Console.Write("Enter how many weeks is Joro in his hometown:");
            byte hometownWeeks = byte.Parse(Console.ReadLine());

            int weekends = 52;
            int normalWeekends = weekends - hometownWeeks;
            double footballWeekends = normalWeekends * 2 / 3;
            double footballPlayed = (holidays/2) + footballWeekends + hometownWeeks;

            if (leapYear == "t"){
                footballPlayed+=3;
            }
            Console.WriteLine(footballPlayed);
        }
    }

