using System; // Thư viện xử lý kiểu dữ liệu và thời gian của .NET
using System.Collections.Generic; // Thư viện tập hợp danh sách List<T>
using System.Drawing; // Thư viện đồ họa và màu sắc
using System.Windows.Forms; // Thư viện thành phần điều khiển Windows Forms

namespace QuanlyshopVT // Không gian tên chính của dự án Quản lý Shop Thời trang Việt Tiến
{
    // ══════════════════════════════════════════════════════════════════════════════
    //  FORM LẬP HÓA ĐƠN BÁN HÀNG CHI TIẾT (POS BÁN LẺ THỜI TRANG)
    //  Cho phép chọn nhiều sản phẩm vào giỏ, trừ tồn kho tự động, tính tiền thừa
    //  Hỗ trợ Visual Studio Designer chỉnh sửa giao diện thủ công
    //  Toàn bộ mã nguồn có chú thích chi tiết công dụng của từng dòng lệnh
    // ══════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// FormTaoHoaDon – Cửa sổ bán hàng và lập hóa đơn bán lẻ chuyên nghiệp.
    /// Có thể chỉnh sửa thủ công trực quan trong Visual Studio Designer.
    /// </summary>
    public partial class FormTaoHoaDon : Form // Kế thừa từ Form của Windows Forms
    {
        private List<ChiTietHoaDon> gioHang; // Danh sách các mặt hàng đang được chọn trong giỏ
        private decimal tongTienHang; // Biến lưu tổng tiền hàng trước chiết khấu
        private decimal tongThanhToan; // Biến lưu số tiền thực tế khách phải trả sau khi giảm giá

        /// <summary>Hóa đơn vừa tạo thành công để Form1 mở xem hoặc in phiếu.</summary>
        public HoaDon HoaDonVuaTao { get; private set; } // Thuộc tính chỉ đọc từ bên ngoài

        /// <summary>
        /// Hàm khởi tạo của FormTaoHoaDon.
        /// </summary>
        public FormTaoHoaDon()
        {
            InitializeComponent(); // Khởi tạo các điều khiển từ file Designer
            gioHang = new List<ChiTietHoaDon>(); // Khởi tạo danh sách giỏ hàng trống
            tongTienHang = 0; // Đặt tổng tiền hàng ban đầu bằng 0
            tongThanhToan = 0; // Đặt tổng thanh toán ban đầu bằng 0
            HoaDonVuaTao = null; // Mặc định chưa có hóa đơn

            caiDatCotGioHang(); // Khởi tạo cấu trúc các cột cho bảng giỏ hàng
            napDanhSachKhachHang(); // Nạp dữ liệu khách hàng vào ComboBox
            napDanhSachSanPham(); // Nạp dữ liệu sản phẩm may mặc vào ComboBox

            if (cboPhuongThuc.Items.Count > 0) cboPhuongThuc.SelectedIndex = 0; // Mặc định chọn tiền mặt

            NhanVien nv = KhoDuLieu.NguoiDangNhapHienTai; // Lấy thông tin thu ngân đang đăng nhập
            lblThuNganPOS.Text = "Thu ngân: " + (nv != null ? nv.HoTen : "Phạm Thái Lan"); // Hiển thị tên thu ngân
            lblNgayLapPOS.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"); // Hiển thị ngày giờ
        }

        /// <summary>
        /// Cài đặt cấu trúc cột hiển thị cho DataGridView Giỏ Hàng.
        /// </summary>
        private void caiDatCotGioHang()
        {
            dgvGioHang.Columns.Clear(); // Xóa sạch cột cũ
            dgvGioHang.EnableHeadersVisualStyles = false; // Bật chế độ tùy biến tiêu đề
            dgvGioHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59); // Màu nền tiêu đề Slate Navy
            dgvGioHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Màu chữ trắng
            dgvGioHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold); // Phông chữ đậm
            dgvGioHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252); // Màu nền xen kẽ
            dgvGioHang.GridColor = Color.FromArgb(226, 232, 240); // Đường kẻ ô
            dgvGioHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Kẻ ngang
            dgvGioHang.RowTemplate.Height = 28; // Chiều cao mỗi dòng 28 pixel

            dgvGioHang.Columns.Add("MaSP", "ID"); // Cột ID sản phẩm
            dgvGioHang.Columns.Add("TenSP", "Tên Sản Phẩm Thời Trang"); // Cột tên mặt hàng
            dgvGioHang.Columns.Add("SoLuong", "Số Lượng"); // Cột số lượng mua
            dgvGioHang.Columns.Add("DonGia", "Đơn Giá (đ)"); // Cột đơn giá niêm yết
            dgvGioHang.Columns.Add("ThanhTien", "Thành Tiền (đ)"); // Cột thành tiền của món hàng

            dgvGioHang.Columns["MaSP"].Width = 50; // Chiều rộng cột ID
            dgvGioHang.Columns["TenSP"].Width = 320; // Chiều rộng cột tên
            dgvGioHang.Columns["SoLuong"].Width = 90; // Chiều rộng cột số lượng
            dgvGioHang.Columns["DonGia"].Width = 140; // Chiều rộng cột đơn giá
            dgvGioHang.Columns["ThanhTien"].Width = 160; // Chiều rộng cột thành tiền

            dgvGioHang.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            dgvGioHang.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
            dgvGioHang.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
        }

        /// <summary>
        /// Nạp danh sách khách hàng vào ComboBox lựa chọn.
        /// </summary>
        private void napDanhSachKhachHang()
        {
            cboKhachHangPOS.Items.Clear(); // Xóa sạch danh sách cũ
            cboKhachHangPOS.Items.Add("Khách Lẻ (Mua trực tiếp tại showroom)"); // Thêm lựa chọn khách lẻ mặc định
            foreach (KhachHang kh in KhoDuLieu.DanhSachKhachHang) // Duyệt qua tất cả khách hàng
            {
                cboKhachHangPOS.Items.Add(kh.HoTen + " - " + kh.SoDienThoai + " (" + kh.LoaiKhach + ")"); // Hiển thị chi tiết
            }
            cboKhachHangPOS.SelectedIndex = 0; // Chọn mục đầu tiên mặc định
        }

        /// <summary>
        /// Nạp danh sách sản phẩm thời trang còn tồn kho vào ComboBox bán hàng.
        /// </summary>
        private void napDanhSachSanPham()
        {
            cboSanPhamPOS.Items.Clear(); // Xóa sạch danh sách cũ
            foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt qua từng sản phẩm trong kho
            {
                cboSanPhamPOS.Items.Add(sp.MaHang + " | " + sp.TenSP + " [Size: " + sp.Size + "] - " + sp.GiaBan.ToString("N0") + " đ (Tồn: " + sp.SoLuongTon + ")"); // Hiển thị đầy đủ thông tin
            }
            if (cboSanPhamPOS.Items.Count > 0) cboSanPhamPOS.SelectedIndex = 0; // Chọn sản phẩm đầu tiên
        }

        /// <summary>
        /// Thêm sản phẩm đang chọn trên ComboBox vào bảng giỏ hàng.
        /// </summary>
        private void btnThemVaoGioClick(object sender, EventArgs e)
        {
            if (cboSanPhamPOS.SelectedIndex < 0 || cboSanPhamPOS.SelectedIndex >= KhoDuLieu.DanhSachSanPham.Count) // Kiểm tra hợp lệ
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SanPham sp = KhoDuLieu.DanhSachSanPham[cboSanPhamPOS.SelectedIndex]; // Lấy sản phẩm tương ứng
            int slMua = (int)numSoLuong.Value; // Lấy số lượng người dùng muốn mua

            int slHienTaiTrongGio = 0; // Biến tính số lượng sản phẩm này đã có sẵn trong giỏ
            ChiTietHoaDon dongDaCo = null; // Tham chiếu dòng đã có
            foreach (ChiTietHoaDon ct in gioHang) // Duyệt qua giỏ hàng
            {
                if (ct.MaSP == sp.MaSP) // Nếu trùng ID sản phẩm
                {
                    slHienTaiTrongGio = ct.SoLuong; // Lấy số lượng hiện tại
                    dongDaCo = ct; // Lưu lại dòng chi tiết
                    break;
                }
            }

            if (slHienTaiTrongGio + slMua > sp.SoLuongTon) // Kiểm tra nếu mua vượt quá số lượng tồn kho
            {
                MessageBox.Show(
                    "Sản phẩm '" + sp.TenSP + "' chỉ còn tồn kho " + sp.SoLuongTon + " chiếc!\nBạn không thể bán vượt quá tồn kho thực tế.",
                    "Cảnh Báo Tồn Kho",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Cảnh báo thiếu hàng
                return;
            }

            if (dongDaCo != null) // Nếu sản phẩm đã có trong giỏ
            {
                dongDaCo.SoLuong += slMua; // Tăng thêm số lượng
                dongDaCo.ThanhTien = dongDaCo.SoLuong * dongDaCo.DonGia; // Tính lại thành tiền
            }
            else // Nếu sản phẩm chưa có trong giỏ
            {
                ChiTietHoaDon ctMoi = new ChiTietHoaDon // Tạo dòng chi tiết mới
                {
                    MaCTHD = KhoDuLieu.SinhMaCTHD(),
                    MaHD = 0,
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP + " (" + sp.Size + ", " + sp.MauSacSP + ")",
                    SoLuong = slMua,
                    DonGia = sp.GiaBan,
                    ThanhTien = slMua * sp.GiaBan
                };
                gioHang.Add(ctMoi); // Thêm vào danh sách giỏ
            }

            numSoLuong.Value = 1; // Đặt lại số lượng chọn về 1
            capNhatBangGioHang(); // Cập nhật lại giao diện bảng giỏ hàng
        }

        /// <summary>
        /// Xóa một món hàng khỏi giỏ khi khách đổi ý không mua nữa.
        /// </summary>
        private void btnXoaKhoiGioClick(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null) // Kiểm tra đã chọn món cần bỏ chưa
            {
                MessageBox.Show("Vui lòng chọn món hàng trong giỏ để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = dgvGioHang.CurrentRow.Index; // Lấy vị trí dòng đang chọn
            if (idx >= 0 && idx < gioHang.Count) // Kiểm tra vị trí hợp lệ
            {
                gioHang.RemoveAt(idx); // Xóa khỏi danh sách giỏ hàng
                capNhatBangGioHang(); // Cập nhật lại bảng
            }
        }

        /// <summary>
        /// Nạp lại toàn bộ dòng trong giỏ hàng lên DataGridView và tính toán tổng tiền.
        /// </summary>
        private void capNhatBangGioHang()
        {
            dgvGioHang.Rows.Clear(); // Xóa sạch dữ liệu cũ
            tongTienHang = 0; // Đặt lại tổng tiền hàng bằng 0

            foreach (ChiTietHoaDon ct in gioHang) // Duyệt qua từng món hàng trong giỏ
            {
                int r = dgvGioHang.Rows.Add(); // Thêm một dòng mới
                dgvGioHang.Rows[r].Cells["MaSP"].Value = ct.MaSP; // Gán ID
                dgvGioHang.Rows[r].Cells["TenSP"].Value = ct.TenSP; // Gán tên sản phẩm
                dgvGioHang.Rows[r].Cells["SoLuong"].Value = ct.SoLuong; // Gán số lượng
                dgvGioHang.Rows[r].Cells["DonGia"].Value = ct.DonGia.ToString("N0"); // Gán đơn giá
                dgvGioHang.Rows[r].Cells["ThanhTien"].Value = ct.ThanhTien.ToString("N0"); // Gán thành tiền
                tongTienHang += ct.ThanhTien; // Cộng dồn vào tổng tiền hàng
            }

            lblTongTienHang.Text = tongTienHang.ToString("N0") + " đ"; // Hiển thị tổng tiền hàng
            tinhTongThanhToan(); // Gọi hàm tính số tiền thực thu sau chiết khấu
        }

        /// <summary>
        /// Sự kiện thay đổi số tiền giảm giá chiết khấu.
        /// </summary>
        private void txtGiamGiaTextChanged(object sender, EventArgs e)
        {
            tinhTongThanhToan(); // Tính lại tổng tiền thực thu
        }

        /// <summary>
        /// Sự kiện thay đổi số tiền khách đưa để tính tiền thừa thối lại.
        /// </summary>
        private void txtTienKhachDuaTextChanged(object sender, EventArgs e)
        {
            tinhTienThua(); // Tính lại tiền thừa
        }

        /// <summary>
        /// Tính toán số tiền thực thanh toán = Tổng tiền hàng - Giảm giá.
        /// </summary>
        private void tinhTongThanhToan()
        {
            decimal giamGia = 0; // Biến lưu số tiền giảm
            string text = txtGiamGia.Text.Replace(".", "").Replace(",", "").Trim(); // Làm sạch chuỗi
            decimal.TryParse(text, out giamGia); // Ép kiểu số

            if (giamGia < 0) giamGia = 0; // Giảm giá không được âm
            if (giamGia > tongTienHang) giamGia = tongTienHang; // Giảm giá tối đa bằng tiền hàng

            tongThanhToan = tongTienHang - giamGia; // Tính tiền thanh toán
            lblThanhTien.Text = tongThanhToan.ToString("N0") + " đ"; // Hiển thị tiền phải thu màu đỏ đậm
            tinhTienThua(); // Cập nhật lại số tiền thừa tương ứng
        }

        /// <summary>
        /// Tính số tiền thối lại cho khách mua hàng.
        /// </summary>
        private void tinhTienThua()
        {
            decimal tienKhachDua = 0; // Khởi tạo tiền khách đưa
            string text = txtTienKhachDua.Text.Replace(".", "").Replace(",", "").Trim(); // Làm sạch chuỗi
            decimal.TryParse(text, out tienKhachDua); // Ép kiểu số

            decimal tienThua = tienKhachDua - tongThanhToan; // Tính chênh lệch
            if (tienThua >= 0) // Nếu khách đưa đủ hoặc thừa
            {
                lblTienThua.ForeColor = Color.FromArgb(22, 101, 52); // Đổi màu xanh lá
                lblTienThua.Text = "Tiền thừa trả khách: " + tienThua.ToString("N0") + " đ"; // Báo tiền thừa
            }
            else // Nếu khách đưa thiếu tiền
            {
                lblTienThua.ForeColor = Color.FromArgb(185, 28, 28); // Đổi màu đỏ
                lblTienThua.Text = "Còn thiếu: " + Math.Abs(tienThua).ToString("N0") + " đ"; // Báo còn thiếu
            }
        }

        /// <summary>
        /// Xử lý sự kiện nhấn nút HOÀN TẤT & XUẤT HÓA ĐƠN.
        /// </summary>
        private void btnThanhToanClick(object sender, EventArgs e)
        {
            if (gioHang.Count == 0) // Kiểm tra giỏ hàng có rỗng không
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn ít nhất 1 sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal giamGia = 0; // Biến nhận giảm giá
            decimal.TryParse(txtGiamGia.Text.Replace(".", "").Replace(",", "").Trim(), out giamGia); // Lấy giá trị

            string tenKH = "Khách Lẻ"; // Mặc định tên khách
            int maKH = 1; // Mặc định mã khách
            if (cboKhachHangPOS.SelectedIndex > 0) // Nếu chọn khách hàng trong danh sách
            {
                KhachHang khChon = KhoDuLieu.DanhSachKhachHang[cboKhachHangPOS.SelectedIndex - 1]; // Lấy khách hàng
                tenKH = khChon.HoTen; // Lấy họ tên
                maKH = khChon.MaKH; // Lấy ID
                khChon.DiemTichLuy += (int)(tongThanhToan / 100000); // Cộng điểm thưởng: 100.000đ = 1 điểm
            }

            NhanVien nvHienTai = KhoDuLieu.NguoiDangNhapHienTai; // Lấy nhân viên thu ngân
            string tenNV = nvHienTai != null ? nvHienTai.HoTen : "Phạm Thái Lan"; // Lấy họ tên thu ngân
            int maNV = nvHienTai != null ? nvHienTai.MaNV : 1; // Lấy ID thu ngân

            string phuongThuc = cboPhuongThuc.SelectedItem != null ? cboPhuongThuc.SelectedItem.ToString() : "Tiền mặt"; // Lấy hình thức thanh toán

            HoaDon hdMoi = new HoaDon // Tạo mới đối tượng Hóa Đơn
            {
                MaHD = KhoDuLieu.SinhMaHD(), // Sinh mã ID tự động
                MaHoaDon = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss"), // Sinh mã hóa đơn theo thời gian
                NgayLap = DateTime.Now, // Ngày giờ hiện tại
                MaNV = maNV, // Mã nhân viên bán hàng
                TenNhanVien = tenNV, // Tên nhân viên bán hàng
                MaKH = maKH, // Mã khách hàng
                TenKhachHang = tenKH, // Tên khách hàng
                TongTien = tongTienHang, // Tổng tiền hàng
                GiamGia = giamGia, // Giảm giá
                ThanhTien = tongThanhToan, // Thực thu
                PhuongThucTT = phuongThuc, // Hình thức thanh toán
                TrangThai = "Đã thanh toán" // Tình trạng thanh toán
            };

            KhoDuLieu.DanhSachHoaDon.Add(hdMoi); // Lưu hóa đơn vào kho dữ liệu

            foreach (ChiTietHoaDon ct in gioHang) // Duyệt từng món hàng trong giỏ
            {
                ct.MaHD = hdMoi.MaHD; // Gán khóa ngoại liên kết với hóa đơn vừa tạo
                KhoDuLieu.DanhSachChiTietHoaDon.Add(ct); // Thêm dòng chi tiết vào kho

                // Giảm trừ tồn kho thực tế của sản phẩm
                foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Tìm sản phẩm trong kho
                {
                    if (sp.MaSP == ct.MaSP) // Nếu trùng ID
                    {
                        if (sp.SoLuongTon >= ct.SoLuong) sp.SoLuongTon -= ct.SoLuong; // Trừ số tồn kho
                        else sp.SoLuongTon = 0; // Nếu không đủ thì về 0
                        break;
                    }
                }
            }

            HoaDonVuaTao = hdMoi; // Gán thuộc tính đầu ra cho Form1
            this.DialogResult = DialogResult.OK; // Đặt kết quả là thành công
            this.Close(); // Đóng cửa sổ lập hóa đơn
        }

        /// <summary>
        /// Hủy bỏ quá trình lập đơn hàng.
        /// </summary>
        private void btnHuyBoClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Đặt kết quả là hủy
            this.Close(); // Đóng cửa sổ
        }
    }
}

