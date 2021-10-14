using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom2_Final.OOP
{
    public class HourtyEmployee : Employee
    {
        private double wage;
        private double workingHours;

        //Xây dựng getter,setter
        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }
        public double WorkingHours
        {
            get { return workingHours; }
            set { workingHours = value; }
        }

        //Xây dựng hàm khởi tạo 8 tham số 
        public HourtyEmployee(double Wage, double WorkingHours, string SSN, string FirstName, string LastName, string Phone, string Email, string BirthDate)
            : base(SSN, FirstName, LastName, Phone, Email, BirthDate)
        {
            this.Wage = Wage;
            this.WorkingHours = WorkingHours;
        }

        //Overide phương thức Display từ Employee 
        public override void Display()
        {
            Console.WriteLine("Thông tin HourtyEmployee : \n- SSN: {0} - FirstName: {1} - LastName: {2} - Phone : {3} - Email : {5} - Birthday : {4} - Wage : {5} - WorkingHours : {6}", 
                   SSN, FirstName, LastName, Phone, Email, BirthDate, Wage, WorkingHours);
        }

        //Xây dựng phương thức ToString()
        public void ToString()
        {
        }
    }
}
