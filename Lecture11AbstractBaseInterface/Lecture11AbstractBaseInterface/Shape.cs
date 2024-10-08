using System;

public abstract class Shape
{
   //Create an abstract class Shape with
   //an abstract method CalculateArea()
    public abstract double calculateArea();
   //non-abstract method DisplayArea().
   public void displayArea()
    {
        Console.WriteLine("Area: " + this.calculateArea());
    }
   
    //Requirements:
    //The Shape class should define an abstract CalculateArea() method.
    
    //The Rectangle class should implement CalculateArea() using the
    //formula Area = width * height.
    //The DisplayArea() method should print the result of CalculateArea().

}
