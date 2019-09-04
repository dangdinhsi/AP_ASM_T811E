using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace BT560
{
    
    class Program
    {
        static List<ClassRoom> list = new List<ClassRoom>();
        static void Main(string[] args)
        {
            /*   List<ClassRoom> list = new List<ClassRoom>();
             Console.Write("Số lượng lớp cần thêm:");
             int n = int.Parse(Console.ReadLine());
             for(int i = 0; i < n; i++)
             {
                 ClassRoom room = new ClassRoom();
                 Console.WriteLine("phong thu " + (i + 1));
                 room.input();
                 list.Add(room);
             }
             string jsonText = JsonConvert.SerializeObject(list);
             Console.WriteLine(jsonText);
             File.WriteAllText("data.json", jsonText);
             Console.WriteLine("Success!!!");
             */
            int choose = 0;

            do
            {
                Menu();
                Console.Write("Nhap lua chon:");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        getDataToFile();
                        break;
                    case 2:
                        getInforClassroom();
                        break;
                    case 3:
                        SaveClassroomWithName();
                        break;
                    default:
                        Console.WriteLine("Nhap sai,Vui long nhap lai!!");
                        break;
                }

            } while (choose != 3);
       
        }

        static void getDataToFile()
        {
            string jsonText = String.Empty;
            jsonText = File.ReadAllText("data.json");
            list = JsonConvert.DeserializeObject<List<ClassRoom>>(jsonText);
            if (list.Count != 0)
            {
                Console.WriteLine("Success!!");
            }
        }
        static void getInforClassroom()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Khong co thong tin hien thi.");
            }
            else
            {
                foreach (var classRoom in list)
                {
                    classRoom.display();
                }
            }
            
        }
        static void SaveClassroomWithName()
        {
            int dem = 0;
            for(int i = 0; i < list.Count; i++)
            {
                dem++;
                ClassRoom classRoom = list[i];
                string name = classRoom.Name;
                using (Stream stream = File.Open(name, FileMode.Create))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFormatter.Serialize(stream, classRoom);
                }
            }
            Console.WriteLine("Da thuc hien ghi thong tin {0} classroom vao file rieng biet",dem);
        }
        static void Menu()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("1.Lay thong tin sinh vien tu file data.json.");
            Console.WriteLine("2.Hien thi thong tin lop hoc.");
            Console.WriteLine("3.Luu thong tin tung lop hoc ra file rieng biet.");
            Console.WriteLine("************************************************");
        }

    }
}
