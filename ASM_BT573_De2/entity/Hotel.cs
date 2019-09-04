using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_BT573_De2.entity
{
    class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public List<Room> roomList = new List<Room>();
        public string HotelCode { get; set; }

        public Hotel()
        {
        }

        public Hotel(string name, string address, string type, string hotelCode)
        {
            Name = name;
            Address = address;
            Type = type;
            HotelCode = hotelCode;
        }

        private static Boolean checkHotelExist(List<Hotel> list, string str)
        {
            foreach(Hotel hotel in list)
            {
                if (hotel.HotelCode.Equals(str))
                {
                    return true;
                }
            }
            return false;
        }
        public void inputHotel(List<Hotel> list)
        {
            while (true)
            {
                Console.Write("Mã khách sạn:");
                HotelCode = Console.ReadLine();
                if (!checkHotelExist(list,HotelCode))
                {
                    break;
                }
                Console.WriteLine("Mã khách sạn đã được sử dụng!!!");
            }
            
            Console.Write("Nhập tên khách sạn:");
            Name = Console.ReadLine();
            Console.Write("Loại khách sạn:");
            Type = Console.ReadLine();
            Console.Write("Địa chỉ:");
            Address = Console.ReadLine();
            Console.Write("Số lượng phòng cần thêm:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Room room = new Room();
                Console.WriteLine("Phòng thứ {0}.", i + 1);
                room.inputRoom();
                roomList.Add(room);
            }
        }

        public void displayBaseInforHotel()
        {
            Console.WriteLine("Tên:{0},Mã khách sạn:{1}.", Name, HotelCode);
        }
        public void displayFullInforHotel()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("+Tên KS:{0},Mã KS:{1},Loại:{2},Địa chỉ:{3}.", Name, HotelCode, Type, Address);
            Console.WriteLine("+DS phòng của khách sạn {0}:",Name);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", "Name", "RoomCode", "Price", "PeopleMax");
            foreach (Room room in roomList)
            {
                room.displayRoom();
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
    }
}
