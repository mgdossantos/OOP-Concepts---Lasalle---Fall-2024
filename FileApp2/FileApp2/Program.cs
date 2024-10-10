using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "example.txt";

        try
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("File lines:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (IOException e)
        {
            Console.WriteLine("An I/O error occurred: " + e.Message);
        }
    }
}