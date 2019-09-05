using System;
using System.Collections;
using System.Collections.Generic;

namespace BT445
{
    class Program
    {
        static List<Book> listAbsolute = new List<Book>();
        static List<Book> listRelative = new List<Book>();
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>();
             int choose = 0;
             do
             {
                 GenerateMenu();
                 Console.Write("Nhap lua chon:");
                 choose = int.Parse(Console.ReadLine());
                 switch (choose)
                 {
                     case 1:
                         AddBook();
                         break;
                     case 2:
                         getListAbsolute();
                         break;
                     case 3:
                        sortByYear();
                         break;
                     case 4:
                        // tim kiem theo ten tac gia.
                         break;
                     case 5:
                        // tim kiem theo ten sach.
                         break;
                     case 6:

                        Console.WriteLine("Exit!");
                         break;
                 }

             } while (choose != 6); 
            
        }


        static void sortByYear()
        {
            listRelative.Sort(new BookComparer());
            foreach(var book in listRelative)
            {
                book.display();
            }
        }
        // Sap xep su dung IComparer.
        public class BookComparer : IComparer<Book>
        {
            public int Compare(Book x,Book y)
            {
             //   return x.YearPublish.CompareTo(y.YearPublish); // sap xep tang dan theo nam
                return y.YearPublish.CompareTo(x.YearPublish); // sap xep giam dan theo nam
            }
        }

        static void AddBook()
        {
            Console.Write("So luong sach:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Book book = new Book();
                Console.WriteLine("Thong tin cuon sach thu " + (i + 1));
                book.input();
                listAbsolute.Add(book);
                listRelative.Add(book);
            }
        }
        static void getListAbsolute()
        {
            foreach(var book in listAbsolute)
            {
                book.display();
            }
        }
        static void GenerateMenu()
        {
            Console.WriteLine("1.Nhap thong tin n cuon sach");
            Console.WriteLine("2.Hien thi sach.");
            Console.WriteLine("3.Sap xep theo nam xuat ban giam dan.");
            Console.WriteLine("4.Tim kiem sach theo ten tac gia.");
            Console.WriteLine("5.Tim kiem sach theo ten sach.");
            Console.WriteLine("6.Thoat");
        }
    }
}
