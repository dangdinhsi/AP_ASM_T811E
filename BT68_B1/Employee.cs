using System;
using System.Collections.Generic;
using System.Text;

namespace BT68_B1
{
    class Employee
    {
        public string Hoten { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public string ChucVu { get; set; }
        public double Luong { get; set; }

        public Employee()
        {
        }

        public Employee(string hoten, string gioiTinh, string queQuan, string chucVu, double luong)
        {
            Hoten = hoten;
            GioiTinh = gioiTinh;
            QueQuan = queQuan;
            ChucVu = chucVu;
            Luong = luong;
        }
        public void input()
        {
            Console.Write("Ho ten:");
            Hoten = Console.ReadLine();
            Console.Write("Gioi tinh:");
            GioiTinh = Console.ReadLine();
            Console.Write("Que quan:");
            QueQuan = Console.ReadLine();
            Console.Write("Chuc vu:");
            ChucVu = Console.ReadLine();
            Console.Write("Luong:");
            Luong = double.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Ho ten:{0},Gioi tinh:{1},Que quan:{2},Chuc vu:{3},Luong:{4}",Hoten,GioiTinh,QueQuan,ChucVu,Luong);
        }
    }
}
