using System;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dem = 0;
            Console.Write("Nhap N:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cac so nguyen to <=" + n + " la: ");
            for (int i = 0; i <= n; i++)
            {
                if (kiemtraSNT(i))
                {
                    Console.Write(i + " ");
                }
            }

        }
        static bool kiemtraSNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= n / 2; i++) if (n % i == 0) return false;
            return true;
        }
    }
}
