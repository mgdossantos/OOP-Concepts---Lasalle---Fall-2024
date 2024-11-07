using Lecture18_GenericPracticalExercise;
using System;


public class Program
{
    public static void Main(string[] args)
    {
        IRepository<Product> productRepository = new InMemoryRepository<Product>();

        productRepository.add(new Product { Name = "Laptop", Price = 999.99f });
        productRepository.add(new Product { Name = "Smartphone", Price = 499.99f });

        //Retrieve all products
        Console.WriteLine("Retrieve all products");
        var products = productRepository.getAll();
        foreach(var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}CAD");
        }

        Console.WriteLine("Find a product");
        var productToUpdate = productRepository.get(1);
        if(productToUpdate != null)
        {
            productToUpdate.Price = 899.99f;
            productRepository.update(productToUpdate);
            Console.WriteLine($"Updated Product: Id: {productToUpdate.Id}, Name: {productToUpdate.Name}, New Price: {productToUpdate.Price}");

        }

        Console.WriteLine("Delete a product");
        productRepository.delete(2);

        //Retrieve all products
        Console.WriteLine("All products after delete");
        products = productRepository.getAll();
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}CAD");
        }


    }
}
