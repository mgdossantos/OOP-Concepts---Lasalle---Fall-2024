using System;
using System.Collections.Generic;
using System.Linq;

namespace Lecture15_Generic3
{
    public class Person
    {
        public int Age { get; set; }    
        public string Name { get; set; }

        public Person (string name, int age)
        {
            Name=name;
            Age=age;
        }

        public override string ToString()
        {
            return $"[Name: {Name}, Age: {Age}]";
        }
    }
}
