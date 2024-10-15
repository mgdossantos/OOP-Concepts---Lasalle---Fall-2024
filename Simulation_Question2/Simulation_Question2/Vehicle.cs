using System;
//Create a base class Vehicle with fields for Make, Model, and
//a method Start(). Then, create two derived classes Car and
//Motorcycle that inherit from Vehicle and add a field for
//NumberOfWheels. In both derived classes, implement the Start()
//method to display a unique message for each type of vehicle.


// Base class: Vehicle
public class Vehicle
{
    // Fields for Make and Model
    public string Make { get; set; }
    public string Model { get; set; }

    // Constructor for Vehicle
    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }

    // Virtual method Start to be overridden by derived classes
    public virtual void start()
    {
        Console.WriteLine("The vehicle is starting.");
    }

    // Method to display vehicle details
    public void displayDetails()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}");
    }
}
