using System;


// Define a class called Circle (reference type)
public class Circle
{
    public double Radius { get; set; }
    public Point Center { get; set; }  
    // Circle contains a Point struct

    // Constructor for the Circle class
    public Circle(double radius, Point center)
    {
        Radius = radius;
        Center = center;
    }

    public void display()
    {
        Console.WriteLine($"Circle with Radius: {Radius}, Center at: ({Center.X}, {Center.Y})");
    }
}
