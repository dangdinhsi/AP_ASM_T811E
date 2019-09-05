using System;
using System.Collections.Generic;
using System.Text;

namespace BT445
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Producer { get; set; }
        public int YearPublish { get; set; }
        public float Price { get; set; }

        public Book()
        {
        }

        public Book(string name, string author, string producer, int yearPublish, float price)
        {
            Name = name;
            Author = author;
            Producer = producer;
            YearPublish = yearPublish;
            Price = price;
        }
        public virtual void input()
        {
            Console.Write("Name:");
            Name = Console.ReadLine();
            Console.Write("Author:");
            Author = Console.ReadLine();
            Console.Write("Producer:");
            Producer = Console.ReadLine();
            Console.Write("Year publish:");
            YearPublish = int.Parse(Console.ReadLine());
            Console.Write("Price:");
            Price = float.Parse(Console.ReadLine());
        }
        public virtual void display()
        {
            Console.WriteLine("Name:{0},Author:{1},Producer:{2},YearPublish:{3},Price:{4}",Name,Author,Producer,YearPublish,Price);
        }

     
    }
}
