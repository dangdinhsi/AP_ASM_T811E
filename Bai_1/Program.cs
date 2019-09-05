using System;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap do dai canh goc vuong cua tam giac: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                width--;
            }

            Console.ReadKey();
        }
    }
    }

