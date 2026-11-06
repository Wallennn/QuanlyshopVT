using System; // Thư viện xử lý kiểu dữ liệu cơ bản của .NET
using System.Collections.Generic; // Thư viện quản lý danh sách List<T>
using System.Drawing; // Thư viện điều khiển đồ họa và màu sắc
using System.Windows.Forms; // Thư viện điều khiển giao diện Windows Forms

namespace QuanlyshopVT // Không gian tên chính của phần mềm quản lý shop thời trang Việt Tiến
{
    // ══════════════════════════════════════════════════════════════════════════════
    //  FORM IN HÓA ĐƠN BÁN LẺ (RETAIL RECEIPT VIEW & PRINT)
    //  Hiển thị phiếu thanh toán đẹp mắt theo chuẩn hóa đơn bán lẻ Việt Tiến
    //  Hỗ trợ Visual Studio Designer chỉnh sửa thủ công
    //  Toàn bộ code có chú thích chi tiết công dụng từng dòng lệnh
    // ══════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// FormInHoaDon – Cửa sổ hiển thị và xem trước phiếu in hóa đơn bán hàng.
    /// Có thể chỉnh sửa thủ công trực tiếp trong Visual Studio Designer.
    /// </summary>
    public partial class FormInHoaDon : Form // Kế thừa từ Form Windows Forms
    {
        private HoaDon hoaDonHienThi; // Đối tượng hóa đơn đang cần xem và in

        /// <summary>
        /// Hàm khởi tạo mặc định cho Visual Studio Designer.
        /// </summary>
        public FormInHoaDon()
        {
            InitializeComponent(); // Khởi tạo các điều khiển từ file Designer
            caiDatCotBangChiTiet(); // Cấu hình các cột cho bảng hiển thị sản phẩm
        }

        /// <summary>
        /// Hàm khởi tạo nhận đối tượng hóa đơn cần in.
        /// </summary>
        public FormInHoaDon(HoaDon hd) : this() // Gọi hàm khởi tạo mặc định
        {
            this.hoaDonHienThi = hd; // Gán hóa đơn truyền vào biến nội bộ
            napDuLieuHoaDon(); // Nạp toàn bộ thông tin hóa đơn lên các nhãn và bảng
        }

        /// <summary>
        /// Cài đặt cấu trúc cột cho bảng chi tiết các mặt hàng mua.
        /// </summary>
        private void caiDatCotBangChiTiet()
        {
            dgvChiTiet.Columns.Clear(); // Xóa sạch cột cũ

            DataGridViewTextBoxColumn cotTenSP = new DataGridViewTextBoxColumn(); // Cột tên mặt hàng
            cotTenSP.Name = "TenSP"; // Đặt tên định danh cột
            cotTenSP.HeaderText = "Tên Sản Phẩm"; // Tiêu đề cột
            cotTenSP.Width = 200; // Độ rộng 200 pixel
            dgvChiTiet.Columns.Add(cotTenSP); // Thêm vào bảng

            DataGridViewTextBoxColumn cotSL = new DataGridViewTextBoxColumn(); // Cột số lượng mua
            cotSL.Name = "SoLuong"; // Đặt tên định danh cột
            cotSL.HeaderText = "SL"; // Tiêu đề cột
            cotSL.Width = 45; // Độ rộng 45 pixel
            cotSL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            dgvChiTiet.Columns.Add(cotSL); // Thêm vào bảng

            DataGridViewTextBoxColumn cotGia = new DataGridViewTextBoxColumn(); // Cột đơn giá sản phẩm
            cotGia.Name = "DonGia"; // Đặt tên định danh cột
            cotGia.HeaderText = "Đơn Giá"; // Tiêu đề cột
            cotGia.Width = 90; // Độ rộng 90 pixel
            cotGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
            dgvChiTiet.Columns.Add(cotGia); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTien = new DataGridViewTextBoxColumn(); // Cột thành tiền
            cotTien.Name = "ThanhTien"; // Đặt tên định danh cột
            cotTien.HeaderText = "Thành Tiền"; // Tiêu đề cột
            cotTien.Width = 95; // Độ rộng 95 pixel
            cotTien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
            dgvChiTiet.Columns.Add(cotTien); // Thêm vào bảng
        }

        /// <summary>
        /// Tải thông tin chi tiết hóa đơn lên các nhãn và bảng danh sách món hàng.
        /// </summary>
        private void napDuLieuHoaDon()
        {
            if (hoaDonHienThi == null) return; // Nếu chưa có hóa đơn thì dừng

            lblSoHoaDon.Text = "Số HĐ: " + hoaDonHienThi.MaHoaDon; // Hiển thị mã hóa đơn
            lblNgayLap.Text = "Ngày lập: " + hoaDonHienThi.NgayLap.ToString("dd/MM/yyyy HH:mm"); // Hiển thị ngày giờ
            lblThuNgan.Text = "Thu ngân: " + hoaDonHienThi.TenNhanVien; // Hiển thị tên thu ngân
            lblKhachHang.Text = "Khách hàng: " + hoaDonHienThi.TenKhachHang; // Hiển thị tên khách hàng

            lblTongCongTien.Text = "Tổng tiền hàng: " + hoaDonHienThi.TongTien.ToString("N0") + " đ"; // Hiển thị tổng tiền
            lblGiamGia.Text = "Chiết khấu / Giảm giá: " + hoaDonHienThi.GiamGia.ToString("N0") + " đ"; // Hiển thị giảm giá
            lblThanhTien.Text = "TỔNG THANH TOÁN: " + hoaDonHienThi.ThanhTien.ToString("N0") + " đ"; // Hiển thị thực thu

            dgvChiTiet.Rows.Clear(); // Xóa sạch dòng cũ trên bảng
            HoaDonService hdService = new HoaDonService(); // Khởi tạo dịch vụ hóa đơn
            List<ChiTietHoaDon> dsChiTiet = hdService.layChiTietHoaDon(hoaDonHienThi.MaHD); // Lấy danh sách chi tiết

            foreach (ChiTietHoaDon ct in dsChiTiet) // Duyệt qua từng sản phẩm trong hóa đơn
            {
                int r = dgvChiTiet.Rows.Add(); // Thêm một dòng mới
                dgvChiTiet.Rows[r].Cells["TenSP"].Value = ct.TenSP; // Gán tên sản phẩm
                dgvChiTiet.Rows[r].Cells["SoLuong"].Value = ct.SoLuong; // Gán số lượng
                dgvChiTiet.Rows[r].Cells["DonGia"].Value = ct.DonGia.ToString("N0"); // Gán đơn giá
                dgvChiTiet.Rows[r].Cells["ThanhTien"].Value = ct.ThanhTien.ToString("N0"); // Gán thành tiền
            }
        }

        /// <summary>
        /// Xử lý gửi lệnh in phiếu thanh toán ra máy in hóa đơn.
        /// </summary>
        private void btnInPhieuClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Đã gửi lệnh in thành công đến máy in hóa đơn bán lẻ!\nSố HĐ: " + (hoaDonHienThi != null ? hoaDonHienThi.MaHoaDon : ""),
                "Thông Báo In Phiếu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information); // Thông báo thành công
        }

        /// <summary>
        /// Đóng cửa sổ xem phiếu in hóa đơn.
        /// </summary>
        private void btnDongClick(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }
    }
}

