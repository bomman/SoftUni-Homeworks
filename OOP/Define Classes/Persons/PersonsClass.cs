using System;

public class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Person(string name, int age, string email)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }

    public string Name
    {
        get { return this.name; }
        set 
        {
            if(value != string.Empty)
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if(value >= 0 && value <= 100 )
            {
                this.age = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if(value.Contains("@") || value == null)
            {
                this.email = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public override string ToString()
    {
        return string.Format("Name: {0}, Age: {1}, Email: {2}", name, age, email ?? "Doesn't have an email");
    }
}

