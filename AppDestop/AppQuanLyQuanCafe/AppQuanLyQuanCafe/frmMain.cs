﻿using System;
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
    }
}