using System;
using System.Collections.Generic;
using System.Text;

namespace TestDateTime
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public Student(string name, string gender)
        {
            Name = name;
            Gender = gender;
        }
        public override string ToString()
        {
            return Name+"-"+Gender;
        }
    }
}
