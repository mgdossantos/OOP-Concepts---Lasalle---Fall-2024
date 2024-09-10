using System;

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        Car2 car2 = new Car2();
        Console.WriteLine("Constructor without explcitly definition: "+car.brand);
        Console.WriteLine("Constructor without parameters: " + car2.brand);
        Car3 car3 = new Car3("Toyota", "Corolla");
        Console.WriteLine("Constructor with parameters: " + car3.brand);
  

    }
}