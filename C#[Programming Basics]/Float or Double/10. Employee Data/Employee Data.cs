using System;

class EmployeeData
{
    static void Main()
    {
        // A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        //•	First name
        //•	Last name
        //•	Age (0...100)
        //•	Gender (m or f)
        //•	Personal ID number (e.g. 8306112507)
        //•	Unique employee number (27560000…27569999)
        //Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

        Console.Write("Enter your first name:");
        string firstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter your age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter you gender with M or F: "); 
        string gender = Console.ReadLine();
        long personalID = 8306112507;
        long employeeNumber = 275600002756999;

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        Console.WriteLine(age);
        Console.WriteLine(gender);
        Console.WriteLine("Your personal ID is: {0}", personalID);
        Console.WriteLine("Your employee number is: {0}", employeeNumber);


    }
}

