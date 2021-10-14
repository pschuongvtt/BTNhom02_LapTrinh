using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaiTapNhom2_Final.OOP
{
    public abstract class Employee : Payable
    {
        private string ssn;
        private string firstName;
        private string lastName;
        private string birthDate;
        private string phone;
        private string email;

        //Xây dựng Getter , Setter
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public string FirstName
        {
            get {return firstName;}
            set {firstName = value;}
        }
        public string LastName
        {
            get {return lastName;}
            set {lastName = value;}
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (IsValidPhone(value) == true)
                    phone = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value) == true)
                    email = value;
            }
        }
        public string BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;//String.Format("{0:dd/MM/yyyy}", value);
            }
        }
        //Xây dựng hàm khởi tạo không có tham số 
        public Employee()
        {

        }

        //Xây dựng hàm khởi tạo có 3 tham số
        public Employee(string SSN, string FirstName, string LastName)
        {
            this.SSN = SSN;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        //Xây dựng hàm khởi tạo có 5 tham số
        public Employee(string SSN, string FirstName, string LastName, string Phone, string Email, string BirthDate)
        {
            this.SSN = SSN;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.BirthDate = BirthDate;
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

        //Xây dựng phương thức Display 
        public abstract void Display();

        //Override phương thức ToString từ Interface
        public new void ToString()
        {
            throw new NotImplementedException();
        }

        //Override phương thức từ Interface
        public double PaymentAmount()
        {
            throw new NotImplementedException();
        }

    }
}
