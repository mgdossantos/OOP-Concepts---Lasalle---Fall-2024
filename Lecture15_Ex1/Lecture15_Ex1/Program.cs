using System;


namespace Lecture15_Ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a Box to hold an integer
            //Box<int> intBox = new Box<int>();
            var intBox = new Box<int>();
            intBox.SetItem(42);
            Console.WriteLine(intBox.GetItem()); // Should output: 42
            intBox.DisplayItem();               // Should output: Item: 42

            // Create a Box to hold a string
            var stringBox = new Box<string>();
            stringBox.SetItem("Hello, Generics!");
            Console.WriteLine(stringBox.GetItem()); // Should output: Hello, Generics!
            stringBox.DisplayItem();               // Should output: Item: Hello, Generics!
        }
    }
}