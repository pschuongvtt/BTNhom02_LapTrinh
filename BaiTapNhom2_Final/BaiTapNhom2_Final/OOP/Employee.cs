using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaiTapNhom2_Final.OOP
{
    public abstract class Employee
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

        //Xây dựng hàm khởi tạo không có tham số 
        public Employee()
        {

        }

        //Xây dựng hàm khởi tạo có tham số
        public Employee(string SSN, string FirstName, string LastName)
        {
            this.SSN = SSN;
            this.FirstName = FirstName;
            this.LastName = LastName;
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

        //Xây dựng hàm xuất thông tin ra màn hình 
        public abstract void Display();
    }
}
