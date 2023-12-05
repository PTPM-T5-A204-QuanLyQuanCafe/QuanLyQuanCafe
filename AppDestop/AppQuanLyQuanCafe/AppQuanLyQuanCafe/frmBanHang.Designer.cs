namespace AppQuanLyQuanCafe
{
    partial class frmBanHang
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView_hoadon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_mon = new System.Windows.Forms.ComboBox();
            this.numericUpDown1_soluong = new System.Windows.Forms.NumericUpDown();
            this.btn_themmon = new System.Windows.Forms.Button();
            this.btn_chuyenban = new System.Windows.Forms.Button();
            this.cbo_ban = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_tienNhan = new System.Windows.Forms.TextBox();
            this.txt_tienthoi = new System.Windows.Forms.TextBox();
            this.TenBan = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dataGridView_hoadon);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(571, 225);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(794, 383);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView_hoadon
            // 
            this.dataGridView_hoadon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hoadon.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_hoadon.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_hoadon.Name = "dataGridView_hoadon";
            this.dataGridView_hoadon.RowTemplate.Height = 28;
            this.dataGridView_hoadon.Size = new System.Drawing.Size(791, 380);
            this.dataGridView_hoadon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn món:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng:";
            // 
            // cbo_mon
            // 
            this.cbo_mon.FormattingEnabled = true;
            this.cbo_mon.Location = new System.Drawing.Point(696, 34);
            this.cbo_mon.Name = "cbo_mon";
            this.cbo_mon.Size = new System.Drawing.Size(228, 28);
            this.cbo_mon.TabIndex = 5;
            // 
            // numericUpDown1_soluong
            // 
            this.numericUpDown1_soluong.Location = new System.Drawing.Point(697, 88);
            this.numericUpDown1_soluong.Name = "numericUpDown1_soluong";
            this.numericUpDown1_soluong.Size = new System.Drawing.Size(227, 26);
            this.numericUpDown1_soluong.TabIndex = 6;
            // 
            // btn_themmon
            // 
            this.btn_themmon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_themmon.Location = new System.Drawing.Point(972, 37);
            this.btn_themmon.Name = "btn_themmon";
            this.btn_themmon.Size = new System.Drawing.Size(109, 60);
            this.btn_themmon.TabIndex = 7;
            this.btn_themmon.Text = "Thêm món";
            this.btn_themmon.UseVisualStyleBackColor = false;
            this.btn_themmon.Click += new System.EventHandler(this.btn_themmon_Click);
            // 
            // btn_chuyenban
            // 
            this.btn_chuyenban.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_chuyenban.Location = new System.Drawing.Point(1237, 151);
            this.btn_chuyenban.Name = "btn_chuyenban";
            this.btn_chuyenban.Size = new System.Drawing.Size(142, 61);
            this.btn_chuyenban.TabIndex = 8;
            this.btn_chuyenban.Text = "Chuyển bàn";
            this.btn_chuyenban.UseVisualStyleBackColor = false;
            this.btn_chuyenban.Click += new System.EventHandler(this.btn_chuyenban_Click);
            // 
            // cbo_ban
            // 
            this.cbo_ban.FormattingEnabled = true;
            this.cbo_ban.Location = new System.Drawing.Point(1237, 111);
            this.cbo_ban.Name = "cbo_ban";
            this.cbo_ban.Size = new System.Drawing.Size(158, 28);
            this.cbo_ban.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(785, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "HOÁ ĐƠN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(715, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(715, 692);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tiền nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(715, 737);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tiền thối lại";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(865, 645);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(235, 26);
            this.txt_tongtien.TabIndex = 14;
            // 
            // txt_tienNhan
            // 
            this.txt_tienNhan.Location = new System.Drawing.Point(865, 694);
            this.txt_tienNhan.Name = "txt_tienNhan";
            this.txt_tienNhan.Size = new System.Drawing.Size(235, 26);
            this.txt_tienNhan.TabIndex = 15;
            // 
            // txt_tienthoi
            // 
            this.txt_tienthoi.Enabled = false;
            this.txt_tienthoi.Location = new System.Drawing.Point(862, 736);
            this.txt_tienthoi.Name = "txt_tienthoi";
            this.txt_tienthoi.Size = new System.Drawing.Size(238, 26);
            this.txt_tienthoi.TabIndex = 16;
            // 
            // TenBan
            // 
            this.TenBan.AutoSize = true;
            this.TenBan.BackColor = System.Drawing.Color.Transparent;
            this.TenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenBan.ForeColor = System.Drawing.Color.Purple;
            this.TenBan.Location = new System.Drawing.Point(1009, 184);
            this.TenBan.Name = "TenBan";
            this.TenBan.Size = new System.Drawing.Size(50, 25);
            this.TenBan.TabIndex = 19;
            this.TenBan.Text = "Bàn";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppQuanLyQuanCafe.Properties.Resources.printer;
            this.pictureBox2.Location = new System.Drawing.Point(1000, 796);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppQuanLyQuanCafe.Properties.Resources.diskette;
            this.pictureBox1.Location = new System.Drawing.Point(805, 796);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackgroundImage = global::AppQuanLyQuanCafe.Properties.Resources.background1;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(553, 834);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1104, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Chuyển sang:";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppQuanLyQuanCafe.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(1403, 854);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TenBan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_tienthoi);
            this.Controls.Add(this.txt_tienNhan);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_ban);
            this.Controls.Add(this.btn_chuyenban);
            this.Controls.Add(this.btn_themmon);
            this.Controls.Add(this.numericUpDown1_soluong);
            this.Controls.Add(this.cbo_mon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView_hoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_mon;
        private System.Windows.Forms.NumericUpDown numericUpDown1_soluong;
        private System.Windows.Forms.Button btn_themmon;
        private System.Windows.Forms.Button btn_chuyenban;
        private System.Windows.Forms.ComboBox cbo_ban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_tienNhan;
        private System.Windows.Forms.TextBox txt_tienthoi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label TenBan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
    }
}