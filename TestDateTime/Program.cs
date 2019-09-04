using System;
using System.Collections.Generic;

namespace TestDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();

            Student s1 = new Student("ngoc","nu");
            Student s2 = new Student("si", "nam");
            Student s3 = new Student("huong giang", "other");
            Student s4 = new Student("1111", "11111");


            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            list.Add(s4);

            string str = "si";
            string str2 = "1111";
           for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Name.Equals(str)) // sua 
                {
                    list[i].Name = "occho";
                    list[i].Gender = "female";
                    Console.WriteLine(i);
                }
                if (list[i].Name.Equals(str2)) // xoa
                {
                    list.RemoveAt(i);
                    Console.WriteLine(i);

                }
            }
            int dem = 0;
            foreach(Student student in list)
            {
                dem++;
                Console.WriteLine(student.ToString());
                
            }
            Console.WriteLine(dem);

        }
    }
}
