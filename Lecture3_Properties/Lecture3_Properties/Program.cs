using System;

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Marcela";
        student1.Age = 40;


        Console.WriteLine("Data from the object student1");
        Console.WriteLine("Name: " + student1.Name);
        Console.WriteLine("Age: " + student1.Age);

        student1.Name = "";
        Console.WriteLine("Data from the object student1");
        Console.WriteLine("Name: " + student1.Name);
        Console.WriteLine("Age: " + student1.Age);


    }
}
