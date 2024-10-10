using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string absolutePath = @"C:\Users\tchel\Documents\GitHub\OBJECT- ORIENTED PROGRAMMING CONCEPTS\FileApp5\FileApp5\Files\output.txt"; // Absolute path example
       
        string filePath = absolutePath;


        // Create the directory for the relative path if it doesn't exist
        string directoryPath = Path.GetDirectoryName(filePath);
        if (directoryPath != null && !Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }


        // Content to write into the file
        string[] lines = new string[]
        {
            "Hello, World!",
            "Welcome to file handling in C#.",
            "This is a simple example of writing to a file."
        };

        try
        {
            // Using StreamWriter to write to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write each line to the file
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }

            // Inform the user that the write operation was successful
            Console.WriteLine("File written successfully!");
        }
        catch (Exception e)
        {
            // Handle any exceptions that might occur
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}