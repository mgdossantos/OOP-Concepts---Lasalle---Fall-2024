using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppConcatenation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelFullName.Visible = false;
            labelFullName.Font = new Font("Arial", 20,FontStyle.Bold);

        }

        private void buttonConcatenation_Click(object sender, EventArgs e)
        {
            //string fullName;
            //fullName= textBoxFirstName.Text + " "+textBoxLastName.Text;
            
            Person person = new Person();
            person.FirstName = textBoxFirstName.Text;
            person.LastName = textBoxLastName.Text;

            //labelFullName.Text = fullName;
            labelFullName.Text= person.getFullName();
            labelFullName.Visible= true;

        }
    }
}
