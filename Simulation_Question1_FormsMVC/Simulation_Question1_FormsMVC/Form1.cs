using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simulation_Question1_FormsMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        
        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            // Retrieve input from text boxes
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            double price;

            if (!double.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Create a new book instance
            Book book = new Book(title, author, price);

            // Display book details in the label
            labelBookDetails.Text = book.display();
        }

      
    }
}
