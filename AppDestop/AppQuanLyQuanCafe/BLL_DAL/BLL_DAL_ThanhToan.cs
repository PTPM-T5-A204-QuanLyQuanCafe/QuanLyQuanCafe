using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BLL_DAL
{
    public class BLL_DAL_ThanhToan
    {
        QL_COFFEDataContext ql = new QL_COFFEDataContext();
        public BLL_DAL_ThanhToan()
        {

        }
        public List<CTHOADON> ct_HoaDon(string ma)
        {
            var ds = from item in ql.CTHOADONs where item.MAHD == ma select item;
            List<CTHOADON> ct = ds.ToList<CTHOADON>();
            return ct;
        }

        public List<BAN> Ds_Ban()
        {
            var khoa = from kh in ql.BANs select kh;
            List<BAN> dskhoa = khoa.ToList<BAN>();
            return dskhoa;


        }
        public List<BAN> Ds_BanTrong()
        {
            var khoa = from kh in ql.BANs where kh.TINHTRANG == "Trống" select kh;
            List<BAN> dskhoa = khoa.ToList<BAN>();
            return dskhoa;
        }
        public List<MENU> Ds_Mon()
        {
            var ds_menu = from item in ql.MENUs where item.SOLUONG > 0 select item;
            List<MENU> menu = ds_menu.ToList();
            return menu;
        }


        public bool KiemTraBan(string ma)
        {
            BAN ban = (from item in ql.BANs where item.TENBAN == ma select item).FirstOrDefault();
            if (ban.TINHTRANG == "Có khách")
            {
                return false;
            }
            return true;
        }
        // check bàn trống hay đã có khách
        public void TaoHoaDon(string maban, Button btn, DataGridView table)
        {
            if (KiemTraBan(maban) == true)
            {
                string ma = "";
                DateTime date = DateTime.Now;
                ma = "HD" + date.Year + date.Month + date.Day + date.Hour + date.Minute + date.Second;

                HOADON hd = new HOADON();
                hd.MAHD = ma;
                hd.NGAYLAP = date;
                hd.GIODEN = date;
                hd.SDT = "0895214785";
                hd.TINHTRANG = "Chưa thanh toán";
                hd.TENBAN = maban;
                ql.HOADONs.InsertOnSubmit(hd);

                ql.SubmitChanges();
                Update_Ban(maban, btn);
            }
            else
            {
                Load_CTHD(maban, table);
            }
        }


        public void Update_Ban(string ma, Button btn)
        {
            BAN ban = (from item in ql.BANs where item.TENBAN == ma select item).FirstOrDefault();
            ban.TINHTRANG = "Có khách";
            btn.BackColor = Color.OrangeRed;
            ql.SubmitChanges();
        }
        public string LayMaHD(string ban)
        {
            HOADON hd = (from item in ql.HOADONs where item.TINHTRANG == "Chưa thanh toán" select item).FirstOrDefault();
            string ma = (from h in ql.HOADONs
                         where h.TINHTRANG == "Chưa thanh toán" && h.TENBAN == ban
                         select h.MAHD).FirstOrDefault();

            return ma;

        }
        public void Load_CTHD(string maban, DataGridView dataGridView)// load chi tiết hóa đơn khi nhấn vào bàn 
        {
            dataGridView.DataSource = null;
            string mahd = LayMaHD(maban);
            var cthd = (from item in ql.CTHOADONs
                        join sp in ql.MENUs on item.MASP equals sp.MASP
                        where item.MAHD == mahd
                        select new
                        {
                            TENSP = sp.TENSP,
                            SOLUONG = item.SOLUONG,
                            TONGTIEN = item.SOTIEN
                        }).ToList();
            dataGridView.DataSource = cthd;
        }
        public void Add_CTHD(string maban, string masp, int soluong)
        {
            string mahd = LayMaHD(maban);

            CTHOADON ct = new CTHOADON();
            MENU menu = (from sp in ql.MENUs where sp.MASP == masp select sp).FirstOrDefault();
            if (soluong > menu.SOLUONG)
            {
                MessageBox.Show("Số lượng trong kho không còn đủ");
            }
            else if(KiemTraKhoaNgoaiHoaDon(mahd,masp))
            {
                float tongtien = (float)soluong * (float)menu.GIA;
                ct = ql.CTHOADONs.Where(t => t.MAHD == mahd && t.MASP == masp).FirstOrDefault();
                ct.SOLUONG = ct.SOLUONG + soluong;
                ct.SOTIEN = ct.SOTIEN + tongtien;
                ql.SubmitChanges();
                UpdateSLMon(masp, soluong);
            }
            else
            {
                float tongtien = (float)soluong * (float)menu.GIA;
                ct.MAHD = mahd;
                ct.MASP = masp;
                ct.SOLUONG = soluong;
                ct.SOTIEN = tongtien;
                ql.CTHOADONs.InsertOnSubmit(ct);
                ql.SubmitChanges();
                UpdateSLMon(masp, soluong);
                MessageBox.Show("Thành công");
            }

        }
        public int tong(string mahd) //trả về tổng tiền hóa đơn
        {
            int tongSoLuong = (int)(ql.CTHOADONs.Where(ct => ct.MAHD == mahd).Sum(ct => ct.SOTIEN) ?? 0);
            return tongSoLuong;

        }
        public void CapNhatHoaDon(string mahd, int tong)// khi thanh toán cập nhật tổng tiền và tình trạng hóa đơn
        {
            HOADON hd = (from item in ql.HOADONs where item.MAHD == mahd select item).FirstOrDefault();
            hd.GIODI = DateTime.Now;
            hd.TONGTIEN = tong;
            hd.TINHTRANG = "Đã thanh toán";
            ql.SubmitChanges();
        }
        //cập nhật lại tình trạng bàn là Trống
        public void CapNhatBan(string maban)
        {
            BAN ban = (from item in ql.BANs where item.TENBAN == maban select item).FirstOrDefault();
            ban.TINHTRANG = "Trống";
            ql.SubmitChanges();
        }
        public void ReLoadBan(FlowLayoutPanel panel)
        {

            foreach (var item in Ds_Ban())
            {
                Button btn = new Button();

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
                panel.Controls.Add(btn);


            }


        }
        //update lại hóa đơn khi chuyển bàn
        public void ChuyenBan(string macu, string mamoi, string mahd)
        {
            HOADON hd = (from item in ql.HOADONs where item.MAHD == mahd select item).FirstOrDefault();
            hd.TENBAN = mamoi;
            ql.SubmitChanges();

        }
        // cập nhật trạng thái bàn là có khách
        public void CapNhatBanCoKhach(string ma)
        {
            BAN ban = (from item in ql.BANs where item.TENBAN == ma select item).FirstOrDefault();
            ban.TINHTRANG = "Có khách";
            ql.SubmitChanges();
        }
        // Trừ số lượng món khi thêm vào chi tiết hóa đơn
        public void UpdateSLMon(string mamon, int soluong)
        {
            MENU mENU = (from item in ql.MENUs where item.MASP == mamon select item).FirstOrDefault();
            mENU.SOLUONG = mENU.SOLUONG - soluong;
            ql.SubmitChanges();

        }
        //Bool trạng thái bàn
        public bool TrangThaiBan(string maban)
        {
            BAN ban = (from item in ql.BANs where item.TENBAN == maban select item).FirstOrDefault();
            if (ban.TINHTRANG == "Có khách")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Gộp bàn
        public void GopBan(string mahd, string maban)
        {
            string hdbangop = LayMaHD(maban);
            foreach (var hoadonbd in ct_HoaDon(mahd))
            {

            }

        }
        public bool KiemTraKhoaChinhHoaDon(string maHD)
        {
            return ql.HOADONs.Any(b => b.MAHD == maHD);
        }
        public bool KiemTraKhoaNgoaiHoaDon(string maHD,string maSP)
        {
            return ql.CTHOADONs.Any(ct => ct.MAHD == maHD && ct.MASP == maSP);
        }
    }
}
