using System; // Sử dụng các kiểu dữ liệu và lớp ngày giờ của .NET
using System.Collections.Generic; // Sử dụng lớp danh sách List<T> để lưu trữ tập hợp đối tượng trong bộ nhớ

namespace QuanlyshopVT // Không gian tên chính của dự án Quản lý Shop Thời trang Việt Tiến
{
    // ══════════════════════════════════════════════════════════════════════════════
    //  KHO DỮ LIỆU BỘ NHỚ (REPOSITORY / DATA STORAGE)
    //  Tương tự tầng DAO và cơ sở dữ liệu mẫu trong dự án BAOCAO Java
    //  Chú thích công dụng chi tiết của từng dòng mã nguồn
    // ══════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// KhoDuLieu – Lớp tĩnh lưu trữ toàn bộ dữ liệu trong bộ nhớ RAM cho ứng dụng.
    /// Hoạt động như một cơ sở dữ liệu nội bộ sẵn sàng chạy ngay mà không cần cài đặt SQL Server phức tạp.
    /// </summary>
    public static class KhoDuLieu
    {
        // ── Khai báo các danh sách lưu trữ thực thể trong bộ nhớ ─────────────────
        public static List<SanPham> DanhSachSanPham = new List<SanPham>(); // Danh sách chứa tất cả sản phẩm
        public static List<KhachHang> DanhSachKhachHang = new List<KhachHang>(); // Danh sách chứa tất cả khách hàng
        public static List<NhaCungCap> DanhSachNhaCungCap = new List<NhaCungCap>(); // Danh sách chứa tất cả nhà cung cấp
        public static List<NhanVien> DanhSachNhanVien = new List<NhanVien>(); // Danh sách chứa tất cả nhân viên
        public static List<HoaDon> DanhSachHoaDon = new List<HoaDon>(); // Danh sách chứa tất cả hóa đơn bán lẻ
        public static List<ChiTietHoaDon> DanhSachChiTietHoaDon = new List<ChiTietHoaDon>(); // Danh sách các dòng chi tiết hóa đơn

        // ── Biến lưu trữ phiên đăng nhập hiện tại ─────────────────────────────────
        public static NhanVien NguoiDangNhapHienTai = null; // Tài khoản nhân viên đang sử dụng phần mềm

        // ── Các biến đếm số nguyên dùng để tự tăng mã ID cho từng bảng ───────────
        private static int boDemSP = 1; // Bộ đếm sinh mã tự tăng cho sản phẩm
        private static int boDemKH = 1; // Bộ đếm sinh mã tự tăng cho khách hàng
        private static int boDemNCC = 1; // Bộ đếm sinh mã tự tăng cho nhà cung cấp
        private static int boDemNV = 1; // Bộ đếm sinh mã tự tăng cho nhân viên
        private static int boDemHD = 1; // Bộ đếm sinh mã tự tăng cho hóa đơn
        private static int boDemCTHD = 1; // Bộ đếm sinh mã tự tăng cho chi tiết hóa đơn

        /// <summary>
        /// Hàm khởi tạo tĩnh của lớp KhoDuLieu.
        /// Chạy tự động một lần duy nhất khi lớp được truy cập lần đầu.
        /// </summary>
        static KhoDuLieu()
        {
            NapDuLieuMau(); // Tự động nạp bộ dữ liệu mẫu vào danh sách
        }

        // ── Các hàm sinh mã tự tăng (Auto-increment) ──────────────────────────────
        public static int SinhMaSP() { return boDemSP++; } // Trả về mã ID hiện tại và tăng bộ đếm thêm 1
        public static int SinhMaKH() { return boDemKH++; } // Sinh mã ID khách hàng tiếp theo
        public static int SinhMaNCC() { return boDemNCC++; } // Sinh mã ID nhà cung cấp tiếp theo
        public static int SinhMaNV() { return boDemNV++; } // Sinh mã ID nhân viên tiếp theo
        public static int SinhMaHD() { return boDemHD++; } // Sinh mã ID hóa đơn tiếp theo
        public static int SinhMaCTHD() { return boDemCTHD++; } // Sinh mã ID chi tiết hóa đơn tiếp theo

        /// <summary>
        /// Nạp toàn bộ dữ liệu mẫu ban đầu cho các bảng.
        /// Tương tự file NapDataMau.java trong dự án BAOCAO Java.
        /// </summary>
        public static void NapDuLieuMau()
        {
            if (DanhSachSanPham.Count > 0) return; // Nếu đã có dữ liệu rồi thì bỏ qua không nạp lại

            // ── 1. Nạp danh sách tài khoản Nhân Viên mẫu ─────────────────────────
            DanhSachNhanVien.Add(new NhanVien // Thêm tài khoản Quản lý cấp cao
            {
                MaNV = SinhMaNV(), // Sinh mã tự tăng
                MaNhanVien = "NV001", // Mã nhân viên nội bộ
                HoTen = "Phạm Thái Lan", // Họ và tên
                TenDangNhap = "admin", // Tên đăng nhập
                MatKhau = "123456", // Mật khẩu đăng nhập
                ChucVu = "Quản lý", // Quyền hạn Quản lý
                SoDienThoai = "0988 123 456", // Điện thoại
                Email = "thailan@viettien.com.vn", // Email
                TrangThai = "Đang làm việc" // Trạng thái làm việc
            });

            DanhSachNhanVien.Add(new NhanVien // Thêm tài khoản Nhân viên bán hàng
            {
                MaNV = SinhMaNV(), // Sinh mã tự tăng
                MaNhanVien = "NV002", // Mã nhân viên nội bộ
                HoTen = "Trần Thị Mai", // Họ và tên
                TenDangNhap = "nhanvien1", // Tên đăng nhập
                MatKhau = "123456", // Mật khẩu đăng nhập
                ChucVu = "Nhân viên bán hàng", // Quyền hạn Nhân viên bán hàng
                SoDienThoai = "0912 345 678", // Điện thoại
                Email = "maitt@viettien.com.vn", // Email
                TrangThai = "Đang làm việc" // Trạng thái làm việc
            });

            DanhSachNhanVien.Add(new NhanVien // Thêm tài khoản Thủ kho
            {
                MaNV = SinhMaNV(), // Sinh mã tự tăng
                MaNhanVien = "NV003", // Mã nhân viên nội bộ
                HoTen = "Lê Hoàng Nam", // Họ và tên
                TenDangNhap = "thukho", // Tên đăng nhập
                MatKhau = "123456", // Mật khẩu đăng nhập
                ChucVu = "Thủ kho", // Quyền hạn Thủ kho
                SoDienThoai = "0903 555 888", // Điện thoại
                Email = "namlh@viettien.com.vn", // Email
                TrangThai = "Đang làm việc" // Trạng thái làm việc
            });

            // ── 2. Nạp danh sách Nhà Cung Cấp may mặc mẫu ────────────────────────
            DanhSachNhaCungCap.Add(new NhaCungCap // Thêm nhà cung cấp 1
            {
                MaNCC = SinhMaNCC(), // Sinh mã tự tăng
                MaNhaCungCap = "NCC001", // Mã đối tác
                TenNCC = "Tổng Công Ty CP May Việt Tiến", // Tên công ty
                DienThoai = "0283 864 0800", // Số điện thoại
                Email = "viettien@viettien.com.vn", // Hòm thư điện tử
                DiaChi = "7 Lê Minh Xuân, P.7, Q.Tân Bình, TP.HCM", // Trụ sở
                MaSoThue = "0300684868", // MST
                NguoiDaiDien = "Nguyễn Văn An", // Đại diện pháp luật
                TrangThai = "Đang hợp tác" // Trạng thái
            });

            DanhSachNhaCungCap.Add(new NhaCungCap // Thêm nhà cung cấp 2
            {
                MaNCC = SinhMaNCC(), // Sinh mã tự tăng
                MaNhaCungCap = "NCC002", // Mã đối tác
                TenNCC = "Xưởng Dệt Nhuộm Vải An Phú", // Tên xưởng
                DienThoai = "0901 234 567", // Số điện thoại
                Email = "anphutex@gmail.com", // Hòm thư điện tử
                DiaChi = "123 Nguyễn Trãi, Thanh Xuân, Hà Nội", // Trụ sở
                MaSoThue = "0103456789", // MST
                NguoiDaiDien = "Trần Thị Bình", // Đại diện
                TrangThai = "Đang hợp tác" // Trạng thái
            });

            DanhSachNhaCungCap.Add(new NhaCungCap // Thêm nhà cung cấp 3
            {
                MaNCC = SinhMaNCC(), // Sinh mã tự tăng
                MaNhaCungCap = "NCC003", // Mã đối tác
                TenNCC = "Công Ty Phụ Liệu May Dệt Kim Long", // Tên công ty
                DienThoai = "0283 777 9999", // Số điện thoại
                Email = "phulieukimlong@gmail.com", // Hòm thư điện tử
                DiaChi = "45 Bàu Cát, Q.Tân Bình, TP.HCM", // Trụ sở
                MaSoThue = "0311223344", // MST
                NguoiDaiDien = "Lê Trọng Nghĩa", // Đại diện
                TrangThai = "Đang hợp tác" // Trạng thái
            });

            // ── 3. Nạp danh sách Khách Hàng mẫu ──────────────────────────────────
            DanhSachKhachHang.Add(new KhachHang // Thêm khách hàng 1
            {
                MaKH = SinhMaKH(), // Sinh mã tự tăng
                MaKhachHang = "KH001", // Mã khách hàng
                HoTen = "Nguyễn Văn Hùng", // Họ và tên
                SoDienThoai = "0912 345 678", // Số điện thoại
                Email = "hungnv@gmail.com", // Email
                DiaChi = "12 Hai Bà Trưng, Hoàn Kiếm, Hà Nội", // Địa chỉ
                DiemTichLuy = 250, // Điểm thưởng
                LoaiKhach = "VIP" // Hạng VIP
            });

            DanhSachKhachHang.Add(new KhachHang // Thêm khách hàng 2
            {
                MaKH = SinhMaKH(), // Sinh mã tự tăng
                MaKhachHang = "KH002", // Mã khách hàng
                HoTen = "Trần Thị Thu Hương", // Họ và tên
                SoDienThoai = "0987 654 321", // Số điện thoại
                Email = "huongttt@yahoo.com", // Email
                DiaChi = "45 Nguyễn Đình Chiểu, Q.3, TP.HCM", // Địa chỉ
                DiemTichLuy = 120, // Điểm thưởng
                LoaiKhach = "Thành viên" // Hạng Thành viên
            });

            DanhSachKhachHang.Add(new KhachHang // Thêm khách hàng 3
            {
                MaKH = SinhMaKH(), // Sinh mã tự tăng
                MaKhachHang = "KH003", // Mã khách hàng
                HoTen = "Lê Tuấn Anh", // Họ và tên
                SoDienThoai = "0908 112 233", // Số điện thoại
                Email = "anhlt@gmail.com", // Email
                DiaChi = "78 Lê Lợi, TP.Đà Nẵng", // Địa chỉ
                DiemTichLuy = 50, // Điểm thưởng
                LoaiKhach = "Thường" // Hạng Thường
            });

            // ── 4. Nạp danh sách Sản Phẩm thời trang Việt Tiến mẫu ────────────────
            DanhSachSanPham.Add(new SanPham // Áo sơ mi nam trắng
            {
                MaSP = SinhMaSP(), // Sinh mã tự tăng
                MaHang = "VT001", // Mã hàng
                TenSP = "Áo Sơ Mi Nam Trắng Dài Tay", // Tên sản phẩm
                LoaiSP = "Áo sơ mi", // Loại
                Size = "M", // Kích cỡ
                MauSacSP = "Trắng", // Màu sắc
                ChatLieu = "Cotton 100%", // Chất liệu
                GiaNhap = 180000, // Giá nhập
                GiaBan = 350000, // Giá bán
                SoLuongTon = 50, // Tồn kho
                TrangThai = "Đang bán" // Trạng thái
            });

            DanhSachSanPham.Add(new SanPham // Áo sơ mi xanh navy
            {
                MaSP = SinhMaSP(), // Sinh mã tự tăng
                MaHang = "VT002", // Mã hàng
                TenSP = "Áo Sơ Mi Nam Xanh Navy", // Tên sản phẩm
                LoaiSP = "Áo sơ mi", // Loại
                Size = "L", // Kích cỡ
                MauSacSP = "Xanh Navy", // Màu sắc
                ChatLieu = "Cotton Polyester", // Chất liệu
                GiaNhap = 190000, // Giá nhập
                GiaBan = 370000, // Giá bán
                SoLuongTon = 35, // Tồn kho
                TrangThai = "Đang bán" // Trạng thái
            });

            DanhSachSanPham.Add(new SanPham // Quần tây nam đen
            {
                MaSP = SinhMaSP(), // Sinh mã tự tăng
                MaHang = "VT003", // Mã hàng
                TenSP = "Quần Tây Nam Đen Slim Fit", // Tên sản phẩm
                LoaiSP = "Quần tây", // Loại
                Size = "32", // Kích cỡ
                MauSacSP = "Đen", // Màu sắc
                ChatLieu = "Vải Kaki cao cấp", // Chất liệu
                GiaNhap = 250000, // Giá nhập
                GiaBan = 490000, // Giá bán
                SoLuongTon = 28, // Tồn kho
                TrangThai = "Đang bán" // Trạng thái
            });

            DanhSachSanPham.Add(new SanPham // Áo polo thể thao
            {
                MaSP = SinhMaSP(), // Sinh mã tự tăng
                MaHang = "VT004", // Mã hàng
                TenSP = "Áo Thun Polo Xanh Dương", // Tên sản phẩm
                LoaiSP = "Áo polo", // Loại
                Size = "XL", // Kích cỡ
                MauSacSP = "Xanh Dương", // Màu sắc
                ChatLieu = "CVC cá sấu", // Chất liệu
                GiaNhap = 150000, // Giá nhập
                GiaBan = 290000, // Giá bán
                SoLuongTon = 60, // Tồn kho
                TrangThai = "Đang bán" // Trạng thái
            });

            DanhSachSanPham.Add(new SanPham // Bộ vest cao cấp
            {
                MaSP = SinhMaSP(), // Sinh mã tự tăng
                MaHang = "VT005", // Mã hàng
                TenSP = "Bộ Vest Nam Công Sở Xám", // Tên sản phẩm
                LoaiSP = "Vest", // Loại
                Size = "48", // Kích cỡ
                MauSacSP = "Xám", // Màu sắc
                ChatLieu = "Wool pha Poly", // Chất liệu
                GiaNhap = 1200000, // Giá nhập
                GiaBan = 2500000, // Giá bán
                SoLuongTon = 12, // Tồn kho
                TrangThai = "Đang bán" // Trạng thái
            });

            DanhSachSanPham.Add(new SanPham // Cà vạt phụ kiện
            {
                MaSP = SinhMaSP(), // Sinh mã tự tăng
                MaHang = "VT006", // Mã hàng
                TenSP = "Cà Vạt Lụa Đỏ Đô Họa Tiết", // Tên sản phẩm
                LoaiSP = "Phụ kiện", // Loại
                Size = "Freesize", // Kích cỡ
                MauSacSP = "Đỏ đô", // Màu sắc
                ChatLieu = "Lụa tơ tằm", // Chất liệu
                GiaNhap = 80000, // Giá nhập
                GiaBan = 180000, // Giá bán
                SoLuongTon = 80, // Tồn kho
                TrangThai = "Đang bán" // Trạng thái
            });

            DanhSachSanPham.Add(new SanPham // Áo sơ mi Bamboo sợi tre
            {
                MaSP = SinhMaSP(), // Sinh mã tự tăng
                MaHang = "VT007", // Mã hàng
                TenSP = "Áo Sơ Mi Nam Bamboo Xanh Mint", // Tên sản phẩm
                LoaiSP = "Áo sơ mi", // Loại
                Size = "40", // Kích cỡ
                MauSacSP = "Xanh Mint", // Màu sắc
                ChatLieu = "Vải sợi tre kháng khuẩn", // Chất liệu
                GiaNhap = 220000, // Giá nhập
                GiaBan = 420000, // Giá bán
                SoLuongTon = 45, // Tồn kho
                TrangThai = "Đang bán" // Trạng thái
            });

            DanhSachSanPham.Add(new SanPham // Quần Kaki co giãn
            {
                MaSP = SinhMaSP(), // Sinh mã tự tăng
                MaHang = "VT008", // Mã hàng
                TenSP = "Quần Kaki Casual Co Giãn Màu Be", // Tên sản phẩm
                LoaiSP = "Quần kaki", // Loại
                Size = "31", // Kích cỡ
                MauSacSP = "Màu Be", // Màu sắc
                ChatLieu = "Kaki thun cao cấp", // Chất liệu
                GiaNhap = 230000, // Giá nhập
                GiaBan = 450000, // Giá bán
                SoLuongTon = 25, // Tồn kho
                TrangThai = "Đang bán" // Trạng thái
            });

            DanhSachSanPham.Add(new SanPham // Dây lưng da bò
            {
                MaSP = SinhMaSP(), // Sinh mã tự tăng
                MaHang = "VT009", // Mã hàng
                TenSP = "Dây Lưng Nam Khóa Tự Động Cao Cấp", // Tên sản phẩm
                LoaiSP = "Phụ kiện", // Loại
                Size = "Freesize", // Kích cỡ
                MauSacSP = "Đen bóng", // Màu sắc
                ChatLieu = "Da bò nguyên tấm", // Chất liệu
                GiaNhap = 160000, // Giá nhập
                GiaBan = 320000, // Giá bán
                SoLuongTon = 35, // Tồn kho
                TrangThai = "Đang bán" // Trạng thái
            });

            DanhSachSanPham.Add(new SanPham // Áo blazer nam linen
            {
                MaSP = SinhMaSP(), // Sinh mã tự tăng
                MaHang = "VT010", // Mã hàng
                TenSP = "Áo Blazer Nam Linen Cổ Điển", // Tên sản phẩm
                LoaiSP = "Vest", // Loại
                Size = "46", // Kích cỡ
                MauSacSP = "Xanh rêu", // Màu sắc
                ChatLieu = "Vải Linen tự nhiên", // Chất liệu
                GiaNhap = 850000, // Giá nhập
                GiaBan = 1800000, // Giá bán
                SoLuongTon = 8, // Tồn kho thấp báo động
                TrangThai = "Đang bán" // Trạng thái
            });

            // ── 5. Nạp danh sách Hóa Đơn và Chi Tiết mẫu ──────────────────────────
            HoaDon hd1 = new HoaDon // Tạo hóa đơn mẫu đầu tiên
            {
                MaHD = SinhMaHD(), // Sinh mã tự tăng
                MaHoaDon = "HD20261028001", // Mã chứng từ hóa đơn
                NgayLap = DateTime.Now.AddDays(-2), // Lập cách đây 2 ngày
                MaNV = 1, // Mã nhân viên thu ngân
                TenNhanVien = "Phạm Thái Lan", // Tên nhân viên
                MaKH = 1, // Mã khách hàng
                TenKhachHang = "Nguyễn Văn Hùng", // Tên khách hàng
                TongTien = 840000, // Tổng tiền hàng
                GiamGia = 40000, // Số tiền giảm
                ThanhTien = 800000, // Thực thu
                PhuongThucTT = "Tiền mặt", // Phương thức thanh toán
                TrangThai = "Đã thanh toán" // Tình trạng
            };
            DanhSachHoaDon.Add(hd1); // Thêm hóa đơn vào danh sách

            DanhSachChiTietHoaDon.Add(new ChiTietHoaDon // Chi tiết sản phẩm thứ nhất trong hóa đơn
            {
                MaCTHD = SinhMaCTHD(), // Sinh mã tự tăng
                MaHD = hd1.MaHD, // Khóa ngoại liên kết hóa đơn
                MaSP = 1, // Mã sản phẩm
                TenSP = "Áo Sơ Mi Nam Trắng Dài Tay", // Tên sản phẩm
                SoLuong = 1, // Số lượng
                DonGia = 350000, // Đơn giá
                ThanhTien = 350000 // Thành tiền
            });

            DanhSachChiTietHoaDon.Add(new ChiTietHoaDon // Chi tiết sản phẩm thứ hai trong hóa đơn
            {
                MaCTHD = SinhMaCTHD(), // Sinh mã tự tăng
                MaHD = hd1.MaHD, // Khóa ngoại liên kết hóa đơn
                MaSP = 3, // Mã sản phẩm
                TenSP = "Quần Tây Nam Đen Slim Fit", // Tên sản phẩm
                SoLuong = 1, // Số lượng
                DonGia = 490000, // Đơn giá
                ThanhTien = 490000 // Thành tiền
            });

            HoaDon hd2 = new HoaDon // Tạo hóa đơn mẫu thứ hai phát sinh hôm nay
            {
                MaHD = SinhMaHD(), // Sinh mã tự tăng
                MaHoaDon = "HD20261030002", // Mã hóa đơn
                NgayLap = DateTime.Now, // Ngày giờ hiện tại hôm nay
                MaNV = 2, // Mã nhân viên Mai
                TenNhanVien = "Trần Thị Mai", // Tên nhân viên bán hàng
                MaKH = 2, // Khách hàng Hương
                TenKhachHang = "Trần Thị Thu Hương", // Tên khách hàng
                TongTien = 740000, // Tổng tiền
                GiamGia = 20000, // Giảm giá hội viên
                ThanhTien = 720000, // Thực thu
                PhuongThucTT = "Tiền mặt", // Phương thức thanh toán
                TrangThai = "Đã thanh toán" // Tình trạng
            };
            DanhSachHoaDon.Add(hd2); // Thêm vào danh sách

            DanhSachChiTietHoaDon.Add(new ChiTietHoaDon // Mặt hàng 1 hóa đơn 2
            {
                MaCTHD = SinhMaCTHD(), // Sinh mã
                MaHD = hd2.MaHD, // Mã hóa đơn
                MaSP = 7, // Áo sơ mi Bamboo
                TenSP = "Áo Sơ Mi Nam Bamboo Xanh Mint", // Tên
                SoLuong = 1, // Số lượng 1
                DonGia = 420000, // Đơn giá
                ThanhTien = 420000 // Thành tiền
            });

            DanhSachChiTietHoaDon.Add(new ChiTietHoaDon // Mặt hàng 2 hóa đơn 2
            {
                MaCTHD = SinhMaCTHD(), // Sinh mã
                MaHD = hd2.MaHD, // Mã hóa đơn
                MaSP = 9, // Dây lưng
                TenSP = "Dây Lưng Nam Khóa Tự Động Cao Cấp", // Tên
                SoLuong = 1, // Số lượng 1
                DonGia = 320000, // Đơn giá
                ThanhTien = 320000 // Thành tiền
            });

            HoaDon hd3 = new HoaDon // Tạo hóa đơn mẫu thứ ba cách đây 1 ngày
            {
                MaHD = SinhMaHD(), // Sinh mã tự tăng
                MaHoaDon = "HD20261029003", // Mã hóa đơn
                NgayLap = DateTime.Now.AddDays(-1), // Cách đây 1 ngày
                MaNV = 2, // Thu ngân Mai
                TenNhanVien = "Trần Thị Mai", // Tên thu ngân
                MaKH = 3, // Khách hàng Tuấn Anh
                TenKhachHang = "Lê Tuấn Anh", // Tên khách hàng
                TongTien = 2680000, // Tổng tiền bộ vest và cà vạt
                GiamGia = 80000, // Chiết khấu
                ThanhTien = 2600000, // Thực thu
                PhuongThucTT = "Chuyển khoản", // Chuyển khoản ngân hàng
                TrangThai = "Đã thanh toán" // Tình trạng
            };
            DanhSachHoaDon.Add(hd3); // Thêm vào danh sách

            DanhSachChiTietHoaDon.Add(new ChiTietHoaDon // Bộ vest xám
            {
                MaCTHD = SinhMaCTHD(), // Sinh mã
                MaHD = hd3.MaHD, // Mã hóa đơn
                MaSP = 5, // Bộ vest
                TenSP = "Bộ Vest Nam Công Sở Xám", // Tên
                SoLuong = 1, // Số lượng
                DonGia = 2500000, // Đơn giá
                ThanhTien = 2500000 // Thành tiền
            });

            DanhSachChiTietHoaDon.Add(new ChiTietHoaDon // Cà vạt lụa
            {
                MaCTHD = SinhMaCTHD(), // Sinh mã
                MaHD = hd3.MaHD, // Mã hóa đơn
                MaSP = 6, // Cà vạt
                TenSP = "Cà Vạt Lụa Đỏ Đô Họa Tiết", // Tên
                SoLuong = 1, // Số lượng
                DonGia = 180000, // Đơn giá
                ThanhTien = 180000 // Thành tiền
            });

            HoaDon hd4 = new HoaDon // Tạo hóa đơn mẫu thứ tư cách đây 4 ngày
            {
                MaHD = SinhMaHD(), // Sinh mã tự tăng
                MaHoaDon = "HD20261026004", // Mã hóa đơn
                NgayLap = DateTime.Now.AddDays(-4), // Cách đây 4 ngày
                MaNV = 1, // Quản lý Lan
                TenNhanVien = "Phạm Thái Lan", // Tên thu ngân
                MaKH = 1, // Khách hàng Hùng
                TenKhachHang = "Nguyễn Văn Hùng", // Tên khách hàng
                TongTien = 740000, // Tổng tiền
                GiamGia = 0, // Không giảm
                ThanhTien = 740000, // Thực thu
                PhuongThucTT = "Thẻ POS", // Quẹt thẻ POS
                TrangThai = "Đã thanh toán" // Tình trạng
            };
            DanhSachHoaDon.Add(hd4); // Thêm vào danh sách

            DanhSachChiTietHoaDon.Add(new ChiTietHoaDon // Áo polo
            {
                MaCTHD = SinhMaCTHD(), // Sinh mã
                MaHD = hd4.MaHD, // Mã hóa đơn
                MaSP = 4, // Áo polo
                TenSP = "Áo Thun Polo Xanh Dương", // Tên
                SoLuong = 1, // Số lượng
                DonGia = 290000, // Đơn giá
                ThanhTien = 290000 // Thành tiền
            });

            DanhSachChiTietHoaDon.Add(new ChiTietHoaDon // Quần Kaki
            {
                MaCTHD = SinhMaCTHD(), // Sinh mã
                MaHD = hd4.MaHD, // Mã hóa đơn
                MaSP = 8, // Quần Kaki
                TenSP = "Quần Kaki Casual Co Giãn Màu Be", // Tên
                SoLuong = 1, // Số lượng
                DonGia = 450000, // Đơn giá
                ThanhTien = 450000 // Thành tiền
            });
        }

        /// <summary>
        /// Khôi phục và đặt lại toàn bộ dữ liệu mẫu ban đầu của hệ thống.
        /// Giúp người dùng hoặc giảng viên dễ dàng làm mới trạng thái dữ liệu khi báo cáo đồ án.
        /// </summary>
        public static void DatLaiDuLieuGoc()
        {
            DanhSachSanPham.Clear(); // Xóa sạch danh sách sản phẩm
            DanhSachKhachHang.Clear(); // Xóa sạch danh sách khách hàng
            DanhSachNhaCungCap.Clear(); // Xóa sạch danh sách nhà cung cấp
            DanhSachNhanVien.Clear(); // Xóa sạch danh sách nhân viên
            DanhSachHoaDon.Clear(); // Xóa sạch danh sách hóa đơn
            DanhSachChiTietHoaDon.Clear(); // Xóa sạch chi tiết hóa đơn

            boDemSP = 1; // Đặt lại bộ đếm sản phẩm
            boDemKH = 1; // Đặt lại bộ đếm khách hàng
            boDemNCC = 1; // Đặt lại bộ đếm nhà cung cấp
            boDemNV = 1; // Đặt lại bộ đếm nhân viên
            boDemHD = 1; // Đặt lại bộ đếm hóa đơn
            boDemCTHD = 1; // Đặt lại bộ đếm chi tiết hóa đơn

            NapDuLieuMau(); // Nạp lại toàn bộ bộ dữ liệu mẫu phong phú
        }
    }
}
