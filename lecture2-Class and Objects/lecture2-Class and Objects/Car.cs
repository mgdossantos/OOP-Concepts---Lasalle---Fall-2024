using System;

public class Car
{
    public string brand;
    public string model;
    public double consumption;
    public double fuel;

    public void start()
    {
        Console.WriteLine("Car Starterd!");
    }

    public Car(double consuption)
    {
        consumption = consuption;
    }

    public void walk(double distance)
    {
        double reduction;
        reduction = distance / consumption;
        fuel=fuel-reduction;
    }

    public double getGasoline()
    {
        return fuel;
    }

    public void addGasoline(double gas)
    {
        fuel = fuel + gas;
    }
}


