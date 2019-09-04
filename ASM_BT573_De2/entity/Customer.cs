using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_BT573_De2.entity
{
   public class Customer
    {
       
        public string IdCard { get; set; }  // mỗi khách hàng có 1 số, không thể trùng.
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public Customer()
        {
        }

        public Customer(string idCard, string fullname, int age, string gender, string address)
        {
            IdCard = idCard;
            Fullname = fullname;
            Age = age;
            Gender = gender;
            Address = address;
        }

        private static Boolean checkExistCard(List<Customer> list,string str)
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


        public void inputCustomerWithoutCardId()
        {
            while (true)
            {
                Console.Write("Nhập tên:");
                Fullname = Console.ReadLine();
                if (Fullname.Length > 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tên quá ngắn, nhập lại:");
                }
            }
            while (true)
            {
                Console.Write("Nhập tuổi:");
                Age = int.Parse(Console.ReadLine());
                if (Age >= 18)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tuổi không hợp lệ, nhập lại!!!");
                }
            }
            while (true)
            {

                Console.Write("Nhập giới tính:");
                Gender = Console.ReadLine();
                if (Gender == "nam" || Gender == "nu" || Gender == "other")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Giới tính không hợp lệ, nhập lại!!!");
                }
            }

            Console.Write("Địa chỉ:");
            Address = Console.ReadLine();

        }
        public void inputCustomer(List<Customer> list)
        {
            while (true)
            {
                Console.Write("Nhập CMTND:");
                IdCard = Console.ReadLine();
                if (!checkExistCard(list, IdCard))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Số cmt đã có người sử dung,vui lòng nhập lại:");
                }
            }
            while (true)
            {
                Console.Write("Nhập tên:");
                Fullname = Console.ReadLine();
                if (Fullname.Length > 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tên quá ngắn, nhập lại:");
                }
            }
            while (true)
            {
                Console.Write("Nhập tuổi:");
                Age = int.Parse(Console.ReadLine());
                if (Age >= 18)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tuổi không hợp lệ, nhập lại!!!");
                }
            }
            while (true)
            {

                Console.Write("Nhập giới tính:");
                Gender = Console.ReadLine();
                if(Gender=="nam" || Gender == "nu" || Gender == "other")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Giới tính không hợp lệ, nhập lại!!!");
                }
            }
            
            Console.Write("Địa chỉ:");
            Address = Console.ReadLine();
           
        }

      /*  Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", "Fullname", "IdCard", "Age", "Gender", "Address");

            foreach (Customer cus in listCus)
            {
                cus.display();
            }

    */
    public void displayCustomer()
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}",Fullname,IdCard,Age,Gender,Address);
        }
      

        
    }
}
