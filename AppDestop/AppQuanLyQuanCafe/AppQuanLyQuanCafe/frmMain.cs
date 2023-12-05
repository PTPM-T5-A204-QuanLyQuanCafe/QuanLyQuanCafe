using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanCafe
{
    public partial class frmMain : Form
    {
        Boolean laAdmin;

        public Boolean LaAdmin
        {
            get { return laAdmin; }
            set { laAdmin = value; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        private void danhMụcBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBan frm = new frmBan();
            frm.Show();
        }

        private void danhMụcMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
        }

        private void danhMụcHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKho frm = new frmKho();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if (LaAdmin != true)
            {
               tStripNhanVien.Enabled = false;
               tStripMenu.Enabled = false;
               tStripNhapHang.Enabled = false;
               sTripTKHangTon.Enabled = false;
            }
        }

        private void tStripNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frm = new frmNhapHang();
            frm.Show();
        }

        private void sTripTKHangTon_Click(object sender, EventArgs e)
        {
            frmThongKeHangTon frm = new frmThongKeHangTon();
            frm.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.Show();
        }
    }
}
