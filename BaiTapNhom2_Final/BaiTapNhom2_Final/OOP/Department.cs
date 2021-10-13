using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom2_Final.OOP
{
    public class Department
    {
        private string departmentName;
        private List<Employee> listOfEmployee;

        //Xây dựng getter, setter 
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

        //Xây dựng hàm khởi tạo không tham số 
        public Department()
        {
            this.DepartmentName = "";
            listOfEmployee = new List<Employee>();
        }

        //Xây dựng hàm khởi tạo có tham số 
        public Department(string DepartmentName)
        {
            this.DepartmentName = DepartmentName;
            listOfEmployee = new List<Employee>();
        }

        //Xây dựng phương thức ToString -- Chính là phương thức Display 
        public void Display()
        {
            //Xuất thông tin phòng ban 
            Console.WriteLine("Phòng ban : {0}", DepartmentName);
            //Xuất thông tin danh sách nhân viên thuộc phòng ban đó 
            foreach (var item in listOfEmployee)
            {
                item.Display();
            }
        }

        //Add SalariedEmployee
        public void AddEmployee(SalariedEmployee ee)
        {
            listOfEmployee.Add(ee);
        }

        //Add HourtyEmployee
        public void AddEmployee(HourtyEmployee ee)
        {
            listOfEmployee.Add(ee);
        }
    }
}
