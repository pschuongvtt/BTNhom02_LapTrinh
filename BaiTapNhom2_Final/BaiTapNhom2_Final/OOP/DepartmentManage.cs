using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaiTapNhom2_Final.OOP
{
    class DepartmentManage
    {
        List<Department> listdepartment = new List<Department>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //Khởi tạo đối tượng 
            DepartmentManage manage = new DepartmentManage();

            int x = 3;
            do
            {
                Console.WriteLine("-------------------------Mời bạn chọn tính năng-----------------------------");
                Console.WriteLine("1. Nhập danh sách phòng ban và nhân viên");
                Console.WriteLine("2. Hiển thị thông tin từng loại đối tượng nhân viên");
                Console.WriteLine("3. Tìm kiếm Nhân viên");
                Console.WriteLine("4. Thống kê");
                Console.WriteLine("--> Mời bạn chọn chức năng");

                //ThuHuong đã sửa phần chạy nhập sai ký tự
                string chuoi_kq = Console.ReadLine();
                int kq = manage.KiemTraNhapChonMenu_PhanCap4(chuoi_kq);

                switch (kq)
                {
                    case 1:
                        #region 1. Nhập danh sách phòng ban và nhân viên
                        //Kiên
                        int y = 3;
                        do
                        {
                            Console.WriteLine("-----Mời bạn chọn danh mục-----");
                            Console.WriteLine("1_1. Nhập danh sách phòng ban");
                            Console.WriteLine("1_2. Nhập danh sách nhân viên");
                            Console.WriteLine("1_3. Trở lại menu chính");
                            Console.WriteLine("--> Mời bạn chọn chức năng");

                            //ThuHuong đã sửa phần chạy nhập sai ký tự
                            chuoi_kq = Console.ReadLine();
                            int case1 = manage.KiemTraNhapChonMenu_PhanCap3(chuoi_kq);

                            switch (case1)
                            {
                                case 1:
                                    Console.Write("Nhập tên phòng ban cần thêm: ");
                                    string tam = Console.ReadLine();
                                    List<Employee> dsnv = new List<Employee>();
                                    manage.NhapDanhSachPhongBan(tam, dsnv);

                                    Console.WriteLine("\n\n");
                                    break;
                                case 2:
                                    manage.NhapDanhSachNhanVien();
                                    Console.WriteLine("\n\n");
                                    break;
                                default:
                                    y = -1;
                                    Console.WriteLine("\n\n");
                                    break;
                            }
                        } while (y > 0);
                        break;
                        #endregion
                    case 2:
                        #region 2. Hiển thị thông tin từng loại đối tượng nhân viên
                        //Kiên
                        int z = 3;
                        do
                        {
                            Console.WriteLine("-----Mời bạn chọn danh mục-----");
                            Console.WriteLine("2_1. Xuất toàn bộ danh sách nhân viên");
                            Console.WriteLine("2_2. Xuất toàn bộ danh sách nhân viên SarariedEmployee");
                            Console.WriteLine("2_3. Xuất toàn bộ danh sách nhân viên HourtyEmployee");
                            Console.WriteLine("2_4. Trở lại menu chính");
                            Console.WriteLine("--> Mời bạn chọn chức năng");

                            //ThuHuong đã sửa phần chạy nhập sai ký tự
                            chuoi_kq = Console.ReadLine();
                            int chon = manage.KiemTraNhapChonMenu_PhanCap4(chuoi_kq);

                            switch (chon)
                            {
                                //1: Toàn bộ  , 2 : SalariedEmployee , 3 : HourtyEmployee
                                case 1://Xuất toàn bộ nhân viên
                                    foreach (Department item in manage.listdepartment)
                                        item.Display();
                                    Console.WriteLine("\n\n");
                                    break;
                                case 2:
                                    foreach (var item in manage.listdepartment)
                                    {
                                        if (manage.listdepartment.Count > 0)
                                            foreach (Employee tam in item.ListOfEmployee)
                                            {
                                                if (tam.GetType() == typeof(SalariedEmployee))
                                                    tam.Display();
                                            }

                                    }
                                    Console.WriteLine("\n\n");
                                    break;
                                case 3:
                                    foreach (Department item in manage.listdepartment)
                                    {
                                        if (manage.listdepartment.Count > 0)
                                            foreach (var tam in item.ListOfEmployee)
                                            {
                                                if (tam.GetType() == typeof(HourtyEmployee))
                                                    tam.Display();
                                            }
                                    }
                                    Console.WriteLine("\n\n");
                                    break;
                                default:
                                    z = -1;
                                    Console.WriteLine("\n\n");
                                    break;
                            }
                        } while (z > 0);
                        break;
                        #endregion
                    case 3:
                        #region 3. Tìm kiếm Nhân viên
                        //Hương
                        int t = 3;
                        do
                        {
                            Console.WriteLine("-----Mời bạn chọn danh mục-----");
                            Console.WriteLine("3_1. Tìm kiếm nhân viên theo phòng ban");
                            Console.WriteLine("3_2. Tìm kiếm nhân viên theo tên");
                            Console.WriteLine("3_3. Trở lại menu chính");
                            Console.WriteLine("--> Mời bạn chọn chức năng");

                            //ThuHuong đã sửa phần chạy nhập sai ký tự
                            chuoi_kq = Console.ReadLine();
                            int case1 = manage.KiemTraNhapChonMenu_PhanCap3(chuoi_kq);

                            switch (case1)
                            {
                                case 1:
                                    Console.WriteLine("Mời bạn nhập tên phòng ban");
                                    string tenPhongban = Console.ReadLine();
                                    manage.TimKiemNhanVienTheoPhongBan(tenPhongban.Trim());
                                    Console.WriteLine("\n\n");
                                    break;
                                case 2:
                                    Console.WriteLine("Mời bạn nhập tên nhân viên");
                                    string tenNhanVien = Console.ReadLine();
                                    manage.TimKiemNhanVienTheoTen(tenNhanVien.Trim());
                                    Console.WriteLine("\n\n");
                                    break;
                                default:
                                    t = -1;
                                    Console.WriteLine("\n\n");
                                    break;
                            }
                        } while (t > 0);
                        break;
                        #endregion
                    case 4:
                        #region 4. Thống kê
                        //Kiều
                        manage.HienThiDanhSach();
                        Console.WriteLine("\n\n");
                        break;
                        #endregion
                       
                }

            } while (x > 0);

            Console.ReadKey(); 
        }

        //1_1. Nhập danh sách phòng ban
        public void NhapDanhSachPhongBan(string tenphongban, List<Employee> ls)
        {
            Department department = new Department(tenphongban, ls);
            listdepartment.Add(department);
        }

        //1_2. Nhập danh sách nhân viên 
        public void NhapDanhSachNhanVien()
        {
            int x = 1;
            string tenPhongBan;
            //Khởi tạo đối tượng Department 
            Department dp = new Department(); 

            //Dùng vòng lặp While để lấy được đối tượng Department 
            while (x == 1)
            {
                int bien = 0;
                Console.WriteLine("Mời bạn nhập tên phòng ban : ");
                tenPhongBan = Console.ReadLine();
                foreach (var item in listdepartment)
                {
                    if (item.DepartmentName.Equals(tenPhongBan))
                    {
                        bien = 1;
                        dp = item; //Tìm được đối tượng dp
                    }
                }
                if (bien == 1)
                {
                    x = 2; //Thiết lập giá trị thoát khỏi while 
                }
                else Console.WriteLine("Tên phòng ban không tôn tại trong hệ thống\n");
            }

            int t = 3;
            do
            {

                Console.WriteLine("-----Mời bạn chọn danh mục phân cấp con-----");
                Console.WriteLine("1_2_1. Nhập thông tin nhân viên SalariedEmployee");
                Console.WriteLine("1_2_2. Nhập thông tin nhân viên HourtyEmployee");
                Console.WriteLine("1_2_3. Trở lại menu");
                Console.WriteLine("--> Mời bạn chọn chức năng");

                int case1 = Convert.ToInt32(Console.ReadLine());
                //Khai báo biến chung
                double CommissionRate = 0, GrossSales = 0, BasicSalary = 0, Wage = 0, WorkingHours = 0;
                string SSN, FirstName, LastName, Phone = "089875852", Email="test@gmail.com", BirthDate;
                int NgaySinh = 17, ThangSinh = 8, NamSinh = 1997;
                string chuoi_NgaySinh, chuoi_ThangSinh;
                int temp = 3;
                switch (case1)
                {
                    case 1:
                        Console.WriteLine("Mời bạn nhập SSN");
                        SSN = Console.ReadLine(); 
                        Console.WriteLine("Mời bạn nhập FirstName");
                        FirstName = Console.ReadLine(); 
                        Console.WriteLine("Mời bạn nhập LastName");
                        LastName = Console.ReadLine();

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Phone");
                            string s = Console.ReadLine();
                            if (IsValidPhone(s)==true)
                            {
                                Phone = s;
                                break;
                            }
                            else Console.WriteLine("Bạn nhập không đúng định dạng số 7 ký tự");
                        }

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Email");
                            string s = Console.ReadLine();
                            if (IsValidEmail(s) == true)
                            {
                                Email = s;
                                break;
                            }
                            else Console.WriteLine("Bạn nhập không đúng định dạng Email");
                        }
                        
                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Ngày sinh");
                            string s = Console.ReadLine();
                            if (IsInt(s) == true && Convert.ToInt32(s) >= 1 && Convert.ToInt32(s) <= 31)
                            {
                                NgaySinh = Convert.ToInt32(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai ngày sinh hoặc không đúng đúng định dạng ngày sinh");
                        }

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Tháng sinh");
                            string s = Console.ReadLine();
                            if (IsInt(s) == true  && Convert.ToInt32(s) >= 1 && Convert.ToInt32(s) <= 12)
                            {
                                ThangSinh = Convert.ToInt32(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai tháng sinh hoặc không đúng đúng định dạng tháng sinh");
                        }

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Năm sinh");
                            string s = Console.ReadLine();
                            if (IsInt(s) == true && Convert.ToInt32(s) >= 1000)
                            {
                                NamSinh = Convert.ToInt32(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai ngày sinh hoặc không đúng đúng định dạng ngày sinh");
                        }

                        //Thiết lập các kiểu định dạng hợp lệ dd/MM/yyyy; Relex
                        if (NgaySinh > 0 && NgaySinh < 10)
                            chuoi_NgaySinh = "0" + NgaySinh;
                        else chuoi_NgaySinh = NgaySinh.ToString();

                        if (ThangSinh > 0 && ThangSinh < 10)
                            chuoi_ThangSinh = "0" + ThangSinh;
                        else chuoi_ThangSinh = ThangSinh.ToString();
                        BirthDate = chuoi_NgaySinh  + "/" + chuoi_ThangSinh + "/" + NamSinh;

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập CommissionRate");
                            string s = Console.ReadLine();
                            if (Convert.ToDouble(s) >= 0)
                            {
                                CommissionRate = Convert.ToDouble(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai định dạng hoặc giá trị phải > 0 cho CommissionRate");
                        }

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập GrossSales");
                            string s = Console.ReadLine();
                            if (Convert.ToDouble(s) >= 0)
                            {
                                GrossSales = Convert.ToDouble(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai định dạng hoặc giá trị phải > 0 cho GrossSales");
                        }

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập BasicSalary");
                            string s = Console.ReadLine();
                            if (Convert.ToDouble(s) >= 0)
                            {
                                BasicSalary = Convert.ToDouble(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai định dạng hoặc giá trị phải > 0 cho BasicSalary");
                        }
                        
                        //Khởi tạo đối tượng
                        Employee salary = new SalariedEmployee(CommissionRate,GrossSales,BasicSalary,SSN,FirstName,LastName,Phone,Email,BirthDate);
                        //Add thông tin đối tượng vào list
                        dp.ListOfEmployee.Add(salary);
                        break;
                    case 2:
                       Console.WriteLine("Mời bạn nhập SSN");
                        SSN = Console.ReadLine(); 
                        Console.WriteLine("Mời bạn nhập FirstName");
                        FirstName = Console.ReadLine(); 
                        Console.WriteLine("Mời bạn nhập LastName");
                        LastName = Console.ReadLine();

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Phone");
                            string s = Console.ReadLine();
                            if (IsValidPhone(s)==true)
                            {
                                Phone = s;
                                break;
                            }
                            else Console.WriteLine("Bạn nhập không đúng định dạng số 7 ký tự");
                        }

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Email");
                            string s = Console.ReadLine();
                            if (IsValidEmail(s) == true)
                            {
                                Email = s;
                                break;
                            }
                            else Console.WriteLine("Bạn nhập không đúng định dạng Email");
                        }
                        
                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Ngày sinh");
                            string s = Console.ReadLine();
                            if (IsInt(s) == true && Convert.ToInt32(s) >= 1 && Convert.ToInt32(s) <= 31)
                            {
                                NgaySinh = Convert.ToInt32(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai ngày sinh hoặc không đúng đúng định dạng ngày sinh");
                        }

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Tháng sinh");
                            string s = Console.ReadLine();
                            if (IsInt(s) == true && Convert.ToInt32(s) >= 1 && Convert.ToInt32(s) <= 12)
                            {
                                ThangSinh = Convert.ToInt32(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai tháng sinh hoặc không đúng đúng định dạng tháng sinh");
                        }

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Năm sinh");
                            string s = Console.ReadLine();
                            if (IsInt(s) == true)
                            {
                                NamSinh = Convert.ToInt32(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai ngày sinh hoặc không đúng đúng định dạng ngày sinh");
                        }

                        //Thiết lập các kiểu định dạng hợp lệ dd/MM/yyyy
                        if (NgaySinh > 0 && NgaySinh < 10)
                            chuoi_NgaySinh = "0" + NgaySinh;
                        else chuoi_NgaySinh = NgaySinh.ToString();

                        if (ThangSinh > 0 && ThangSinh < 10)
                            chuoi_ThangSinh = "0" + ThangSinh;
                        else chuoi_ThangSinh = ThangSinh.ToString();
                        BirthDate = chuoi_NgaySinh  + "/" + chuoi_ThangSinh + "/" + NamSinh;

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập Wage");
                            string s = Console.ReadLine();
                            if (Convert.ToDouble(s) >= 0)
                            {
                                Wage = Convert.ToDouble(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai định dạng hoặc giá trị phải > 0 cho Wage");
                        }

                        while (temp > 0)
                        {
                            Console.WriteLine("Mời bạn nhập WorkingHours");
                            string s = Console.ReadLine();
                            if (Convert.ToDouble(s) >= 0)
                            {
                                WorkingHours = Convert.ToDouble(s);
                                break;
                            }
                            else Console.WriteLine("Bạn nhập sai định dạng hoặc giá trị phải > 0 cho WorkingHours");
                        }

                        //Khởi tạo đối tượng
                        Employee hourty = new HourtyEmployee(Wage,WorkingHours,SSN,FirstName,LastName,Phone,Email,BirthDate);
                        //Add thông tin đối tượng vào list
                        dp.ListOfEmployee.Add(hourty);
                        break;
                    default:
                        t = -1;
                        break;
                }
            } while (t > 0);
        }

        //3_1: Tìm kiếm nhân viên theo phòng ban 
        public void TimKiemNhanVienTheoPhongBan(string TenPhongBan)
        {
            int kq = 0;//Thiết lập bool
            foreach (var item in listdepartment)
            {
                if (item.DepartmentName.Equals(TenPhongBan))
                {
                    item.Display();
                    kq ++;
                }
            }
            if (kq==0)
            {
                Console.WriteLine("Không tìm thấy tên phòng ban ứng với danh sách nhân viên mà bạn cần tìm");
            }
        }

        //3_2: Tìm kiếm nhân viên theo tên nhân viên 
        public void TimKiemNhanVienTheoTen(string TenNhanVien)
        {
            int kq = 0;//bool
            foreach (var depart in listdepartment)
            {
                foreach (var empl in depart.ListOfEmployee)
                {
                    if(empl.LastName.Equals(TenNhanVien))
                    {
                        empl.Display();
                        kq ++;
                    }
                }
            }
            if (kq==0)
            {
                Console.WriteLine("Không tìm thấy tên nhân viên mà bạn cần tìm");
            }
        }

        //4. Thống kê danh sách các phòng ban và số lương nhân viên tương ứng từng phòng ban 
        public void HienThiDanhSach()
        {
            Console.WriteLine("-->Hiển thị danh sách phòng ban : "); 
            int i = 1; 
            foreach (var item in listdepartment)
            {
                Console.WriteLine("{0}. {1}. Tổng số lượng nhân viên : {2}", i, item.DepartmentName, item.ListOfEmployee.Count());
                i++;
            }
        }

        #region 5. Hàm dùng chung
        //Hàm tìm phòng ban 
        public bool TimPhongBan(string tenPhongBan)
        {
            foreach (var item in listdepartment)
            {
                if (item.DepartmentName.Equals(tenPhongBan))
                {
                    return true;
                }
            }
            return false;
        }

        //Xây dựng hàm kiểm tra có phải email không : 1 - True , 0 - False
        public bool IsValidEmail(string email)
        {
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            return rx.IsMatch(email);
        }

        //Ham Kiem tra chuoi chi chua cac ki tu 0123456789
        public bool IsInt(string num)
        {
            foreach (char c in num)
            {
                int iN = (int)c;
                //Ma ASCII: 48=0, 57=9
                if ((iN > 57) || (iN < 48))
                    return false;
            }
            return true;
        }

        //Hàm kiểm tra Số điện thoại có phải kiểu số 0 : 1 - True , 0 - False
        public bool IsValidPhone(string value)
        {
            if (IsInt(value) == true)
            {
                if (value.Length < 7 || value.Length > 10)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }

        //Hàm kiểm tra chọn menu 4 phân cấp
        public int KiemTraNhapChonMenu_PhanCap4(string chuoi_kq)
        {
            //ThuHuong đã sửa phần chạy nhập sai ký tự
            int kq = 0;
            int check_chon = 3;
            while (check_chon > 0)
            {
                if (Int32.TryParse(chuoi_kq, out kq))
                {
                    if (Convert.ToInt32(chuoi_kq) < 5 && Convert.ToInt32(chuoi_kq) > 0)
                    {
                        return kq = Convert.ToInt32(chuoi_kq);
                    }
                    else
                    {
                        Console.WriteLine("Bạn nhập sai ký hiệu hoặc không có tính năng trong menu");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Bạn nhập sai ký hiệu hoặc không có tính năng trong menu");
                    break;
                }
            }
            return 0;
        }


        //Hàm kiểm tra chọn menu 3 phân cấp
        public int KiemTraNhapChonMenu_PhanCap3(string chuoi_kq)
        {
            //ThuHuong đã sửa phần chạy nhập sai ký tự
            int kq = 0;
            int check_chon = 3;
            while (check_chon > 0)
            {
                if (Int32.TryParse(chuoi_kq, out kq))
                {
                    if (Convert.ToInt32(chuoi_kq) < 4 && Convert.ToInt32(chuoi_kq) > 0)
                    {
                        return kq = Convert.ToInt32(chuoi_kq);
                    }
                    else
                    {
                        Console.WriteLine("Bạn nhập sai ký hiệu hoặc không có tính năng trong menu");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Bạn nhập sai ký hiệu hoặc không có tính năng trong menu");
                    break;
                }
            }
            return 0;
        }
        #endregion
      
    }
}
