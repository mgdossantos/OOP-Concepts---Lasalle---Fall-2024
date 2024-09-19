using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppConcatenation
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string getFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
