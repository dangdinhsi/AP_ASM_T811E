using System;

namespace BT423
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b:");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Nhap c:");
            float c = float.Parse(Console.ReadLine());
            int choose = 0;
            do
            {
                Console.WriteLine("Giai phuong trinh");
                Console.WriteLine("1.Giai ax + b = 0");
                Console.WriteLine("2.Giai ax2+bx+c=0");
                Console.Write("Nhap lua chon:");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        giaiBacNhat(a, b);
                        break;
                    case 2:
                        giaiBacHai(a, b, c);
                        break;
                    default:
                        Console.WriteLine("Lua chon sai, chon lai");
                        break;
                }
            } while (choose != 2);
        }
        static void giaiBacNhat(float a, float b)
        {
            if(a==0 && b != 0)
            {
                Console.WriteLine("PT vo nghiem");
            }
            if(a==0 && b == 0)
            {
                Console.WriteLine("PT vo so nghiem");
            }
            Console.WriteLine("Nghiem la:" + (-b / a));
        }
        static void giaiBacHai(float a,float b, float c)
        {
            if (a == 0)
            {
                giaiBacNhat(b, c);
            }
            else
            {
               float delta = b * b - 4 * a * c;
                if (delta == 0)
                {
                    float x = -b / (2 * a);
                    Console.WriteLine("PT co 1 nghiem duy nhat:" + x);
                }
                if (delta> 0)
                {
                   double canDelta = Math.Sqrt(delta);
                    double x1 = (-b + canDelta) / (2 * a);
                    double x2 = (-b - canDelta) / (2 * a);
                    Console.WriteLine("Phuong trinh co 2 nghiem x1={0},x2={1}.",x1,x2);
                }
                if (delta < 0)
                {
                    Console.WriteLine("PT vo nghiem");
                }
                
            }
        }
    }
}
