using System;

public class Program {
    public static void Main(string[] args)
    {
        Product p1 = new Product(1, "T-Shirt Avengers", 39.99);
        Console.WriteLine("-- Product Details --");
        Console.WriteLine(p1.display());
        p1.applyDiscount(10);
        Console.WriteLine("-- Product Details (After Discount) --");
        Console.WriteLine(p1.display());

    }
}
