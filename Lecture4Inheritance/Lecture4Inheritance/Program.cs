using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("From Base");
        //BaseClass baseObject = new BaseClass();
        //baseObject.Greet();


        Console.WriteLine("From Derived");
        DerivedClass person = new DerivedClass("Marcela","Teacher");
        person.SetAge(40);
        person.Introduce();
        person.Show();

    }
}
