namespace crud
{
    partial class Form1
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
            this.gb_ThongTin = new System.Windows.Forms.GroupBox();
            this.dtgvThongTin = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.TxbTienLuong = new System.Windows.Forms.TextBox();
            this.txbChucVu = new System.Windows.Forms.TextBox();
            this.txTenNV = new System.Windows.Forms.TextBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.gb_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ThongTin
            // 
            this.gb_ThongTin.Controls.Add(this.dtgvThongTin);
            this.gb_ThongTin.Location = new System.Drawing.Point(12, 12);
            this.gb_ThongTin.Name = "gb_ThongTin";
            this.gb_ThongTin.Size = new System.Drawing.Size(821, 245);
            this.gb_ThongTin.TabIndex = 0;
            this.gb_ThongTin.TabStop = false;
            this.gb_ThongTin.Text = "Thông tin";
            // 
            // dtgvThongTin
            // 
            this.dtgvThongTin.AllowUserToAddRows = false;
            this.dtgvThongTin.AllowUserToDeleteRows = false;
            this.dtgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongTin.Location = new System.Drawing.Point(6, 21);
            this.dtgvThongTin.Name = "dtgvThongTin";
            this.dtgvThongTin.ReadOnly = true;
            this.dtgvThongTin.RowHeadersWidth = 51;
            this.dtgvThongTin.RowTemplate.Height = 24;
            this.dtgvThongTin.Size = new System.Drawing.Size(815, 224);
            this.dtgvThongTin.TabIndex = 0;
            this.dtgvThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThongTin_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.dtPNgaySinh);
            this.groupBox1.Controls.Add(this.TxbTienLuong);
            this.groupBox1.Controls.Add(this.txbChucVu);
            this.groupBox1.Controls.Add(this.txTenNV);
            this.groupBox1.Controls.Add(this.txbMaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tiền lương:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chức vụ:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(108, 119);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(218, 24);
            this.cbGioiTinh.TabIndex = 3;
            // 
            // dtPNgaySinh
            // 
            this.dtPNgaySinh.Location = new System.Drawing.Point(461, 32);
            this.dtPNgaySinh.Name = "dtPNgaySinh";
            this.dtPNgaySinh.Size = new System.Drawing.Size(228, 22);
            this.dtPNgaySinh.TabIndex = 4;
            // 
            // TxbTienLuong
            // 
            this.TxbTienLuong.Location = new System.Drawing.Point(461, 122);
            this.TxbTienLuong.Name = "TxbTienLuong";
            this.TxbTienLuong.Size = new System.Drawing.Size(228, 22);
            this.TxbTienLuong.TabIndex = 6;
            // 
            // txbChucVu
            // 
            this.txbChucVu.Location = new System.Drawing.Point(461, 79);
            this.txbChucVu.Name = "txbChucVu";
            this.txbChucVu.Size = new System.Drawing.Size(228, 22);
            this.txbChucVu.TabIndex = 5;
            // 
            // txTenNV
            // 
            this.txTenNV.Location = new System.Drawing.Point(109, 73);
            this.txTenNV.Name = "txTenNV";
            this.txTenNV.Size = new System.Drawing.Size(219, 22);
            this.txTenNV.TabIndex = 2;
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(109, 29);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(218, 22);
            this.txbMaNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(758, 290);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(758, 350);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(758, 413);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Location = new System.Drawing.Point(758, 486);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(75, 23);
            this.btnKhoiTao.TabIndex = 5;
            this.btnKhoiTao.Text = "Khởi tạo";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 521);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_ThongTin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_ThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ThongTin;
        private System.Windows.Forms.DataGridView dtgvThongTin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtPNgaySinh;
        private System.Windows.Forms.TextBox TxbTienLuong;
        private System.Windows.Forms.TextBox txbChucVu;
        private System.Windows.Forms.TextBox txTenNV;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnKhoiTao;
    }
}

