using System;


public class Program
{
    //Task: Write a generic method Swap<T>(ref T a, ref T b)
    //that swaps two variables of the same type.
    public static void Swap<T>(ref T a,ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    
    public static void Main(string[] args)
    {
        
              
        //Test the method with different data types (e.g., int, string).

        int x = 10, y = 20;
        Console.WriteLine($"Before Swap: x= {x}, y= {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"After Swap: x= {x}, y={y}");


        string firstName = "Marcela";
        string lastName = "dos Santos";
        Console.WriteLine($"Before Swap: first name= {firstName}, last name= {lastName}");
        Swap(ref firstName, ref lastName );
        Console.WriteLine($"After Swap: first name= {firstName}, last name= {lastName}");

    }
}
