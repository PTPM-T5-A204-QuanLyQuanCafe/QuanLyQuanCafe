namespace AppQuanLyQuanCafe
{
    partial class frmMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbbDVT = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTaoLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTenLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(971, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTenLoai);
            this.groupBox1.Controls.Add(this.cbbTinhTrang);
            this.groupBox1.Controls.Add(this.cbbDVT);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnTaoLai);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnChonAnh);
            this.groupBox1.Controls.Add(this.picSanPham);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(460, 115);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(208, 28);
            this.cbbTinhTrang.TabIndex = 8;
            // 
            // cbbDVT
            // 
            this.cbbDVT.FormattingEnabled = true;
            this.cbbDVT.Location = new System.Drawing.Point(460, 26);
            this.cbbDVT.Name = "cbbDVT";
            this.cbbDVT.Size = new System.Drawing.Size(208, 28);
            this.cbbDVT.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(599, 176);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(489, 176);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTaoLai
            // 
            this.btnTaoLai.Location = new System.Drawing.Point(119, 198);
            this.btnTaoLai.Name = "btnTaoLai";
            this.btnTaoLai.Size = new System.Drawing.Size(86, 40);
            this.btnTaoLai.TabIndex = 5;
            this.btnTaoLai.Text = "Tạo lại";
            this.btnTaoLai.UseVisualStyleBackColor = true;
            this.btnTaoLai.Click += new System.EventHandler(this.btnTaoLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(375, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 40);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(252, 198);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(709, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ảnh sản phẩm:";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(847, 22);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(106, 34);
            this.btnChonAnh.TabIndex = 3;
            this.btnChonAnh.Text = "Chọn";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picSanPham
            // 
            this.picSanPham.Location = new System.Drawing.Point(713, 70);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(251, 166);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSanPham.TabIndex = 2;
            this.picSanPham.TabStop = false;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(119, 164);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(208, 26);
            this.txtGia.TabIndex = 1;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(119, 115);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(208, 26);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(460, 67);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(208, 26);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(119, 19);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(208, 26);
            this.txtMaSP.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn vị tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // cbbTenLoai
            // 
            this.cbbTenLoai.FormattingEnabled = true;
            this.cbbTenLoai.Location = new System.Drawing.Point(119, 67);
            this.cbbTenLoai.Name = "cbbTenLoai";
            this.cbbTenLoai.Size = new System.Drawing.Size(208, 28);
            this.cbbTenLoai.TabIndex = 9;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTaoLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.ComboBox cbbDVT;
        private System.Windows.Forms.ComboBox cbbTenLoai;
    }
}