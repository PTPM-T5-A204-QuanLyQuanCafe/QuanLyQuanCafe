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
    public partial class frmThongKeHangTon : Form
    {
        BLL_DAL_Kho bll_kho = new BLL_DAL_Kho();
        public frmThongKeHangTon()
        {
            InitializeComponent();
        }

        private void frmThongKeHangTon_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (KTNhapLieu())
            {

                if (txtMaHang.Text != "")
                {
                    dataGridView1.DataSource = bll_kho.TimKiemMaHang(txtMaHang.Text);
                }
                else if (txtTenHang.Text != "")
                {
                    dataGridView1.DataSource = bll_kho.TimKiemMaHang(txtTenHang.Text);
                }
                else
                {
                    int soluong = int.Parse(txtSoLuong.Text);
                    dataGridView1.DataSource = bll_kho.TimKiemSoLuongHang(soluong);
                }
            }
        }
        public bool KTNhapLieu()
        {
            if(txtMaHang.Text == "" && txtTenHang.Text == "" && txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu cần tìm kiếm!");
                return false;
            }
            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
