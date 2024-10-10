using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "example.txt";

        try
        {
            // The using statement ensures the StreamReader is disposed of after use

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                Console.WriteLine("Reading file line by line:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
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