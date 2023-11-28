using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace AppQuanLyQuanCafe
{
    public partial class frmBan : Form
    {
        BLL_DAL_Ban bll_ban = new BLL_DAL_Ban();
        public frmBan()
        {
            InitializeComponent();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            loadCBB();
            loadDataGribView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KTNhapLieu())
            {
                BAN b = new BAN();
                b.TENBAN = txtTenBan.Text;
                b.SLMAX = int.Parse(txtSoLuong.Text);
                b.TINHTRANG = cbbTinhTrang.SelectedItem.ToString();
                bll_ban.themBan(b);
                loadDataGribView();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(KTNhapLieu())
            {
                string tenban = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                BAN b = new BAN();
                b.SLMAX = int.Parse(txtSoLuong.Text);
                b.TINHTRANG = cbbTinhTrang.SelectedItem.ToString();
                bll_ban.suaBan(tenban, b);
                loadDataGribView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenban = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bll_ban.xoaBan(tenban);
            loadDataGribView();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }
        public void loadDataGribView()
        {
            lamMoi();
            dataGridView1.DataSource = bll_ban.loadDataBan();
        }
        void loadCBB()
        {
            cbbTinhTrang.Items.Add("Trống");
            cbbTinhTrang.Items.Add("Đặt trước");
            cbbTinhTrang.Items.Add("Có khách");
        }
        void lamMoi()
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtSoLuong.Text = "";
            txtTenBan.Text = "";
            cbbTinhTrang.SelectedIndex = 0;
            txtTenBan.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    txtTenBan.Text = row.Cells[0].Value.ToString();
                    txtSoLuong.Text = row.Cells[1].Value.ToString();
                    cbbTinhTrang.SelectedItem = row.Cells[2].Value.ToString();
                }
            }
        }
        private bool KTNhapLieu()
        {
            if (txtTenBan.Text == "")
            {
                MessageBox.Show("Tên bàn không được để trống");
                txtTenBan.Focus();
                return false;
            }

            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống");
                txtSoLuong.Focus();
                return false;
            }

            return true;
        }

    }
}
