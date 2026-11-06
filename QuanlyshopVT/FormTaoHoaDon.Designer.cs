namespace QuanlyshopVT
{
    partial class FormTaoHoaDon
    {
        /// <summary>
        /// Biến quản lý các thành phần điều khiển của Designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Giải phóng các tài nguyên khi đóng form.
        /// </summary>
        /// <param name="disposing">true nếu giải phóng tài nguyên; ngược lại false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Phương thức hỗ trợ khởi tạo giao diện cho Visual Studio Designer.
        /// Cho phép lập trình viên chỉnh sửa thủ công trực quan dễ dàng.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeaderPOS = new System.Windows.Forms.Panel();
            this.lblThuNganPOS = new System.Windows.Forms.Label();
            this.lblTieuDePOS = new System.Windows.Forms.Label();
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.lblNgayLapPOS = new System.Windows.Forms.Label();
            this.cboKhachHangPOS = new System.Windows.Forms.ComboBox();
            this.lblKhachHangPOS = new System.Windows.Forms.Label();
            this.grpChonSP = new System.Windows.Forms.GroupBox();
            this.btnXoaKhoiGio = new System.Windows.Forms.Button();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboSanPhamPOS = new System.Windows.Forms.ComboBox();
            this.lblChonSP = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.pnlTongKet = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTienThua = new System.Windows.Forms.Label();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.lblTienKhachDua = new System.Windows.Forms.Label();
            this.cboPhuongThuc = new System.Windows.Forms.ComboBox();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblThanhTienText = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.lblGiamGiaText = new System.Windows.Forms.Label();
            this.lblTongTienHang = new System.Windows.Forms.Label();
            this.lblTongTienHangText = new System.Windows.Forms.Label();
            this.pnlHeaderPOS.SuspendLayout();
            this.pnlKhachHang.SuspendLayout();
            this.grpChonSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlTongKet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderPOS
            // 
            this.pnlHeaderPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeaderPOS.Controls.Add(this.lblThuNganPOS);
            this.pnlHeaderPOS.Controls.Add(this.lblTieuDePOS);
            this.pnlHeaderPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderPOS.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderPOS.Name = "pnlHeaderPOS";
            this.pnlHeaderPOS.Size = new System.Drawing.Size(864, 55);
            this.pnlHeaderPOS.TabIndex = 0;
            // 
            // lblThuNganPOS
            // 
            this.lblThuNganPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThuNganPOS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuNganPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblThuNganPOS.Location = new System.Drawing.Point(540, 16);
            this.lblThuNganPOS.Name = "lblThuNganPOS";
            this.lblThuNganPOS.Size = new System.Drawing.Size(310, 23);
            this.lblThuNganPOS.TabIndex = 1;
            this.lblThuNganPOS.Text = "Thu ngân: Phạm Thái Lan";
            this.lblThuNganPOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTieuDePOS
            // 
            this.lblTieuDePOS.AutoSize = true;
            this.lblTieuDePOS.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDePOS.ForeColor = System.Drawing.Color.White;
            this.lblTieuDePOS.Location = new System.Drawing.Point(14, 15);
            this.lblTieuDePOS.Name = "lblTieuDePOS";
            this.lblTieuDePOS.Size = new System.Drawing.Size(325, 25);
            this.lblTieuDePOS.TabIndex = 0;
            this.lblTieuDePOS.Text = "LẬP HÓA ĐƠN BÁN HÀNG VIETTIEN";
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKhachHang.Controls.Add(this.lblNgayLapPOS);
            this.pnlKhachHang.Controls.Add(this.cboKhachHangPOS);
            this.pnlKhachHang.Controls.Add(this.lblKhachHangPOS);
            this.pnlKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKhachHang.Location = new System.Drawing.Point(0, 55);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(864, 46);
            this.pnlKhachHang.TabIndex = 1;
            // 
            // lblNgayLapPOS
            // 
            this.lblNgayLapPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayLapPOS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLapPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblNgayLapPOS.Location = new System.Drawing.Point(580, 11);
            this.lblNgayLapPOS.Name = "lblNgayLapPOS";
            this.lblNgayLapPOS.Size = new System.Drawing.Size(270, 23);
            this.lblNgayLapPOS.TabIndex = 2;
            this.lblNgayLapPOS.Text = "Thời gian: 03/11/2026 09:30";
            this.lblNgayLapPOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboKhachHangPOS
            // 
            this.cboKhachHangPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHangPOS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhachHangPOS.FormattingEnabled = true;
            this.cboKhachHangPOS.Location = new System.Drawing.Point(135, 10);
            this.cboKhachHangPOS.Name = "cboKhachHangPOS";
            this.cboKhachHangPOS.Size = new System.Drawing.Size(320, 25);
            this.cboKhachHangPOS.TabIndex = 1;
            // 
            // lblKhachHangPOS
            // 
            this.lblKhachHangPOS.AutoSize = true;
            this.lblKhachHangPOS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHangPOS.Location = new System.Drawing.Point(16, 13);
            this.lblKhachHangPOS.Name = "lblKhachHangPOS";
            this.lblKhachHangPOS.Size = new System.Drawing.Size(113, 17);
            this.lblKhachHangPOS.TabIndex = 0;
            this.lblKhachHangPOS.Text = "Chọn khách mua:";
            // 
            // grpChonSP
            // 
            this.grpChonSP.BackColor = System.Drawing.Color.White;
            this.grpChonSP.Controls.Add(this.btnXoaKhoiGio);
            this.grpChonSP.Controls.Add(this.btnThemVaoGio);
            this.grpChonSP.Controls.Add(this.numSoLuong);
            this.grpChonSP.Controls.Add(this.lblSoLuong);
            this.grpChonSP.Controls.Add(this.cboSanPhamPOS);
            this.grpChonSP.Controls.Add(this.lblChonSP);
            this.grpChonSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpChonSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChonSP.Location = new System.Drawing.Point(0, 101);
            this.grpChonSP.Name = "grpChonSP";
            this.grpChonSP.Size = new System.Drawing.Size(864, 68);
            this.grpChonSP.TabIndex = 2;
            this.grpChonSP.TabStop = false;
            this.grpChonSP.Text = "Thêm Mặt Hàng Vào Giỏ";
            // 
            // btnXoaKhoiGio
            // 
            this.btnXoaKhoiGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoaKhoiGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKhoiGio.FlatAppearance.BorderSize = 0;
            this.btnXoaKhoiGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoiGio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoiGio.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhoiGio.Location = new System.Drawing.Point(745, 23);
            this.btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            this.btnXoaKhoiGio.Size = new System.Drawing.Size(105, 32);
            this.btnXoaKhoiGio.TabIndex = 5;
            this.btnXoaKhoiGio.Text = "Bỏ Món";
            this.btnXoaKhoiGio.UseVisualStyleBackColor = false;
            this.btnXoaKhoiGio.Click += new System.EventHandler(this.btnXoaKhoiGioClick);
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThemVaoGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaoGio.FlatAppearance.BorderSize = 0;
            this.btnThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(605, 23);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(130, 32);
            this.btnThemVaoGio.TabIndex = 4;
            this.btnThemVaoGio.Text = "Thêm Vào Giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGioClick);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(525, 27);
            this.numSoLuong.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(65, 25);
            this.numSoLuong.TabIndex = 3;
            this.numSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(465, 31);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(57, 15);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // cboSanPhamPOS
            // 
            this.cboSanPhamPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPhamPOS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSanPhamPOS.FormattingEnabled = true;
            this.cboSanPhamPOS.Location = new System.Drawing.Point(100, 27);
            this.cboSanPhamPOS.Name = "cboSanPhamPOS";
            this.cboSanPhamPOS.Size = new System.Drawing.Size(355, 25);
            this.cboSanPhamPOS.TabIndex = 1;
            // 
            // lblChonSP
            // 
            this.lblChonSP.AutoSize = true;
            this.lblChonSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonSP.Location = new System.Drawing.Point(16, 31);
            this.lblChonSP.Name = "lblChonSP";
            this.lblChonSP.Size = new System.Drawing.Size(63, 15);
            this.lblChonSP.TabIndex = 0;
            this.lblChonSP.Text = "Sản phẩm:";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.ColumnHeadersHeight = 32;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(0, 169);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowTemplate.Height = 28;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(864, 256);
            this.dgvGioHang.TabIndex = 3;
            // 
            // pnlTongKet
            // 
            this.pnlTongKet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlTongKet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTongKet.Controls.Add(this.btnHuyBo);
            this.pnlTongKet.Controls.Add(this.btnThanhToan);
            this.pnlTongKet.Controls.Add(this.lblTienThua);
            this.pnlTongKet.Controls.Add(this.txtTienKhachDua);
            this.pnlTongKet.Controls.Add(this.lblTienKhachDua);
            this.pnlTongKet.Controls.Add(this.cboPhuongThuc);
            this.pnlTongKet.Controls.Add(this.lblPhuongThuc);
            this.pnlTongKet.Controls.Add(this.lblThanhTien);
            this.pnlTongKet.Controls.Add(this.lblThanhTienText);
            this.pnlTongKet.Controls.Add(this.txtGiamGia);
            this.pnlTongKet.Controls.Add(this.lblGiamGiaText);
            this.pnlTongKet.Controls.Add(this.lblTongTienHang);
            this.pnlTongKet.Controls.Add(this.lblTongTienHangText);
            this.pnlTongKet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTongKet.Location = new System.Drawing.Point(0, 425);
            this.pnlTongKet.Name = "pnlTongKet";
            this.pnlTongKet.Size = new System.Drawing.Size(864, 160);
            this.pnlTongKet.TabIndex = 4;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Location = new System.Drawing.Point(480, 105);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(100, 42);
            this.btnHuyBo.TabIndex = 12;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBoClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(590, 105);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(260, 42);
            this.btnThanhToan.TabIndex = 11;
            this.btnThanhToan.Text = "HOÀN TẤT VÀ XUẤT HÓA ĐƠN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToanClick);
            // 
            // lblTienThua
            // 
            this.lblTienThua.AutoSize = true;
            this.lblTienThua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblTienThua.Location = new System.Drawing.Point(475, 70);
            this.lblTienThua.Name = "lblTienThua";
            this.lblTienThua.Size = new System.Drawing.Size(161, 19);
            this.lblTienThua.TabIndex = 10;
            this.lblTienThua.Text = "Tiền thừa trả khách: 0 đ";
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKhachDua.Location = new System.Drawing.Point(620, 25);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(230, 25);
            this.txtTienKhachDua.TabIndex = 9;
            this.txtTienKhachDua.Text = "0";
            this.txtTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienKhachDua.TextChanged += new System.EventHandler(this.txtTienKhachDuaTextChanged);
            // 
            // lblTienKhachDua
            // 
            this.lblTienKhachDua.AutoSize = true;
            this.lblTienKhachDua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienKhachDua.Location = new System.Drawing.Point(475, 28);
            this.lblTienKhachDua.Name = "lblTienKhachDua";
            this.lblTienKhachDua.Size = new System.Drawing.Size(131, 17);
            this.lblTienKhachDua.TabIndex = 8;
            this.lblTienKhachDua.Text = "Tiền khách đưa (đ):";
            // 
            // cboPhuongThuc
            // 
            this.cboPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhuongThuc.FormattingEnabled = true;
            this.cboPhuongThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản QR",
            "Thẻ ngân hàng"});
            this.cboPhuongThuc.Location = new System.Drawing.Point(180, 118);
            this.cboPhuongThuc.Name = "cboPhuongThuc";
            this.cboPhuongThuc.Size = new System.Drawing.Size(170, 23);
            this.cboPhuongThuc.TabIndex = 7;
            // 
            // lblPhuongThuc
            // 
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuongThuc.Location = new System.Drawing.Point(16, 122);
            this.lblPhuongThuc.Name = "lblPhuongThuc";
            this.lblPhuongThuc.Size = new System.Drawing.Size(126, 15);
            this.lblPhuongThuc.TabIndex = 6;
            this.lblPhuongThuc.Text = "Hình thức thanh toán:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblThanhTien.Location = new System.Drawing.Point(180, 80);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(170, 25);
            this.lblThanhTien.TabIndex = 5;
            this.lblThanhTien.Text = "0 đ";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThanhTienText
            // 
            this.lblThanhTienText.AutoSize = true;
            this.lblThanhTienText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTienText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblThanhTienText.Location = new System.Drawing.Point(15, 83);
            this.lblThanhTienText.Name = "lblThanhTienText";
            this.lblThanhTienText.Size = new System.Drawing.Size(148, 20);
            this.lblThanhTienText.TabIndex = 4;
            this.lblThanhTienText.Text = "TỔNG THANH TOÁN:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(180, 48);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(170, 25);
            this.txtGiamGia.TabIndex = 3;
            this.txtGiamGia.Text = "0";
            this.txtGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGiaTextChanged);
            // 
            // lblGiamGiaText
            // 
            this.lblGiamGiaText.AutoSize = true;
            this.lblGiamGiaText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamGiaText.Location = new System.Drawing.Point(16, 52);
            this.lblGiamGiaText.Name = "lblGiamGiaText";
            this.lblGiamGiaText.Size = new System.Drawing.Size(150, 15);
            this.lblGiamGiaText.TabIndex = 2;
            this.lblGiamGiaText.Text = "Chiết khấu / Giảm giá (đ):";
            // 
            // lblTongTienHang
            // 
            this.lblTongTienHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienHang.Location = new System.Drawing.Point(180, 18);
            this.lblTongTienHang.Name = "lblTongTienHang";
            this.lblTongTienHang.Size = new System.Drawing.Size(170, 20);
            this.lblTongTienHang.TabIndex = 1;
            this.lblTongTienHang.Text = "0 đ";
            this.lblTongTienHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienHangText
            // 
            this.lblTongTienHangText.AutoSize = true;
            this.lblTongTienHangText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienHangText.Location = new System.Drawing.Point(16, 18);
            this.lblTongTienHangText.Name = "lblTongTienHangText";
            this.lblTongTienHangText.Size = new System.Drawing.Size(108, 17);
            this.lblTongTienHangText.TabIndex = 0;
            this.lblTongTienHangText.Text = "Tổng tiền hàng:";
            // 
            // FormTaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 585);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.pnlTongKet);
            this.Controls.Add(this.grpChonSP);
            this.Controls.Add(this.pnlKhachHang);
            this.Controls.Add(this.pnlHeaderPOS);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTaoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập Hóa Đơn Bán Lẻ Mới – VietTien POS";
            this.pnlHeaderPOS.ResumeLayout(false);
            this.pnlHeaderPOS.PerformLayout();
            this.pnlKhachHang.ResumeLayout(false);
            this.pnlKhachHang.PerformLayout();
            this.grpChonSP.ResumeLayout(false);
            this.grpChonSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlTongKet.ResumeLayout(false);
            this.pnlTongKet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderPOS;
        private System.Windows.Forms.Label lblTieuDePOS;
        private System.Windows.Forms.Label lblThuNganPOS;
        private System.Windows.Forms.Panel pnlKhachHang;
        private System.Windows.Forms.Label lblKhachHangPOS;
        private System.Windows.Forms.ComboBox cboKhachHangPOS;
        private System.Windows.Forms.Label lblNgayLapPOS;
        private System.Windows.Forms.GroupBox grpChonSP;
        private System.Windows.Forms.Label lblChonSP;
        private System.Windows.Forms.ComboBox cboSanPhamPOS;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.Button btnXoaKhoiGio;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Panel pnlTongKet;
        private System.Windows.Forms.Label lblTongTienHangText;
        private System.Windows.Forms.Label lblTongTienHang;
        private System.Windows.Forms.Label lblGiamGiaText;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label lblThanhTienText;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.Label lblTienKhachDua;
        private System.Windows.Forms.TextBox txtTienKhachDua;
        private System.Windows.Forms.Label lblTienThua;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyBo;
    }
}

