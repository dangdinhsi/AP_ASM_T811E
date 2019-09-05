using System;
using System.Collections.Generic;
using System.Text;

namespace BT603
{
    class Parent
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }

        public Parent()
        {
        }

        public Parent(string name, string address, string phone, string code)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Code = code;
        }

        public void input()
        {
            Console.Write("Nhap name:");
            Name = Console.ReadLine();
            Console.Write("Address:");
            Address = Console.ReadLine();
            Console.Write("Phone:");
            Phone = Console.ReadLine();
            Console.Write("Code:");
            Code = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Name:{0},Address:{1},Phone:{2},Code:{3}",Name,Address,Phone,Code);
        }
    }
}
