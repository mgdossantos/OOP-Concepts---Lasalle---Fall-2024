namespace Lecture15_Generic2
{

    public class Program
    {
        public static void Main(string[] args)
        {
            DataStorage<int> intStorage = new DataStorage<int>();
            intStorage.addItem(1);
            intStorage.addItem(2);
            intStorage.addItem(3);
            intStorage.addItem(4);
            intStorage.addItem(5);
            intStorage.addItem(6);
            intStorage.displayItems();
            intStorage.addItem(7);
            intStorage.displayItems();

            Console.WriteLine();

            DataStorage<string> stringStorage = new DataStorage<string>();

            stringStorage.addItem("Luciana");
            stringStorage.addItem("Abhay");
            stringStorage.addItem("Gurusharan");
            stringStorage.addItem("Muskan");
            stringStorage.addItem("Chetna");
            stringStorage.addItem("Sankini");
            stringStorage.displayItems();





        }
    }
}