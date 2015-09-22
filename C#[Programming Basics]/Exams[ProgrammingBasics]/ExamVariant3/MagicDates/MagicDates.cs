using System;
using System.Linq;
class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        int result = 0;
        int count = 0;
        

        for (int i = startYear; i <= endYear; i++)
        {
            int[] year = new int[4];
            year[0] = (i / 1000) % 10;
            year[1] = (i / 100) % 10;
            year[2] = (i / 10) % 10;
            year[3] = i % 10;
            for (int j = 1; j <= 12; j++)
            {
                int[] month = new int[2];
                month[0] = j / 10;
                month[1] = j % 10;
                if (j == 1 || j == 3 || j == 5 || j == 7 || j == 8 || j == 10 || j == 12)
                {

                    for (int k = 1; k <= 31; k++)
                    {
                        int[] day = new int[2];
                        day[0] = k / 10;
                        day[1] = k % 10;

                        result = day[0] * day[1] + day[0] * month[0] + day[0] * month[1] + day[0] * year[0] + day[0] * year[1] + day[0] * year[2] + day[0] * year[3] + day[1] * month[0] + day[1] * month[1] + day[1] * year[0] + day[1] * year[1] + day[1] * year[2] + day[1] * year[3] + month[0] * month[1] + month[0] * year[0] + month[0] * year[1] + month[0] * year[2] + month[0] * year[3] + month[1] * year[0] + month[1] * year[1] + month[1] * year[2] + month[1] * year[3] + year[0] * year[1] + year[0] * year[2] + year[0] * year[3] + year[1] * year[2] + year[1] * year[3] + year[2] * year[3]; 

                        if (result == magicWeight)
                        {
                            Console.WriteLine(day[0] + "" + day[1] + "-" + month[0] + "" + month[1] + "-" + year[0] + "" + year[1] + year[2] + "" + year[3]);

                            count++;
                        }
                     
                    }
                }
                else if (j == 2)
                {
                    for (int k = 1; k <= 28; k++)
                    {
                        int[] day = new int[2];
                        day[0] = k / 10;
                        day[1] = k % 10;

                        result = day[0] * day[1] + day[0] * month[0] + day[0] * month[1] + day[0] * year[0] + day[0] * year[1] + day[0] * year[2] + day[0] * year[3] + day[1] * month[0] + day[1] * month[1] + day[1] * year[0] + day[1] * year[1] + day[1] * year[2] + day[1] * year[3] + month[0] * month[1] + month[0] * year[0] + month[0] * year[1] + month[0] * year[2] + month[0] * year[3] + month[1] * year[0] + month[1] * year[1] + month[1] * year[2] + month[1] * year[3] + year[0] * year[1] + year[0] * year[2] + year[0] * year[3] + year[1] * year[2] + year[1] * year[3] + year[2] * year[3];

                        if (result == magicWeight)
                        {
                            Console.WriteLine(day[0] + "" + day[1] + "-" + month[0] + "" + month[1] + "-" + year[0] + "" + year[1] + year[2] + "" + year[3]);
                            count++;
                        }
                      
                    }
                }
                else
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        int[] day = new int[2];
                        day[0] = k / 10;
                        day[1] = k % 10;

                        result = day[0] * day[1] + day[0] * month[0] + day[0] * month[1] + day[0] * year[0] + day[0] * year[1] + day[0] * year[2] + day[0] * year[3] + day[1] * month[0] + day[1] * month[1] + day[1] * year[0] + day[1] * year[1] + day[1] * year[2] + day[1] * year[3] + month[0] * month[1] + month[0] * year[0] + month[0] * year[1] + month[0] * year[2] + month[0] * year[3] + month[1] * year[0] + month[1] * year[1] + month[1] * year[2] + month[1] * year[3] + year[0] * year[1] + year[0] * year[2] + year[0] * year[3] + year[1] * year[2] + year[1] * year[3] + year[2] * year[3];

                        if (result == magicWeight)
                        {
                            Console.WriteLine(day[0] + "" + day[1] + "-" + month[0] + "" + month[1] + "-" + year[0] + "" + year[1] + year[2] + "" + year[3]);
                            count++;
                        }
                        
                    }
                    
                }
                
            }

        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
