using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3, n;
            Console.Write("Nhap so max:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Day fibonaci la:0 1 ");
            for (int i = 2; i < (n - 1); ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
