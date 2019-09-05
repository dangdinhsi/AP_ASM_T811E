using System;
using System.Collections.Generic;

namespace BT68_B2
{
    class StudentMark
    {
        public string Rollnumber { get; set; }
        public string Fullname { get; set; }
        public string Lop { get; set; }
        public string Mon_hoc { get; set; }
        public double Diem { get; set; }

        public StudentMark()
        {
        }

        public StudentMark(string rollnumber, string fullname, string lop, string mon_hoc, double diem)
        {
            Rollnumber = rollnumber;
            Fullname = fullname;
            Lop = lop;
            Mon_hoc = mon_hoc;
            Diem = diem;
        }
        public void input()
        {
            Console.Write("Rollnumber:");
            Rollnumber = Console.ReadLine();
            Console.Write("Fullname:");
            Fullname = Console.ReadLine();
            Console.Write("Lop:");
            Lop = Console.ReadLine();
            Console.Write("Mon hoc:");
            Mon_hoc = Console.ReadLine();
            Console.Write("Diem:");
            Diem = double.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Rollnumber:{0},Fullname:{1},Lop:{2},Mon hoc:{3},Diem:{4}",Rollnumber,Fullname,Lop,Mon_hoc,Diem);
        }

        static void Main(string[] args)
        {
            List<StudentMark> list = new List<StudentMark>();
            StudentMark s1 = new StudentMark();
            s1.input();
            StudentMark s2 = new StudentMark();
            s2.input();
            list.Add(s1);
            list.Add(s2);
            double max = list[0].Diem;
            if(max < list[1].Diem)
            {
                list[1].display();
            }
            else
            {
                list[0].display();
            }
        }
    }
}
