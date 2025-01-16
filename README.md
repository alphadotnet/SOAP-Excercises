# WorldClient: SOAP Service Client Application

## Giới thiệu
WorldClient là một ứng dụng Windows Forms được thiết kế để kết nối và tương tác với dịch vụ SOAP (WorldService). Dịch vụ SOAP cung cấp các chức năng để truy vấn thông tin quốc gia và thành phố từ cơ sở dữ liệu.

## Giao diện chính
![Image](https://github.com/user-attachments/assets/fde2ce61-0631-4f65-8a8b-4d234da193b8)
![Image](https://github.com/user-attachments/assets/3453daf8-8699-4b63-97ab-247e60b527ea)

## Các tính năng chính
Ứng dụng hỗ trợ các chức năng chính sau:

1. **Hiển thị danh sách quốc gia**:
   - Người dùng có thể nhấn vào nút **Get All Countries** để lấy danh sách tất cả các quốc gia từ dịch vụ.
   - Dữ liệu quốc gia (Code và Name) sẽ được hiển thị trong một `DataGridView`.
   - ![Image](https://github.com/user-attachments/assets/0d626f8d-4093-470e-ad0e-661a31c063ab)
   - ![Image](https://github.com/user-attachments/assets/a5b20ce0-a62c-40f8-acfe-b6d8f34c48b8)

2. **Tra cứu quốc gia theo mã**:
   - Người dùng nhập mã quốc gia (Country Code) và nhấn nút **Get Country By Code**.
   - Thông tin quốc gia, bao gồm mã (Code) và tên (Name), sẽ được hiển thị.
   - ![Image](https://github.com/user-attachments/assets/903090dc-8c19-4348-9cb4-3bdb0b32b6b3)
   - ![Image](https://github.com/user-attachments/assets/fdacd64d-8daa-4663-9b66-76be4f2484da)

3. **Tra cứu thành phố theo tên**:
   - Người dùng nhập tên thành phố và nhấn nút **Get City By Name**.
   - Kết quả hiển thị thông tin chi tiết của thành phố bao gồm ID, Name, CountryCode, District trong một `DataGridView`.
   - ![Image](https://github.com/user-attachments/assets/aef0cb85-9581-4dd1-bfa6-5f5f5212fff5)
   - ![Image](https://github.com/user-attachments/assets/110e74f3-167e-48dd-a25c-64d4e27dda20)

4. **Tra cứu danh sách thành phố theo mã quốc gia**:
   - Người dùng nhập mã quốc gia và nhấn nút **Get Cities By Country Code**.
   - Ứng dụng hiển thị danh sách các thành phố thuộc quốc gia đó (bao gồm ID, Name, CountryCode, District) trong một `DataGridView`.
   - ![Image](https://github.com/user-attachments/assets/8d41a52c-5050-4d48-a3d8-762c2754fba3)
   - ![Image](https://github.com/user-attachments/assets/593872fb-5b18-44bc-b3cb-c2109d40920b)

## Công nghệ sử dụng
- **Windows Forms (C#)**: Giao diện người dùng.
- **SOAP (Simple Object Access Protocol)**: Giao tiếp với dịch vụ web.
- **DataGridView**: Hiển thị thông tin quốc gia và thành phố.
- **.NET Framework**: Xây dựng và chạy ứng dụng.

## Hướng dẫn sử dụng
1. **Khởi chạy ứng dụng WorldClient**.
2. Sử dụng các nút trên giao diện:
   - **Get All Countries**: Hiển thị tất cả quốc gia.
   - **Get Country By Code**: Nhập mã quốc gia để tra cứu.
   - **Get City By Name**: Nhập tên thành phố để tìm kiếm.
   - **Get Cities By Country Code**: Nhập mã quốc gia để lấy danh sách các thành phố.
