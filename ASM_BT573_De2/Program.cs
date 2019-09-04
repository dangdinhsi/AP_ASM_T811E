using ASM_BT573_De2.entity;
using ASM_BT573_De2.util;
using System;
using System.Collections.Generic;

namespace ASM_BT573_De2
{

    class Program
    {

        static List<Customer> listCustomer = new List<Customer>();
        static List<Book> listBook = new List<Book>();
        static List<Hotel> listHotel = new List<Hotel>();
        static void Main(string[] args)
        {
            int choose = 0;
            do
            {
                GenerateMenu();
                Console.Write("Nhập lựa chọn:");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        addHotel();
                        break;
                    case 2:
                        getHotel();
                        break;
                    case 3:
                        editHotel();
                        break;
                    case 4:
                        deleteHotel();
                        break;
                    case 5:
                        booking();
                        break;
                    case 6:
                        editCustomer();
                        break;
                    case 7:
                        deleteCustomer();
                        break;
                    case 8:
                        ShowRoomAvaiable();
                        break;
                    case 9:
                        Revenue();
                        break;
                    case 10:
                        Console.WriteLine("Good bye!!!");
                        break;
                    default:
                        Console.WriteLine("Bạn nhập lựa chọn không hợp lệ!!");
                        break;
                }

            } while (choose != 10);
            
        }
       static void GenerateMenu()
        {
            Console.WriteLine("****************************Quản lí khách sạn********************************");
            Console.WriteLine("1.Thêm khách sạn");
            Console.WriteLine("2.Danh sách khách sạn.");
            Console.WriteLine("3.Sửa khách sạn.");
            Console.WriteLine("4.Xóa khách sạn.");
            Console.WriteLine("5.Đặt phòng nghỉ.");
            Console.WriteLine("6.Sửa thông tin khách hàng đặt phòng.");
            Console.WriteLine("7.Xóa thông tin khách hàng đặt phòng.");
            Console.WriteLine("8.Tìm phòng còn trống.");
            Console.WriteLine("9.Thống kê doanh thu.");
            Console.WriteLine("10.Thoát chương trình.");
            Console.WriteLine("*****************************************************************************");
        }

        static void Revenue()
        {
            if (listBook.Count==0)
            {
                Console.WriteLine("Chức năng chưa được thực hiện do chưa có khách hang đặt phòng!!");
                return;
            }
            Console.WriteLine("1.Danh sách booking.");
            foreach(Book book in listBook)
            {
                book.displayBook();
            }
            Console.WriteLine("2.Doanh thu.");
            foreach(Hotel hotel in listHotel)
            {
                float money = getTotal(hotel);
                Console.WriteLine("{0}-Doanh thu:{1}", hotel.Name ,money);
            }

        }

        static float getTotal(Hotel hotel)
        {
            float total = 0;
            foreach(Book book in listBook)
            {
                if (book.HotelCode.Equals(hotel.HotelCode))
                {
                    float price = getMoney(hotel.roomList,book.RoomCode);
                    total += price * (book.CheckOut.Day -book.CheckIn.Day);
                }
            }
            return total;
        }

        static float getMoney(List<Room> listRoom, string roomCode)
        {
            foreach (Room room in listRoom)
            {
                if (room.RoomCode.Equals(roomCode))
                {
                    return room.Price;
                }
            }

            return 0;
        }
        static Boolean checkExistCustomer(string str)
        {
            foreach(Customer customer in listCustomer)
            {
                if (customer.IdCard.Equals(str))
                {
                    return true;
                }
            }
            return false;
        }

        static void deleteCustomer()
        {
            if (listCustomer.Count == 0)
            {
                Console.WriteLine("Chức năng chưa được thực hiện do không có thông tin khách hàng!!");
                return;
            }
            foreach (Customer customer in listCustomer)
            {
                customer.displayCustomer();
            }
            Console.Write("Nhập CMTND khách hàng cần xóa:");
            string str = Console.ReadLine();
            if (checkExistCustomer(str))
            {
                for(int i = 0; i < listCustomer.Count; i++)
                {
                    if (listCustomer[i].IdCard.Equals(str))
                    {
                        listCustomer.RemoveAt(i);
                        Console.WriteLine("Xóa khách hàng thành công!!");
                    }
                }
                foreach (Customer customer in listCustomer)
                {
                    customer.displayCustomer();
                }
            }
            else
            {
                Console.WriteLine("Số CMTND nhập không trùng khớp!!!");
            }
        }
        static void editCustomer()
        {
            if (listCustomer.Count == 0)
            {
                Console.WriteLine("Chức năng chưa được thực hiện do không có thông tin khách hàng!!");
                return;
            }
            foreach (Customer customer in listCustomer)
            {
                customer.displayCustomer();
            }
            Console.Write("Nhập CMTND khách hàng cần sửa:");
            string str = Console.ReadLine();
            if (checkExistCustomer(str))
            {
                Console.WriteLine("Update thông tin mới:");
                Console.Write("Tên:");
                string fullname = Console.ReadLine();
                Console.Write("Tuổi:");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Giới tính:");
                string gender = Console.ReadLine();
                Console.Write("Địa chỉ:");
                string address = Console.ReadLine();
                foreach(Customer customer in listCustomer)
                {
                    if (customer.IdCard.Equals(str))
                    {
                        customer.Fullname = fullname;
                        customer.Age = age;
                        customer.Gender = gender;
                        customer.Address = address;
                    }
                }
                Console.WriteLine("Update thành công!!");
            }
            else
            {
                Console.WriteLine("Số chứng minh nhập không hợp lệ!");
            }
        }
        static void ShowRoomAvaiable()
        {
            if (listHotel.Count == 0)
            {
                Console.WriteLine("Chức năng chưa được thực hiện do không có thông tin khách sạn!!");
                return;
            }

            DateTime cIn, cOut;

            while (true)
            {
                Console.Write("Nhập ngày đặt phòng (dd-mm-yyyy):");
                DateTime checkin = Utils.ConvertStringToDatetime(Console.ReadLine());
                Console.Write("Nhập ngày trả phòng (dd-mm-yyyy):");
                DateTime checkout = Utils.ConvertStringToDatetime(Console.ReadLine());
                if (DateTime.Compare(checkout, checkin) == 1)
                {
                    cIn = checkin;
                    cOut = checkout;
                    break;

                }
                else
                {
                    Console.WriteLine("Vui lòng nhập lại thông tin, thông tin bạn nhập không hợp lệ!!");
                }
            }
            
            foreach(Hotel hotel in listHotel)
            {
               


                    Console.WriteLine("Danh sách phòng của KS {0}, Mã KS:{1} phù hợp với lịch đặt phòng({2} đến {3})", hotel.Name, hotel.HotelCode, Utils.ConvertDatetimeToString(cIn), Utils.ConvertDatetimeToString(cOut));
                   

                    foreach (Room room in hotel.roomList)
                    {
                    
                    
                        Boolean isAvaiable = true;
                        foreach (Book book in listBook)
                        {
                            if (book.HotelCode == hotel.HotelCode && book.RoomCode == room.RoomCode)
                            {
                                if (!book.CheckTimeAvailable(cIn, cOut))
                                {
                                
                                    isAvaiable = false;
                                Console.WriteLine("-Không có phòng còn trống từ ngày {0} đến ngày {1}.", Utils.ConvertDatetimeToString(cIn), Utils.ConvertDatetimeToString(cOut));
                                    break;
                                }
                            }
                        }
                        if (isAvaiable)
                        {
                        Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", "Name", "RoomCode", "Price", "PeopleMax");
                        room.displayRoom();
                        }
                    }
                
            }
        }
        static void booking()
        {
            if (listHotel.Count == 0)
            {
                Console.WriteLine("Chức năng chưa được thực hiện do không có thông tin khách sạn!!");
                return;
            }
            Book book = new Book();
            book.inputBook(listCustomer,listHotel,listBook);
            listBook.Add(book);
        }
        static void addHotel()     // thêm khách sạn.
        {
            Console.Write("Số khách sạn cần thêm:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Hotel hotel = new Hotel();
                Console.WriteLine("Khách sạn " + (i + 1));
                hotel.inputHotel(listHotel);
                listHotel.Add(hotel);
            }
        }
        static void getHotel()
        {
            if (listHotel.Count == 0)
            {
                Console.WriteLine("Chức năng chưa được thực hiện do không có thông tin khách sạn!!");
                return;
            }
            foreach (Hotel hotel in listHotel)
            {
                hotel.displayFullInforHotel();
            }
        }

        static void deleteHotel()
        {
            if (listHotel.Count == 0)
            {
                Console.WriteLine("Chức năng chưa được thực hiện do không có thông tin khách sạn!!");
                return;
            }

            foreach (Hotel hotel in listHotel)
            {
                hotel.displayBaseInforHotel();
            }
            Console.Write("Nhập mã khách sạn cần xóa:");
            string code = Console.ReadLine();
            if (checkExistHotel(code))
            {
                for(int i = 0; i < listHotel.Count; i++)
                {
                    if (listHotel[i].HotelCode.Equals(code))
                    {
                        listHotel.RemoveAt(i);
                        Console.WriteLine("Xóa thành công!!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Mã khách sạn bạn nhập không hợp lệ!!");
            }
            
        }
        static void editHotel()
        {
            if (listHotel.Count == 0)
            {
                Console.WriteLine("Chức năng chưa được thực hiện do không có thông tin khách sạn!!");
                return;
            }
            foreach (Hotel hotel in listHotel)
            {
                hotel.displayBaseInforHotel();
            }
            Console.Write("Nhập mã khách sạn của khách sạn cần sửa:");
            string code = Console.ReadLine();
            if (checkExistHotel(code))
            {
                Console.WriteLine("Nhập thông tin update!");
                Console.Write("Tên:");
                string name = Console.ReadLine();
                Console.Write("Địa chỉ:");
                string address = Console.ReadLine();
                Console.Write("Loại khách sạn:");
                string type = Console.ReadLine();
                foreach(Hotel hotel in listHotel)
                {
                    if (hotel.HotelCode.Equals(code))
                    {
                        hotel.Name = name;
                        hotel.Address = address;
                        hotel.Type = type;
                    }
                }
                Console.WriteLine("Update thành công!!!");
            }
            else
            {
                Console.WriteLine("Mã khách sạn bạn nhập không tồn tại!!");
            }
        }

        static Boolean checkExistHotel(string str) {
            foreach(Hotel hotel in listHotel)
            {
                if (hotel.HotelCode.Equals(str))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
