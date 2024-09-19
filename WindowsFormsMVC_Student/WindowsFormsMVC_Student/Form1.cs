using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMVC_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelStudentDetail.Visible = false;
        }
        public string getStudentName()
        {
            return textBoxName.Text;
        }

        public int getStudentAge(){
            return int.Parse(textBoxAge.Text);
        }

        public void setStudentDetails(string name,int age)
        {
            labelStudentDetail.Text = $"Name:  { name}, Age: {age}";
            labelStudentDetail.Visible = true;

        }
        public event EventHandler SubmitButtonClicked;



        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SubmitButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
