using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom2_Final.OOP
{
    public class Invoice : Payable
    {
        private string partNumber;
        private string partDescription;
        private int quantity;
        private double pricePerItemc;

        //Override phương thức từ Interface
        public double PaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
