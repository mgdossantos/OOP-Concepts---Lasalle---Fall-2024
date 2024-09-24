using System;

public struct Point
{
    public int x;
    public int y;

    public Point(int xnew, int ynew)
    {
        this.x = xnew;
        this.y = ynew;
    }

    public void displayInfo()
    {
        Console.WriteLine($"x:{x}, y:{y}");
    }


}