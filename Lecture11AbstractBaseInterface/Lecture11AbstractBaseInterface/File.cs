public class File : IReadable, IWritable
{

    //The File class implements both interfaces explicitly,
    //meaning that the methods are not accessible directly via the class,
    //but rather through an interface reference.

    // Explicit implementation of IReadable.Read()
    void IReadable.Read()
    {
        Console.WriteLine("Reading file...");
    }

    // Explicit implementation of IWritable.Write()
    void IWritable.Write()
    {
        Console.WriteLine("Writing to file...");
    }
}