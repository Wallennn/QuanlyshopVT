namespace QuanlyshopVT
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Biến quản lý các thành phần điều khiển của Designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Giải phóng các tài nguyên đồ họa khi đóng form.
        /// </summary>
        /// <param name="disposing">true nếu giải phóng tài nguyên quản lý; ngược lại false.</param>
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
        /// Cho phép lập trình viên kéo thả và chỉnh sửa trực quan dễ dàng.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlChinh = new System.Windows.Forms.Panel();
            this.lblBanQuyen = new System.Windows.Forms.Label();
            this.btnDemoThuKho = new System.Windows.Forms.Button();
            this.btnDemoNhanVien = new System.Windows.Forms.Button();
            this.btnDemoAdmin = new System.Windows.Forms.Button();
            this.lblGoiY = new System.Windows.Forms.Label();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlLogoBanner = new System.Windows.Forms.Panel();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlChinh.SuspendLayout();
            this.pnlLogoBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChinh
            // 
            this.pnlChinh.BackColor = System.Drawing.Color.White;
            this.pnlChinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChinh.Controls.Add(this.lblBanQuyen);
            this.pnlChinh.Controls.Add(this.btnDemoThuKho);
            this.pnlChinh.Controls.Add(this.btnDemoNhanVien);
            this.pnlChinh.Controls.Add(this.btnDemoAdmin);
            this.pnlChinh.Controls.Add(this.lblGoiY);
            this.pnlChinh.Controls.Add(this.chkHienMatKhau);
            this.pnlChinh.Controls.Add(this.lblThongBao);
            this.pnlChinh.Controls.Add(this.btnThoat);
            this.pnlChinh.Controls.Add(this.btnDangNhap);
            this.pnlChinh.Controls.Add(this.txtMatKhau);
            this.pnlChinh.Controls.Add(this.lblMatKhau);
            this.pnlChinh.Controls.Add(this.txtTenDangNhap);
            this.pnlChinh.Controls.Add(this.lblTenDangNhap);
            this.pnlChinh.Controls.Add(this.lblFormTitle);
            this.pnlChinh.Controls.Add(this.pnlLogoBanner);
            this.pnlChinh.Location = new System.Drawing.Point(30, 25);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(430, 485);
            this.pnlChinh.TabIndex = 0;
            // 
            // lblBanQuyen
            // 
            this.lblBanQuyen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBanQuyen.Location = new System.Drawing.Point(20, 450);
            this.lblBanQuyen.Name = "lblBanQuyen";
            this.lblBanQuyen.Size = new System.Drawing.Size(390, 22);
            this.lblBanQuyen.TabIndex = 14;
            this.lblBanQuyen.Text = "Bản quyền © 2026 Tổng Công Ty CP May Việt Tiến";
            this.lblBanQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDemoThuKho
            // 
            this.btnDemoThuKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnDemoThuKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDemoThuKho.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnDemoThuKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemoThuKho.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemoThuKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnDemoThuKho.Location = new System.Drawing.Point(286, 298);
            this.btnDemoThuKho.Name = "btnDemoThuKho";
            this.btnDemoThuKho.Size = new System.Drawing.Size(104, 26);
            this.btnDemoThuKho.TabIndex = 13;
            this.btnDemoThuKho.Text = "Thủ kho";
            this.btnDemoThuKho.UseVisualStyleBackColor = false;
            this.btnDemoThuKho.Click += new System.EventHandler(this.btnDemoThuKhoClick);
            // 
            // btnDemoNhanVien
            // 
            this.btnDemoNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnDemoNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDemoNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnDemoNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemoNhanVien.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemoNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnDemoNhanVien.Location = new System.Drawing.Point(163, 298);
            this.btnDemoNhanVien.Name = "btnDemoNhanVien";
            this.btnDemoNhanVien.Size = new System.Drawing.Size(117, 26);
            this.btnDemoNhanVien.TabIndex = 12;
            this.btnDemoNhanVien.Text = "Bán hàng";
            this.btnDemoNhanVien.UseVisualStyleBackColor = false;
            this.btnDemoNhanVien.Click += new System.EventHandler(this.btnDemoNhanVienClick);
            // 
            // btnDemoAdmin
            // 
            this.btnDemoAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnDemoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDemoAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnDemoAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemoAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemoAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnDemoAdmin.Location = new System.Drawing.Point(40, 298);
            this.btnDemoAdmin.Name = "btnDemoAdmin";
            this.btnDemoAdmin.Size = new System.Drawing.Size(117, 26);
            this.btnDemoAdmin.TabIndex = 11;
            this.btnDemoAdmin.Text = "Quản lý";
            this.btnDemoAdmin.UseVisualStyleBackColor = false;
            this.btnDemoAdmin.Click += new System.EventHandler(this.btnDemoAdminClick);
            // 
            // lblGoiY
            // 
            this.lblGoiY.AutoSize = true;
            this.lblGoiY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoiY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblGoiY.Location = new System.Drawing.Point(37, 278);
            this.lblGoiY.Name = "lblGoiY";
            this.lblGoiY.Size = new System.Drawing.Size(155, 13);
            this.lblGoiY.TabIndex = 10;
            this.lblGoiY.Text = "Chọn nhanh tài khoản mẫu thử:";
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.chkHienMatKhau.Location = new System.Drawing.Point(40, 252);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(104, 19);
            this.chkHienMatKhau.TabIndex = 9;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhauCheckedChanged);
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Crimson;
            this.lblThongBao.Location = new System.Drawing.Point(20, 332);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(390, 32);
            this.lblThongBao.TabIndex = 8;
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(270, 372);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 42);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoatClick);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(40, 372);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(220, 42);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhapClick);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(40, 218);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(350, 27);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhauKeyDown);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMatKhau.Location = new System.Drawing.Point(37, 196);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(70, 17);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(40, 158);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(350, 27);
            this.txtTenDangNhap.TabIndex = 3;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTenDangNhap.Location = new System.Drawing.Point(37, 136);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(104, 17);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblFormTitle.Location = new System.Drawing.Point(20, 95);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(390, 28);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogoBanner
            // 
            this.pnlLogoBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlLogoBanner.Controls.Add(this.lblPhuDe);
            this.pnlLogoBanner.Controls.Add(this.lblTieuDe);
            this.pnlLogoBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoBanner.Name = "pnlLogoBanner";
            this.pnlLogoBanner.Size = new System.Drawing.Size(428, 80);
            this.pnlLogoBanner.TabIndex = 0;
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblPhuDe.Location = new System.Drawing.Point(10, 45);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(408, 20);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "Hệ Thống Bán Lẻ Thời Trang Công Sở Cao Cấp";
            this.lblPhuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(10, 12);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(408, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "VIETTIEN FASHION";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(490, 535);
            this.Controls.Add(this.pnlChinh);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập – VietTien Fashion Shop";
            this.pnlChinh.ResumeLayout(false);
            this.pnlChinh.PerformLayout();
            this.pnlLogoBanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChinh;
        private System.Windows.Forms.Panel pnlLogoBanner;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Label lblGoiY;
        private System.Windows.Forms.Button btnDemoAdmin;
        private System.Windows.Forms.Button btnDemoNhanVien;
        private System.Windows.Forms.Button btnDemoThuKho;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblBanQuyen;
    }
}
