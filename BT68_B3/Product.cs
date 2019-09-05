using System;
using System.Collections.Generic;
using System.Text;

namespace BT68_B3
{
    class Product
    {
        private string id;
        private string name;
        private float quantity;
        private float price;

        public Product()
        {
        }

        public Product(string id, string name, float quantity, float price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }

        public void input()
        {
            Console.Write("Id:");
            Id = Console.ReadLine();
            Console.Write("Name:");
            Name = Console.ReadLine();
            Console.Write("Quantity:");
            Quantity = float.Parse(Console.ReadLine());
            Console.Write("Price:");
            Price = float.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("ID:{0},Name:{1},Quantity:{2},Price:{3}",Id,Name,Quantity,Price);
        }
    }
}
