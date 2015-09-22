using System;

    class Age
    {
        static void Main()
        {
            int birthdayYear = 1993;
            int currentYear = 2015;
            int myAge = currentYear - birthdayYear;
            Console.WriteLine("I am {0} years old and I will be {1} after 10 years", myAge, (myAge + 10));
        }
    }

