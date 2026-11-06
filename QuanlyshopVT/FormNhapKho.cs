using System; // Sử dụng thư viện cơ bản của hệ thống .NET Framework
using System.Collections.Generic; // Sử dụng danh sách kiểu đối tượng List
using System.Windows.Forms; // Sử dụng các thành phần điều khiển giao diện Windows Forms

namespace QuanlyshopVT // Không gian tên chính thức của dự án Quản lý Shop Thời trang Việt Tiến
{
    /// <summary>
    /// Cửa sổ thực hiện nghiệp vụ Nhập Kho Hàng Hóa chuyên trách cho Thủ kho và Quản lý.
    /// Giúp bổ sung số lượng tồn kho, cập nhật đơn giá nhập và gắn với đối tác Nhà Cung Cấp.
    /// </summary>
    public partial class FormNhapKho : Form // Kế thừa từ lớp Form của Windows Forms
    {
        private string maSanPhamChon; // Biến lưu mã sản phẩm được chỉ định ban đầu nếu có

        /// <summary>
        /// Hàm khởi tạo mặc định cho FormNhapKho.
        /// </summary>
        /// <param name="maSP">Mã sản phẩm chọn sẵn trên bảng dữ liệu nếu có</param>
        public FormNhapKho(string maSP = "") // Hàm khởi tạo nhận tham số mặc định
        {
            InitializeComponent(); // Khởi tạo toàn bộ giao diện từ Designer
            maSanPhamChon = maSP; // Gán mã sản phẩm truyền vào
        }

        /// <summary>
        /// Sự kiện khi form nạp lên màn hình: tải danh mục sản phẩm và nhà cung cấp.
        /// </summary>
        private void FormNhapKhoLoad(object sender, EventArgs e) // Hàm xử lý khi mở form
        {
            napDanhSachSanPham(); // Nạp dữ liệu các mặt hàng vào danh sách chọn
            napDanhSachNhaCungCap(); // Nạp dữ liệu các đối tác cung ứng hàng hóa
        }

        /// <summary>
        /// Nạp danh sách các sản phẩm đang có trong hệ thống vào ComboBox.
        /// </summary>
        private void napDanhSachSanPham() // Hàm tải sản phẩm vào hộp chọn
        {
            cboSanPham.Items.Clear(); // Xóa sạch các mục cũ trong danh sách
            int viTriMacDinh = 0; // Biến ghi nhận vị trí sản phẩm được chọn mặc định
            int dem = 0; // Biến đếm thứ tự lặp

            foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt qua toàn bộ danh sách sản phẩm
            {
                cboSanPham.Items.Add(sp.MaHang + " - " + sp.TenSP + " (" + sp.LoaiSP + ")"); // Thêm chuỗi hiển thị
                if (!string.IsNullOrEmpty(maSanPhamChon) && sp.MaHang.Equals(maSanPhamChon, StringComparison.OrdinalIgnoreCase)) // So sánh mã
                {
                    viTriMacDinh = dem; // Ghi nhớ vị trí trùng khớp
                }
                dem++; // Tăng biến đếm
            }

            if (cboSanPham.Items.Count > 0) // Kiểm tra nếu có ít nhất một sản phẩm
            {
                cboSanPham.SelectedIndex = viTriMacDinh; // Chọn phần tử theo vị trí đã xác định
            }
        }

        /// <summary>
        /// Nạp danh sách các Nhà Cung Cấp đối tác vào ComboBox.
        /// </summary>
        private void napDanhSachNhaCungCap() // Hàm tải nhà cung cấp vào hộp chọn
        {
            cboNhaCungCap.Items.Clear(); // Xóa sạch danh sách cũ

            foreach (NhaCungCap ncc in KhoDuLieu.DanhSachNhaCungCap) // Duyệt qua tất cả nhà cung cấp trong kho dữ liệu
            {
                cboNhaCungCap.Items.Add(ncc.MaNhaCungCap + " - " + ncc.TenNCC + " (" + ncc.NguoiDaiDien + ")"); // Thêm tên đối tác
            }

            if (cboNhaCungCap.Items.Count > 0) // Kiểm tra nếu có dữ liệu
            {
                cboNhaCungCap.SelectedIndex = 0; // Chọn mục nhà cung cấp đầu tiên
            }
        }

        /// <summary>
        /// Sự kiện khi người dùng đổi sản phẩm cần nhập trong danh sách ComboBox.
        /// </summary>
        private void cboSanPhamSelectedIndexChanged(object sender, EventArgs e) // Hàm xử lý đổi sản phẩm
        {
            SanPham sp = laySanPhamDangChon(); // Lấy đối tượng sản phẩm hiện hành
            if (sp != null) // Nếu tìm thấy sản phẩm hợp lệ
            {
                txtTonHienTai.Text = sp.SoLuongTon.ToString("N0") + " chiếc"; // Hiển thị số lượng tồn kho hiện có
                txtGiaNhapCu.Text = sp.GiaNhap.ToString("N0") + " đ"; // Hiển thị giá vốn nhập hiện tại
                numGiaNhapMoi.Value = sp.GiaNhap; // Điền sẵn giá vốn cũ vào ô giá mới để dễ chỉnh sửa
                capNhatTonSauNhap(); // Tính toán và hiển thị dự kiến tồn sau nhập
            }
        }

        /// <summary>
        /// Sự kiện khi người dùng thay đổi số lượng nhập thêm trong ô NumericUpDown.
        /// </summary>
        private void numSoLuongNhapValueChanged(object sender, EventArgs e) // Hàm xử lý đổi số lượng
        {
            capNhatTonSauNhap(); // Cập nhật lại số lượng tồn kho dự kiến sau nhập
        }

        /// <summary>
        /// Tính toán tổng số lượng tồn kho sau khi cộng thêm số lượng nhập mới.
        /// </summary>
        private void capNhatTonSauNhap() // Hàm tính toán tồn kho dự kiến
        {
            SanPham sp = laySanPhamDangChon(); // Lấy thông tin sản phẩm đang chọn
            if (sp != null) // Nếu sản phẩm tồn tại
            {
                int soLuongThem = (int)numSoLuongNhap.Value; // Lấy số lượng nhập thêm từ ô nhập
                int tonMoi = sp.SoLuongTon + soLuongThem; // Tính tổng tồn kho mới
                txtTonSauKhiNhap.Text = tonMoi.ToString("N0") + " chiếc (+" + soLuongThem + ")"; // Hiển thị ra giao diện
            }
        }

        /// <summary>
        /// Lấy đối tượng sản phẩm đang được chọn trong danh mục ComboBox.
        /// </summary>
        /// <returns>Đối tượng SanPham tương ứng hoặc null</returns>
        private SanPham laySanPhamDangChon() // Hàm truy xuất sản phẩm theo vị trí chọn
        {
            if (cboSanPham.SelectedIndex < 0 || cboSanPham.SelectedIndex >= KhoDuLieu.DanhSachSanPham.Count) // Kiểm tra chỉ số
            {
                return null; // Trả về rỗng nếu không hợp lệ
            }
            return KhoDuLieu.DanhSachSanPham[cboSanPham.SelectedIndex]; // Trả về sản phẩm tương ứng trong danh sách
        }

        /// <summary>
        /// Xử lý xác nhận nhập thêm hàng hóa vào kho: cộng dồn tồn kho và cập nhật giá vốn.
        /// </summary>
        private void btnXacNhanNhapClick(object sender, EventArgs e) // Hàm xử lý khi bấm nút Xác Nhận Nhập
        {
            SanPham sp = laySanPhamDangChon(); // Lấy sản phẩm cần nhập
            if (sp == null) // Nếu chưa chọn sản phẩm
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm cần nhập hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Cảnh báo
                return; // Dừng xử lý
            }

            int soLuongNhap = (int)numSoLuongNhap.Value; // Lấy số lượng nhập thêm
            if (soLuongNhap <= 0) // Kiểm tra số lượng nhập phải lớn hơn không
            {
                MessageBox.Show("Số lượng nhập kho phải lớn hơn 0 chiếc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Cảnh báo
                return; // Dừng xử lý
            }

            decimal giaNhapMoi = numGiaNhapMoi.Value; // Lấy đơn giá nhập đợt này
            string tenNCC = cboNhaCungCap.SelectedItem != null ? cboNhaCungCap.SelectedItem.ToString() : "Nội bộ"; // Lấy tên đối tác

            // Cập nhật tăng số lượng tồn kho trong bộ nhớ hệ thống
            sp.SoLuongTon += soLuongNhap; // Cộng dồn số lượng tồn mới vào kho

            // Cập nhật giá nhập mới nếu người dùng điều chỉnh
            if (giaNhapMoi > 0) // Kiểm tra nếu có đơn giá hợp lệ
            {
                sp.GiaNhap = giaNhapMoi; // Cập nhật lại giá vốn sản phẩm
            }

            // Hiển thị thông báo hoàn tất giao dịch nhập kho chuyên nghiệp
            string thongBao = "XÁC NHẬN NHẬP KHO THÀNH CÔNG!\n\n" +
                              "Mã sản phẩm: " + sp.MaHang + "\n" +
                              "Tên sản phẩm: " + sp.TenSP + "\n" +
                              "Số lượng nhập thêm: +" + soLuongNhap.ToString("N0") + " chiếc\n" +
                              "Tổng tồn kho mới: " + sp.SoLuongTon.ToString("N0") + " chiếc\n" +
                              "Đơn giá nhập: " + sp.GiaNhap.ToString("N0") + " đ\n" +
                              "Nhà cung cấp: " + tenNCC; // Chuỗi thông tin chi tiết biên bản nhập

            MessageBox.Show(thongBao, "Biên Bản Nhập Kho", MessageBoxButtons.OK, MessageBoxIcon.Information); // Hiện hộp thoại thông tin

            this.DialogResult = DialogResult.OK; // Đặt kết quả hộp thoại là thành công
            this.Close(); // Đóng cửa sổ nhập kho lại
        }

        /// <summary>
        /// Xử lý khi người dùng bấm nút Hủy Bỏ để đóng form mà không lưu thay đổi.
        /// </summary>
        private void btnHuyBoClick(object sender, EventArgs e) // Hàm xử lý khi bấm nút Hủy
        {
            this.DialogResult = DialogResult.Cancel; // Đặt kết quả là hủy
            this.Close(); // Đóng cửa sổ nhập kho
        }
    }
}
