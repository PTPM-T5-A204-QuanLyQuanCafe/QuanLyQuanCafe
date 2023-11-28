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
    public partial class frmKho : Form
    {
        BLL_DAL_Kho bll_kho = new BLL_DAL_Kho();
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
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
                KHOHANG k = new KHOHANG();
                k.MAHANG = txtMaHang.Text;
                k.TENHANG = txtTenHang.Text;
                k.SOLUONG = int.Parse(txtSoLuong.Text);
                k.GIA = float.Parse(txtGia.Text);
                k.DVT = cbbDVT.SelectedItem.ToString();
                k.TINHTRANG = cbbTinhTrang.SelectedItem.ToString();
                bll_kho.themKhoHang(k);
                loadDataGribView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahang = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bll_kho.xoaKhoHang(mahang);
            loadDataGribView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahang = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (KTNhapLieu())
            {
                KHOHANG k = new KHOHANG();
                k.TENHANG = txtTenHang.Text;
                k.SOLUONG = int.Parse(txtSoLuong.Text);
                k.GIA = float.Parse(txtGia.Text);
                k.DVT = cbbDVT.SelectedItem.ToString();
                k.TINHTRANG = cbbTinhTrang.SelectedItem.ToString();
                bll_kho.suaKhoHang(mahang, k);
                loadDataGribView();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }
        void loadDataGribView()
        {
            lamMoi();
            dataGridView1.DataSource = bll_kho.loadDataKhoHang();
        }
        void loadCBB()
        {
            cbbDVT.Items.Add("Kg");
            cbbDVT.Items.Add("Lon");
            cbbDVT.Items.Add("Gói");
            cbbTinhTrang.Items.Add("Còn");
            cbbTinhTrang.Items.Add("Hết");
        }
        void lamMoi()
        {
            txtMaHang.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtMaHang.Text = "";
            txtGia.Text = "";
            cbbDVT.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;
            txtMaHang.Focus();
        }
        private bool KTNhapLieu()
        {
            if (txtGia.Text == "")
            {
                MessageBox.Show("Giá không được để trống");
                txtGia.Focus();
                return false;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Mã hàng hóa không được để trống");
                txtMaHang.Focus();
                return false;
            }
            if (txtTenHang.Text == "")
            {
                MessageBox.Show("Tên hàng hóa không được để trống");
                txtTenHang.Focus();
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng hàng hóa không được để trống");
                txtSoLuong.Focus();
                return false;
            }        
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    txtMaHang.Text = row.Cells[0].Value.ToString();
                    txtTenHang.Text = row.Cells[1].Value.ToString();
                    cbbDVT.SelectedItem = row.Cells[2].Value.ToString();
                    txtSoLuong.Text = row.Cells[3].Value.ToString();
                    txtGia.Text = row.Cells[4].Value.ToString();
                    cbbTinhTrang.SelectedItem = row.Cells[5].Value.ToString();
                    txtMaHang.Enabled = false;
                }
            }
        }
    }
}
