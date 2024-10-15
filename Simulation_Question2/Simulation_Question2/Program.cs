//Write a program that demonstrates the creation of Car and
//Motorcycle objects, displaying their details and calling
//their Start() methods.
using Simulation_Question2;
public class Program
{
    public static void Main(string[] args)
    {
        // Create a Car object
        Car myCar = new Car("Toyota", "Corolla", 4);
        myCar.displayCarDetails();  // Display car details
        myCar.start();  // Start the car

        Console.WriteLine();  // Line break for clarity

        // Create a Motorcycle object
        Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", "Street 750", 2);
        myMotorcycle.displayMotorcycleDetails();  // Display motorcycle details
        myMotorcycle.start();  // Start the motorcycle
    }
}