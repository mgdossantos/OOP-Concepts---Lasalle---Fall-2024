using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMVC_Student
{
    public class StudentController
    {
        private Student _student;
        private Form1 _view;

        public StudentController(Form1 view)
        {
            _view = view;
            //Subscribe to the submit button click event
            _view.SubmitButtonClicked += OnSubmitButtonClicked;

        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            //Get data from the view
            string name = _view.getStudentName();
            int age = _view.getStudentAge();

            //update the model
            _student = new Student(name, age);
            //Update the view with the model data
            _view.setStudentDetails(_student.Name, _student.Age);
        }
    }
}
