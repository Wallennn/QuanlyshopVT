using System; // Sử dụng các kiểu dữ liệu cơ bản và ngày giờ hệ thống
using System.Collections.Generic; // Sử dụng danh sách List để xử lý tập hợp đối tượng
using System.IO; // Sử dụng các lớp đọc ghi tệp tin của .NET
using System.Text; // Sử dụng lớp mã hóa ký tự UTF8

namespace QuanlyshopVT // Không gian tên dự án Quản lý Shop Thời trang Việt Tiến
{
    /// <summary>
    /// Lớp tiện ích xuất dữ liệu ra tệp Microsoft Excel chuẩn biểu mẫu doanh nghiệp.
    /// Tạo tệp bảng tính có đầy đủ thông tin tổng công ty, tiêu đề, bảng kê chi tiết, tổng cộng và chữ ký.
    /// Tương thích 100% với Microsoft Excel, LibreOffice và Google Sheets mà không cần cài đặt Office Interop.
    /// </summary>
    public static class XuatExcel
    {
        /// <summary>
        /// Chuyển đổi một số tiền nguyên thành chuỗi đọc bằng chữ tiếng Việt chuẩn kế toán.
        /// Ví dụ: 1250000 -> Một triệu hai trăm năm mươi nghìn đồng chẵn.
        /// </summary>
        public static string DocSoThanhChu(long soTien)
        {
            if (soTien == 0) return "Không đồng"; // Trả về Không đồng nếu số tiền bằng 0
            if (soTien < 0) return "Âm " + DocSoThanhChu(-soTien); // Xử lý trường hợp số tiền âm

            string[] chuSo = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" }; // Danh sách tên chữ số
            string[] hangTien = new string[] { "", "nghìn", "triệu", "tỷ", "nghìn tỷ" }; // Danh sách các cấp hàng tiền

            string chuoiSo = soTien.ToString(); // Đổi số sang chuỗi
            List<string> nhom3So = new List<string>(); // Danh sách chứa các nhóm 3 chữ số

            int doDai = chuoiSo.Length; // Độ dài của chuỗi số
            while (doDai > 0) // Cắt chuỗi số từ phải sang trái thành từng nhóm 3 số
            {
                int start = Math.Max(0, doDai - 3); // Vị trí bắt đầu của nhóm 3 số
                int len = doDai - start; // Độ dài nhóm
                nhom3So.Add(chuoiSo.Substring(start, len)); // Thêm nhóm vào danh sách
                doDai = start; // Dời con trỏ độ dài về trước
            }

            string ketQua = ""; // Chuỗi kết quả tích lũy
            for (int i = 0; i < nhom3So.Count; i++) // Duyệt qua từng nhóm 3 chữ số từ thấp đến cao
            {
                int giaTriNhom = int.Parse(nhom3So[i]); // Giá trị số nguyên của nhóm
                if (giaTriNhom > 0) // Chỉ đọc các nhóm có giá trị lớn hơn 0
                {
                    int tram = giaTriNhom / 100; // Chữ số hàng trăm
                    int chuc = (giaTriNhom % 100) / 10; // Chữ số hàng chục
                    int donVi = giaTriNhom % 10; // Chữ số hàng đơn vị

                    string docNhom = ""; // Chuỗi đọc cho nhóm hiện tại
                    if (nhom3So.Count > 1 || tram > 0) docNhom += chuSo[tram] + " trăm "; // Đọc chữ số hàng trăm

                    if (chuc > 1) // Hàng chục từ 2 trở lên
                    {
                        docNhom += chuSo[chuc] + " mươi "; // Đọc ví dụ: hai mươi
                        if (donVi == 1) docNhom += "mốt "; // Một đọc thành mốt
                        else if (donVi == 5) docNhom += "lăm "; // Năm đọc thành lăm
                        else if (donVi > 0) docNhom += chuSo[donVi] + " "; // Đọc đơn vị bình thường
                    }
                    else if (chuc == 1) // Hàng chục là 1 (mười)
                    {
                        docNhom += "mười "; // Đọc mười
                        if (donVi == 5) docNhom += "lăm "; // Năm đọc thành lăm
                        else if (donVi > 0) docNhom += chuSo[donVi] + " "; // Đọc đơn vị
                    }
                    else if (donVi > 0) // Hàng chục là 0 và có hàng đơn vị
                    {
                        if (tram > 0 || nhom3So.Count > 1) docNhom += "lẻ "; // Đọc lẻ ví dụ: một trăm lẻ năm
                        docNhom += chuSo[donVi] + " "; // Đọc đơn vị
                    }

                    docNhom += hangTien[i] + " "; // Nối thêm cấp hàng (nghìn, triệu, tỷ)
                    ketQua = docNhom + ketQua; // Nối vào đầu chuỗi kết quả
                }
            }

            ketQua = ketQua.Trim(); // Cắt bỏ khoảng trắng thừa
            if (string.IsNullOrEmpty(ketQua)) return "Không đồng"; // Kiểm tra nếu rỗng
            string chuDau = ketQua.Substring(0, 1).ToUpper(); // Viết hoa chữ cái đầu tiên
            return chuDau + ketQua.Substring(1) + " đồng chẵn."; // Hoàn chỉnh chuỗi đọc số tiền
        }

        /// <summary>
        /// Xuất Báo cáo Doanh thu & Bán hàng thời trang chuẩn biểu mẫu doanh nghiệp Việt Tiến.
        /// </summary>
        public static bool XuatBaoCaoDoanhThu(string duongDanFile, DateTime tuNgay, DateTime denNgay, List<HoaDon> dsHoaDon, string nguoiLap, out string thongBao)
        {
            try // Bắt đầu khối xử lý ghi tệp
            {
                StringBuilder sb = new StringBuilder(); // Khởi tạo chuỗi xây dựng nội dung HTML Spreadsheet

                sb.AppendLine("<!DOCTYPE html>"); // Khai báo chuẩn HTML
                sb.AppendLine("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />"); // Khai báo mã hóa UTF8 cho Excel
                sb.AppendLine("<style>"); // Mở khối định dạng CSS
                sb.AppendLine("body { font-family: 'Segoe UI', Arial, sans-serif; font-size: 11pt; color: #1e293b; }"); // Kiểu phông chữ chuẩn
                sb.AppendLine("table { border-collapse: collapse; width: 100%; margin-top: 15px; }"); // Bảng giãn đều 100%
                sb.AppendLine("th { background-color: #1e3a8a; color: #ffffff; font-weight: bold; text-align: center; padding: 10px 6px; border: 1px solid #0f172a; font-size: 10.5pt; }"); // Tiêu đề cột nền xanh Navy chữ trắng
                sb.AppendLine("td { padding: 8px 6px; border: 1px solid #cbd5e1; font-size: 10pt; vertical-align: middle; }"); // Ô dữ liệu viền xám nhẹ
                sb.AppendLine(".text-center { text-align: center; }"); // Căn giữa nội dung
                sb.AppendLine(".text-right { text-align: right; }"); // Căn phải số liệu tiền tệ
                sb.AppendLine(".text-left { text-align: left; }"); // Căn trái văn bản
                sb.AppendLine(".row-even { background-color: #ffffff; }"); // Dòng chẵn màu trắng tinh
                sb.AppendLine(".row-odd { background-color: #f8fafc; }"); // Dòng lẻ màu xám thanh nhã dịu mắt
                sb.AppendLine(".row-total { background-color: #e2e8f0; font-weight: bold; border-top: 2px solid #1e3a8a; }"); // Dòng tổng cộng đậm nét
                sb.AppendLine(".title { font-size: 16pt; font-weight: bold; color: #1e3a8a; text-align: center; margin: 10px 0 5px 0; }"); // Tiêu đề lớn báo cáo
                sb.AppendLine(".subtitle { font-size: 11pt; font-style: italic; color: #475569; text-align: center; margin-bottom: 15px; }"); // Phụ đề kỳ báo cáo
                sb.AppendLine(".company-name { font-size: 11pt; font-weight: bold; color: #0f172a; text-transform: uppercase; }"); // Tên tổng công ty
                sb.AppendLine(".company-info { font-size: 9.5pt; color: #475569; line-height: 1.4; }"); // Thông tin liên hệ công ty
                sb.AppendLine(".sign-title { font-weight: bold; font-size: 10.5pt; text-align: center; color: #0f172a; }"); // Chức danh người ký
                sb.AppendLine(".sign-note { font-style: italic; font-size: 9pt; text-align: center; color: #64748b; }"); // Ghi chú ký tên
                sb.AppendLine("</style></head><body>"); // Đóng phần đầu và mở thân trang

                // ── 1. Phần tiêu ngữ và thông tin Tổng Công Ty May Việt Tiến ────────
                sb.AppendLine("<table>"); // Mở bảng thông tin đầu trang
                sb.AppendLine("<tr>"); // Dòng tiêu đề công ty
                sb.AppendLine("<td colspan=\"5\" style=\"border: none; vertical-align: top;\">"); // Cột thông tin doanh nghiệp bên trái
                sb.AppendLine("<div class=\"company-name\">TỔNG CÔNG TY CỔ PHẦN MAY VIỆT TIẾN</div>"); // Tên thương hiệu
                sb.AppendLine("<div class=\"company-info\"><b>HỆ THỐNG CỬA HÀNG THỜI TRANG CÔNG SỞ VIETTIEN SHOP</b></div>"); // Tên chi nhánh
                sb.AppendLine("<div class=\"company-info\">Địa chỉ: Số 07 Lê Minh Xuân, Phường 7, Quận Tân Bình, TP. Hồ Chí Minh</div>"); // Địa chỉ trụ sở
                sb.AppendLine("<div class=\"company-info\">Hotline: 1800 8080 - Email: info@viettien.com.vn - Website: www.viettien.com.vn</div>"); // Liên hệ
                sb.AppendLine("</td>"); // Đóng cột trái
                sb.AppendLine("<td colspan=\"5\" style=\"border: none; text-align: right; vertical-align: top;\">"); // Cột mẫu số biểu mẫu bên phải
                sb.AppendLine("<div class=\"company-info\"><b>Mẫu số: 01-BH/VT</b></div>"); // Mã hiệu mẫu biểu kế toán
                sb.AppendLine("<div class=\"company-info\">Ban hành theo quy chế quản trị nội bộ Việt Tiến</div>"); // Quyết định ban hành
                sb.AppendLine("<div class=\"company-info\">Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "</div>"); // Thời điểm xuất báo cáo
                sb.AppendLine("<div class=\"company-info\">Người lập biểu: <b>" + nguoiLap + "</b></div>"); // Người chịu trách nhiệm lập
                sb.AppendLine("</td>"); // Đóng cột phải
                sb.AppendLine("</tr></table>"); // Đóng bảng đầu trang

                // ── 2. Tiêu đề chính của báo cáo ────────────────────────────────────
                sb.AppendLine("<div class=\"title\">BÁO CÁO TỔNG HỢP DOANH THU & BÁN HÀNG THỜI TRANG</div>"); // Tiêu đề lớn
                sb.AppendLine("<div class=\"subtitle\">Kỳ thống kê: Từ ngày " + tuNgay.ToString("dd/MM/yyyy") + " đến ngày " + denNgay.ToString("dd/MM/yyyy") + "</div>"); // Kỳ báo cáo

                // ── 3. Bảng dữ liệu chi tiết các hóa đơn ────────────────────────────
                sb.AppendLine("<table>"); // Mở bảng kê chi tiết
                sb.AppendLine("<thead><tr>"); // Dòng tiêu đề cột
                sb.AppendLine("<th style=\"width: 40px;\">STT</th>"); // Cột số thứ tự
                sb.AppendLine("<th style=\"width: 110px;\">Mã Hóa Đơn</th>"); // Cột mã hóa đơn
                sb.AppendLine("<th style=\"width: 130px;\">Thời Gian Lập</th>"); // Cột ngày giờ lập
                sb.AppendLine("<th style=\"width: 150px;\">Thu Ngân</th>"); // Cột nhân viên bán hàng
                sb.AppendLine("<th style=\"width: 160px;\">Khách Hàng</th>"); // Cột khách hàng mua
                sb.AppendLine("<th style=\"width: 110px;\">Hình Thức TT</th>"); // Cột hình thức thanh toán
                sb.AppendLine("<th style=\"width: 110px;\">Tổng Tiền Hàng</th>"); // Cột tổng giá niêm yết
                sb.AppendLine("<th style=\"width: 90px;\">Chiết Khấu</th>"); // Cột giảm giá
                sb.AppendLine("<th style=\"width: 120px;\">Thực Thu (VNĐ)</th>"); // Cột thực thu
                sb.AppendLine("<th style=\"width: 110px;\">Tình Trạng</th>"); // Cột trạng thái hóa đơn
                sb.AppendLine("</tr></thead><tbody>"); // Đóng tiêu đề và mở thân bảng

                int stt = 1; // Biến đếm số thứ tự
                decimal tongTienHang = 0; // Tích lũy tổng tiền hàng
                decimal tongGiamGia = 0; // Tích lũy tổng số tiền giảm giá
                decimal tongThucThu = 0; // Tích lũy tổng thực thu
                int soDonThanhCong = 0; // Đếm số đơn hàng hợp lệ

                foreach (HoaDon hd in dsHoaDon) // Duyệt qua từng hóa đơn trong danh sách
                {
                    string lopMau = (stt % 2 == 0) ? "row-even" : "row-odd"; // Đổi màu dòng chẵn lẻ xen kẽ
                    bool daThanhToan = hd.TrangThai != null && hd.TrangThai.Equals("Đã thanh toán", StringComparison.OrdinalIgnoreCase); // Kiểm tra trạng thái đã thanh toán

                    if (daThanhToan) // Nếu đơn hàng đã thanh toán thành công
                    {
                        tongTienHang += hd.TongTien; // Cộng vào tổng tiền hàng
                        tongGiamGia += hd.GiamGia; // Cộng vào tổng giảm giá
                        tongThucThu += hd.ThanhTien; // Cộng vào tổng thực thu
                        soDonThanhCong++; // Tăng số lượng đơn thành công
                    }

                    sb.AppendLine("<tr class=\"" + lopMau + "\">"); // Mở thẻ dòng với lớp màu tương ứng
                    sb.AppendLine("<td class=\"text-center\">" + stt++ + "</td>"); // In số thứ tự
                    sb.AppendLine("<td class=\"text-center\"><b>" + hd.MaHoaDon + "</b></td>"); // In mã hóa đơn in đậm
                    sb.AppendLine("<td class=\"text-center\">" + hd.NgayLap.ToString("dd/MM/yyyy HH:mm") + "</td>"); // In ngày giờ lập
                    sb.AppendLine("<td class=\"text-left\">" + hd.TenNhanVien + "</td>"); // In tên nhân viên thu ngân
                    sb.AppendLine("<td class=\"text-left\">" + hd.TenKhachHang + "</td>"); // In tên khách hàng
                    sb.AppendLine("<td class=\"text-center\">" + hd.PhuongThucTT + "</td>"); // In phương thức thanh toán
                    sb.AppendLine("<td class=\"text-right\">" + hd.TongTien.ToString("N0") + " đ</td>"); // In tổng tiền
                    sb.AppendLine("<td class=\"text-right\">" + hd.GiamGia.ToString("N0") + " đ</td>"); // In chiết khấu
                    sb.AppendLine("<td class=\"text-right\"><b>" + hd.ThanhTien.ToString("N0") + " đ</b></td>"); // In thực thu đậm
                    sb.AppendLine("<td class=\"text-center\" style=\"color: " + (daThanhToan ? "#059669" : "#dc2626") + "; font-weight: bold;\">" + hd.TrangThai + "</td>"); // In trạng thái có màu
                    sb.AppendLine("</tr>"); // Đóng thẻ dòng
                }

                // ── 4. Dòng tổng cộng số liệu ──────────────────────────────────────
                sb.AppendLine("<tr class=\"row-total\">"); // Mở dòng tổng cộng
                sb.AppendLine("<td colspan=\"6\" class=\"text-right\"><b>TỔNG CỘNG (" + soDonThanhCong + " đơn hợp lệ):</b></td>"); // Nhãn tổng cộng
                sb.AppendLine("<td class=\"text-right\"><b>" + tongTienHang.ToString("N0") + " đ</b></td>"); // Tổng tiền hàng
                sb.AppendLine("<td class=\"text-right\"><b>" + tongGiamGia.ToString("N0") + " đ</b></td>"); // Tổng giảm giá
                sb.AppendLine("<td class=\"text-right\" style=\"color: #1e3a8a; font-size: 11pt;\"><b>" + tongThucThu.ToString("N0") + " đ</b></td>"); // Tổng thực thu nổi bật
                sb.AppendLine("<td class=\"text-center\"><b>HOÀN TẤT</b></td>"); // Nhãn hoàn tất
                sb.AppendLine("</tr>"); // Đóng dòng tổng cộng
                sb.AppendLine("</tbody></table>"); // Đóng bảng kê chi tiết

                // ── 5. Đọc số tiền bằng chữ ────────────────────────────────────────
                sb.AppendLine("<div style=\"margin-top: 10px; font-size: 10.5pt;\">"); // Khối đọc tiền bằng chữ
                sb.AppendLine("<b>Số tiền thực thu bằng chữ: </b><i>" + DocSoThanhChu((long)tongThucThu) + "</i>"); // Chèn chuỗi đọc số tiền
                sb.AppendLine("</div>"); // Đóng khối

                // ── 6. Phần chữ ký xác nhận chuẩn 3 bên ─────────────────────────────
                sb.AppendLine("<table style=\"margin-top: 35px; border: none;\">"); // Mở bảng chữ ký không viền
                sb.AppendLine("<tr style=\"border: none;\">"); // Dòng chức danh
                sb.AppendLine("<td style=\"border: none; width: 33%;\" class=\"sign-title\">NGƯỜI LẬP BIỂU<br/><span class=\"sign-note\">(Ký, ghi rõ họ tên)</span><br/><br/><br/><br/><b>" + nguoiLap + "</b></td>"); // Cột người lập
                sb.AppendLine("<td style=\"border: none; width: 34%;\" class=\"sign-title\">KẾ TOÁN BÁN HÀNG<br/><span class=\"sign-note\">(Ký, ghi rõ họ tên)</span><br/><br/><br/><br/><b>Trần Thị Mai</b></td>"); // Cột kế toán
                sb.AppendLine("<td style=\"border: none; width: 33%;\" class=\"sign-title\">TRƯỞNG CỬA HÀNG / GIÁM ĐỐC<br/><span class=\"sign-note\">(Ký, đóng dấu)</span><br/><br/><br/><br/><b>Phạm Thái Lan</b></td>"); // Cột giám đốc
                sb.AppendLine("</tr></table>"); // Đóng bảng chữ ký

                sb.AppendLine("</body></html>"); // Đóng thẻ body và html

                File.WriteAllText(duongDanFile, sb.ToString(), new UTF8Encoding(true)); // Ghi nội dung vào tệp tin kèm UTF8 BOM
                thongBao = "Xuất báo cáo doanh thu thành công!"; // Báo thành công
                return true; // Trả về kết quả thành công
            }
            catch (Exception ex) // Bắt lỗi ngoại lệ
            {
                thongBao = "Lỗi khi xuất tệp: " + ex.Message; // Gán thông báo lỗi
                return false; // Trả về thất bại
            }
        }

        /// <summary>
        /// Xuất Bảng Kiểm Kê Tồn Kho & Tài Sản Hàng Hóa chuẩn biểu mẫu kiểm kê nội bộ Việt Tiến.
        /// </summary>
        public static bool XuatBangKiemKeKho(string duongDanFile, List<SanPham> dsSanPham, string nguoiLap, out string thongBao)
        {
            try // Bắt đầu khối xử lý
            {
                StringBuilder sb = new StringBuilder(); // Khởi tạo bộ dựng chuỗi

                sb.AppendLine("<!DOCTYPE html>"); // Chuẩn HTML
                sb.AppendLine("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />"); // Khai báo bảng mã UTF8
                sb.AppendLine("<style>"); // Mở thẻ định dạng
                sb.AppendLine("body { font-family: 'Segoe UI', Arial, sans-serif; font-size: 11pt; color: #1e293b; }"); // Phông chữ
                sb.AppendLine("table { border-collapse: collapse; width: 100%; margin-top: 15px; }"); // Giãn rộng 100%
                sb.AppendLine("th { background-color: #0f766e; color: #ffffff; font-weight: bold; text-align: center; padding: 10px 5px; border: 1px solid #115e59; font-size: 10pt; }"); // Tiêu đề xanh Teal thanh lịch
                sb.AppendLine("td { padding: 7px 5px; border: 1px solid #cbd5e1; font-size: 9.5pt; vertical-align: middle; }"); // Ô dữ liệu
                sb.AppendLine(".text-center { text-align: center; }"); // Căn giữa
                sb.AppendLine(".text-right { text-align: right; }"); // Căn phải
                sb.AppendLine(".text-left { text-align: left; }"); // Căn trái
                sb.AppendLine(".row-even { background-color: #ffffff; }"); // Dòng chẵn
                sb.AppendLine(".row-odd { background-color: #f8fafc; }"); // Dòng lẻ
                sb.AppendLine(".row-total { background-color: #e2e8f0; font-weight: bold; border-top: 2px solid #0f766e; }"); // Dòng tổng cộng
                sb.AppendLine(".title { font-size: 16pt; font-weight: bold; color: #0f766e; text-align: center; margin: 10px 0 5px 0; }"); // Tiêu đề kiểm kê
                sb.AppendLine(".subtitle { font-size: 11pt; font-style: italic; color: #475569; text-align: center; margin-bottom: 15px; }"); // Thời điểm kiểm kê
                sb.AppendLine(".company-name { font-size: 11pt; font-weight: bold; color: #0f172a; text-transform: uppercase; }"); // Tên đơn vị
                sb.AppendLine(".company-info { font-size: 9.5pt; color: #475569; line-height: 1.4; }"); // Thông tin đơn vị
                sb.AppendLine(".sign-title { font-weight: bold; font-size: 10.5pt; text-align: center; color: #0f172a; }"); // Tiêu đề chữ ký
                sb.AppendLine(".sign-note { font-style: italic; font-size: 9pt; text-align: center; color: #64748b; }"); // Ghi chú ký tên
                sb.AppendLine("</style></head><body>"); // Đóng thẻ head, mở thẻ body

                // ── 1. Thông tin doanh nghiệp ───────────────────────────────────────
                sb.AppendLine("<table><tr>"); // Mở bảng thông tin
                sb.AppendLine("<td colspan=\"6\" style=\"border: none; vertical-align: top;\">"); // Cột trái
                sb.AppendLine("<div class=\"company-name\">TỔNG CÔNG TY CỔ PHẦN MAY VIỆT TIẾN</div>"); // Tên đơn vị
                sb.AppendLine("<div class=\"company-info\"><b>BỘ PHẬN KHO VẬN & QUẢN TRỊ NGUYÊN LIỆU HÀNG HÓA</b></div>"); // Bộ phận kho
                sb.AppendLine("<div class=\"company-info\">Địa chỉ kho: Số 07 Lê Minh Xuân, Phường 7, Q. Tân Bình, TP.HCM</div>"); // Kho hàng
                sb.AppendLine("</td>"); // Đóng cột trái
                sb.AppendLine("<td colspan=\"5\" style=\"border: none; text-align: right; vertical-align: top;\">"); // Cột phải
                sb.AppendLine("<div class=\"company-info\"><b>Mẫu số: 02-KK/VT</b></div>"); // Mẫu biểu kiểm kê
                sb.AppendLine("<div class=\"company-info\">Thời điểm kiểm kê: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "</div>"); // Thời điểm
                sb.AppendLine("<div class=\"company-info\">Cán bộ kiểm kê: <b>" + nguoiLap + "</b></div>"); // Cán bộ kiểm kê
                sb.AppendLine("</td></tr></table>"); // Đóng bảng

                // ── 2. Tiêu đề báo cáo ──────────────────────────────────────────────
                sb.AppendLine("<div class=\"title\">BẢNG KÊ KIỂM KÊ TỒN KHO & GIÁ TRỊ TÀI SẢN HÀNG HÓA</div>"); // Tiêu đề
                sb.AppendLine("<div class=\"subtitle\">Áp dụng tại Cửa hàng Thời trang Công sở Việt Tiến - Ngày chốt sổ: " + DateTime.Now.ToString("dd/MM/yyyy") + "</div>"); // Ngày chốt

                // ── 3. Bảng kê danh mục sản phẩm ────────────────────────────────────
                sb.AppendLine("<table><thead><tr>"); // Mở bảng dữ liệu
                sb.AppendLine("<th style=\"width: 35px;\">STT</th>"); // STT
                sb.AppendLine("<th style=\"width: 80px;\">Mã Hàng</th>"); // Mã hàng
                sb.AppendLine("<th style=\"width: 220px;\">Tên Sản Phẩm Thời Trang</th>"); // Tên sản phẩm
                sb.AppendLine("<th style=\"width: 90px;\">Phân Loại</th>"); // Loại
                sb.AppendLine("<th style=\"width: 55px;\">Size</th>"); // Size
                sb.AppendLine("<th style=\"width: 80px;\">Màu Sắc</th>"); // Màu sắc
                sb.AppendLine("<th style=\"width: 110px;\">Chất Liệu</th>"); // Chất liệu
                sb.AppendLine("<th style=\"width: 65px;\">Tồn Kho</th>"); // Tồn kho
                sb.AppendLine("<th style=\"width: 95px;\">Giá Vốn</th>"); // Giá nhập
                sb.AppendLine("<th style=\"width: 95px;\">Giá Bán Niêm Yết</th>"); // Giá bán
                sb.AppendLine("<th style=\"width: 120px;\">Tổng Giá Trị Vốn</th>"); // Tổng vốn tồn
                sb.AppendLine("</tr></thead><tbody>"); // Đóng header

                int stt = 1; // Biến STT
                int tongTonKho = 0; // Tổng số chiếc tồn kho
                long tongGiaTriVon = 0; // Tổng giá trị vốn hàng hóa tồn
                long tongGiaTriBan = 0; // Tổng giá trị bán dự kiến

                foreach (SanPham sp in dsSanPham) // Duyệt qua từng sản phẩm
                {
                    string lopMau = (stt % 2 == 0) ? "row-even" : "row-odd"; // Đổi màu dòng
                    long tienVon = (long)sp.GiaNhap * sp.SoLuongTon; // Tính tiền vốn tồn kho
                    long tienBan = (long)sp.GiaBan * sp.SoLuongTon; // Tính tiền bán dự kiến

                    tongTonKho += sp.SoLuongTon; // Cộng dồn số chiếc
                    tongGiaTriVon += tienVon; // Cộng dồn giá trị vốn
                    tongGiaTriBan += tienBan; // Cộng dồn giá trị bán

                    sb.AppendLine("<tr class=\"" + lopMau + "\">"); // Mở dòng
                    sb.AppendLine("<td class=\"text-center\">" + stt++ + "</td>"); // STT
                    sb.AppendLine("<td class=\"text-center\"><b>" + sp.MaHang + "</b></td>"); // Mã hàng
                    sb.AppendLine("<td class=\"text-left\"><b>" + sp.TenSP + "</b></td>"); // Tên sản phẩm
                    sb.AppendLine("<td class=\"text-center\">" + sp.LoaiSP + "</td>"); // Loại
                    sb.AppendLine("<td class=\"text-center\">" + sp.Size + "</td>"); // Size
                    sb.AppendLine("<td class=\"text-center\">" + sp.MauSacSP + "</td>"); // Màu
                    sb.AppendLine("<td class=\"text-left\">" + sp.ChatLieu + "</td>"); // Chất liệu
                    sb.AppendLine("<td class=\"text-center\" style=\"font-weight: bold; color: " + (sp.SoLuongTon <= 10 ? "#dc2626" : "#0f172a") + ";\">" + sp.SoLuongTon + "</td>"); // Tồn kho cảnh báo đỏ
                    sb.AppendLine("<td class=\"text-right\">" + sp.GiaNhap.ToString("N0") + " đ</td>"); // Giá nhập
                    sb.AppendLine("<td class=\"text-right\">" + sp.GiaBan.ToString("N0") + " đ</td>"); // Giá bán
                    sb.AppendLine("<td class=\"text-right\"><b>" + tienVon.ToString("N0") + " đ</b></td>"); // Tổng vốn
                    sb.AppendLine("</tr>"); // Đóng dòng
                }

                // ── 4. Dòng tổng cộng kiểm kê ───────────────────────────────────────
                sb.AppendLine("<tr class=\"row-total\">"); // Mở dòng tổng cộng
                sb.AppendLine("<td colspan=\"7\" class=\"text-right\"><b>TỔNG CỘNG (" + dsSanPham.Count + " mẫu mã):</b></td>"); // Cột nhãn
                sb.AppendLine("<td class=\"text-center\" style=\"color: #0f766e; font-size: 10.5pt;\"><b>" + tongTonKho + " chiếc</b></td>"); // Tổng chiếc
                sb.AppendLine("<td colspan=\"2\" class=\"text-right\"><b>Tổng Vốn Đầu Tư Tồn Kho:</b></td>"); // Nhãn vốn
                sb.AppendLine("<td class=\"text-right\" style=\"color: #0f766e; font-size: 11pt;\"><b>" + tongGiaTriVon.ToString("N0") + " đ</b></td>"); // Tổng vốn
                sb.AppendLine("</tr>"); // Đóng dòng tổng cộng
                sb.AppendLine("</tbody></table>"); // Đóng bảng

                // ── 5. Đọc bằng chữ ────────────────────────────────────────────────
                sb.AppendLine("<div style=\"margin-top: 10px; font-size: 10.5pt;\">"); // Khối đọc chữ
                sb.AppendLine("<b>Tổng giá trị vốn hàng tồn kho bằng chữ: </b><i>" + DocSoThanhChu(tongGiaTriVon) + "</i>"); // Đọc tiền vốn
                sb.AppendLine("</div>"); // Đóng khối

                // ── 6. Chữ ký 3 bên ────────────────────────────────────────────────
                sb.AppendLine("<table style=\"margin-top: 35px; border: none;\">"); // Mở bảng chữ ký
                sb.AppendLine("<tr style=\"border: none;\">"); // Dòng chữ ký
                sb.AppendLine("<td style=\"border: none; width: 33%;\" class=\"sign-title\">CÁN BỘ KIỂM KÊ<br/><span class=\"sign-note\">(Ký, ghi rõ họ tên)</span><br/><br/><br/><br/><b>" + nguoiLap + "</b></td>"); // Người kiểm kê
                sb.AppendLine("<td style=\"border: none; width: 34%;\" class=\"sign-title\">THỦ KHO QUẢN LÝ<br/><span class=\"sign-note\">(Ký, ghi rõ họ tên)</span><br/><br/><br/><br/><b>Lê Hoàng Nam</b></td>"); // Thủ kho
                sb.AppendLine("<td style=\"border: none; width: 33%;\" class=\"sign-title\">GIÁM ĐỐC ĐIỀU HÀNH<br/><span class=\"sign-note\">(Ký, đóng dấu)</span><br/><br/><br/><br/><b>Phạm Thái Lan</b></td>"); // Giám đốc
                sb.AppendLine("</tr></table>"); // Đóng bảng chữ ký

                sb.AppendLine("</body></html>"); // Đóng html

                File.WriteAllText(duongDanFile, sb.ToString(), new UTF8Encoding(true)); // Ghi tệp kèm UTF8 BOM
                thongBao = "Xuất bảng kiểm kê tồn kho thành công!"; // Thông báo thành công
                return true; // Trả về thành công
            }
            catch (Exception ex) // Bắt lỗi
            {
                thongBao = "Lỗi khi xuất bảng kiểm kê: " + ex.Message; // Báo lỗi
                return false; // Trả về thất bại
            }
        }

        /// <summary>
        /// Xuất Danh Sách Hội Viên Khách Hàng Thân Thiết chuẩn biểu mẫu CRM Việt Tiến.
        /// </summary>
        public static bool XuatDanhSachHoiVien(string duongDanFile, List<KhachHang> dsKhachHang, string nguoiLap, out string thongBao)
        {
            try // Khối bắt lỗi
            {
                StringBuilder sb = new StringBuilder(); // Khởi tạo bộ dựng chuỗi

                sb.AppendLine("<!DOCTYPE html>"); // Chuẩn HTML
                sb.AppendLine("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />"); // Khai báo UTF8
                sb.AppendLine("<style>"); // Mở style
                sb.AppendLine("body { font-family: 'Segoe UI', Arial, sans-serif; font-size: 11pt; color: #1e293b; }"); // Phông
                sb.AppendLine("table { border-collapse: collapse; width: 100%; margin-top: 15px; }"); // Bảng
                sb.AppendLine("th { background-color: #4338ca; color: #ffffff; font-weight: bold; text-align: center; padding: 10px 5px; border: 1px solid #3730a3; font-size: 10pt; }"); // Tiêu đề xanh chàm
                sb.AppendLine("td { padding: 7px 5px; border: 1px solid #cbd5e1; font-size: 9.5pt; vertical-align: middle; }"); // Ô
                sb.AppendLine(".text-center { text-align: center; }"); // Giữa
                sb.AppendLine(".text-right { text-align: right; }"); // Phải
                sb.AppendLine(".text-left { text-align: left; }"); // Trái
                sb.AppendLine(".row-even { background-color: #ffffff; }"); // Chẵn
                sb.AppendLine(".row-odd { background-color: #f8fafc; }"); // Lẻ
                sb.AppendLine(".row-total { background-color: #e2e8f0; font-weight: bold; border-top: 2px solid #4338ca; }"); // Tổng
                sb.AppendLine(".title { font-size: 16pt; font-weight: bold; color: #4338ca; text-align: center; margin: 10px 0 5px 0; }"); // Tiêu đề
                sb.AppendLine(".subtitle { font-size: 11pt; font-style: italic; color: #475569; text-align: center; margin-bottom: 15px; }"); // Phụ đề
                sb.AppendLine(".company-name { font-size: 11pt; font-weight: bold; color: #0f172a; text-transform: uppercase; }"); // Tên công ty
                sb.AppendLine(".company-info { font-size: 9.5pt; color: #475569; line-height: 1.4; }"); // Thông tin công ty
                sb.AppendLine(".sign-title { font-weight: bold; font-size: 10.5pt; text-align: center; color: #0f172a; }"); // Tiêu đề ký
                sb.AppendLine(".sign-note { font-style: italic; font-size: 9pt; text-align: center; color: #64748b; }"); // Ghi chú ký
                sb.AppendLine("</style></head><body>"); // Mở body

                sb.AppendLine("<table><tr>"); // Bảng thông tin
                sb.AppendLine("<td colspan=\"4\" style=\"border: none; vertical-align: top;\">"); // Cột trái
                sb.AppendLine("<div class=\"company-name\">TỔNG CÔNG TY CỔ PHẦN MAY VIỆT TIẾN</div>"); // Tên
                sb.AppendLine("<div class=\"company-info\"><b>PHÒNG CHĂM SÓC KHÁCH HÀNG & PHÁT TRIỂN HỘI VIÊN</b></div>"); // Phòng ban
                sb.AppendLine("</td>"); // Đóng cột trái
                sb.AppendLine("<td colspan=\"4\" style=\"border: none; text-align: right; vertical-align: top;\">"); // Cột phải
                sb.AppendLine("<div class=\"company-info\"><b>Mẫu số: 03-KH/VT</b></div>"); // Mẫu
                sb.AppendLine("<div class=\"company-info\">Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "</div>"); // Ngày
                sb.AppendLine("<div class=\"company-info\">Người trích xuất: <b>" + nguoiLap + "</b></div>"); // Người xuất
                sb.AppendLine("</td></tr></table>"); // Đóng bảng thông tin

                sb.AppendLine("<div class=\"title\">DANH SÁCH HỘI VIÊN KHÁCH HÀNG THÂN THIẾT VIỆT TIẾN</div>"); // Tiêu đề
                sb.AppendLine("<div class=\"subtitle\">Báo cáo tổng hợp hội viên và điểm thưởng tích lũy tính đến ngày " + DateTime.Now.ToString("dd/MM/yyyy") + "</div>"); // Phụ đề

                sb.AppendLine("<table><thead><tr>"); // Mở bảng
                sb.AppendLine("<th style=\"width: 40px;\">STT</th>"); // STT
                sb.AppendLine("<th style=\"width: 100px;\">Mã Hội Viên</th>"); // Mã
                sb.AppendLine("<th style=\"width: 180px;\">Họ Và Tên</th>"); // Họ tên
                sb.AppendLine("<th style=\"width: 120px;\">Số Điện Thoại</th>"); // SĐT
                sb.AppendLine("<th style=\"width: 160px;\">Email</th>"); // Email
                sb.AppendLine("<th style=\"width: 250px;\">Địa Chỉ</th>"); // Địa chỉ
                sb.AppendLine("<th style=\"width: 100px;\">Hạng Thẻ</th>"); // Hạng
                sb.AppendLine("<th style=\"width: 110px;\">Điểm Tích Lũy</th>"); // Điểm
                sb.AppendLine("</tr></thead><tbody>"); // Thân bảng

                int stt = 1; // STT
                int tongDiem = 0; // Tổng điểm
                foreach (KhachHang kh in dsKhachHang) // Duyệt khách hàng
                {
                    string lopMau = (stt % 2 == 0) ? "row-even" : "row-odd"; // Đổi màu
                    tongDiem += kh.DiemTichLuy; // Cộng điểm

                    sb.AppendLine("<tr class=\"" + lopMau + "\">"); // Dòng
                    sb.AppendLine("<td class=\"text-center\">" + stt++ + "</td>"); // STT
                    sb.AppendLine("<td class=\"text-center\"><b>" + kh.MaKhachHang + "</b></td>"); // Mã
                    sb.AppendLine("<td class=\"text-left\"><b>" + kh.HoTen + "</b></td>"); // Họ tên
                    sb.AppendLine("<td class=\"text-center\">" + kh.SoDienThoai + "</td>"); // SĐT
                    sb.AppendLine("<td class=\"text-left\">" + kh.Email + "</td>"); // Email
                    sb.AppendLine("<td class=\"text-left\">" + kh.DiaChi + "</td>"); // Địa chỉ
                    sb.AppendLine("<td class=\"text-center\" style=\"font-weight: bold; color: " + (kh.LoaiKhach == "VIP" ? "#b45309" : "#4338ca") + ";\">" + kh.LoaiKhach + "</td>"); // Hạng thẻ
                    sb.AppendLine("<td class=\"text-right\"><b>" + kh.DiemTichLuy.ToString("N0") + " điểm</b></td>"); // Điểm
                    sb.AppendLine("</tr>"); // Đóng dòng
                }

                sb.AppendLine("<tr class=\"row-total\">"); // Dòng tổng
                sb.AppendLine("<td colspan=\"7\" class=\"text-right\"><b>TỔNG CỘNG (" + dsKhachHang.Count + " hội viên):</b></td>"); // Nhãn
                sb.AppendLine("<td class=\"text-right\" style=\"color: #4338ca; font-size: 10.5pt;\"><b>" + tongDiem.ToString("N0") + " điểm</b></td>"); // Tổng điểm
                sb.AppendLine("</tr></tbody></table>"); // Đóng bảng

                sb.AppendLine("<table style=\"margin-top: 35px; border: none;\"><tr style=\"border: none;\">"); // Bảng ký
                sb.AppendLine("<td style=\"border: none; width: 50%;\" class=\"sign-title\">NGƯỜI LẬP BIỂU<br/><span class=\"sign-note\">(Ký, ghi rõ họ tên)</span><br/><br/><br/><br/><b>" + nguoiLap + "</b></td>"); // Người lập
                sb.AppendLine("<td style=\"border: none; width: 50%;\" class=\"sign-title\">PHỤ TRÁCH KHÁCH HÀNG CRM<br/><span class=\"sign-note\">(Ký, đóng dấu)</span><br/><br/><br/><br/><b>Phạm Thái Lan</b></td>"); // Phụ trách
                sb.AppendLine("</tr></table>"); // Đóng bảng ký

                sb.AppendLine("</body></html>"); // Đóng html

                File.WriteAllText(duongDanFile, sb.ToString(), new UTF8Encoding(true)); // Ghi tệp
                thongBao = "Xuất danh sách hội viên thành công!"; // Báo thành công
                return true; // Trả về thành công
            }
            catch (Exception ex) // Bắt lỗi
            {
                thongBao = "Lỗi khi xuất danh sách: " + ex.Message; // Báo lỗi
                return false; // Trả về thất bại
            }
        }
    }
}
