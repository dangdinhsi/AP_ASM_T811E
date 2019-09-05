using System;
using System.Collections.Generic;
using System.Text;

namespace BT445
{
    class AptechBook:Book
    {
        public string Language { get; set; }
        public string Semester { get; set; }

        public AptechBook()
        {
        }

        public AptechBook(string language, string semester)
        {
            Language = language;
            Semester = semester;
        }
        public override void input()
        {
            base.input();
            Console.Write("Language:");
            Language = Console.ReadLine();
            Console.Write("Semester:");
            Semester = Console.ReadLine();
        }
        public override void display()
        {
            Console.WriteLine("Name:{0},Author:{1},Producer:{2},YearPublish:{3},Price:{4},Language:{5},Semester:{6}", Name,Author,Producer,YearPublish,Price,Language,Semester);
        }
    }
}
