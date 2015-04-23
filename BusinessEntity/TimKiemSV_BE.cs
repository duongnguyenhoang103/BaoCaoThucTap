using AccessData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public  class TimKiemSV_BE
    {
        DataConnect kn = new DataConnect();
        public DataTable ShowData()
        {
            string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and sv.MaLop = '' and MaSV = '' ";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
        public DataTable GetSVByIdMaLop(string key)
        {

            if (key =="")
            {
                string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                            + " Where sv.MaLop = lp.MaLop and sv.MaLop = ''  ";
                DataTable dt = new DataTable();
                dt = kn.GetTable(sql);
                return dt;
            }
            else
            {
                string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                        + " Where sv.MaLop = lp.MaLop and sv.MaLop like N'%" + key + "%'  ";
                DataTable dt = new DataTable();
                dt = kn.GetTable(sql);
                return dt;  
            }
          
        }

        public DataTable GetSV(string maL, string maSV)
        {
            string sql = string.Empty;
            if (maL == "" && maSV == "")
            {
                sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and sv.MaLop = ''  ";
            }
            else if (maL != "" && maSV != "")
            {
                sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and sv.MaLop = '"+maL+"'  and sv.MaSV ='"+maSV+"' ";
            }
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }
    }
}
