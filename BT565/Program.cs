using System;

namespace BT565
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Room room = new Room();
          room.inputRoom();
          room.displayRoom(); 
        Hotel hotel = new Hotel();
        hotel.inputKS();
        hotel.displayKS();
        */
            Menu();
        }
        static void addHotel()
        {
            Console.Write("Nhập số lượng khách sạn:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Hotel hotel = new Hotel();
                Console.WriteLine("Thông tin khách sạn thứ " + (i + 1));
                hotel.inputKS();
                list.Add(hotel);
            }
        }
        static void listHotel()
        {

        }
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("**********************Quản lí khách sạn**********************");
                Console.WriteLine("1.Thêm khách sạn.");
                Console.WriteLine("2.Hiển thị khách sạn.");
                Console.WriteLine("**************************************************************");
            }
        }
    }
}
