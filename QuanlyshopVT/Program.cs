using System; // Sử dụng các kiểu dữ liệu cơ bản của .NET Framework
using System.Windows.Forms; // Sử dụng các lớp quản lý vòng lặp ứng dụng Windows Forms

namespace QuanlyshopVT // Không gian tên của dự án Quản lý Shop Thời trang Việt Tiến
{
    /// <summary>
    /// Lớp Program – Điểm vào (Entry Point) thực thi đầu tiên của toàn bộ ứng dụng.
    /// Tương tự QuanLyNhaThuoc.java trong dự án BAOCAO Java.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Điểm khởi đầu chính của ứng dụng Quản Lý Shop Thời Trang VietTien.
        /// Chú thích công dụng chi tiết của từng dòng mã nguồn.
        /// </summary>
        [STAThread] // Thuộc tính Single-Threaded Apartment cần thiết cho các ứng dụng Windows Forms
        static void Main() // Hàm Main thực thi khi chương trình được khởi chạy
        {
            Application.EnableVisualStyles(); // Bật giao diện trực quan chuẩn của hệ điều hành Windows
            Application.SetCompatibleTextRenderingDefault(false); // Thiết lập phương thức vẽ chữ tương thích

            // Nạp dữ liệu mẫu ban đầu vào bộ nhớ (sản phẩm, khách hàng, nhân viên, nhà cung cấp, hóa đơn)
            KhoDuLieu.NapDuLieuMau(); // Khởi tạo dữ liệu mẫu thời trang Việt Tiến sẵn sàng làm việc

            // Vòng lặp phiên làm việc: cho phép Đăng xuất -> Đăng nhập lại mượt mà không bị đóng ứng dụng
            while (true) // Lặp vô hạn cho tới khi người dùng chủ động thoát hoàn toàn
            {
                // Mở màn hình đăng nhập (tương tự LoginDialog trong BAOCAO)
                using (FormDangNhap formLogin = new FormDangNhap()) // Tạo form đăng nhập trong khối using để tự giải phóng
                {
                    formLogin.ShowDialog(); // Hiển thị form đăng nhập dưới dạng hộp thoại chặn (modal dialog)

                    // Kiểm tra nếu người dùng đóng form hoặc bấm Thoát mà chưa đăng nhập thành công
                    if (!formLogin.DaDangNhap)
                    {
                        break; // Thoát khỏi vòng lặp while để kết thúc toàn bộ ứng dụng
                    }
                } // Tự động dọn dẹp bộ nhớ của formLogin

                // Khi đăng nhập thành công, khởi tạo form làm việc chính Form1
                Form1 formChinh = new Form1(); // Tạo mới một phiên làm việc Form1
                Application.Run(formChinh); // Bắt đầu vòng lặp xử lý thông điệp giao diện Windows cho Form1

                // Khi formChinh đóng lại (người dùng bấm Đăng Xuất hoặc bấm nút X thoát cửa sổ):
                // Nếu người dùng chọn Đăng Xuất (formChinh.DaDangXuat == true), vòng lặp tiếp tục mở lại FormDangNhap
                // Nếu người dùng bấm dấu X trên thanh tiêu đề để thoát (DaDangXuat == false), thoát hoàn toàn ứng dụng
                if (!formChinh.DaDangXuat) // Kiểm tra nếu không phải do bấm nút Đăng Xuất
                {
                    break; // Thoát khỏi vòng lặp để đóng hoàn toàn tiến trình ứng dụng
                }
            } // Kết thúc vòng lặp phiên làm việc
        } // Kết thúc hàm Main
    } // Kết thúc lớp Program
} // Kết thúc không gian tên
