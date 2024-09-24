using System;

public record Person(string name, int age)
{
    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{name}, Idade: {age}");
    }
}