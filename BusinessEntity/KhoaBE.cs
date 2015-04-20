using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessData;
using System.Data;

namespace BusinessEntity
{
   public class KhoaBE
    {
        DataConnect kn = new DataConnect();

        public DataTable ShowKhoa()
        {
            string sql = " select  * from tbl_KHOA";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public void InsertKhoa(string maKhoa, string tenKhoa, string sdt, string email, string diaChi)
        {
            string sql = " INSERT INTO tbl_KHOA VALUES ('" + maKhoa + "', N'" + tenKhoa + "', '" + sdt + "','" + email + "', N'" + diaChi + "') ";
            kn.ExcuteNonQuery1(sql);
        }
        public void UpdateKhoa(string madk, string maKhoa, string tenKhoa,  string sdt, string email, string diaChi)
        {
            string sql = " Update tbl_KHOA SET MaKhoa ='" + maKhoa + "', TenKhoa =N'" + tenKhoa + "', SDT='" + sdt + "', Email ='" + email + "' , DiaChi =N'" + diaChi + "' WHERE MaKhoa ='" + madk + "' ";
            kn.ExcuteNonQuery1(sql);
        }
        public void DeleteKhoa(string maKhoa)
        {
            string sql = "delete tbl_Khoa where MaKhoa = '" + maKhoa + "' ";
            kn.ExcuteNonQuery1(sql);
        }
        public DataTable GetkhByIdMaKhoa(string key)
        {

            string sql = " select Distinct kh.Makh,kh.Tenkh,kh.GioiTinh,kh.SDT, kh.DiaChi, kh.Email ,kh.NgaySinh,kh.MaLop from tbl_KHOA  kh ,tbl_LOP lp "
                            + " Where kh.MaLop = lp.MaLop and kh.MaLop like N'%" + key + "%' ";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public DataTable GetKhoaByTenKhoa(string key)
        {
            string sql = " select Distinct kh.Makh,kh.Tenkh,kh.GioiTinh,kh.SDT,kh.DiaChi, kh.Email ,kh.NgaySinh,kh.MaLop from tbl_SINHVIEN  kh ,tbl_LOP lp "
                             + " Where kh.MaLop = lp.MaLop and lp.TenLop like N'%" + key + "%' ";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
    }
}
