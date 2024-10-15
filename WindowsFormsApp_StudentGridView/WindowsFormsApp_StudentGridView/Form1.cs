using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp_StudentGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridStudents.Columns.Add("Name", "Name");
            dataGridStudents.Columns.Add("Age", "Age");
            dataGridStudents.Width = 500;
            dataGridStudents.Height = 200;
            dataGridStudents.Columns[0].Width = 350;
            dataGridStudents.Columns[1].Width = 80;

        }

        public string getStudentName()
        {
            return textBoxName.Text;
        }

        public int getStudentAge()
        {
            return int.Parse(textBoxAge.Text);
        }

        // Event for submit button click
        public event EventHandler SubmitButtonClicked;

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SubmitButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void displayStudents(List <Student> students)
        {
            foreach (var student in students)
            {
                dataGridStudents.Rows.Add(student.Name,student.Age);
            }
        }


        
    }
}
