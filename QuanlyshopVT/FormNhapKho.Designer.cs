namespace QuanlyshopVT // Không gian tên của dự án Quản lý Shop Thời trang Việt Tiến
{
    partial class FormNhapKho // Lớp giao diện nhập kho hàng hóa cho Thủ kho và Quản lý
    {
        /// <summary>
        /// Biến quản lý việc giải phóng các tài nguyên không dùng nữa.
        /// </summary>
        private System.ComponentModel.IContainer components = null; // Biến thành phần tài nguyên

        /// <summary>
        /// Giải phóng các tài nguyên giao diện đang được sử dụng.
        /// </summary>
        /// <param name="disposing">True nếu giải phóng cả tài nguyên được quản lý, ngược lại False</param>
        protected override void Dispose(bool disposing) // Phương thức dọn dẹp bộ nhớ
        {
            if (disposing && (components != null)) // Kiểm tra nếu tài nguyên hợp lệ
            {
                components.Dispose(); // Giải phóng tài nguyên
            }
            base.Dispose(disposing); // Gọi phương thức dọn dẹp lớp cơ sở
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Phương thức khởi tạo các điều khiển trực quan cho cửa sổ Nhập Kho.
        /// Tương thích hoàn toàn với Visual Studio 2010 Designer.
        /// </summary>
        private void InitializeComponent() // Hàm thiết lập các thành phần điều khiển
        {
            this.pnlHeaderNhapKho = new System.Windows.Forms.Panel(); // Tạo khung tiêu đề trên
            this.lblPhuDeHeader = new System.Windows.Forms.Label(); // Tạo nhãn phụ đề hướng dẫn
            this.lblTieuDeHeader = new System.Windows.Forms.Label(); // Tạo nhãn tiêu đề chính
            this.pnlBody = new System.Windows.Forms.Panel(); // Tạo khung chứa nội dung thông tin
            this.txtGhiChu = new System.Windows.Forms.TextBox(); // Tạo ô nhập ghi chú phiếu nhập
            this.lblGhiChu = new System.Windows.Forms.Label(); // Tạo nhãn ghi chú
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox(); // Tạo hộp chọn nhà cung cấp
            this.lblNhaCungCap = new System.Windows.Forms.Label(); // Tạo nhãn nhà cung cấp
            this.numGiaNhapMoi = new System.Windows.Forms.NumericUpDown(); // Tạo ô nhập đơn giá nhập mới
            this.lblGiaNhapMoi = new System.Windows.Forms.Label(); // Tạo nhãn đơn giá nhập mới
            this.txtTonSauKhiNhap = new System.Windows.Forms.TextBox(); // Tạo ô hiển thị tồn kho sau nhập
            this.lblTonSauKhiNhap = new System.Windows.Forms.Label(); // Tạo nhãn dự kiến tồn kho
            this.numSoLuongNhap = new System.Windows.Forms.NumericUpDown(); // Tạo ô nhập số lượng bổ sung
            this.lblSoLuongNhap = new System.Windows.Forms.Label(); // Tạo nhãn số lượng nhập
            this.txtGiaNhapCu = new System.Windows.Forms.TextBox(); // Tạo ô hiển thị giá nhập hiện tại
            this.lblGiaNhapCu = new System.Windows.Forms.Label(); // Tạo nhãn giá nhập hiện tại
            this.txtTonHienTai = new System.Windows.Forms.TextBox(); // Tạo ô hiển thị số lượng tồn hiện có
            this.lblTonHienTai = new System.Windows.Forms.Label(); // Tạo nhãn tồn kho hiện có
            this.cboSanPham = new System.Windows.Forms.ComboBox(); // Tạo hộp chọn sản phẩm cần nhập
            this.lblSanPham = new System.Windows.Forms.Label(); // Tạo nhãn hướng dẫn chọn sản phẩm
            this.pnlFooter = new System.Windows.Forms.Panel(); // Tạo khung chân trang chứa nút bấm
            this.btnHuyBo = new System.Windows.Forms.Button(); // Tạo nút hủy bỏ thao tác
            this.btnXacNhanNhap = new System.Windows.Forms.Button(); // Tạo nút xác nhận nhập kho
            this.pnlHeaderNhapKho.SuspendLayout(); // Tạm dừng bố cục tiêu đề
            this.pnlBody.SuspendLayout(); // Tạm dừng bố cục thân form
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhapMoi)).BeginInit(); // Tạm dừng bố cục giá nhập
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNhap)).BeginInit(); // Tạm dừng bố cục số lượng nhập
            this.pnlFooter.SuspendLayout(); // Tạm dừng bố cục chân trang
            this.SuspendLayout(); // Tạm dừng bố cục form chính
            // 
            // pnlHeaderNhapKho
            // 
            this.pnlHeaderNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42))))); // Màu Slate Navy sang trọng
            this.pnlHeaderNhapKho.Controls.Add(this.lblPhuDeHeader); // Đưa phụ đề vào khung tiêu đề
            this.pnlHeaderNhapKho.Controls.Add(this.lblTieuDeHeader); // Đưa tiêu đề vào khung tiêu đề
            this.pnlHeaderNhapKho.Dock = System.Windows.Forms.DockStyle.Top; // Gắn sát mép trên form
            this.pnlHeaderNhapKho.Location = new System.Drawing.Point(0, 0); // Vị trí góc trên cùng bên trái
            this.pnlHeaderNhapKho.Name = "pnlHeaderNhapKho"; // Tên định danh điều khiển
            this.pnlHeaderNhapKho.Size = new System.Drawing.Size(534, 65); // Kích thước khung tiêu đề
            this.pnlHeaderNhapKho.TabIndex = 0; // Thứ tự chuyển nét TabIndex
            // 
            // lblPhuDeHeader
            // 
            this.lblPhuDeHeader.AutoSize = true; // Tự co giãn theo kích thước chữ
            this.lblPhuDeHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông Segoe UI 9pt
            this.lblPhuDeHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184))))); // Chữ màu Slate xám nhạt
            this.lblPhuDeHeader.Location = new System.Drawing.Point(18, 38); // Tọa độ phụ đề
            this.lblPhuDeHeader.Name = "lblPhuDeHeader"; // Tên định danh
            this.lblPhuDeHeader.Size = new System.Drawing.Size(425, 15); // Kích thước phụ đề
            this.lblPhuDeHeader.TabIndex = 1; // Chỉ số phím Tab
            this.lblPhuDeHeader.Text = "Nghiệp vụ Thủ kho & Quản lý - Cập nhật tồn kho sản phẩm và nhà cung cấp"; // Nội dung
            // 
            // lblTieuDeHeader
            // 
            this.lblTieuDeHeader.AutoSize = true; // Tự co giãn theo chữ
            this.lblTieuDeHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ đậm 12pt
            this.lblTieuDeHeader.ForeColor = System.Drawing.Color.White; // Chữ màu trắng tinh khôi
            this.lblTieuDeHeader.Location = new System.Drawing.Point(18, 12); // Tọa độ tiêu đề chính
            this.lblTieuDeHeader.Name = "lblTieuDeHeader"; // Tên định danh
            this.lblTieuDeHeader.Size = new System.Drawing.Size(306, 21); // Kích thước tiêu đề
            this.lblTieuDeHeader.TabIndex = 0; // Chỉ số phím Tab
            this.lblTieuDeHeader.Text = "PHIẾU NHẬP THÊM HÀNG HÓA VÀO KHO"; // Nội dung tiêu đề
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White; // Nền thân màu trắng sáng
            this.pnlBody.Controls.Add(this.txtGhiChu); // Đưa ô nhập ghi chú vào
            this.pnlBody.Controls.Add(this.lblGhiChu); // Đưa nhãn ghi chú vào
            this.pnlBody.Controls.Add(this.cboNhaCungCap); // Đưa chọn nhà cung cấp vào
            this.pnlBody.Controls.Add(this.lblNhaCungCap); // Đưa nhãn nhà cung cấp vào
            this.pnlBody.Controls.Add(this.numGiaNhapMoi); // Đưa ô đơn giá mới vào
            this.pnlBody.Controls.Add(this.lblGiaNhapMoi); // Đưa nhãn đơn giá mới vào
            this.pnlBody.Controls.Add(this.txtTonSauKhiNhap); // Đưa ô tồn dự kiến vào
            this.pnlBody.Controls.Add(this.lblTonSauKhiNhap); // Đưa nhãn tồn dự kiến vào
            this.pnlBody.Controls.Add(this.numSoLuongNhap); // Đưa ô số lượng nhập vào
            this.pnlBody.Controls.Add(this.lblSoLuongNhap); // Đưa nhãn số lượng nhập vào
            this.pnlBody.Controls.Add(this.txtGiaNhapCu); // Đưa ô giá nhập cũ vào
            this.pnlBody.Controls.Add(this.lblGiaNhapCu); // Đưa nhãn giá nhập cũ vào
            this.pnlBody.Controls.Add(this.txtTonHienTai); // Đưa ô tồn hiện tại vào
            this.pnlBody.Controls.Add(this.lblTonHienTai); // Đưa nhãn tồn hiện tại vào
            this.pnlBody.Controls.Add(this.cboSanPham); // Đưa chọn sản phẩm vào
            this.pnlBody.Controls.Add(this.lblSanPham); // Đưa nhãn chọn sản phẩm vào
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill; // Phủ kín phần thân form
            this.pnlBody.Location = new System.Drawing.Point(0, 65); // Tọa độ nối tiếp tiêu đề
            this.pnlBody.Name = "pnlBody"; // Tên định danh
            this.pnlBody.Size = new System.Drawing.Size(534, 430); // Kích thước phần thân form
            this.pnlBody.TabIndex = 1; // Chỉ số chuyển phím Tab
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ Segoe UI
            this.txtGhiChu.Location = new System.Drawing.Point(21, 382); // Tọa độ ô ghi chú
            this.txtGhiChu.Name = "txtGhiChu"; // Tên định danh
            this.txtGhiChu.Size = new System.Drawing.Size(490, 25); // Kích thước ô ghi chú
            this.txtGhiChu.TabIndex = 15; // Chỉ số chuyển Tab
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true; // Tự co giãn theo chữ
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông nhãn
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85))))); // Chữ xám Slate
            this.lblGhiChu.Location = new System.Drawing.Point(18, 359); // Tọa độ nhãn ghi chú
            this.lblGhiChu.Name = "lblGhiChu"; // Tên định danh
            this.lblGhiChu.Size = new System.Drawing.Size(142, 17); // Kích thước nhãn
            this.lblGhiChu.TabIndex = 14; // Chỉ số chuyển Tab
            this.lblGhiChu.Text = "5. Ghi chú phiếu nhập:"; // Nội dung nhãn
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Chỉ cho phép chọn trong danh sách
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ danh sách
            this.cboNhaCungCap.FormattingEnabled = true; // Bật định dạng dữ liệu
            this.cboNhaCungCap.Location = new System.Drawing.Point(21, 318); // Tọa độ hộp chọn NCC
            this.cboNhaCungCap.Name = "cboNhaCungCap"; // Tên định danh
            this.cboNhaCungCap.Size = new System.Drawing.Size(490, 25); // Kích thước hộp chọn NCC
            this.cboNhaCungCap.TabIndex = 13; // Chỉ số chuyển Tab
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true; // Tự co giãn theo chữ
            this.lblNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ nhãn
            this.lblNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85))))); // Chữ xám Slate
            this.lblNhaCungCap.Location = new System.Drawing.Point(18, 295); // Tọa độ nhãn NCC
            this.lblNhaCungCap.Name = "lblNhaCungCap"; // Tên định danh
            this.lblNhaCungCap.Size = new System.Drawing.Size(182, 17); // Kích thước nhãn
            this.lblNhaCungCap.TabIndex = 12; // Chỉ số chuyển Tab
            this.lblNhaCungCap.Text = "4. Đối tác / Nhà cung cấp cấp:"; // Nội dung nhãn
            // 
            // numGiaNhapMoi
            // 
            this.numGiaNhapMoi.DecimalPlaces = 0; // Không lấy số thập phân
            this.numGiaNhapMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ đậm
            this.numGiaNhapMoi.Increment = new decimal(new int[] { 5000, 0, 0, 0 }); // Mỗi lần tăng giảm 5,000 đ
            this.numGiaNhapMoi.Location = new System.Drawing.Point(21, 253); // Tọa độ ô giá nhập
            this.numGiaNhapMoi.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 }); // Tối đa 100 triệu
            this.numGiaNhapMoi.Name = "numGiaNhapMoi"; // Tên định danh
            this.numGiaNhapMoi.Size = new System.Drawing.Size(225, 25); // Kích thước ô giá nhập
            this.numGiaNhapMoi.TabIndex = 11; // Chỉ số chuyển Tab
            this.numGiaNhapMoi.ThousandsSeparator = true; // Phân tách hàng nghìn bằng dấu phẩy
            // 
            // lblGiaNhapMoi
            // 
            this.lblGiaNhapMoi.AutoSize = true; // Tự co giãn theo chữ
            this.lblGiaNhapMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ nhãn
            this.lblGiaNhapMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85))))); // Chữ xám Slate
            this.lblGiaNhapMoi.Location = new System.Drawing.Point(18, 230); // Tọa độ nhãn giá nhập mới
            this.lblGiaNhapMoi.Name = "lblGiaNhapMoi"; // Tên định danh
            this.lblGiaNhapMoi.Size = new System.Drawing.Size(183, 17); // Kích thước nhãn
            this.lblGiaNhapMoi.TabIndex = 10; // Chỉ số chuyển Tab
            this.lblGiaNhapMoi.Text = "3. Đơn giá nhập đợt này (đ):"; // Nội dung nhãn
            // 
            // txtTonSauKhiNhap
            // 
            this.txtTonSauKhiNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245))))); // Nền xanh ngọc nhạt báo hiệu thành công
            this.txtTonSauKhiNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ đậm nổi bật
            this.txtTonSauKhiNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52))))); // Chữ xanh lá cây đậm
            this.txtTonSauKhiNhap.Location = new System.Drawing.Point(286, 186); // Tọa độ ô tồn sau nhập
            this.txtTonSauKhiNhap.Name = "txtTonSauKhiNhap"; // Tên định danh
            this.txtTonSauKhiNhap.ReadOnly = true; // Chỉ cho phép xem không cho gõ trực tiếp
            this.txtTonSauKhiNhap.Size = new System.Drawing.Size(225, 25); // Kích thước ô tồn sau nhập
            this.txtTonSauKhiNhap.TabIndex = 9; // Chỉ số chuyển Tab
            // 
            // lblTonSauKhiNhap
            // 
            this.lblTonSauKhiNhap.AutoSize = true; // Tự co giãn theo chữ
            this.lblTonSauKhiNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ nhãn đậm
            this.lblTonSauKhiNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52))))); // Chữ xanh lá đậm
            this.lblTonSauKhiNhap.Location = new System.Drawing.Point(283, 163); // Tọa độ nhãn tồn sau nhập
            this.lblTonSauKhiNhap.Name = "lblTonSauKhiNhap"; // Tên định danh
            this.lblTonSauKhiNhap.Size = new System.Drawing.Size(155, 17); // Kích thước nhãn
            this.lblTonSauKhiNhap.TabIndex = 8; // Chỉ số chuyển Tab
            this.lblTonSauKhiNhap.Text = "Dự kiến tồn sau nhập:"; // Nội dung nhãn
            // 
            // numSoLuongNhap
            // 
            this.numSoLuongNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ số lượng đậm
            this.numSoLuongNhap.Location = new System.Drawing.Point(21, 186); // Tọa độ ô số lượng nhập
            this.numSoLuongNhap.Maximum = new decimal(new int[] { 10000, 0, 0, 0 }); // Tối đa 10,000 chiếc
            this.numSoLuongNhap.Minimum = new decimal(new int[] { 1, 0, 0, 0 }); // Tối thiểu 1 chiếc
            this.numSoLuongNhap.Name = "numSoLuongNhap"; // Tên định danh
            this.numSoLuongNhap.Size = new System.Drawing.Size(225, 25); // Kích thước ô số lượng nhập
            this.numSoLuongNhap.TabIndex = 7; // Chỉ số chuyển Tab
            this.numSoLuongNhap.Value = new decimal(new int[] { 20, 0, 0, 0 }); // Giá trị mặc định 20 chiếc
            this.numSoLuongNhap.ValueChanged += new System.EventHandler(this.numSoLuongNhapValueChanged); // Bắt sự kiện đổi số lượng
            // 
            // lblSoLuongNhap
            // 
            this.lblSoLuongNhap.AutoSize = true; // Tự co giãn theo chữ
            this.lblSoLuongNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ nhãn đậm
            this.lblSoLuongNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138))))); // Chữ màu xanh dương đậm
            this.lblSoLuongNhap.Location = new System.Drawing.Point(18, 163); // Tọa độ nhãn số lượng
            this.lblSoLuongNhap.Name = "lblSoLuongNhap"; // Tên định danh
            this.lblSoLuongNhap.Size = new System.Drawing.Size(183, 17); // Kích thước nhãn
            this.lblSoLuongNhap.TabIndex = 6; // Chỉ số chuyển Tab
            this.lblSoLuongNhap.Text = "2. Số lượng nhập thêm (+):"; // Nội dung nhãn
            // 
            // txtGiaNhapCu
            // 
            this.txtGiaNhapCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249))))); // Nền xám nhạt chỉ đọc
            this.txtGiaNhapCu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ
            this.txtGiaNhapCu.Location = new System.Drawing.Point(286, 120); // Tọa độ ô giá cũ
            this.txtGiaNhapCu.Name = "txtGiaNhapCu"; // Tên định danh
            this.txtGiaNhapCu.ReadOnly = true; // Khóa chỉ đọc
            this.txtGiaNhapCu.Size = new System.Drawing.Size(225, 25); // Kích thước ô giá cũ
            this.txtGiaNhapCu.TabIndex = 5; // Chỉ số chuyển Tab
            // 
            // lblGiaNhapCu
            // 
            this.lblGiaNhapCu.AutoSize = true; // Tự co giãn theo chữ
            this.lblGiaNhapCu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ nhãn
            this.lblGiaNhapCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139))))); // Chữ xám mờ
            this.lblGiaNhapCu.Location = new System.Drawing.Point(283, 99); // Tọa độ nhãn giá cũ
            this.lblGiaNhapCu.Name = "lblGiaNhapCu"; // Tên định danh
            this.lblGiaNhapCu.Size = new System.Drawing.Size(107, 15); // Kích thước nhãn
            this.lblGiaNhapCu.TabIndex = 4; // Chỉ số chuyển Tab
            this.lblGiaNhapCu.Text = "Giá vốn hiện tại (đ):"; // Nội dung nhãn
            // 
            // txtTonHienTai
            // 
            this.txtTonHienTai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249))))); // Nền xám nhạt chỉ đọc
            this.txtTonHienTai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ đậm
            this.txtTonHienTai.Location = new System.Drawing.Point(21, 120); // Tọa độ ô tồn hiện tại
            this.txtTonHienTai.Name = "txtTonHienTai"; // Tên định danh
            this.txtTonHienTai.ReadOnly = true; // Khóa chỉ đọc
            this.txtTonHienTai.Size = new System.Drawing.Size(225, 25); // Kích thước ô tồn hiện tại
            this.txtTonHienTai.TabIndex = 3; // Chỉ số chuyển Tab
            // 
            // lblTonHienTai
            // 
            this.lblTonHienTai.AutoSize = true; // Tự co giãn theo chữ
            this.lblTonHienTai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ nhãn
            this.lblTonHienTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139))))); // Chữ xám mờ
            this.lblTonHienTai.Location = new System.Drawing.Point(18, 99); // Tọa độ nhãn tồn hiện tại
            this.lblTonHienTai.Name = "lblTonHienTai"; // Tên định danh
            this.lblTonHienTai.Size = new System.Drawing.Size(117, 15); // Kích thước nhãn
            this.lblTonHienTai.TabIndex = 2; // Chỉ số chuyển Tab
            this.lblTonHienTai.Text = "Tồn kho trong kho:"; // Nội dung nhãn
            // 
            // cboSanPham
            // 
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Chỉ cho phép chọn từ danh mục có sẵn
            this.cboSanPham.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ danh sách
            this.cboSanPham.FormattingEnabled = true; // Bật định dạng
            this.cboSanPham.Location = new System.Drawing.Point(21, 58); // Tọa độ hộp chọn sản phẩm
            this.cboSanPham.Name = "cboSanPham"; // Tên định danh
            this.cboSanPham.Size = new System.Drawing.Size(490, 25); // Kích thước hộp chọn sản phẩm
            this.cboSanPham.TabIndex = 1; // Chỉ số chuyển Tab
            this.cboSanPham.SelectedIndexChanged += new System.EventHandler(this.cboSanPhamSelectedIndexChanged); // Bắt sự kiện đổi sản phẩm
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true; // Tự co giãn theo chữ
            this.lblSanPham.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ nhãn đậm
            this.lblSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42))))); // Chữ đen Slate
            this.lblSanPham.Location = new System.Drawing.Point(18, 35); // Tọa độ nhãn chọn sản phẩm
            this.lblSanPham.Name = "lblSanPham"; // Tên định danh
            this.lblSanPham.Size = new System.Drawing.Size(189, 17); // Kích thước nhãn
            this.lblSanPham.TabIndex = 0; // Chỉ số chuyển Tab
            this.lblSanPham.Text = "1. Chọn sản phẩm nhập kho:"; // Nội dung nhãn
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252))))); // Nền chân trang xám rất nhạt
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Kẻ viền ngăn cách
            this.pnlFooter.Controls.Add(this.btnHuyBo); // Đưa nút hủy bỏ vào
            this.pnlFooter.Controls.Add(this.btnXacNhanNhap); // Đưa nút xác nhận vào
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom; // Gắn sát mép dưới form
            this.pnlFooter.Location = new System.Drawing.Point(0, 495); // Tọa độ khung chân trang
            this.pnlFooter.Name = "pnlFooter"; // Tên định danh
            this.pnlFooter.Size = new System.Drawing.Size(534, 55); // Kích thước khung chân trang
            this.pnlFooter.TabIndex = 2; // Chỉ số chuyển Tab
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139))))); // Nền màu xám Slate
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand; // Đổi con trỏ chuột sang hình bàn tay
            this.btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel; // Tự động đóng với Cancel khi nhấn
            this.btnHuyBo.FlatAppearance.BorderSize = 0; // Không viền
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Phong cách phẳng hiện đại
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ đậm
            this.btnHuyBo.ForeColor = System.Drawing.Color.White; // Chữ trắng
            this.btnHuyBo.Location = new System.Drawing.Point(286, 11); // Tọa độ nút Hủy
            this.btnHuyBo.Name = "btnHuyBo"; // Tên định danh
            this.btnHuyBo.Size = new System.Drawing.Size(100, 32); // Kích thước nút Hủy
            this.btnHuyBo.TabIndex = 1; // Chỉ số chuyển Tab
            this.btnHuyBo.Text = "Hủy Bỏ"; // Nội dung nút
            this.btnHuyBo.UseVisualStyleBackColor = false; // Tắt nền mặc định
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBoClick); // Bắt sự kiện bấm nút Hủy
            // 
            // btnXacNhanNhap
            // 
            this.btnXacNhanNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52))))); // Nền màu xanh lá cây đậm Forest Green
            this.btnXacNhanNhap.Cursor = System.Windows.Forms.Cursors.Hand; // Đổi con trỏ chuột sang hình bàn tay
            this.btnXacNhanNhap.FlatAppearance.BorderSize = 0; // Không viền
            this.btnXacNhanNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Phong cách phẳng hiện đại
            this.btnXacNhanNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ đậm
            this.btnXacNhanNhap.ForeColor = System.Drawing.Color.White; // Chữ trắng
            this.btnXacNhanNhap.Location = new System.Drawing.Point(395, 11); // Tọa độ nút Xác nhận
            this.btnXacNhanNhap.Name = "btnXacNhanNhap"; // Tên định danh
            this.btnXacNhanNhap.Size = new System.Drawing.Size(125, 32); // Kích thước nút Xác nhận
            this.btnXacNhanNhap.TabIndex = 0; // Chỉ số chuyển Tab
            this.btnXacNhanNhap.Text = "Xác Nhận Nhập"; // Nội dung nút
            this.btnXacNhanNhap.UseVisualStyleBackColor = false; // Tắt nền mặc định
            this.btnXacNhanNhap.Click += new System.EventHandler(this.btnXacNhanNhapClick); // Bắt sự kiện bấm nút Xác nhận
            // 
            // FormNhapKho
            // 
            this.AcceptButton = this.btnXacNhanNhap; // Phím Enter mặc định bấm Xác nhận
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F); // Tỉ lệ co giãn DPI
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Bật chế độ thích ứng phông chữ
            this.CancelButton = this.btnHuyBo; // Phím Esc mặc định bấm Hủy bỏ
            this.ClientSize = new System.Drawing.Size(534, 550); // Kích thước cửa sổ
            this.Controls.Add(this.pnlBody); // Đưa khung thân vào form
            this.Controls.Add(this.pnlFooter); // Đưa khung chân trang vào form
            this.Controls.Add(this.pnlHeaderNhapKho); // Đưa khung tiêu đề vào form
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Phông chữ toàn form
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Viền cố định không cho kéo đổi cỡ
            this.MaximizeBox = false; // Tắt nút phóng to
            this.MinimizeBox = false; // Tắt nút thu nhỏ
            this.Name = "FormNhapKho"; // Tên định danh form
            this.ShowIcon = false; // Không hiển thị biểu tượng góc trên
            this.ShowInTaskbar = false; // Không tạo mục riêng trên Taskbar
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; // Xuất hiện chính giữa form cha
            this.Text = "Phiếu Nhập Thêm Hàng Hóa Vào Kho - VietTien Fashion Shop"; // Tiêu đề cửa sổ
            this.Load += new System.EventHandler(this.FormNhapKhoLoad); // Bắt sự kiện nạp form
            this.pnlHeaderNhapKho.ResumeLayout(false); // Tiếp tục bố cục tiêu đề
            this.pnlHeaderNhapKho.PerformLayout(); // Sắp đặt tiêu đề
            this.pnlBody.ResumeLayout(false); // Tiếp tục bố cục thân form
            this.pnlBody.PerformLayout(); // Sắp đặt thân form
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhapMoi)).EndInit(); // Tiếp tục bố cục giá nhập
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNhap)).EndInit(); // Tiếp tục bố cục số lượng nhập
            this.pnlFooter.ResumeLayout(false); // Tiếp tục bố cục chân trang
            this.ResumeLayout(false); // Hoàn tất bố cục toàn form
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderNhapKho; // Biến khung tiêu đề
        private System.Windows.Forms.Label lblTieuDeHeader; // Biến nhãn tiêu đề
        private System.Windows.Forms.Label lblPhuDeHeader; // Biến nhãn phụ đề
        private System.Windows.Forms.Panel pnlBody; // Biến khung thân
        private System.Windows.Forms.Label lblSanPham; // Biến nhãn chọn sản phẩm
        private System.Windows.Forms.ComboBox cboSanPham; // Biến hộp chọn sản phẩm
        private System.Windows.Forms.Label lblTonHienTai; // Biến nhãn tồn hiện tại
        private System.Windows.Forms.TextBox txtTonHienTai; // Biến ô tồn hiện tại
        private System.Windows.Forms.Label lblGiaNhapCu; // Biến nhãn giá cũ
        private System.Windows.Forms.TextBox txtGiaNhapCu; // Biến ô giá cũ
        private System.Windows.Forms.Label lblSoLuongNhap; // Biến nhãn số lượng nhập
        private System.Windows.Forms.NumericUpDown numSoLuongNhap; // Biến ô số lượng nhập
        private System.Windows.Forms.Label lblTonSauKhiNhap; // Biến nhãn tồn dự kiến
        private System.Windows.Forms.TextBox txtTonSauKhiNhap; // Biến ô tồn dự kiến
        private System.Windows.Forms.Label lblGiaNhapMoi; // Biến nhãn giá nhập mới
        private System.Windows.Forms.NumericUpDown numGiaNhapMoi; // Biến ô giá nhập mới
        private System.Windows.Forms.Label lblNhaCungCap; // Biến nhãn nhà cung cấp
        private System.Windows.Forms.ComboBox cboNhaCungCap; // Biến hộp chọn nhà cung cấp
        private System.Windows.Forms.Label lblGhiChu; // Biến nhãn ghi chú
        private System.Windows.Forms.TextBox txtGhiChu; // Biến ô nhập ghi chú
        private System.Windows.Forms.Panel pnlFooter; // Biến khung chân trang
        private System.Windows.Forms.Button btnXacNhanNhap; // Biến nút bấm xác nhận
        private System.Windows.Forms.Button btnHuyBo; // Biến nút bấm hủy bỏ
    }
}

