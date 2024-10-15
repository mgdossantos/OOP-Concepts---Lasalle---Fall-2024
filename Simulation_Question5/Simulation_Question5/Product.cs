using System;

public class Product
{
	private int productID;
	private string name;
	private double price;

	public int ProductID {  get { return productID; } set {  productID = value; } }	
	public string Name { get { return name; } set { name = value; } }
	public double Price { get { return price; } set { price = value; } }

	public Product(int productID, string name, double price) {
		ProductID = productID;
		Name = name;
		Price = price;
	
	}
	public string display()
	{
		return $"ID: {ProductID}, Name: {Name}, Price: {Price}";
	}

	public void applyDiscount(double discount)
	{
		this.price = this.Price - this.Price * discount / 100;
	}
}
