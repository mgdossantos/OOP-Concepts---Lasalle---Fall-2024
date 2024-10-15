using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Question2
{
    // Derived class: Motorcycle
    public class Motorcycle : Vehicle
    {
        // Field for Number of Wheels
        public int NumberOfWheels { get; set; }

        // Constructor for Motorcycle, calls base class constructor
        public Motorcycle(string make, string model, int numberOfWheels)
            : base(make, model)
        {
            NumberOfWheels = numberOfWheels;
        }

        // Override the Start method to display specific message for Motorcycle
        public override void start()
        {
            Console.WriteLine("The motorcycle's engine is revving up!");
        }

        // Method to display motorcycle-specific details
        public void displayMotorcycleDetails()
        {
            displayDetails();
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        }
    }

}
