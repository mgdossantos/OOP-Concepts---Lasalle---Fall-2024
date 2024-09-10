using System;

public class Movie
{
	public string title;
	public int durationInMinutes;


	public Movie(string t,int d)
	{
		this.title = t;	
		this.durationInMinutes = d;
	}

	public void durationInHours()
	{
		int hours,minutes;
		hours = durationInMinutes / 60;
		minutes = durationInMinutes % 60;
		Console.WriteLine("The " + this.title + "movie has " + hours + " hours and " + minutes + " minutes long.");

	}
}
