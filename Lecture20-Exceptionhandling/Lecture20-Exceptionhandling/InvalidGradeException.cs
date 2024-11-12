using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture20_Exceptionhandling
{
    public class InvalidGradeException : Exception
    {
        // Constructor that takes a custom error message
        public InvalidGradeException(string message) : base(message) { }
    }

}
