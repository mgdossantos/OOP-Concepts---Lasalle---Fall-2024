using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonName.Text = "*** Click Me ***";
            buttonName.BackColor = Color.LightBlue;

            label1.Text = " Hello World!!";
            label1.Font = new Font("Arial", 16);
            label1.Visible = false;
            
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            label1.Visible=true;
            label1.Text = "Clicked Button!!";
        }
    }
}
