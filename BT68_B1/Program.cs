using System;

namespace BT68_B1
{
    class Test
    {
        static void Main(string[] args)
        {
            Employee e2 = new Employee("dang dinh si", "nam", "HN", "hoc sinh", 1000);
            Employee e1 = new Employee();
            e1.input();
            e1.display();
            e2.display();
        }
    }
}
