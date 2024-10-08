using System;
using System.Diagnostics.Contracts;

public class Program
{
    public static void Main(string[] args)
    {
        //we are not able to create animal
        //Animal a1 = new Animal();

        /*Console.WriteLine("Type the name for your dog: ");
        string name = Console.ReadLine();
        Dog dog = new Dog(name);
        dog.speak();
        dog.move();*/


        //Cat cat = new Cat("Pudim");

        /*Circle circle1=new Circle();
        circle1.Radius = 4;
        circle1.displayArea();*/

        /*Console.WriteLine("Type the brand: ");
        string brand = Console.ReadLine();
        Car car1 = new Car(brand);
        car1.displayInfo();*/

        File myFile = new File();

        // Explicit casting to call the respective methods

        //In the Main() method, we create a File object and
        //explicitly cast it to IReadable and IWritable to invoke
        //the respective methods.
        ((IReadable)myFile).Read();
        ((IWritable)myFile).Write();


    }

}