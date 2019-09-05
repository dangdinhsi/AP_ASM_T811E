using System;
using System.Collections.Generic;
using System.Text;

namespace BT603
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Rollnumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ParentCode { get; set; }

        public Student()
        {
        }

        public Student(string name, int age, string rollnumber, string email, string phone, string parentCode)
        {
            Name = name;
            Age = age;
            Rollnumber = rollnumber;
            Email = email;
            Phone = phone;
            ParentCode = parentCode;
        }
        public void input()
        {
            Console.Write("Name:");
            Name = Console.ReadLine();
            Console.Write("Tuoi:");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Rollnumber:");
            Rollnumber = Console.ReadLine();
            Console.Write("Email:");
            Email = Console.ReadLine();
            Console.Write("Phone:");
            Phone = Console.ReadLine();
            Console.Write("ParentCode:");
            ParentCode = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Name:{0},Age:{1},Rollnumber:{2},Email:{3},Phone:{4}",Name,Age,Rollnumber,Email,Phone);
        }
    }
}
