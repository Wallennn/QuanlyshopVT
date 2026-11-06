namespace QuanlyshopVT
{
    partial class FormInHoaDon
    {
        /// <summary>
        /// Biến quản lý các điều khiển của Designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Giải phóng các tài nguyên khi đóng cửa sổ phiếu in.
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
        /// Cho phép lập trình viên chỉnh sửa thủ công trực tiếp trên Visual Studio Designer.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlKhungPhieu = new System.Windows.Forms.Panel();
            this.lblLoiCamOn = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblTongCongTien = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblThuNgan = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.lblPhieuThanhToan = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenCuaHang = new System.Windows.Forms.Label();
            this.lblTieuDeCongTy = new System.Windows.Forms.Label();
            this.pnlThaoTac = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.pnlKhungPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.pnlThaoTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKhungPhieu
            // 
            this.pnlKhungPhieu.BackColor = System.Drawing.Color.White;
            this.pnlKhungPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKhungPhieu.Controls.Add(this.lblLoiCamOn);
            this.pnlKhungPhieu.Controls.Add(this.lblThanhTien);
            this.pnlKhungPhieu.Controls.Add(this.lblGiamGia);
            this.pnlKhungPhieu.Controls.Add(this.lblTongCongTien);
            this.pnlKhungPhieu.Controls.Add(this.dgvChiTiet);
            this.pnlKhungPhieu.Controls.Add(this.lblKhachHang);
            this.pnlKhungPhieu.Controls.Add(this.lblThuNgan);
            this.pnlKhungPhieu.Controls.Add(this.lblNgayLap);
            this.pnlKhungPhieu.Controls.Add(this.lblSoHoaDon);
            this.pnlKhungPhieu.Controls.Add(this.lblPhieuThanhToan);
            this.pnlKhungPhieu.Controls.Add(this.lblDienThoai);
            this.pnlKhungPhieu.Controls.Add(this.lblDiaChi);
            this.pnlKhungPhieu.Controls.Add(this.lblTenCuaHang);
            this.pnlKhungPhieu.Controls.Add(this.lblTieuDeCongTy);
            this.pnlKhungPhieu.Location = new System.Drawing.Point(20, 15);
            this.pnlKhungPhieu.Name = "pnlKhungPhieu";
            this.pnlKhungPhieu.Size = new System.Drawing.Size(460, 520);
            this.pnlKhungPhieu.TabIndex = 0;
            // 
            // lblLoiCamOn
            // 
            this.lblLoiCamOn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiCamOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLoiCamOn.Location = new System.Drawing.Point(15, 480);
            this.lblLoiCamOn.Name = "lblLoiCamOn";
            this.lblLoiCamOn.Size = new System.Drawing.Size(430, 25);
            this.lblLoiCamOn.TabIndex = 13;
            this.lblLoiCamOn.Text = "Cảm ơn Quý Khách đã tin chọn Thời Trang Việt Tiến!";
            this.lblLoiCamOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblThanhTien.Location = new System.Drawing.Point(15, 445);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(430, 24);
            this.lblThanhTien.TabIndex = 12;
            this.lblThanhTien.Text = "TỔNG THANH TOÁN: 800.000 đ";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamGia.Location = new System.Drawing.Point(15, 423);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(430, 20);
            this.lblGiamGia.TabIndex = 11;
            this.lblGiamGia.Text = "Chiết khấu / Giảm giá: 0 đ";
            this.lblGiamGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongCongTien
            // 
            this.lblTongCongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongCongTien.Location = new System.Drawing.Point(15, 401);
            this.lblTongCongTien.Name = "lblTongCongTien";
            this.lblTongCongTien.Size = new System.Drawing.Size(430, 20);
            this.lblTongCongTien.TabIndex = 10;
            this.lblTongCongTien.Text = "Tổng tiền hàng: 800.000 đ";
            this.lblTongCongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.ColumnHeadersHeight = 28;
            this.dgvChiTiet.Location = new System.Drawing.Point(15, 230);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowTemplate.Height = 26;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(430, 160);
            this.dgvChiTiet.TabIndex = 9;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(15, 198);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(155, 15);
            this.lblKhachHang.TabIndex = 8;
            this.lblKhachHang.Text = "Khách hàng: Nguyễn Văn Hùng";
            // 
            // lblThuNgan
            // 
            this.lblThuNgan.AutoSize = true;
            this.lblThuNgan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuNgan.Location = new System.Drawing.Point(15, 175);
            this.lblThuNgan.Name = "lblThuNgan";
            this.lblThuNgan.Size = new System.Drawing.Size(147, 15);
            this.lblThuNgan.TabIndex = 7;
            this.lblThuNgan.Text = "Thu ngân: Phạm Thái Lan";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(15, 152);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(146, 15);
            this.lblNgayLap.TabIndex = 6;
            this.lblNgayLap.Text = "Ngày lập: 03/11/2026 09:30";
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHoaDon.Location = new System.Drawing.Point(15, 130);
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.Size = new System.Drawing.Size(155, 15);
            this.lblSoHoaDon.TabIndex = 5;
            this.lblSoHoaDon.Text = "Số HĐ: HD20261028001";
            // 
            // lblPhieuThanhToan
            // 
            this.lblPhieuThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPhieuThanhToan.Location = new System.Drawing.Point(10, 95);
            this.lblPhieuThanhToan.Name = "lblPhieuThanhToan";
            this.lblPhieuThanhToan.Size = new System.Drawing.Size(438, 26);
            this.lblPhieuThanhToan.TabIndex = 4;
            this.lblPhieuThanhToan.Text = "PHIẾU THANH TOÁN BÁN LẺ";
            this.lblPhieuThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDienThoai.Location = new System.Drawing.Point(10, 68);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(438, 18);
            this.lblDienThoai.TabIndex = 3;
            this.lblDienThoai.Text = "Hotline: 1800 6868 – Website: www.viettien.com.vn";
            this.lblDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDiaChi.Location = new System.Drawing.Point(10, 48);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(438, 18);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "7 Lê Minh Xuân, P.7, Q.Tân Bình, TP.Hồ Chí Minh";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenCuaHang
            // 
            this.lblTenCuaHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCuaHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTenCuaHang.Location = new System.Drawing.Point(10, 26);
            this.lblTenCuaHang.Name = "lblTenCuaHang";
            this.lblTenCuaHang.Size = new System.Drawing.Size(438, 20);
            this.lblTenCuaHang.TabIndex = 1;
            this.lblTenCuaHang.Text = "SHOWROOM THỜI TRANG CÔNG SỞ CAO CẤP";
            this.lblTenCuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTieuDeCongTy
            // 
            this.lblTieuDeCongTy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeCongTy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTieuDeCongTy.Location = new System.Drawing.Point(10, 5);
            this.lblTieuDeCongTy.Name = "lblTieuDeCongTy";
            this.lblTieuDeCongTy.Size = new System.Drawing.Size(438, 20);
            this.lblTieuDeCongTy.TabIndex = 0;
            this.lblTieuDeCongTy.Text = "TỔNG CÔNG TY CỔ PHẦN MAY VIỆT TIẾN";
            this.lblTieuDeCongTy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlThaoTac
            // 
            this.pnlThaoTac.Controls.Add(this.btnDong);
            this.pnlThaoTac.Controls.Add(this.btnInPhieu);
            this.pnlThaoTac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThaoTac.Location = new System.Drawing.Point(0, 545);
            this.pnlThaoTac.Name = "pnlThaoTac";
            this.pnlThaoTac.Size = new System.Drawing.Size(500, 50);
            this.pnlThaoTac.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(260, 7);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 36);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDongClick);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnInPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInPhieu.FlatAppearance.BorderSize = 0;
            this.btnInPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.ForeColor = System.Drawing.Color.White;
            this.btnInPhieu.Location = new System.Drawing.Point(120, 7);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(130, 36);
            this.btnInPhieu.TabIndex = 0;
            this.btnInPhieu.Text = "In Phiếu Thu";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieuClick);
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(500, 595);
            this.Controls.Add(this.pnlThaoTac);
            this.Controls.Add(this.pnlKhungPhieu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu In Hóa Đơn Bán Lẻ – VietTien Fashion";
            this.pnlKhungPhieu.ResumeLayout(false);
            this.pnlKhungPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.pnlThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKhungPhieu;
        private System.Windows.Forms.Label lblTieuDeCongTy;
        private System.Windows.Forms.Label lblTenCuaHang;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblPhieuThanhToan;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblThuNgan;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label lblTongCongTien;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblLoiCamOn;
        private System.Windows.Forms.Panel pnlThaoTac;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnDong;
    }
}

