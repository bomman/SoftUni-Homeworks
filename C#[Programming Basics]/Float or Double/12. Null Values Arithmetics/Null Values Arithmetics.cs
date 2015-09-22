using System;

class NullValueArithmetic
{
    static void Main()
    {
        // Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.

        // null cannot be assigned to integer but it can be done as this:

        int? num = null;

        // Is the HasValue property true? 
        if (num.HasValue)
        {
            System.Console.WriteLine("num = " + num.Value);
        }
        else
        {
            System.Console.WriteLine("num = Null");
        }
    }

}

