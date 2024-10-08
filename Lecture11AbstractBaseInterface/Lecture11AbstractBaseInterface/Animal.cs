using System;

public abstract class Animal
{
	public string Name { get; set; }

	//base constructor
	public Animal(string name)
	{
		Name = name;
	}
	//Abstract method (no implementation)
	//public abstract void speak();

	public virtual void speak()
	{
		Console.WriteLine("Animal is making a sound!!!");
	}

	//Concrete method (has implementation)
	public void eat()
	{
		Console.WriteLine("eating...");
	}

    public void sleep()
    {
        Console.WriteLine("Sleeping.....");
    }

	
}
