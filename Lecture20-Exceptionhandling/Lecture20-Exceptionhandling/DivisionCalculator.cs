using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture20_Exceptionhandling
{

    public class DivisionCalculator
    {
        // Method to take two integers as input
        public (int, int) GetInput()
        {
            try
            {
                Console.Write("Enter the first integer: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the second integer: ");
                int denominator = int.Parse(Console.ReadLine());

                return (numerator, denominator);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
                throw;  // Rethrow to signal failure for caller to handle if needed
            }
        }

        // Method to perform division and handle DivideByZeroException
        public void Divide(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Division attempt completed.");
            }
        }
    }

}
