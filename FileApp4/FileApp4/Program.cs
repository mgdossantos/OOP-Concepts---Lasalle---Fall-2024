using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string filePath = "example.txt";

        try
        {
            // Asynchronously read all text from the file
            string fileContent = await File.ReadAllTextAsync(filePath);

            Console.WriteLine("File content:");
            Console.WriteLine(fileContent);
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