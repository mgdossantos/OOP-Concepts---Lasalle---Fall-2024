using System;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        //add initialization that is related to the Cat
    }
    public override void speak()
    {
        Console.WriteLine("Meow!!!");
    }
    
}
