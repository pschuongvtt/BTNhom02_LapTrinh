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


        //Overide phương thức Display từ Employee
        public override void Display()
        {
            Console.WriteLine("");
        }
    }
}
