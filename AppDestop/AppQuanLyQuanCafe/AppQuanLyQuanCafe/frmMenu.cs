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
using System.IO;

namespace AppQuanLyQuanCafe
{
    public partial class frmMenu : Form
    {
        BLL_DAL_Menu bll_menu = new BLL_DAL_Menu();
        private bool ktPicSanPham = false;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            loadCBB();
            loadDataGridView();
        }

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            taoLai();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KTNhapLieu())
            {
                MENU m = new MENU();
                m.MASP = txtMaSP.Text;
                m.TENLOAI = cbbTenLoai.SelectedValue.ToString();
                m.TENSP = txtTenSP.Text;
                m.GIA = float.Parse(txtGia.Text);
                m.SOLUONG = int.Parse(txtSoLuong.Text);
                m.DVT = cbbDVT.SelectedItem.ToString();
                m.TINHTRANG = cbbTinhTrang.SelectedItem.ToString();
                string tenAnh = Path.GetFileName(picSanPham.ImageLocation);
                m.ANH = tenAnh;
                bll_menu.themSPMenu(m);
                loadDataGridView();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KTNhapLieu())
            {
                string masp = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                MENU m = new MENU();
                m.TENLOAI = cbbTenLoai.SelectedValue.ToString();
                m.TENSP = txtTenSP.Text;
                m.GIA = float.Parse(txtGia.Text);
                m.SOLUONG = int.Parse(txtSoLuong.Text);
                m.DVT = cbbDVT.SelectedItem.ToString();
                m.TINHTRANG = cbbTinhTrang.SelectedItem.ToString();
                string tenAnh = Path.GetFileName(picSanPham.ImageLocation);
                m.ANH = tenAnh;
                bll_menu.suaSPMenu(masp, m);
                loadDataGridView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && !bll_menu.KiemTraKhoaNgoaiMenu(txtMaSP.Text))
            {
                string masp = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                bll_menu.xoaSPMenu(masp);
                loadDataGridView();
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.gif;*jpg;*.jpeg;*.png;*.bmp)|*.gif;*jpg;*.jpeg;*.png;*.bmp";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                picSanPham.ImageLocation = openFile.FileName;
                ktPicSanPham = true;
            }
        }

        void loadCBB()
        {
            cbbTenLoai.DataSource = bll_menu.loadDataPhanLoai();
            cbbTenLoai.DisplayMember = "TenLoai";
            cbbTenLoai.ValueMember = "TenLoai";
            cbbDVT.Items.Add("Ly");
            cbbDVT.Items.Add("Cái");
            cbbDVT.Items.Add("M");
            cbbDVT.Items.Add("X");
            cbbDVT.Items.Add("XL");
            cbbTinhTrang.Items.Add("Đang bán");
            cbbTinhTrang.Items.Add("Hết");
            cbbTinhTrang.Items.Add("Ngừng bán");
        }
        void loadDataGridView()
        {
            taoLai();
            dataGridView1.DataSource = bll_menu.loadDataMenu();
        }
        void taoLai()
        {
            ktPicSanPham = false;
            picSanPham.Image = null;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaSP.Enabled  = true;
            txtMaSP.Text = "";
            cbbTenLoai.SelectedIndex = 0;
            txtTenSP.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            cbbDVT.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;
        }
        private bool KTNhapLieu()
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Mã sản phẩm không được để trống");
                txtMaSP.Focus();
                return false;
            }
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được để trống");
                txtTenSP.Focus();
                return false;
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Giá không được để trống");
                txtGia.Focus();
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống");
                txtSoLuong.Focus();
                return false;
            }
            if (!ktPicSanPham)
            {
                MessageBox.Show("Vui lòng chọn ảnh cho sản phẩm");
                return false;
            }
            if (bll_menu.KiemTraKhoaChinhMenu(txtMaSP.Text))
            {
                MessageBox.Show("Sản phẩm đã tồn tại!");
                txtMaSP.Focus();
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
                    ktPicSanPham = true;
                    txtMaSP.Text = row.Cells[0].Value.ToString();
                    cbbTenLoai.SelectedItem = row.Cells[1].Value.ToString();
                    txtTenSP.Text = row.Cells[2].Value.ToString();
                    txtSoLuong.Text = row.Cells[3].Value.ToString();
                    cbbDVT.SelectedItem = row.Cells[4].Value.ToString();                   
                    txtGia.Text = row.Cells[5].Value.ToString();
                    //picSanPham.ImageLocation = row.Cells[6].Value.ToString();
                    cbbTinhTrang.SelectedItem = row.Cells[7].Value.ToString();
                    txtMaSP.Enabled = false;
                    string tenAnh = row.Cells[6].Value.ToString();

                    // Lấy đường dẫn thư mục làm việc hiện tại của ứng dụng
                    string thuMucLamViec = AppDomain.CurrentDomain.BaseDirectory;

                    // Kết hợp với tên thư mục ảnh và tên ảnh
                    string duongDanDayDu = Path.Combine(thuMucLamViec, "Anh", tenAnh);

                    // Hiển thị ảnh trong PictureBox
                    picSanPham.Image = Image.FromFile(duongDanDayDu);
                }
            }
        }

              
        
    }
}
