using System;

class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.Age = age;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName 
    {
        get { return this.firstName; }
        set
        {
            if (value == null || value == string.Empty || value.Length < 2)
            {
                throw new ArgumentException("The name of the component cannot be empty or shorter than 2 characters");
            }
            this.firstName = value;
        }
    }
    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value == null || value == string.Empty || value.Length < 2)
            {
                throw new ArgumentException("The name of the component cannot be empty or shorter than 2 characters");
            }
            this.lastName = value;
        }
    }
    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentException("Age cannot be less than zero and more than 120!");
            }
            this.age = value;
        }
    }
}

