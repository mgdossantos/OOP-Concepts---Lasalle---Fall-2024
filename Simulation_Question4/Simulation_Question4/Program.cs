using System;
using System.Runtime.Intrinsics.X86;

// Create a record type called Person with properties for FirstName,
// LastName, and Age.

// Demonstrate the following features of records:
//Immutability: Show how records provide immutability by
//attempting to change the properties after instantiation.

//Value-based Equality: Create two Person objects with the
//same property values and show how records compare based
//on value equality, unlike classes which use reference equality.

//With-expression: Use the with expression to create a new Person
//object from an existing one, but with an updated Age property.

//Write a C# program that demonstrates each of these features.
//Explain how records differ from classes in terms of immutability, equality, and their typical use cases in applications.

public class Program
{
    static void Main(string[] args)
    {
        // 1. Immutability: Show how records provide immutability
        Console.WriteLine("Immutability:");
        var person1 = new Person("John", "Doe", 30);

        Console.WriteLine($"Person 1: {person1}");

        // Attempting to modify person1's properties will
        // result in a compile-time error:
        //person1.FirstName = "Jane";  
        // Uncommenting this line will cause an error
        // Records are immutable by default

        // 2. Value-based Equality: Demonstrate how records
        // compare based on value equality
        Console.WriteLine("\nValue-based Equality:");
        var person2 = new Person("John", "Doe", 30);
        var person3 = new Person("John", "Doe", 30);
        var person4 = new Person("Jane", "Doe", 25);

        // Comparing two records with the same property values
        Console.WriteLine($"person2 == person3: {person2 == person3}");  // True because records compare based on values
        Console.WriteLine($"person2 == person4: {person2 == person4}");  // False because the values are different

        // 3. With-expression: Create a new Person object
        // by copying and modifying the Age
        Console.WriteLine("\nWith-expression:");
        var person5 = person1 with { Age = 35 };

        Console.WriteLine($"Original Person: {person1}");
        Console.WriteLine($"New Person (with modified Age): {person5}");
    }
}
