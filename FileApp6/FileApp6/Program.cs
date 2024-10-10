using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Specify the path for the file
        string filePath = @"C:\Users\tchel\Documents\GitHub\OBJECT- ORIENTED PROGRAMMING CONCEPTS\FileApp6\FileApp6\Files\output.txt"; // Change this to your desired path

        // Create the directory for the specified file path if it doesn't exist
        string directoryPath = Path.GetDirectoryName(filePath);
        if (directoryPath != null && !Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Content to append to the file
        string[] linesToAppend = new string[]
        {
            "This is an additional line.",
            "Appending more text to the file.",
            "End of the appended content."
        };

        try
        {
            // Using StreamWriter to append text to the file
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                foreach (string line in linesToAppend)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine($"Content appended successfully to {filePath}!");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}