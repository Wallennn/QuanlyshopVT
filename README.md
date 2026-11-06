# VIETTIEN FASHION SHOP - Hệ Thống Quản Lý Bán Lẻ Thời Trang

Hệ thống quản lý chuỗi cửa hàng bán lẻ thời trang Việt Tiến xây dựng trên nền tảng **C# Windows Forms (.NET Framework 4.0)**, tương thích Visual Studio 2010, 2019, 2022.

---

## 🌟 Tính Năng Nổi Bật

### 1. Phân Quyền Chuyên Biệt Theo Vai Trò (Role-Based Access Control)
* **👑 Quản lý (Admin)**: Toàn quyền quản trị 7 phân hệ, cấu hình nhân sự, giám sát doanh thu tổng thể, xem báo cáo tài chính toàn diện.
* **📦 Thủ kho**: Giao diện tập trung kho vận, quản lý nhập kho với phiếu nhập chi tiết (`FormNhapKho`), lọc cảnh báo hàng tồn thấp (<30 chiếc), quản lý nhà cung cấp, xuất kiểm kê kho.
* **👔 Thu ngân / Bán lẻ (POS)**: Tập trung vào lập hóa đơn bán lẻ, tích điểm khách hàng VIP, in hóa đơn thanh toán trực tiếp, tự động ẩn giá vốn để bảo mật kinh doanh.

### 2. Dashboard & KPI Thời Gian Thực
* Thẻ chỉ số trực quan: Doanh thu, Hóa đơn, Khách hàng, Giá trị vốn tồn kho, Cảnh báo tồn thấp.
* Tự động điều chỉnh các chỉ số thông minh theo vai trò của người đăng nhập.

### 3. Vẽ Biểu Đồ Thống Kê Thuần GDI+ Hiện Đại
* Biểu đồ hình cột (Column Chart): Thống kê doanh thu theo nhóm hàng, doanh số nhân viên, sản phẩm sắp hết hàng.
* Biểu đồ hình tròn khuyên (Donut Chart): Cơ cấu tỷ trọng danh mục hàng hóa, tỷ trọng doanh thu.
* Sử dụng bảng màu Pastel dịu mắt, chống chói lóa, khử răng cưa mượt mà.

### 4. Xuất Báo Cáo Excel Chuẩn Biểu Mẫu Doanh Nghiệp
* Báo cáo phân tích kết quả kinh doanh định dạng chuẩn tiếng Việt có dấu.
* Bảng kiểm kê tồn kho và định giá tài sản kho hàng.
* Đầy đủ tiêu ngữ, chữ ký 3 bên (Người lập, Thủ kho, Kế toán trưởng, Giám đốc) và hàm đọc tiền thành chữ tiếng Việt.

---

## 🔑 Tài Khoản Thử Nghiệm

| Chức Vụ | Tên Đăng Nhập | Mật Khẩu | Quyền Hạn |
|---|---|---|---|
| **Quản lý** | `admin` | `123` | Toàn quyền toàn bộ hệ thống |
| **Thủ kho** | `thukho` | `123` | Quản lý kho, nhập hàng, NCC |
| **Thu ngân** | `nhanvien1` | `123` | Bán lẻ POS, in hóa đơn, khách hàng |

---

## 🛠️ Công Nghệ Sử Dụng

* **Ngôn ngữ**: C#
* **Nền tảng**: .NET Framework 4.0 Client Profile
* **Giao diện**: Windows Forms (WinForms) với thiết kế Flat UI & bảng màu Slate Hiện Đại
* **Đồ họa**: GDI+ Double-Buffered Graphics
* **Định dạng dữ liệu**: In-Memory Collections, XML Spreadsheet Excel Export

---

## 🚀 Hướng Dẫn Cài Đặt & Chạy Dự Án

1. **Clone repository**:
   ```bash
   git clone https://github.com/TranThanhPhongCV/QuanlyshopVT.git
   ```
2. **Mở dự án**:
   - Nhấp đúp vào file `QuanlyshopVT.sln` trong Visual Studio (hỗ trợ VS 2010 / 2012 / 2015 / 2017 / 2019 / 2022).
3. **Build & Chạy**:
   - Nhấn **F5** hoặc chọn **Debug > Start Debugging** để khởi chạy ứng dụng.
