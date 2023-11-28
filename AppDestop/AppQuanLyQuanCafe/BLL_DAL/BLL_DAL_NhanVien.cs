using AppQuanLyQuanCafe;
using BLL_DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_NhanVien
    {
        QL_COFFEDataContext ql = new QL_COFFEDataContext();
        MaHoaPassword mh = new MaHoaPassword();
        public BLL_DAL_NhanVien()
        {

        }
        public List<NhanVienDTO> loadDataNhanVien()
        {
            List<NhanVienDTO> lst = ql.NHANVIENs.Select(t => new NhanVienDTO 
            { 
                SDT = t.SDT,
                MAQ = t.MAQ,
                HOTEN = t.HOTEN,
                GIOITINH = t.GIOITINH,
                EMAIL = t.EMAIL,
                DIACHI = t.DIACHI,
                PASSNV = t.PASSNV,
                NGAYSINH = t.NGAYSINH,
                TINHTRANG = t.TINHTRANG
            })
            .ToList();
            return lst;
        }
        public void themNhanVien(NHANVIEN nv)
        {
            ql.NHANVIENs.InsertOnSubmit(nv);
            ql.SubmitChanges();
        }
        public void xoaNhanVien(string sdt)
        {
            NHANVIEN kh = ql.NHANVIENs.Where(t => t.SDT == sdt).FirstOrDefault();
            ql.NHANVIENs.DeleteOnSubmit(kh);
            ql.SubmitChanges();
        }
        public void suaNhanVien(string sdt, NHANVIEN nv)
        {
            NHANVIEN nhanvien = ql.NHANVIENs.Where(t => t.SDT == sdt).FirstOrDefault();
            nhanvien.MAQ = nv.MAQ;
            nhanvien.HOTEN = nv.HOTEN;
            nhanvien.GIOITINH = nv.GIOITINH;
            nhanvien.EMAIL = nv.EMAIL;
            nhanvien.DIACHI = nv.DIACHI;
            nhanvien.PASSNV = nv.PASSNV;
            nhanvien.NGAYSINH = nv.NGAYSINH;
            nhanvien.TINHTRANG = nv.TINHTRANG;
            ql.SubmitChanges();
        }
        public NHANVIEN DangNhap(string user, string pass)
        {
            string password = mh.Encrypt(pass);

            NHANVIEN kt = ql.NHANVIENs
                .Where(nv => nv.SDT == user && nv.PASSNV == password)
                .FirstOrDefault();
            if (kt != null)
                return kt;
            else
                return null;
        }
    }
}
