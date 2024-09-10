using System;
using System.Drawing;

public class Program
{
    public static void Main(string[] args)
    {
        double width,length;

        Console.WriteLine("Width: ");
        width= double.Parse(Console.ReadLine());
        Console.WriteLine("Lenght: ");
        length= double.Parse(Console.ReadLine());
        Rectangle door = new Rectangle(width, length);
        Console.WriteLine("Area: "+door.calculateArea());
        Console.WriteLine("Perimeter: "+door.calculatePerimeter());
    }
}
