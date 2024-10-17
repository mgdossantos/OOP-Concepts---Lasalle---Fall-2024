using System;
using System.Windows.Forms;

namespace Simulation_Question5MVC
{
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
            labelProductDetails.Visible = false;
        }

        public int getProductID()
        {
            return int.Parse(textBoxID.Text);
        }

        public string getProductName()
        {
            return textBoxName.Text;
        }

        public double getProductPrice()
        {
            return double.Parse(textBoxPrice.Text);
        }

        public double getDiscount()
        {
            return double.Parse(textBoxDiscount.Text);
        }

        public event EventHandler SubmitButtonClicked;

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SubmitButtonClicked?.Invoke(this, EventArgs.Empty);

        }

        public event EventHandler DiscountButtonClicked;

        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            DiscountButtonClicked?.Invoke(this, EventArgs.Empty);

        }


        public void setProductDetails(int id, string name, double price)
        {
            labelProductDetails.Text = $"ID: {id}, Name: {name}, Price: {price}CAD";
            labelProductDetails.Visible = true;

        }

        

    }
}
