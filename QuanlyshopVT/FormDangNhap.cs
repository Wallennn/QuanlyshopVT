using System; // Sử dụng các kiểu dữ liệu và lớp hệ thống của .NET
using System.Windows.Forms; // Sử dụng thư viện các điều khiển giao diện Windows Forms

namespace QuanlyshopVT // Không gian tên chính của dự án Quản lý Shop Thời trang Việt Tiến
{
    // ══════════════════════════════════════════════════════════════════════════════
    //  FORM ĐĂNG NHẬP HỆ THỐNG SHOP VIETTIEN
    //  Tương tự LoginDialog.java trong dự án BAOCAO Java
    //  Hỗ trợ Visual Studio Designer chỉnh sửa thủ công
    //  Chú thích công dụng chi tiết của từng dòng mã nguồn
    // ══════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// FormDangNhap – Cửa sổ đăng nhập xác thực tài khoản nhân viên.
    /// Có thể chỉnh sửa thủ công dễ dàng trong Visual Studio Designer.
    /// </summary>
    public partial class FormDangNhap : Form // Kế thừa từ Form của Windows Forms
    {
        private AuthService authService; // Đối tượng xử lý nghiệp vụ xác thực đăng nhập

        /// <summary>Cờ xác nhận người dùng đã đăng nhập thành công hay chưa.</summary>
        public bool DaDangNhap { get; private set; } // Thuộc tính chỉ đọc từ bên ngoài

        /// <summary>
        /// Hàm khởi tạo của FormDangNhap.
        /// </summary>
        public FormDangNhap()
        {
            InitializeComponent(); // Khởi tạo các điều khiển từ file FormDangNhap.Designer.cs
            authService = new AuthService(); // Khởi tạo dịch vụ xác thực tài khoản
            DaDangNhap = false; // Mặc định ban đầu chưa đăng nhập thành công

            // Điền sẵn tài khoản quản lý mẫu để người dùng thuận tiện đăng nhập thử nghiệm
            txtTenDangNhap.Text = "admin"; // Điền sẵn tên đăng nhập quản trị
            txtMatKhau.Text = "123456"; // Điền sẵn mật khẩu mẫu
        }

        /// <summary>
        /// Xử lý sự kiện nhấn nút Đăng Nhập.
        /// Tương tự loginAction trong LoginDialog.java của dự án BAOCAO.
        /// </summary>
        private void btnDangNhapClick(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim(); // Lấy tên đăng nhập và cắt bỏ khoảng trắng hai đầu
            string matKhau = txtMatKhau.Text.Trim(); // Lấy mật khẩu và cắt bỏ khoảng trắng thừa

            NhanVien nv; // Biến nhận thông tin nhân viên trả về khi đăng nhập thành công
            string thongBaoLoi; // Biến nhận thông báo lỗi nếu đăng nhập thất bại
            bool ketQua = authService.dangNhap(tenDN, matKhau, out nv, out thongBaoLoi); // Gọi nghiệp vụ xác thực

            if (ketQua) // Nếu thông tin tài khoản và mật khẩu hoàn toàn chính xác
            {
                DaDangNhap = true; // Đánh dấu cờ đăng nhập thành công
                lblThongBao.Text = ""; // Xóa sạch thông báo lỗi cũ
                this.Close(); // Đóng form đăng nhập lại để chuyển vào Form1
            }
            else // Nếu thông tin tài khoản hoặc mật khẩu bị sai
            {
                lblThongBao.Text = thongBaoLoi; // Hiển thị nguyên nhân lỗi màu đỏ lên giao diện
                txtMatKhau.Focus(); // Đưa con trỏ nhấp nháy quay lại ô mật khẩu
                txtMatKhau.SelectAll(); // Bôi đen toàn bộ mật khẩu cũ để người dùng nhập lại nhanh
            }
        }

        /// <summary>
        /// Xử lý ẩn hiện mật khẩu khi tích vào ô CheckBox.
        /// </summary>
        private void chkHienMatKhauCheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked; // Bật hoặc tắt ký tự ẩn mật khẩu
        }

        /// <summary>
        /// Nút chọn nhanh tài khoản Quản lý để trải nghiệm tức thì.
        /// </summary>
        private void btnDemoAdminClick(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "admin"; // Điền tên đăng nhập quản lý
            txtMatKhau.Text = "123456"; // Điền mật khẩu
            lblThongBao.Text = ""; // Xóa thông báo lỗi
        }

        /// <summary>
        /// Nút chọn nhanh tài khoản Nhân viên bán hàng.
        /// </summary>
        private void btnDemoNhanVienClick(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "nhanvien1"; // Điền tên đăng nhập nhân viên
            txtMatKhau.Text = "123456"; // Điền mật khẩu
            lblThongBao.Text = ""; // Xóa thông báo lỗi
        }

        /// <summary>
        /// Nút chọn nhanh tài khoản Thủ kho.
        /// </summary>
        private void btnDemoThuKhoClick(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "thukho"; // Điền tên đăng nhập thủ kho
            txtMatKhau.Text = "123456"; // Điền mật khẩu
            lblThongBao.Text = ""; // Xóa thông báo lỗi
        }

        /// <summary>
        /// Xử lý nhấn phím Enter tại ô mật khẩu để kích hoạt đăng nhập nhanh không cần click chuột.
        /// </summary>
        private void txtMatKhauKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Kiểm tra nếu phím vừa gõ là Enter
            {
                btnDangNhapClick(sender, EventArgs.Empty); // Tự động gọi hàm xử lý nút Đăng Nhập
            }
        }

        /// <summary>
        /// Xử lý sự kiện nhấn nút Thoát để hủy phiên làm việc.
        /// </summary>
        private void btnThoatClick(object sender, EventArgs e)
        {
            DaDangNhap = false; // Đánh dấu chưa đăng nhập
            this.Close(); // Đóng form đăng nhập để chương trình kết thúc an toàn
        }
    }
}
