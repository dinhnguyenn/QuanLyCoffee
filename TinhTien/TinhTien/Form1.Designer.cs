namespace TinhTien
{
    partial class frmTinhTien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTinhTien = new System.Windows.Forms.DataGridView();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblPhuThu = new System.Windows.Forms.Label();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.cbxTenKH = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.SanPham = new System.Windows.Forms.GroupBox();
            this.nmrSL = new System.Windows.Forms.NumericUpDown();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxTenSP = new System.Windows.Forms.ComboBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTienPhuThu = new System.Windows.Forms.TextBox();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTienPhuThu = new System.Windows.Forms.Label();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this._stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxPhuThu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTien)).BeginInit();
            this.SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH TIỀN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTinhTien
            // 
            this.dgvTinhTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._stt,
            this._masp,
            this._tensp,
            this._soluong,
            this._dongia});
            this.dgvTinhTien.Location = new System.Drawing.Point(377, 54);
            this.dgvTinhTien.Name = "dgvTinhTien";
            this.dgvTinhTien.Size = new System.Drawing.Size(531, 172);
            this.dgvTinhTien.TabIndex = 1;
            this.dgvTinhTien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTinhTien_CellClick);
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(12, 57);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(71, 13);
            this.lblMaHD.TabIndex = 2;
            this.lblMaHD.Text = "Mã Hóa Đơn:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(12, 89);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(56, 13);
            this.lblNgayLap.TabIndex = 3;
            this.lblNgayLap.Text = "Ngày Lập:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(12, 119);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(82, 13);
            this.lblNhanVien.TabIndex = 3;
            this.lblNhanVien.Text = "Tên Nhân Viên:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(12, 151);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(92, 13);
            this.lblMaKH.TabIndex = 3;
            this.lblMaKH.Text = "Tên Khách Hàng:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(12, 179);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(88, 13);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Mã Khách Hàng:";
            // 
            // lblPhuThu
            // 
            this.lblPhuThu.AutoSize = true;
            this.lblPhuThu.Location = new System.Drawing.Point(525, 309);
            this.lblPhuThu.Name = "lblPhuThu";
            this.lblPhuThu.Size = new System.Drawing.Size(51, 13);
            this.lblPhuThu.TabIndex = 3;
            this.lblPhuThu.Text = "Phụ Thu:";
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(139, 116);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(182, 21);
            this.cbxNhanVien.TabIndex = 4;
            // 
            // cbxTenKH
            // 
            this.cbxTenKH.FormattingEnabled = true;
            this.cbxTenKH.Location = new System.Drawing.Point(139, 148);
            this.cbxTenKH.Name = "cbxTenKH";
            this.cbxTenKH.Size = new System.Drawing.Size(182, 21);
            this.cbxTenKH.TabIndex = 4;
            this.cbxTenKH.SelectedIndexChanged += new System.EventHandler(this.cbxTenKH_SelectedIndexChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(139, 54);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(182, 20);
            this.txtMaHD.TabIndex = 5;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(139, 176);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(182, 20);
            this.txtMaKH.TabIndex = 5;
            // 
            // SanPham
            // 
            this.SanPham.Controls.Add(this.nmrSL);
            this.SanPham.Controls.Add(this.txtMaSP);
            this.SanPham.Controls.Add(this.btnSua);
            this.SanPham.Controls.Add(this.btnRemove);
            this.SanPham.Controls.Add(this.btnAdd);
            this.SanPham.Controls.Add(this.cbxTenSP);
            this.SanPham.Controls.Add(this.lblSL);
            this.SanPham.Controls.Add(this.lblTenSP);
            this.SanPham.Controls.Add(this.lblMaSP);
            this.SanPham.Location = new System.Drawing.Point(15, 250);
            this.SanPham.Name = "SanPham";
            this.SanPham.Size = new System.Drawing.Size(483, 153);
            this.SanPham.TabIndex = 6;
            this.SanPham.TabStop = false;
            this.SanPham.Text = "Sản Phẩm";
            // 
            // nmrSL
            // 
            this.nmrSL.Location = new System.Drawing.Point(124, 107);
            this.nmrSL.Name = "nmrSL";
            this.nmrSL.Size = new System.Drawing.Size(182, 20);
            this.nmrSL.TabIndex = 4;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(124, 65);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(182, 20);
            this.txtMaSP.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(362, 63);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(362, 102);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(362, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxTenSP
            // 
            this.cbxTenSP.FormattingEnabled = true;
            this.cbxTenSP.Location = new System.Drawing.Point(124, 27);
            this.cbxTenSP.Name = "cbxTenSP";
            this.cbxTenSP.Size = new System.Drawing.Size(182, 21);
            this.cbxTenSP.TabIndex = 1;
            this.cbxTenSP.SelectedIndexChanged += new System.EventHandler(this.cbxTenSP_SelectedIndexChanged);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(33, 107);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(56, 13);
            this.lblSL.TabIndex = 0;
            this.lblSL.Text = "Số Lượng:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(33, 68);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(77, 13);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Mã Sản Phẩm:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(33, 27);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(81, 13);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Tên Sản Phẩm:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(139, 83);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(182, 20);
            this.dtpNgayLap.TabIndex = 7;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(806, 249);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(102, 74);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "Tính Tiền";
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(806, 357);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(102, 38);
            this.btnMoi.TabIndex = 8;
            this.btnMoi.Text = "Làm Mới (không cần)";
            this.btnMoi.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(616, 246);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(164, 41);
            this.txtTongTien.TabIndex = 9;
            // 
            // txtTienPhuThu
            // 
            this.txtTienPhuThu.Location = new System.Drawing.Point(616, 346);
            this.txtTienPhuThu.Name = "txtTienPhuThu";
            this.txtTienPhuThu.Size = new System.Drawing.Size(164, 20);
            this.txtTienPhuThu.TabIndex = 9;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(616, 379);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(164, 20);
            this.txtThanhToan.TabIndex = 9;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(521, 268);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(59, 13);
            this.lblTongTien.TabIndex = 10;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblTienPhuThu
            // 
            this.lblTienPhuThu.AutoSize = true;
            this.lblTienPhuThu.Location = new System.Drawing.Point(521, 353);
            this.lblTienPhuThu.Name = "lblTienPhuThu";
            this.lblTienPhuThu.Size = new System.Drawing.Size(91, 13);
            this.lblTienPhuThu.TabIndex = 10;
            this.lblTienPhuThu.Text = "Số Tiền Phụ Thu:";
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Location = new System.Drawing.Point(521, 386);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(69, 13);
            this.lblThanhToan.TabIndex = 10;
            this.lblThanhToan.Text = "Thanh Toán:";
            // 
            // _stt
            // 
            this._stt.HeaderText = "STT";
            this._stt.Name = "_stt";
            this._stt.ReadOnly = true;
            // 
            // _masp
            // 
            this._masp.HeaderText = "Mã Sản Phẩm";
            this._masp.Name = "_masp";
            this._masp.ReadOnly = true;
            // 
            // _tensp
            // 
            this._tensp.HeaderText = "Tên Sản Phẩm";
            this._tensp.Name = "_tensp";
            this._tensp.ReadOnly = true;
            // 
            // _soluong
            // 
            this._soluong.HeaderText = "Số Lượng";
            this._soluong.Name = "_soluong";
            this._soluong.ReadOnly = true;
            // 
            // _dongia
            // 
            this._dongia.HeaderText = "Đơn Giá";
            this._dongia.Name = "_dongia";
            this._dongia.ReadOnly = true;
            // 
            // cbxPhuThu
            // 
            this.cbxPhuThu.FormattingEnabled = true;
            this.cbxPhuThu.Items.AddRange(new object[] {
            "Buổi Tối",
            "Ngày Lễ"});
            this.cbxPhuThu.Location = new System.Drawing.Point(616, 302);
            this.cbxPhuThu.Name = "cbxPhuThu";
            this.cbxPhuThu.Size = new System.Drawing.Size(164, 21);
            this.cbxPhuThu.TabIndex = 11;
            // 
            // frmTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 444);
            this.Controls.Add(this.cbxPhuThu);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.lblTienPhuThu);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.txtTienPhuThu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.SanPham);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.cbxTenKH);
            this.Controls.Add(this.cbxNhanVien);
            this.Controls.Add(this.lblPhuThu);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.dgvTinhTien);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmTinhTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÍNH TIỀN";
            this.Load += new System.EventHandler(this.frmTinhTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTien)).EndInit();
            this.SanPham.ResumeLayout(false);
            this.SanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTinhTien;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblPhuThu;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.ComboBox cbxTenKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.GroupBox SanPham;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxTenSP;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.NumericUpDown nmrSL;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTienPhuThu;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTienPhuThu;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn _stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn _masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn _soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dongia;
        private System.Windows.Forms.ComboBox cbxPhuThu;
    }
}

