using System; // Sử dụng các kiểu dữ liệu và lớp cơ bản của .NET Framework
using System.Collections.Generic; // Sử dụng các cấu trúc tập hợp danh sách List<T>
using System.Drawing; // Sử dụng các kiểu định dạng đồ họa, điểm ảnh và màu sắc
using System.Windows.Forms; // Sử dụng các thành phần điều khiển giao diện Windows Forms

namespace QuanlyshopVT // Không gian tên chính của dự án Quản lý Shop Thời trang Việt Tiến
{
    // ══════════════════════════════════════════════════════════════════════════════
    //  FORM CHÍNH (MAIN FORM) – HỆ THỐNG QUẢN LÝ SHOP THỜI TRANG VIETTIEN
    //  Giao diện hiện đại, chuyên nghiệp, hỗ trợ Visual Studio Designer kéo thả
    //  Hỗ trợ chức năng thêm, xóa, sửa trực tiếp trên DataGridView với nút Lưu
    //  Tích hợp Dashboard KPI, POS Bán hàng, In hóa đơn và Báo cáo thống kê
    //  Toàn bộ mã nguồn có chú thích chi tiết công dụng của từng dòng lệnh
    // ══════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// Form1 – Lớp giao diện trung tâm điều hành toàn bộ hoạt động của cửa hàng thời trang Việt Tiến.
    /// Kế thừa từ Form của thư viện Windows Forms.
    /// </summary>
    public partial class Form1 : Form
    {
        // ── Khai báo các đối tượng thuộc tầng nghiệp vụ (Service Layer) ────────────
        private SanPhamService sanPhamService; // Dịch vụ xử lý dữ liệu và nghiệp vụ sản phẩm
        private KhachHangService khachHangService; // Dịch vụ xử lý dữ liệu và nghiệp vụ khách hàng
        private NhaCungCapService nhaCungCapService; // Dịch vụ xử lý dữ liệu và nghiệp vụ nhà cung cấp
        private HoaDonService hoaDonService; // Dịch vụ xử lý dữ liệu và nghiệp vụ hóa đơn
        private AuthService authService; // Dịch vụ xử lý phân quyền và xác thực tài khoản
        private ThongKeService thongKeService; // Dịch vụ tổng hợp số liệu báo cáo và biểu đồ

        // ── Thuộc tính cờ đánh dấu đăng xuất ─────────────────────────────────────
        public bool DaDangXuat { get; set; } // Biến cờ: true nếu người dùng chọn Đăng xuất

        /// <summary>
        /// Hàm khởi tạo của Form1.
        /// Chạy đầu tiên khi đối tượng Form1 được tạo ra trong bộ nhớ.
        /// </summary>
        public Form1()
        {
            InitializeComponent(); // Gọi phương thức khởi tạo giao diện từ file Designer
            DaDangXuat = false; // Khởi tạo cờ đăng xuất bằng false (chưa đăng xuất)

            // Khởi tạo các thể hiện của tầng nghiệp vụ (Service)
            sanPhamService = new SanPhamService(); // Tạo mới đối tượng xử lý sản phẩm
            khachHangService = new KhachHangService(); // Tạo mới đối tượng xử lý khách hàng
            nhaCungCapService = new NhaCungCapService(); // Tạo mới đối tượng xử lý nhà cung cấp
            hoaDonService = new HoaDonService(); // Tạo mới đối tượng xử lý hóa đơn
            authService = new AuthService(); // Tạo mới đối tượng xử lý xác thực tài khoản
            thongKeService = new ThongKeService(); // Tạo mới đối tượng tổng hợp thống kê và biểu đồ
        }

        /// <summary>
        /// Sự kiện kích hoạt khi Form1 được nạp vào màn hình lần đầu tiên.
        /// </summary>
        private void Form1Load(object sender, EventArgs e)
        {
            NhanVien nvHienTai = authService.layNhanVienHienTai(); // Lấy thông tin tài khoản đang đăng nhập
            if (nvHienTai != null) // Kiểm tra nếu đã có thông tin tài khoản đăng nhập hợp lệ
            {
                lblNguoiDung.Text = "Xin chào: " + nvHienTai.HoTen + " (" + nvHienTai.ChucVu + ")"; // Hiển thị tên và quyền
            }
            else // Nếu không có dữ liệu tài khoản
            {
                lblNguoiDung.Text = "Xin chào: Quản lý"; // Hiển thị mặc định là Quản lý
            }

            // Kích hoạt bộ đệm đôi DoubleBuffered cho Panel biểu đồ để vẽ khử răng cưa mượt mà không bị nháy hình
            if (pnlBieuDoThongKe != null)
            {
                typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, pnlBieuDoThongKe, new object[] { true });
            }

            // Gọi các hàm định dạng hiển thị đẹp mắt cho tất cả các bảng DataGridView
            dinhDangBang(dgvSanPham); // Định dạng bảng sản phẩm
            dinhDangBang(dgvKhachHang); // Định dạng bảng khách hàng
            dinhDangBang(dgvNhaCungCap); // Định dạng bảng nhà cung cấp
            dinhDangBang(dgvHoaDon); // Định dạng bảng hóa đơn
            dinhDangBang(dgvChiTietHoaDon); // Định dạng bảng chi tiết hóa đơn
            dinhDangBang(dgvNhanVien); // Định dạng bảng nhân viên
            dinhDangBang(dgvCanhBaoKho); // Định dạng bảng cảnh báo tồn kho
            dinhDangBang(dgvGiaoDichMoi); // Định dạng bảng giao dịch gần đây
            dinhDangBang(dgvThongKeNV); // Định dạng bảng thống kê nhân viên
            dinhDangBang(dgvThongKeSP); // Định dạng bảng thống kê sản phẩm

            // Gọi các hàm khởi tạo cấu trúc cột cho các bảng DataGridView
            thietLapCotSanPham(); // Thiết lập cột cho bảng Sản Phẩm
            thietLapCotKhachHang(); // Thiết lập cột cho bảng Khách Hàng
            thietLapCotNhaCungCap(); // Thiết lập cột cho bảng Nhà Cung Cấp
            thietLapCotHoaDon(); // Thiết lập cột cho bảng Hóa Đơn
            thietLapCotChiTietHoaDon(); // Thiết lập cột cho bảng Chi Tiết Hóa Đơn
            thietLapCotNhanVien(); // Thiết lập cột cho bảng Nhân Viên
            thietLapCotCanhBaoKho(); // Thiết lập cột cho bảng Cảnh Báo Kho
            thietLapCotGiaoDichMoi(); // Thiết lập cột cho bảng Giao Dịch Gần Đây
            thietLapCotThongKeNV(); // Thiết lập cột cho bảng Thống Kê Nhân Viên
            thietLapCotThongKeSP(); // Thiết lập cột cho bảng Thống Kê Sản Phẩm

            // Chọn giá trị mặc định đầu tiên cho ComboBox lọc phân loại và thống kê
            if (cboLocLoaiSP.Items.Count > 0) cboLocLoaiSP.SelectedIndex = 0; // Mặc định là Tất cả loại
            if (cboKyBaoCao != null && cboKyBaoCao.Items.Count > 0) cboKyBaoCao.SelectedIndex = 0; // Mặc định là Toàn bộ kỳ
            if (cboCheDoBieuDo != null && cboCheDoBieuDo.Items.Count > 0) cboCheDoBieuDo.SelectedIndex = 0; // Mặc định là Biểu đồ cột phân loại

            // Gọi các hàm tải dữ liệu ban đầu lên các bảng
            loadDataSanPham(""); // Nạp toàn bộ dữ liệu sản phẩm lên bảng
            loadDataKhachHang(""); // Nạp toàn bộ dữ liệu khách hàng lên bảng
            loadDataNhaCungCap(""); // Nạp toàn bộ dữ liệu nhà cung cấp lên bảng
            loadDataHoaDon(""); // Nạp toàn bộ dữ liệu hóa đơn lên bảng
            loadDataNhanVien(""); // Nạp toàn bộ dữ liệu nhân viên lên bảng

            // Cập nhật các bảng số liệu thống kê và tổng quan Dashboard
            pnlBangThongKeContainer.Resize += new EventHandler(pnlBangThongKeContainerResize); // Gắn sự kiện co giãn
            capNhatDashboard(); // Cập nhật các thẻ KPI và danh sách cảnh báo trên Dashboard
            capNhatThongKe(); // Cập nhật dữ liệu tổng hợp tại tab Thống Kê
            capNhatDongHo(); // Hiển thị thời gian thực ban đầu lên thanh tiêu đề
            capNhatStatusTongSo(); // Cập nhật nhãn tổng số lượng bản ghi dưới thanh trạng thái
            apDungPhanQuyen(nvHienTai); // Phân quyền chi tiết giao diện theo vai trò của người đăng nhập
        }

        /// <summary>
        /// Xử lý căn đều tỷ lệ 50-50 cho 2 bảng dữ liệu thống kê khi kích thước màn hình thay đổi.
        /// </summary>
        private void pnlBangThongKeContainerResize(object sender, EventArgs e)
        {
            if (pnlThongKeNV.Visible && pnlBangThongKeContainer.ClientSize.Width > 200) // Nếu bảng nhân viên đang hiển thị
            {
                pnlThongKeNV.Width = pnlBangThongKeContainer.ClientSize.Width / 2; // Cân bằng đều 50% mỗi bên
            }
        }

        /// <summary>
        /// Phân quyền chi tiết giao diện và tính năng theo chức vụ của người dùng đăng nhập.
        /// Phân biệt rõ rệt: Quản lý (Toàn quyền), Thủ kho (Kho vận, Nhập hàng, NCC), Thu ngân (POS, Bán hàng).
        /// </summary>
        private void apDungPhanQuyen(NhanVien nv)
        {
            if (nv == null) return; // Nếu nhân viên null thì kết thúc

            string chucVu = nv.ChucVu != null ? nv.ChucVu.Trim() : ""; // Lấy chức vụ chuẩn hóa

            if (chucVu.Equals("Thủ kho", StringComparison.OrdinalIgnoreCase))
            {
                // 1. VAI TRÒ THỦ KHO (Lê Hoàng Nam)
                lblNguoiDung.Text = "Xin chào: " + nv.HoTen + " (Thủ kho - Quản Trị Kho Vận & Hàng Hóa)"; // Tiêu đề vai trò rõ ràng

                // Đổi tiêu đề các tab phù hợp với nghiệp vụ kho
                tabSanPham.Text = "Sản Phẩm & Kho Hàng"; // Tiêu đề kho hàng
                tabHoaDon.Text = "Xuất Kho & Đơn Hàng"; // Tiêu đề xuất kho
                tabThongKe.Text = "Kiểm Kê & Báo Cáo Kho"; // Tiêu đề kiểm kê kho

                // Ẩn hoàn toàn tab Nhân Viên (Thủ kho không được can thiệp nhân sự)
                if (tabChinh.TabPages.Contains(tabNhanVien))
                {
                    tabChinh.TabPages.Remove(tabNhanVien); // Gỡ bỏ tab nhân viên
                }

                // Chế độ hóa đơn: Thủ kho chỉ tra cứu đối soát xuất kho, không lập hóa đơn bán lẻ hay hủy đơn
                btnTaoHD.Visible = false; // Ẩn nút tạo đơn bán
                btnHuyHD.Visible = false; // Ẩn nút hủy đơn bán
                btnInHD.Visible = true; // Cho phép in phiếu xuất kho
                btnXuatFileHD.Visible = true; // Cho phép xuất Excel đơn xuất kho

                // Tab Thống kê: Thủ kho chỉ xem cơ cấu hàng hóa tồn kho, không xem doanh thu tài chính hay hiệu suất nhân viên
                btnBaoCaoDoanhThu.Visible = false; // Ẩn nút xuất báo cáo doanh thu tài chính
                btnBaoCaoTonKho.Visible = true; // Hiện nút kiểm kê kho
                btnNapDuLieuGoc.Visible = true; // Hiện nút nạp dữ liệu mẫu
                pnlThongKeNV.Visible = false; // Ẩn bảng hiệu suất nhân viên bán hàng
                pnlThongKeSP.Dock = DockStyle.Fill; // Mở rộng bảng tồn kho toàn bộ chiều rộng
                lblTieuDeTKSP.Text = "BẢNG TỔNG HỢP KIỂM KÊ VÀ GIÁ TRỊ TỒN KHO THEO LOẠI HÀNG HÓA"; // Tiêu đề bảng kiểm kê

                // Điều chỉnh danh sách lựa chọn biểu đồ phù hợp với nghiệp vụ kho
                cboCheDoBieuDo.Items.Clear(); // Xóa các mục biểu đồ cũ
                cboCheDoBieuDo.Items.Add("Biểu đồ cột: Sản phẩm tồn kho thấp cần nhập"); // Biểu đồ cảnh báo nhập hàng
                cboCheDoBieuDo.Items.Add("Biểu đồ tròn: Cơ cấu tồn kho"); // Biểu đồ tròn cơ cấu kho
                cboCheDoBieuDo.SelectedIndex = 0; // Chọn mục đầu tiên

                // Hiển thị các nút nghiệp vụ chuyên biệt của Thủ kho trên tab Sản phẩm
                btnNhapKho.Visible = true; // Hiện nút Nhập Thêm Hàng Vào Kho
                btnLocHangTonThap.Visible = true; // Hiện nút Lọc hàng tồn kho thấp
                btnThemSP.Enabled = true; // Cho phép thêm mặt hàng mới
                btnLuuSP.Enabled = true; // Cho phép lưu thông tin mặt hàng
                btnXoaSP.Enabled = false; // Khóa chức năng xóa mặt hàng khỏi danh mục

                // Đổi các nút thao tác nhanh trên Tổng Quan sang nghiệp vụ kho
                btnQuickBanHang.Text = "Nhập Thêm Kho"; // Nút nhập kho
                btnQuickBanHang.BackColor = Color.FromArgb(15, 118, 110); // Màu xanh Teal
                btnQuickThemSP.Text = "Kiểm Kê Tồn Kho"; // Nút kiểm kê
                btnQuickKhachHang.Text = "Nhà Cung Cấp"; // Nút mở nhà cung cấp
                btnQuickKhachHang.BackColor = Color.FromArgb(2, 132, 199); // Màu xanh dương nhạt
                btnQuickLamMoiKPI.Text = "Làm Mới Số Liệu"; // Nút làm mới

                // Đổi nhãn KPI trên Tổng Quan: Giá trị tài sản tồn kho và cảnh báo
                decimal tongGiaTriTon = 0; // Biến tính tổng giá trị vốn tồn kho
                int soLuongTonThap = 0; // Số mặt hàng tồn thấp
                foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt qua các mặt hàng
                {
                    tongGiaTriTon += (sp.GiaNhap * sp.SoLuongTon); // Cộng dồn giá trị vốn
                    if (sp.SoLuongTon < 30) // Kiểm tra tồn thấp
                    {
                        soLuongTonThap++; // Đếm hàng sắp hết
                    }
                }
                lblKpiSPTieuDe.Text = "TỔNG LOẠI HÀNG HÓA"; // Tiêu đề sản phẩm kho
                lblKpiKHTieuDe.Text = "ĐỐI TÁC CUNG ỨNG"; // Tiêu đề nhà cung cấp
                lblKpiKHSoLuong.Text = KhoDuLieu.DanhSachNhaCungCap.Count + " Nhà Cung Cấp"; // Số lượng NCC
                lblKpiKHGhiChu.Text = "Nguồn cung may mặc Việt Tiến"; // Ghi chú NCC
                lblKpiDTTieuDe.Text = "GIÁ TRỊ TỒN KHO"; // Đổi tiêu đề thẻ sang Giá trị tồn kho
                lblKpiDTSoLuong.Text = tongGiaTriTon.ToString("N0") + " đ"; // Hiển thị giá trị tồn kho cho Thủ kho
                lblKpiDTGhiChu.Text = "Tổng giá vốn các mặt hàng trong kho"; // Ghi chú giá vốn
                lblKpiHDTieuDe.Text = "CẢNH BÁO TỒN THẤP"; // Tiêu đề cảnh báo tồn
                lblKpiHDSoLuong.Text = soLuongTonThap + " Mặt Hàng"; // Số mặt hàng sắp hết
                lblKpiHDGhiChu.Text = "Cần lập phiếu nhập kho bổ sung"; // Ghi chú bổ sung

                // Tự động chuyển hướng ngay sang Tab Sản Phẩm & Kho Hàng khi Thủ kho đăng nhập
                tabChinh.SelectedTab = tabSanPham; // Tập trung ngay vào kho hàng
            }
            else if (chucVu.Equals("Nhân viên bán hàng", StringComparison.OrdinalIgnoreCase))
            {
                // 2. VAI TRÒ NHÂN VIÊN BÁN HÀNG / THU NGÂN (Trần Thị Mai)
                lblNguoiDung.Text = "Xin chào: " + nv.HoTen + " (Thu ngân - Quầy Bán Hàng POS)"; // Tiêu đề vai trò thu ngân

                // Tiêu đề các tab phù hợp bán hàng
                tabSanPham.Text = "Tra Cứu Sản Phẩm"; // Tab tra cứu
                tabHoaDon.Text = "Hóa Đơn & Bán Hàng"; // Tab hóa đơn
                tabThongKe.Text = "Báo Cáo Bán Hàng"; // Tab báo cáo

                // Ẩn tab Quản lý nhân viên và tab Nhà cung cấp
                if (tabChinh.TabPages.Contains(tabNhanVien))
                {
                    tabChinh.TabPages.Remove(tabNhanVien); // Gỡ tab nhân viên
                }
                if (tabChinh.TabPages.Contains(tabNhaCungCap))
                {
                    tabChinh.TabPages.Remove(tabNhaCungCap); // Gỡ tab nhà cung cấp
                }

                // Khóa quyền chỉnh sửa hoặc xóa sản phẩm (Nhân viên chỉ được tra cứu giá và tồn)
                btnThemSP.Enabled = false; // Khóa nút thêm sản phẩm
                btnXoaSP.Enabled = false; // Khóa nút xóa sản phẩm
                btnLuuSP.Enabled = false; // Khóa nút lưu sản phẩm
                btnNhapKho.Visible = false; // Không có quyền nhập kho
                btnLocHangTonThap.Visible = false; // Không cần nút lọc kho

                // Ẩn cột Giá Nhập (giá vốn sản phẩm) để bảo mật bí mật kinh doanh
                if (dgvSanPham.Columns.Contains("GiaNhap"))
                {
                    dgvSanPham.Columns["GiaNhap"].Visible = false; // Ẩn cột giá vốn với nhân viên bán lẻ
                }

                // Phân quyền hóa đơn cho nhân viên
                btnTaoHD.Visible = true; // Cho phép tạo hóa đơn bán lẻ
                btnHuyHD.Visible = false; // Khóa chức năng hủy hóa đơn của nhân viên
                btnInHD.Visible = true; // Cho phép in hóa đơn bán lẻ
                btnXuatFileHD.Visible = true; // Cho phép xuất Excel

                // Tab Thống kê: Không cho xuất báo cáo tài chính cấp cao
                btnBaoCaoDoanhThu.Visible = false; // Ẩn xuất báo cáo doanh thu
                btnBaoCaoTonKho.Visible = false; // Ẩn xuất kiểm kê kho
                btnNapDuLieuGoc.Visible = false; // Ẩn nút nạp lại dữ liệu gốc

                // Tự động chuyển hướng ngay sang Tab Hóa Đơn & Bán Hàng POS khi Nhân viên đăng nhập
                tabChinh.SelectedTab = tabHoaDon; // Tập trung ngay vào quầy thu ngân
            }
            else
            {
                // 3. VAI TRÒ QUẢN LÝ / GIÁM ĐỐC (Phạm Thái Lan)
                lblNguoiDung.Text = "Xin chào: " + nv.HoTen + " (Quản lý - Giám Đốc Cửa Hàng)"; // Tiêu đề toàn quyền

                // Khôi phục tên gốc cho các tab
                tabSanPham.Text = "Sản Phẩm"; // Tab sản phẩm
                tabHoaDon.Text = "Hóa Đơn & Bán Hàng"; // Tab hóa đơn
                tabThongKe.Text = "Báo Cáo & Biểu Đồ"; // Tab thống kê

                // Quản lý có toàn quyền truy cập đầy đủ tất cả các tab
                btnTaoHD.Visible = true; // Cho phép tạo đơn
                btnHuyHD.Visible = true; // Cho phép hủy đơn
                btnInHD.Visible = true; // Cho phép in đơn
                btnXuatFileHD.Visible = true; // Cho phép xuất file
                btnThemSP.Enabled = true; // Cho phép thêm SP
                btnXoaSP.Enabled = true; // Cho phép xóa SP
                btnLuuSP.Enabled = true; // Cho phép lưu SP
                btnNhapKho.Visible = true; // Cho phép nhập kho
                btnLocHangTonThap.Visible = true; // Cho phép lọc kho
                btnBaoCaoDoanhThu.Visible = true; // Cho phép xuất doanh thu
                btnBaoCaoTonKho.Visible = true; // Cho phép xuất kiểm kê kho
                btnNapDuLieuGoc.Visible = true; // Cho phép nạp dữ liệu gốc
                pnlThongKeNV.Visible = true; // Xem hiệu suất nhân viên
                lblTieuDeTKSP.Text = "CƠ CẤU HÀNG HÓA VÀ GIÁ TRỊ TỒN KHO THEO LOẠI"; // Tiêu đề bảng tồn kho
                if (pnlBangThongKeContainer.ClientSize.Width > 200) // Kiểm tra chiều rộng bảng
                {
                    pnlThongKeNV.Width = pnlBangThongKeContainer.ClientSize.Width / 2; // Cân xứng 50%
                }
                pnlThongKeSP.Dock = DockStyle.Fill; // Dock fill

                // Cấu hình đầy đủ các loại biểu đồ cho Quản lý
                cboCheDoBieuDo.Items.Clear(); // Xóa cũ
                cboCheDoBieuDo.Items.Add("Biểu đồ cột: Doanh thu theo phân loại"); // Biểu đồ doanh thu SP
                cboCheDoBieuDo.Items.Add("Biểu đồ cột: Doanh số nhân viên"); // Biểu đồ doanh số NV
                cboCheDoBieuDo.Items.Add("Biểu đồ tròn: Cơ cấu tồn kho"); // Biểu đồ tồn kho
                cboCheDoBieuDo.Items.Add("Biểu đồ tròn: Tỷ trọng doanh thu"); // Biểu đồ tỷ trọng
                cboCheDoBieuDo.SelectedIndex = 0; // Chọn mục đầu tiên

                // Khôi phục nút thao tác nhanh trên Tổng quan
                btnQuickBanHang.Text = "Lập Đơn Bán Mới"; // Nút bán hàng
                btnQuickBanHang.BackColor = Color.FromArgb(22, 163, 74); // Màu xanh lá
                btnQuickThemSP.Text = "Quản Lý Sản Phẩm"; // Nút sản phẩm
                btnQuickKhachHang.Text = "Khách Hàng Thân Thiết"; // Nút khách hàng
                btnQuickKhachHang.BackColor = Color.FromArgb(71, 85, 105); // Màu xám Slate
                btnQuickLamMoiKPI.Text = "Cập Nhật Số Liệu"; // Nút cập nhật số liệu

                // Cột giá nhập hiển thị bình thường cho Quản lý
                if (dgvSanPham.Columns.Contains("GiaNhap"))
                {
                    dgvSanPham.Columns["GiaNhap"].Visible = true; // Hiển thị giá nhập
                }

                // Quản lý mặc định vào xem Dashboard Tổng Quan
                tabChinh.SelectedTab = tabTongQuan; // Tập trung vào tổng quan hoạt động
            }
        }

        /// <summary>
        /// Phương thức dùng chung định dạng mỹ thuật hiện đại và dịu mắt cho DataGridView.
        /// Sử dụng tông màu Slate Navy và nền chọn xanh băng Ice Blue tạo cảm giác thoải mái khi nhìn lâu.
        /// </summary>
        private void dinhDangBang(DataGridView dgv)
        {
            if (dgv == null) return; // Nếu bảng rỗng thì bỏ qua
            dgv.EnableHeadersVisualStyles = false; // Tắt phong cách cũ của Windows để áp dụng màu tùy biến
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59); // Màu nền tiêu đề Slate Navy
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Chữ tiêu đề màu trắng tinh
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold); // Phông chữ đậm hiện đại
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Căn lề trái tiêu đề
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular); // Phông chữ nội dung rõ nét
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(15, 23, 42); // Chữ màu tối dễ đọc
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254); // Dòng đang chọn màu Ice Blue dịu mắt
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59); // Chữ dòng đang chọn màu Slate tối nét
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252); // Hàng xen kẽ màu sáng nhẹ
            dgv.GridColor = Color.FromArgb(226, 232, 240); // Đường kẻ ô màu xám nhạt tinh tế
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Chỉ kẻ ngang cho thoáng mắt
            dgv.RowTemplate.Height = 30; // Chiều cao mỗi dòng 30 pixel dễ click
        }

        /// <summary>
        /// Sự kiện kích hoạt định kỳ mỗi giây của Timer để cập nhật đồng hồ số thời gian thực.
        /// </summary>
        private void timerDongHoTick(object sender, EventArgs e)
        {
            capNhatDongHo(); // Gọi hàm cập nhật hiển thị giờ
        }

        /// <summary>
        /// Cập nhật nhãn đồng hồ kỹ thuật số trên thanh tiêu đề ứng dụng.
        /// </summary>
        private void capNhatDongHo()
        {
            lblDongHo.Text = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy"); // Định dạng giờ phút giây và ngày tháng
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  1. PHẦN TỔNG QUAN DASHBOARD VÀ CHỈ SỐ KPI CỬA HÀNG
        // ══════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Thiết lập cột cho bảng cảnh báo hàng tồn kho thấp trên Dashboard.
        /// </summary>
        private void thietLapCotCanhBaoKho()
        {
            dgvCanhBaoKho.Columns.Clear(); // Xóa sạch cột cũ
            dgvCanhBaoKho.Columns.Add("MaHang", "Mã Hàng"); // Cột mã hàng
            dgvCanhBaoKho.Columns.Add("TenSP", "Tên Sản Phẩm Thời Trang"); // Cột tên sản phẩm
            dgvCanhBaoKho.Columns.Add("LoaiSP", "Phân Loại"); // Cột chủng loại
            dgvCanhBaoKho.Columns.Add("SoLuongTon", "Tồn Kho"); // Cột số lượng tồn kho
            dgvCanhBaoKho.Columns.Add("GiaBan", "Giá Bán (đ)"); // Cột giá niêm yết
            dgvCanhBaoKho.Columns.Add("TrangThai", "Trạng Thái"); // Cột trạng thái kinh doanh

            dgvCanhBaoKho.Columns["MaHang"].Width = 80; // Độ rộng mã hàng
            dgvCanhBaoKho.Columns["TenSP"].Width = 200; // Độ rộng tên sản phẩm
            dgvCanhBaoKho.Columns["LoaiSP"].Width = 90; // Độ rộng phân loại
            dgvCanhBaoKho.Columns["SoLuongTon"].Width = 70; // Độ rộng tồn kho
            dgvCanhBaoKho.Columns["GiaBan"].Width = 95; // Độ rộng giá bán
            dgvCanhBaoKho.Columns["TrangThai"].Width = 90; // Độ rộng trạng thái

            dgvCanhBaoKho.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            dgvCanhBaoKho.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
        }

        /// <summary>
        /// Thiết lập cột cho bảng lịch sử đơn hàng bán gần đây trên Dashboard.
        /// </summary>
        private void thietLapCotGiaoDichMoi()
        {
            dgvGiaoDichMoi.Columns.Clear(); // Xóa sạch cột cũ
            dgvGiaoDichMoi.Columns.Add("MaHoaDon", "Mã Hóa Đơn"); // Cột mã hóa đơn
            dgvGiaoDichMoi.Columns.Add("NgayLap", "Ngày Bán"); // Cột thời gian lập hóa đơn
            dgvGiaoDichMoi.Columns.Add("TenKhachHang", "Khách Hàng"); // Cột họ tên khách hàng
            dgvGiaoDichMoi.Columns.Add("TenNhanVien", "Nhân Viên"); // Cột thu ngân
            dgvGiaoDichMoi.Columns.Add("ThanhTien", "Thực Thu (đ)"); // Cột số tiền thực tế
            dgvGiaoDichMoi.Columns.Add("TrangThai", "Trạng Thái"); // Cột tình trạng thanh toán

            dgvGiaoDichMoi.Columns["MaHoaDon"].Width = 110; // Chiều rộng mã hóa đơn
            dgvGiaoDichMoi.Columns["NgayLap"].Width = 120; // Chiều rộng ngày lập
            dgvGiaoDichMoi.Columns["TenKhachHang"].Width = 130; // Chiều rộng khách hàng
            dgvGiaoDichMoi.Columns["TenNhanVien"].Width = 110; // Chiều rộng nhân viên
            dgvGiaoDichMoi.Columns["ThanhTien"].Width = 100; // Chiều rộng thành tiền
            dgvGiaoDichMoi.Columns["TrangThai"].Width = 95; // Chiều rộng trạng thái

            dgvGiaoDichMoi.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
        }

        /// <summary>
        /// Tính toán và làm mới toàn bộ các chỉ số KPI cùng 2 bảng tóm tắt trên màn hình Tổng Quan.
        /// </summary>
        private void capNhatDashboard()
        {
            int tongLoaiSP = KhoDuLieu.DanhSachSanPham.Count; // Tổng số loại sản phẩm trong kho
            int tongChiecSP = 0; // Biến tính tổng số chiếc sản phẩm tồn kho
            foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt qua từng sản phẩm
            {
                tongChiecSP += sp.SoLuongTon; // Cộng dồn số lượng tồn kho
            }

            int tongKH = KhoDuLieu.DanhSachKhachHang.Count; // Tổng số khách hàng đã đăng ký

            NhanVien nvHienTai = authService.layNhanVienHienTai(); // Lấy nhân viên đăng nhập hiện tại
            if (nvHienTai != null && nvHienTai.ChucVu != null && nvHienTai.ChucVu.Equals("Thủ kho", StringComparison.OrdinalIgnoreCase)) // Nếu là thủ kho
            {
                lblKpiSPTieuDe.Text = "TỔNG LOẠI HÀNG HÓA"; // Tiêu đề sản phẩm kho
                lblKpiSPSoLuong.Text = tongLoaiSP + " Loại Hàng"; // Số loại hàng
                lblKpiSPGhiChu.Text = "Tổng tồn kho: " + tongChiecSP + " sản phẩm"; // Chú thích tổng số chiếc

                lblKpiKHTieuDe.Text = "ĐỐI TÁC CUNG ỨNG"; // Tiêu đề nhà cung cấp
                lblKpiKHSoLuong.Text = KhoDuLieu.DanhSachNhaCungCap.Count + " Nhà Cung Cấp"; // Số lượng NCC
                lblKpiKHGhiChu.Text = "Nguồn cung may mặc Việt Tiến"; // Ghi chú NCC

                decimal tongGiaTriTon = 0; // Biến tính tổng vốn tồn kho
                int soLuongTonThap = 0; // Số mặt hàng tồn thấp
                foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt qua các mặt hàng
                {
                    tongGiaTriTon += (sp.GiaNhap * sp.SoLuongTon); // Cộng dồn vốn
                    if (sp.SoLuongTon < 30) // Kiểm tra hàng tồn thấp
                    {
                        soLuongTonThap++; // Đếm số sản phẩm sắp hết
                    }
                }
                lblKpiDTTieuDe.Text = "GIÁ TRỊ TỒN KHO"; // Tiêu đề giá trị tồn kho
                lblKpiDTSoLuong.Text = tongGiaTriTon.ToString("N0") + " đ"; // Hiển thị tổng vốn tồn
                lblKpiDTGhiChu.Text = "Tổng giá vốn các mặt hàng trong kho"; // Chú thích giá vốn

                lblKpiHDTieuDe.Text = "CẢNH BÁO TỒN THẤP"; // Tiêu đề cảnh báo tồn kho
                lblKpiHDSoLuong.Text = soLuongTonThap + " Mặt Hàng"; // Số mặt hàng tồn thấp
                lblKpiHDGhiChu.Text = "Cần lập phiếu nhập kho bổ sung"; // Ghi chú nhập kho
            }
            else // Nếu là Quản lý hoặc Nhân viên bán hàng
            {
                lblKpiSPTieuDe.Text = "TỔNG SẢN PHẨM"; // Tiêu đề sản phẩm
                lblKpiSPSoLuong.Text = tongLoaiSP + " Loại Hàng"; // Cập nhật số loại hàng
                lblKpiSPGhiChu.Text = "Tổng tồn kho: " + tongChiecSP + " sản phẩm"; // Cập nhật số chiếc

                lblKpiKHTieuDe.Text = "KHÁCH HÀNG"; // Tiêu đề khách hàng
                lblKpiKHSoLuong.Text = tongKH + " Khách Hàng"; // Hiển thị số lượng khách hàng
                lblKpiKHGhiChu.Text = "Khách hàng VIP và thân thiết"; // Chú thích loại khách

                decimal tongDoanhThu = 0; // Biến tính tổng doanh thu bán hàng
                int tongHoaDonThanhCong = 0; // Biến đếm hóa đơn hoàn tất thanh toán
                foreach (HoaDon hd in KhoDuLieu.DanhSachHoaDon) // Duyệt từng hóa đơn
                {
                    if (hd.TrangThai != null && hd.TrangThai.Equals("Đã thanh toán", StringComparison.OrdinalIgnoreCase)) // Kiểm tra trạng thái đã thanh toán
                    {
                        tongDoanhThu += hd.ThanhTien; // Cộng dồn tiền thực thu
                        tongHoaDonThanhCong++; // Tăng biến đếm hóa đơn thành công
                    }
                }
                lblKpiDTTieuDe.Text = "DOANH THU"; // Tiêu đề doanh thu
                lblKpiDTSoLuong.Text = tongDoanhThu.ToString("N0") + " đ"; // Hiển thị doanh thu VNĐ
                lblKpiHDTieuDe.Text = "HÓA ĐƠN HOÀN TẤT"; // Tiêu đề hóa đơn
                lblKpiHDSoLuong.Text = tongHoaDonThanhCong + " Đơn Hàng"; // Hiển thị số đơn đã bán
                lblKpiHDGhiChu.Text = "Tỷ lệ hoàn tất đơn hàng: 100%"; // Ghi chú hoàn tất
            }

            // Tải danh sách cảnh báo sản phẩm có tồn kho thấp (< 30 chiếc)
            dgvCanhBaoKho.Rows.Clear(); // Xóa dữ liệu cũ
            foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Lặp qua danh mục sản phẩm
            {
                if (sp.SoLuongTon < 30) // Kiểm tra nếu số lượng tồn kho dưới 30
                {
                    int r = dgvCanhBaoKho.Rows.Add(); // Thêm dòng vào bảng cảnh báo
                    dgvCanhBaoKho.Rows[r].Cells["MaHang"].Value = sp.MaHang; // Gán mã hàng
                    dgvCanhBaoKho.Rows[r].Cells["TenSP"].Value = sp.TenSP; // Gán tên sản phẩm
                    dgvCanhBaoKho.Rows[r].Cells["LoaiSP"].Value = sp.LoaiSP; // Gán loại sản phẩm
                    dgvCanhBaoKho.Rows[r].Cells["SoLuongTon"].Value = sp.SoLuongTon; // Gán số tồn kho
                    dgvCanhBaoKho.Rows[r].Cells["GiaBan"].Value = sp.GiaBan.ToString("N0"); // Gán giá bán
                    dgvCanhBaoKho.Rows[r].Cells["TrangThai"].Value = sp.TrangThai; // Gán trạng thái
                    dgvCanhBaoKho.Rows[r].DefaultCellStyle.ForeColor = Color.FromArgb(185, 28, 28); // Đổi chữ màu đỏ cảnh báo
                }
            }

            // Tải danh sách các giao dịch hóa đơn bán hàng gần nhất
            dgvGiaoDichMoi.Rows.Clear(); // Xóa dữ liệu cũ
            for (int i = KhoDuLieu.DanhSachHoaDon.Count - 1; i >= 0; i--) // Duyệt ngược từ mới nhất
            {
                HoaDon hd = KhoDuLieu.DanhSachHoaDon[i]; // Lấy hóa đơn
                int r = dgvGiaoDichMoi.Rows.Add(); // Thêm dòng vào bảng
                dgvGiaoDichMoi.Rows[r].Cells["MaHoaDon"].Value = hd.MaHoaDon; // Gán mã hóa đơn
                dgvGiaoDichMoi.Rows[r].Cells["NgayLap"].Value = hd.NgayLap.ToString("dd/MM HH:mm"); // Gán ngày giờ
                dgvGiaoDichMoi.Rows[r].Cells["TenKhachHang"].Value = hd.TenKhachHang; // Gán tên khách hàng
                dgvGiaoDichMoi.Rows[r].Cells["TenNhanVien"].Value = hd.TenNhanVien; // Gán tên nhân viên
                dgvGiaoDichMoi.Rows[r].Cells["ThanhTien"].Value = hd.ThanhTien.ToString("N0"); // Gán thực thu
                dgvGiaoDichMoi.Rows[r].Cells["TrangThai"].Value = hd.TrangThai; // Gán trạng thái
            }
        }

        /// <summary>
        /// Nút tắt nhanh: Chuyển sang tab Hóa Đơn và lập ngay đơn bán hàng mới.
        /// </summary>
        private void btnQuickBanHangClick(object sender, EventArgs e)
        {
            NhanVien nvHienTai = authService.layNhanVienHienTai(); // Lấy nhân viên đăng nhập
            if (nvHienTai != null && nvHienTai.ChucVu != null && nvHienTai.ChucVu.Equals("Thủ kho", StringComparison.OrdinalIgnoreCase)) // Nếu là thủ kho
            {
                tabChinh.SelectedTab = tabSanPham; // Chuyển sang tab sản phẩm kho
                btnNhapKhoClick(sender, e); // Mở cửa sổ nhập kho
            }
            else // Nếu là quản lý hoặc nhân viên bán hàng
            {
                tabChinh.SelectedTab = tabHoaDon; // Chuyển sang tab Hóa Đơn
                btnTaoHDClick(sender, e); // Kích hoạt sự kiện lập hóa đơn mới
            }
        }

        /// <summary>
        /// Nút tắt nhanh: Chuyển sang tab Sản Phẩm để quản lý kho hàng.
        /// </summary>
        private void btnQuickThemSPClick(object sender, EventArgs e)
        {
            tabChinh.SelectedTab = tabSanPham; // Chuyển sang tab Sản Phẩm
        }

        /// <summary>
        /// Nút tắt nhanh: Chuyển sang tab Khách Hàng hoặc Nhà Cung Cấp cho Thủ kho.
        /// </summary>
        private void btnQuickKhachHangClick(object sender, EventArgs e)
        {
            NhanVien nvHienTai = authService.layNhanVienHienTai(); // Lấy nhân viên hiện tại
            if (nvHienTai != null && nvHienTai.ChucVu != null && nvHienTai.ChucVu.Equals("Thủ kho", StringComparison.OrdinalIgnoreCase)) // Nếu là thủ kho
            {
                tabChinh.SelectedTab = tabNhaCungCap; // Mở tab Nhà Cung Cấp cho Thủ kho
            }
            else // Nếu là các chức vụ khác
            {
                tabChinh.SelectedTab = tabKhachHang; // Chuyển sang tab Khách Hàng
            }
        }

        /// <summary>
        /// Nút làm mới dữ liệu thống kê Dashboard.
        /// </summary>
        private void btnQuickLamMoiKPIClick(object sender, EventArgs e)
        {
            capNhatDashboard(); // Gọi hàm cập nhật toàn diện
            lblStatusThongBao.Text = "Đã cập nhật các chỉ số tổng quan kinh doanh."; // Thông báo trạng thái
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  2. PHẦN QUẢN LÝ SẢN PHẨM THỜI TRANG VIỆT TIẾN
        // ══════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Thiết lập cấu trúc cột và cho phép chỉnh sửa trực tiếp trên DataGridView Sản Phẩm.
        /// </summary>
        private void thietLapCotSanPham()
        {
            dgvSanPham.Columns.Clear(); // Xóa sạch cột cũ

            DataGridViewTextBoxColumn cotId = new DataGridViewTextBoxColumn(); // Cột ID nội bộ
            cotId.Name = "MaSP"; // Tên định danh cột
            cotId.HeaderText = "ID"; // Tiêu đề cột
            cotId.Width = 50; // Chiều rộng 50 pixel
            cotId.ReadOnly = true; // Chỉ đọc không cho sửa
            dgvSanPham.Columns.Add(cotId); // Thêm cột vào bảng

            DataGridViewTextBoxColumn cotMa = new DataGridViewTextBoxColumn(); // Cột mã hàng
            cotMa.Name = "MaHang"; // Tên định danh cột
            cotMa.HeaderText = "Mã Hàng"; // Tiêu đề cột
            cotMa.Width = 90; // Chiều rộng 90 pixel
            dgvSanPham.Columns.Add(cotMa); // Thêm cột vào bảng

            DataGridViewTextBoxColumn cotTen = new DataGridViewTextBoxColumn(); // Cột tên sản phẩm
            cotTen.Name = "TenSP"; // Tên định danh cột
            cotTen.HeaderText = "Tên Sản Phẩm Thời Trang"; // Tiêu đề cột
            cotTen.Width = 220; // Chiều rộng 220 pixel
            dgvSanPham.Columns.Add(cotTen); // Thêm cột vào bảng

            DataGridViewTextBoxColumn cotLoai = new DataGridViewTextBoxColumn(); // Cột phân loại sản phẩm
            cotLoai.Name = "LoaiSP"; // Tên định danh cột
            cotLoai.HeaderText = "Loại SP"; // Tiêu đề cột
            cotLoai.Width = 110; // Chiều rộng 110 pixel
            dgvSanPham.Columns.Add(cotLoai); // Thêm cột vào bảng

            DataGridViewTextBoxColumn cotSize = new DataGridViewTextBoxColumn(); // Cột kích cỡ Size
            cotSize.Name = "Size"; // Tên định danh cột
            cotSize.HeaderText = "Size"; // Tiêu đề cột
            cotSize.Width = 70; // Chiều rộng 70 pixel
            cotSize.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            dgvSanPham.Columns.Add(cotSize); // Thêm cột vào bảng

            DataGridViewTextBoxColumn cotMau = new DataGridViewTextBoxColumn(); // Cột màu sắc
            cotMau.Name = "MauSacSP"; // Tên định danh cột
            cotMau.HeaderText = "Màu Sắc"; // Tiêu đề cột
            cotMau.Width = 100; // Chiều rộng 100 pixel
            dgvSanPham.Columns.Add(cotMau); // Thêm cột vào bảng

            DataGridViewTextBoxColumn cotChatLieu = new DataGridViewTextBoxColumn(); // Cột chất liệu vải
            cotChatLieu.Name = "ChatLieu"; // Tên định danh cột
            cotChatLieu.HeaderText = "Chất Liệu"; // Tiêu đề cột
            cotChatLieu.Width = 130; // Chiều rộng 130 pixel
            dgvSanPham.Columns.Add(cotChatLieu); // Thêm cột vào bảng

            DataGridViewTextBoxColumn cotGiaNhap = new DataGridViewTextBoxColumn(); // Cột giá vốn nhập
            cotGiaNhap.Name = "GiaNhap"; // Tên định danh cột
            cotGiaNhap.HeaderText = "Giá Nhập (đ)"; // Tiêu đề cột
            cotGiaNhap.Width = 110; // Chiều rộng 110 pixel
            cotGiaNhap.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
            dgvSanPham.Columns.Add(cotGiaNhap); // Thêm cột vào bảng

            DataGridViewTextBoxColumn cotGiaBan = new DataGridViewTextBoxColumn(); // Cột giá bán lẻ
            cotGiaBan.Name = "GiaBan"; // Tên định danh cột
            cotGiaBan.HeaderText = "Giá Bán (đ)"; // Tiêu đề cột
            cotGiaBan.Width = 110; // Chiều rộng 110 pixel
            cotGiaBan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
            dgvSanPham.Columns.Add(cotGiaBan); // Thêm cột vào bảng

            DataGridViewTextBoxColumn cotTon = new DataGridViewTextBoxColumn(); // Cột số lượng tồn kho
            cotTon.Name = "SoLuongTon"; // Tên định danh cột
            cotTon.HeaderText = "Tồn Kho"; // Tiêu đề cột
            cotTon.Width = 80; // Chiều rộng 80 pixel
            cotTon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            dgvSanPham.Columns.Add(cotTon); // Thêm cột vào bảng

            DataGridViewTextBoxColumn cotTrangThai = new DataGridViewTextBoxColumn(); // Cột trạng thái kinh doanh
            cotTrangThai.Name = "TrangThai"; // Tên định danh cột
            cotTrangThai.HeaderText = "Trạng Thái"; // Tiêu đề cột
            cotTrangThai.Width = 100; // Chiều rộng 100 pixel
            dgvSanPham.Columns.Add(cotTrangThai); // Thêm cột vào bảng
        }

        /// <summary>
        /// Nạp dữ liệu sản phẩm lên DataGridView kết hợp lọc từ khóa và ComboBox loại hàng.
        /// </summary>
        public void loadDataSanPham(string tuKhoa)
        {
            dgvSanPham.Rows.Clear(); // Xóa sạch các dòng hiện tại
            List<SanPham> ds = sanPhamService.timKiem(tuKhoa); // Tìm kiếm theo từ khóa trong Service

            string loaiLoc = cboLocLoaiSP.SelectedItem != null ? cboLocLoaiSP.SelectedItem.ToString() : "Tất cả loại"; // Lấy phân loại đang lọc

            foreach (SanPham sp in ds) // Duyệt qua từng sản phẩm
            {
                // Kiểm tra điều kiện lọc theo phân loại sản phẩm
                if (!loaiLoc.Equals("Tất cả loại") && !loaiLoc.Equals("Tất cả") && sp.LoaiSP != null && !sp.LoaiSP.Equals(loaiLoc, StringComparison.OrdinalIgnoreCase))
                {
                    continue; // Bỏ qua sản phẩm không khớp loại đang lọc
                }

                int idx = dgvSanPham.Rows.Add(); // Thêm dòng mới vào bảng
                DataGridViewRow row = dgvSanPham.Rows[idx]; // Lấy tham chiếu đến dòng vừa thêm

                row.Cells["MaSP"].Value = sp.MaSP; // Gán ID sản phẩm
                row.Cells["MaHang"].Value = sp.MaHang; // Gán mã hàng
                row.Cells["TenSP"].Value = sp.TenSP; // Gán tên sản phẩm
                row.Cells["LoaiSP"].Value = sp.LoaiSP; // Gán phân loại
                row.Cells["Size"].Value = sp.Size; // Gán kích cỡ
                row.Cells["MauSacSP"].Value = sp.MauSacSP; // Gán màu sắc
                row.Cells["ChatLieu"].Value = sp.ChatLieu; // Gán chất liệu
                row.Cells["GiaNhap"].Value = sp.GiaNhap.ToString("N0"); // Gán giá nhập có dấu phân cách
                row.Cells["GiaBan"].Value = sp.GiaBan.ToString("N0"); // Gán giá bán có dấu phân cách
                row.Cells["SoLuongTon"].Value = sp.SoLuongTon; // Gán tồn kho
                row.Cells["TrangThai"].Value = sp.TrangThai; // Gán trạng thái
            }
        }

        /// <summary>
        /// Sự kiện thay đổi lựa chọn ComboBox phân loại sản phẩm.
        /// </summary>
        private void cboLocLoaiSPSelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataSanPham(txtTimSP.Text.Trim()); // Nạp lại danh sách theo loại vừa chọn
        }

        /// <summary>
        /// Nút tìm kiếm sản phẩm theo từ khóa.
        /// </summary>
        private void btnTimSPClick(object sender, EventArgs e)
        {
            loadDataSanPham(txtTimSP.Text.Trim()); // Gọi hàm nạp dữ liệu với từ khóa tìm kiếm
        }

        /// <summary>
        /// Nhấn phím Enter trong ô tìm kiếm sản phẩm để kích hoạt tìm nhanh.
        /// </summary>
        private void txtTimSPKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTimSPClick(sender, EventArgs.Empty); // Gọi hàm tìm
        }

        /// <summary>
        /// Nút làm mới danh sách sản phẩm về trạng thái đầy đủ ban đầu.
        /// </summary>
        private void btnLamMoiSPClick(object sender, EventArgs e)
        {
            txtTimSP.Clear(); // Xóa sạch từ khóa tìm kiếm
            if (cboLocLoaiSP.Items.Count > 0) cboLocLoaiSP.SelectedIndex = 0; // Đặt lại về Tất cả loại
            loadDataSanPham(""); // Tải lại toàn bộ dữ liệu
            lblStatusThongBao.Text = "Đã làm mới danh sách sản phẩm."; // Thông báo trạng thái
        }

        /// <summary>
        /// Bắt sự kiện người dùng gõ chỉnh sửa trực tiếp trên ô của bảng sản phẩm.
        /// Tự động bật sáng nút Lưu để người dùng nhấn xác nhận lưu thay đổi.
        /// </summary>
        private void dgvSanPhamCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra thay đổi nằm trên dòng hợp lệ
            {
                btnLuuSP.Enabled = true; // Kích hoạt nút Lưu sáng lên
                lblStatusThongBao.Text = "Có thay đổi tại bảng sản phẩm. Vui lòng nhấn nút 'Lưu' để cập nhật."; // Hướng dẫn
            }
        }

        /// <summary>
        /// Nút THÊM MỚI sản phẩm: Chèn trực tiếp một dòng mới trên DataGridView.
        /// Người dùng nhập liệu ngay trên bảng rồi nhấn nút Lưu.
        /// </summary>
        private void btnThemSPClick(object sender, EventArgs e)
        {
            int idx = dgvSanPham.Rows.Add(); // Thêm dòng mới vào bảng
            DataGridViewRow row = dgvSanPham.Rows[idx]; // Lấy dòng mới

            row.Cells["MaSP"].Value = 0; // Gán ID = 0 đại diện cho sản phẩm mới
            row.Cells["MaHang"].Value = "VT" + DateTime.Now.ToString("HHmmss"); // Tạo mã hàng tạm
            row.Cells["TenSP"].Value = "Áo Sơ Mi Nam Mới"; // Tên mặc định
            row.Cells["LoaiSP"].Value = "Áo sơ mi"; // Loại mặc định
            row.Cells["Size"].Value = "L"; // Size mặc định
            row.Cells["MauSacSP"].Value = "Trắng"; // Màu mặc định
            row.Cells["ChatLieu"].Value = "Cotton"; // Chất liệu mặc định
            row.Cells["GiaNhap"].Value = "150.000"; // Giá nhập mặc định
            row.Cells["GiaBan"].Value = "300.000"; // Giá bán mặc định
            row.Cells["SoLuongTon"].Value = 10; // Tồn kho mặc định
            row.Cells["TrangThai"].Value = "Đang bán"; // Trạng thái mặc định

            dgvSanPham.ClearSelection(); // Hủy chọn dòng cũ
            row.Selected = true; // Bôi xanh chọn dòng mới
            dgvSanPham.CurrentCell = row.Cells["TenSP"]; // Đặt con trỏ vào ô Tên Sản Phẩm để gõ ngay

            btnLuuSP.Enabled = true; // Bật nút Lưu sáng lên
            lblStatusThongBao.Text = "Đã thêm dòng sản phẩm mới. Vui lòng chỉnh sửa và nhấn nút 'Lưu'."; // Hướng dẫn
        }

        /// <summary>
        /// Nút LƯU dữ liệu Sản Phẩm đã thêm mới hoặc chỉnh sửa trực tiếp trên DataGridView.
        /// </summary>
        private void btnLuuSPClick(object sender, EventArgs e)
        {
            try
            {
                dgvSanPham.EndEdit(); // Kết thúc chỉnh sửa ô hiện tại để chốt dữ liệu
                int soLuu = 0; // Biến đếm số lượng bản ghi lưu thành công

                for (int i = 0; i < dgvSanPham.Rows.Count; i++) // Duyệt từng dòng trên bảng
                {
                    DataGridViewRow row = dgvSanPham.Rows[i]; // Lấy dòng
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới trống

                    int maSP = 0; // Khởi tạo mã ID
                    if (row.Cells["MaSP"].Value != null) int.TryParse(row.Cells["MaSP"].Value.ToString(), out maSP); // Ép kiểu ID

                    string maHang = row.Cells["MaHang"].Value != null ? row.Cells["MaHang"].Value.ToString().Trim() : ""; // Lấy mã hàng
                    string tenSP = row.Cells["TenSP"].Value != null ? row.Cells["TenSP"].Value.ToString().Trim() : ""; // Lấy tên sản phẩm
                    string loaiSP = row.Cells["LoaiSP"].Value != null ? row.Cells["LoaiSP"].Value.ToString().Trim() : "Áo sơ mi"; // Lấy phân loại
                    string size = row.Cells["Size"].Value != null ? row.Cells["Size"].Value.ToString().Trim() : "M"; // Lấy kích cỡ
                    string mauSac = row.Cells["MauSacSP"].Value != null ? row.Cells["MauSacSP"].Value.ToString().Trim() : "Trắng"; // Lấy màu sắc
                    string chatLieu = row.Cells["ChatLieu"].Value != null ? row.Cells["ChatLieu"].Value.ToString().Trim() : "Cotton"; // Lấy chất liệu

                    string giaNhapText = row.Cells["GiaNhap"].Value != null ? row.Cells["GiaNhap"].Value.ToString().Replace(".", "").Replace(",", "").Trim() : "0"; // Làm sạch chuỗi giá nhập
                    decimal giaNhap = 0; // Khởi tạo giá nhập
                    decimal.TryParse(giaNhapText, out giaNhap); // Ép kiểu giá nhập

                    string giaBanText = row.Cells["GiaBan"].Value != null ? row.Cells["GiaBan"].Value.ToString().Replace(".", "").Replace(",", "").Trim() : "0"; // Làm sạch chuỗi giá bán
                    decimal giaBan = 0; // Khởi tạo giá bán
                    decimal.TryParse(giaBanText, out giaBan); // Ép kiểu giá bán

                    string tonText = row.Cells["SoLuongTon"].Value != null ? row.Cells["SoLuongTon"].Value.ToString().Trim() : "0"; // Lấy chuỗi tồn kho
                    int soTon = 0; // Khởi tạo số lượng tồn
                    int.TryParse(tonText, out soTon); // Ép kiểu số tồn

                    string trangThai = row.Cells["TrangThai"].Value != null ? row.Cells["TrangThai"].Value.ToString() : "Đang bán"; // Lấy trạng thái

                    if (string.IsNullOrEmpty(tenSP)) // Kiểm tra hợp lệ tên sản phẩm không được rỗng
                    {
                        MessageBox.Show("Dòng " + (i + 1) + ": Tên sản phẩm không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Dừng nếu dữ liệu không hợp lệ
                    }

                    string thongBaoLoi; // Biến nhận thông báo lỗi từ Service
                    if (maSP == 0) // Trường hợp thêm mới sản phẩm
                    {
                        SanPham spMoi = new SanPham // Tạo mới thực thể sản phẩm
                        {
                            MaHang = maHang,
                            TenSP = tenSP,
                            LoaiSP = loaiSP,
                            Size = size,
                            MauSacSP = mauSac,
                            ChatLieu = chatLieu,
                            GiaNhap = giaNhap,
                            GiaBan = giaBan,
                            SoLuongTon = soTon,
                            TrangThai = trangThai
                        };
                        sanPhamService.themSanPham(spMoi, out thongBaoLoi); // Gọi Service thêm sản phẩm
                        soLuu++; // Tăng biến đếm số bản ghi đã lưu
                    }
                    else // Trường hợp cập nhật sản phẩm đã tồn tại
                    {
                        SanPham spSua = sanPhamService.layTheoId(maSP); // Lấy đối tượng từ kho theo ID
                        if (spSua != null) // Nếu tìm thấy sản phẩm
                        {
                            spSua.MaHang = maHang; // Cập nhật mã hàng
                            spSua.TenSP = tenSP; // Cập nhật tên sản phẩm
                            spSua.LoaiSP = loaiSP; // Cập nhật phân loại
                            spSua.Size = size; // Cập nhật size
                            spSua.MauSacSP = mauSac; // Cập nhật màu sắc
                            spSua.ChatLieu = chatLieu; // Cập nhật chất liệu
                            spSua.GiaNhap = giaNhap; // Cập nhật giá nhập
                            spSua.GiaBan = giaBan; // Cập nhật giá bán
                            spSua.SoLuongTon = soTon; // Cập nhật tồn kho
                            spSua.TrangThai = trangThai; // Cập nhật trạng thái
                            sanPhamService.suaSanPham(spSua, out thongBaoLoi); // Gọi Service sửa sản phẩm
                            soLuu++; // Tăng biến đếm số bản ghi đã lưu
                        }
                    }
                }

                btnLuuSP.Enabled = false; // Tắt nút Lưu sau khi đã hoàn tất
                loadDataSanPham(txtTimSP.Text.Trim()); // Tải lại danh sách sản phẩm hiển thị chuẩn
                capNhatDashboard(); // Cập nhật lại số liệu Dashboard và tồn kho
                capNhatThongKe(); // Cập nhật lại số liệu Thống Kê
                MessageBox.Show("Lưu dữ liệu sản phẩm thành công (" + soLuu + " bản ghi)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa sản phẩm thời trang đang được chọn trên DataGridView.
        /// </summary>
        private void btnXoaSPClick(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) // Kiểm tra người dùng đã chọn dòng nào chưa
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trên bảng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSP = 0; // Khởi tạo mã ID
            if (dgvSanPham.CurrentRow.Cells["MaSP"].Value != null) int.TryParse(dgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString(), out maSP);
            string tenSP = dgvSanPham.CurrentRow.Cells["TenSP"].Value != null ? dgvSanPham.CurrentRow.Cells["TenSP"].Value.ToString() : "";

            // Hiển thị hộp thoại xác nhận xóa an toàn
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm thời trang:\n" + tenSP + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) // Nếu người dùng chọn Yes
            {
                if (maSP > 0) // Nếu là sản phẩm đã lưu trong CSDL
                {
                    string thongBaoLoi; // Biến nhận lỗi
                    sanPhamService.xoaSanPham(maSP, out thongBaoLoi); // Gọi Service xóa sản phẩm
                }
                loadDataSanPham(txtTimSP.Text.Trim()); // Nạp lại bảng sản phẩm
                capNhatDashboard(); // Cập nhật lại Dashboard
                capNhatThongKe(); // Cập nhật lại Thống Kê
                lblStatusThongBao.Text = "Đã xóa sản phẩm thành công."; // Báo trạng thái
            }
        }

        private bool dangLocTonThap = false; // Cờ kiểm tra trạng thái đang lọc tồn kho thấp

        /// <summary>
        /// Nghiệp vụ mở cửa sổ nhập thêm hàng hóa vào kho cho Thủ kho và Quản lý.
        /// </summary>
        private void btnNhapKhoClick(object sender, EventArgs e)
        {
            string maHang = ""; // Chuỗi mã hàng mặc định
            if (dgvSanPham.CurrentRow != null && dgvSanPham.CurrentRow.Cells["MaHang"] != null && dgvSanPham.CurrentRow.Cells["MaHang"].Value != null)
            {
                maHang = dgvSanPham.CurrentRow.Cells["MaHang"].Value.ToString(); // Lấy mã hàng dòng đang chọn
            }

            using (FormNhapKho formNhap = new FormNhapKho(maHang)) // Khởi tạo form nhập kho
            {
                if (formNhap.ShowDialog(this) == DialogResult.OK) // Hiển thị dưới dạng modal
                {
                    loadDataSanPham(txtTimSP.Text.Trim()); // Nạp lại danh sách sản phẩm
                    capNhatDashboard(); // Cập nhật Dashboard KPI và cảnh báo kho
                    capNhatThongKe(); // Cập nhật Thống Kê
                    if (pnlBieuDoThongKe != null) pnlBieuDoThongKe.Invalidate(); // Vẽ lại biểu đồ
                }
            }
        }

        /// <summary>
        /// Nghiệp vụ lọc nhanh danh sách sản phẩm có số lượng tồn kho thấp dưới 30 chiếc.
        /// </summary>
        private void btnLocHangTonThapClick(object sender, EventArgs e)
        {
            if (!dangLocTonThap) // Nếu chưa bật chế độ lọc
            {
                dangLocTonThap = true; // Đánh dấu cờ đang lọc
                btnLocHangTonThap.Text = "Xem Tất Cả"; // Đổi nhãn nút
                btnLocHangTonThap.BackColor = Color.FromArgb(71, 85, 105); // Đổi màu xám Slate
                locSanPhamTonThap(); // Gọi hàm lọc
            }
            else // Nếu đang lọc thì hủy lọc
            {
                dangLocTonThap = false; // Tắt cờ lọc
                btnLocHangTonThap.Text = "Tồn Thấp (<30)"; // Khôi phục nhãn nút
                btnLocHangTonThap.BackColor = Color.FromArgb(217, 119, 6); // Khôi phục màu cam Amber
                loadDataSanPham(txtTimSP.Text.Trim()); // Nạp lại toàn bộ
            }
        }

        /// <summary>
        /// Lọc và hiển thị riêng các mặt hàng có số lượng tồn kho dưới 30 chiếc lên DataGridView.
        /// </summary>
        private void locSanPhamTonThap()
        {
            dgvSanPham.Rows.Clear(); // Xóa sạch dữ liệu cũ trên bảng
            foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt qua danh mục
            {
                if (sp.SoLuongTon < 30) // Kiểm tra điều kiện tồn kho thấp
                {
                    int idx = dgvSanPham.Rows.Add(); // Thêm dòng
                    DataGridViewRow row = dgvSanPham.Rows[idx]; // Tham chiếu dòng
                    row.Cells["MaSP"].Value = sp.MaSP; // Gán ID
                    row.Cells["MaHang"].Value = sp.MaHang; // Gán mã
                    row.Cells["TenSP"].Value = sp.TenSP; // Gán tên
                    row.Cells["LoaiSP"].Value = sp.LoaiSP; // Gán loại
                    row.Cells["Size"].Value = sp.Size; // Gán size
                    row.Cells["MauSacSP"].Value = sp.MauSacSP; // Gán màu
                    row.Cells["ChatLieu"].Value = sp.ChatLieu; // Gán chất liệu
                    row.Cells["GiaNhap"].Value = sp.GiaNhap.ToString("N0"); // Gán giá nhập
                    row.Cells["GiaBan"].Value = sp.GiaBan.ToString("N0"); // Gán giá bán
                    row.Cells["SoLuongTon"].Value = sp.SoLuongTon; // Gán tồn kho
                    row.Cells["TrangThai"].Value = sp.TrangThai; // Gán trạng thái
                }
            }
            btnLuuSP.Enabled = false; // Tắt nút Lưu
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  3. PHẦN QUẢN LÝ KHÁCH HÀNG THÂN THIẾT (CRM)
        // ══════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Thiết lập cấu trúc cột cho DataGridView Khách Hàng.
        /// </summary>
        private void thietLapCotKhachHang()
        {
            dgvKhachHang.Columns.Clear(); // Xóa sạch cột cũ

            DataGridViewTextBoxColumn cotId = new DataGridViewTextBoxColumn(); // Cột ID
            cotId.Name = "MaKH"; // Tên định danh
            cotId.HeaderText = "ID"; // Tiêu đề cột
            cotId.Width = 50; // Chiều rộng
            cotId.ReadOnly = true; // Chỉ đọc
            dgvKhachHang.Columns.Add(cotId); // Thêm vào bảng

            DataGridViewTextBoxColumn cotMa = new DataGridViewTextBoxColumn(); // Cột mã khách hàng
            cotMa.Name = "MaKhachHang"; // Tên định danh
            cotMa.HeaderText = "Mã KH"; // Tiêu đề cột
            cotMa.Width = 90; // Chiều rộng
            dgvKhachHang.Columns.Add(cotMa); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTen = new DataGridViewTextBoxColumn(); // Cột họ tên
            cotTen.Name = "HoTen"; // Tên định danh
            cotTen.HeaderText = "Họ Và Tên"; // Tiêu đề cột
            cotTen.Width = 180; // Chiều rộng
            dgvKhachHang.Columns.Add(cotTen); // Thêm vào bảng

            DataGridViewTextBoxColumn cotSDT = new DataGridViewTextBoxColumn(); // Cột số điện thoại
            cotSDT.Name = "SoDienThoai"; // Tên định danh
            cotSDT.HeaderText = "Số Điện Thoại"; // Tiêu đề cột
            cotSDT.Width = 120; // Chiều rộng
            dgvKhachHang.Columns.Add(cotSDT); // Thêm vào bảng

            DataGridViewTextBoxColumn cotEmail = new DataGridViewTextBoxColumn(); // Cột Email
            cotEmail.Name = "Email"; // Tên định danh
            cotEmail.HeaderText = "Email"; // Tiêu đề cột
            cotEmail.Width = 160; // Chiều rộng
            dgvKhachHang.Columns.Add(cotEmail); // Thêm vào bảng

            DataGridViewTextBoxColumn cotDiaChi = new DataGridViewTextBoxColumn(); // Cột địa chỉ
            cotDiaChi.Name = "DiaChi"; // Tên định danh
            cotDiaChi.HeaderText = "Địa Chỉ"; // Tiêu đề cột
            cotDiaChi.Width = 220; // Chiều rộng
            dgvKhachHang.Columns.Add(cotDiaChi); // Thêm vào bảng

            DataGridViewTextBoxColumn cotDiem = new DataGridViewTextBoxColumn(); // Cột điểm tích lũy
            cotDiem.Name = "DiemTichLuy"; // Tên định danh
            cotDiem.HeaderText = "Điểm Thưởng"; // Tiêu đề cột
            cotDiem.Width = 110; // Chiều rộng
            cotDiem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            dgvKhachHang.Columns.Add(cotDiem); // Thêm vào bảng

            DataGridViewTextBoxColumn cotLoai = new DataGridViewTextBoxColumn(); // Cột hạng khách hàng
            cotLoai.Name = "LoaiKhach"; // Tên định danh
            cotLoai.HeaderText = "Xếp Hạng"; // Tiêu đề cột
            cotLoai.Width = 110; // Chiều rộng
            dgvKhachHang.Columns.Add(cotLoai); // Thêm vào bảng
        }

        /// <summary>
        /// Nạp danh sách khách hàng lên DataGridView.
        /// </summary>
        public void loadDataKhachHang(string tuKhoa)
        {
            dgvKhachHang.Rows.Clear(); // Xóa sạch dữ liệu cũ trên bảng
            List<KhachHang> ds = khachHangService.timKiem(tuKhoa); // Gọi Service tìm khách hàng

            foreach (KhachHang kh in ds) // Duyệt qua từng khách hàng
            {
                int idx = dgvKhachHang.Rows.Add(); // Thêm dòng mới
                DataGridViewRow row = dgvKhachHang.Rows[idx]; // Lấy dòng vừa thêm

                row.Cells["MaKH"].Value = kh.MaKH; // Gán ID
                row.Cells["MaKhachHang"].Value = kh.MaKhachHang; // Gán mã khách hàng
                row.Cells["HoTen"].Value = kh.HoTen; // Gán họ tên
                row.Cells["SoDienThoai"].Value = kh.SoDienThoai; // Gán số điện thoại
                row.Cells["Email"].Value = kh.Email; // Gán email
                row.Cells["DiaChi"].Value = kh.DiaChi; // Gán địa chỉ
                row.Cells["DiemTichLuy"].Value = kh.DiemTichLuy; // Gán điểm tích lũy
                row.Cells["LoaiKhach"].Value = kh.LoaiKhach; // Gán hạng khách hàng
            }
        }

        private void btnTimKHClick(object sender, EventArgs e)
        {
            loadDataKhachHang(txtTimKH.Text.Trim()); // Tìm khách hàng theo từ khóa
        }

        private void txtTimKHKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTimKHClick(sender, EventArgs.Empty); // Nhấn Enter để tìm
        }

        private void btnLamMoiKHClick(object sender, EventArgs e)
        {
            txtTimKH.Clear(); // Xóa từ khóa
            loadDataKhachHang(""); // Nạp lại toàn bộ khách hàng
            lblStatusThongBao.Text = "Đã làm mới danh sách khách hàng."; // Thông báo
        }

        private void dgvKhachHangCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra dòng hợp lệ
            {
                btnLuuKH.Enabled = true; // Bật nút Lưu sáng lên
                lblStatusThongBao.Text = "Có thay đổi tại bảng khách hàng. Nhấn nút 'Lưu' để cập nhật."; // Thông báo
            }
        }

        private void btnThemKHClick(object sender, EventArgs e)
        {
            int idx = dgvKhachHang.Rows.Add(); // Thêm dòng mới vào bảng
            DataGridViewRow row = dgvKhachHang.Rows[idx]; // Lấy dòng vừa thêm

            row.Cells["MaKH"].Value = 0; // ID = 0 đánh dấu thêm mới
            row.Cells["MaKhachHang"].Value = "KH" + DateTime.Now.ToString("HHmmss"); // Sinh mã tạm
            row.Cells["HoTen"].Value = "Khách Hàng Mới"; // Tên mặc định
            row.Cells["SoDienThoai"].Value = "0900000000"; // SĐT mặc định
            row.Cells["Email"].Value = "khach@gmail.com"; // Email mặc định
            row.Cells["DiaChi"].Value = "Hà Nội"; // Địa chỉ mặc định
            row.Cells["DiemTichLuy"].Value = 0; // Điểm tích lũy 0
            row.Cells["LoaiKhach"].Value = "Thường"; // Hạng mặc định

            dgvKhachHang.ClearSelection(); // Hủy chọn dòng cũ
            row.Selected = true; // Chọn dòng mới
            dgvKhachHang.CurrentCell = row.Cells["HoTen"]; // Đặt con trỏ vào ô Họ Tên

            btnLuuKH.Enabled = true; // Bật nút Lưu
            lblStatusThongBao.Text = "Đã thêm dòng mới. Chỉnh sửa thông tin khách hàng rồi nhấn nút 'Lưu'."; // Hướng dẫn
        }

        private void btnLuuKHClick(object sender, EventArgs e)
        {
            try
            {
                dgvKhachHang.EndEdit(); // Kết thúc sửa ô
                int soLuu = 0; // Biến đếm bản ghi

                for (int i = 0; i < dgvKhachHang.Rows.Count; i++) // Duyệt từng dòng
                {
                    DataGridViewRow row = dgvKhachHang.Rows[i]; // Lấy dòng
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới

                    int maKH = 0;
                    if (row.Cells["MaKH"].Value != null) int.TryParse(row.Cells["MaKH"].Value.ToString(), out maKH);

                    string ma = row.Cells["MaKhachHang"].Value != null ? row.Cells["MaKhachHang"].Value.ToString().Trim() : "";
                    string ten = row.Cells["HoTen"].Value != null ? row.Cells["HoTen"].Value.ToString().Trim() : "";
                    string dt = row.Cells["SoDienThoai"].Value != null ? row.Cells["SoDienThoai"].Value.ToString().Trim() : "";
                    string mail = row.Cells["Email"].Value != null ? row.Cells["Email"].Value.ToString().Trim() : "";
                    string dc = row.Cells["DiaChi"].Value != null ? row.Cells["DiaChi"].Value.ToString().Trim() : "";
                    string diemText = row.Cells["DiemTichLuy"].Value != null ? row.Cells["DiemTichLuy"].Value.ToString().Trim() : "0";
                    int diem = 0;
                    int.TryParse(diemText, out diem);
                    string loai = row.Cells["LoaiKhach"].Value != null ? row.Cells["LoaiKhach"].Value.ToString() : "Thường";

                    if (string.IsNullOrEmpty(ten)) // Kiểm tra rỗng họ tên
                    {
                        MessageBox.Show("Dòng " + (i + 1) + ": Họ tên khách hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string thongBaoLoi;
                    if (maKH == 0) // Thêm mới
                    {
                        KhachHang khMoi = new KhachHang
                        {
                            MaKhachHang = ma,
                            HoTen = ten,
                            SoDienThoai = dt,
                            Email = mail,
                            DiaChi = dc,
                            DiemTichLuy = diem,
                            LoaiKhach = loai
                        };
                        khachHangService.themKhachHang(khMoi, out thongBaoLoi); // Gọi Service thêm khách hàng
                        soLuu++; // Tăng biến đếm
                    }
                    else // Cập nhật
                    {
                        KhachHang khSua = khachHangService.layTheoId(maKH); // Lấy khách hàng theo ID
                        if (khSua != null)
                        {
                            khSua.MaKhachHang = ma; // Cập nhật mã
                            khSua.HoTen = ten; // Cập nhật họ tên
                            khSua.SoDienThoai = dt; // Cập nhật SĐT
                            khSua.Email = mail; // Cập nhật email
                            khSua.DiaChi = dc; // Cập nhật địa chỉ
                            khSua.DiemTichLuy = diem; // Cập nhật điểm
                            khSua.LoaiKhach = loai; // Cập nhật hạng
                            khachHangService.suaKhachHang(khSua, out thongBaoLoi); // Gọi Service sửa khách hàng
                            soLuu++; // Tăng biến đếm
                        }
                    }
                }

                btnLuuKH.Enabled = false; // Tắt nút Lưu
                loadDataKhachHang(txtTimKH.Text.Trim()); // Tải lại danh sách
                capNhatDashboard(); // Cập nhật lại chỉ số Dashboard
                MessageBox.Show("Lưu thông tin khách hàng thành công (" + soLuu + " bản ghi)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKHClick(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) // Kiểm tra đã chọn dòng chưa
            {
                MessageBox.Show("Vui lòng chọn khách hàng trên bảng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maKH = 0;
            if (dgvKhachHang.CurrentRow.Cells["MaKH"].Value != null) int.TryParse(dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString(), out maKH);
            string hoTen = dgvKhachHang.CurrentRow.Cells["HoTen"].Value != null ? dgvKhachHang.CurrentRow.Cells["HoTen"].Value.ToString() : "";

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng:\n" + hoTen + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) // Nếu người dùng xác nhận xóa
            {
                if (maKH > 0)
                {
                    string thongBaoLoi;
                    khachHangService.xoaKhachHang(maKH, out thongBaoLoi); // Gọi Service xóa khách hàng
                }
                loadDataKhachHang(txtTimKH.Text.Trim()); // Tải lại bảng
                capNhatDashboard(); // Cập nhật Dashboard
                lblStatusThongBao.Text = "Đã xóa khách hàng thành công."; // Báo trạng thái
            }
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  4. PHẦN QUẢN LÝ NHÀ CUNG CẤP VẬT TƯ MAY MẶC
        // ══════════════════════════════════════════════════════════════════════════

        private void thietLapCotNhaCungCap()
        {
            dgvNhaCungCap.Columns.Clear(); // Xóa sạch cột cũ

            DataGridViewTextBoxColumn cotId = new DataGridViewTextBoxColumn(); // Cột ID
            cotId.Name = "MaNCC"; // Tên định danh
            cotId.HeaderText = "ID"; // Tiêu đề cột
            cotId.Width = 50; // Chiều rộng
            cotId.ReadOnly = true; // Chỉ đọc
            dgvNhaCungCap.Columns.Add(cotId); // Thêm vào bảng

            DataGridViewTextBoxColumn cotMa = new DataGridViewTextBoxColumn(); // Cột mã đối tác
            cotMa.Name = "MaNhaCungCap"; // Tên định danh
            cotMa.HeaderText = "Mã NCC"; // Tiêu đề cột
            cotMa.Width = 90; // Chiều rộng
            dgvNhaCungCap.Columns.Add(cotMa); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTen = new DataGridViewTextBoxColumn(); // Cột tên công ty
            cotTen.Name = "TenNCC"; // Tên định danh
            cotTen.HeaderText = "Tên Nhà Cung Cấp May Mặc"; // Tiêu đề cột
            cotTen.Width = 220; // Chiều rộng
            dgvNhaCungCap.Columns.Add(cotTen); // Thêm vào bảng

            DataGridViewTextBoxColumn cotDT = new DataGridViewTextBoxColumn(); // Cột số điện thoại
            cotDT.Name = "DienThoai"; // Tên định danh
            cotDT.HeaderText = "Điện Thoại"; // Tiêu đề cột
            cotDT.Width = 120; // Chiều rộng
            dgvNhaCungCap.Columns.Add(cotDT); // Thêm vào bảng

            DataGridViewTextBoxColumn cotMail = new DataGridViewTextBoxColumn(); // Cột Email
            cotMail.Name = "Email"; // Tên định danh
            cotMail.HeaderText = "Email"; // Tiêu đề cột
            cotMail.Width = 160; // Chiều rộng
            dgvNhaCungCap.Columns.Add(cotMail); // Thêm vào bảng

            DataGridViewTextBoxColumn cotDC = new DataGridViewTextBoxColumn(); // Cột địa chỉ trụ sở
            cotDC.Name = "DiaChi"; // Tên định danh
            cotDC.HeaderText = "Địa Chỉ"; // Tiêu đề cột
            cotDC.Width = 200; // Chiều rộng
            dgvNhaCungCap.Columns.Add(cotDC); // Thêm vào bảng

            DataGridViewTextBoxColumn cotMST = new DataGridViewTextBoxColumn(); // Cột mã số thuế
            cotMST.Name = "MaSoThue"; // Tên định danh
            cotMST.HeaderText = "Mã Số Thuế"; // Tiêu đề cột
            cotMST.Width = 110; // Chiều rộng
            dgvNhaCungCap.Columns.Add(cotMST); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTT = new DataGridViewTextBoxColumn(); // Cột tình trạng hợp tác
            cotTT.Name = "TrangThai"; // Tên định danh
            cotTT.HeaderText = "Trạng Thái"; // Tiêu đề cột
            cotTT.Width = 110; // Chiều rộng
            dgvNhaCungCap.Columns.Add(cotTT); // Thêm vào bảng
        }

        public void loadDataNhaCungCap(string tuKhoa)
        {
            dgvNhaCungCap.Rows.Clear(); // Xóa dòng cũ
            List<NhaCungCap> ds = nhaCungCapService.timKiem(tuKhoa); // Gọi Service tìm nhà cung cấp

            foreach (NhaCungCap ncc in ds) // Lặp qua danh sách
            {
                int idx = dgvNhaCungCap.Rows.Add(); // Thêm dòng mới
                DataGridViewRow row = dgvNhaCungCap.Rows[idx]; // Lấy dòng

                row.Cells["MaNCC"].Value = ncc.MaNCC; // Gán ID
                row.Cells["MaNhaCungCap"].Value = ncc.MaNhaCungCap; // Gán mã đối tác
                row.Cells["TenNCC"].Value = ncc.TenNCC; // Gán tên nhà cung cấp
                row.Cells["DienThoai"].Value = ncc.DienThoai; // Gán điện thoại
                row.Cells["Email"].Value = ncc.Email; // Gán email
                row.Cells["DiaChi"].Value = ncc.DiaChi; // Gán địa chỉ
                row.Cells["MaSoThue"].Value = ncc.MaSoThue; // Gán mã số thuế
                row.Cells["TrangThai"].Value = ncc.TrangThai; // Gán trạng thái
            }
        }

        private void btnTimNCCClick(object sender, EventArgs e)
        {
            loadDataNhaCungCap(txtTimNCC.Text.Trim()); // Tìm NCC theo từ khóa
        }

        private void txtTimNCCKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTimNCCClick(sender, EventArgs.Empty); // Nhấn Enter để tìm
        }

        private void btnLamMoiNCCClick(object sender, EventArgs e)
        {
            txtTimNCC.Clear(); // Xóa từ khóa
            loadDataNhaCungCap(""); // Tải lại toàn bộ
            lblStatusThongBao.Text = "Đã làm mới danh sách nhà cung cấp."; // Báo trạng thái
        }

        private void dgvNhaCungCapCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra dòng hợp lệ
            {
                btnLuuNCC.Enabled = true; // Bật nút Lưu
                lblStatusThongBao.Text = "Có thay đổi tại bảng nhà cung cấp. Nhấn nút 'Lưu' để cập nhật."; // Thông báo
            }
        }

        private void btnThemNCCClick(object sender, EventArgs e)
        {
            int idx = dgvNhaCungCap.Rows.Add(); // Thêm dòng mới
            DataGridViewRow row = dgvNhaCungCap.Rows[idx]; // Lấy dòng

            row.Cells["MaNCC"].Value = 0; // ID = 0 đánh dấu thêm mới
            row.Cells["MaNhaCungCap"].Value = "NCC" + DateTime.Now.ToString("HHmmss"); // Mã tạm
            row.Cells["TenNCC"].Value = "Công Ty Dệt May Mới"; // Tên mặc định
            row.Cells["DienThoai"].Value = "0283000000"; // SĐT mặc định
            row.Cells["Email"].Value = "ncc@viettien.com"; // Email mặc định
            row.Cells["DiaChi"].Value = "TP.Hồ Chí Minh"; // Địa chỉ mặc định
            row.Cells["MaSoThue"].Value = "0123456789"; // MST mặc định
            row.Cells["TrangThai"].Value = "Đang hợp tác"; // Trạng thái mặc định

            dgvNhaCungCap.ClearSelection(); // Hủy chọn dòng cũ
            row.Selected = true; // Chọn dòng mới
            dgvNhaCungCap.CurrentCell = row.Cells["TenNCC"]; // Đặt con trỏ vào ô Tên NCC

            btnLuuNCC.Enabled = true; // Bật nút Lưu
            lblStatusThongBao.Text = "Đã thêm dòng mới. Chỉnh sửa trực tiếp trên bảng rồi nhấn nút 'Lưu'."; // Hướng dẫn
        }

        private void btnLuuNCCClick(object sender, EventArgs e)
        {
            try
            {
                dgvNhaCungCap.EndEdit(); // Kết thúc chỉnh sửa ô
                int soLuu = 0; // Đếm số bản ghi đã lưu

                for (int i = 0; i < dgvNhaCungCap.Rows.Count; i++) // Lặp qua tất cả các dòng
                {
                    DataGridViewRow row = dgvNhaCungCap.Rows[i]; // Lấy dòng
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới trống

                    int maNCC = 0;
                    if (row.Cells["MaNCC"].Value != null) int.TryParse(row.Cells["MaNCC"].Value.ToString(), out maNCC);

                    string ma = row.Cells["MaNhaCungCap"].Value != null ? row.Cells["MaNhaCungCap"].Value.ToString().Trim() : "";
                    string ten = row.Cells["TenNCC"].Value != null ? row.Cells["TenNCC"].Value.ToString().Trim() : "";
                    string dt = row.Cells["DienThoai"].Value != null ? row.Cells["DienThoai"].Value.ToString().Trim() : "";
                    string mail = row.Cells["Email"].Value != null ? row.Cells["Email"].Value.ToString().Trim() : "";
                    string dc = row.Cells["DiaChi"].Value != null ? row.Cells["DiaChi"].Value.ToString().Trim() : "";
                    string mst = row.Cells["MaSoThue"].Value != null ? row.Cells["MaSoThue"].Value.ToString().Trim() : "";
                    string tt = row.Cells["TrangThai"].Value != null ? row.Cells["TrangThai"].Value.ToString() : "Đang hợp tác";

                    if (string.IsNullOrEmpty(ten)) // Kiểm tra hợp lệ tên NCC
                    {
                        MessageBox.Show("Dòng " + (i + 1) + ": Tên nhà cung cấp không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string thongBaoLoi;
                    if (maNCC == 0) // Thêm mới
                    {
                        NhaCungCap nccMoi = new NhaCungCap // Tạo mới đối tượng
                        {
                            MaNhaCungCap = ma,
                            TenNCC = ten,
                            DienThoai = dt,
                            Email = mail,
                            DiaChi = dc,
                            MaSoThue = mst,
                            TrangThai = tt
                        };
                        nhaCungCapService.themNhaCungCap(nccMoi, out thongBaoLoi); // Gọi Service thêm
                        soLuu++; // Tăng biến đếm
                    }
                    else // Cập nhật
                    {
                        NhaCungCap nccSua = nhaCungCapService.layTheoId(maNCC); // Lấy NCC theo ID
                        if (nccSua != null)
                        {
                            nccSua.MaNhaCungCap = ma; // Cập nhật mã
                            nccSua.TenNCC = ten; // Cập nhật tên
                            nccSua.DienThoai = dt; // Cập nhật điện thoại
                            nccSua.Email = mail; // Cập nhật email
                            nccSua.DiaChi = dc; // Cập nhật địa chỉ
                            nccSua.MaSoThue = mst; // Cập nhật MST
                            nccSua.TrangThai = tt; // Cập nhật trạng thái
                            nhaCungCapService.suaNhaCungCap(nccSua, out thongBaoLoi); // Gọi Service sửa
                            soLuu++; // Tăng biến đếm
                        }
                    }
                }

                btnLuuNCC.Enabled = false; // Tắt nút Lưu
                loadDataNhaCungCap(txtTimNCC.Text.Trim()); // Nạp lại dữ liệu
                MessageBox.Show("Lưu nhà cung cấp thành công (" + soLuu + " bản ghi)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNCCClick(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.CurrentRow == null) // Kiểm tra đã chọn NCC chưa
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp trên bảng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNCC = 0;
            if (dgvNhaCungCap.CurrentRow.Cells["MaNCC"].Value != null) int.TryParse(dgvNhaCungCap.CurrentRow.Cells["MaNCC"].Value.ToString(), out maNCC);
            string tenNCC = dgvNhaCungCap.CurrentRow.Cells["TenNCC"].Value != null ? dgvNhaCungCap.CurrentRow.Cells["TenNCC"].Value.ToString() : "";

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp:\n" + tenNCC + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) // Nếu người dùng xác nhận xóa
            {
                if (maNCC > 0)
                {
                    string thongBaoLoi;
                    nhaCungCapService.xoaNhaCungCap(maNCC, out thongBaoLoi); // Gọi Service xóa
                }
                loadDataNhaCungCap(txtTimNCC.Text.Trim()); // Tải lại bảng
                lblStatusThongBao.Text = "Đã xóa nhà cung cấp thành công."; // Báo trạng thái
            }
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  5. PHẦN HÓA ĐƠN BÁN HÀNG VÀ CHI TIẾT ĐƠN HÀNG (POS)
        // ══════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Thiết lập cấu trúc cột và kiểu hiển thị cho DataGridView Hóa Đơn.
        /// </summary>
        private void thietLapCotHoaDon()
        {
            dgvHoaDon.Columns.Clear(); // Xóa cột cũ

            DataGridViewTextBoxColumn cotId = new DataGridViewTextBoxColumn(); // Cột ID hóa đơn
            cotId.Name = "MaHD"; // Tên định danh
            cotId.HeaderText = "ID"; // Tiêu đề cột
            cotId.Width = 50; // Chiều rộng
            dgvHoaDon.Columns.Add(cotId); // Thêm vào bảng

            DataGridViewTextBoxColumn cotMa = new DataGridViewTextBoxColumn(); // Cột Mã Hóa Đơn
            cotMa.Name = "MaHoaDon"; // Tên định danh
            cotMa.HeaderText = "Mã Hóa Đơn"; // Tiêu đề cột
            cotMa.Width = 130; // Chiều rộng
            dgvHoaDon.Columns.Add(cotMa); // Thêm vào bảng

            DataGridViewTextBoxColumn cotNgay = new DataGridViewTextBoxColumn(); // Cột Ngày Lập
            cotNgay.Name = "NgayLap"; // Tên định danh
            cotNgay.HeaderText = "Ngày Lập"; // Tiêu đề cột
            cotNgay.Width = 140; // Chiều rộng
            dgvHoaDon.Columns.Add(cotNgay); // Thêm vào bảng

            DataGridViewTextBoxColumn cotNV = new DataGridViewTextBoxColumn(); // Cột Nhân Viên Lập
            cotNV.Name = "TenNhanVien"; // Tên định danh
            cotNV.HeaderText = "Nhân Viên Thu Ngân"; // Tiêu đề cột
            cotNV.Width = 160; // Chiều rộng
            dgvHoaDon.Columns.Add(cotNV); // Thêm vào bảng

            DataGridViewTextBoxColumn cotKH = new DataGridViewTextBoxColumn(); // Cột Khách Hàng Mua
            cotKH.Name = "TenKhachHang"; // Tên định danh
            cotKH.HeaderText = "Khách Hàng"; // Tiêu đề cột
            cotKH.Width = 180; // Chiều rộng
            dgvHoaDon.Columns.Add(cotKH); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTong = new DataGridViewTextBoxColumn(); // Cột Tổng Tiền
            cotTong.Name = "TongTien"; // Tên định danh
            cotTong.HeaderText = "Tổng Tiền (đ)"; // Tiêu đề cột
            cotTong.Width = 120; // Chiều rộng
            cotTong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
            dgvHoaDon.Columns.Add(cotTong); // Thêm vào bảng

            DataGridViewTextBoxColumn cotGiam = new DataGridViewTextBoxColumn(); // Cột Giảm Giá
            cotGiam.Name = "GiamGia"; // Tên định danh
            cotGiam.HeaderText = "Giảm Giá (đ)"; // Tiêu đề cột
            cotGiam.Width = 100; // Chiều rộng
            cotGiam.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
            dgvHoaDon.Columns.Add(cotGiam); // Thêm vào bảng

            DataGridViewTextBoxColumn cotThanhTien = new DataGridViewTextBoxColumn(); // Cột Thực Thu
            cotThanhTien.Name = "ThanhTien"; // Tên định danh
            cotThanhTien.HeaderText = "Thành Tiền (đ)"; // Tiêu đề cột
            cotThanhTien.Width = 120; // Chiều rộng
            cotThanhTien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
            dgvHoaDon.Columns.Add(cotThanhTien); // Thêm vào bảng

            DataGridViewTextBoxColumn cotPT = new DataGridViewTextBoxColumn(); // Cột Phương Thức Thanh Toán
            cotPT.Name = "PhuongThucTT"; // Tên định danh
            cotPT.HeaderText = "Thanh Toán"; // Tiêu đề cột
            cotPT.Width = 110; // Chiều rộng
            dgvHoaDon.Columns.Add(cotPT); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTT = new DataGridViewTextBoxColumn(); // Cột Trạng Thái
            cotTT.Name = "TrangThai"; // Tên định danh
            cotTT.HeaderText = "Trạng Thái"; // Tiêu đề cột
            cotTT.Width = 110; // Chiều rộng
            dgvHoaDon.Columns.Add(cotTT); // Thêm vào bảng
        }

        /// <summary>
        /// Thiết lập cấu trúc cột cho bảng hiển thị các dòng chi tiết món hàng của hóa đơn đang chọn.
        /// </summary>
        private void thietLapCotChiTietHoaDon()
        {
            dgvChiTietHoaDon.Columns.Clear(); // Xóa sạch cột cũ

            DataGridViewTextBoxColumn cotMaCT = new DataGridViewTextBoxColumn(); // Cột ID dòng chi tiết
            cotMaCT.Name = "MaCTHD"; // Tên định danh
            cotMaCT.HeaderText = "Mã Chi Tiết"; // Tiêu đề cột
            cotMaCT.Width = 100; // Chiều rộng
            dgvChiTietHoaDon.Columns.Add(cotMaCT); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTenSP = new DataGridViewTextBoxColumn(); // Cột tên mặt hàng thời trang
            cotTenSP.Name = "TenSP"; // Tên định danh
            cotTenSP.HeaderText = "Tên Sản Phẩm Đã Mua"; // Tiêu đề cột
            cotTenSP.Width = 320; // Chiều rộng
            dgvChiTietHoaDon.Columns.Add(cotTenSP); // Thêm vào bảng

            DataGridViewTextBoxColumn cotSL = new DataGridViewTextBoxColumn(); // Cột số lượng mua
            cotSL.Name = "SoLuong"; // Tên định danh
            cotSL.HeaderText = "Số Lượng"; // Tiêu đề cột
            cotSL.Width = 100; // Chiều rộng
            cotSL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            dgvChiTietHoaDon.Columns.Add(cotSL); // Thêm vào bảng

            DataGridViewTextBoxColumn cotGia = new DataGridViewTextBoxColumn(); // Cột đơn giá sản phẩm
            cotGia.Name = "DonGia"; // Tên định danh
            cotGia.HeaderText = "Đơn Giá (đ)"; // Tiêu đề cột
            cotGia.Width = 140; // Chiều rộng
            cotGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
            dgvChiTietHoaDon.Columns.Add(cotGia); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTien = new DataGridViewTextBoxColumn(); // Cột thành tiền của dòng
            cotTien.Name = "ThanhTien"; // Tên định danh
            cotTien.HeaderText = "Thành Tiền (đ)"; // Tiêu đề cột
            cotTien.Width = 160; // Chiều rộng
            cotTien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
            dgvChiTietHoaDon.Columns.Add(cotTien); // Thêm vào bảng
        }

        /// <summary>
        /// Nạp lịch sử danh sách hóa đơn bán hàng lên DataGridView.
        /// </summary>
        public void loadDataHoaDon(string tuKhoa)
        {
            dgvHoaDon.Rows.Clear(); // Xóa sạch các dòng cũ trên bảng
            List<HoaDon> ds = hoaDonService.timKiem(tuKhoa); // Gọi Service tìm kiếm hóa đơn

            foreach (HoaDon hd in ds) // Lặp qua từng hóa đơn trong kết quả
            {
                int idx = dgvHoaDon.Rows.Add(); // Thêm dòng mới
                DataGridViewRow row = dgvHoaDon.Rows[idx]; // Lấy dòng

                row.Cells["MaHD"].Value = hd.MaHD; // Gán ID
                row.Cells["MaHoaDon"].Value = hd.MaHoaDon; // Gán mã hóa đơn
                row.Cells["NgayLap"].Value = hd.NgayLap.ToString("dd/MM/yyyy HH:mm"); // Định dạng ngày giờ
                row.Cells["TenNhanVien"].Value = hd.TenNhanVien; // Gán tên nhân viên thu ngân
                row.Cells["TenKhachHang"].Value = hd.TenKhachHang; // Gán tên khách hàng
                row.Cells["TongTien"].Value = hd.TongTien.ToString("N0"); // Định dạng số tiền
                row.Cells["GiamGia"].Value = hd.GiamGia.ToString("N0"); // Định dạng số tiền giảm
                row.Cells["ThanhTien"].Value = hd.ThanhTien.ToString("N0"); // Định dạng số tiền thực thu
                row.Cells["PhuongThucTT"].Value = hd.PhuongThucTT; // Gán phương thức thanh toán
                row.Cells["TrangThai"].Value = hd.TrangThai; // Gán trạng thái hóa đơn
            }

            // Tự động tải chi tiết cho hóa đơn đầu tiên nếu có dữ liệu
            if (dgvHoaDon.Rows.Count > 0)
            {
                dgvHoaDonSelectionChanged(null, EventArgs.Empty); // Gọi hàm tải chi tiết
            }
            else
            {
                dgvChiTietHoaDon.Rows.Clear(); // Xóa trắng bảng chi tiết nếu không có hóa đơn nào
            }
        }

        /// <summary>
        /// Bắt sự kiện chọn dòng trên bảng hóa đơn để nạp danh sách chi tiết các mặt hàng đã mua tương ứng.
        /// </summary>
        private void dgvHoaDonSelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) return; // Nếu chưa chọn dòng nào thì bỏ qua

            int maHD = 0; // Biến nhận mã ID hóa đơn
            if (dgvHoaDon.CurrentRow.Cells["MaHD"].Value != null)
            {
                int.TryParse(dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString(), out maHD); // Lấy mã ID
            }

            dgvChiTietHoaDon.Rows.Clear(); // Xóa sạch bảng chi tiết cũ
            if (maHD > 0) // Nếu có mã hóa đơn hợp lệ
            {
                List<ChiTietHoaDon> dsChiTiet = hoaDonService.layChiTietHoaDon(maHD); // Lấy chi tiết từ Service
                foreach (ChiTietHoaDon ct in dsChiTiet) // Duyệt qua từng món hàng trong đơn
                {
                    int r = dgvChiTietHoaDon.Rows.Add(); // Thêm dòng vào bảng chi tiết
                    dgvChiTietHoaDon.Rows[r].Cells["MaCTHD"].Value = "CT" + ct.MaCTHD; // Gán mã dòng chi tiết
                    dgvChiTietHoaDon.Rows[r].Cells["TenSP"].Value = ct.TenSP; // Gán tên sản phẩm
                    dgvChiTietHoaDon.Rows[r].Cells["SoLuong"].Value = ct.SoLuong; // Gán số lượng
                    dgvChiTietHoaDon.Rows[r].Cells["DonGia"].Value = ct.DonGia.ToString("N0"); // Gán đơn giá
                    dgvChiTietHoaDon.Rows[r].Cells["ThanhTien"].Value = ct.ThanhTien.ToString("N0"); // Gán thành tiền
                }
            }
        }

        private void btnTimHDClick(object sender, EventArgs e)
        {
            loadDataHoaDon(txtTimHD.Text.Trim()); // Tìm hóa đơn theo mã hoặc tên
        }

        private void txtTimHDKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTimHDClick(sender, EventArgs.Empty); // Nhấn Enter để tìm
        }

        private void btnLamMoiHDClick(object sender, EventArgs e)
        {
            txtTimHD.Clear(); // Xóa từ khóa
            loadDataHoaDon(""); // Tải lại toàn bộ hóa đơn
            lblStatusThongBao.Text = "Đã làm mới danh sách hóa đơn."; // Thông báo
        }

        /// <summary>
        /// Mở cửa sổ POS chuyên nghiệp để tạo hóa đơn bán lẻ mới.
        /// Cho phép chọn khách hàng, chọn nhiều sản phẩm, tính tiền, giảm giá và cập nhật kho tự động.
        /// </summary>
        private void btnTaoHDClick(object sender, EventArgs e)
        {
            using (FormTaoHoaDon fTao = new FormTaoHoaDon()) // Khởi tạo form bán lẻ chuyên nghiệp
            {
                if (fTao.ShowDialog(this) == DialogResult.OK) // Kiểm tra nếu người dùng đã hoàn tất thanh toán
                {
                    loadDataHoaDon(""); // Nạp lại danh sách hóa đơn
                    loadDataSanPham(""); // Nạp lại bảng sản phẩm để cập nhật tồn kho mới nhất
                    capNhatDashboard(); // Cập nhật lại các chỉ số tổng quan trên Dashboard
                    capNhatThongKe(); // Cập nhật lại số liệu thống kê doanh thu
                    capNhatStatusTongSo(); // Cập nhật lại tổng số bản ghi hiển thị dưới thanh trạng thái
                    lblStatusThongBao.Text = "Đã lập hóa đơn bán hàng thành công."; // Thông báo trạng thái thành công

                    if (fTao.HoaDonVuaTao != null) // Nếu có đối tượng hóa đơn vừa tạo
                    {
                        DialogResult dr = MessageBox.Show("Đã lập hóa đơn thành công! Bạn có muốn in phiếu thanh toán ngay bây giờ không?", "In Hóa Đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Hỏi người dùng có muốn in phiếu không
                        if (dr == DialogResult.Yes) // Nếu người dùng chọn có in phiếu
                        {
                            using (FormInHoaDon fIn = new FormInHoaDon(fTao.HoaDonVuaTao)) // Khởi tạo form in phiếu thanh toán
                            {
                                fIn.ShowDialog(this); // Hiển thị phiếu thanh toán cho hóa đơn vừa tạo
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Mở cửa sổ in phiếu thanh toán hóa đơn bán lẻ chuyên nghiệp.
        /// </summary>
        private void btnInHDClick(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) // Kiểm tra người dùng đã chọn hóa đơn chưa
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn trên bảng để in phiếu thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHD = 0; // Biến nhận ID hóa đơn
            if (dgvHoaDon.CurrentRow.Cells["MaHD"].Value != null) int.TryParse(dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString(), out maHD);

            HoaDon hdChon = null; // Tìm đối tượng hóa đơn trong kho dữ liệu
            foreach (HoaDon h in KhoDuLieu.DanhSachHoaDon) // Duyệt danh sách hóa đơn
            {
                if (h.MaHD == maHD) { hdChon = h; break; }
            }

            if (hdChon != null) // Nếu tìm thấy hóa đơn hợp lệ
            {
                FormInHoaDon fIn = new FormInHoaDon(hdChon); // Khởi tạo form in phiếu với dữ liệu hóa đơn này
                fIn.ShowDialog(this); // Mở cửa sổ xem và in phiếu thanh toán
            }
        }

        /// <summary>
        /// Xử lý hủy một hóa đơn bán hàng đã chọn.
        /// </summary>
        private void btnHuyHDClick(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) // Kiểm tra đã chọn hóa đơn chưa
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHD = 0;
            if (dgvHoaDon.CurrentRow.Cells["MaHD"].Value != null) int.TryParse(dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString(), out maHD);
            string maHDText = dgvHoaDon.CurrentRow.Cells["MaHoaDon"].Value != null ? dgvHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString() : "";

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn:\n" + maHDText + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) // Nếu xác nhận hủy
            {
                string thongBaoLoi;
                hoaDonService.huyHoaDon(maHD, out thongBaoLoi); // Gọi Service hủy hóa đơn
                loadDataHoaDon(txtTimHD.Text.Trim()); // Tải lại bảng hóa đơn
                capNhatDashboard(); // Cập nhật lại chỉ số Dashboard
                capNhatThongKe(); // Cập nhật lại số liệu thống kê
                lblStatusThongBao.Text = "Đã hủy hóa đơn " + maHDText; // Báo trạng thái
            }
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  6. PHẦN QUẢN LÝ TÀI KHOẢN NHÂN VIÊN VÀ PHÂN QUYỀN
        // ══════════════════════════════════════════════════════════════════════════

        private void thietLapCotNhanVien()
        {
            dgvNhanVien.Columns.Clear(); // Xóa sạch cột cũ

            DataGridViewTextBoxColumn cotId = new DataGridViewTextBoxColumn(); // Cột ID
            cotId.Name = "MaNV"; // Tên định danh
            cotId.HeaderText = "ID"; // Tiêu đề cột
            cotId.Width = 50; // Chiều rộng
            cotId.ReadOnly = true; // Chỉ đọc
            dgvNhanVien.Columns.Add(cotId); // Thêm vào bảng

            DataGridViewTextBoxColumn cotMa = new DataGridViewTextBoxColumn(); // Cột mã nhân viên
            cotMa.Name = "MaNhanVien"; // Tên định danh
            cotMa.HeaderText = "Mã NV"; // Tiêu đề cột
            cotMa.Width = 90; // Chiều rộng
            dgvNhanVien.Columns.Add(cotMa); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTen = new DataGridViewTextBoxColumn(); // Cột họ tên
            cotTen.Name = "HoTen"; // Tên định danh
            cotTen.HeaderText = "Họ Và Tên"; // Tiêu đề cột
            cotTen.Width = 180; // Chiều rộng
            dgvNhanVien.Columns.Add(cotTen); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTK = new DataGridViewTextBoxColumn(); // Cột tên đăng nhập
            cotTK.Name = "TenDangNhap"; // Tên định danh
            cotTK.HeaderText = "Tên Đăng Nhập"; // Tiêu đề cột
            cotTK.Width = 130; // Chiều rộng
            dgvNhanVien.Columns.Add(cotTK); // Thêm vào bảng

            DataGridViewTextBoxColumn cotMK = new DataGridViewTextBoxColumn(); // Cột mật khẩu
            cotMK.Name = "MatKhau"; // Tên định danh
            cotMK.HeaderText = "Mật Khẩu"; // Tiêu đề cột
            cotMK.Width = 110; // Chiều rộng
            dgvNhanVien.Columns.Add(cotMK); // Thêm vào bảng

            DataGridViewTextBoxColumn cotCV = new DataGridViewTextBoxColumn(); // Cột chức vụ
            cotCV.Name = "ChucVu"; // Tên định danh
            cotCV.HeaderText = "Chức Vụ"; // Tiêu đề cột
            cotCV.Width = 140; // Chiều rộng
            dgvNhanVien.Columns.Add(cotCV); // Thêm vào bảng

            DataGridViewTextBoxColumn cotDT = new DataGridViewTextBoxColumn(); // Cột số điện thoại
            cotDT.Name = "SoDienThoai"; // Tên định danh
            cotDT.HeaderText = "Điện Thoại"; // Tiêu đề cột
            cotDT.Width = 120; // Chiều rộng
            dgvNhanVien.Columns.Add(cotDT); // Thêm vào bảng

            DataGridViewTextBoxColumn cotMail = new DataGridViewTextBoxColumn(); // Cột Email
            cotMail.Name = "Email"; // Tên định danh
            cotMail.HeaderText = "Email"; // Tiêu đề cột
            cotMail.Width = 160; // Chiều rộng
            dgvNhanVien.Columns.Add(cotMail); // Thêm vào bảng

            DataGridViewTextBoxColumn cotTT = new DataGridViewTextBoxColumn(); // Cột trạng thái làm việc
            cotTT.Name = "TrangThai"; // Tên định danh
            cotTT.HeaderText = "Trạng Thái"; // Tiêu đề cột
            cotTT.Width = 110; // Chiều rộng
            dgvNhanVien.Columns.Add(cotTT); // Thêm vào bảng
        }

        public void loadDataNhanVien(string tuKhoa)
        {
            dgvNhanVien.Rows.Clear(); // Xóa sạch dữ liệu cũ
            List<NhanVien> ds = authService.timKiemNhanVien(tuKhoa); // Gọi Service tìm nhân viên

            foreach (NhanVien nv in ds) // Lặp qua danh sách nhân viên
            {
                int idx = dgvNhanVien.Rows.Add(); // Thêm dòng mới
                DataGridViewRow row = dgvNhanVien.Rows[idx]; // Lấy dòng

                row.Cells["MaNV"].Value = nv.MaNV; // Gán ID
                row.Cells["MaNhanVien"].Value = nv.MaNhanVien; // Gán mã NV
                row.Cells["HoTen"].Value = nv.HoTen; // Gán họ tên
                row.Cells["TenDangNhap"].Value = nv.TenDangNhap; // Gán tên đăng nhập
                row.Cells["MatKhau"].Value = nv.MatKhau; // Gán mật khẩu
                row.Cells["ChucVu"].Value = nv.ChucVu; // Gán chức vụ
                row.Cells["SoDienThoai"].Value = nv.SoDienThoai; // Gán điện thoại
                row.Cells["Email"].Value = nv.Email; // Gán email
                row.Cells["TrangThai"].Value = nv.TrangThai; // Gán trạng thái
            }
        }

        private void btnTimNVClick(object sender, EventArgs e)
        {
            loadDataNhanVien(txtTimNV.Text.Trim()); // Tìm nhân viên theo từ khóa
        }

        private void txtTimNVKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTimNVClick(sender, EventArgs.Empty); // Nhấn Enter để tìm
        }

        private void btnLamMoiNVClick(object sender, EventArgs e)
        {
            txtTimNV.Clear(); // Xóa từ khóa
            loadDataNhanVien(""); // Tải lại toàn bộ nhân viên
            lblStatusThongBao.Text = "Đã làm mới danh sách nhân viên."; // Thông báo
        }

        private void dgvNhanVienCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra dòng hợp lệ
            {
                btnLuuNV.Enabled = true; // Bật nút Lưu
                lblStatusThongBao.Text = "Có thay đổi tại bảng nhân viên. Nhấn nút 'Lưu' để cập nhật."; // Thông báo
            }
        }

        private void btnThemNVClick(object sender, EventArgs e)
        {
            int idx = dgvNhanVien.Rows.Add(); // Thêm dòng mới
            DataGridViewRow row = dgvNhanVien.Rows[idx]; // Lấy dòng

            row.Cells["MaNV"].Value = 0; // ID = 0 đánh dấu thêm mới
            row.Cells["MaNhanVien"].Value = "NV" + DateTime.Now.ToString("HHmmss"); // Mã tạm
            row.Cells["HoTen"].Value = "Nhân Viên Mới"; // Tên mặc định
            row.Cells["TenDangNhap"].Value = "user" + DateTime.Now.ToString("mmss"); // Tên đăng nhập tạm
            row.Cells["MatKhau"].Value = "123456"; // Mật khẩu mặc định
            row.Cells["ChucVu"].Value = "Nhân viên bán hàng"; // Chức vụ mặc định
            row.Cells["SoDienThoai"].Value = "0900000000"; // SĐT mặc định
            row.Cells["Email"].Value = "nv@viettien.com"; // Email mặc định
            row.Cells["TrangThai"].Value = "Đang làm việc"; // Trạng thái mặc định

            dgvNhanVien.ClearSelection(); // Hủy chọn dòng cũ
            row.Selected = true; // Chọn dòng mới
            dgvNhanVien.CurrentCell = row.Cells["HoTen"]; // Đặt con trỏ vào ô Họ Tên

            btnLuuNV.Enabled = true; // Bật nút Lưu
            lblStatusThongBao.Text = "Đã thêm dòng mới. Chỉnh sửa thông tin nhân viên rồi nhấn nút 'Lưu'."; // Hướng dẫn
        }

        private void btnLuuNVClick(object sender, EventArgs e)
        {
            try
            {
                dgvNhanVien.EndEdit(); // Kết thúc sửa ô
                int soLuu = 0; // Đếm số bản ghi đã lưu

                for (int i = 0; i < dgvNhanVien.Rows.Count; i++) // Lặp qua tất cả các dòng
                {
                    DataGridViewRow row = dgvNhanVien.Rows[i]; // Lấy dòng
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới

                    int maNV = 0;
                    if (row.Cells["MaNV"].Value != null) int.TryParse(row.Cells["MaNV"].Value.ToString(), out maNV);

                    string ma = row.Cells["MaNhanVien"].Value != null ? row.Cells["MaNhanVien"].Value.ToString().Trim() : "";
                    string ten = row.Cells["HoTen"].Value != null ? row.Cells["HoTen"].Value.ToString().Trim() : "";
                    string tk = row.Cells["TenDangNhap"].Value != null ? row.Cells["TenDangNhap"].Value.ToString().Trim() : "";
                    string mk = row.Cells["MatKhau"].Value != null ? row.Cells["MatKhau"].Value.ToString().Trim() : "";
                    string cv = row.Cells["ChucVu"].Value != null ? row.Cells["ChucVu"].Value.ToString() : "Nhân viên bán hàng";
                    string dt = row.Cells["SoDienThoai"].Value != null ? row.Cells["SoDienThoai"].Value.ToString().Trim() : "";
                    string mail = row.Cells["Email"].Value != null ? row.Cells["Email"].Value.ToString().Trim() : "";
                    string tt = row.Cells["TrangThai"].Value != null ? row.Cells["TrangThai"].Value.ToString() : "Đang làm việc";

                    if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk)) // Kiểm tra rỗng
                    {
                        MessageBox.Show("Dòng " + (i + 1) + ": Họ tên, tên đăng nhập và mật khẩu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string thongBaoLoi;
                    if (maNV == 0) // Thêm mới
                    {
                        NhanVien nvMoi = new NhanVien
                        {
                            MaNhanVien = ma,
                            HoTen = ten,
                            TenDangNhap = tk,
                            MatKhau = mk,
                            ChucVu = cv,
                            SoDienThoai = dt,
                            Email = mail,
                            TrangThai = tt
                        };
                        authService.themNhanVien(nvMoi, out thongBaoLoi); // Gọi Service thêm nhân viên
                        soLuu++; // Tăng biến đếm
                    }
                    else // Cập nhật
                    {
                        NhanVien nvSua = null;
                        foreach (NhanVien n in KhoDuLieu.DanhSachNhanVien) // Tìm nhân viên trong kho
                        {
                            if (n.MaNV == maNV) { nvSua = n; break; }
                        }
                        if (nvSua != null)
                        {
                            nvSua.MaNhanVien = ma; // Cập nhật mã
                            nvSua.HoTen = ten; // Cập nhật họ tên
                            nvSua.TenDangNhap = tk; // Cập nhật tên đăng nhập
                            nvSua.MatKhau = mk; // Cập nhật mật khẩu
                            nvSua.ChucVu = cv; // Cập nhật chức vụ
                            nvSua.SoDienThoai = dt; // Cập nhật SĐT
                            nvSua.Email = mail; // Cập nhật email
                            nvSua.TrangThai = tt; // Cập nhật trạng thái
                            authService.suaNhanVien(nvSua, out thongBaoLoi); // Gọi Service sửa nhân viên
                            soLuu++; // Tăng biến đếm
                        }
                    }
                }

                btnLuuNV.Enabled = false; // Tắt nút Lưu
                loadDataNhanVien(txtTimNV.Text.Trim()); // Nạp lại danh sách nhân viên
                MessageBox.Show("Lưu thông tin nhân viên thành công (" + soLuu + " bản ghi)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNVClick(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) // Kiểm tra đã chọn nhân viên chưa
            {
                MessageBox.Show("Vui lòng chọn nhân viên trên bảng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = 0;
            if (dgvNhanVien.CurrentRow.Cells["MaNV"].Value != null) int.TryParse(dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString(), out maNV);
            string hoTen = dgvNhanVien.CurrentRow.Cells["HoTen"].Value != null ? dgvNhanVien.CurrentRow.Cells["HoTen"].Value.ToString() : "";

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên:\n" + hoTen + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) // Xác nhận xóa
            {
                if (maNV > 0)
                {
                    string thongBaoLoi;
                    if (!authService.xoaNhanVien(maNV, out thongBaoLoi)) // Gọi Service xóa và kiểm tra điều kiện
                    {
                        MessageBox.Show(thongBaoLoi, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                loadDataNhanVien(txtTimNV.Text.Trim()); // Nạp lại danh sách nhân viên
                lblStatusThongBao.Text = "Đã xóa nhân viên thành công."; // Báo trạng thái
            }
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  7. PHẦN BÁO CÁO THỐNG KÊ VÀ HIỆU SUẤT KINH DOANH
        // ══════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Thiết lập cấu trúc cột cho bảng thống kê doanh số theo nhân viên.
        /// </summary>
        private void thietLapCotThongKeNV()
        {
            dgvThongKeNV.Columns.Clear(); // Xóa sạch cột cũ
            dgvThongKeNV.Columns.Add("HoTen", "Tên Nhân Viên"); // Cột tên nhân viên
            dgvThongKeNV.Columns.Add("ChucVu", "Chức Vụ"); // Cột chức vụ
            dgvThongKeNV.Columns.Add("SoDonHang", "Số Đơn Bán"); // Cột số đơn hàng
            dgvThongKeNV.Columns.Add("DoanhSo", "Tổng Doanh Số (đ)"); // Cột doanh số thu về

            dgvThongKeNV.Columns["HoTen"].Width = 180; // Chiều rộng tên nhân viên
            dgvThongKeNV.Columns["ChucVu"].Width = 140; // Chiều rộng chức vụ
            dgvThongKeNV.Columns["SoDonHang"].Width = 100; // Chiều rộng số đơn
            dgvThongKeNV.Columns["DoanhSo"].Width = 150; // Chiều rộng doanh số

            dgvThongKeNV.Columns["SoDonHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            dgvThongKeNV.Columns["DoanhSo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
        }

        /// <summary>
        /// Thiết lập cấu trúc cột cho bảng cơ cấu sản phẩm và giá trị tồn kho theo loại.
        /// </summary>
        private void thietLapCotThongKeSP()
        {
            dgvThongKeSP.Columns.Clear(); // Xóa sạch cột cũ
            dgvThongKeSP.Columns.Add("LoaiSP", "Phân Loại Sản Phẩm"); // Cột loại sản phẩm
            dgvThongKeSP.Columns.Add("SoMau", "Số Mẫu Mã"); // Cột số lượng mẫu mã
            dgvThongKeSP.Columns.Add("TongTon", "Tổng Tồn Kho"); // Cột tổng số chiếc
            dgvThongKeSP.Columns.Add("GiaTriTon", "Tổng Giá Trị Tồn (đ)"); // Cột giá trị quy thành tiền

            dgvThongKeSP.Columns["LoaiSP"].Width = 170; // Chiều rộng loại sản phẩm
            dgvThongKeSP.Columns["SoMau"].Width = 100; // Chiều rộng số mẫu mã
            dgvThongKeSP.Columns["TongTon"].Width = 110; // Chiều rộng tổng tồn
            dgvThongKeSP.Columns["GiaTriTon"].Width = 180; // Chiều rộng giá trị tồn

            dgvThongKeSP.Columns["SoMau"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            dgvThongKeSP.Columns["TongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            dgvThongKeSP.Columns["GiaTriTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
        }

        /// <summary>
        /// Tính toán tổng hợp số liệu và nạp lên hai bảng thống kê.
        /// </summary>
        private void capNhatThongKe()
        {
            DateTime tuNgay; // Biến mốc từ ngày
            DateTime denNgay; // Biến mốc đến ngày
            layKhoangThoiGianThongKe(out tuNgay, out denNgay); // Lấy khoảng thời gian lọc

            // 1. Thống kê hiệu suất theo nhân viên
            dgvThongKeNV.Rows.Clear(); // Xóa dòng cũ
            foreach (NhanVien nv in KhoDuLieu.DanhSachNhanVien) // Duyệt qua từng nhân viên
            {
                int soDon = 0; // Đếm số đơn của nhân viên này
                decimal doanhThu = 0; // Tính tổng doanh thu
                foreach (HoaDon hd in KhoDuLieu.DanhSachHoaDon) // Duyệt qua tất cả hóa đơn
                {
                    if (hd.NgayLap < tuNgay || hd.NgayLap > denNgay) continue; // Lọc theo mốc thời gian

                    if (hd.TenNhanVien != null && hd.TenNhanVien.Equals(nv.HoTen, StringComparison.OrdinalIgnoreCase))
                    {
                        if (hd.TrangThai != null && hd.TrangThai.Equals("Đã thanh toán", StringComparison.OrdinalIgnoreCase))
                        {
                            soDon++; // Tăng số đơn
                            doanhThu += hd.ThanhTien; // Cộng dồn tiền
                        }
                    }
                }

                int r = dgvThongKeNV.Rows.Add(); // Thêm dòng vào bảng
                dgvThongKeNV.Rows[r].Cells["HoTen"].Value = nv.HoTen; // Gán tên nhân viên
                dgvThongKeNV.Rows[r].Cells["ChucVu"].Value = nv.ChucVu; // Gán chức vụ
                dgvThongKeNV.Rows[r].Cells["SoDonHang"].Value = soDon; // Gán số đơn hàng
                dgvThongKeNV.Rows[r].Cells["DoanhSo"].Value = doanhThu.ToString("N0"); // Gán doanh số
            }

            // 2. Thống kê cơ cấu hàng hóa theo nhóm loại sản phẩm
            dgvThongKeSP.Rows.Clear(); // Xóa dòng cũ
            Dictionary<string, int> demMau = new Dictionary<string, int>(); // Đếm số mẫu theo loại
            Dictionary<string, int> demTon = new Dictionary<string, int>(); // Đếm số tồn theo loại
            Dictionary<string, decimal> giaTriTon = new Dictionary<string, decimal>(); // Tính tổng giá trị vốn

            foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt qua từng sản phẩm
            {
                string loai = string.IsNullOrEmpty(sp.LoaiSP) ? "Khác" : sp.LoaiSP; // Lấy tên loại
                if (!demMau.ContainsKey(loai))
                {
                    demMau[loai] = 0; // Khởi tạo đếm mẫu
                    demTon[loai] = 0; // Khởi tạo đếm tồn
                    giaTriTon[loai] = 0; // Khởi tạo giá trị
                }
                demMau[loai] += 1; // Tăng số mẫu
                demTon[loai] += sp.SoLuongTon; // Cộng dồn số tồn
                giaTriTon[loai] += (sp.GiaBan * sp.SoLuongTon); // Tính tổng giá trị hàng theo giá bán
            }

            foreach (string k in demMau.Keys) // Duyệt qua từng loại sản phẩm
            {
                int r = dgvThongKeSP.Rows.Add(); // Thêm dòng vào bảng
                dgvThongKeSP.Rows[r].Cells["LoaiSP"].Value = k; // Gán loại sản phẩm
                dgvThongKeSP.Rows[r].Cells["SoMau"].Value = demMau[k]; // Gán số mẫu
                dgvThongKeSP.Rows[r].Cells["TongTon"].Value = demTon[k]; // Gán tổng tồn
                dgvThongKeSP.Rows[r].Cells["GiaTriTon"].Value = giaTriTon[k].ToString("N0"); // Gán giá trị tồn
            }

            // Yêu cầu vẽ lại biểu đồ trực quan
            if (pnlBieuDoThongKe != null) pnlBieuDoThongKe.Invalidate(); // Kích hoạt vẽ lại biểu đồ
        }

        /// <summary>
        /// Xác định khoảng thời gian lọc số liệu báo cáo dựa trên ComboBox kỳ thống kê.
        /// </summary>
        private void layKhoangThoiGianThongKe(out DateTime tuNgay, out DateTime denNgay)
        {
            int idx = cboKyBaoCao != null ? cboKyBaoCao.SelectedIndex : 0; // Lấy chỉ số kỳ đang chọn
            DateTime homNay = DateTime.Today; // Mốc hôm nay

            if (idx == 1) // Hôm nay
            {
                tuNgay = homNay; // 00:00:00 hôm nay
                denNgay = homNay.AddDays(1).AddSeconds(-1); // 23:59:59 hôm nay
            }
            else if (idx == 2) // 7 ngày qua
            {
                tuNgay = homNay.AddDays(-7); // Cách đây 7 ngày
                denNgay = DateTime.Now; // Đến hiện tại
            }
            else if (idx == 3) // Tháng này
            {
                tuNgay = new DateTime(homNay.Year, homNay.Month, 1); // Đầu tháng
                denNgay = DateTime.Now; // Đến hiện tại
            }
            else // Toàn bộ thời gian
            {
                tuNgay = new DateTime(2020, 1, 1); // Từ 2020
                denNgay = DateTime.Now.AddDays(1); // Đến hết ngày mai
            }
        }

        /// <summary>
        /// Xử lý vẽ biểu đồ trực quan động lên Panel thống kê bằng kỹ thuật đồ họa GDI+.
        /// </summary>
        private void pnlBieuDoThongKePaint(object sender, PaintEventArgs e)
        {
            DateTime tuNgay; // Biến từ ngày
            DateTime denNgay; // Biến đến ngày
            layKhoangThoiGianThongKe(out tuNgay, out denNgay); // Lấy khoảng thời gian

            string luaChon = cboCheDoBieuDo != null && cboCheDoBieuDo.SelectedItem != null ? cboCheDoBieuDo.SelectedItem.ToString() : ""; // Lấy văn bản kiểu biểu đồ đang chọn

            if (luaChon.Contains("Doanh số nhân viên")) // Biểu đồ Cột: Doanh số theo nhân viên
            {
                List<string> nhan; // Danh sách tên nhân viên
                List<double> tien; // Danh sách doanh số
                thongKeService.layDoanhThuTheoNhanVien(tuNgay, denNgay, out nhan, out tien); // Lấy dữ liệu
                VeBieuDoHelper.VeBieuDoCot(e.Graphics, pnlBieuDoThongKe.ClientRectangle, "HIỆU SUẤT DOANH SỐ THEO NHÂN VIÊN BÁN HÀNG", nhan, tien, "đ"); // Vẽ biểu đồ cột
            }
            else if (luaChon.Contains("Cơ cấu tồn kho")) // Biểu đồ Tròn: Cơ cấu tồn kho theo loại
            {
                List<string> nhan; // Danh sách phân loại
                List<double> ton; // Danh sách số lượng tồn
                thongKeService.layCoCauTonKho(out nhan, out ton); // Lấy dữ liệu
                VeBieuDoHelper.VeBieuDoTron(e.Graphics, pnlBieuDoThongKe.ClientRectangle, "CƠ CẤU TỶ TRỌNG HÀNG HÓA TỒN KHO THEO LOẠI", nhan, ton, "Tổng tồn kho"); // Vẽ biểu đồ tròn khuyên
            }
            else if (luaChon.Contains("tồn kho thấp") || luaChon.Contains("cần nhập")) // Biểu đồ Cột: Cảnh báo hàng tồn thấp cho Thủ kho
            {
                List<string> nhan = new List<string>(); // Danh sách tên sản phẩm
                List<double> ton = new List<double>(); // Danh sách số lượng tồn
                foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt qua danh mục sản phẩm
                {
                    if (sp.SoLuongTon < 50) // Lọc các mặt hàng có tồn kho dưới 50 chiếc
                    {
                        string tenRutGon = sp.TenSP.Length > 16 ? sp.TenSP.Substring(0, 15) + "..." : sp.TenSP; // Rút gọn tên sản phẩm
                        nhan.Add(tenRutGon); // Thêm tên
                        ton.Add((double)sp.SoLuongTon); // Thêm số lượng tồn
                    }
                }
                VeBieuDoHelper.VeBieuDoCot(e.Graphics, pnlBieuDoThongKe.ClientRectangle, "SẢN PHẨM TỒN KHO THẤP CẦN NHẬP BỔ SUNG", nhan, ton, "chiếc"); // Vẽ biểu đồ cảnh báo tồn
            }
            else if (luaChon.Contains("Tỷ trọng doanh thu")) // Biểu đồ Tròn: Tỷ trọng doanh thu theo loại
            {
                List<string> nhan; // Danh sách phân loại
                List<double> tien; // Danh sách doanh thu
                thongKeService.layDoanhThuTheoLoai(tuNgay, denNgay, out nhan, out tien); // Lấy dữ liệu
                VeBieuDoHelper.VeBieuDoTron(e.Graphics, pnlBieuDoThongKe.ClientRectangle, "TỶ TRỌNG CƠ CẤU DOANH THU THEO CHỦNG LOẠI", nhan, tien, "Tổng doanh thu"); // Vẽ biểu đồ tròn khuyên
            }
            else // Mặc định: Biểu đồ Cột: Doanh thu theo phân loại
            {
                List<string> nhan; // Danh sách nhãn
                List<double> tien; // Danh sách số tiền
                thongKeService.layDoanhThuTheoLoai(tuNgay, denNgay, out nhan, out tien); // Lấy dữ liệu
                VeBieuDoHelper.VeBieuDoCot(e.Graphics, pnlBieuDoThongKe.ClientRectangle, "BIỂU ĐỒ DOANH THU THEO PHÂN LOẠI SẢN PHẨM", nhan, tien, "đ"); // Vẽ biểu đồ cột
            }
        }

        /// <summary>
        /// Sự kiện thay đổi kỳ thống kê thời gian trong tab Báo Cáo.
        /// </summary>
        private void cboKyBaoCaoSelectedIndexChanged(object sender, EventArgs e)
        {
            capNhatThongKe(); // Cập nhật lại số liệu thống kê
            if (pnlBieuDoThongKe != null) pnlBieuDoThongKe.Invalidate(); // Vẽ lại biểu đồ
        }

        /// <summary>
        /// Sự kiện thay đổi kiểu hiển thị biểu đồ trực quan.
        /// </summary>
        private void cboCheDoBieuDoSelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlBieuDoThongKe != null) pnlBieuDoThongKe.Invalidate(); // Vẽ lại biểu đồ theo kiểu mới
        }

        /// <summary>
        /// Xuất Báo cáo Doanh thu & Bán hàng ra tệp Excel chuẩn biểu mẫu doanh nghiệp Việt Tiến.
        /// </summary>
        private void btnBaoCaoDoanhThuClick(object sender, EventArgs e)
        {
            DateTime tuNgay; // Biến từ ngày
            DateTime denNgay; // Biến đến ngày
            layKhoangThoiGianThongKe(out tuNgay, out denNgay); // Lấy khoảng ngày

            List<HoaDon> dsLoc = new List<HoaDon>(); // Danh sách hóa đơn trong kỳ
            foreach (HoaDon hd in KhoDuLieu.DanhSachHoaDon) // Duyệt qua các hóa đơn
            {
                if (hd.NgayLap >= tuNgay && hd.NgayLap <= denNgay) dsLoc.Add(hd); // Lọc hóa đơn theo kỳ
            }

            if (dsLoc.Count == 0) dsLoc = new List<HoaDon>(KhoDuLieu.DanhSachHoaDon); // Nếu rỗng lấy toàn bộ

            using (SaveFileDialog sfd = new SaveFileDialog()) // Khởi tạo hộp thoại lưu
            {
                sfd.Filter = "Tệp Excel (*.xls)|*.xls|Tất cả tệp (*.*)|*.*"; // Bộ lọc tệp Excel
                sfd.FileName = "BaoCao-DoanhThu-BanHang-VietTien-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".xls"; // Tên tệp mặc định
                sfd.Title = "Xuất Báo Cáo Doanh Thu Chuẩn Biểu Mẫu Excel"; // Tiêu đề cửa sổ

                if (sfd.ShowDialog(this) == DialogResult.OK) // Người dùng chọn lưu
                {
                    string nguoiLap = authService.layNhanVienHienTai() != null ? authService.layNhanVienHienTai().HoTen : "Quản lý cửa hàng"; // Tên người lập
                    string thongBao; // Thông báo
                    if (XuatExcel.XuatBaoCaoDoanhThu(sfd.FileName, tuNgay, denNgay, dsLoc, nguoiLap, out thongBao)) // Xuất Excel
                    {
                        lblStatusThongBao.Text = "Đã xuất báo cáo: " + System.IO.Path.GetFileName(sfd.FileName); // Báo thanh trạng thái
                        DialogResult dr = MessageBox.Show(thongBao + "\nĐường dẫn: " + sfd.FileName + "\n\nBạn có muốn mở ngay tệp Excel để xem không?", "Xuất Báo Cáo Thành Công", MessageBoxButtons.YesNo, MessageBoxIcon.Information); // Hỏi mở tệp
                        if (dr == DialogResult.Yes) System.Diagnostics.Process.Start(sfd.FileName); // Mở tệp trực tiếp trong Excel
                    }
                    else
                    {
                        MessageBox.Show(thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Báo lỗi
                    }
                }
            }
        }

        /// <summary>
        /// Xuất Bảng Kiểm Kê Tồn Kho Hàng Hóa ra tệp Excel chuẩn biểu mẫu doanh nghiệp Việt Tiến.
        /// </summary>
        private void btnBaoCaoTonKhoClick(object sender, EventArgs e)
        {
            if (KhoDuLieu.DanhSachSanPham.Count == 0) // Kiểm tra kho rỗng
            {
                MessageBox.Show("Hiện chưa có sản phẩm nào trong kho dữ liệu để xuất bảng kiểm kê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Cảnh báo
                return; // Dừng
            }

            using (SaveFileDialog sfd = new SaveFileDialog()) // Khởi tạo hộp thoại lưu
            {
                sfd.Filter = "Tệp Excel (*.xls)|*.xls|Tất cả tệp (*.*)|*.*"; // Bộ lọc tệp Excel
                sfd.FileName = "BangKiemKe-TonKho-VietTien-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".xls"; // Tên tệp
                sfd.Title = "Xuất Bảng Kiểm Kê Tồn Kho Chuẩn Biểu Mẫu Excel"; // Tiêu đề cửa sổ

                if (sfd.ShowDialog(this) == DialogResult.OK) // Người dùng chọn lưu
                {
                    string nguoiLap = authService.layNhanVienHienTai() != null ? authService.layNhanVienHienTai().HoTen : "Thủ kho"; // Tên người lập
                    string thongBao; // Thông báo
                    if (XuatExcel.XuatBangKiemKeKho(sfd.FileName, KhoDuLieu.DanhSachSanPham, nguoiLap, out thongBao)) // Xuất kiểm kê
                    {
                        lblStatusThongBao.Text = "Đã xuất bảng kiểm kê: " + System.IO.Path.GetFileName(sfd.FileName); // Báo thanh trạng thái
                        DialogResult dr = MessageBox.Show(thongBao + "\nĐường dẫn: " + sfd.FileName + "\n\nBạn có muốn mở ngay tệp Excel để xem không?", "Xuất Kiểm Kê Thành Công", MessageBoxButtons.YesNo, MessageBoxIcon.Information); // Hỏi mở tệp
                        if (dr == DialogResult.Yes) System.Diagnostics.Process.Start(sfd.FileName); // Mở tệp trực tiếp trong Excel
                    }
                    else
                    {
                        MessageBox.Show(thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Báo lỗi
                    }
                }
            }
        }

        /// <summary>
        /// Khôi phục và nạp lại toàn bộ dữ liệu mẫu ban đầu của hệ thống.
        /// </summary>
        private void btnNapDuLieuGocClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn khôi phục toàn bộ dữ liệu mẫu ban đầu không?\nMọi dữ liệu vừa chỉnh sửa hoặc xóa sẽ được làm mới.", "Xác nhận khôi phục", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Hỏi xác nhận
            if (dr == DialogResult.Yes) // Nếu đồng ý
            {
                KhoDuLieu.DatLaiDuLieuGoc(); // Khôi phục kho dữ liệu gốc
                loadDataSanPham(""); // Nạp lại bảng sản phẩm
                loadDataKhachHang(""); // Nạp lại bảng khách hàng
                loadDataNhaCungCap(""); // Nạp lại bảng nhà cung cấp
                loadDataHoaDon(""); // Nạp lại bảng hóa đơn
                loadDataNhanVien(""); // Nạp lại bảng nhân viên
                capNhatDashboard(); // Cập nhật lại chỉ số Dashboard
                capNhatThongKe(); // Cập nhật lại thống kê
                capNhatStatusTongSo(); // Cập nhật tổng số dòng
                if (pnlBieuDoThongKe != null) pnlBieuDoThongKe.Invalidate(); // Vẽ lại biểu đồ
                lblStatusThongBao.Text = "Đã khôi phục dữ liệu mẫu ban đầu thành công."; // Báo trạng thái
                MessageBox.Show("Khôi phục toàn bộ dữ liệu mẫu ban đầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Thông báo cho người dùng
            }
        }

        private void btnLamMoiTKClick(object sender, EventArgs e)
        {
            capNhatThongKe(); // Tải lại số liệu thống kê
            lblStatusThongBao.Text = "Đã cập nhật dữ liệu báo cáo thống kê."; // Báo trạng thái
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  8. CÁC HÀM TIỆN ÍCH, ĐĂNG XUẤT VÀ SỰ KIỆN CHUNG
        // ══════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Sự kiện chuyển tab trên TabControl để cập nhật lại số lượng bản ghi dưới thanh trạng thái.
        /// Đồng thời tự động cập nhật Dashboard hoặc Thống Kê khi chuyển đến tab tương ứng.
        /// </summary>
        private void tabChinhSelectedIndexChanged(object sender, EventArgs e)
        {
            capNhatStatusTongSo(); // Gọi hàm cập nhật hiển thị tổng số dòng
            if (tabChinh.SelectedTab == tabTongQuan) capNhatDashboard(); // Nếu chuyển sang tab Tổng Quan thì cập nhật Dashboard
            if (tabChinh.SelectedTab == tabThongKe) capNhatThongKe(); // Nếu chuyển sang tab Thống Kê thì cập nhật Thống Kê
        }

        /// <summary>
        /// Hàm cập nhật số lượng dòng dữ liệu đang hiển thị của tab đang chọn.
        /// </summary>
        private void capNhatStatusTongSo()
        {
            if (tabChinh.SelectedTab == tabTongQuan) // Nếu đang ở tab Tổng Quan
                lblStatusTongSo.Text = "Tổng kho: " + KhoDuLieu.DanhSachSanPham.Count + " loại SP";
            else if (tabChinh.SelectedTab == tabSanPham) // Nếu đang ở tab Sản Phẩm
                lblStatusTongSo.Text = "Tổng số: " + dgvSanPham.Rows.Count + " sản phẩm";
            else if (tabChinh.SelectedTab == tabKhachHang) // Nếu đang ở tab Khách Hàng
                lblStatusTongSo.Text = "Tổng số: " + dgvKhachHang.Rows.Count + " khách hàng";
            else if (tabChinh.SelectedTab == tabNhaCungCap) // Nếu đang ở tab Nhà Cung Cấp
                lblStatusTongSo.Text = "Tổng số: " + dgvNhaCungCap.Rows.Count + " nhà cung cấp";
            else if (tabChinh.SelectedTab == tabHoaDon) // Nếu đang ở tab Hóa Đơn
                lblStatusTongSo.Text = "Tổng số: " + dgvHoaDon.Rows.Count + " hóa đơn";
            else if (tabChinh.SelectedTab == tabNhanVien) // Nếu đang ở tab Nhân Viên
                lblStatusTongSo.Text = "Tổng số: " + dgvNhanVien.Rows.Count + " nhân viên";
            else if (tabChinh.SelectedTab == tabThongKe) // Nếu đang ở tab Thống Kê
                lblStatusTongSo.Text = "Tổng loại: " + dgvThongKeSP.Rows.Count + " nhóm hàng";
        }

        /// <summary>
        /// Bắt sự kiện DataError trên DataGridView để ngăn chặn hộp thoại lỗi mặc định của Windows Forms.
        /// </summary>
        private void dgvDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false; // Ngăn không ném ngoại lệ làm gián đoạn chương trình
            e.Cancel = false; // Hủy bỏ hộp thoại thông báo lỗi mặc định
        }

        /// <summary>
        /// Mở hộp thoại đổi mật khẩu cho tài khoản người dùng đang đăng nhập hệ thống.
        /// </summary>
        private void btnDoiMatKhauClick(object sender, EventArgs e)
        {
            using (FormDoiMatKhau fDoi = new FormDoiMatKhau()) // Khởi tạo form đổi mật khẩu cá nhân
            {
                fDoi.ShowDialog(this); // Hiển thị hộp thoại đổi mật khẩu modal
            }
        }

        /// <summary>
        /// Phương thức xuất dữ liệu từ bảng DataGridView ra tệp tin CSV với chuẩn UTF8 có BOM cho Microsoft Excel.
        /// </summary>
        private void xuatDuLieuRaCSV(DataGridView dgv, string tenMacDinh)
        {
            if (dgv == null || dgv.Rows.Count == 0) // Kiểm tra bảng có dữ liệu để xuất không
            {
                MessageBox.Show("Bảng hiện tại không có dữ liệu để xuất tệp tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Cảnh báo bảng rỗng
                return; // Dừng thực hiện nếu không có dòng nào
            }

            using (SaveFileDialog sfd = new SaveFileDialog()) // Khởi tạo hộp thoại chọn nơi lưu tệp tin
            {
                sfd.Filter = "Tệp CSV (Excel) (*.csv)|*.csv|Tất cả tệp (*.*)|*.*"; // Thiết lập bộ lọc định dạng tệp CSV
                sfd.FileName = tenMacDinh + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv"; // Tên tệp mặc định có mốc thời gian
                sfd.Title = "Xuất dữ liệu bảng ra tệp CSV Excel"; // Tiêu đề cửa sổ chọn tệp

                if (sfd.ShowDialog(this) == DialogResult.OK) // Nếu người dùng xác nhận lưu tệp
                {
                    try // Khối bắt lỗi thao tác tệp tin
                    {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, new System.Text.UTF8Encoding(true))) // Mở luồng ghi tệp với mã hóa UTF8 có BOM
                        {
                            List<string> tieuDes = new List<string>(); // Danh sách chứa tiêu đề các cột
                            List<int> cotHienThi = new List<int>(); // Danh sách chỉ số các cột đang hiển thị

                            for (int c = 0; c < dgv.Columns.Count; c++) // Duyệt qua từng cột trong bảng
                            {
                                if (dgv.Columns[c].Visible) // Chỉ lấy cột đang hiển thị
                                {
                                    cotHienThi.Add(c); // Ghi nhận chỉ số cột
                                    string td = dgv.Columns[c].HeaderText.Replace("\"", "\"\""); // Chuẩn hóa ký tự ngoặc kép
                                    tieuDes.Add("\"" + td + "\""); // Thêm tiêu đề có ngoặc kép vào danh sách
                                }
                            }
                            sw.WriteLine(string.Join(",", tieuDes.ToArray())); // Ghi dòng tiêu đề cột vào tệp CSV

                            foreach (DataGridViewRow row in dgv.Rows) // Duyệt qua từng dòng dữ liệu trong bảng
                            {
                                if (row.IsNewRow) continue; // Bỏ qua dòng mới trống cuối bảng

                                List<string> giaTris = new List<string>(); // Danh sách chứa giá trị các ô trong dòng

                                foreach (int c in cotHienThi) // Duyệt qua các cột đang hiển thị
                                {
                                    object val = row.Cells[c].Value; // Lấy giá trị ô hiện tại
                                    string str = val != null ? val.ToString().Replace("\"", "\"\"") : ""; // Chuẩn hóa chuỗi và xử lý ngoặc kép
                                    giaTris.Add("\"" + str + "\""); // Thêm giá trị vào danh sách
                                }
                                sw.WriteLine(string.Join(",", giaTris.ToArray())); // Ghi dòng dữ liệu vào tệp CSV
                            }
                        }

                        lblStatusThongBao.Text = "Đã xuất dữ liệu ra tệp: " + System.IO.Path.GetFileName(sfd.FileName); // Báo thành công lên thanh trạng thái
                        MessageBox.Show("Xuất tệp CSV thành công!\nĐường dẫn: " + sfd.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Hiển thị thông báo hoàn tất
                    }
                    catch (Exception ex) // Bắt lỗi ngoại lệ phát sinh khi ghi tệp
                    {
                        MessageBox.Show("Lỗi khi xuất tệp tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Báo chi tiết lỗi
                    }
                }
            }
        }

        /// <summary>
        /// Nút xuất bảng kiểm kê danh mục sản phẩm thời trang ra tệp Excel chuẩn biểu mẫu.
        /// </summary>
        private void btnXuatFileSPClick(object sender, EventArgs e)
        {
            btnBaoCaoTonKhoClick(sender, e); // Tận dụng xuất kiểm kê chuẩn biểu mẫu doanh nghiệp
        }

        /// <summary>
        /// Nút xuất danh sách hội viên khách hàng thân thiết ra tệp Excel chuẩn biểu mẫu CRM.
        /// </summary>
        private void btnXuatFileKHClick(object sender, EventArgs e)
        {
            if (KhoDuLieu.DanhSachKhachHang.Count == 0) // Kiểm tra danh sách rỗng
            {
                MessageBox.Show("Hiện chưa có khách hàng nào trong kho dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Cảnh báo
                return; // Dừng
            }

            using (SaveFileDialog sfd = new SaveFileDialog()) // Khởi tạo hộp thoại lưu
            {
                sfd.Filter = "Tệp Excel (*.xls)|*.xls|Tất cả tệp (*.*)|*.*"; // Bộ lọc tệp Excel
                sfd.FileName = "DanhSach-HoiVien-VietTien-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".xls"; // Tên tệp
                sfd.Title = "Xuất Danh Sách Hội Viên Chuẩn Biểu Mẫu Excel"; // Tiêu đề

                if (sfd.ShowDialog(this) == DialogResult.OK) // Người dùng chọn lưu
                {
                    string nguoiLap = authService.layNhanVienHienTai() != null ? authService.layNhanVienHienTai().HoTen : "Chăm sóc khách hàng"; // Tên người lập
                    string thongBao; // Thông báo
                    if (XuatExcel.XuatDanhSachHoiVien(sfd.FileName, KhoDuLieu.DanhSachKhachHang, nguoiLap, out thongBao)) // Xuất danh sách
                    {
                        lblStatusThongBao.Text = "Đã xuất danh sách hội viên: " + System.IO.Path.GetFileName(sfd.FileName); // Báo trạng thái
                        DialogResult dr = MessageBox.Show(thongBao + "\nĐường dẫn: " + sfd.FileName + "\n\nBạn có muốn mở ngay tệp Excel để xem không?", "Xuất Thành Công", MessageBoxButtons.YesNo, MessageBoxIcon.Information); // Hỏi mở tệp
                        if (dr == DialogResult.Yes) System.Diagnostics.Process.Start(sfd.FileName); // Mở trực tiếp bằng Excel
                    }
                    else
                    {
                        MessageBox.Show(thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Báo lỗi
                    }
                }
            }
        }

        /// <summary>
        /// Nút xuất báo cáo doanh thu bán lẻ ra tệp Excel chuẩn biểu mẫu kế toán.
        /// </summary>
        private void btnXuatFileHDClick(object sender, EventArgs e)
        {
            btnBaoCaoDoanhThuClick(sender, e); // Tận dụng xuất báo cáo doanh thu chuẩn biểu mẫu
        }

        /// <summary>
        /// Xử lý tìm kiếm tức thời sản phẩm khi người dùng gõ vào ô nhập liệu.
        /// </summary>
        private void txtTimSPTextChanged(object sender, EventArgs e)
        {
            loadDataSanPham(txtTimSP.Text.Trim()); // Nạp lại danh sách theo từ khóa vừa gõ
        }

        /// <summary>
        /// Xử lý sự kiện nhấn nút ĐĂNG XUẤT trên thanh tiêu đề.
        /// Đánh dấu cờ DaDangXuat = true để Program.cs mở lại FormDangNhap.
        /// </summary>
        private void btnDangXuatClick(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại hỏi người dùng xác nhận đăng xuất
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes) // Nếu người dùng chọn Yes đồng ý đăng xuất
            {
                DaDangXuat = true; // Bật cờ DaDangXuat = true để Program.cs biết là đang đăng xuất
                authService.dangXuat(); // Gọi nghiệp vụ xóa phiên đăng nhập hiện tại
                this.Close(); // Đóng Form1 hiện tại lại
            }
        }
    }
}
