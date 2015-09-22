using System;



class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());
        int countOfCardWithMagicWeight = 0;
        int counter = 0;
        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int[] valuesOfLetters = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };

        for (int d1 = 0; d1 <= 9; d1++)
        {
            for (int d2 = 0; d2 <= 9; d2++)
            {
                for (int c1 = 0; c1 < 10; c1++)
                {
                    for (int c2 = 0; c2 < 10; c2++)
                    {
                        if ((valuesOfLetters[0] + valuesOfLetters[2] + d1 + d1 + d1 + d1 + valuesOfLetters[c1] + valuesOfLetters[c2] == magicWeight) && counter < 1 )
                        {
                            countOfCardWithMagicWeight++;
                            
                           
                        }
                        if ((valuesOfLetters[0] + valuesOfLetters[2] + d1 + d2 + d2 + d2 + valuesOfLetters[c1] + valuesOfLetters[c2] == magicWeight) && d1 != d2)
                        {
                            countOfCardWithMagicWeight++;
                           

                        }
                        if ((valuesOfLetters[0] + valuesOfLetters[2] + d1 + d1 + d1 + d2 + valuesOfLetters[c1] + valuesOfLetters[c2] == magicWeight) && d1 != d2)
                        {
                            countOfCardWithMagicWeight++;
                           

                        }
                        if ((valuesOfLetters[0] + valuesOfLetters[2] + d1 + d1 + d2 + d2 + valuesOfLetters[c1] + valuesOfLetters[c2] == magicWeight) && d1 != d2)
                        {
                            countOfCardWithMagicWeight++;
                         

                        }
                        if ((valuesOfLetters[0] + valuesOfLetters[2] + d1 + d2 + d1 + d2 + valuesOfLetters[c1] + valuesOfLetters[c2] == magicWeight) && d1 != d2)
                        {
                            countOfCardWithMagicWeight++;
                           

                        }
                        if ((valuesOfLetters[0] + valuesOfLetters[2] + d1 + d2 + d2 + d1 + valuesOfLetters[c1] + valuesOfLetters[c2] == magicWeight) && d1 != d2)
                        {
                            countOfCardWithMagicWeight++;
                          

                        }
                    }
                }
                counter++;
            }
            counter = 0;
        }
        Console.WriteLine(countOfCardWithMagicWeight);
    }
}

