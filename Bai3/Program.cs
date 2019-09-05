using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.input();
            string xml = student.Serialize();
            Console.WriteLine(xml);
        }
    }


    public static class XmlExtension
    {
        public static string Serialize<T>(this T value)
        {
            if (value == null) return string.Empty;

            var xmlSerializer = new XmlSerializer(typeof(T));

            using (var stringWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
                {
                    xmlSerializer.Serialize(xmlWriter, value);
                    return stringWriter.ToString();
                }
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Rollnumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Student()
        {
        }

        public Student(string name, string rollnumber, int age, string address)
        {
            Name = name;
            Rollnumber = rollnumber;
            Age = age;
            Address = address;
        }

        public void input()
        {
            Console.Write("Name:");
            Name = Console.ReadLine();
            Console.Write("Rollnumber:");
            Rollnumber = Console.ReadLine();
            Console.Write("Age:");
            Age =int.Parse(Console.ReadLine());
            Console.Write("Address:");
            Address = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Name:{0},Rollnumber:{1},Age:{2},Address:{3}",Name,Rollnumber,Age,Address);
        }

    }
}
