using System;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
//Create a struct called Point with X and Y fields representing
//coordinates. Then, create a class called Circle with properties for Radius and Center (which should be a Point). In your program, demonstrate the following differences between structs and classes:

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor for the Point struct
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}