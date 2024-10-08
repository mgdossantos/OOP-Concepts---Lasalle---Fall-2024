using System;

public class Dog :Animal, IMovable
{
    public Dog (string name) : base(name)
    {
        //add initialization that is related to the Dog
    }
    public override void speak()
    {
        base.speak();
        Console.WriteLine(Name + " Bark!!!");
    }

    public void move()
    {
        Console.WriteLine("Dog is moving!!!");
    }

}
