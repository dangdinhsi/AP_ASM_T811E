using ASM_BT573_De2.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_BT573_De2.entity
{
    class Book
    {
        public string HotelCode { get; set; }
        public string RoomCode { get; set; }
        public string CardId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Book()
        {
        }

        public Book(string hotelCode, string roomCode, string cardId, DateTime checkIn, DateTime checkOut)
        {
            HotelCode = hotelCode;
            RoomCode = roomCode;
            CardId = cardId;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public Boolean CheckTimeAvailable(DateTime cIn,DateTime cOut)
        {
            if (DateTime.Compare(cIn,CheckOut) > 0)
            {
                return true;
            }
            if (DateTime.Compare(cOut, CheckIn) < 0)
            {
                return true;
            }
            return false;
        }
        private static Boolean checkExistCustomer(List<Customer> list,string str)
        {
            foreach(Customer customer in list)
            {
                if (customer.IdCard.Equals(str))
                {
                    return true;
                }
            }
            return false;
        }

        public Hotel getHotelExist(List<Hotel> list,string str)
        {
            foreach(Hotel hotel in list)
            {
                if (hotel.HotelCode.Equals(str))
                {
                    return hotel;
                }
            }
            return null;
        }
        public void inputBook(List<Customer> customerList,List<Hotel> hotelList,List<Book> bookList)
        {
            
                Console.Write("Nhập CMTND khách hàng đặt phòng:");
                CardId = Console.ReadLine();
                if (!checkExistCustomer(customerList, CardId))
                {
                    Customer customer = new Customer();
                    customer.IdCard = CardId;
                    customer.inputCustomerWithoutCardId();
                    customerList.Add(customer);
                }
            foreach(Hotel hotel in hotelList)
            {
                hotel.displayBaseInforHotel();
            }
            Hotel currentHotel = null;
            while (true)
            {
                Console.Write("Nhập mã khách sạn:");
                HotelCode = Console.ReadLine();
                currentHotel = getHotelExist(hotelList,HotelCode);
                if (currentHotel != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Mã khách sạn không tồn tại, vui lòng nhập lại!!");
                }
            }

            foreach(Room room in currentHotel.roomList)
            {
                Console.WriteLine("Tên phòng:{0},Mã phòng:{1}",room.Name,room.RoomCode);
            }
            while (true)
            {
                Console.Write("Nhập mã phòng:");
                RoomCode = Console.ReadLine();
                Boolean isFind = false;
                foreach (Room room in currentHotel.roomList)
                {
                    if (room.RoomCode.Equals(RoomCode))
                    {
                        isFind = true;
                        break;
                    }
                }
                if (isFind)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Mã phòng không hợp lệ, vui lòng nhập lại!!!");

                }
            }
            while (true)
            {
                while (true)
                {
                    Console.Write("Nhập ngày đặt phòng(dd-mm-yyyy):");
                    string checkin = Console.ReadLine();
                    Console.Write("Nhập ngày trả phòng(dd-mm-yyyy):");
                    string checkout = Console.ReadLine();
                    CheckIn = Utils.ConvertStringToDatetime(checkin);
                    CheckOut = Utils.ConvertStringToDatetime(checkout);
                    int n = DateTime.Compare(CheckOut, CheckIn);
                    if (n == 1)
                    {
                        break;
                    }
                    if (n == 0)
                    {
                        Console.WriteLine("Đặt phòng tối thiểu 1 ngày trở lên.");
                    }
                    else
                    {
                        Console.WriteLine("Ngày nhập không hợp lệ,Vui lòng nhập lại!!");

                    }

                }
               
                Boolean isAvailable = true;
                foreach (Book book in bookList)
                {
                    if (book.HotelCode == HotelCode && RoomCode == book.RoomCode)
                    {
                        if (!CheckTimeAvailable(book.CheckIn, book.CheckOut))
                        {
                            isAvailable = false;
                            break;
                        }
                    }
                }
                    if (isAvailable)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Thời gian đặt phòng không hợp lệ, vui lòng đặt lại");
                    }
                
            }

        }

        public void displayBook()
        {
            Console.WriteLine("Mã KS: {0}, Mã Phòng: {1}, CMTND: {2}, Ngày đặt phòng: {3}, Ngày trả phòng: {4},Thuê {5} ngày",HotelCode,RoomCode,CardId,Utils.ConvertDatetimeToString(CheckIn),Utils.ConvertDatetimeToString(CheckOut),(CheckOut.Day-CheckIn.Day));

        }
    }
}
