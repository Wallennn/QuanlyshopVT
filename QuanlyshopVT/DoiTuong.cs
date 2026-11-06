using System; // Sử dụng các kiểu dữ liệu cơ bản của .NET Framework như int, string, decimal, DateTime

namespace QuanlyshopVT // Không gian tên của dự án Quản lý Shop Thời trang Việt Tiến
{
    // ══════════════════════════════════════════════════════════════════════════════
    //  CÁC LỚP ĐỐI TƯỢNG THỰC THỂ (ENTITIES) – QUẢN LÝ SHOP THỜI TRANG VIETTIEN
    //  Tương tự package quanlynhathuoc.doituong trong dự án BAOCAO Java
    //  Chú thích công dụng chi tiết của từng dòng mã nguồn
    // ══════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// Đối tượng Sản Phẩm thời trang Việt Tiến (tương tự lớp Thuoc.java trong BAOCAO).
    /// Đại diện cho các mặt hàng áo sơ mi, quần tây, vest, phụ kiện may mặc.
    /// </summary>
    public class SanPham
    {
        public int MaSP { get; set; } // Khóa chính: Mã định danh ID sản phẩm tự tăng
        public string MaHang { get; set; } // Mã hàng hiển thị theo quy ước thương hiệu (VD: VT001)
        public string TenSP { get; set; } // Tên đầy đủ của sản phẩm thời trang
        public string LoaiSP { get; set; } // Phân loại sản phẩm: Áo sơ mi, Quần tây, Vest, Phụ kiện...
        public string Size { get; set; } // Kích cỡ sản phẩm: S, M, L, XL, XXL, 29, 30, 31, 32...
        public string MauSacSP { get; set; } // Màu sắc vải may: Trắng, Xanh Navy, Đen, Xám...
        public string ChatLieu { get; set; } // Thành phần chất liệu vải: Cotton 100%, Kaki, Wool, Lụa...
        public decimal GiaNhap { get; set; } // Đơn giá nhập hàng từ nhà máy may mặc (đồng)
        public decimal GiaBan { get; set; } // Đơn giá bán lẻ niêm yết cho khách hàng (đồng)
        public int SoLuongTon { get; set; } // Số lượng sản phẩm hiện còn tồn trữ trong kho
        public string TrangThai { get; set; } // Trạng thái kinh doanh: Đang bán hoặc Ngừng bán

        /// <summary>
        /// Hàm khởi tạo của đối tượng Sản Phẩm.
        /// </summary>
        public SanPham()
        {
            TrangThai = "Đang bán"; // Mặc định sản phẩm mới tạo có trạng thái là Đang bán
        }
    }

    /// <summary>
    /// Đối tượng Khách Hàng mua sắm thời trang (tương tự KhachHang.java trong BAOCAO).
    /// </summary>
    public class KhachHang
    {
        public int MaKH { get; set; } // Khóa chính: Mã ID khách hàng tự tăng
        public string MaKhachHang { get; set; } // Mã định danh khách hàng (VD: KH001)
        public string HoTen { get; set; } // Họ và tên đầy đủ của khách hàng
        public string SoDienThoai { get; set; } // Số điện thoại liên hệ của khách hàng
        public string Email { get; set; } // Địa chỉ thư điện tử của khách hàng
        public string DiaChi { get; set; } // Địa chỉ liên hệ hoặc nơi cư trú của khách hàng
        public int DiemTichLuy { get; set; } // Điểm tích lũy thành viên dùng để đổi ưu đãi, giảm giá
        public string LoaiKhach { get; set; } // Phân hạng khách hàng: Thường, Thành viên, VIP

        /// <summary>
        /// Hàm khởi tạo của đối tượng Khách Hàng.
        /// </summary>
        public KhachHang()
        {
            LoaiKhach = "Thường"; // Mặc định ban đầu là khách hàng Thường
            DiemTichLuy = 0; // Mặc định điểm tích lũy ban đầu là 0 điểm
        }
    }

    /// <summary>
    /// Đối tượng Nhà Cung Cấp vải sợi, phụ liệu may mặc (tương tự NhaCungCap.java trong BAOCAO).
    /// </summary>
    public class NhaCungCap
    {
        public int MaNCC { get; set; } // Khóa chính: Mã ID nhà cung cấp tự tăng
        public string MaNhaCungCap { get; set; } // Mã đối tác nhà cung cấp (VD: NCC001)
        public string TenNCC { get; set; } // Tên đầy đủ của công ty hoặc xưởng dệt may
        public string DienThoai { get; set; } // Số điện thoại liên hệ của nhà cung cấp
        public string Email { get; set; } // Hòm thư điện tử liên hệ giao dịch
        public string DiaChi { get; set; } // Địa chỉ trụ sở công ty hoặc kho nhà máy
        public string MaSoThue { get; set; } // Mã số thuế doanh nghiệp
        public string NguoiDaiDien { get; set; } // Họ tên người đại diện pháp luật hoặc liên hệ kinh doanh
        public string TrangThai { get; set; } // Tình trạng hợp tác: Đang hợp tác hoặc Tạm ngừng

        /// <summary>
        /// Hàm khởi tạo của đối tượng Nhà Cung Cấp.
        /// </summary>
        public NhaCungCap()
        {
            TrangThai = "Đang hợp tác"; // Mặc định là Đang hợp tác
        }
    }

    /// <summary>
    /// Đối tượng Nhân Viên kiêm Tài Khoản đăng nhập (tương tự NhanVien.java trong BAOCAO).
    /// </summary>
    public class NhanVien
    {
        public int MaNV { get; set; } // Khóa chính: Mã ID nhân viên tự tăng
        public string MaNhanVien { get; set; } // Mã số nhân viên nội bộ (VD: NV001)
        public string HoTen { get; set; } // Họ và tên đầy đủ của nhân viên
        public string TenDangNhap { get; set; } // Tên tài khoản dùng để đăng nhập vào phần mềm
        public string MatKhau { get; set; } // Mật khẩu bảo mật của tài khoản
        public string ChucVu { get; set; } // Vị trí làm việc: Quản lý, Nhân viên bán hàng, Thủ kho, Thu ngân
        public string SoDienThoai { get; set; } // Số điện thoại liên hệ của nhân viên
        public string Email { get; set; } // Hòm thư điện tử của nhân viên
        public string TrangThai { get; set; } // Tình trạng tài khoản: Đang làm việc hoặc Đã khóa

        /// <summary>
        /// Hàm khởi tạo của đối tượng Nhân Viên.
        /// </summary>
        public NhanVien()
        {
            ChucVu = "Nhân viên bán hàng"; // Mặc định chức vụ ban đầu là Nhân viên bán hàng
            TrangThai = "Đang làm việc"; // Mặc định trạng thái là Đang làm việc
        }

        /// <summary>
        /// Kiểm tra xem nhân viên hiện tại có phải là Quản lý/Admin hay không.
        /// </summary>
        public bool LaQuanLy()
        {
            if (string.IsNullOrEmpty(ChucVu)) return false; // Nếu chưa gán chức vụ thì trả về false
            return ChucVu.Equals("Quản lý", StringComparison.OrdinalIgnoreCase) // Khớp chức vụ Quản lý
                || ChucVu.Equals("Admin", StringComparison.OrdinalIgnoreCase) // Khớp chức vụ Admin
                || ChucVu.Equals("Giám đốc", StringComparison.OrdinalIgnoreCase); // Khớp chức vụ Giám đốc
        }
    }

    /// <summary>
    /// Đối tượng Hóa Đơn bán lẻ hàng may mặc thời trang (tương tự HoaDon.java trong BAOCAO).
    /// </summary>
    public class HoaDon
    {
        public int MaHD { get; set; } // Khóa chính: Mã ID hóa đơn tự tăng
        public string MaHoaDon { get; set; } // Mã chứng từ hóa đơn theo chuẩn chuỗi (VD: HD20261031001)
        public DateTime NgayLap { get; set; } // Ngày giờ xuất hóa đơn bán hàng
        public int MaNV { get; set; } // Khóa ngoại: Mã nhân viên bán hàng lập hóa đơn
        public string TenNhanVien { get; set; } // Họ tên nhân viên lập hóa đơn
        public int MaKH { get; set; } // Khóa ngoại: Mã khách hàng mua hàng
        public string TenKhachHang { get; set; } // Tên khách hàng mua hàng
        public decimal TongTien { get; set; } // Tổng tiền hàng trước khi giảm giá (đồng)
        public decimal GiamGia { get; set; } // Số tiền chiết khấu hoặc giảm trừ điểm tích lũy (đồng)
        public decimal ThanhTien { get; set; } // Số tiền thực tế khách hàng phải trả (đồng)
        public string PhuongThucTT { get; set; } // Phương thức thanh toán: Tiền mặt, Chuyển khoản, Thẻ
        public string TrangThai { get; set; } // Trạng thái hóa đơn: Đã thanh toán hoặc Đã hủy

        /// <summary>
        /// Hàm khởi tạo của đối tượng Hóa Đơn.
        /// </summary>
        public HoaDon()
        {
            NgayLap = DateTime.Now; // Lấy thời gian lập là thời điểm hiện tại của máy tính
            PhuongThucTT = "Tiền mặt"; // Mặc định phương thức thanh toán là Tiền mặt
            TrangThai = "Đã thanh toán"; // Mặc định trạng thái là Đã thanh toán
        }
    }

    /// <summary>
    /// Đối tượng Chi Tiết Hóa Đơn từng mặt hàng bán ra (tương tự ChiTietHoaDon.java trong BAOCAO).
    /// </summary>
    public class ChiTietHoaDon
    {
        public int MaCTHD { get; set; } // Khóa chính: Mã ID dòng chi tiết tự tăng
        public int MaHD { get; set; } // Khóa ngoại: Liên kết đến mã hóa đơn tổng thể
        public int MaSP { get; set; } // Khóa ngoại: Liên kết đến mã sản phẩm đã bán
        public string TenSP { get; set; } // Lưu tên sản phẩm tại thời điểm xuất bán
        public int SoLuong { get; set; } // Số lượng sản phẩm bán ra trong dòng này
        public decimal DonGia { get; set; } // Đơn giá bán của sản phẩm tại thời điểm lập hóa đơn
        public decimal ThanhTien { get; set; } // Thành tiền của dòng chi tiết = SoLuong * DonGia
    }
}
