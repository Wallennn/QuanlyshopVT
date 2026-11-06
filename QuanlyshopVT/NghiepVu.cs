using System; // Sử dụng các kiểu dữ liệu và phương thức xử lý chuỗi của .NET
using System.Collections.Generic; // Sử dụng danh sách động List<T> để thao tác tập hợp dữ liệu

namespace QuanlyshopVT // Không gian tên chính của dự án Quản lý Shop Thời trang Việt Tiến
{
    // ══════════════════════════════════════════════════════════════════════════════
    //  TẦNG NGHIỆP VỤ (SERVICE LAYER) – SHOP THỜI TRANG VIETTIEN
    //  Tổ chức và tên phương thức hoàn toàn chuẩn theo dự án BAOCAO Java
    //  Chú thích công dụng chi tiết của từng dòng mã nguồn
    // ══════════════════════════════════════════════════════════════════════════════

    /// <summary>
    /// SanPhamService – Nghiệp vụ quản lý danh mục sản phẩm thời trang Việt Tiến.
    /// Tương tự ThuocService.java trong dự án BAOCAO Java.
    /// </summary>
    public class SanPhamService
    {
        /// <summary>
        /// Lấy toàn bộ danh sách sản phẩm thời trang đang có trong kho.
        /// Tương tự layDanhSach trong ThuocService.java.
        /// </summary>
        public List<SanPham> layDanhSach()
        {
            return new List<SanPham>(KhoDuLieu.DanhSachSanPham); // Tạo bản sao danh sách sản phẩm để trả về
        }

        /// <summary>
        /// Tìm kiếm sản phẩm theo từ khóa (mã hàng, tên sản phẩm, loại hoặc màu sắc).
        /// Tương tự timKiem trong ThuocService.java.
        /// </summary>
        public List<SanPham> timKiem(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa)) // Nếu từ khóa rỗng hoặc null
                return layDanhSach(); // Trả về tất cả sản phẩm

            string tk = tuKhoa.Trim().ToLower(); // Chuyển từ khóa về chữ thường và xóa khoảng trắng thừa
            List<SanPham> kq = new List<SanPham>(); // Danh sách chứa các sản phẩm thỏa mãn điều kiện

            foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt từng sản phẩm trong kho dữ liệu
            {
                // Kiểm tra xem từ khóa có xuất hiện trong mã hàng, tên sản phẩm, loại hoặc màu sắc không
                if ((sp.MaHang != null && sp.MaHang.ToLower().Contains(tk)) ||
                    (sp.TenSP != null && sp.TenSP.ToLower().Contains(tk)) ||
                    (sp.LoaiSP != null && sp.LoaiSP.ToLower().Contains(tk)) ||
                    (sp.MauSacSP != null && sp.MauSacSP.ToLower().Contains(tk)))
                {
                    kq.Add(sp); // Thêm sản phẩm phù hợp vào danh sách kết quả
                }
            }
            return kq; // Trả về danh sách kết quả tìm kiếm
        }

        /// <summary>
        /// Lọc danh sách sản phẩm thời trang theo đa tiêu chí: từ khóa, phân loại, tầm giá và tồn kho.
        /// </summary>
        public List<SanPham> locNangCao(string tuKhoa, string loaiSP, string mucGia, string tonKho)
        {
            List<SanPham> ds = timKiem(tuKhoa); // Lọc bước đầu theo từ khóa tìm kiếm
            List<SanPham> kq = new List<SanPham>(); // Danh sách kết quả thỏa mãn tất cả điều kiện

            foreach (SanPham sp in ds) // Duyệt qua từng sản phẩm
            {
                // 1. Kiểm tra lọc phân loại sản phẩm
                if (!string.IsNullOrEmpty(loaiSP) && !loaiSP.Equals("Tất cả loại") && !loaiSP.Equals("Tất cả"))
                {
                    if (sp.LoaiSP == null || !sp.LoaiSP.Equals(loaiSP, StringComparison.OrdinalIgnoreCase)) continue;
                }

                // 2. Kiểm tra lọc theo khoảng giá bán
                if (!string.IsNullOrEmpty(mucGia) && !mucGia.Equals("Tất cả mức giá") && !mucGia.Equals("Tất cả giá"))
                {
                    if (mucGia.Contains("Dưới 300") && sp.GiaBan >= 300000) continue;
                    if (mucGia.Contains("300") && mucGia.Contains("700") && (sp.GiaBan < 300000 || sp.GiaBan > 700000)) continue;
                    if (mucGia.Contains("Trên 700") && sp.GiaBan <= 700000) continue;
                }

                // 3. Kiểm tra lọc theo tình trạng tồn kho
                if (!string.IsNullOrEmpty(tonKho) && !tonKho.Equals("Tất cả tồn kho") && !tonKho.Equals("Tất cả"))
                {
                    if (tonKho.Contains("Còn nhiều") && sp.SoLuongTon <= 20) continue;
                    if (tonKho.Contains("Sắp hết") && (sp.SoLuongTon > 10 || sp.SoLuongTon <= 0)) continue;
                    if (tonKho.Contains("Hết hàng") && sp.SoLuongTon > 0) continue;
                }

                kq.Add(sp); // Thêm sản phẩm thỏa mãn vào danh sách
            }
            return kq; // Trả về danh sách kết quả sau khi lọc
        }

        /// <summary>
        /// Tìm và trả về đối tượng sản phẩm theo mã ID.
        /// </summary>
        public SanPham layTheoId(int maSP)
        {
            foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt qua các sản phẩm trong kho
            {
                if (sp.MaSP == maSP) return sp; // Nếu trùng mã ID thì trả về ngay đối tượng đó
            }
            return null; // Không tìm thấy thì trả về null
        }

        /// <summary>
        /// Thêm mới một sản phẩm vào kho dữ liệu sau khi kiểm tra hợp lệ.
        /// Tương tự themThuoc trong ThuocService.java.
        /// </summary>
        public bool themSanPham(SanPham sp, out string thongBaoLoi)
        {
            if (!kiemTraSanPham(sp, out thongBaoLoi)) return false; // Kiểm tra dữ liệu đầu vào, nếu sai thì dừng

            if (string.IsNullOrEmpty(sp.MaHang)) // Nếu người dùng chưa nhập mã hàng
            {
                sp.MaHang = "VT" + KhoDuLieu.DanhSachSanPham.Count.ToString("D3"); // Tự động sinh mã hàng VTxxx
            }
            sp.MaSP = KhoDuLieu.SinhMaSP(); // Tự động sinh mã ID mới cho sản phẩm
            KhoDuLieu.DanhSachSanPham.Add(sp); // Thêm sản phẩm vào danh sách trong kho dữ liệu
            thongBaoLoi = "Thêm sản phẩm thành công."; // Báo thông điệp thành công
            return true; // Trả về kết quả thành công
        }

        /// <summary>
        /// Cập nhật thông tin của một sản phẩm đã có trong kho dữ liệu.
        /// Tương tự suaThuoc trong ThuocService.java.
        /// </summary>
        public bool suaSanPham(SanPham spMoi, out string thongBaoLoi)
        {
            if (!kiemTraSanPham(spMoi, out thongBaoLoi)) return false; // Kiểm tra hợp lệ dữ liệu sửa

            for (int i = 0; i < KhoDuLieu.DanhSachSanPham.Count; i++) // Lặp qua danh sách để tìm sản phẩm cũ
            {
                if (KhoDuLieu.DanhSachSanPham[i].MaSP == spMoi.MaSP) // Nếu trùng mã ID
                {
                    KhoDuLieu.DanhSachSanPham[i] = spMoi; // Ghi đè thông tin mới vào vị trí cũ
                    thongBaoLoi = "Cập nhật sản phẩm thành công."; // Báo thành công
                    return true; // Kết thúc hàm với kết quả thành công
                }
            }
            thongBaoLoi = "Không tìm thấy sản phẩm cần cập nhật."; // Báo lỗi nếu không tìm thấy ID
            return false; // Trả về thất bại
        }

        /// <summary>
        /// Xóa bỏ một sản phẩm khỏi danh sách theo mã ID.
        /// Tương tự xoaThuoc trong ThuocService.java.
        /// </summary>
        public bool xoaSanPham(int maSP, out string thongBaoLoi)
        {
            SanPham sp = layTheoId(maSP); // Tìm sản phẩm cần xóa theo ID
            if (sp == null) // Nếu không tồn tại
            {
                thongBaoLoi = "Sản phẩm không tồn tại."; // Báo lỗi
                return false; // Trả về thất bại
            }
            KhoDuLieu.DanhSachSanPham.Remove(sp); // Xóa đối tượng sản phẩm khỏi kho
            thongBaoLoi = "Xóa sản phẩm thành công."; // Báo thành công
            return true; // Trả về thành công
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của dữ liệu sản phẩm (validate logic).
        /// </summary>
        public bool kiemTraSanPham(SanPham sp, out string thongBaoLoi)
        {
            if (sp == null) // Kiểm tra đối tượng có bị rỗng không
            {
                thongBaoLoi = "Dữ liệu sản phẩm không được rỗng.";
                return false;
            }
            if (string.IsNullOrEmpty(sp.TenSP) || sp.TenSP.Trim().Length == 0) // Kiểm tra tên sản phẩm
            {
                thongBaoLoi = "Tên sản phẩm không được để trống.";
                return false;
            }
            if (sp.GiaNhap < 0) // Kiểm tra giá nhập không được âm
            {
                thongBaoLoi = "Giá nhập không được âm.";
                return false;
            }
            if (sp.GiaBan < 0) // Kiểm tra giá bán không được âm
            {
                thongBaoLoi = "Giá bán không được âm.";
                return false;
            }
            if (sp.SoLuongTon < 0) // Kiểm tra tồn kho không được âm
            {
                thongBaoLoi = "Số lượng tồn không được âm.";
                return false;
            }
            thongBaoLoi = ""; // Dữ liệu hoàn toàn hợp lệ
            return true;
        }
    }

    /// <summary>
    /// KhachHangService – Nghiệp vụ quản lý khách hàng thân thiết.
    /// Tương tự KhachHangService.java trong dự án BAOCAO Java.
    /// </summary>
    public class KhachHangService
    {
        public List<KhachHang> layDanhSach()
        {
            return new List<KhachHang>(KhoDuLieu.DanhSachKhachHang); // Trả về bản sao danh sách khách hàng
        }

        public List<KhachHang> timKiem(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa)) // Nếu không có từ khóa
                return layDanhSach(); // Trả về toàn bộ danh sách

            string tk = tuKhoa.Trim().ToLower(); // Chuyển từ khóa về chữ thường
            List<KhachHang> kq = new List<KhachHang>(); // Danh sách kết quả

            foreach (KhachHang kh in KhoDuLieu.DanhSachKhachHang) // Duyệt qua từng khách hàng
            {
                // Kiểm tra từ khóa trong mã khách hàng, họ tên hoặc số điện thoại
                if ((kh.MaKhachHang != null && kh.MaKhachHang.ToLower().Contains(tk)) ||
                    (kh.HoTen != null && kh.HoTen.ToLower().Contains(tk)) ||
                    (kh.SoDienThoai != null && kh.SoDienThoai.Contains(tk)))
                {
                    kq.Add(kh); // Thêm khách hàng thỏa mãn vào danh sách
                }
            }
            return kq; // Trả về kết quả
        }

        public KhachHang layTheoId(int maKH)
        {
            foreach (KhachHang kh in KhoDuLieu.DanhSachKhachHang) // Duyệt qua danh sách khách hàng
            {
                if (kh.MaKH == maKH) return kh; // Nếu trùng mã ID thì trả về
            }
            return null; // Không thấy thì trả về null
        }

        public bool themKhachHang(KhachHang kh, out string thongBaoLoi)
        {
            if (kh == null || string.IsNullOrEmpty(kh.HoTen)) // Kiểm tra bắt buộc có họ tên
            {
                thongBaoLoi = "Họ tên khách hàng không được để trống.";
                return false;
            }
            if (string.IsNullOrEmpty(kh.MaKhachHang)) // Tự sinh mã nếu chưa có
            {
                kh.MaKhachHang = "KH" + KhoDuLieu.DanhSachKhachHang.Count.ToString("D3");
            }
            kh.MaKH = KhoDuLieu.SinhMaKH(); // Sinh mã ID mới
            KhoDuLieu.DanhSachKhachHang.Add(kh); // Thêm vào kho dữ liệu
            thongBaoLoi = "Thêm khách hàng thành công.";
            return true;
        }

        public bool suaKhachHang(KhachHang khMoi, out string thongBaoLoi)
        {
            if (khMoi == null || string.IsNullOrEmpty(khMoi.HoTen)) // Kiểm tra bắt buộc họ tên
            {
                thongBaoLoi = "Họ tên khách hàng không được để trống.";
                return false;
            }
            for (int i = 0; i < KhoDuLieu.DanhSachKhachHang.Count; i++) // Tìm khách hàng cũ
            {
                if (KhoDuLieu.DanhSachKhachHang[i].MaKH == khMoi.MaKH) // Nếu trùng ID
                {
                    KhoDuLieu.DanhSachKhachHang[i] = khMoi; // Cập nhật thông tin mới
                    thongBaoLoi = "Cập nhật thông tin khách hàng thành công.";
                    return true;
                }
            }
            thongBaoLoi = "Không tìm thấy khách hàng.";
            return false;
        }

        public bool xoaKhachHang(int maKH, out string thongBaoLoi)
        {
            KhachHang kh = layTheoId(maKH); // Tìm khách hàng theo ID
            if (kh == null)
            {
                thongBaoLoi = "Khách hàng không tồn tại.";
                return false;
            }
            KhoDuLieu.DanhSachKhachHang.Remove(kh); // Xóa khỏi danh sách
            thongBaoLoi = "Xóa khách hàng thành công.";
            return true;
        }
    }

    /// <summary>
    /// NhaCungCapService – Nghiệp vụ quản lý đối tác cung cấp may mặc.
    /// Tương tự NhaCungCapService.java trong dự án BAOCAO Java.
    /// </summary>
    public class NhaCungCapService
    {
        public List<NhaCungCap> layDanhSach()
        {
            return new List<NhaCungCap>(KhoDuLieu.DanhSachNhaCungCap); // Trả về bản sao danh sách
        }

        public List<NhaCungCap> timKiem(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa))
                return layDanhSach();

            string tk = tuKhoa.Trim().ToLower(); // Chuyển từ khóa sang chữ thường
            List<NhaCungCap> kq = new List<NhaCungCap>(); // Danh sách kết quả

            foreach (NhaCungCap ncc in KhoDuLieu.DanhSachNhaCungCap) // Duyệt từng nhà cung cấp
            {
                // Kiểm tra từ khóa trong mã, tên hoặc số điện thoại
                if ((ncc.MaNhaCungCap != null && ncc.MaNhaCungCap.ToLower().Contains(tk)) ||
                    (ncc.TenNCC != null && ncc.TenNCC.ToLower().Contains(tk)) ||
                    (ncc.DienThoai != null && ncc.DienThoai.Contains(tk)))
                {
                    kq.Add(ncc); // Thêm đối tác thỏa mãn
                }
            }
            return kq;
        }

        public NhaCungCap layTheoId(int maNCC)
        {
            foreach (NhaCungCap ncc in KhoDuLieu.DanhSachNhaCungCap) // Tìm NCC theo ID
            {
                if (ncc.MaNCC == maNCC) return ncc;
            }
            return null;
        }

        public bool themNhaCungCap(NhaCungCap ncc, out string thongBaoLoi)
        {
            if (ncc == null || string.IsNullOrEmpty(ncc.TenNCC)) // Kiểm tra tên NCC bắt buộc
            {
                thongBaoLoi = "Tên nhà cung cấp không được để trống.";
                return false;
            }
            if (string.IsNullOrEmpty(ncc.MaNhaCungCap)) // Tự sinh mã nếu chưa có
            {
                ncc.MaNhaCungCap = "NCC" + KhoDuLieu.DanhSachNhaCungCap.Count.ToString("D3");
            }
            ncc.MaNCC = KhoDuLieu.SinhMaNCC(); // Sinh mã ID tự tăng
            KhoDuLieu.DanhSachNhaCungCap.Add(ncc); // Thêm vào kho dữ liệu
            thongBaoLoi = "Thêm nhà cung cấp thành công.";
            return true;
        }

        public bool suaNhaCungCap(NhaCungCap nccMoi, out string thongBaoLoi)
        {
            if (nccMoi == null || string.IsNullOrEmpty(nccMoi.TenNCC)) // Kiểm tra tên NCC bắt buộc
            {
                thongBaoLoi = "Tên nhà cung cấp không được để trống.";
                return false;
            }
            for (int i = 0; i < KhoDuLieu.DanhSachNhaCungCap.Count; i++) // Tìm NCC cũ
            {
                if (KhoDuLieu.DanhSachNhaCungCap[i].MaNCC == nccMoi.MaNCC) // Nếu trùng ID
                {
                    KhoDuLieu.DanhSachNhaCungCap[i] = nccMoi; // Cập nhật thông tin
                    thongBaoLoi = "Cập nhật nhà cung cấp thành công.";
                    return true;
                }
            }
            thongBaoLoi = "Không tìm thấy nhà cung cấp.";
            return false;
        }

        public bool xoaNhaCungCap(int maNCC, out string thongBaoLoi)
        {
            NhaCungCap ncc = layTheoId(maNCC); // Tìm NCC theo ID
            if (ncc == null)
            {
                thongBaoLoi = "Nhà cung cấp không tồn tại.";
                return false;
            }
            KhoDuLieu.DanhSachNhaCungCap.Remove(ncc); // Xóa khỏi danh sách
            thongBaoLoi = "Xóa nhà cung cấp thành công.";
            return true;
        }
    }

    /// <summary>
    /// HoaDonService – Nghiệp vụ lập và tra cứu hóa đơn bán hàng.
    /// Tương tự BanThuocService.java trong dự án BAOCAO Java.
    /// </summary>
    public class HoaDonService
    {
        public List<HoaDon> layDanhSach()
        {
            return new List<HoaDon>(KhoDuLieu.DanhSachHoaDon); // Trả về bản sao danh sách hóa đơn
        }

        public List<HoaDon> timKiem(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa))
                return layDanhSach();

            string tk = tuKhoa.Trim().ToLower(); // Chuyển từ khóa sang chữ thường
            List<HoaDon> kq = new List<HoaDon>(); // Danh sách kết quả

            foreach (HoaDon hd in KhoDuLieu.DanhSachHoaDon) // Duyệt từng hóa đơn
            {
                // Kiểm tra từ khóa trong mã hóa đơn, tên khách hàng hoặc tên nhân viên
                if ((hd.MaHoaDon != null && hd.MaHoaDon.ToLower().Contains(tk)) ||
                    (hd.TenKhachHang != null && hd.TenKhachHang.ToLower().Contains(tk)) ||
                    (hd.TenNhanVien != null && hd.TenNhanVien.ToLower().Contains(tk)))
                {
                    kq.Add(hd); // Thêm hóa đơn thỏa mãn
                }
            }
            return kq;
        }

        /// <summary>
        /// Lọc danh sách hóa đơn theo đa tiêu chí: từ khóa, trạng thái và mốc thời gian.
        /// </summary>
        public List<HoaDon> locNangCao(string tuKhoa, string trangThai, string kyThoiGian)
        {
            List<HoaDon> ds = timKiem(tuKhoa); // Lọc ban đầu theo từ khóa
            List<HoaDon> kq = new List<HoaDon>(); // Danh sách kết quả

            DateTime homNay = DateTime.Today; // Ngày hôm nay
            foreach (HoaDon hd in ds) // Duyệt qua từng hóa đơn
            {
                // 1. Kiểm tra lọc trạng thái
                if (!string.IsNullOrEmpty(trangThai) && !trangThai.Equals("Tất cả trạng thái") && !trangThai.Equals("Tất cả"))
                {
                    if (hd.TrangThai == null || !hd.TrangThai.Equals(trangThai, StringComparison.OrdinalIgnoreCase)) continue;
                }

                // 2. Kiểm tra lọc khoảng thời gian
                if (!string.IsNullOrEmpty(kyThoiGian) && !kyThoiGian.Equals("Tất cả thời gian") && !kyThoiGian.Equals("Tất cả"))
                {
                    if (kyThoiGian.Contains("Hôm nay") && hd.NgayLap.Date != homNay) continue;
                    if (kyThoiGian.Contains("7 ngày") && hd.NgayLap.Date < homNay.AddDays(-7)) continue;
                    if (kyThoiGian.Contains("Tháng này") && (hd.NgayLap.Month != homNay.Month || hd.NgayLap.Year != homNay.Year)) continue;
                }

                kq.Add(hd); // Thêm hóa đơn thỏa mãn
            }
            return kq; // Trả về danh sách kết quả sau khi lọc
        }

        public List<ChiTietHoaDon> layChiTietHoaDon(int maHD)
        {
            List<ChiTietHoaDon> kq = new List<ChiTietHoaDon>(); // Danh sách dòng chi tiết
            foreach (ChiTietHoaDon ct in KhoDuLieu.DanhSachChiTietHoaDon) // Lặp qua tất cả chi tiết
            {
                if (ct.MaHD == maHD) kq.Add(ct); // Thêm các dòng thuộc về hóa đơn này
            }
            return kq; // Trả về kết quả
        }

        public bool huyHoaDon(int maHD, out string thongBaoLoi)
        {
            foreach (HoaDon hd in KhoDuLieu.DanhSachHoaDon) // Tìm hóa đơn theo mã ID
            {
                if (hd.MaHD == maHD)
                {
                    hd.TrangThai = "Đã hủy"; // Cập nhật trạng thái thành Đã hủy
                    thongBaoLoi = "Đã hủy hóa đơn " + hd.MaHoaDon;
                    return true;
                }
            }
            thongBaoLoi = "Không tìm thấy hóa đơn.";
            return false;
        }
    }

    /// <summary>
    /// AuthService – Nghiệp vụ xác thực đăng nhập và quản lý tài khoản nhân viên.
    /// Tương tự AuthService.java trong dự án BAOCAO Java.
    /// </summary>
    public class AuthService
    {
        public bool dangNhap(string tenDangNhap, string matKhau, out NhanVien nv, out string thongBaoLoi)
        {
            nv = null; // Khởi tạo biến đầu ra là null
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau)) // Kiểm tra rỗng
            {
                thongBaoLoi = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                return false;
            }

            foreach (NhanVien n in KhoDuLieu.DanhSachNhanVien) // Tìm tài khoản trong kho
            {
                // So khớp chính xác tên đăng nhập (không phân biệt hoa thường) và mật khẩu
                if (n.TenDangNhap.Equals(tenDangNhap.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    n.MatKhau.Equals(matKhau.Trim()))
                {
                    if (n.TrangThai != null && n.TrangThai.Equals("Đã khóa", StringComparison.OrdinalIgnoreCase))
                    {
                        thongBaoLoi = "Tài khoản của bạn đã bị khóa. Vui lòng liên hệ quản trị viên.";
                        return false; // Chặn nếu tài khoản bị khóa
                    }
                    nv = n; // Gán nhân viên đăng nhập thành công
                    KhoDuLieu.NguoiDangNhapHienTai = n; // Lưu vào phiên làm việc hiện tại
                    thongBaoLoi = "Đăng nhập thành công.";
                    return true; // Trả về thành công
                }
            }

            thongBaoLoi = "Tên đăng nhập hoặc mật khẩu không chính xác.";
            return false; // Sai thông tin đăng nhập
        }

        public void dangXuat()
        {
            KhoDuLieu.NguoiDangNhapHienTai = null; // Xóa sạch phiên đăng nhập hiện tại
        }

        public NhanVien layNhanVienHienTai()
        {
            return KhoDuLieu.NguoiDangNhapHienTai; // Trả về nhân viên đang đăng nhập
        }

        public bool laQuanLy()
        {
            if (KhoDuLieu.NguoiDangNhapHienTai == null) return false;
            return KhoDuLieu.NguoiDangNhapHienTai.LaQuanLy(); // Kiểm tra quyền Quản lý
        }

        public List<NhanVien> layDanhSachNhanVien()
        {
            return new List<NhanVien>(KhoDuLieu.DanhSachNhanVien); // Trả về bản sao danh sách nhân viên
        }

        public List<NhanVien> timKiemNhanVien(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa))
                return layDanhSachNhanVien();

            string tk = tuKhoa.Trim().ToLower(); // Chuyển chữ thường
            List<NhanVien> kq = new List<NhanVien>(); // Danh sách kết quả

            foreach (NhanVien nv in KhoDuLieu.DanhSachNhanVien) // Duyệt từng nhân viên
            {
                // Kiểm tra từ khóa trong mã nhân viên, họ tên hoặc tên đăng nhập
                if ((nv.MaNhanVien != null && nv.MaNhanVien.ToLower().Contains(tk)) ||
                    (nv.HoTen != null && nv.HoTen.ToLower().Contains(tk)) ||
                    (nv.TenDangNhap != null && nv.TenDangNhap.ToLower().Contains(tk)))
                {
                    kq.Add(nv); // Thêm nhân viên thỏa mãn
                }
            }
            return kq;
        }

        public bool themNhanVien(NhanVien nv, out string thongBaoLoi)
        {
            if (nv == null || string.IsNullOrEmpty(nv.TenDangNhap) || string.IsNullOrEmpty(nv.HoTen))
            {
                thongBaoLoi = "Họ tên và tên đăng nhập không được để trống.";
                return false;
            }
            foreach (NhanVien n in KhoDuLieu.DanhSachNhanVien) // Kiểm tra trùng lặp tên đăng nhập
            {
                if (n.TenDangNhap.Equals(nv.TenDangNhap.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    thongBaoLoi = "Tên đăng nhập '" + nv.TenDangNhap + "' đã tồn tại.";
                    return false; // Chặn trùng tài khoản
                }
            }
            if (string.IsNullOrEmpty(nv.MaNhanVien)) // Tự sinh mã nếu chưa có
            {
                nv.MaNhanVien = "NV" + KhoDuLieu.DanhSachNhanVien.Count.ToString("D3");
            }
            nv.MaNV = KhoDuLieu.SinhMaNV(); // Sinh mã ID tự tăng
            KhoDuLieu.DanhSachNhanVien.Add(nv); // Thêm vào kho dữ liệu
            thongBaoLoi = "Thêm nhân viên thành công.";
            return true;
        }

        public bool suaNhanVien(NhanVien nvMoi, out string thongBaoLoi)
        {
            if (nvMoi == null || string.IsNullOrEmpty(nvMoi.HoTen))
            {
                thongBaoLoi = "Họ tên không được để trống.";
                return false;
            }
            for (int i = 0; i < KhoDuLieu.DanhSachNhanVien.Count; i++) // Tìm nhân viên cũ
            {
                if (KhoDuLieu.DanhSachNhanVien[i].MaNV == nvMoi.MaNV) // Nếu trùng ID
                {
                    KhoDuLieu.DanhSachNhanVien[i] = nvMoi; // Cập nhật thông tin
                    thongBaoLoi = "Cập nhật thông tin nhân viên thành công.";
                    return true;
                }
            }
            thongBaoLoi = "Không tìm thấy nhân viên.";
            return false;
        }

        public bool xoaNhanVien(int maNV, out string thongBaoLoi)
        {
            foreach (NhanVien nv in KhoDuLieu.DanhSachNhanVien) // Tìm nhân viên theo ID
            {
                if (nv.MaNV == maNV)
                {
                    if (KhoDuLieu.NguoiDangNhapHienTai != null && KhoDuLieu.NguoiDangNhapHienTai.MaNV == maNV)
                    {
                        thongBaoLoi = "Không thể xóa tài khoản đang đăng nhập hiện tại.";
                        return false; // Ngăn không cho tự xóa tài khoản đang đăng nhập
                    }
                    KhoDuLieu.DanhSachNhanVien.Remove(nv); // Xóa nhân viên
                    thongBaoLoi = "Xóa nhân viên thành công.";
                    return true;
                }
            }
            thongBaoLoi = "Nhân viên không tồn tại.";
            return false;
        }
    }

    /// <summary>
    /// ThongKeService – Nghiệp vụ tổng hợp chỉ số KPI, dữ liệu biểu đồ và phân tích kinh doanh.
    /// </summary>
    public class ThongKeService
    {
        /// <summary>
        /// Tổng hợp doanh thu bán hàng theo từng nhóm phân loại sản phẩm trong khoảng thời gian chỉ định.
        /// </summary>
        public void layDoanhThuTheoLoai(DateTime tuNgay, DateTime denNgay, out List<string> nhanLoai, out List<double> tienLoai)
        {
            nhanLoai = new List<string>(); // Khởi tạo danh sách nhãn phân loại
            tienLoai = new List<double>(); // Khởi tạo danh sách doanh thu
            Dictionary<string, double> thongKe = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase); // Từ điển gom nhóm

            foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Nạp các phân loại có sẵn
            {
                string loai = !string.IsNullOrEmpty(sp.LoaiSP) ? sp.LoaiSP : "Khác"; // Tên phân loại
                if (!thongKe.ContainsKey(loai)) thongKe[loai] = 0; // Đặt giá trị ban đầu là 0đ
            }

            foreach (HoaDon hd in KhoDuLieu.DanhSachHoaDon) // Duyệt qua từng hóa đơn
            {
                if (hd.NgayLap.Date < tuNgay.Date || hd.NgayLap.Date > denNgay.Date) continue; // Bỏ qua ngoài khoảng ngày
                if (hd.TrangThai != null && hd.TrangThai.Equals("Đã hủy", StringComparison.OrdinalIgnoreCase)) continue; // Bỏ qua đơn hủy

                foreach (ChiTietHoaDon ct in KhoDuLieu.DanhSachChiTietHoaDon) // Duyệt từng dòng chi tiết của hóa đơn
                {
                    if (ct.MaHD == hd.MaHD) // Khớp mã hóa đơn
                    {
                        SanPham sp = null; // Khởi tạo biến tìm sản phẩm
                        foreach (SanPham s in KhoDuLieu.DanhSachSanPham) if (s.MaSP == ct.MaSP) { sp = s; break; } // Tìm sản phẩm
                        string loai = (sp != null && !string.IsNullOrEmpty(sp.LoaiSP)) ? sp.LoaiSP : "Khác"; // Tên phân loại
                        if (!thongKe.ContainsKey(loai)) thongKe[loai] = 0; // Đảm bảo khóa tồn tại
                        thongKe[loai] += (double)ct.ThanhTien; // Cộng dồn doanh thu
                    }
                }
            }

            foreach (KeyValuePair<string, double> kvp in thongKe) // Chuyển từ điển ra 2 danh sách
            {
                nhanLoai.Add(kvp.Key); // Thêm tên phân loại
                tienLoai.Add(kvp.Value); // Thêm số tiền
            }
        }

        /// <summary>
        /// Tổng hợp doanh số bán hàng theo từng nhân viên thu ngân trong khoảng thời gian chỉ định.
        /// </summary>
        public void layDoanhThuTheoNhanVien(DateTime tuNgay, DateTime denNgay, out List<string> nhanNV, out List<double> tienNV)
        {
            nhanNV = new List<string>(); // Khởi tạo danh sách tên nhân viên
            tienNV = new List<double>(); // Khởi tạo danh sách doanh số
            Dictionary<string, double> thongKe = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase); // Từ điển gom nhóm

            foreach (NhanVien nv in KhoDuLieu.DanhSachNhanVien) // Nạp sẵn tất cả nhân viên
            {
                thongKe[nv.HoTen] = 0; // Khởi tạo doanh số ban đầu là 0đ
            }

            foreach (HoaDon hd in KhoDuLieu.DanhSachHoaDon) // Duyệt qua các hóa đơn
            {
                if (hd.NgayLap.Date < tuNgay.Date || hd.NgayLap.Date > denNgay.Date) continue; // Bỏ qua ngoài khoảng ngày
                if (hd.TrangThai != null && hd.TrangThai.Equals("Đã hủy", StringComparison.OrdinalIgnoreCase)) continue; // Bỏ qua đơn hủy

                string tenNV = !string.IsNullOrEmpty(hd.TenNhanVien) ? hd.TenNhanVien : "Chưa xác định"; // Tên nhân viên
                if (!thongKe.ContainsKey(tenNV)) thongKe[tenNV] = 0; // Tạo khóa nếu thiếu
                thongKe[tenNV] += (double)hd.ThanhTien; // Cộng dồn doanh thu
            }

            foreach (KeyValuePair<string, double> kvp in thongKe) // Chuyển từ điển ra 2 danh sách
            {
                nhanNV.Add(kvp.Key); // Thêm tên nhân viên
                tienNV.Add(kvp.Value); // Thêm doanh thu
            }
        }

        /// <summary>
        /// Tổng hợp cơ cấu số lượng tồn kho theo từng phân loại mặt hàng thời trang.
        /// </summary>
        public void layCoCauTonKho(out List<string> nhanLoai, out List<double> soLuongTon)
        {
            nhanLoai = new List<string>(); // Khởi tạo danh sách tên phân loại
            soLuongTon = new List<double>(); // Khởi tạo danh sách số lượng tồn kho
            Dictionary<string, double> thongKe = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase); // Từ điển gom nhóm

            foreach (SanPham sp in KhoDuLieu.DanhSachSanPham) // Duyệt qua từng sản phẩm trong kho
            {
                string loai = !string.IsNullOrEmpty(sp.LoaiSP) ? sp.LoaiSP : "Khác"; // Xác định phân loại
                if (!thongKe.ContainsKey(loai)) thongKe[loai] = 0; // Tạo khóa nếu chưa có
                thongKe[loai] += sp.SoLuongTon; // Cộng dồn số chiếc tồn kho
            }

            foreach (KeyValuePair<string, double> kvp in thongKe) // Chuyển từ điển ra 2 danh sách
            {
                nhanLoai.Add(kvp.Key); // Thêm tên phân loại
                soLuongTon.Add(kvp.Value); // Thêm số lượng tồn kho
            }
        }
    }
}
