//public members of the base class are 
// accessible in the derived class.

// protected members are accessible
// in the derived class but not outside
// the class hierarchy.

// private members are not accessible
// in the derived class unless explicitly
// exposed via methods or properties.


using System;

public class BaseClass
{
	public string Name { get; set; }
	protected int Age {  get; set; }

	public BaseClass(string name)
	{
		Console.WriteLine($"Base class constructor: {Name}");
		this.Name = name;
	}
	public virtual void Greet()
	{
		Console.WriteLine($"Hello, my name is {Name}");
	}

	public void SetAge(int age)
	{
		Age = age;
	}

	public void showAge()
	{
		Console.WriteLine($"I am {Age} years old!");
	}

    public void showName()
    {
        Console.WriteLine($"I am {Name}");
    }

    public virtual void Show(){
		Console.WriteLine("Base class method: ");
	}
}
