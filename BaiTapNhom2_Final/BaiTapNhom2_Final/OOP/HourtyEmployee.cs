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

        //Overide phương thức Display từ Employee
        public override void Display()
        {
            
        }
    }
}
