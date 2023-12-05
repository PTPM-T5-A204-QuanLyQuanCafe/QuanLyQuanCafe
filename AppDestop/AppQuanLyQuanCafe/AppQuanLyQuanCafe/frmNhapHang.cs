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
    public partial class frmNhapHang : Form
    {
        BLL_DAL_PhieuNhap bll_phieunhap = new BLL_DAL_PhieuNhap();
        BLL_DAL_ChiTietPhieuNhap bll_chitietPN = new BLL_DAL_ChiTietPhieuNhap();
        BLL_DAL_NhanVien bll_nhanvien = new BLL_DAL_NhanVien();
        BLL_DAL_NCC bll_ncc = new BLL_DAL_NCC();
        BLL_DAL_Kho bll_hang = new BLL_DAL_Kho();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            loadCBB();
            txtMaPhieu.Text = bll_phieunhap.TaoMaPhieuNhap();
            loadDataGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            lamMoiCTPN();
            enableCTPN();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if(!KTNhapLieu())
                return;
            string maphieu = txtMaPhieu.Text;
            string mahang = txtMaHang.Text;
            if(bll_phieunhap.KTTonTaiPN(maphieu) == false)
            {
                PHIEUNHAP p = new PHIEUNHAP();
                p.MAPHIEU = txtMaPhieu.Text;
                p.SDT = cbbNhanVien.SelectedValue.ToString();
                p.SODIENTHOAINCC = cbbNhaCC.SelectedValue.ToString();
                p.NGAYLAP = dateNgayLap.Value;
                p.TONGTIEN = 0;
                bll_phieunhap.themPhieuNhap(p);
                CHITIETPHEUNHAP ct = new CHITIETPHEUNHAP();
                ct.MAPHIEU = txtMaPhieu.Text;
                ct.MAHANG = txtMaHang.Text;
                ct.GIA = float.Parse(txtGia.Text);
                ct.SOLUONG = int.Parse(txtSoLuong.Text);
                bll_chitietPN.themChiTietPhieuNhap(ct);
                luuTienThem(maphieu);
                loadDataGridView();
            }
            else
            {
                PHIEUNHAP p = new PHIEUNHAP();
                p.SDT = cbbNhanVien.SelectedValue.ToString();
                p.SODIENTHOAINCC = cbbNhaCC.SelectedValue.ToString();
                p.NGAYLAP = dateNgayLap.Value;
                bll_phieunhap.suaPhieuNhap(maphieu, p);
                if(bll_chitietPN.KTTonTaiCTPN(maphieu, mahang) == false)
                {
                    CHITIETPHEUNHAP ct = new CHITIETPHEUNHAP();
                    ct.MAPHIEU = txtMaPhieu.Text;
                    ct.MAHANG = txtMaHang.Text;
                    ct.GIA = float.Parse(txtGia.Text);
                    ct.SOLUONG = int.Parse(txtSoLuong.Text);
                    bll_chitietPN.themChiTietPhieuNhap(ct);
                }
                else
                {
                    CHITIETPHEUNHAP ct = new CHITIETPHEUNHAP();
                    ct.GIA = float.Parse(txtGia.Text);
                    ct.SOLUONG = int.Parse(txtSoLuong.Text);
                    bll_chitietPN.suaChiTietPhieuNhap(maphieu, mahang, ct);
                }
                luuTienThem(maphieu);
                loadDataGridView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu cần xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                luuTienXoa(txtMaPhieu.Text);
                bll_chitietPN.xoaChiTietPhieuNhap(txtMaPhieu.Text, txtMaHang.Text);
                loadDataGridView();
            }

        }
        void loadDataGridView()
        {
            lamMoiCTPN();
            string maphieu = txtMaPhieu.Text;
            dataGridView1.DataSource = bll_chitietPN.loadCTPNTheoMa(maphieu);
        }
        void loadCBB()
        {
            cbbNhanVien.DataSource = bll_nhanvien.loadDataNhanVien();
            cbbNhanVien.DisplayMember = "HOTEN";
            cbbNhanVien.ValueMember = "SDT";

            cbbNhaCC.DataSource = bll_ncc.loadDataNCC();
            cbbNhaCC.DisplayMember = "TENNHACC";
            cbbNhaCC.ValueMember = "SODIENTHOAINCC";

            cbbTenHang.DataSource = bll_hang.loadDataKhoHang();
            cbbTenHang.DisplayMember = "TENHANG";
            cbbTenHang.ValueMember = "MAHANG";
        }
        void lamMoiCTPN()
        {
            txtMaHang.Text = "";
            txtMaHang.Focus();
            txtSoLuong.Text = "";
            txtGia.Text = "";
            cbbTenHang.Text = "";
        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHang.Text = cbbTenHang.SelectedValue.ToString();
        }

        void enableCTPN()
        {
            txtMaHang.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGia.Enabled = true;
            cbbTenHang.Enabled = true;
        }
        void disableCTPN()
        {
            txtMaHang.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGia.Enabled = false;
            cbbTenHang.Enabled = false;
        }

        private bool KTNhapLieu()
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Mã không được để trống");
                txtMaHang.Focus();
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
                return false;
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá");
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
                    txtMaPhieu.Text = row.Cells[0].Value.ToString();
                    txtMaHang.Text = row.Cells[1].Value.ToString();
                    cbbTenHang.SelectedText = bll_hang.TenHang(txtMaHang.Text);
                    txtGia.Text = row.Cells[2].Value.ToString();
                    txtSoLuong.Text = row.Cells[3].Value.ToString();     
                }
            }
        }
        public void luuTienThem(string maphieu)
        {
            float tong = float.Parse(txtTongTien.Text);
            float gia = float.Parse(txtGia.Text);
            float sl = int.Parse(txtSoLuong.Text);
            tong = tong + gia * sl;
            txtTongTien.Text = tong.ToString();
            bll_phieunhap.luuTongTien(maphieu, tong);
        }
        public void luuTienXoa(string maphieu)
        {
            float tong = float.Parse(txtTongTien.Text);
            float gia = float.Parse(txtGia.Text);
            float sl = int.Parse(txtSoLuong.Text);
            tong = tong - gia * sl;
            txtTongTien.Text = tong.ToString();
            bll_phieunhap.luuTongTien(maphieu, tong);
        }
    }
}
