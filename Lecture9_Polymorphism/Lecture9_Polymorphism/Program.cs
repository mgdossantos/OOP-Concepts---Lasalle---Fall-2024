using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        /*Animal animal = new Animal();
        animal.makeSound();

        Animal dog = new Dog();
        dog.makeSound();

        Animal cat = new Cat();
        cat.makeSound();*/

        IShape shapeObject;

        List<IShape> shapes = new List<IShape>();
       

        shapeObject = new Circle();
        //Circle circle = new Circle();   
        shapes.Add(shapeObject);

        shapeObject = new Rectangle();
        shapes.Add(shapeObject);

        shapeObject= new Triangle();
        shapes.Add(shapeObject);

        foreach (IShape shape in shapes)
        {
            shape.draw();
        }



    }
}