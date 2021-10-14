# BTNhom02_LapTrinh
-- Thành viên : 
1.Trần Trung Kiên 
2.Vũ Thị Thu Hương 
3.Mai Thị Thúy Kiều 
4.Nguyễn Văn Học

----------------Nội dung thông tin bài tập-----------------
- Mô tả dự án : 
a. Xây dựng thông tin sơ đồ các lớp và quan hệ bao gồm : 
+ Invoice
+ Payable 
+ Employee
+ SalariedEmployee
+ HourlyEmployee
+ Deparment 
b. Đặc tả : 
+ Employee là 1 lớp trừu tượng có 6 trường : SSN, FirstName, LastName, BirthDate, Phone, Email
+ SalariedEmployee là nhân viên được trả lương theo tháng.
+ HourlyEmployee là nhân viên được trả lương theo giờ 
+ Deparment : Mỗi phòng ban sẽ có 1 danh sách nhân viên bao gồm SalariedEmployee và HourlyEmployee
+ Lưu ý rằng mỗi lớp trừu tượng và lớp khác có 1 phương thức khởi tạo và các phương thức khác để lấy và các trường của nó (getter, setter) và 1 phương thức ToString()
c. Yêu cầu: 
+ Lớp DepartmentManage : Có phương thức Main sử dụng lớp nhân viên và lớp con của nó cho phép chọn các chức năng sau 
1. Nhập dữ liệu từ bàn phím
2. Hiển thị nhân viên
3. Tìm kiếm nhân vien
4. Thông kê
