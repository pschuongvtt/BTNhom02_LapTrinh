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
                if (IsValidPhone(phone) == true)
                    phone = value;
                else
                    Console.WriteLine("Phone number không tồn tại. Phải có ít nhất 7 ký tự");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(email) == true)
                    email = value;
            }
        }
        public string BirthDate
        {
            get { return birthDate; }
            set
            {
                String.Format("{0:dd/MM/yyyy}", birthDate);
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

        //Hàm kiểm tra Số điện thoại có phải kiểu số 0 : 1 - True , 0 - False
        public bool IsValidPhone(string value)
        {
            string pattern = @"^-*[0-9,\.?\-?\(?\)?\ ]+$";
            return Regex.IsMatch(value, pattern);
        }

        //Xây dựng hàm kiểm tra có phải email không : 1 - True , 0 - False
        public bool IsValidEmail(string email)
        {
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            return rx.IsMatch(email);
        }

        //Xây dựng phương thức ToString -- Chính là phương thức Display 
        public abstract void Display();
        
        //Override phương thức từ Interface
        public double PaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
