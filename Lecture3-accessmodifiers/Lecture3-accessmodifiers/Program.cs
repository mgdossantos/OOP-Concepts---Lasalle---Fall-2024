
public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        Console.WriteLine("Name: "+student.Name);
        Console.WriteLine("Age: " + student.Age);
        student.Age = 40;
        student.Name = "Marcela";
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);

        student.Age = 40;
        student.Name = "";
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);

        student.Age = -40;
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);












    }
}