using System;


    class WorkHours
    {
        static void Main()
        {

            long neededHours = long.Parse(Console.ReadLine());     
            double availableDays = double.Parse(Console.ReadLine());
            short productivity = short.Parse(Console.ReadLine());
            double workHours = (availableDays - (availableDays / 10)) * 12;           
            double vancheWillFinishFor = Convert.ToInt32(Math.Floor((workHours * productivity) / 100));       
          

            if (vancheWillFinishFor >= neededHours)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(vancheWillFinishFor- neededHours);
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine(vancheWillFinishFor - neededHours);
            }
        }
    }

