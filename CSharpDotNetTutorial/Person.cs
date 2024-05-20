using System;
namespace CSharpDotNetTutorial;

public class Person
{
    public string? Name;

    public DateTime Birthdate { get; set; }

    public int Age
    {
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days / 365;

            return years;
        }
    }

    public void Introduce(string to)
    {
        Console.WriteLine("Hi {0}, I am {1}", to, Name);
    }

    public static Person Parse(string str)
    {
        var person = new Person();
        person.Name = str;

        return person;
    }
}