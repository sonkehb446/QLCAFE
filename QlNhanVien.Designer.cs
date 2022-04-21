
namespace CAFE
{
    partial class QlNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QlNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewnhanvien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtXuatEXCEL = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.dateVao = new System.Windows.Forms.DateTimePicker();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.buttonsua = new System.Windows.Forms.Button();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.textTenNV = new System.Windows.Forms.TextBox();
            this.textMaNV = new System.Windows.Forms.TextBox();
            this.Reload1 = new System.Windows.Forms.Button();
            this.Timkiem = new System.Windows.Forms.TextBox();
            this.BTTIMKIEM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhanvien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.dataGridViewnhanvien);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Reload1);
            this.panel1.Controls.Add(this.Timkiem);
            this.panel1.Controls.Add(this.BTTIMKIEM);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 457);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewnhanvien
            // 
            this.dataGridViewnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewnhanvien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.DiaChi,
            this.SDT,
            this.ChucVu,
            this.GioiTinh,
            this.PhanQuyen,
            this.NgayVaoLam});
            this.dataGridViewnhanvien.Location = new System.Drawing.Point(0, 31);
            this.dataGridViewnhanvien.Name = "dataGridViewnhanvien";
            this.dataGridViewnhanvien.ReadOnly = true;
            this.dataGridViewnhanvien.RowTemplate.Height = 25;
            this.dataGridViewnhanvien.Size = new System.Drawing.Size(788, 275);
            this.dataGridViewnhanvien.TabIndex = 0;
            this.dataGridViewnhanvien.Click += new System.EventHandler(this.dataGridViewnhanvien_Click);
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 65;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "TenNV";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "ChucVu";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Nam/Nữ";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // PhanQuyen
            // 
            this.PhanQuyen.DataPropertyName = "PhanQuyen";
            this.PhanQuyen.HeaderText = "Quyền Truy Cập";
            this.PhanQuyen.Name = "PhanQuyen";
            this.PhanQuyen.ReadOnly = true;
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.DataPropertyName = "NgayVaoLam";
            this.NgayVaoLam.HeaderText = "Ngày Vào Làm";
            this.NgayVaoLam.Name = "NgayVaoLam";
            this.NgayVaoLam.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtXuatEXCEL);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.cbQuyen);
            this.panel3.Controls.Add(this.dateVao);
            this.panel3.Controls.Add(this.buttonxoa);
            this.panel3.Controls.Add(this.buttonthem);
            this.panel3.Controls.Add(this.cbGioiTinh);
            this.panel3.Controls.Add(this.buttonsua);
            this.panel3.Controls.Add(this.cbChucVu);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.txtDiaChi);
            this.panel3.Controls.Add(this.textTenNV);
            this.panel3.Controls.Add(this.textMaNV);
            this.panel3.Location = new System.Drawing.Point(5, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 136);
            this.panel3.TabIndex = 1;
            // 
            // txtXuatEXCEL
            // 
            this.txtXuatEXCEL.Location = new System.Drawing.Point(611, 14);
            this.txtXuatEXCEL.Name = "txtXuatEXCEL";
            this.txtXuatEXCEL.Size = new System.Drawing.Size(129, 32);
            this.txtXuatEXCEL.TabIndex = 11;
            this.txtXuatEXCEL.Text = "Xuất EXCEL";
            this.txtXuatEXCEL.UseVisualStyleBackColor = true;
            this.txtXuatEXCEL.Click += new System.EventHandler(this.txtXuatEXCEL_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(32, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 24);
            this.panel4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phân Quyền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chức Vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giới Tính";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 29);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Vào Làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaNV";
            // 
            // cbQuyen
            // 
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Items.AddRange(new object[] {
            "Mức Quản lý",
            "Mức Nhân Viên"});
            this.cbQuyen.Location = new System.Drawing.Point(316, 96);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(121, 23);
            this.cbQuyen.TabIndex = 3;
            // 
            // dateVao
            // 
            this.dateVao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVao.Location = new System.Drawing.Point(463, 37);
            this.dateVao.Name = "dateVao";
            this.dateVao.Size = new System.Drawing.Size(104, 23);
            this.dateVao.TabIndex = 4;
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(463, 66);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 53);
            this.buttonxoa.TabIndex = 1;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonthem
            // 
            this.buttonthem.Location = new System.Drawing.Point(665, 66);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(75, 53);
            this.buttonthem.TabIndex = 0;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click_1);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGioiTinh.Location = new System.Drawing.Point(10, 96);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 23);
            this.cbGioiTinh.TabIndex = 2;
            // 
            // buttonsua
            // 
            this.buttonsua.Location = new System.Drawing.Point(563, 66);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(75, 53);
            this.buttonsua.TabIndex = 0;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = true;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "CUA HANG TRUONG",
            "QUAN LY",
            "ORDER"});
            this.cbChucVu.Location = new System.Drawing.Point(159, 96);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(121, 23);
            this.cbChucVu.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(344, 37);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(93, 23);
            this.txtSDT.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(219, 37);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(119, 23);
            this.txtDiaChi.TabIndex = 7;
            // 
            // textTenNV
            // 
            this.textTenNV.Location = new System.Drawing.Point(94, 37);
            this.textTenNV.Name = "textTenNV";
            this.textTenNV.Size = new System.Drawing.Size(119, 23);
            this.textTenNV.TabIndex = 6;
            // 
            // textMaNV
            // 
            this.textMaNV.Location = new System.Drawing.Point(10, 37);
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.Size = new System.Drawing.Size(78, 23);
            this.textMaNV.TabIndex = 5;
            // 
            // Reload1
            // 
            this.Reload1.Location = new System.Drawing.Point(224, 2);
            this.Reload1.Name = "Reload1";
            this.Reload1.Size = new System.Drawing.Size(75, 23);
            this.Reload1.TabIndex = 4;
            this.Reload1.Text = "Reload";
            this.Reload1.UseVisualStyleBackColor = true;
            this.Reload1.Click += new System.EventHandler(this.Reload1_Click);
            // 
            // Timkiem
            // 
            this.Timkiem.Location = new System.Drawing.Point(118, 2);
            this.Timkiem.Name = "Timkiem";
            this.Timkiem.Size = new System.Drawing.Size(100, 23);
            this.Timkiem.TabIndex = 2;
            // 
            // BTTIMKIEM
            // 
            this.BTTIMKIEM.Location = new System.Drawing.Point(37, 2);
            this.BTTIMKIEM.Name = "BTTIMKIEM";
            this.BTTIMKIEM.Size = new System.Drawing.Size(75, 23);
            this.BTTIMKIEM.TabIndex = 3;
            this.BTTIMKIEM.Text = "Tìm Kiếm";
            this.BTTIMKIEM.UseVisualStyleBackColor = true;
            this.BTTIMKIEM.Click += new System.EventHandler(this.BTTIMKIEM_Click);
            // 
            // QlNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 463);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QlNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QlNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhanvien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox textTenNV;
        private System.Windows.Forms.TextBox textMaNV;
        private System.Windows.Forms.DateTimePicker dateVao;
        private System.Windows.Forms.TextBox Timkiem;
        private System.Windows.Forms.Button BTTIMKIEM;
        private System.Windows.Forms.Button Reload1;
        private System.Windows.Forms.DataGridView dataGridViewnhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoLam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtXuatEXCEL;
    }
}