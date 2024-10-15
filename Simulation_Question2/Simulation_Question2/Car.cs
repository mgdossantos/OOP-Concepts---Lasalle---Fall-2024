using System;


namespace Simulation_Question2
{
    // Derived class: Car
    public class Car : Vehicle
    {
        // Field for Number of Wheels
        public int NumberOfWheels { get; set; }

        // Constructor for Car, calls base class constructor
        public Car(string make, string model, int numberOfWheels)
            : base(make, model)
        {
            NumberOfWheels = numberOfWheels;
        }

        // Override the Start method to display specific message for Car
        public override void start()
        {
            Console.WriteLine("The car's engine is roaring to life!");
        }

        // Method to display car-specific details
        public void displayCarDetails()
        {
            displayDetails();
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        }
    }

}
