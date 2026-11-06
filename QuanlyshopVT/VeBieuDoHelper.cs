using System; // Sử dụng các kiểu dữ liệu và toán học cơ bản
using System.Collections.Generic; // Sử dụng List để quản lý danh sách nhãn và giá trị
using System.Drawing; // Sử dụng GDI+ để vẽ đồ họa vector trực tiếp
using System.Drawing.Drawing2D; // Sử dụng các phép làm mịn khử răng cưa và dải màu Gradient

namespace QuanlyshopVT // Không gian tên dự án Quản lý Shop Thời trang Việt Tiến
{
    /// <summary>
    /// Lớp tiện ích hỗ trợ vẽ các biểu đồ thống kê hiện đại, trực quan và dịu mắt bằng GDI+.
    /// Không phụ thuộc vào thư viện bên ngoài, chạy cực nhanh và tương thích hoàn toàn với Visual Studio 2010.
    /// </summary>
    public static class VeBieuDoHelper
    {
        // ── Bảng màu Pastel dịu mắt chuẩn thiết kế hiện đại ─────────────────────
        private static readonly Color[] BangMauPastel = new Color[]
        {
            Color.FromArgb(59, 130, 246), // Xanh dương dịu (Soft Blue)
            Color.FromArgb(16, 185, 129), // Xanh ngọc lục bảo dịu (Soft Emerald)
            Color.FromArgb(245, 158, 11), // Vàng hổ phách dịu (Soft Amber)
            Color.FromArgb(139, 92, 246), // Tím oải hương dịu (Soft Purple)
            Color.FromArgb(244, 63, 94), // Hồng thạch anh dịu (Soft Rose)
            Color.FromArgb(6, 182, 212), // Xanh mòng két dịu (Soft Cyan)
            Color.FromArgb(249, 115, 22), // Cam san hô dịu (Soft Orange)
            Color.FromArgb(100, 116, 139) // Xám đá dịu (Soft Slate)
        };

        /// <summary>
        /// Vẽ biểu đồ hình cột hiện đại thể hiện doanh thu hoặc số lượng theo từng danh mục.
        /// </summary>
        public static void VeBieuDoCot(Graphics g, Rectangle bounds, string tieuDe, List<string> nhanCots, List<double> giaTris, string donVi)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias; // Bật chế độ khử răng cưa cho đường nét mượt mà
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; // Khử răng cưa chữ viết sắc nét

            // 1. Vẽ nền trắng và viền thẻ mềm mại
            using (SolidBrush brNen = new SolidBrush(Color.White)) // Cọ vẽ màu nền trắng
            {
                g.FillRectangle(brNen, bounds); // Đổ nền thẻ
            }
            using (Pen penVien = new Pen(Color.FromArgb(226, 232, 240), 1)) // Bút vẽ viền xám nhạt
            {
                g.DrawRectangle(penVien, bounds.X, bounds.Y, bounds.Width - 1, bounds.Height - 1); // Vẽ khung viền bao quanh
            }

            // 2. Vẽ dải màu nhấn trang trí đầu thẻ và tiêu đề biểu đồ
            Rectangle rectNhan = new Rectangle(bounds.X, bounds.Y, bounds.Width, 4); // Dải màu nhấn 4 pixel
            using (SolidBrush brNhan = new SolidBrush(Color.FromArgb(37, 99, 235))) // Màu xanh Slate
            {
                g.FillRectangle(brNhan, rectNhan); // Đổ dải màu nhấn
            }

            using (Font fontTieuDe = new Font("Segoe UI", 11.25F, FontStyle.Bold)) // Phông chữ tiêu đề
            using (SolidBrush brTieuDe = new SolidBrush(Color.FromArgb(15, 23, 42))) // Màu chữ tiêu đề đen than
            {
                g.DrawString(tieuDe, fontTieuDe, brTieuDe, bounds.X + 16, bounds.Y + 14); // Vẽ tiêu đề biểu đồ
            }

            // 3. Kiểm tra dữ liệu rỗng
            if (nhanCots == null || nhanCots.Count == 0 || giaTris == null || giaTris.Count == 0) // Kiểm tra danh sách rỗng
            {
                using (Font fontTrong = new Font("Segoe UI", 10F, FontStyle.Italic)) // Phông chữ nghiêng thông báo
                using (SolidBrush brTrong = new SolidBrush(Color.FromArgb(148, 163, 184))) // Màu xám nhạt
                {
                    string thongBao = "Chưa có dữ liệu thống kê trong khoảng thời gian này."; // Chuỗi thông báo
                    SizeF sz = g.MeasureString(thongBao, fontTrong); // Đo kích thước chuỗi
                    g.DrawString(thongBao, fontTrong, brTrong, bounds.X + (bounds.Width - sz.Width) / 2, bounds.Y + (bounds.Height - sz.Height) / 2); // Vẽ giữa thẻ
                }
                return; // Kết thúc sớm
            }

            // 4. Xác định vùng vẽ đồ thị thực tế
            int leTrai = bounds.X + 80; // Lề trái dành cho thang giá trị
            int lePhai = bounds.Right - 20; // Lề phải
            int leTren = bounds.Y + 50; // Lề trên dành cho tiêu đề
            int leDuoi = bounds.Bottom - 45; // Lề dưới dành cho nhãn cột
            int chieuRongDoThi = lePhai - leTrai; // Chiều rộng vùng vẽ
            int chieuCaoDoThi = leDuoi - leTren; // Chiều cao vùng vẽ

            if (chieuRongDoThi <= 0 || chieuCaoDoThi <= 0) return; // Nếu kích thước quá nhỏ thì bỏ qua

            // 5. Tìm giá trị lớn nhất để tính tỷ lệ vẽ
            double giaTriLonNhat = 0; // Khởi tạo giá trị lớn nhất
            foreach (double v in giaTris) // Duyệt qua từng giá trị
            {
                if (v > giaTriLonNhat) giaTriLonNhat = v; // Cập nhật mốc cực đại
            }
            if (giaTriLonNhat <= 0) giaTriLonNhat = 1; // Tránh chia cho số 0

            // Làm tròn mốc cực đại lên bậc làm tròn đẹp
            double mocTran = giaTriLonNhat * 1.15; // Dự phòng 15% khoảng trống phía trên cho nhãn số

            // 6. Vẽ các đường lưới ngang mờ dịu mắt và thang giá trị
            int soVachLuoi = 4; // Số vạch lưới ngang
            using (Pen penLuoi = new Pen(Color.FromArgb(241, 245, 249), 1)) // Bút vẽ đường lưới
            using (Font fontThang = new Font("Segoe UI", 8.25F, FontStyle.Regular)) // Phông số thang đo
            using (SolidBrush brThang = new SolidBrush(Color.FromArgb(148, 163, 184))) // Màu chữ thang đo
            {
                penLuoi.DashStyle = DashStyle.Dash; // Đường nét đứt mềm mại
                for (int i = 0; i <= soVachLuoi; i++) // Vẽ từng vạch lưới
                {
                    float y = leDuoi - (chieuCaoDoThi * (float)i / soVachLuoi); // Tọa độ Y vạch lưới
                    g.DrawLine(penLuoi, leTrai, y, lePhai, y); // Kẻ vạch ngang

                    double giaTriVach = (mocTran * i / soVachLuoi); // Giá trị tại vạch
                    string chuoiThang = giaTriVach >= 1000000 ? (giaTriVach / 1000000.0).ToString("0.#") + " Tr" : (giaTriVach >= 1000 ? (giaTriVach / 1000.0).ToString("0.#") + " K" : giaTriVach.ToString("N0")); // Viết gọn số tiền
                    SizeF szThang = g.MeasureString(chuoiThang, fontThang); // Đo độ dài
                    g.DrawString(chuoiThang, fontThang, brThang, leTrai - szThang.Width - 6, y - (szThang.Height / 2)); // Vẽ nhãn thang đo bên trái
                }
            }

            // 7. Vẽ từng cột dữ liệu với dải màu Gradient mềm mại
            int soCot = Math.Min(nhanCots.Count, giaTris.Count); // Số lượng cột cần vẽ
            float khoangCachMoiCot = (float)chieuRongDoThi / soCot; // Khoảng cách đều giữa các tâm cột
            float chieuRongCot = Math.Min(48f, khoangCachMoiCot * 0.55f); // Chiều rộng mỗi cột tối đa 48px

            using (Font fontGiaTri = new Font("Segoe UI", 8.5F, FontStyle.Bold)) // Phông chữ giá trị trên đỉnh cột
            using (Font fontNhan = new Font("Segoe UI", 8.5F, FontStyle.Regular)) // Phông chữ nhãn danh mục dưới chân cột
            using (SolidBrush brChuGiaTri = new SolidBrush(Color.FromArgb(30, 41, 59))) // Màu chữ giá trị
            using (SolidBrush brChuNhan = new SolidBrush(Color.FromArgb(71, 85, 105))) // Màu chữ nhãn
            {
                for (int i = 0; i < soCot; i++) // Lặp vẽ từng cột
                {
                    float tamX = leTrai + (i * khoangCachMoiCot) + (khoangCachMoiCot / 2); // Tọa độ tâm trục X
                    float cotX = tamX - (chieuRongCot / 2); // Tọa độ lề trái cột
                    float chieuCaoCot = (float)((giaTris[i] / mocTran) * chieuCaoDoThi); // Chiều cao thực tế của cột
                    if (chieuCaoCot < 3 && giaTris[i] > 0) chieuCaoCot = 3; // Luôn hiển thị ít nhất 3px nếu có giá trị
                    float cotY = leDuoi - chieuCaoCot; // Tọa độ đỉnh cột

                    Color mauCotGoc = BangMauPastel[i % BangMauPastel.Length]; // Lấy màu từ bảng màu dịu mắt
                    Color mauCotNhat = Color.FromArgb(Math.Min(255, mauCotGoc.R + 40), Math.Min(255, mauCotGoc.G + 40), Math.Min(255, mauCotGoc.B + 40)); // Màu sáng hơn cho đỉnh cột

                    RectangleF rectCot = new RectangleF(cotX, cotY, chieuRongCot, chieuCaoCot); // Hình chữ nhật đại diện cột
                    if (chieuCaoCot > 0) // Chỉ vẽ nếu chiều cao lớn hơn 0
                    {
                        using (LinearGradientBrush brGradient = new LinearGradientBrush(new PointF(cotX, cotY), new PointF(cotX, leDuoi), mauCotGoc, mauCotNhat)) // Gradient từ trên xuống
                        {
                            g.FillRectangle(brGradient, rectCot); // Tô màu cột
                        }
                    }

                    // Vẽ giá trị lên trên đầu cột
                    string chuoiGiaTri = giaTris[i] >= 1000000 ? (giaTris[i] / 1000000.0).ToString("0.##") + "Tr" : (giaTris[i] >= 1000 ? (giaTris[i] / 1000.0).ToString("0.#") + "K" : giaTris[i].ToString("N0")); // Rút gọn định dạng
                    if (!string.IsNullOrEmpty(donVi)) chuoiGiaTri += " " + donVi; // Nối đơn vị tính
                    SizeF szVal = g.MeasureString(chuoiGiaTri, fontGiaTri); // Đo kích thước
                    g.DrawString(chuoiGiaTri, fontGiaTri, brChuGiaTri, tamX - (szVal.Width / 2), cotY - szVal.Height - 3); // Vẽ giá trị

                    // Vẽ nhãn danh mục dưới chân cột
                    string nhan = nhanCots[i]; // Lấy tên nhãn
                    SizeF szNhan = g.MeasureString(nhan, fontNhan); // Đo kích thước nhãn
                    if (szNhan.Width > khoangCachMoiCot && nhan.Length > 10) nhan = nhan.Substring(0, 8) + ".."; // Cắt ngắn nếu quá dài
                    szNhan = g.MeasureString(nhan, fontNhan); // Đo lại kích thước
                    g.DrawString(nhan, fontNhan, brChuNhan, tamX - (szNhan.Width / 2), leDuoi + 8); // Vẽ nhãn dưới chân cột
                }
            }

            // 8. Kẻ trục hoành đáy đồ thị
            using (Pen penTruc = new Pen(Color.FromArgb(203, 213, 225), 1.5f)) // Bút vẽ trục xám nhẹ
            {
                g.DrawLine(penTruc, leTrai, leDuoi, lePhai, leDuoi); // Vẽ đường trục đáy
            }
        }

        /// <summary>
        /// Vẽ biểu đồ hình tròn khuyên (Donut Chart) thể hiện cơ cấu tỷ trọng phần trăm danh mục.
        /// </summary>
        public static void VeBieuDoTron(Graphics g, Rectangle bounds, string tieuDe, List<string> nhanPhans, List<double> giaTris, string nhanTrungTam)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias; // Bật khử răng cưa
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; // Khử răng cưa chữ

            // 1. Đổ nền và viền thẻ
            using (SolidBrush brNen = new SolidBrush(Color.White)) // Màu nền trắng
            {
                g.FillRectangle(brNen, bounds); // Tô nền
            }
            using (Pen penVien = new Pen(Color.FromArgb(226, 232, 240), 1)) // Viền xám nhạt
            {
                g.DrawRectangle(penVien, bounds.X, bounds.Y, bounds.Width - 1, bounds.Height - 1); // Vẽ viền
            }

            // 2. Dải màu nhấn đầu thẻ
            Rectangle rectNhan = new Rectangle(bounds.X, bounds.Y, bounds.Width, 4); // Dải màu 4px
            using (SolidBrush brNhan = new SolidBrush(Color.FromArgb(13, 148, 136))) // Màu xanh mòng két Teal
            {
                g.FillRectangle(brNhan, rectNhan); // Tô dải màu nhấn
            }

            using (Font fontTieuDe = new Font("Segoe UI", 11.25F, FontStyle.Bold)) // Phông tiêu đề
            using (SolidBrush brTieuDe = new SolidBrush(Color.FromArgb(15, 23, 42))) // Màu chữ than
            {
                g.DrawString(tieuDe, fontTieuDe, brTieuDe, bounds.X + 16, bounds.Y + 14); // Vẽ tiêu đề biểu đồ
            }

            // 3. Kiểm tra danh sách rỗng
            if (nhanPhans == null || nhanPhans.Count == 0 || giaTris == null || giaTris.Count == 0) // Kiểm tra rỗng
            {
                using (Font fontTrong = new Font("Segoe UI", 10F, FontStyle.Italic)) // Phông chữ nghiêng
                using (SolidBrush brTrong = new SolidBrush(Color.FromArgb(148, 163, 184))) // Màu xám nhạt
                {
                    string tb = "Chưa có dữ liệu cơ cấu trong khoảng thời gian này."; // Chuỗi báo
                    SizeF sz = g.MeasureString(tb, fontTrong); // Đo kích thước
                    g.DrawString(tb, fontTrong, brTrong, bounds.X + (bounds.Width - sz.Width) / 2, bounds.Y + (bounds.Height - sz.Height) / 2); // Vẽ thông báo
                }
                return; // Thoát
            }

            // 4. Tính tổng giá trị để quy ra phần trăm góc quét
            double tongCong = 0; // Tổng giá trị
            foreach (double v in giaTris) tongCong += v; // Cộng dồn
            if (tongCong <= 0) return; // Nếu tổng bằng 0 thì không vẽ

            // 5. Xác định vùng vẽ vòng tròn bên trái và vùng chú giải bên phải
            int banKinhVong = Math.Min(bounds.Height - 80, (bounds.Width / 2) - 30); // Bán kính ngoài
            if (banKinhVong < 40) return; // Nếu quá nhỏ thì bỏ qua

            int tamX = bounds.X + 25 + (banKinhVong / 2); // Tọa độ tâm X của vòng tròn
            int tamY = bounds.Y + 45 + (banKinhVong / 2); // Tọa độ tâm Y của vòng tròn
            Rectangle rectVongNgoai = new Rectangle(tamX - (banKinhVong / 2), tamY - (banKinhVong / 2), banKinhVong, banKinhVong); // Hình vuông bao quanh hình tròn

            // 6. Vẽ các lát bánh hình quạt (Pie Slices)
            float gocBatDau = -90f; // Bắt đầu quét từ đỉnh 12 giờ
            int soPhan = Math.Min(nhanPhans.Count, giaTris.Count); // Số lát bánh

            for (int i = 0; i < soPhan; i++) // Quét từng lát
            {
                float gocQuet = (float)((giaTris[i] / tongCong) * 360.0); // Tính số độ quét tương ứng phần trăm
                if (gocQuet <= 0) continue; // Bỏ qua lát 0 độ

                Color mauLat = BangMauPastel[i % BangMauPastel.Length]; // Lấy màu dịu mắt
                using (SolidBrush brLat = new SolidBrush(mauLat)) // Cọ vẽ màu lát bánh
                {
                    g.FillPie(brLat, rectVongNgoai, gocBatDau, gocQuet); // Đổ màu lát quạt
                }
                using (Pen penVienLat = new Pen(Color.White, 2)) // Bút viền trắng ngăn cách giữa các lát
                {
                    g.DrawPie(penVienLat, rectVongNgoai, gocBatDau, gocQuet); // Vẽ đường ngăn cách
                }

                gocBatDau += gocQuet; // Tăng góc bắt đầu cho lát kế tiếp
            }

            // 7. Khoét lỗ tròn ở giữa để tạo thành hình khuyên (Donut Chart) hiện đại
            int banKinhTrong = (int)(banKinhVong * 0.58f); // Bán kính vòng tròn bên trong
            Rectangle rectVongTrong = new Rectangle(tamX - (banKinhTrong / 2), tamY - (banKinhTrong / 2), banKinhTrong, banKinhTrong); // Hình tròn bên trong
            using (SolidBrush brLoTrong = new SolidBrush(Color.White)) // Cọ trắng che phần giữa
            {
                g.FillEllipse(brLoTrong, rectVongTrong); // Khoét lỗ giữa tạo Donut
            }

            // Vẽ nhãn tổng số ở tâm hình khuyên
            using (Font fontTam = new Font("Segoe UI", 9.5F, FontStyle.Bold)) // Phông chữ ở tâm
            using (Font fontPhuTam = new Font("Segoe UI", 8F, FontStyle.Regular)) // Phông chữ phụ ở tâm
            using (SolidBrush brTam = new SolidBrush(Color.FromArgb(15, 23, 42))) // Màu chữ tâm
            using (SolidBrush brPhuTam = new SolidBrush(Color.FromArgb(100, 116, 139))) // Màu chữ phụ
            {
                string chuoiTong = tongCong >= 1000000 ? (tongCong / 1000000.0).ToString("0.##") + " Tr" : tongCong.ToString("N0"); // Rút gọn số tổng
                SizeF szTong = g.MeasureString(chuoiTong, fontTam); // Đo kích thước
                g.DrawString(chuoiTong, fontTam, brTam, tamX - (szTong.Width / 2), tamY - (szTong.Height / 2) - 6); // Vẽ số tổng

                string chuoiPhu = !string.IsNullOrEmpty(nhanTrungTam) ? nhanTrungTam : "Tổng cộng"; // Nhãn phụ tâm
                SizeF szPhu = g.MeasureString(chuoiPhu, fontPhuTam); // Đo kích thước
                g.DrawString(chuoiPhu, fontPhuTam, brPhuTam, tamX - (szPhu.Width / 2), tamY + 4); // Vẽ nhãn phụ
            }

            // 8. Vẽ bảng chú giải (Legend) ở nửa bên phải
            int chuGiaiX = rectVongNgoai.Right + 30; // Tọa độ X bảng chú giải
            int chuGiaiY = bounds.Y + 45; // Tọa độ Y bắt đầu bảng chú giải

            using (Font fontLegend = new Font("Segoe UI", 9F, FontStyle.Regular)) // Phông chữ chú giải
            using (Font fontPhanTram = new Font("Segoe UI", 9F, FontStyle.Bold)) // Phông chữ phần trăm
            using (SolidBrush brLegend = new SolidBrush(Color.FromArgb(51, 65, 85))) // Màu chữ chú giải
            {
                for (int i = 0; i < soPhan; i++) // Vẽ từng dòng chú giải
                {
                    double phanTram = (giaTris[i] / tongCong) * 100.0; // Tính tỷ lệ %
                    Color mauHop = BangMauPastel[i % BangMauPastel.Length]; // Lấy màu tương ứng

                    // Vẽ ô vuông màu đại diện
                    Rectangle rectHop = new Rectangle(chuGiaiX, chuGiaiY + (i * 24) + 2, 12, 12); // Ô vuông nhỏ 12x12px
                    using (SolidBrush brHop = new SolidBrush(mauHop)) // Cọ vẽ ô
                    {
                        g.FillRectangle(brHop, rectHop); // Tô màu ô
                    }

                    // Tên danh mục và phần trăm
                    string tenMuc = nhanPhans[i]; // Tên danh mục
                    if (tenMuc.Length > 16) tenMuc = tenMuc.Substring(0, 14) + ".."; // Cắt ngắn nếu quá dài
                    g.DrawString(tenMuc, fontLegend, brLegend, chuGiaiX + 20, chuGiaiY + (i * 24)); // Vẽ tên danh mục

                    string chuoiPT = phanTram.ToString("0.0") + "% (" + (giaTris[i] >= 1000000 ? (giaTris[i] / 1000000.0).ToString("0.#") + "Tr" : giaTris[i].ToString("N0")) + ")"; // Chuỗi phần trăm và giá trị
                    using (SolidBrush brPT = new SolidBrush(mauHop)) // Cọ màu nhấn
                    {
                        g.DrawString(chuoiPT, fontPhanTram, brPT, chuGiaiX + 160, chuGiaiY + (i * 24)); // Vẽ phần trăm bên phải
                    }
                }
            }
        }
    }
}

