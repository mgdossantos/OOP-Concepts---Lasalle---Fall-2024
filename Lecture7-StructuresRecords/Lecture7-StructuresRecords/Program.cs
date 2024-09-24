using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*Console.WriteLine("Point Structure");
        Point p1 = new Point(5,10);
        p1.displayInfo();

        Point p2 = p1;
        p2.y = 25;
        Console.WriteLine("Point 1 Structure");
        p1.displayInfo();
        Console.WriteLine("Point 2 Structure");
        p2.displayInfo();


        Console.WriteLine("Point Class");
        PointClass p3 = new PointClass(8, 16);
        p3.displayInfo();

        PointClass p4 = p3;
        p4.y = 84;
        Console.WriteLine("Point 3 Class");
        p3.displayInfo();
        Console.WriteLine("Point 4 Class");
        p4.displayInfo();*/


        var person1 = new Person("Marcela", 40);
        person1.DisplayInfo();

        var person2 = new Person("Marcela", 40);
        person1.DisplayInfo();

        Console.WriteLine(person1 == person2);

        PersonClass person3 = new PersonClass("Rafael", 46);
        person3.DisplayInfo();

        PersonClass person4 = new PersonClass("Rafael", 46);
        person4.DisplayInfo();

        Console.WriteLine(person3 == person4);

    }
}
