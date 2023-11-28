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
    public partial class frmNhanVien : Form
    {
        BLL_DAL_NhanVien bll_nv = new BLL_DAL_NhanVien();
        MaHoaPassword mh = new MaHoaPassword();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            loadCBB();
            loadDataGridView();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KTNhapLieu())
            {
                NHANVIEN nv = new NHANVIEN();                
                nv.EMAIL = txtEmail.Text;
                string passmahoa = mh.Encrypt(txtMatkhau.Text);
                nv.PASSNV = passmahoa;
                nv.HOTEN = txtHoTen.Text;
                nv.GIOITINH = cbbGioiTinh.SelectedItem.ToString();
                nv.SDT = txtSDT.Text;
                nv.NGAYSINH = dateNgaySinh.Value;
                nv.DIACHI = txtDiaChi.Text;
                nv.TINHTRANG = cbbTinhTrang.SelectedItem.ToString();
                if (chkQuyen.Checked)
                    nv.MAQ = "Q01";
                else
                    nv.MAQ = "Q02";
                bll_nv.themNhanVien(nv);
                loadDataGridView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sdt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bll_nv.xoaNhanVien(sdt);
            loadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KTNhapLieu())
            {
                string sdt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                NHANVIEN nv = new NHANVIEN();
                nv.EMAIL = txtEmail.Text;
                string passmahoa = mh.Encrypt(txtMatkhau.Text);
                nv.PASSNV = passmahoa;
                nv.HOTEN = txtHoTen.Text;
                nv.GIOITINH = cbbGioiTinh.SelectedItem.ToString();
                nv.NGAYSINH = dateNgaySinh.Value;
                nv.DIACHI = txtDiaChi.Text;
                nv.TINHTRANG = cbbTinhTrang.SelectedItem.ToString();
                if (chkQuyen.Checked)
                    nv.MAQ = "Q01";
                else
                    nv.MAQ = "Q02";
                bll_nv.suaNhanVien(sdt, nv);
                loadDataGridView();
            }
        }
        public void loadCBB()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbTinhTrang.Items.Add("Đang làm việc");
            cbbTinhTrang.Items.Add("Tạm nghỉ");
            cbbTinhTrang.Items.Add("Nghỉ việc");

            cbbGioiTinh.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;
        }
        public void loadDataGridView()
        {
            lamMoi();
            dataGridView1.DataSource = bll_nv.loadDataNhanVien();
        }
        private bool KTNhapLieu()
        {
            DateTime ngaysinh = dateNgaySinh.Value;
            int tuoi = DateTime.Now.Year - ngaysinh.Year;
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống");
                txtEmail.Focus();
                return false;
            }

            if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
                txtMatkhau.Focus();
                return false;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ tên không được để trống");
                txtHoTen.Focus();
                return false;
            }
            if (tuoi < 16)
            {
                MessageBox.Show("Tuổi phải lớn hơn 16");
                dateNgaySinh.Focus();
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống");
                txtSDT.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống");
                txtDiaChi.Focus();
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
                    txtSDT.Text = row.Cells[0].Value.ToString();
                    string passmh = mh.Decrypt(row.Cells[7].Value.ToString());
                    txtMatkhau.Text = passmh;
                    txtHoTen.Text = row.Cells[2].Value.ToString();
                    cbbGioiTinh.SelectedItem = row.Cells[3].Value.ToString();
                    dateNgaySinh.Value = Convert.ToDateTime(row.Cells[4].Value);
                    txtEmail.Text = row.Cells[6].Value.ToString();
                    txtDiaChi.Text = row.Cells[5].Value.ToString();
                    cbbTinhTrang.SelectedItem = row.Cells[8].Value.ToString();
                    if (row.Cells[1].Value.ToString() == "Q01")
                        chkQuyen.Checked = true;
                    else
                        chkQuyen.Checked = false;
                    txtSDT.Enabled = false;
                }
            }
        }
        void lamMoi()
        {
            txtSDT.Enabled = true;
            txtEmail.Text = "";
            txtMatkhau.Text = "";
            txtHoTen.Text = "";
            cbbGioiTinh.SelectedItem = 0;
            txtSDT.Text = "";
            dateNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            cbbTinhTrang.SelectedItem = 0;
            chkQuyen.Checked = false;
            txtSDT.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

    }
}
