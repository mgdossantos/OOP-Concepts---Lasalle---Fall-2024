
namespace Simulation_Question5MVC
{
    public class Product
    {
        private int productID;
        private string name;
        private double price;

        public int ProductID { get { return productID; } set { productID = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }

        public Product(int productID, string name, double price)
        {
            ProductID = productID;
            Name = name;
            Price = price;

        }


        
    }
}
