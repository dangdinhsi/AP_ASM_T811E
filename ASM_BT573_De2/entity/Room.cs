using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_BT573_De2.entity
{
    class Room
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int PeopleMax { get; set; }
        public string RoomCode { get; set; }  

        public Room()
        {
        }

        public Room(string name, float price, int peopleMax, string roomCode)
        {
            Name = name;
            Price = price;
            PeopleMax = peopleMax;
            RoomCode = roomCode;
        }
        public void inputRoom()
        {
            Console.Write("Nhập mã phòng:");
            RoomCode = Console.ReadLine();
            Console.Write("Tên phòng:");
            Name = Console.ReadLine();
            Console.Write("Số người tối đa:");
            PeopleMax = int.Parse(Console.ReadLine());
            Console.Write("Giá tiền:");
            Price = float.Parse(Console.ReadLine());
        }
        public void displayRoom()
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}",Name,RoomCode,Price,PeopleMax);

        }
    }
}
