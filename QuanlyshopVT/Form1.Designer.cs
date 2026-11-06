namespace QuanlyshopVT
{
    partial class Form1
    {
        /// <summary>
        /// Biến quản lý các thành phần của Designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Giải phóng tài nguyên đồ họa khi đóng form.
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
        /// Cho phép mở và chỉnh sửa giao diện thủ công trực quan dễ dàng trên Visual Studio Designer.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.lblDongHo = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusThongBao = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTongSo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusPhienBan = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDongHo = new System.Windows.Forms.Timer(this.components);
            this.tabChinh = new System.Windows.Forms.TabControl();
            this.tabTongQuan = new System.Windows.Forms.TabPage();
            this.pnlKpiBottom = new System.Windows.Forms.Panel();
            this.pnlGiaoDichMoi = new System.Windows.Forms.Panel();
            this.dgvGiaoDichMoi = new System.Windows.Forms.DataGridView();
            this.lblTieuDeGiaoDich = new System.Windows.Forms.Label();
            this.pnlCanhBaoKho = new System.Windows.Forms.Panel();
            this.dgvCanhBaoKho = new System.Windows.Forms.DataGridView();
            this.lblTieuDeCanhBao = new System.Windows.Forms.Label();
            this.pnlKpiActions = new System.Windows.Forms.Panel();
            this.btnQuickLamMoiKPI = new System.Windows.Forms.Button();
            this.btnQuickKhachHang = new System.Windows.Forms.Button();
            this.btnQuickThemSP = new System.Windows.Forms.Button();
            this.btnQuickBanHang = new System.Windows.Forms.Button();
            this.pnlKpiCards = new System.Windows.Forms.Panel();
            this.pnlCardHoaDon = new System.Windows.Forms.Panel();
            this.lblKpiHDGhiChu = new System.Windows.Forms.Label();
            this.lblKpiHDSoLuong = new System.Windows.Forms.Label();
            this.lblKpiHDTieuDe = new System.Windows.Forms.Label();
            this.pnlStripeHD = new System.Windows.Forms.Panel();
            this.pnlCardDoanhThu = new System.Windows.Forms.Panel();
            this.lblKpiDTGhiChu = new System.Windows.Forms.Label();
            this.lblKpiDTSoLuong = new System.Windows.Forms.Label();
            this.lblKpiDTTieuDe = new System.Windows.Forms.Label();
            this.pnlStripeDT = new System.Windows.Forms.Panel();
            this.pnlCardKH = new System.Windows.Forms.Panel();
            this.lblKpiKHGhiChu = new System.Windows.Forms.Label();
            this.lblKpiKHSoLuong = new System.Windows.Forms.Label();
            this.lblKpiKHTieuDe = new System.Windows.Forms.Label();
            this.pnlStripeKH = new System.Windows.Forms.Panel();
            this.pnlCardSP = new System.Windows.Forms.Panel();
            this.lblKpiSPGhiChu = new System.Windows.Forms.Label();
            this.lblKpiSPSoLuong = new System.Windows.Forms.Label();
            this.lblKpiSPTieuDe = new System.Windows.Forms.Label();
            this.pnlStripeSP = new System.Windows.Forms.Panel();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.pnlThaoTacSP = new System.Windows.Forms.Panel();
            this.btnLocHangTonThap = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.btnXuatFileSP = new System.Windows.Forms.Button();
            this.cboLocLoaiSP = new System.Windows.Forms.ComboBox();
            this.lblLocLoaiSP = new System.Windows.Forms.Label();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnLuuSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnLamMoiSP = new System.Windows.Forms.Button();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.lblTimSP = new System.Windows.Forms.Label();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.pnlThaoTacKH = new System.Windows.Forms.Panel();
            this.btnXuatFileKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnLamMoiKH = new System.Windows.Forms.Button();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.lblTimKH = new System.Windows.Forms.Label();
            this.tabNhaCungCap = new System.Windows.Forms.TabPage();
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.pnlThaoTacNCC = new System.Windows.Forms.Panel();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnLuuNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.btnLamMoiNCC = new System.Windows.Forms.Button();
            this.btnTimNCC = new System.Windows.Forms.Button();
            this.txtTimNCC = new System.Windows.Forms.TextBox();
            this.lblTimNCC = new System.Windows.Forms.Label();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.pnlChiTietHDContainer = new System.Windows.Forms.Panel();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.lblTieuDeChiTietHD = new System.Windows.Forms.Label();
            this.pnlThaoTacHD = new System.Windows.Forms.Panel();
            this.btnXuatFileHD = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.btnLamMoiHD = new System.Windows.Forms.Button();
            this.btnTimHD = new System.Windows.Forms.Button();
            this.txtTimHD = new System.Windows.Forms.TextBox();
            this.lblTimHD = new System.Windows.Forms.Label();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.pnlThaoTacNV = new System.Windows.Forms.Panel();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnLuuNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnLamMoiNV = new System.Windows.Forms.Button();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.txtTimNV = new System.Windows.Forms.TextBox();
            this.lblTimNV = new System.Windows.Forms.Label();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.pnlThongKeContainer = new System.Windows.Forms.Panel();
            this.pnlBieuDoThongKe = new System.Windows.Forms.Panel();
            this.pnlBangThongKeContainer = new System.Windows.Forms.Panel();
            this.pnlThongKeSP = new System.Windows.Forms.Panel();
            this.dgvThongKeSP = new System.Windows.Forms.DataGridView();
            this.lblTieuDeTKSP = new System.Windows.Forms.Label();
            this.pnlThongKeNV = new System.Windows.Forms.Panel();
            this.dgvThongKeNV = new System.Windows.Forms.DataGridView();
            this.lblTieuDeTKNV = new System.Windows.Forms.Label();
            this.pnlThaoTacTK = new System.Windows.Forms.Panel();
            this.lblKyBaoCao = new System.Windows.Forms.Label();
            this.cboKyBaoCao = new System.Windows.Forms.ComboBox();
            this.lblCheDoBieuDo = new System.Windows.Forms.Label();
            this.cboCheDoBieuDo = new System.Windows.Forms.ComboBox();
            this.btnLamMoiTK = new System.Windows.Forms.Button();
            this.btnBaoCaoTonKho = new System.Windows.Forms.Button();
            this.btnBaoCaoDoanhThu = new System.Windows.Forms.Button();
            this.btnNapDuLieuGoc = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabChinh.SuspendLayout();
            this.tabTongQuan.SuspendLayout();
            this.pnlKpiBottom.SuspendLayout();
            this.pnlGiaoDichMoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichMoi)).BeginInit();
            this.pnlCanhBaoKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanhBaoKho)).BeginInit();
            this.pnlKpiActions.SuspendLayout();
            this.pnlKpiCards.SuspendLayout();
            this.pnlCardHoaDon.SuspendLayout();
            this.pnlCardDoanhThu.SuspendLayout();
            this.pnlCardKH.SuspendLayout();
            this.pnlCardSP.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.pnlThaoTacSP.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.pnlThaoTacKH.SuspendLayout();
            this.tabNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.pnlThaoTacNCC.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.pnlChiTietHDContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.pnlThaoTacHD.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.pnlThaoTacNV.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.pnlThongKeContainer.SuspendLayout();
            this.pnlBangThongKeContainer.SuspendLayout();
            this.pnlThongKeSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeSP)).BeginInit();
            this.pnlThongKeNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeNV)).BeginInit();
            this.pnlThaoTacTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.btnDoiMatKhau);
            this.pnlHeader.Controls.Add(this.lblDongHo);
            this.pnlHeader.Controls.Add(this.btnDangXuat);
            this.pnlHeader.Controls.Add(this.lblNguoiDung);
            this.pnlHeader.Controls.Add(this.lblPhuDe);
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1204, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(958, 14);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(122, 36);
            this.btnDoiMatKhau.TabIndex = 5;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhauClick);
            // 
            // lblDongHo
            // 
            this.lblDongHo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDongHo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblDongHo.Location = new System.Drawing.Point(460, 20);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(220, 25);
            this.lblDongHo.TabIndex = 4;
            this.lblDongHo.Text = "00:00:00 - 01/01/2026";
            this.lblDongHo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(1090, 14);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(100, 36);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuatClick);
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNguoiDung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDung.ForeColor = System.Drawing.Color.White;
            this.lblNguoiDung.Location = new System.Drawing.Point(685, 20);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(265, 25);
            this.lblNguoiDung.TabIndex = 2;
            this.lblNguoiDung.Text = "Xin chào: Quản lý";
            this.lblNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.AutoSize = true;
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPhuDe.Location = new System.Drawing.Point(18, 38);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(325, 15);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "Hệ Thống Bán Lẻ Thời Trang Công Sở Hàng Đầu Việt Nam";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(15, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(236, 25);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "VIETTIEN FASHION SHOP";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusThongBao,
            this.lblStatusTongSo,
            this.lblStatusPhienBan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 697);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1204, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusThongBao
            // 
            this.lblStatusThongBao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStatusThongBao.Name = "lblStatusThongBao";
            this.lblStatusThongBao.Size = new System.Drawing.Size(952, 19);
            this.lblStatusThongBao.Spring = true;
            this.lblStatusThongBao.Text = "Hệ thống sẵn sàng làm việc.";
            this.lblStatusThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusTongSo
            // 
            this.lblStatusTongSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTongSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblStatusTongSo.Name = "lblStatusTongSo";
            this.lblStatusTongSo.Size = new System.Drawing.Size(125, 19);
            this.lblStatusTongSo.Text = "Tổng số: 0 bản ghi";
            // 
            // lblStatusPhienBan
            // 
            this.lblStatusPhienBan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPhienBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStatusPhienBan.Name = "lblStatusPhienBan";
            this.lblStatusPhienBan.Size = new System.Drawing.Size(112, 19);
            this.lblStatusPhienBan.Text = "Phiên bản: 2.0 Pro";
            // 
            // timerDongHo
            // 
            this.timerDongHo.Enabled = true;
            this.timerDongHo.Interval = 1000;
            this.timerDongHo.Tick += new System.EventHandler(this.timerDongHoTick);
            // 
            // tabChinh
            // 
            this.tabChinh.Controls.Add(this.tabTongQuan);
            this.tabChinh.Controls.Add(this.tabSanPham);
            this.tabChinh.Controls.Add(this.tabKhachHang);
            this.tabChinh.Controls.Add(this.tabNhaCungCap);
            this.tabChinh.Controls.Add(this.tabHoaDon);
            this.tabChinh.Controls.Add(this.tabNhanVien);
            this.tabChinh.Controls.Add(this.tabThongKe);
            this.tabChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabChinh.ItemSize = new System.Drawing.Size(165, 34);
            this.tabChinh.Location = new System.Drawing.Point(0, 65);
            this.tabChinh.Name = "tabChinh";
            this.tabChinh.SelectedIndex = 0;
            this.tabChinh.Size = new System.Drawing.Size(1204, 632);
            this.tabChinh.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabChinh.TabIndex = 1;
            this.tabChinh.SelectedIndexChanged += new System.EventHandler(this.tabChinhSelectedIndexChanged);
            // 
            // tabTongQuan
            // 
            this.tabTongQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabTongQuan.Controls.Add(this.pnlKpiBottom);
            this.tabTongQuan.Controls.Add(this.pnlKpiActions);
            this.tabTongQuan.Controls.Add(this.pnlKpiCards);
            this.tabTongQuan.Location = new System.Drawing.Point(4, 38);
            this.tabTongQuan.Name = "tabTongQuan";
            this.tabTongQuan.Padding = new System.Windows.Forms.Padding(6);
            this.tabTongQuan.Size = new System.Drawing.Size(1196, 590);
            this.tabTongQuan.TabIndex = 0;
            this.tabTongQuan.Text = "Tổng Quan";
            // 
            // pnlKpiBottom
            // 
            this.pnlKpiBottom.Controls.Add(this.pnlGiaoDichMoi);
            this.pnlKpiBottom.Controls.Add(this.pnlCanhBaoKho);
            this.pnlKpiBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiBottom.Location = new System.Drawing.Point(6, 154);
            this.pnlKpiBottom.Name = "pnlKpiBottom";
            this.pnlKpiBottom.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlKpiBottom.Size = new System.Drawing.Size(1184, 430);
            this.pnlKpiBottom.TabIndex = 2;
            // 
            // pnlGiaoDichMoi
            // 
            this.pnlGiaoDichMoi.BackColor = System.Drawing.Color.White;
            this.pnlGiaoDichMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGiaoDichMoi.Controls.Add(this.dgvGiaoDichMoi);
            this.pnlGiaoDichMoi.Controls.Add(this.lblTieuDeGiaoDich);
            this.pnlGiaoDichMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGiaoDichMoi.Location = new System.Drawing.Point(590, 6);
            this.pnlGiaoDichMoi.Name = "pnlGiaoDichMoi";
            this.pnlGiaoDichMoi.Size = new System.Drawing.Size(594, 424);
            this.pnlGiaoDichMoi.TabIndex = 1;
            // 
            // dgvGiaoDichMoi
            // 
            this.dgvGiaoDichMoi.AllowUserToAddRows = false;
            this.dgvGiaoDichMoi.AllowUserToDeleteRows = false;
            this.dgvGiaoDichMoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoDichMoi.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaoDichMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGiaoDichMoi.ColumnHeadersHeight = 32;
            this.dgvGiaoDichMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoDichMoi.Location = new System.Drawing.Point(0, 32);
            this.dgvGiaoDichMoi.MultiSelect = false;
            this.dgvGiaoDichMoi.Name = "dgvGiaoDichMoi";
            this.dgvGiaoDichMoi.ReadOnly = true;
            this.dgvGiaoDichMoi.RowHeadersVisible = false;
            this.dgvGiaoDichMoi.RowTemplate.Height = 28;
            this.dgvGiaoDichMoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoDichMoi.Size = new System.Drawing.Size(592, 390);
            this.dgvGiaoDichMoi.TabIndex = 1;
            this.dgvGiaoDichMoi.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataError);
            // 
            // lblTieuDeGiaoDich
            // 
            this.lblTieuDeGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblTieuDeGiaoDich.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeGiaoDich.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeGiaoDich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.lblTieuDeGiaoDich.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeGiaoDich.Name = "lblTieuDeGiaoDich";
            this.lblTieuDeGiaoDich.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTieuDeGiaoDich.Size = new System.Drawing.Size(592, 32);
            this.lblTieuDeGiaoDich.TabIndex = 0;
            this.lblTieuDeGiaoDich.Text = "GIAO DỊCH BÁN HÀNG GẦN ĐÂY";
            this.lblTieuDeGiaoDich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCanhBaoKho
            // 
            this.pnlCanhBaoKho.BackColor = System.Drawing.Color.White;
            this.pnlCanhBaoKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanhBaoKho.Controls.Add(this.dgvCanhBaoKho);
            this.pnlCanhBaoKho.Controls.Add(this.lblTieuDeCanhBao);
            this.pnlCanhBaoKho.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCanhBaoKho.Location = new System.Drawing.Point(0, 6);
            this.pnlCanhBaoKho.Name = "pnlCanhBaoKho";
            this.pnlCanhBaoKho.Size = new System.Drawing.Size(590, 424);
            this.pnlCanhBaoKho.TabIndex = 0;
            // 
            // dgvCanhBaoKho
            // 
            this.dgvCanhBaoKho.AllowUserToAddRows = false;
            this.dgvCanhBaoKho.AllowUserToDeleteRows = false;
            this.dgvCanhBaoKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanhBaoKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvCanhBaoKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCanhBaoKho.ColumnHeadersHeight = 32;
            this.dgvCanhBaoKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCanhBaoKho.Location = new System.Drawing.Point(0, 32);
            this.dgvCanhBaoKho.MultiSelect = false;
            this.dgvCanhBaoKho.Name = "dgvCanhBaoKho";
            this.dgvCanhBaoKho.ReadOnly = true;
            this.dgvCanhBaoKho.RowHeadersVisible = false;
            this.dgvCanhBaoKho.RowTemplate.Height = 28;
            this.dgvCanhBaoKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanhBaoKho.Size = new System.Drawing.Size(588, 390);
            this.dgvCanhBaoKho.TabIndex = 1;
            this.dgvCanhBaoKho.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataError);
            // 
            // lblTieuDeCanhBao
            // 
            this.lblTieuDeCanhBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTieuDeCanhBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeCanhBao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeCanhBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblTieuDeCanhBao.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeCanhBao.Name = "lblTieuDeCanhBao";
            this.lblTieuDeCanhBao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTieuDeCanhBao.Size = new System.Drawing.Size(588, 32);
            this.lblTieuDeCanhBao.TabIndex = 0;
            this.lblTieuDeCanhBao.Text = "CẢNH BÁO TỒN KHO THẤP (< 30 CHIẾC CẦN NHẬP THÊM)";
            this.lblTieuDeCanhBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlKpiActions
            // 
            this.pnlKpiActions.BackColor = System.Drawing.Color.White;
            this.pnlKpiActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiActions.Controls.Add(this.btnQuickLamMoiKPI);
            this.pnlKpiActions.Controls.Add(this.btnQuickKhachHang);
            this.pnlKpiActions.Controls.Add(this.btnQuickThemSP);
            this.pnlKpiActions.Controls.Add(this.btnQuickBanHang);
            this.pnlKpiActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpiActions.Location = new System.Drawing.Point(6, 106);
            this.pnlKpiActions.Name = "pnlKpiActions";
            this.pnlKpiActions.Size = new System.Drawing.Size(1184, 48);
            this.pnlKpiActions.TabIndex = 1;
            // 
            // btnQuickLamMoiKPI
            // 
            this.btnQuickLamMoiKPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnQuickLamMoiKPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickLamMoiKPI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnQuickLamMoiKPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickLamMoiKPI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickLamMoiKPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnQuickLamMoiKPI.Location = new System.Drawing.Point(582, 8);
            this.btnQuickLamMoiKPI.Name = "btnQuickLamMoiKPI";
            this.btnQuickLamMoiKPI.Size = new System.Drawing.Size(160, 30);
            this.btnQuickLamMoiKPI.TabIndex = 3;
            this.btnQuickLamMoiKPI.Text = "Cập Nhật Số Liệu";
            this.btnQuickLamMoiKPI.UseVisualStyleBackColor = false;
            this.btnQuickLamMoiKPI.Click += new System.EventHandler(this.btnQuickLamMoiKPIClick);
            // 
            // btnQuickKhachHang
            // 
            this.btnQuickKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnQuickKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQuickKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnQuickKhachHang.Location = new System.Drawing.Point(392, 8);
            this.btnQuickKhachHang.Name = "btnQuickKhachHang";
            this.btnQuickKhachHang.Size = new System.Drawing.Size(180, 30);
            this.btnQuickKhachHang.TabIndex = 2;
            this.btnQuickKhachHang.Text = "Khách Hàng Thân Thiết";
            this.btnQuickKhachHang.UseVisualStyleBackColor = false;
            this.btnQuickKhachHang.Click += new System.EventHandler(this.btnQuickKhachHangClick);
            // 
            // btnQuickThemSP
            // 
            this.btnQuickThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnQuickThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickThemSP.FlatAppearance.BorderSize = 0;
            this.btnQuickThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickThemSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickThemSP.ForeColor = System.Drawing.Color.White;
            this.btnQuickThemSP.Location = new System.Drawing.Point(202, 8);
            this.btnQuickThemSP.Name = "btnQuickThemSP";
            this.btnQuickThemSP.Size = new System.Drawing.Size(180, 30);
            this.btnQuickThemSP.TabIndex = 1;
            this.btnQuickThemSP.Text = "Quản Lý Sản Phẩm";
            this.btnQuickThemSP.UseVisualStyleBackColor = false;
            this.btnQuickThemSP.Click += new System.EventHandler(this.btnQuickThemSPClick);
            // 
            // btnQuickBanHang
            // 
            this.btnQuickBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnQuickBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickBanHang.FlatAppearance.BorderSize = 0;
            this.btnQuickBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickBanHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickBanHang.ForeColor = System.Drawing.Color.White;
            this.btnQuickBanHang.Location = new System.Drawing.Point(12, 8);
            this.btnQuickBanHang.Name = "btnQuickBanHang";
            this.btnQuickBanHang.Size = new System.Drawing.Size(180, 30);
            this.btnQuickBanHang.TabIndex = 0;
            this.btnQuickBanHang.Text = "Lập Đơn Bán Mới";
            this.btnQuickBanHang.UseVisualStyleBackColor = false;
            this.btnQuickBanHang.Click += new System.EventHandler(this.btnQuickBanHangClick);
            // 
            // pnlKpiCards
            // 
            this.pnlKpiCards.Controls.Add(this.pnlCardHoaDon);
            this.pnlKpiCards.Controls.Add(this.pnlCardDoanhThu);
            this.pnlKpiCards.Controls.Add(this.pnlCardKH);
            this.pnlKpiCards.Controls.Add(this.pnlCardSP);
            this.pnlKpiCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpiCards.Location = new System.Drawing.Point(6, 6);
            this.pnlKpiCards.Name = "pnlKpiCards";
            this.pnlKpiCards.Size = new System.Drawing.Size(1184, 100);
            this.pnlKpiCards.TabIndex = 0;
            // 
            // pnlCardHoaDon
            // 
            this.pnlCardHoaDon.BackColor = System.Drawing.Color.White;
            this.pnlCardHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardHoaDon.Controls.Add(this.lblKpiHDGhiChu);
            this.pnlCardHoaDon.Controls.Add(this.lblKpiHDSoLuong);
            this.pnlCardHoaDon.Controls.Add(this.lblKpiHDTieuDe);
            this.pnlCardHoaDon.Controls.Add(this.pnlStripeHD);
            this.pnlCardHoaDon.Location = new System.Drawing.Point(888, 5);
            this.pnlCardHoaDon.Name = "pnlCardHoaDon";
            this.pnlCardHoaDon.Size = new System.Drawing.Size(285, 88);
            this.pnlCardHoaDon.TabIndex = 3;
            // 
            // lblKpiHDGhiChu
            // 
            this.lblKpiHDGhiChu.AutoSize = true;
            this.lblKpiHDGhiChu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiHDGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblKpiHDGhiChu.Location = new System.Drawing.Point(18, 62);
            this.lblKpiHDGhiChu.Name = "lblKpiHDGhiChu";
            this.lblKpiHDGhiChu.Size = new System.Drawing.Size(146, 13);
            this.lblKpiHDGhiChu.TabIndex = 3;
            this.lblKpiHDGhiChu.Text = "Tỷ lệ hoàn tất đơn hàng: 100%";
            // 
            // lblKpiHDSoLuong
            // 
            this.lblKpiHDSoLuong.AutoSize = true;
            this.lblKpiHDSoLuong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiHDSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblKpiHDSoLuong.Location = new System.Drawing.Point(16, 26);
            this.lblKpiHDSoLuong.Name = "lblKpiHDSoLuong";
            this.lblKpiHDSoLuong.Size = new System.Drawing.Size(130, 30);
            this.lblKpiHDSoLuong.TabIndex = 2;
            this.lblKpiHDSoLuong.Text = "1 Đơn Hàng";
            // 
            // lblKpiHDTieuDe
            // 
            this.lblKpiHDTieuDe.AutoSize = true;
            this.lblKpiHDTieuDe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiHDTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiHDTieuDe.Location = new System.Drawing.Point(18, 8);
            this.lblKpiHDTieuDe.Name = "lblKpiHDTieuDe";
            this.lblKpiHDTieuDe.Size = new System.Drawing.Size(127, 13);
            this.lblKpiHDTieuDe.TabIndex = 1;
            this.lblKpiHDTieuDe.Text = "HÓA ĐƠN HOÀN TẤT";
            // 
            // pnlStripeHD
            // 
            this.pnlStripeHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.pnlStripeHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripeHD.Location = new System.Drawing.Point(0, 0);
            this.pnlStripeHD.Name = "pnlStripeHD";
            this.pnlStripeHD.Size = new System.Drawing.Size(6, 86);
            this.pnlStripeHD.TabIndex = 0;
            // 
            // pnlCardDoanhThu
            // 
            this.pnlCardDoanhThu.BackColor = System.Drawing.Color.White;
            this.pnlCardDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardDoanhThu.Controls.Add(this.lblKpiDTGhiChu);
            this.pnlCardDoanhThu.Controls.Add(this.lblKpiDTSoLuong);
            this.pnlCardDoanhThu.Controls.Add(this.lblKpiDTTieuDe);
            this.pnlCardDoanhThu.Controls.Add(this.pnlStripeDT);
            this.pnlCardDoanhThu.Location = new System.Drawing.Point(595, 5);
            this.pnlCardDoanhThu.Name = "pnlCardDoanhThu";
            this.pnlCardDoanhThu.Size = new System.Drawing.Size(285, 88);
            this.pnlCardDoanhThu.TabIndex = 2;
            // 
            // lblKpiDTGhiChu
            // 
            this.lblKpiDTGhiChu.AutoSize = true;
            this.lblKpiDTGhiChu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiDTGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblKpiDTGhiChu.Location = new System.Drawing.Point(18, 62);
            this.lblKpiDTGhiChu.Name = "lblKpiDTGhiChu";
            this.lblKpiDTGhiChu.Size = new System.Drawing.Size(124, 13);
            this.lblKpiDTGhiChu.TabIndex = 3;
            this.lblKpiDTGhiChu.Text = "Doanh số thực thu bán lẻ";
            // 
            // lblKpiDTSoLuong
            // 
            this.lblKpiDTSoLuong.AutoSize = true;
            this.lblKpiDTSoLuong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiDTSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblKpiDTSoLuong.Location = new System.Drawing.Point(16, 26);
            this.lblKpiDTSoLuong.Name = "lblKpiDTSoLuong";
            this.lblKpiDTSoLuong.Size = new System.Drawing.Size(117, 30);
            this.lblKpiDTSoLuong.TabIndex = 2;
            this.lblKpiDTSoLuong.Text = "800.000 đ";
            // 
            // lblKpiDTTieuDe
            // 
            this.lblKpiDTTieuDe.AutoSize = true;
            this.lblKpiDTTieuDe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiDTTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiDTTieuDe.Location = new System.Drawing.Point(18, 8);
            this.lblKpiDTTieuDe.Name = "lblKpiDTTieuDe";
            this.lblKpiDTTieuDe.Size = new System.Drawing.Size(120, 13);
            this.lblKpiDTTieuDe.TabIndex = 1;
            this.lblKpiDTTieuDe.Text = "TỔNG DOANH THU";
            // 
            // pnlStripeDT
            // 
            this.pnlStripeDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.pnlStripeDT.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripeDT.Location = new System.Drawing.Point(0, 0);
            this.pnlStripeDT.Name = "pnlStripeDT";
            this.pnlStripeDT.Size = new System.Drawing.Size(6, 86);
            this.pnlStripeDT.TabIndex = 0;
            // 
            // pnlCardKH
            // 
            this.pnlCardKH.BackColor = System.Drawing.Color.White;
            this.pnlCardKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardKH.Controls.Add(this.lblKpiKHGhiChu);
            this.pnlCardKH.Controls.Add(this.lblKpiKHSoLuong);
            this.pnlCardKH.Controls.Add(this.lblKpiKHTieuDe);
            this.pnlCardKH.Controls.Add(this.pnlStripeKH);
            this.pnlCardKH.Location = new System.Drawing.Point(302, 5);
            this.pnlCardKH.Name = "pnlCardKH";
            this.pnlCardKH.Size = new System.Drawing.Size(285, 88);
            this.pnlCardKH.TabIndex = 1;
            // 
            // lblKpiKHGhiChu
            // 
            this.lblKpiKHGhiChu.AutoSize = true;
            this.lblKpiKHGhiChu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiKHGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblKpiKHGhiChu.Location = new System.Drawing.Point(18, 62);
            this.lblKpiKHGhiChu.Name = "lblKpiKHGhiChu";
            this.lblKpiKHGhiChu.Size = new System.Drawing.Size(126, 13);
            this.lblKpiKHGhiChu.TabIndex = 3;
            this.lblKpiKHGhiChu.Text = "1 Khách VIP, 1 Thành viên";
            // 
            // lblKpiKHSoLuong
            // 
            this.lblKpiKHSoLuong.AutoSize = true;
            this.lblKpiKHSoLuong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiKHSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblKpiKHSoLuong.Location = new System.Drawing.Point(16, 26);
            this.lblKpiKHSoLuong.Name = "lblKpiKHSoLuong";
            this.lblKpiKHSoLuong.Size = new System.Drawing.Size(152, 30);
            this.lblKpiKHSoLuong.TabIndex = 2;
            this.lblKpiKHSoLuong.Text = "3 Khách Hàng";
            // 
            // lblKpiKHTieuDe
            // 
            this.lblKpiKHTieuDe.AutoSize = true;
            this.lblKpiKHTieuDe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiKHTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiKHTieuDe.Location = new System.Drawing.Point(18, 8);
            this.lblKpiKHTieuDe.Name = "lblKpiKHTieuDe";
            this.lblKpiKHTieuDe.Size = new System.Drawing.Size(100, 13);
            this.lblKpiKHTieuDe.TabIndex = 1;
            this.lblKpiKHTieuDe.Text = "KHÁCH HÀNG";
            // 
            // pnlStripeKH
            // 
            this.pnlStripeKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.pnlStripeKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripeKH.Location = new System.Drawing.Point(0, 0);
            this.pnlStripeKH.Name = "pnlStripeKH";
            this.pnlStripeKH.Size = new System.Drawing.Size(6, 86);
            this.pnlStripeKH.TabIndex = 0;
            // 
            // pnlCardSP
            // 
            this.pnlCardSP.BackColor = System.Drawing.Color.White;
            this.pnlCardSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardSP.Controls.Add(this.lblKpiSPGhiChu);
            this.pnlCardSP.Controls.Add(this.lblKpiSPSoLuong);
            this.pnlCardSP.Controls.Add(this.lblKpiSPTieuDe);
            this.pnlCardSP.Controls.Add(this.pnlStripeSP);
            this.pnlCardSP.Location = new System.Drawing.Point(9, 5);
            this.pnlCardSP.Name = "pnlCardSP";
            this.pnlCardSP.Size = new System.Drawing.Size(285, 88);
            this.pnlCardSP.TabIndex = 0;
            // 
            // lblKpiSPGhiChu
            // 
            this.lblKpiSPGhiChu.AutoSize = true;
            this.lblKpiSPGhiChu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiSPGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblKpiSPGhiChu.Location = new System.Drawing.Point(18, 62);
            this.lblKpiSPGhiChu.Name = "lblKpiSPGhiChu";
            this.lblKpiSPGhiChu.Size = new System.Drawing.Size(126, 13);
            this.lblKpiSPGhiChu.TabIndex = 3;
            this.lblKpiSPGhiChu.Text = "Tổng tồn kho: 265 chiếc";
            // 
            // lblKpiSPSoLuong
            // 
            this.lblKpiSPSoLuong.AutoSize = true;
            this.lblKpiSPSoLuong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiSPSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblKpiSPSoLuong.Location = new System.Drawing.Point(16, 26);
            this.lblKpiSPSoLuong.Name = "lblKpiSPSoLuong";
            this.lblKpiSPSoLuong.Size = new System.Drawing.Size(122, 30);
            this.lblKpiSPSoLuong.TabIndex = 2;
            this.lblKpiSPSoLuong.Text = "6 Loại Hàng";
            // 
            // lblKpiSPTieuDe
            // 
            this.lblKpiSPTieuDe.AutoSize = true;
            this.lblKpiSPTieuDe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiSPTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKpiSPTieuDe.Location = new System.Drawing.Point(18, 8);
            this.lblKpiSPTieuDe.Name = "lblKpiSPTieuDe";
            this.lblKpiSPTieuDe.Size = new System.Drawing.Size(117, 13);
            this.lblKpiSPTieuDe.TabIndex = 1;
            this.lblKpiSPTieuDe.Text = "TỔNG SẢN PHẨM";
            // 
            // pnlStripeSP
            // 
            this.pnlStripeSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlStripeSP.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripeSP.Location = new System.Drawing.Point(0, 0);
            this.pnlStripeSP.Name = "pnlStripeSP";
            this.pnlStripeSP.Size = new System.Drawing.Size(6, 86);
            this.pnlStripeSP.TabIndex = 0;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.dgvSanPham);
            this.tabSanPham.Controls.Add(this.pnlThaoTacSP);
            this.tabSanPham.Location = new System.Drawing.Point(4, 38);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(1196, 590);
            this.tabSanPham.TabIndex = 1;
            this.tabSanPham.Text = "Sản Phẩm & Kho Hàng";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSanPham.ColumnHeadersHeight = 36;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 55);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 32;
            this.dgvSanPham.RowTemplate.Height = 30;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1190, 532);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPhamCellValueChanged);
            this.dgvSanPham.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataError);
            // 
            // pnlThaoTacSP
            // 
            this.pnlThaoTacSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlThaoTacSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThaoTacSP.Controls.Add(this.btnLocHangTonThap);
            this.pnlThaoTacSP.Controls.Add(this.btnNhapKho);
            this.pnlThaoTacSP.Controls.Add(this.btnXuatFileSP);
            this.pnlThaoTacSP.Controls.Add(this.cboLocLoaiSP);
            this.pnlThaoTacSP.Controls.Add(this.lblLocLoaiSP);
            this.pnlThaoTacSP.Controls.Add(this.btnXoaSP);
            this.pnlThaoTacSP.Controls.Add(this.btnLuuSP);
            this.pnlThaoTacSP.Controls.Add(this.btnThemSP);
            this.pnlThaoTacSP.Controls.Add(this.btnLamMoiSP);
            this.pnlThaoTacSP.Controls.Add(this.btnTimSP);
            this.pnlThaoTacSP.Controls.Add(this.txtTimSP);
            this.pnlThaoTacSP.Controls.Add(this.lblTimSP);
            this.pnlThaoTacSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThaoTacSP.Location = new System.Drawing.Point(3, 3);
            this.pnlThaoTacSP.Name = "pnlThaoTacSP";
            this.pnlThaoTacSP.Size = new System.Drawing.Size(1190, 52);
            this.pnlThaoTacSP.TabIndex = 0;
            // 
            // btnLocHangTonThap
            // 
            this.btnLocHangTonThap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnLocHangTonThap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocHangTonThap.FlatAppearance.BorderSize = 0;
            this.btnLocHangTonThap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocHangTonThap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocHangTonThap.ForeColor = System.Drawing.Color.White;
            this.btnLocHangTonThap.Location = new System.Drawing.Point(676, 11);
            this.btnLocHangTonThap.Name = "btnLocHangTonThap";
            this.btnLocHangTonThap.Size = new System.Drawing.Size(120, 28);
            this.btnLocHangTonThap.TabIndex = 11;
            this.btnLocHangTonThap.Text = "Tồn Thấp (<30)";
            this.btnLocHangTonThap.UseVisualStyleBackColor = false;
            this.btnLocHangTonThap.Click += new System.EventHandler(this.btnLocHangTonThapClick);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.Location = new System.Drawing.Point(555, 11);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(115, 28);
            this.btnNhapKho.TabIndex = 10;
            this.btnNhapKho.Text = "Nhập Thêm Kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKhoClick);
            // 
            // btnXuatFileSP
            // 
            this.btnXuatFileSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnXuatFileSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFileSP.FlatAppearance.BorderSize = 0;
            this.btnXuatFileSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFileSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFileSP.ForeColor = System.Drawing.Color.White;
            this.btnXuatFileSP.Location = new System.Drawing.Point(474, 11);
            this.btnXuatFileSP.Name = "btnXuatFileSP";
            this.btnXuatFileSP.Size = new System.Drawing.Size(75, 28);
            this.btnXuatFileSP.TabIndex = 9;
            this.btnXuatFileSP.Text = "Xuất File";
            this.btnXuatFileSP.UseVisualStyleBackColor = false;
            this.btnXuatFileSP.Click += new System.EventHandler(this.btnXuatFileSPClick);
            // 
            // cboLocLoaiSP
            // 
            this.cboLocLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocLoaiSP.FormattingEnabled = true;
            this.cboLocLoaiSP.Items.AddRange(new object[] {
            "Tất cả loại",
            "Áo sơ mi",
            "Quần tây",
            "Áo polo",
            "Vest",
            "Phụ kiện"});
            this.cboLocLoaiSP.Location = new System.Drawing.Point(76, 13);
            this.cboLocLoaiSP.Name = "cboLocLoaiSP";
            this.cboLocLoaiSP.Size = new System.Drawing.Size(105, 25);
            this.cboLocLoaiSP.TabIndex = 8;
            this.cboLocLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLocLoaiSPSelectedIndexChanged);
            // 
            // lblLocLoaiSP
            // 
            this.lblLocLoaiSP.AutoSize = true;
            this.lblLocLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocLoaiSP.Location = new System.Drawing.Point(12, 17);
            this.lblLocLoaiSP.Name = "lblLocLoaiSP";
            this.lblLocLoaiSP.Size = new System.Drawing.Size(62, 15);
            this.lblLocLoaiSP.TabIndex = 7;
            this.lblLocLoaiSP.Text = "Phân loại:";
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSP.FlatAppearance.BorderSize = 0;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(1094, 9);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(84, 32);
            this.btnXoaSP.TabIndex = 6;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSPClick);
            // 
            // btnLuuSP
            // 
            this.btnLuuSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnLuuSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuSP.Enabled = false;
            this.btnLuuSP.FlatAppearance.BorderSize = 0;
            this.btnLuuSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuSP.ForeColor = System.Drawing.Color.White;
            this.btnLuuSP.Location = new System.Drawing.Point(1004, 9);
            this.btnLuuSP.Name = "btnLuuSP";
            this.btnLuuSP.Size = new System.Drawing.Size(84, 32);
            this.btnLuuSP.TabIndex = 5;
            this.btnLuuSP.Text = "Lưu";
            this.btnLuuSP.UseVisualStyleBackColor = false;
            this.btnLuuSP.Click += new System.EventHandler(this.btnLuuSPClick);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(894, 9);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(104, 32);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Thêm mới";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSPClick);
            // 
            // btnLamMoiSP
            // 
            this.btnLamMoiSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnLamMoiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiSP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnLamMoiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiSP.Location = new System.Drawing.Point(398, 11);
            this.btnLamMoiSP.Name = "btnLamMoiSP";
            this.btnLamMoiSP.Size = new System.Drawing.Size(70, 28);
            this.btnLamMoiSP.TabIndex = 3;
            this.btnLamMoiSP.Text = "Làm mới";
            this.btnLamMoiSP.UseVisualStyleBackColor = false;
            this.btnLamMoiSP.Click += new System.EventHandler(this.btnLamMoiSPClick);
            // 
            // btnTimSP
            // 
            this.btnTimSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTimSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimSP.FlatAppearance.BorderSize = 0;
            this.btnTimSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSP.ForeColor = System.Drawing.Color.White;
            this.btnTimSP.Location = new System.Drawing.Point(340, 11);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(52, 28);
            this.btnTimSP.TabIndex = 2;
            this.btnTimSP.Text = "Tìm";
            this.btnTimSP.UseVisualStyleBackColor = false;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSPClick);
            // 
            // txtTimSP
            // 
            this.txtTimSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSP.Location = new System.Drawing.Point(232, 13);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(102, 25);
            this.txtTimSP.TabIndex = 1;
            this.txtTimSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimSPKeyDown);
            this.txtTimSP.TextChanged += new System.EventHandler(this.txtTimSPTextChanged);
            // 
            // lblTimSP
            // 
            this.lblTimSP.AutoSize = true;
            this.lblTimSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimSP.Location = new System.Drawing.Point(185, 17);
            this.lblTimSP.Name = "lblTimSP";
            this.lblTimSP.Size = new System.Drawing.Size(44, 15);
            this.lblTimSP.TabIndex = 0;
            this.lblTimSP.Text = "Từ khóa:";
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.dgvKhachHang);
            this.tabKhachHang.Controls.Add(this.pnlThaoTacKH);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 38);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(1196, 590);
            this.tabKhachHang.TabIndex = 2;
            this.tabKhachHang.Text = "Khách Hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKhachHang.ColumnHeadersHeight = 36;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 55);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 32;
            this.dgvKhachHang.RowTemplate.Height = 30;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1190, 532);
            this.dgvKhachHang.TabIndex = 1;
            this.dgvKhachHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHangCellValueChanged);
            this.dgvKhachHang.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataError);
            // 
            // pnlThaoTacKH
            // 
            this.pnlThaoTacKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlThaoTacKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThaoTacKH.Controls.Add(this.btnXuatFileKH);
            this.pnlThaoTacKH.Controls.Add(this.btnXoaKH);
            this.pnlThaoTacKH.Controls.Add(this.btnLuuKH);
            this.pnlThaoTacKH.Controls.Add(this.btnThemKH);
            this.pnlThaoTacKH.Controls.Add(this.btnLamMoiKH);
            this.pnlThaoTacKH.Controls.Add(this.btnTimKH);
            this.pnlThaoTacKH.Controls.Add(this.txtTimKH);
            this.pnlThaoTacKH.Controls.Add(this.lblTimKH);
            this.pnlThaoTacKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThaoTacKH.Location = new System.Drawing.Point(3, 3);
            this.pnlThaoTacKH.Name = "pnlThaoTacKH";
            this.pnlThaoTacKH.Size = new System.Drawing.Size(1190, 52);
            this.pnlThaoTacKH.TabIndex = 0;
            // 
            // btnXuatFileKH
            // 
            this.btnXuatFileKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnXuatFileKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFileKH.FlatAppearance.BorderSize = 0;
            this.btnXuatFileKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFileKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFileKH.ForeColor = System.Drawing.Color.White;
            this.btnXuatFileKH.Location = new System.Drawing.Point(490, 11);
            this.btnXuatFileKH.Name = "btnXuatFileKH";
            this.btnXuatFileKH.Size = new System.Drawing.Size(95, 28);
            this.btnXuatFileKH.TabIndex = 7;
            this.btnXuatFileKH.Text = "Xuất File";
            this.btnXuatFileKH.UseVisualStyleBackColor = false;
            this.btnXuatFileKH.Click += new System.EventHandler(this.btnXuatFileKHClick);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKH.FlatAppearance.BorderSize = 0;
            this.btnXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.ForeColor = System.Drawing.Color.White;
            this.btnXoaKH.Location = new System.Drawing.Point(1088, 9);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(90, 32);
            this.btnXoaKH.TabIndex = 6;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKHClick);
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnLuuKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuKH.Enabled = false;
            this.btnLuuKH.FlatAppearance.BorderSize = 0;
            this.btnLuuKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKH.ForeColor = System.Drawing.Color.White;
            this.btnLuuKH.Location = new System.Drawing.Point(990, 9);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(92, 32);
            this.btnLuuKH.TabIndex = 5;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.UseVisualStyleBackColor = false;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKHClick);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnThemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKH.FlatAppearance.BorderSize = 0;
            this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.Color.White;
            this.btnThemKH.Location = new System.Drawing.Point(875, 9);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(108, 32);
            this.btnThemKH.TabIndex = 4;
            this.btnThemKH.Text = "Thêm mới";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKHClick);
            // 
            // btnLamMoiKH
            // 
            this.btnLamMoiKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnLamMoiKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiKH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnLamMoiKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiKH.Location = new System.Drawing.Point(395, 11);
            this.btnLamMoiKH.Name = "btnLamMoiKH";
            this.btnLamMoiKH.Size = new System.Drawing.Size(86, 28);
            this.btnLamMoiKH.TabIndex = 3;
            this.btnLamMoiKH.Text = "Làm mới";
            this.btnLamMoiKH.UseVisualStyleBackColor = false;
            this.btnLamMoiKH.Click += new System.EventHandler(this.btnLamMoiKHClick);
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTimKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKH.FlatAppearance.BorderSize = 0;
            this.btnTimKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKH.ForeColor = System.Drawing.Color.White;
            this.btnTimKH.Location = new System.Drawing.Point(320, 11);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(68, 28);
            this.btnTimKH.TabIndex = 2;
            this.btnTimKH.Text = "Tìm";
            this.btnTimKH.UseVisualStyleBackColor = false;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKHClick);
            // 
            // txtTimKH
            // 
            this.txtTimKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKH.Location = new System.Drawing.Point(88, 13);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(222, 25);
            this.txtTimKH.TabIndex = 1;
            this.txtTimKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKHKeyDown);
            // 
            // lblTimKH
            // 
            this.lblTimKH.AutoSize = true;
            this.lblTimKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKH.Location = new System.Drawing.Point(14, 17);
            this.lblTimKH.Name = "lblTimKH";
            this.lblTimKH.Size = new System.Drawing.Size(56, 15);
            this.lblTimKH.TabIndex = 0;
            this.lblTimKH.Text = "Từ khóa:";
            // 
            // tabNhaCungCap
            // 
            this.tabNhaCungCap.Controls.Add(this.dgvNhaCungCap);
            this.tabNhaCungCap.Controls.Add(this.pnlThaoTacNCC);
            this.tabNhaCungCap.Location = new System.Drawing.Point(4, 38);
            this.tabNhaCungCap.Name = "tabNhaCungCap";
            this.tabNhaCungCap.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhaCungCap.Size = new System.Drawing.Size(1196, 590);
            this.tabNhaCungCap.TabIndex = 3;
            this.tabNhaCungCap.Text = "Nhà Cung Cấp";
            this.tabNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.AllowUserToAddRows = false;
            this.dgvNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaCungCap.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNhaCungCap.ColumnHeadersHeight = 36;
            this.dgvNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhaCungCap.Location = new System.Drawing.Point(3, 55);
            this.dgvNhaCungCap.MultiSelect = false;
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.RowHeadersWidth = 32;
            this.dgvNhaCungCap.RowTemplate.Height = 30;
            this.dgvNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(1190, 532);
            this.dgvNhaCungCap.TabIndex = 1;
            this.dgvNhaCungCap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCapCellValueChanged);
            this.dgvNhaCungCap.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataError);
            // 
            // pnlThaoTacNCC
            // 
            this.pnlThaoTacNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlThaoTacNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThaoTacNCC.Controls.Add(this.btnXoaNCC);
            this.pnlThaoTacNCC.Controls.Add(this.btnLuuNCC);
            this.pnlThaoTacNCC.Controls.Add(this.btnThemNCC);
            this.pnlThaoTacNCC.Controls.Add(this.btnLamMoiNCC);
            this.pnlThaoTacNCC.Controls.Add(this.btnTimNCC);
            this.pnlThaoTacNCC.Controls.Add(this.txtTimNCC);
            this.pnlThaoTacNCC.Controls.Add(this.lblTimNCC);
            this.pnlThaoTacNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThaoTacNCC.Location = new System.Drawing.Point(3, 3);
            this.pnlThaoTacNCC.Name = "pnlThaoTacNCC";
            this.pnlThaoTacNCC.Size = new System.Drawing.Size(1190, 52);
            this.pnlThaoTacNCC.TabIndex = 0;
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNCC.FlatAppearance.BorderSize = 0;
            this.btnXoaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNCC.ForeColor = System.Drawing.Color.White;
            this.btnXoaNCC.Location = new System.Drawing.Point(1088, 9);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(90, 32);
            this.btnXoaNCC.TabIndex = 6;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.UseVisualStyleBackColor = false;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCCClick);
            // 
            // btnLuuNCC
            // 
            this.btnLuuNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnLuuNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuNCC.Enabled = false;
            this.btnLuuNCC.FlatAppearance.BorderSize = 0;
            this.btnLuuNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNCC.ForeColor = System.Drawing.Color.White;
            this.btnLuuNCC.Location = new System.Drawing.Point(990, 9);
            this.btnLuuNCC.Name = "btnLuuNCC";
            this.btnLuuNCC.Size = new System.Drawing.Size(92, 32);
            this.btnLuuNCC.TabIndex = 5;
            this.btnLuuNCC.Text = "Lưu";
            this.btnLuuNCC.UseVisualStyleBackColor = false;
            this.btnLuuNCC.Click += new System.EventHandler(this.btnLuuNCCClick);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnThemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNCC.FlatAppearance.BorderSize = 0;
            this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.ForeColor = System.Drawing.Color.White;
            this.btnThemNCC.Location = new System.Drawing.Point(875, 9);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(108, 32);
            this.btnThemNCC.TabIndex = 4;
            this.btnThemNCC.Text = "Thêm mới";
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCCClick);
            // 
            // btnLamMoiNCC
            // 
            this.btnLamMoiNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnLamMoiNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiNCC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnLamMoiNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiNCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiNCC.Location = new System.Drawing.Point(395, 11);
            this.btnLamMoiNCC.Name = "btnLamMoiNCC";
            this.btnLamMoiNCC.Size = new System.Drawing.Size(86, 28);
            this.btnLamMoiNCC.TabIndex = 3;
            this.btnLamMoiNCC.Text = "Làm mới";
            this.btnLamMoiNCC.UseVisualStyleBackColor = false;
            this.btnLamMoiNCC.Click += new System.EventHandler(this.btnLamMoiNCCClick);
            // 
            // btnTimNCC
            // 
            this.btnTimNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTimNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimNCC.FlatAppearance.BorderSize = 0;
            this.btnTimNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimNCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNCC.ForeColor = System.Drawing.Color.White;
            this.btnTimNCC.Location = new System.Drawing.Point(320, 11);
            this.btnTimNCC.Name = "btnTimNCC";
            this.btnTimNCC.Size = new System.Drawing.Size(68, 28);
            this.btnTimNCC.TabIndex = 2;
            this.btnTimNCC.Text = "Tìm";
            this.btnTimNCC.UseVisualStyleBackColor = false;
            this.btnTimNCC.Click += new System.EventHandler(this.btnTimNCCClick);
            // 
            // txtTimNCC
            // 
            this.txtTimNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNCC.Location = new System.Drawing.Point(88, 13);
            this.txtTimNCC.Name = "txtTimNCC";
            this.txtTimNCC.Size = new System.Drawing.Size(222, 25);
            this.txtTimNCC.TabIndex = 1;
            this.txtTimNCC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimNCCKeyDown);
            // 
            // lblTimNCC
            // 
            this.lblTimNCC.AutoSize = true;
            this.lblTimNCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimNCC.Location = new System.Drawing.Point(14, 17);
            this.lblTimNCC.Name = "lblTimNCC";
            this.lblTimNCC.Size = new System.Drawing.Size(56, 15);
            this.lblTimNCC.TabIndex = 0;
            this.lblTimNCC.Text = "Từ khóa:";
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Controls.Add(this.dgvHoaDon);
            this.tabHoaDon.Controls.Add(this.pnlChiTietHDContainer);
            this.tabHoaDon.Controls.Add(this.pnlThaoTacHD);
            this.tabHoaDon.Location = new System.Drawing.Point(4, 38);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoaDon.Size = new System.Drawing.Size(1196, 590);
            this.tabHoaDon.TabIndex = 4;
            this.tabHoaDon.Text = "Hóa Đơn & Bán Hàng";
            this.tabHoaDon.UseVisualStyleBackColor = true;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoaDon.ColumnHeadersHeight = 36;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 55);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersWidth = 32;
            this.dgvHoaDon.RowTemplate.Height = 30;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1190, 332);
            this.dgvHoaDon.TabIndex = 1;
            this.dgvHoaDon.SelectionChanged += new System.EventHandler(this.dgvHoaDonSelectionChanged);
            this.dgvHoaDon.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataError);
            // 
            // pnlChiTietHDContainer
            // 
            this.pnlChiTietHDContainer.BackColor = System.Drawing.Color.White;
            this.pnlChiTietHDContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChiTietHDContainer.Controls.Add(this.dgvChiTietHoaDon);
            this.pnlChiTietHDContainer.Controls.Add(this.lblTieuDeChiTietHD);
            this.pnlChiTietHDContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChiTietHDContainer.Location = new System.Drawing.Point(3, 387);
            this.pnlChiTietHDContainer.Name = "pnlChiTietHDContainer";
            this.pnlChiTietHDContainer.Size = new System.Drawing.Size(1190, 200);
            this.pnlChiTietHDContainer.TabIndex = 2;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToAddRows = false;
            this.dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietHoaDon.ColumnHeadersHeight = 30;
            this.dgvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(0, 30);
            this.dgvChiTietHoaDon.MultiSelect = false;
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.RowHeadersVisible = false;
            this.dgvChiTietHoaDon.RowTemplate.Height = 28;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(1188, 168);
            this.dgvChiTietHoaDon.TabIndex = 1;
            this.dgvChiTietHoaDon.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataError);
            // 
            // lblTieuDeChiTietHD
            // 
            this.lblTieuDeChiTietHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.lblTieuDeChiTietHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeChiTietHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeChiTietHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTieuDeChiTietHD.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeChiTietHD.Name = "lblTieuDeChiTietHD";
            this.lblTieuDeChiTietHD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTieuDeChiTietHD.Size = new System.Drawing.Size(1188, 30);
            this.lblTieuDeChiTietHD.TabIndex = 0;
            this.lblTieuDeChiTietHD.Text = "CHI TIẾT CÁC MẶT HÀNG TRONG HÓA ĐƠN ĐANG CHỌN";
            this.lblTieuDeChiTietHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlThaoTacHD
            // 
            this.pnlThaoTacHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlThaoTacHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThaoTacHD.Controls.Add(this.btnXuatFileHD);
            this.pnlThaoTacHD.Controls.Add(this.btnInHD);
            this.pnlThaoTacHD.Controls.Add(this.btnHuyHD);
            this.pnlThaoTacHD.Controls.Add(this.btnTaoHD);
            this.pnlThaoTacHD.Controls.Add(this.btnLamMoiHD);
            this.pnlThaoTacHD.Controls.Add(this.btnTimHD);
            this.pnlThaoTacHD.Controls.Add(this.txtTimHD);
            this.pnlThaoTacHD.Controls.Add(this.lblTimHD);
            this.pnlThaoTacHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThaoTacHD.Location = new System.Drawing.Point(3, 3);
            this.pnlThaoTacHD.Name = "pnlThaoTacHD";
            this.pnlThaoTacHD.Size = new System.Drawing.Size(1190, 52);
            this.pnlThaoTacHD.TabIndex = 0;
            // 
            // btnXuatFileHD
            // 
            this.btnXuatFileHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnXuatFileHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFileHD.FlatAppearance.BorderSize = 0;
            this.btnXuatFileHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFileHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFileHD.ForeColor = System.Drawing.Color.White;
            this.btnXuatFileHD.Location = new System.Drawing.Point(490, 11);
            this.btnXuatFileHD.Name = "btnXuatFileHD";
            this.btnXuatFileHD.Size = new System.Drawing.Size(95, 28);
            this.btnXuatFileHD.TabIndex = 7;
            this.btnXuatFileHD.Text = "Xuất File";
            this.btnXuatFileHD.UseVisualStyleBackColor = false;
            this.btnXuatFileHD.Click += new System.EventHandler(this.btnXuatFileHDClick);
            // 
            // btnInHD
            // 
            this.btnInHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnInHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHD.FlatAppearance.BorderSize = 0;
            this.btnInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.ForeColor = System.Drawing.Color.White;
            this.btnInHD.Location = new System.Drawing.Point(920, 9);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(148, 32);
            this.btnInHD.TabIndex = 6;
            this.btnInHD.Text = "In / Xem Phiếu";
            this.btnInHD.UseVisualStyleBackColor = false;
            this.btnInHD.Click += new System.EventHandler(this.btnInHDClick);
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnHuyHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyHD.FlatAppearance.BorderSize = 0;
            this.btnHuyHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyHD.ForeColor = System.Drawing.Color.White;
            this.btnHuyHD.Location = new System.Drawing.Point(1075, 9);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(102, 32);
            this.btnHuyHD.TabIndex = 5;
            this.btnHuyHD.Text = "Hủy Đơn";
            this.btnHuyHD.UseVisualStyleBackColor = false;
            this.btnHuyHD.Click += new System.EventHandler(this.btnHuyHDClick);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnTaoHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoHD.FlatAppearance.BorderSize = 0;
            this.btnTaoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.ForeColor = System.Drawing.Color.White;
            this.btnTaoHD.Location = new System.Drawing.Point(765, 9);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(148, 32);
            this.btnTaoHD.TabIndex = 4;
            this.btnTaoHD.Text = "Lập Đơn Hàng";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHDClick);
            // 
            // btnLamMoiHD
            // 
            this.btnLamMoiHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnLamMoiHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiHD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnLamMoiHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiHD.Location = new System.Drawing.Point(395, 11);
            this.btnLamMoiHD.Name = "btnLamMoiHD";
            this.btnLamMoiHD.Size = new System.Drawing.Size(86, 28);
            this.btnLamMoiHD.TabIndex = 3;
            this.btnLamMoiHD.Text = "Làm mới";
            this.btnLamMoiHD.UseVisualStyleBackColor = false;
            this.btnLamMoiHD.Click += new System.EventHandler(this.btnLamMoiHDClick);
            // 
            // btnTimHD
            // 
            this.btnTimHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTimHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimHD.FlatAppearance.BorderSize = 0;
            this.btnTimHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimHD.ForeColor = System.Drawing.Color.White;
            this.btnTimHD.Location = new System.Drawing.Point(320, 11);
            this.btnTimHD.Name = "btnTimHD";
            this.btnTimHD.Size = new System.Drawing.Size(68, 28);
            this.btnTimHD.TabIndex = 2;
            this.btnTimHD.Text = "Tìm";
            this.btnTimHD.UseVisualStyleBackColor = false;
            this.btnTimHD.Click += new System.EventHandler(this.btnTimHDClick);
            // 
            // txtTimHD
            // 
            this.txtTimHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimHD.Location = new System.Drawing.Point(88, 13);
            this.txtTimHD.Name = "txtTimHD";
            this.txtTimHD.Size = new System.Drawing.Size(222, 25);
            this.txtTimHD.TabIndex = 1;
            this.txtTimHD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimHDKeyDown);
            // 
            // lblTimHD
            // 
            this.lblTimHD.AutoSize = true;
            this.lblTimHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimHD.Location = new System.Drawing.Point(14, 17);
            this.lblTimHD.Name = "lblTimHD";
            this.lblTimHD.Size = new System.Drawing.Size(56, 15);
            this.lblTimHD.TabIndex = 0;
            this.lblTimHD.Text = "Từ khóa:";
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.dgvNhanVien);
            this.tabNhanVien.Controls.Add(this.pnlThaoTacNV);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 38);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(1196, 590);
            this.tabNhanVien.TabIndex = 5;
            this.tabNhanVien.Text = "Nhân Viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNhanVien.ColumnHeadersHeight = 36;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 55);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 32;
            this.dgvNhanVien.RowTemplate.Height = 30;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1190, 532);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVienCellValueChanged);
            this.dgvNhanVien.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataError);
            // 
            // pnlThaoTacNV
            // 
            this.pnlThaoTacNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlThaoTacNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThaoTacNV.Controls.Add(this.btnXoaNV);
            this.pnlThaoTacNV.Controls.Add(this.btnLuuNV);
            this.pnlThaoTacNV.Controls.Add(this.btnThemNV);
            this.pnlThaoTacNV.Controls.Add(this.btnLamMoiNV);
            this.pnlThaoTacNV.Controls.Add(this.btnTimNV);
            this.pnlThaoTacNV.Controls.Add(this.txtTimNV);
            this.pnlThaoTacNV.Controls.Add(this.lblTimNV);
            this.pnlThaoTacNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThaoTacNV.Location = new System.Drawing.Point(3, 3);
            this.pnlThaoTacNV.Name = "pnlThaoTacNV";
            this.pnlThaoTacNV.Size = new System.Drawing.Size(1190, 52);
            this.pnlThaoTacNV.TabIndex = 0;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.FlatAppearance.BorderSize = 0;
            this.btnXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV.Location = new System.Drawing.Point(1088, 9);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(90, 32);
            this.btnXoaNV.TabIndex = 6;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNVClick);
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnLuuNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuNV.Enabled = false;
            this.btnLuuNV.FlatAppearance.BorderSize = 0;
            this.btnLuuNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNV.ForeColor = System.Drawing.Color.White;
            this.btnLuuNV.Location = new System.Drawing.Point(990, 9);
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.Size = new System.Drawing.Size(92, 32);
            this.btnLuuNV.TabIndex = 5;
            this.btnLuuNV.Text = "Lưu";
            this.btnLuuNV.UseVisualStyleBackColor = false;
            this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNVClick);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(875, 9);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(108, 32);
            this.btnThemNV.TabIndex = 4;
            this.btnThemNV.Text = "Thêm mới";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNVClick);
            // 
            // btnLamMoiNV
            // 
            this.btnLamMoiNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnLamMoiNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnLamMoiNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiNV.Location = new System.Drawing.Point(395, 11);
            this.btnLamMoiNV.Name = "btnLamMoiNV";
            this.btnLamMoiNV.Size = new System.Drawing.Size(86, 28);
            this.btnLamMoiNV.TabIndex = 3;
            this.btnLamMoiNV.Text = "Làm mới";
            this.btnLamMoiNV.UseVisualStyleBackColor = false;
            this.btnLamMoiNV.Click += new System.EventHandler(this.btnLamMoiNVClick);
            // 
            // btnTimNV
            // 
            this.btnTimNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTimNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimNV.FlatAppearance.BorderSize = 0;
            this.btnTimNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNV.ForeColor = System.Drawing.Color.White;
            this.btnTimNV.Location = new System.Drawing.Point(320, 11);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(68, 28);
            this.btnTimNV.TabIndex = 2;
            this.btnTimNV.Text = "Tìm";
            this.btnTimNV.UseVisualStyleBackColor = false;
            this.btnTimNV.Click += new System.EventHandler(this.btnTimNVClick);
            // 
            // txtTimNV
            // 
            this.txtTimNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNV.Location = new System.Drawing.Point(88, 13);
            this.txtTimNV.Name = "txtTimNV";
            this.txtTimNV.Size = new System.Drawing.Size(222, 25);
            this.txtTimNV.TabIndex = 1;
            this.txtTimNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimNVKeyDown);
            // 
            // lblTimNV
            // 
            this.lblTimNV.AutoSize = true;
            this.lblTimNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimNV.Location = new System.Drawing.Point(14, 17);
            this.lblTimNV.Name = "lblTimNV";
            this.lblTimNV.Size = new System.Drawing.Size(56, 15);
            this.lblTimNV.TabIndex = 0;
            this.lblTimNV.Text = "Từ khóa:";
            // 
            // tabThongKe
            // 
            this.tabThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabThongKe.Controls.Add(this.pnlThongKeContainer);
            this.tabThongKe.Controls.Add(this.pnlThaoTacTK);
            this.tabThongKe.Location = new System.Drawing.Point(4, 38);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(6);
            this.tabThongKe.Size = new System.Drawing.Size(1196, 590);
            this.tabThongKe.TabIndex = 6;
            this.tabThongKe.Text = "Báo Cáo & Biểu Đồ";
            // 
            // pnlThaoTacTK
            // 
            this.pnlThaoTacTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlThaoTacTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThaoTacTK.Controls.Add(this.lblKyBaoCao);
            this.pnlThaoTacTK.Controls.Add(this.cboKyBaoCao);
            this.pnlThaoTacTK.Controls.Add(this.lblCheDoBieuDo);
            this.pnlThaoTacTK.Controls.Add(this.cboCheDoBieuDo);
            this.pnlThaoTacTK.Controls.Add(this.btnBaoCaoDoanhThu);
            this.pnlThaoTacTK.Controls.Add(this.btnBaoCaoTonKho);
            this.pnlThaoTacTK.Controls.Add(this.btnNapDuLieuGoc);
            this.pnlThaoTacTK.Controls.Add(this.btnLamMoiTK);
            this.pnlThaoTacTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThaoTacTK.Location = new System.Drawing.Point(6, 6);
            this.pnlThaoTacTK.Name = "pnlThaoTacTK";
            this.pnlThaoTacTK.Size = new System.Drawing.Size(1184, 52);
            this.pnlThaoTacTK.TabIndex = 0;
            // 
            // lblKyBaoCao
            // 
            this.lblKyBaoCao.AutoSize = true;
            this.lblKyBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKyBaoCao.Location = new System.Drawing.Point(8, 17);
            this.lblKyBaoCao.Name = "lblKyBaoCao";
            this.lblKyBaoCao.Size = new System.Drawing.Size(69, 15);
            this.lblKyBaoCao.TabIndex = 0;
            this.lblKyBaoCao.Text = "Kỳ thống kê:";
            // 
            // cboKyBaoCao
            // 
            this.cboKyBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKyBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKyBaoCao.FormattingEnabled = true;
            this.cboKyBaoCao.Items.AddRange(new object[] {
            "Toàn bộ",
            "Hôm nay",
            "7 ngày qua",
            "Tháng này"});
            this.cboKyBaoCao.Location = new System.Drawing.Point(83, 13);
            this.cboKyBaoCao.Name = "cboKyBaoCao";
            this.cboKyBaoCao.Size = new System.Drawing.Size(100, 23);
            this.cboKyBaoCao.TabIndex = 1;
            this.cboKyBaoCao.SelectedIndexChanged += new System.EventHandler(this.cboKyBaoCaoSelectedIndexChanged);
            // 
            // lblCheDoBieuDo
            // 
            this.lblCheDoBieuDo.AutoSize = true;
            this.lblCheDoBieuDo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheDoBieuDo.Location = new System.Drawing.Point(191, 17);
            this.lblCheDoBieuDo.Name = "lblCheDoBieuDo";
            this.lblCheDoBieuDo.Size = new System.Drawing.Size(76, 15);
            this.lblCheDoBieuDo.TabIndex = 2;
            this.lblCheDoBieuDo.Text = "Kiểu biểu đồ:";
            // 
            // cboCheDoBieuDo
            // 
            this.cboCheDoBieuDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCheDoBieuDo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCheDoBieuDo.FormattingEnabled = true;
            this.cboCheDoBieuDo.Items.AddRange(new object[] {
            "Biểu đồ cột: Doanh thu theo phân loại",
            "Biểu đồ cột: Doanh số nhân viên",
            "Biểu đồ tròn: Cơ cấu tồn kho",
            "Biểu đồ tròn: Tỷ trọng doanh thu"});
            this.cboCheDoBieuDo.Location = new System.Drawing.Point(271, 13);
            this.cboCheDoBieuDo.Name = "cboCheDoBieuDo";
            this.cboCheDoBieuDo.Size = new System.Drawing.Size(225, 23);
            this.cboCheDoBieuDo.TabIndex = 3;
            this.cboCheDoBieuDo.SelectedIndexChanged += new System.EventHandler(this.cboCheDoBieuDoSelectedIndexChanged);
            // 
            // btnBaoCaoDoanhThu
            // 
            this.btnBaoCaoDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnBaoCaoDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCaoDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnBaoCaoDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoDoanhThu.Location = new System.Drawing.Point(500, 11);
            this.btnBaoCaoDoanhThu.Name = "btnBaoCaoDoanhThu";
            this.btnBaoCaoDoanhThu.Size = new System.Drawing.Size(145, 28);
            this.btnBaoCaoDoanhThu.TabIndex = 4;
            this.btnBaoCaoDoanhThu.Text = "Xuất Excel Doanh Thu";
            this.btnBaoCaoDoanhThu.UseVisualStyleBackColor = false;
            this.btnBaoCaoDoanhThu.Click += new System.EventHandler(this.btnBaoCaoDoanhThuClick);
            // 
            // btnBaoCaoTonKho
            // 
            this.btnBaoCaoTonKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnBaoCaoTonKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCaoTonKho.FlatAppearance.BorderSize = 0;
            this.btnBaoCaoTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoTonKho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoTonKho.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoTonKho.Location = new System.Drawing.Point(650, 11);
            this.btnBaoCaoTonKho.Name = "btnBaoCaoTonKho";
            this.btnBaoCaoTonKho.Size = new System.Drawing.Size(145, 28);
            this.btnBaoCaoTonKho.TabIndex = 5;
            this.btnBaoCaoTonKho.Text = "Xuất Kiểm Kê Kho";
            this.btnBaoCaoTonKho.UseVisualStyleBackColor = false;
            this.btnBaoCaoTonKho.Click += new System.EventHandler(this.btnBaoCaoTonKhoClick);
            // 
            // btnNapDuLieuGoc
            // 
            this.btnNapDuLieuGoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnNapDuLieuGoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNapDuLieuGoc.FlatAppearance.BorderSize = 0;
            this.btnNapDuLieuGoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNapDuLieuGoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapDuLieuGoc.ForeColor = System.Drawing.Color.White;
            this.btnNapDuLieuGoc.Location = new System.Drawing.Point(800, 11);
            this.btnNapDuLieuGoc.Name = "btnNapDuLieuGoc";
            this.btnNapDuLieuGoc.Size = new System.Drawing.Size(135, 28);
            this.btnNapDuLieuGoc.TabIndex = 6;
            this.btnNapDuLieuGoc.Text = "Nạp Dữ Liệu Mẫu";
            this.btnNapDuLieuGoc.UseVisualStyleBackColor = false;
            this.btnNapDuLieuGoc.Click += new System.EventHandler(this.btnNapDuLieuGocClick);
            // 
            // btnLamMoiTK
            // 
            this.btnLamMoiTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnLamMoiTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiTK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnLamMoiTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiTK.Location = new System.Drawing.Point(940, 11);
            this.btnLamMoiTK.Name = "btnLamMoiTK";
            this.btnLamMoiTK.Size = new System.Drawing.Size(85, 28);
            this.btnLamMoiTK.TabIndex = 7;
            this.btnLamMoiTK.Text = "Làm mới";
            this.btnLamMoiTK.UseVisualStyleBackColor = false;
            this.btnLamMoiTK.Click += new System.EventHandler(this.btnLamMoiTKClick);
            // 
            // pnlThongKeContainer
            // 
            this.pnlThongKeContainer.Controls.Add(this.pnlBangThongKeContainer);
            this.pnlThongKeContainer.Controls.Add(this.pnlBieuDoThongKe);
            this.pnlThongKeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongKeContainer.Location = new System.Drawing.Point(6, 58);
            this.pnlThongKeContainer.Name = "pnlThongKeContainer";
            this.pnlThongKeContainer.Size = new System.Drawing.Size(1184, 526);
            this.pnlThongKeContainer.TabIndex = 1;
            // 
            // pnlBieuDoThongKe
            // 
            this.pnlBieuDoThongKe.BackColor = System.Drawing.Color.White;
            this.pnlBieuDoThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBieuDoThongKe.Location = new System.Drawing.Point(0, 0);
            this.pnlBieuDoThongKe.Name = "pnlBieuDoThongKe";
            this.pnlBieuDoThongKe.Size = new System.Drawing.Size(1184, 340);
            this.pnlBieuDoThongKe.TabIndex = 0;
            this.pnlBieuDoThongKe.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBieuDoThongKePaint);
            // 
            // pnlBangThongKeContainer
            // 
            this.pnlBangThongKeContainer.Controls.Add(this.pnlThongKeSP);
            this.pnlBangThongKeContainer.Controls.Add(this.pnlThongKeNV);
            this.pnlBangThongKeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBangThongKeContainer.Location = new System.Drawing.Point(0, 340);
            this.pnlBangThongKeContainer.Name = "pnlBangThongKeContainer";
            this.pnlBangThongKeContainer.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlBangThongKeContainer.Size = new System.Drawing.Size(1184, 186);
            this.pnlBangThongKeContainer.TabIndex = 1;
            // 
            // pnlThongKeSP
            // 
            this.pnlThongKeSP.BackColor = System.Drawing.Color.White;
            this.pnlThongKeSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThongKeSP.Controls.Add(this.dgvThongKeSP);
            this.pnlThongKeSP.Controls.Add(this.lblTieuDeTKSP);
            this.pnlThongKeSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongKeSP.Location = new System.Drawing.Point(590, 6);
            this.pnlThongKeSP.Name = "pnlThongKeSP";
            this.pnlThongKeSP.Size = new System.Drawing.Size(594, 270);
            this.pnlThongKeSP.TabIndex = 1;
            // 
            // dgvThongKeSP
            // 
            this.dgvThongKeSP.AllowUserToAddRows = false;
            this.dgvThongKeSP.AllowUserToDeleteRows = false;
            this.dgvThongKeSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKeSP.ColumnHeadersHeight = 32;
            this.dgvThongKeSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeSP.Location = new System.Drawing.Point(0, 32);
            this.dgvThongKeSP.MultiSelect = false;
            this.dgvThongKeSP.Name = "dgvThongKeSP";
            this.dgvThongKeSP.ReadOnly = true;
            this.dgvThongKeSP.RowHeadersVisible = false;
            this.dgvThongKeSP.RowTemplate.Height = 28;
            this.dgvThongKeSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeSP.Size = new System.Drawing.Size(592, 236);
            this.dgvThongKeSP.TabIndex = 1;
            this.dgvThongKeSP.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataError);
            // 
            // lblTieuDeTKSP
            // 
            this.lblTieuDeTKSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.lblTieuDeTKSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeTKSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeTKSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblTieuDeTKSP.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeTKSP.Name = "lblTieuDeTKSP";
            this.lblTieuDeTKSP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTieuDeTKSP.Size = new System.Drawing.Size(592, 32);
            this.lblTieuDeTKSP.TabIndex = 0;
            this.lblTieuDeTKSP.Text = "CƠ CẤU HÀNG HÓA VÀ GIÁ TRỊ TỒN KHO THEO LOẠI";
            this.lblTieuDeTKSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlThongKeNV
            // 
            this.pnlThongKeNV.BackColor = System.Drawing.Color.White;
            this.pnlThongKeNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThongKeNV.Controls.Add(this.dgvThongKeNV);
            this.pnlThongKeNV.Controls.Add(this.lblTieuDeTKNV);
            this.pnlThongKeNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlThongKeNV.Location = new System.Drawing.Point(0, 6);
            this.pnlThongKeNV.Name = "pnlThongKeNV";
            this.pnlThongKeNV.Size = new System.Drawing.Size(590, 270);
            this.pnlThongKeNV.TabIndex = 0;
            // 
            // dgvThongKeNV
            // 
            this.dgvThongKeNV.AllowUserToAddRows = false;
            this.dgvThongKeNV.AllowUserToDeleteRows = false;
            this.dgvThongKeNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeNV.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKeNV.ColumnHeadersHeight = 32;
            this.dgvThongKeNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeNV.Location = new System.Drawing.Point(0, 32);
            this.dgvThongKeNV.MultiSelect = false;
            this.dgvThongKeNV.Name = "dgvThongKeNV";
            this.dgvThongKeNV.ReadOnly = true;
            this.dgvThongKeNV.RowHeadersVisible = false;
            this.dgvThongKeNV.RowTemplate.Height = 28;
            this.dgvThongKeNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeNV.Size = new System.Drawing.Size(588, 236);
            this.dgvThongKeNV.TabIndex = 1;
            this.dgvThongKeNV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataError);
            // 
            // lblTieuDeTKNV
            // 
            this.lblTieuDeTKNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblTieuDeTKNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeTKNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeTKNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.lblTieuDeTKNV.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeTKNV.Name = "lblTieuDeTKNV";
            this.lblTieuDeTKNV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTieuDeTKNV.Size = new System.Drawing.Size(588, 32);
            this.lblTieuDeTKNV.TabIndex = 0;
            this.lblTieuDeTKNV.Text = "HIỆU SUẤT BÁN HÀNG THEO NHÂN VIÊN";
            this.lblTieuDeTKNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1204, 721);
            this.Controls.Add(this.tabChinh);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1080, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VietTien Fashion Shop – Hệ Thống Quản Lý Bán Lẻ Thời Trang";
            this.Load += new System.EventHandler(this.Form1Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabChinh.ResumeLayout(false);
            this.tabTongQuan.ResumeLayout(false);
            this.pnlKpiBottom.ResumeLayout(false);
            this.pnlGiaoDichMoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichMoi)).EndInit();
            this.pnlCanhBaoKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanhBaoKho)).EndInit();
            this.pnlKpiActions.ResumeLayout(false);
            this.pnlKpiCards.ResumeLayout(false);
            this.pnlCardHoaDon.ResumeLayout(false);
            this.pnlCardHoaDon.PerformLayout();
            this.pnlCardDoanhThu.ResumeLayout(false);
            this.pnlCardDoanhThu.PerformLayout();
            this.pnlCardKH.ResumeLayout(false);
            this.pnlCardKH.PerformLayout();
            this.pnlCardSP.ResumeLayout(false);
            this.pnlCardSP.PerformLayout();
            this.tabSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.pnlThaoTacSP.ResumeLayout(false);
            this.pnlThaoTacSP.PerformLayout();
            this.tabKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.pnlThaoTacKH.ResumeLayout(false);
            this.pnlThaoTacKH.PerformLayout();
            this.tabNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.pnlThaoTacNCC.ResumeLayout(false);
            this.pnlThaoTacNCC.PerformLayout();
            this.tabHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.pnlChiTietHDContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.pnlThaoTacHD.ResumeLayout(false);
            this.pnlThaoTacHD.PerformLayout();
            this.tabNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.pnlThaoTacNV.ResumeLayout(false);
            this.pnlThaoTacNV.PerformLayout();
            this.tabThongKe.ResumeLayout(false);
            this.pnlThongKeContainer.ResumeLayout(false);
            this.pnlBangThongKeContainer.ResumeLayout(false);
            this.pnlThongKeSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeSP)).EndInit();
            this.pnlThongKeNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeNV)).EndInit();
            this.pnlThaoTacTK.ResumeLayout(false);
            this.pnlThaoTacTK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.Label lblDongHo;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusThongBao;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTongSo;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusPhienBan;
        private System.Windows.Forms.Timer timerDongHo;
        private System.Windows.Forms.TabControl tabChinh;
        private System.Windows.Forms.TabPage tabTongQuan;
        private System.Windows.Forms.Panel pnlKpiCards;
        private System.Windows.Forms.Panel pnlCardSP;
        private System.Windows.Forms.Panel pnlStripeSP;
        private System.Windows.Forms.Label lblKpiSPTieuDe;
        private System.Windows.Forms.Label lblKpiSPSoLuong;
        private System.Windows.Forms.Label lblKpiSPGhiChu;
        private System.Windows.Forms.Panel pnlCardKH;
        private System.Windows.Forms.Panel pnlStripeKH;
        private System.Windows.Forms.Label lblKpiKHTieuDe;
        private System.Windows.Forms.Label lblKpiKHSoLuong;
        private System.Windows.Forms.Label lblKpiKHGhiChu;
        private System.Windows.Forms.Panel pnlCardDoanhThu;
        private System.Windows.Forms.Panel pnlStripeDT;
        private System.Windows.Forms.Label lblKpiDTTieuDe;
        private System.Windows.Forms.Label lblKpiDTSoLuong;
        private System.Windows.Forms.Label lblKpiDTGhiChu;
        private System.Windows.Forms.Panel pnlCardHoaDon;
        private System.Windows.Forms.Panel pnlStripeHD;
        private System.Windows.Forms.Label lblKpiHDTieuDe;
        private System.Windows.Forms.Label lblKpiHDSoLuong;
        private System.Windows.Forms.Label lblKpiHDGhiChu;
        private System.Windows.Forms.Panel pnlKpiActions;
        private System.Windows.Forms.Button btnQuickBanHang;
        private System.Windows.Forms.Button btnQuickThemSP;
        private System.Windows.Forms.Button btnQuickKhachHang;
        private System.Windows.Forms.Button btnQuickLamMoiKPI;
        private System.Windows.Forms.Panel pnlKpiBottom;
        private System.Windows.Forms.Panel pnlCanhBaoKho;
        private System.Windows.Forms.Label lblTieuDeCanhBao;
        private System.Windows.Forms.DataGridView dgvCanhBaoKho;
        private System.Windows.Forms.Panel pnlGiaoDichMoi;
        private System.Windows.Forms.Label lblTieuDeGiaoDich;
        private System.Windows.Forms.DataGridView dgvGiaoDichMoi;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.Panel pnlThaoTacSP;
        private System.Windows.Forms.ComboBox cboLocLoaiSP;
        private System.Windows.Forms.Label lblLocLoaiSP;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.Label lblTimSP;
        private System.Windows.Forms.Button btnLamMoiSP;
        private System.Windows.Forms.Button btnXuatFileSP;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Button btnLocHangTonThap;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnLuuSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.Panel pnlThaoTacKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Label lblTimKH;
        private System.Windows.Forms.Button btnLamMoiKH;
        private System.Windows.Forms.Button btnXuatFileKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TabPage tabNhaCungCap;
        private System.Windows.Forms.Panel pnlThaoTacNCC;
        private System.Windows.Forms.Button btnTimNCC;
        private System.Windows.Forms.TextBox txtTimNCC;
        private System.Windows.Forms.Label lblTimNCC;
        private System.Windows.Forms.Button btnLamMoiNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Button btnLuuNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private System.Windows.Forms.TabPage tabHoaDon;
        private System.Windows.Forms.Panel pnlThaoTacHD;
        private System.Windows.Forms.Button btnTimHD;
        private System.Windows.Forms.TextBox txtTimHD;
        private System.Windows.Forms.Label lblTimHD;
        private System.Windows.Forms.Button btnLamMoiHD;
        private System.Windows.Forms.Button btnXuatFileHD;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel pnlChiTietHDContainer;
        private System.Windows.Forms.Label lblTieuDeChiTietHD;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.Panel pnlThaoTacNV;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.TextBox txtTimNV;
        private System.Windows.Forms.Label lblTimNV;
        private System.Windows.Forms.Button btnLamMoiNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnLuuNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.Panel pnlThaoTacTK;
        private System.Windows.Forms.Label lblKyBaoCao;
        private System.Windows.Forms.ComboBox cboKyBaoCao;
        private System.Windows.Forms.Label lblCheDoBieuDo;
        private System.Windows.Forms.ComboBox cboCheDoBieuDo;
        private System.Windows.Forms.Button btnBaoCaoDoanhThu;
        private System.Windows.Forms.Button btnBaoCaoTonKho;
        private System.Windows.Forms.Button btnNapDuLieuGoc;
        private System.Windows.Forms.Button btnLamMoiTK;
        private System.Windows.Forms.Panel pnlThongKeContainer;
        private System.Windows.Forms.Panel pnlBieuDoThongKe;
        private System.Windows.Forms.Panel pnlBangThongKeContainer;
        private System.Windows.Forms.Panel pnlThongKeNV;
        private System.Windows.Forms.Label lblTieuDeTKNV;
        private System.Windows.Forms.DataGridView dgvThongKeNV;
        private System.Windows.Forms.Panel pnlThongKeSP;
        private System.Windows.Forms.Label lblTieuDeTKSP;
        private System.Windows.Forms.DataGridView dgvThongKeSP;
    }
}
