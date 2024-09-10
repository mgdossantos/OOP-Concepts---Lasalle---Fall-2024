using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*** Movie Info ***");
        Console.WriteLine("Title: ");
        string movieInput= Console.ReadLine();
        Console.WriteLine("Duration in min: ");
        int durationInput = int.Parse(Console.ReadLine());

        Movie movie1 = new Movie(movieInput, durationInput);
        movie1.durationInHours();
        
    }
}
