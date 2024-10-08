using System;

public class Car : Vehicle
{
    //Create a derived class Car that calls the Vehicle
    //constructor using the base keyword.

    // The Car class should call the Vehicle constructor using the base keyword.
    public Car(string brand): base(brand)
	{
	}

    //Create a DisplayInfo() method in the Car class to
    //display the brand of the car.
    public void displayInfo()
	{
		Console.WriteLine("Brand: " + Brand);
	}
}
