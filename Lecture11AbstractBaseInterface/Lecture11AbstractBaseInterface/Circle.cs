using System;

public class Circle : Shape
{
    ////The Circle class should implement CalculateArea() using the
    //formula Area = π * radius * radius.
    public double Radius {  get; set; }

    public override double calculateArea()
    {
        double area = Math.PI * Radius * Radius;
        return area;
    }
}
