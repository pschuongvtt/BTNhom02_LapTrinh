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
        public List<Employee> ListOfEmployee
        {
            get { return listOfEmployee; }
            set { listOfEmployee = value; }
        }

        //Xây dựng hàm khởi tạo không tham số
        public Department()
        {
            this.DepartmentName = "";
            listOfEmployee = new List<Employee>();
        }

        //Xây dựng hàm khởi tạo có tham số 
        public Department(string DepartmentName, List<Employee> listOfEmployee)
        {
            this.DepartmentName = DepartmentName;
            this.listOfEmployee = listOfEmployee;
        }

        //Xây dựng phương thức phương thức Display 
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

        //Xây dựng phương thức ToString
        public void ToString()
        {

        }
        
    }
}
