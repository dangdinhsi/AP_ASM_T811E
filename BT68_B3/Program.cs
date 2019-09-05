using System;
using System.Collections.Generic;

namespace BT68_B3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            int n = 0;
            Console.Write("Nhap n:");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("San pham thu " + (i + 1));
                Product product = new Product();
                product.input();
                list.Add(product);
            }
            float max = list[0].Price;
            int imax = 0;
            for(int i = 0; i < list.Count; i++)
            {
                if(max < list[i].Price)
                {
                    max = list[i].Price;
                    imax = i;
                }
            }
            Console.WriteLine("Thong tin san pham co gia ban cao nhat");
            list[imax].display();
        }
    }
}
