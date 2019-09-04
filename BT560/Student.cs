using System;
using System.Collections.Generic;
using System.Text;

namespace BT560
{
    [Serializable]
    class Student
    {
        public string Fullname { get; set; }
        public string Birthday  { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }

        public string Gender { get; set; }

        public Student()
        {
        }

        public Student(string fullname, string birthday, string email, string address, string gender)
        {
            Fullname = fullname;
            Birthday = birthday;
            Email = email;
            Address = address;
            Gender = gender;
        }
        public void input()
        {
            Console.Write("Fullname:");
            Fullname = Console.ReadLine();
            Console.Write("Birthday:");
            Birthday = Console.ReadLine();
            Console.Write("Email:");
            Email = Console.ReadLine();
            Console.Write("Address:");
            Address = Console.ReadLine();
            Console.Write("Gender:");
            Gender = Console.ReadLine();
        }

        public override string ToString()
        {
            return Fullname +"-"+ Birthday +"-"+ Email+ "-"+ Address+"-"+ Gender;
        }
        public void display()
        {
            Console.WriteLine("Fullname:{0},Birthday:{1},Email:{2},Address:{3},Gender:{4}",Fullname,Birthday,Email,Address,Gender);
        }
    }
}
