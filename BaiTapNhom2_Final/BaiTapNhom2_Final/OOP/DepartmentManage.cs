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
                Console.WriteLine("2. Hiển thị thông tin từng loại đối tượng nhân viên");
                Console.WriteLine("3. Tìm kiếm Nhân viên");
                Console.WriteLine("4. Thống kê");
                Console.WriteLine("--> Mời bạn chọn chức năng");

                int kq = Convert.ToInt32(Console.ReadLine());
                switch (kq)
                {
                    case 1:
                        //Kiên
                        int y = 3; 
                        do{
                            Console.WriteLine("1_1. Nhập danh sách phòng ban");
                            Console.WriteLine("1_2. Nhập danh sách nhân viên");
                            Console.WriteLine("1_3. Trở lại menu chính");
                            int case1 = Convert.ToInt32(Console.ReadLine());
                            switch (case1)
                            {
                                case 1 :
                                    break; 
                                case 2 :
                                    break;
                                default :
                                    y = -1;
                                    break;
                            }
                        } while (y > 0);
                        break;
                    case 2:
                        //Kiên
                        int z = 3; 
                        do{
                            Console.WriteLine("2_1. Xuất toàn bộ danh sách nhân viên");
                            Console.WriteLine("2_2. Xuất toàn bộ danh sách nhân viên SarariedEmployee");
                            Console.WriteLine("2_3. Xuất toàn bộ danh sách nhân viên HourtyEmployee");
                            Console.WriteLine("2_4. Trở lại menu chính");
                            int case1 = Convert.ToInt32(Console.ReadLine());
                            switch (case1)
                            {
                                case 1 :
                                    break; 
                                case 2 :
                                    break;
                                default :
                                    z = -1;
                                    break;
                            }
                        } while (z > 0);
                        break;
                    case 3:
                        //Hương
                         int t = 3; 
                         do{
                            Console.WriteLine("3_1. Tìm kiếm nhân viên theo phòng ban");
                            Console.WriteLine("3_2. Tìm kiếm nhân viên theo tên");
                            Console.WriteLine("3_3. Trở lại menu chính");
                            int case1 = Convert.ToInt32(Console.ReadLine());
                            switch (case1)
                            {
                                case 1 :
                                    break; 
                                case 2 :
                                    break;
                                default :
                                    t = -1;
                                    break;
                            }
                        } while (t > 0);
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
