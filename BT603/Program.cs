using System;
using System.Collections.Generic;

namespace BT603
{
   
    class Program
    {
        public delegate void OnAddressPrint();
        static event OnAddressPrint EventPrintInfoStudent;
        static List<Student> listStudent = new List<Student>();
        static List<Parent> listParent = new List<Parent>();
        static void Main(string[] args)
        {
            int sosv = 0;
            Console.Write("Nhap so phu huynh:");
            int soPH = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.Write("Nhap so sinh vien:");
                int soSV = int.Parse(Console.ReadLine());
                if (soSV >= soPH)
                {
                    sosv = soSV;
                    break;
                }
                Console.WriteLine("So sinh vien khong the it hon so phu huynh");
            }
            int choose = 0;
            do
            {
                Console.WriteLine("1.Nhap phu huynh.");
                Console.WriteLine("2.Nhap sinh vien.");
                Console.WriteLine("3.Tim kiem sinh vien theo phu huynh.");
                Console.WriteLine("4.Tim kiem phu huynh theo sinh vien.");
                Console.WriteLine("5.In thong tin sinh vien theo dia chi nhap vao.");
                Console.WriteLine();
                Console.Write("Nhap lua chon:");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        addParent(soPH);
                        break;
                    case 2:
                        addStudent(sosv);
                        break;
                    case 3:
                        getStudentByParentCode();
                        break;
                    case 4:
                        getParentByCodeParentToStudent();
                        break;
                    case 5:
                        OnAddressPrint onAddressPrint = getStudentByInfor;
                        EventPrintInfoStudent += onAddressPrint;
                        EventPrintInfoStudent();
                        break;
                    default:
                       
                       
                        Console.WriteLine("Nhap sai, nhap lai");
                        break;
                }
            } while (choose !=5);
        }
        static void getStudentByInfor()
        {
            Console.Write("Nhap rollnumber:");
            string roll = Console.ReadLine();
            foreach(Student student in listStudent)
            {
                if (student.Rollnumber.Equals(roll))
                {
                    student.display();
                }
                else
                {
                    Console.WriteLine("Rollnumber khong ton tai hoac da bi xoa");
                }
            }
        }
        static Boolean checkCode(string code)
        {
            foreach(var parent in listParent)
            {
                if (parent.Code.Equals(code))
                {
                    return true;
                }
            }
            return false;
        }
        static Boolean checkCodeinListStudent(string code)
        {
            foreach (var student in listStudent)
            {
                if (student.ParentCode.Equals(code))
                {
                    return true;
                }
            }
            return false;
        }

        static void getParentByCodeParentToStudent()
        {
            Console.WriteLine("List hoc sinh");
            int i = 0;
            foreach(var x in listStudent)
            {
                i++;
                Console.WriteLine("{0}.Ten HS:{1},CodeParent:{2}",i,x.Name,x.ParentCode);
            }
            Console.Write("Nhap Parent Code:");
            string code = Console.ReadLine();
            if (checkCodeinListStudent(code))
            {
                foreach (var p in listParent)
                {
                    if (p.Code.Equals(code))
                    {
                        p.display();
                    }
                }
            }
            else
            {
                Console.WriteLine("Ma phu huynh khong ton tai");
            }
        }
        static void getStudentByParentCode()
        {
            Console.WriteLine("List Ma PH");
            int i = 0;
            foreach(var p in listParent)
            {
                i++;
                Console.WriteLine("{0}.MaPH:{1}",i,p.Code);
            }
            Console.Write("Nhap ma phu huynh:");
            string code = Console.ReadLine();
            if (checkCode(code))
            {
                foreach(var student in listStudent)
                {
                    if (student.ParentCode.Equals(code))
                    {
                        student.display();
                    }
                }
            }
            else
            {
                Console.WriteLine("Ma phu huynh khong ton tai");
            }
        }
        static void addStudent(int n)
        {
            Console.WriteLine("Nhap thong tin sinh vien");
            for(int i = 0; i < n; i++)
            {
                Student student = new Student();
                Console.WriteLine("Thong tin sinh vien thu " + (i + 1));
                student.input();
                listStudent.Add(student);
            }

        }
        static void addParent(int n)
        {
            Console.WriteLine("Nhap thong tin phu huynh");
            for (int i = 0; i < n; i++)
            {
                Parent parent = new Parent();
                Console.WriteLine("Thong tin phu huynh thu " + (i + 1));
                parent.input();
                listParent.Add(parent);
            }
        }

    }
}
