using System;

public class PersonClass
{
    string Name { get; set; }
    int Age { get; set; }
    public PersonClass(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{this.Name}, Idade: {this.Age}");
    }
}