using System;
using System.Collections.Generic;
using System.Text;

namespace BT37
{
    class HinhChuNhat : HCNInterface
    {
        public float cDai { get; set; }
        public float cRong { get; set; }
        public float S { get; set; }
        public void dientichHCN()
        {
            S = cDai * cRong;
        }

        public void getChieuRong()
        {
            while (true)
            {
                Console.Write("Nhap chieu rong:");
                cRong = float.Parse(Console.ReadLine());
                if (cRong > 0)
                {
                    break;
                }
                Console.WriteLine("Chieu rong khong the <=0, nhap lai");
            }
           
        }

        public void getChieuDai()
        {
            while (true)
            {
                Console.Write("Nhap chieu dai:");
                cDai = float.Parse(Console.ReadLine());
                if (cDai >= cRong)
                {
                    break;
                }
                Console.WriteLine("Khong hop le, nhap lai");

            }

        }

        public override string ToString()
        {
            return "Dai:" + cDai + ",Rong:" + cRong + ",Dien tich:" + S;
        }
        public void SetDaiRong(float chieudai, float chieurong)
        {
            this.cDai = chieudai;
            this.cRong = chieurong;
        }
    }
}
