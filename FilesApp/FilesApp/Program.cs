using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string currentDirectory= Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, "file.txt"); ;  // File path to be read

        try
        {
            // Read all text from the file
            string fileContent = File.ReadAllText(filePath);

            // Print the file content to the console
            Console.WriteLine("File content:");
            Console.WriteLine(fileContent);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");  // Handle file not found error
        }
        catch (IOException e)
        {
            Console.WriteLine("An I/O error occurred: " + e.Message);  // Handle other I/O errors
        }
    }
}