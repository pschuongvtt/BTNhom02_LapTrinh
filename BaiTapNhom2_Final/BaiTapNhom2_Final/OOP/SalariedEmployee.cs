using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom2_Final.OOP
{
    public class SalariedEmployee : Employee
    {
        private double commissionRate;
        private double grossSales;
        private double basicSalary;

        //Thiết lập getter, setter 
        public double CommissionRate
        {
            get {return commissionRate;}
            set {commissionRate = value;}
        }

        public double GrossSales
        {
            get {return grossSales;}
            set {grossSales = value;}
        }

        public double BasicSalary
        {
            get {return basicSalary;}
            set { basicSalary = value;}
        }

        //Xây dựng hàm khởi tạo 9 tham số 
        public SalariedEmployee(double CommissionRate, double GrossSales, double BasicSalary, string SSN, string FirstName, string LastName, string Phone, string Email, string BirthDate)
            : base(SSN, FirstName, LastName, Phone, Email, BirthDate)
        {
            this.CommissionRate = CommissionRate;
            this.GrossSales = GrossSales;
            this.BasicSalary = BasicSalary;
        }

        //Overide phương thức Display từ Employee 
        public override void Display()
        {
            Console.WriteLine("Thông tin SalariedEmployee: \n- SSN: {0} - FirstName: {1} - LastName: {2} - Phone : {3} - Email : {4} - Birthday : {5} - CommissionRate : {6} - GrossSales : {7}, BasicSalary: {8}",
                    SSN, FirstName, LastName, Phone, Email, BirthDate, CommissionRate, GrossSales, BasicSalary);
        }

        //Xây dựng phương thức ToString()
        public void ToString()
        {
        }
    }
}
