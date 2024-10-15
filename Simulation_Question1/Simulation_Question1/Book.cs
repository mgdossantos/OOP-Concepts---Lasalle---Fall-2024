using System;

//Classes and Objects (20 points):
//Create a C# class called Book that has private fields for title,
//author, and price.
//Add public properties to access these fields.
//Write a method to display the details of the book. 

public class Book
{
	private string title;
	private string author;
	private double price;

	// Constructor to initialize a book
    public Book(string title, string author, double price)
    {
		this.title = title;
		this.author = author;
		this.price = price;
    }

    public string Title {  get { return title; } set {  title = value; } }
	public string Author { get { return author; } set { author = value; } }
	public double Price { get { return price; } set { price = value; } }

	public string display()
	{
		return $"Title: {Title}, Author: {Author}, Price:{Price}";
	}
	
}
