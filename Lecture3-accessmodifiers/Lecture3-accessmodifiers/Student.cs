using System;

public class Student
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { if (!string.IsNullOrEmpty(value)) name = value; }
    }

    public int Age
    {
        get { return age; }
        set { if (value > 0) age = value; }
    }

    
}