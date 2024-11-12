using Lecture20_Exceptionhandling;
using System;
using System.ComponentModel;
//Program Structure
//DivisionCalculator class: This class will contain methods to:
//Take input from the user.
//Perform the division.
//Handle exceptions and display appropriate messages.

public class Program
{
    public static void Main(string[] args)
    {
        //Where the execptions might occur
        try
        {
            int x = 5;
            int y = 0;

            int resultint = x / y;
        }
        //This block works to handle exceptions
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        /*float result;
        float [] number = { 1, 2, 3, 4, 5 };
        
            for (int i = 0; i < number.Length; i++)
            {
                try
                {
                    result = number[i] / number[i + 1];
                    Console.WriteLine(result);
                }
                catch (IndexOutOfRangeException ex)
                { 
                    Console.WriteLine("Index out of range.");
                }
                finally
                {
                    Console.WriteLine("This will always execute."); 
                }

            }*/

        /*float result;
        float[] number = { 1, 2, 3, 0, 5 };

        for (int i = 0; i < number.Length; i++)
        {
            try
            {
                result = number[i] / number[i + 1];
                Console.WriteLine(result);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

        }*/

        /*try
        {
            // File operations
        }
        catch (FileProcessingException ex)
        {
            Console.WriteLine("A file processing error occurred: " + ex.Message);
        }*/

        // Creating a Person object and setting it to null
        Person person = null;

        /*try
        {
            // Attempting to access the Name property of a null object
            Console.WriteLine(person.Name);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: Attempted to access a property or method on a null object.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        finally
        {
            // The finally block runs regardless of whether an exception is thrown
            Console.WriteLine("Execution completed.");
        }*/


        // File path of a file that does not exist
        /*string filePath = "nonexistent_file.txt";

        try
        {
            // Attempt to read the file
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Content:");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException ex)
        {
            // This block will handle the FileNotFoundException
            Console.WriteLine("Error: The specified file was not found.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        finally
        {
            // This block will always execute, indicating the end of the file operation
            Console.WriteLine("File reading operation completed.");
        }*/

        /*DivisionCalculator calculator = new DivisionCalculator();

        try
        {
            // Get input from the user
            var (numerator, denominator) = calculator.GetInput();

            // Perform the division
            calculator.Divide(numerator, denominator);
        }
        catch (Exception)
        {
            Console.WriteLine("Program terminated due to invalid input.");
        }*/

        // Creating a sample student
        Student student = new Student("Alice");

        try
        {
            // Prompting user for a grade input
            Console.Write("Enter the grade for Alice (0-100): ");
            int grade = int.Parse(Console.ReadLine());

            // Setting the grade (this may throw InvalidGradeException)
            student.SetGrade(grade);
            student.DisplayStudentInfo();
        }
        catch (InvalidGradeException ex)
        {
            // Handling the custom exception
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException)
        {
            // Handling input that isn't a valid integer
            Console.WriteLine("Error: Invalid input. Please enter a numeric grade.");
        }
        catch (Exception ex)
        {
            // Handling any other unexpected errors
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Grade entry attempt completed.");
        }
    }
}
            