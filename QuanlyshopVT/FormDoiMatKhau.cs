using System; // Thư viện các kiểu dữ liệu cơ bản của .NET Framework
using System.Windows.Forms; // Thư viện giao diện người dùng Windows Forms

namespace QuanlyshopVT // Không gian tên dự án Quản lý Shop Thời trang Việt Tiến
{
    // ══════════════════════════════════════════════════════════════════════════════
    //  FORM ĐỔI MẬT KHẨU TÀI KHOẢN ĐANG ĐĂNG NHẬP
    //  Bảo mật tài khoản thu ngân, bán hàng và quản trị viên
    //  Hỗ trợ Visual Studio Designer chỉnh sửa thủ công
    //  Toàn bộ mã nguồn có chú thích chi tiết công dụng của từng dòng lệnh
    // ══════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// FormDoiMatKhau – Cửa sổ cho phép nhân viên đổi mật khẩu đăng nhập cá nhân.
    /// Có thể chỉnh sửa giao diện thủ công trong Visual Studio Designer.
    /// </summary>
    public partial class FormDoiMatKhau : Form // Kế thừa từ Form của Windows Forms
    {
        private NhanVien nhanVienHienTai; // Biến lưu tài khoản nhân viên đang thao tác đổi mật khẩu

        /// <summary>
        /// Hàm khởi tạo mặc định cho Visual Studio Designer.
        /// </summary>
        public FormDoiMatKhau()
        {
            InitializeComponent(); // Khởi tạo các thành phần giao diện từ Designer
            nhanVienHienTai = KhoDuLieu.NguoiDangNhapHienTai; // Lấy nhân viên từ phiên đăng nhập hiện tại
            if (nhanVienHienTai != null) // Nếu có thông tin tài khoản hợp lệ
            {
                lblTenTaiKhoan.Text = nhanVienHienTai.TenDangNhap + " (" + nhanVienHienTai.HoTen + ")"; // Hiển thị tên
            }
            else // Nếu chưa đăng nhập
            {
                lblTenTaiKhoan.Text = "Chưa xác định"; // Hiển thị mặc định
            }
        }

        /// <summary>
        /// Sự kiện bật hoặc tắt ẩn hiện mật khẩu trên các ô nhập liệu.
        /// </summary>
        private void chkHienMKCheckedChanged(object sender, EventArgs e)
        {
            bool an = !chkHienMK.Checked; // Kiểm tra cờ hiển thị
            txtMatKhauCu.UseSystemPasswordChar = an; // Ẩn hoặc hiện mật khẩu cũ
            txtMatKhauMoi.UseSystemPasswordChar = an; // Ẩn hoặc hiện mật khẩu mới
            txtXacNhan.UseSystemPasswordChar = an; // Ẩn hoặc hiện mật khẩu xác nhận
        }

        /// <summary>
        /// Xử lý sự kiện nhấn nút CẬP NHẬT mật khẩu.
        /// </summary>
        private void btnXacNhanClick(object sender, EventArgs e)
        {
            string mkCu = txtMatKhauCu.Text.Trim(); // Lấy mật khẩu cũ đã nhập
            string mkMoi = txtMatKhauMoi.Text.Trim(); // Lấy mật khẩu mới
            string xacNhan = txtXacNhan.Text.Trim(); // Lấy mật khẩu xác nhận lại

            if (nhanVienHienTai == null) // Kiểm tra tài khoản
            {
                lblThongBao.Text = "Không xác định được phiên làm việc hiện tại."; // Báo lỗi
                return; // Dừng xử lý
            }

            if (string.IsNullOrEmpty(mkCu) || string.IsNullOrEmpty(mkMoi) || string.IsNullOrEmpty(xacNhan)) // Kiểm tra rỗng
            {
                lblThongBao.Text = "Vui lòng nhập đầy đủ các trường thông tin mật khẩu."; // Báo lỗi
                return; // Dừng xử lý
            }

            if (!nhanVienHienTai.MatKhau.Equals(mkCu)) // Kiểm tra mật khẩu cũ có đúng không
            {
                lblThongBao.Text = "Mật khẩu cũ không chính xác!"; // Báo sai mật khẩu
                txtMatKhauCu.Focus(); // Đưa con trỏ vào ô mật khẩu cũ
                txtMatKhauCu.SelectAll(); // Bôi đen để gõ lại
                return; // Dừng xử lý
            }

            if (mkMoi.Length < 6) // Kiểm tra độ dài mật khẩu mới tối thiểu 6 ký tự
            {
                lblThongBao.Text = "Mật khẩu mới phải có độ dài từ 6 ký tự trở lên."; // Cảnh báo bảo mật
                txtMatKhauMoi.Focus(); // Đưa con trỏ vào ô mật khẩu mới
                return; // Dừng xử lý
            }

            if (!mkMoi.Equals(xacNhan)) // Kiểm tra mật khẩu mới và xác nhận có trùng khớp nhau không
            {
                lblThongBao.Text = "Xác nhận mật khẩu mới không trùng khớp!"; // Báo không khớp
                txtXacNhan.Focus(); // Đưa con trỏ vào ô xác nhận
                txtXacNhan.SelectAll(); // Bôi đen
                return; // Dừng xử lý
            }

            nhanVienHienTai.MatKhau = mkMoi; // Cập nhật mật khẩu mới cho tài khoản nhân viên
            MessageBox.Show(
                "Đổi mật khẩu thành công!\nVui lòng ghi nhớ mật khẩu mới cho lần đăng nhập sau.",
                "Thông Báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information); // Thông báo thành công
            this.Close(); // Đóng cửa sổ đổi mật khẩu
        }

        /// <summary>
        /// Đóng cửa sổ đổi mật khẩu mà không thực hiện thay đổi.
        /// </summary>
        private void btnDongClick(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }
    }
}

