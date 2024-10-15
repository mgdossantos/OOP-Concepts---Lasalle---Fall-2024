using System;
using System.Collections.Generic;
namespace WindowsFormsApp_StudentGridView
{
    public class StudentController
    {
        private List<Student> students;
        private Form1 view;

        public StudentController(Form1 view)
        {
            this.students = new List<Student>();
            this.view = view;

            this.view.SubmitButtonClicked += OnSubmitButtonClicked;

        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            string name = this.view.getStudentName();
            int age = this.view.getStudentAge();

            Student student = new Student(name, age);
            students.Add(student);
            view.displayStudents(this.students);
        }
    }
}
