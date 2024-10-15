using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simulation_Question1_Complete
{
    public class BookController
    {
        public Book createBook(string title, string author, double price)
        {
            // Create a new Book object
            return new Book(title, author, price);
        }
    }
}
