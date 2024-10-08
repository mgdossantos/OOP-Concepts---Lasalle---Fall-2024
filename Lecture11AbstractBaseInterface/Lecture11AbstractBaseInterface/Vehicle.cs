using System;

public class Vehicle
{
    //Create a class Vehicle with a constructor that takes the brand as an argument.
    // The Vehicle class should have a brand property and a
    // constructor that sets the brand property.
    public string Brand {  get; set; }
    public Vehicle(string brand)
    {
        Brand = brand;
    }
}
