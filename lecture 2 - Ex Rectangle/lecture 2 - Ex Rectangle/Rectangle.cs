using System;

public class Rectangle
{
	public double length;
	public double width;

	public Rectangle (double w, double l)
	{
        this.width = w;
        this.length = l;
		
	}
	public double calculateArea()
	{
		double area;

		area= this.width*this.length;
		return area;
	}

	public double calculatePerimeter()
	{
		double perimeter;
		perimeter = 2 * (this.length + this.width);
		return perimeter;
	}
}
