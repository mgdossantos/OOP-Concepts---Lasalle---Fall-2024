using System;

public class PointClass
{
    public int x;
    public int y;

    public PointClass(int xnew, int ynew)
    {
        this.x = xnew;
        this.y = ynew;
    }

    public void displayInfo()
    {
        Console.WriteLine($"x:{x}, y:{y}");
    }
}
