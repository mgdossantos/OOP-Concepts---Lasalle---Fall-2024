using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture20_Exceptionhandling
{
    public class Student
    {
        public string Name { get; private set; }
        public int Grade { get; private set; }

        public Student(string name)
        {
            Name = name;
        }

        // Method to set the student's grade, which validates the grade and throws an InvalidGradeException if invalid
        public void SetGrade(int grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new InvalidGradeException("Grade must be between 0 and 100.");
            }
            Grade = grade;
        }

        // Display student information
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student: {Name}, Grade: {Grade}");
        }
    }
}
