using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQuanLyQuanCafe.Models
{
    public class DonDat
    {
        string maphieudat;
        string sdt;
        DateTime ngaylap;
        DateTime gioden;
        string tinhtrang;
        int songuoi;
        public DonDat(string sdt,DateTime gioden,int songuoi)
        {
            this.Sdt = sdt;
            this.Ngaylap = DateTime.Now;
            this.Gioden = gioden;
            this.Songuoi = songuoi;
            this.Tinhtrang = "Đang chờ";
            DateTime now = DateTime.Now;
           string maso= "DD" + now.Day.ToString()
                   + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
            this.Maphieudat = maso;
        }

        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public DateTime Gioden { get => gioden; set => gioden = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Maphieudat { get => maphieudat; set => maphieudat = value; }
        public int Songuoi { get => songuoi; set => songuoi = value; }
    }
}