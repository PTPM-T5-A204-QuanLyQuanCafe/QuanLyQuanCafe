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
    public partial class frmBanHang : Form
    {
        
        BLL_DAL_ThanhToan tt = new BLL_DAL_ThanhToan();

        public frmBanHang()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_tienNhan(txt_tienNhan.Text, txt_tongtien.Text) == true)
                {
                    string maban = TenBan.Text;
                    int tong = TraVeTong(maban);
                    string mahd = tt.LayMaHD(TenBan.Text);
                    tt.CapNhatHoaDon(mahd, tong);
                    tt.CapNhatBan(TenBan.Text);
                    LoadBan();
                    dataGridView_hoadon.DataSource = null;
                    TinhTienThoi(txt_tienNhan.Text, txt_tongtien.Text);
                    MessageBox.Show("Thanh toán thành công");
                }
                else
                {
                    MessageBox.Show("Tiền nhận nhỏ hơn tổng thanh toán");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phải nhập tiền nhận");
            }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            designForm();
            loadAll();
            LoadBan();
        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            string mamon = cbo_mon.SelectedValue.ToString();
            int soluong = (int)numericUpDown1_soluong.Value;
            if (soluong < 1)
            {
                MessageBox.Show("Số lượng món phải lớn hơn 0");
                return;
            }
            string maban = TenBan.Text;

            tt.Add_CTHD(maban, mamon, soluong);
            tt.Load_CTHD(maban, dataGridView_hoadon);
            Tong(maban);
        }

        private void btn_chuyenban_Click(object sender, EventArgs e)
        {
            string mahd = tt.LayMaHD(TenBan.Text);
            tt.CapNhatBan(TenBan.Text);
            tt.ChuyenBan(TenBan.Text, cbo_ban.SelectedValue.ToString(), mahd);
            tt.CapNhatBan(TenBan.Text);
            tt.CapNhatBanCoKhach(cbo_ban.SelectedValue.ToString());
            LoadBan();

            cbo_ban.DataSource = tt.Ds_BanTrong();
        }
        public void loadAll()
        {

            cbo_ban.DataSource = tt.Ds_BanTrong();
            cbo_ban.DisplayMember = "TENBAN";
            cbo_ban.ValueMember = "TENBAN";
            cbo_mon.DataSource = tt.Ds_Mon();
            cbo_mon.DisplayMember = "TENSP";
            cbo_mon.ValueMember = "MASP";

        }
        public void LoadBan()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in tt.Ds_Ban())
            {
                Button btn = new Button();
                if (item.TINHTRANG == "Trống")
                {
                    btn.Click += btn_Click;
                }
                else
                {
                    btn.Click +=btn_Click2;
                }
                btn.MouseUp += btn_MouseUp;
                btn.Tag = item.TENBAN;
                btn.Width = 100;
                btn.Height = 100;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);

                btn.Text = item.TENBAN;
                if (item.TINHTRANG == "Có khách")
                {
                    btn.BackColor = System.Drawing.Color.OrangeRed;
                }
                else
                {
                    btn.BackColor = Color.DarkCyan;
                }
                flowLayoutPanel1.Controls.Add(btn);


            }


        }

        void btn_MouseUp(object sender, MouseEventArgs e)
        {
            Button clickedButton = sender as Button;
            clickedButton.FlatAppearance.BorderColor = SystemColors.ControlDark;
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                var ma = clickedButton.Tag as string;
                try
                {

                    TenBan.Text = ma;
                    tt.TaoHoaDon(ma, clickedButton, dataGridView_hoadon);
                    dataGridView_hoadon.DataSource = null;
                    MessageBox.Show("Thành công");


                    Tong(ma);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }
        private void btn_Click2(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                var ma = clickedButton.Tag as string;
                try
                {

                    TenBan.Text = ma;
                    tt.TaoHoaDon(ma, clickedButton, dataGridView_hoadon);
                    Tong(ma);

                }
                catch (Exception ex)
                {

                }
            }
        }
        public void Tong(string maban)
        {
            string mahd = tt.LayMaHD(maban);
            int tong = tt.tong(mahd);
            string Gia = string.Format("{0:C}", tong.ToString());
            txt_tongtien.Text = Gia;

        }
        public int TraVeTong(string maban)
        {
            string mahd = tt.LayMaHD(maban);
            int tong = tt.tong(mahd);

            return tong;
        }
        public void thietLapBang()
        {
            dataGridView_hoadon.DataSource = tt.Ds_Ban();
            dataGridView_hoadon.Columns["TENBAN"].HeaderText = "Tên bàn";
            dataGridView_hoadon.Columns["SLMAX"].HeaderText = "Số lượng";
            dataGridView_hoadon.Columns["TINHTRANG"].HeaderText = "Tình trạng";
            foreach (DataGridViewColumn column in dataGridView_hoadon.Columns)
            {

                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                column.FillWeight = 1;
            }


            dataGridView_hoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void TinhTienThoi(string tienN, string Gia)
        {
            if (tienN != "" && tienN != null && Gia != "" && Gia != null)
            {

                int tiennhan = int.Parse(tienN);
                int gia = int.Parse(Gia);

                int tienthoi = tiennhan - gia;
                txt_tienthoi.Text = tienthoi.ToString();

            }

        }
        public bool check_tienNhan(string tienN, string Gia)
        {


            int tiennhan = int.Parse(tienN);
            int gia = int.Parse(Gia);
            if (tiennhan < gia)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void designForm()
        {
            // Thiết lập kích thước cho Form
            this.Size = new System.Drawing.Size(960, 600);
            CenterToScreen();
        }
    }
}
