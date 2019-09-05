using System;
using System.Collections.Generic;

namespace BT37
{
    class HCNTest
    {
        static void Main(string[] args)
        {
            List<HinhChuNhat> list = new List<HinhChuNhat>();

            int n = 0;
            Console.Write("Nhap bao nhieu hcn:");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Hinh " + (i + 1));
                HinhChuNhat hcn = new HinhChuNhat();
               
                hcn.getChieuRong();
                hcn.getChieuDai();
                hcn.dientichHCN();
                list.Add(hcn);
            }
            int j = 0;
            Console.WriteLine("Danh sach HCN");
            foreach(HinhChuNhat x in list)
            {
                j++;
                Console.WriteLine("HCN thu {0}"+"\n"+x.ToString(),j);
            }
            int i_new = 0;
            float max = list[0].S;
            for(int i = 1; i < list.Count; i++)
            {
                if(max<list[i].S)
                {
                    max = list[i].S;
                    i_new = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thong tin cua HCN co dien tich lon nhat");
            Console.WriteLine(list[i_new].ToString());
        }
    }
}
