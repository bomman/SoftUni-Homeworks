using System;
using System.Collections.Generic;
using System.Linq;
class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int weight = 0;
        int count = 0;
        string fiveLetters = "abcde";
        int[] weights = { 5, -12, 47, 7, -32 };
    List<string> holdsAnswers = new List<string>();



        for (int i = start; i <= end; i++)
        {
            for (int j = 0; j < 5; j++)
            {

                for (int k = 0; k < 5; k++)
                {
                    for (int o = 0; o < 5; o++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            for (int n = 0; n < 5; n++)
                            {
                                int productWith = 1;
                                int a = productWith * weights[j];
                                productWith = ProductWith(a, productWith);
                                int b = CheckForRepeatedB(weights[j], weights[k], weights[o], weights[l], weights[n]) * productWith;
                                productWith = ProductWith(b, productWith);
                                int c = CheckForRepeatedC(weights[j], weights[k], weights[o], weights[l], weights[n]) * productWith;
                                productWith = ProductWith(c, productWith);
                                int d = CheckForRepeatedD(weights[j], weights[k], weights[o], weights[l], weights[n]) * productWith;
                                productWith = ProductWith(d, productWith);
                                int e = CheckForRepeatedE(weights[j], weights[k], weights[o], weights[l], weights[n]) * productWith;
                                weight = a + b + c + d + e;
                                if (weight == i)
                                {
                                    count++;

                                    string answer = "" + fiveLetters[j] + fiveLetters[k] + fiveLetters[o] + fiveLetters[l] + fiveLetters[n];
                                    holdsAnswers.Add(answer);
                                    
                                   
                                }

                            }
                        }
                    }
                }
            }
          
        }
        holdsAnswers.Sort();

        for (int i = 0; i < holdsAnswers.Count(); i++)
        {
            Console.Write(holdsAnswers[i] + " ");
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int ProductWith(int a, int productWith)
    {
        productWith++;
        if (a == 0)
        {
            productWith--;
        }
        return productWith;
       
    }

    public static int CheckForRepeatedE(int a, int b, int c, int d, int e)
    {
        if (e == a)
        {
            e = 0;
        }
        if (e == b)
        {
            e = 0;
        }
        if (e == c)
        {
            e = 0;

        }
        if (e == d)
        {
            e = 0;


        }
        return e;





    }
    public static int CheckForRepeatedB(int a, int b, int c, int d, int e)
    {
        if (b == a)
        {

            b = 0;
            return b;

        }

        return b;
    }
    public static int CheckForRepeatedC(int a, int b, int c, int d, int e)
    {
        if (c == a)
        {
            c = 0;

        }
        if (c == b)
        {
            c = 0;

        }
        return c;
    }
    public static int CheckForRepeatedD(int a, int b, int c, int d, int e)
    {
        if (d == a)
        {
            d = 0;

        }
        if (d == b)
        {
            d = 0;

        }
        if (d == c)
        {
            d = 0;

        }
        return d;
    }
}


