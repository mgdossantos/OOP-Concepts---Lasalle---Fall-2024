using System;
using System.Windows.Forms;

namespace Simulation_Question1_Complete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Get inputs from the textboxes
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            double price;

            if (!double.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }
            // Create a book using the controller
            BookController control = new BookController();
            Book book = control.createBook(title, author, price);


            // Display the book details
            labelBookDetails.Text = book.display();
        }
    }
}
