using System;

class SquareRoot
{
    static void Main()
    {
        string number = Console.ReadLine();

        try 
        {
            double integer = double.Parse(number);
            if(integer < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number: the number must be positive");
            }

            Console.WriteLine(Math.Sqrt(integer));
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }

    }
}

