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
    public partial class frmLogin : Form
    {
        BLL_DAL_NhanVien bll_login = new BLL_DAL_NhanVien();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DangNhap();
        }
        private void DangNhap()
        {
            string user = txtUserName.Text;
            string pass = txtPassword.Text;
            NHANVIEN kt = bll_login.DangNhap(user,pass);
            if(kt != null)
            {
                frmMain frm = new frmMain();
                if(kt.MAQ == "Q02")
                {
                    frm.LaAdmin = false;
                    frm.ShowDialog();
                    reload();
                }
                else {
                    frm.LaAdmin = true;
                    frm.ShowDialog();
                    reload();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                return;
            }
        }
        void reload()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.DangNhap();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.DangNhap();
            }
        }
 
    }
}
