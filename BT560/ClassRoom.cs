using System;
using System.Collections.Generic;
using System.Text;

namespace BT560
{
    [Serializable]
    class ClassRoom
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Student> listStudent = new List<Student>();

        public ClassRoom()
        {
        }
        public void input()
        {
            Console.Write("Name:");
            Name = Console.ReadLine();
            Console.Write("Address:");
            Address = Console.ReadLine();

        
            Console.Write("Số lượng sinh viên muốn thêm:");
          int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Student student = new Student();
                Console.WriteLine("Thông tin sinh viên thứ " +(i+1));
                student.input();
                listStudent.Add(student);

            }
        }
        public void display()
        {
            Console.WriteLine("Name:{0},Address:{1}",Name,Address);
            foreach(Student student in listStudent)
            {
                student.display();
            }
        }

    }
}
