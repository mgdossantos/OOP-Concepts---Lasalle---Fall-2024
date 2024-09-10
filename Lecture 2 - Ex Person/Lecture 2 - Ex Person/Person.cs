using System;

public class Person
{
	public string name;
	public int age;

	public Person(string name, int age)
	{
		this.name = name;
		this.age = age;
	}

	public int showAge()
	{
		return age;
	}

	public string showName()
	{
		return name;
	}

	public void setAge(int age)
	{
		if(age < 0)
			this.age = 0;
		else
			this.age = age;
	}
}
