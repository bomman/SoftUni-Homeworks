using System;

class PrintCompanyInformation
{
    static void Main()
    {
        //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.
        

        string name = Console.ReadLine();
        string address = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string firstNameOfManager = Console.ReadLine();
        string lastNameOfManager = Console.ReadLine();
        string ageOfManager = Console.ReadLine();
        string phoneNumberOfManager = Console.ReadLine();

        Console.WriteLine("Company name: {0}", name);
        Console.WriteLine("Company address: {0}", address);
        Console.WriteLine("Company phone number: {0}", phoneNumber);
        Console.WriteLine("Company fax number: {0}", faxNumber);
        Console.WriteLine("Company website: {0}", webSite);
        Console.WriteLine("Manager first name: {0}", firstNameOfManager);
        Console.WriteLine("Manager last name: {0}", lastNameOfManager);
        Console.WriteLine("Manager age: {0}", ageOfManager);
        Console.WriteLine("Manager phone number: {0}", phoneNumberOfManager);



    }
}

