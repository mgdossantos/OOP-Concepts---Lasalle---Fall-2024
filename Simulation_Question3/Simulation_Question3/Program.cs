//Memory Allocation: Explain how structs are stored on
//the stack and how classes are allocated on the heap.
//Use examples from your code to illustrate this difference.

//Use Case: Explain when you would choose to use a struct
//over a class in real - world applications.
//In particular, discuss why Point is a good candidate for a
//struct and why Circle should be a class.

//Write a C# program that demonstrates the key differences
//in behavior between struct and class, and explains the
//advantages and disadvantages of each.

public class Program
{
    static void Main(string[] args)
    {

        // Demonstrating Value Type behavior (Struct)

        // Value Type vs. Reference Type: Show how structs are value
        // types by copying a Point struct and modifying its X value.
        Console.WriteLine("Struct (Point) - Value Type:");
        Point p1 = new Point(10, 20);
        Point p2 = p1;  // Copying struct (value type)

        Console.WriteLine("Original Point (p1):");
        p1.display();

        Console.WriteLine("Copied Point (p2):");
        p2.display();

        // Modifying the copied point (p2)
        p2.X = 50;

        Console.WriteLine("\nAfter modifying p2's X value:");
        Console.WriteLine("Original Point (p1):");  // p1 remains unchanged
        p1.display();

        Console.WriteLine("Copied and Modified Point (p2):");
        p2.display();

        // Compare this with copying a Circle object (which contains a
        // Point struct) and modifying its Radius property to
        // demonstrate how classes are reference types.

        // Demonstrating Reference Type behavior (Class)
        Console.WriteLine("\nClass (Circle) - Reference Type:");
        Circle c1 = new Circle(5.0, new Point(10, 10));
        Circle c2 = c1;  // Copying class (reference type)

        Console.WriteLine("Original Circle (c1):");
        c1.display();

        Console.WriteLine("Copied Circle (c2):");
        c2.display();

        // Modifying the copied circle (c2)
        c2.Radius = 10.0;

        Console.WriteLine("\nAfter modifying c2's Radius:");
        Console.WriteLine("Original Circle (c1):");  // c1 is also affected (reference type)
        c1.display();

        Console.WriteLine("Copied and Modified Circle (c2):");
        c2.display();

        // Explanation
        explainMemoryAllocation();
        explainUseCases();
    }

    // Explaining Memory Allocation
    static void explainMemoryAllocation()
    {
        Console.WriteLine("\nMemory Allocation:");
        Console.WriteLine("1. Structs (like Point) are value types, and they are stored on the stack.");
        Console.WriteLine("   When you copy a struct, the values are copied, so modifying the copy doesn't affect the original.");
        Console.WriteLine("2. Classes (like Circle) are reference types, and they are allocated on the heap.");
        Console.WriteLine("   When you copy a class, you only copy the reference to the object on the heap.");
        Console.WriteLine("   Modifying the copy will affect the original object since they both point to the same memory location.");
    }

    // Explaining Use Cases for Structs vs Classes
    static void explainUseCases()
    {
        Console.WriteLine("\nUse Case - When to use Struct vs Class:");
        Console.WriteLine("1. Use Structs for small, simple data types that represent a single value or a group of related values.");
        Console.WriteLine("   - Example: Point is a good candidate for a struct because it represents simple coordinates with X and Y.");
        Console.WriteLine("   - Structs are more efficient for small objects as they avoid heap allocation and garbage collection.");
        Console.WriteLine("2. Use Classes for more complex objects that involve behavior, inheritance, or should be shared between multiple parts of the program.");
        Console.WriteLine("   - Example: Circle is better as a class because it may involve more complex behavior and requires heap allocation for efficient memory management.");
    }
}


