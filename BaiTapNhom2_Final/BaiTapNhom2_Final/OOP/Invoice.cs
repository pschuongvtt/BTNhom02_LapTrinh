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

        //Xây dựng getter, setter
        public string PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }
        public string PartDescription
        {
            get { return partDescription; }
            set { partDescription = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double PricePerItemc
        {
            get { return pricePerItemc; }
            set { pricePerItemc = value; }
        }

        //Override phương thức từ Interface
        public double PaymentAmount()
        {
            throw new NotImplementedException();
        }
       
        //Ovveride ToString từ Interface
        public new void ToString()
        {
            throw new NotImplementedException();
        }

        //Xây dựng hàm khởi tạo 
        public Invoice()
        {

        }
    }
}
