using System;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so phan tu cua mang:");
            n = Convert.ToInt32(Console.ReadLine());
            nhapmang(n);

        }
        static void bubblesort(int[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = n - 1; j > i; j--)
                    if (dataset[j] < dataset[j - 1])
                    {
                        int temp = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = temp;
                    }
        }

        static void nhapmang(int n)
        {
            int c = 0;
            int d = 0;
            int[] arr = new int[n];
            int[] chan = new int[n];
            int[] le = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + (i + 1) + "]:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    chan[c] = arr[i];
                    c++;
                }
                else
                {
                    le[d] = arr[i];
                    d++;
                }
            }
            bubblesort(chan, c);
            bubblesort(le, d);
            for (int i = 0; i < c; i++)
            {
                Console.Write(chan[i] + " ");
            }
            for (int i = 0; i < d; i++)
            {
                Console.Write(le[i] + " ");
            }
        }

    }
}
