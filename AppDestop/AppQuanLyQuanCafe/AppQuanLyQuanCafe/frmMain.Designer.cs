namespace AppQuanLyQuanCafe
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTripTKHangTon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripNhanVien,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tStripNhanVien
            // 
            this.tStripNhanVien.Name = "tStripNhanVien";
            this.tStripNhanVien.Size = new System.Drawing.Size(259, 30);
            this.tStripNhanVien.Text = "Danh sách nhân viên";
            this.tStripNhanVien.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcBànToolStripMenuItem,
            this.danhMụcMenuToolStripMenuItem,
            this.tStripMenu});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // danhMụcBànToolStripMenuItem
            // 
            this.danhMụcBànToolStripMenuItem.Name = "danhMụcBànToolStripMenuItem";
            this.danhMụcBànToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.danhMụcBànToolStripMenuItem.Text = "Danh mục bàn";
            this.danhMụcBànToolStripMenuItem.Click += new System.EventHandler(this.danhMụcBànToolStripMenuItem_Click);
            // 
            // danhMụcMenuToolStripMenuItem
            // 
            this.danhMụcMenuToolStripMenuItem.Name = "danhMụcMenuToolStripMenuItem";
            this.danhMụcMenuToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.danhMụcMenuToolStripMenuItem.Text = "Danh mục menu";
            this.danhMụcMenuToolStripMenuItem.Click += new System.EventHandler(this.danhMụcMenuToolStripMenuItem_Click);
            // 
            // tStripMenu
            // 
            this.tStripMenu.Name = "tStripMenu";
            this.tStripMenu.Size = new System.Drawing.Size(257, 30);
            this.tStripMenu.Text = "Danh mục kho hàng";
            this.tStripMenu.Click += new System.EventHandler(this.danhMụcHàngToolStripMenuItem_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripNhapHang});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // tStripNhapHang
            // 
            this.tStripNhapHang.Name = "tStripNhapHang";
            this.tStripNhapHang.Size = new System.Drawing.Size(210, 30);
            this.tStripNhapHang.Text = "Nhập hàng";
            this.tStripNhapHang.Click += new System.EventHandler(this.tStripNhapHang_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTripTKHangTon});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // sTripTKHangTon
            // 
            this.sTripTKHangTon.Name = "sTripTKHangTon";
            this.sTripTKHangTon.Size = new System.Drawing.Size(247, 30);
            this.sTripTKHangTon.Text = "Thống kê hàng tồn";
            this.sTripTKHangTon.Click += new System.EventHandler(this.sTripTKHangTon_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppQuanLyQuanCafe.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(904, 577);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý Coffe";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tStripNhanVien;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tStripMenu;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tStripNhapHang;
        private System.Windows.Forms.ToolStripMenuItem sTripTKHangTon;
    }
}