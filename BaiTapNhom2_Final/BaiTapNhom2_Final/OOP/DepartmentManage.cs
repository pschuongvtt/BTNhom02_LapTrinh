using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom2_Final.OOP
{
    class DepartmentManage
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Department department = new Department();

            int x = 3;
            do
            {
                Console.WriteLine("-------------------------Mời bạn chọn tính năng-----------------------------");
                Console.WriteLine("1. Nhập danh sách phòng ban và nhân viên");
                Console.WriteLine("2. Hiển thị thông tin từng loại dối tượng nhân viên");
                Console.WriteLine("3. Tìm kiếm Nhân viên");
                Console.WriteLine("4. Thống kê");
                Console.WriteLine("--> Mời bạn chọn chức năng");

                int kq = Convert.ToInt32(Console.ReadLine());
                switch (kq)
                {
                    case 1:
                        //Kiên
                        break;
                    case 2:
                        //Kiên
                        break;
                    case 3:
                        //Hương
                        break;
                    case 4:
                        //Kiều
                        break;
                }

            } while (x > 0);



            Console.ReadKey(); 
        }
       
    }
}
