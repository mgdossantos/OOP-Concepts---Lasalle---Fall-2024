using System;

public class Program
{

    public static void Main(string[] args)
    {
        Person p1 = new Person("Marcela", 40);
        Console.WriteLine("Name: "+p1.showName());
        Console.WriteLine("Age: " + p1.showAge());
        p1.setAge(-20);
        Console.WriteLine("Age: " + p1.showAge());
        p1.age = -20;
        Console.WriteLine("Age: " + p1.showAge());


    }
}