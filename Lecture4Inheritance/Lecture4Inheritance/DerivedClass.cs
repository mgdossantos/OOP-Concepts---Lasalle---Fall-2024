using System;

public class DerivedClass : BaseClass
{
	public string Job {  get; set; }

    public DerivedClass(string name, string job):base (name)
    { 
        this.Job = job; 
    }
    public override void Greet()
    {
		Console.WriteLine("Hello from the derived class.");
    }

    public void Introduce()
	{
		Greet();
		showAge();
        showName();
		Console.WriteLine($"I work as a {Job}");
	}

    public sealed override void Show()
    {
        Console.WriteLine("Derived class method Show");
    }
}
